using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;

namespace MyMAUIApp.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddAuthorization();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "MyMAUIApp API",
                    Version = "v1"
                });
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter JWT token like: {your token}"
                });
                options.OperationFilter<AddBearerAuth>();
            });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowAnyOrigin()); // Note: AllowAnyOrigin + AllowCredentials() is NOT allowed
            });

            var dbPath = Path.Join(Directory.GetCurrentDirectory(), "Carlist.db");

            //var connectionString = new SqliteConnection(dbPath);
            //builder.Services.AddDbContext<CarListDbContext>(options => options.UseSqlite(conn));
            //var connectionString = $"E:\\MAUI\\MyMAUIApp.Api\\Carlist.db";

            //var dbPath = Path.Combine(AppContext.BaseDirectory, "Carlist.db");
            var connectionString = $"Data Source={dbPath}";

            builder.Services.AddDbContext<CarListDbContext>(options =>
                options.UseSqlite(connectionString));


            builder.Services.AddIdentityCore<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<CarListDbContext>()
                .AddDefaultTokenProviders();


            // JWT Authentication
            var jwtKey = builder.Configuration["JwtSettings:Key"];
            var jwtIssuer = builder.Configuration["JwtSettings:Issuer"];
            var jwtAudience = builder.Configuration["JwtSettings:Audience"];
            var expiresMinutes = builder.Configuration["JwtSettings:DurationInMinutes"];

            builder.Services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtIssuer,
                    ValidAudience = jwtAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
                    ClockSkew = TimeSpan.Zero,
                };
            });

            // Authorization: fallback policy
            builder.Services.AddAuthorizationBuilder()
                .SetFallbackPolicy(new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build()
                );
            var app = builder.Build();

            // Create Database
            using (var scope = app.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<CarListDbContext>())
            {
                context.Database.Migrate();
            }
           
            // Swagger
            app.UseSwagger();
            app.UseSwaggerUI();


            // Middleware
            app.UseHttpsRedirection();
            app.UseCors("AllowAll");
            app.UseAuthentication();
            app.UseAuthorization();

            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    {
                        
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = summaries[Random.Shared.Next(summaries.Length)]
                    })
                    .ToArray();
                return forecast;
            }).AllowAnonymous();

            app.MapGet("/cars", async (CarListDbContext db) => await db.Cars.ToListAsync())
                .RequireAuthorization();

            //.WithOpenApi(op => AddBearerSecurity(op));

            app.MapGet("/cars/{id}", async (CarListDbContext db, int id) =>
                await db.Cars.FindAsync(id) is Car car ? Results.Ok(car) : Results.NotFound()
            ).RequireAuthorization(); //.WithOpenApi(op => AddBearerSecurity(op)); == Authoriztion bearer 

            app.MapPut("/cars/{id}", async (CarListDbContext db, Car car, int id) =>
            {
                var record = await db.Cars.FindAsync(id);
                if (record is null) return Results.NotFound();

                record.Make = car.Make;
                record.Model = car.Model;
                record.Vin = car.Vin;

                await db.SaveChangesAsync();

                //return Results.NoContent();
                return Results.Ok(new
                {
                    message = "Car updated successfully.",
                    updatedCar = record
                });
            }).RequireAuthorization();



            app.MapDelete("/cars/{id}", async (CarListDbContext db, int id) =>
            {
                var record = await db.Cars.FindAsync(id);
                if (record is null) return Results.NotFound();

                db.Remove(record);

                await db.SaveChangesAsync();

               // return Results.NoContent();
                return Results.Ok(new
                {
                    message = "Car deleted successfully.",
                    updatedCar = record
                });

            }).RequireAuthorization();

            app.MapPost("/cars", async (CarListDbContext db, Car car) =>
            {
                await db.AddAsync(car);

                await db.SaveChangesAsync();

                return Results.Created($"/cars/{car.Id}", car);

            }).RequireAuthorization();

            app.MapPost("/resetPassword", async (ResetPasswordRequest request, UserManager<IdentityUser> _userManager) =>
            {

                if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
                    return Results.BadRequest("Username and password must be provided.");


                var user = await _userManager.FindByEmailAsync(request.Username);
                if (user == null)
                    return Results.NotFound($"User '{request.Username}' not found.");

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                var result = await _userManager.ResetPasswordAsync(user, token, request.Password);

                if (!result.Succeeded)
                {
                    // Return all error messages from Identity
                    var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                    return Results.BadRequest($"Password reset failed: {errors}");
                }

                return Results.Ok("Password reset successfully.");

            }).AllowAnonymous();

            app.MapPost("/login", async (LoginDto logindto, UserManager<IdentityUser> _userManager) =>
             {
                 var user = await _userManager.FindByNameAsync(logindto.Username);


                 if (user != null && await _userManager.CheckPasswordAsync(user, logindto.Password))
                 {

                 // Generate Acceess Token
                     var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
                     var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                     var roles = await _userManager.GetRolesAsync(user);
                     var claims = await _userManager.GetClaimsAsync(user);

                     var tokenClaims = new List<Claim>
                     {
                         new (JwtRegisteredClaimNames.Sub,user.Id),
                         new (JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                         new (ClaimTypes.Email,user.Email ?? string.Empty),
                         //new (JwtRegisteredClaimNames.Email,user.Email ?? string.Empty),
                         new ("email_confirmed",user.EmailConfirmed.ToString()),

                     }.Union(claims)
                     .Union(roles.Select(role => new Claim(ClaimTypes.Role, role)));

                     var securityToken = new JwtSecurityToken(
                         issuer: jwtIssuer,
                         audience: jwtAudience,
                         claims: tokenClaims,
                         expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(expiresMinutes)),
                         signingCredentials: credentials
                     );

                     var accessToken = new JwtSecurityTokenHandler().WriteToken(securityToken);

                    
                     var response = new AuthResponseDto
                     {
                         UserId = user.Id,
                         Username = user.UserName!,
                         Token = accessToken
                     };
                    
                     return Results.Ok(response);

                     // return Results.Ok("Login Successful");
                 }
                 return Results.Unauthorized();

             }).AllowAnonymous();


            app.Run();
        }

        private static OpenApiOperation AddBearerSecurity(OpenApiOperation op)
        {
            op.Security.Add(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                               Type = ReferenceType.SecurityScheme,
                               Id = "Bearer"
                        },
                        Scheme = "Bearer",
                        Name = "Bearer",
                        In = ParameterLocation.Header
                    },
                    Array.Empty<string>()
                }
            });
            return op;
        }

        internal class LoginDto
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        internal class AuthResponseDto
        {
            public string UserId { get; set; }
            public string Username { get; set; }
            public string Token { get; set; }
        }
    }
}
