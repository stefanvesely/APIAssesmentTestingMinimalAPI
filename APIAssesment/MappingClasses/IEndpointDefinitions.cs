using Microsoft.AspNetCore.Builder;

namespace APIAssesment.MappingClasses
{
    public interface IEndpointDefinition
    {
        void DefineServices(IServiceCollection services);
        void DefineEndpoints(WebApplication app);
    }

}
