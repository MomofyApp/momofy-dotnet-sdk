using Microsoft.Extensions.DependencyInjection;

namespace Momofy.NET;
public static class MomofyService
{
    public static void AddMomofy(this IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddScoped<IMomofyClient, MomofyClient>();
    }
}
