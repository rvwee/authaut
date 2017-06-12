using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RubenVanWee.TestData.Entities;

namespace RubenVanWee.TestData.StartupExtensions 
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<UserEntity, IdentityRole>()
                .AddEntityFrameworkStores<EntityContext>();

            

        }
    }

    public static class ApplicationBuilderExensions
    {
        public static void ConfigureIdentity(this IApplicationBuilder app)
        {
            app.UseIdentity();
        }
    }
}