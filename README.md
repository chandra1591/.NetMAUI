# DotNet MAUIApp
## .NET MAUI CRUD Application Overview

This project is a cross-platform CRUD (Create, Read, Update, Delete) application built using .NET MAUI and follows the MVVM (Model–View–ViewModel) architectural pattern.
The app supports offline data storage using a local database and online synchronization using a Web API service.

It is designed to run on Android, iOS, Windows, and macOS from a single codebase

## Architecture
The application follows MVVM, which ensures clean separation of concerns:
- **Model** – Represents data and business logic.
- **View** – The user interface (UI) components . UI (XAML pages).
- **ViewModel** – Acts as a bridge between the Model and View, handling data binding and commands.

## Benefits:
- Improved testability
- Enhanced maintainability
- Separation of UI and business logic
- Easier collaboration among developers and designers

## Features
- ✔️ Create, Read, Update, Delete (CRUD) operations
- ✔️ Local database support (offline mode)
- ✔️ Web API integration (online mode)
- ✔️ MVVM architecture
- ✔️ Data binding & commands
- ✔️ Dependency Injection
- ✔️ Cross-platform support

## Screens
<img width="320" height="568" alt="Screenshot_1769774667" src="https://github.com/user-attachments/assets/12d81a4e-bd7b-4c21-8486-2ecb375f9694" />
<img width="320" height="568" alt="Screenshot_1769774704" src="https://github.com/user-attachments/assets/8b8fa625-de41-4c09-841b-e2e1517d615a" />
<img width="320" height="568" alt="Screenshot_1769412871" src="https://github.com/user-attachments/assets/b616336c-0499-4b2c-9353-ad16fa30e7af" />
<img width="320" height="568" alt="Screenshot_1769412881" src="https://github.com/user-attachments/assets/23e457a5-3df7-4a01-b2b8-9f0ebadb7a01" />
<img width="320" height="568" alt="Screenshot_1769412904" src="https://github.com/user-attachments/assets/f1299d2f-b930-458c-b351-81686b377036" />

# Web Api Services
- ✔️ Database Migration (Create DB)
- ✔️ JWT Token
1) Appsetting.json
```
"JwtSettings": {
  "Issuer": "CarlistApi",
  "Audience": "MauiApp",
  "DurationInMinutes": 5,
  "Key": "pgNSdmp3FvcAa15FUhYMWBcmGN6eRPEsqKzwHeiXK3i"
},
```
2) Program.cs
```
 var dbPath = Path.Combine(AppContext.BaseDirectory, "Carlist.db");
 var connectionString = $"Data Source={dbPath}";

 builder.Services.AddDbContext<CarListDbContext>(options =>
     options.UseSqlite(connectionString));


 builder.Services.AddIdentityCore<IdentityUser>()
     .AddRoles<IdentityRole>()
     .AddEntityFrameworkStores<CarListDbContext>()
     .AddDefaultTokenProviders();
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
 builder.Services.AddAuthorizationBuilder()
     .SetFallbackPolicy(new AuthorizationPolicyBuilder()
         .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
         .RequireAuthenticatedUser()
         .Build()
     );
  var app = builder.Build();
  
  // Middleware
  app.UseHttpsRedirection();
  app.UseCors("AllowAll");
  app.UseAuthentication();
  app.UseAuthorization();
```
# API
```
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
}).AllowAnonymous(); // not required Authorization

app.MapGet("/cars", async (CarListDbContext db) => await db.Cars.ToListAsync())
    .RequireAuthorization(); // Required Authorization
```
# Create JWT Token
```
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
```
