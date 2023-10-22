using Microsoft.AspNetCore.Mvc;

namespace LookUp.WebAPI.Extensions;

public static class ApiBehaviorExtension
{
    public static void ConfigureApiBehavior(this IServiceCollection services)
    {
        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });
    }
}