using Application.Common.Behaviors;
using Microsoft.Extensions.DependencyInjection;




namespace MrntorsClone.Application.DependencyInjection;

public static class DependencyInjectionAddApplication
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(ApplicationAssemblyMarker).Assembly;


        // MediatR
        services.AddMediatR(cfg =>
        cfg.RegisterServicesFromAssembly(assembly));


        // FluentValidation
        services.AddValidatorsFromAssembly(assembly);


        // Pipeline Behaviors
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehavior<,>));



        return services;
    }
}
