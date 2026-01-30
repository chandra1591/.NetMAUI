using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MyMAUIApp.Api
{
    public class AddBearerAuth : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            
            // Skip if [AllowAnonymous] is applied
            var allowAnonymous = context.MethodInfo?.GetCustomAttributes(true)
                                   .OfType<AllowAnonymousAttribute>().Any() == true;


            var endpointMetadata = context.ApiDescription.ActionDescriptor.EndpointMetadata;

            // Check if method or controller has [Authorize]
            bool requiresAuth = endpointMetadata.OfType<IAuthorizeData>().Any() &&
                           !endpointMetadata.OfType<IAllowAnonymous>().Any();



            if (!requiresAuth && !allowAnonymous)
                return;  // public endpoint, do not add lock


            operation.Security ??= new List<OpenApiSecurityRequirement>();

            operation.Security.Add(new OpenApiSecurityRequirement
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

        }
    }
}