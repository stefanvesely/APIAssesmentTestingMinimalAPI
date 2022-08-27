﻿using Microsoft.OpenApi.Models;
using APIAssesment.MappingClasses;

namespace APIAssesment.EndpointDefs
{
    public class SwaggerEndPointDef : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DotnetDocsShow.Structured.Custom v1"));
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DotnetDocsShow.Structured.Custom", Version = "v1" });
            });
        }
    }
}
