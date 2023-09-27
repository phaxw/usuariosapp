namespace usuariosapp;
public static class DependencyInjection
{
    // Add services to the container.
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}
