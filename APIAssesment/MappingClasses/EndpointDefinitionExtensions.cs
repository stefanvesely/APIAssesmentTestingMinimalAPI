namespace APIAssesment.MappingClasses
{
    public static class EndpointDefinitionExtensions
    {
        public static void EndPointDefinitions(this IServiceCollection services, params Type[] scanMarkers)
        {
            var endpointdefs = new List<IEndpointDefinition>();
            foreach (var marker in scanMarkers)
            {
                endpointdefs.AddRange(
                    marker.Assembly.ExportedTypes
                        .Where(x => typeof(IEndpointDefinition).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                        .Select(Activator.CreateInstance).Cast<IEndpointDefinition>()
                );
            }
            foreach (var endpointDefinition in endpointdefs)
            {
                endpointDefinition.DefineServices(services);
            }
            services.AddSingleton(endpointdefs as IReadOnlyCollection<IEndpointDefinition>);
        }

        public static void UseEndpointDefinitions(this WebApplication app)
        {
            var definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndpointDefinition>>();

            foreach (var endpointDefinition in definitions)
            {
                endpointDefinition.DefineEndpoints(app);
            }
        }
    }
}
