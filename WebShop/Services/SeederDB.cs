using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using WebShop.Data;
using WebShop.Data.Entities;

namespace WebShop.Services
{
    public static class SeederDB
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            using(var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<MyAppContext>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<UserEntity>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<RoleEntity>>();
                
                context.Database.Migrate();

                if(!context.Categories.Any())
                {
                    string[] categories = { "Ноутбуки", "Монітори", "Одяг" };
                    foreach(var name in categories)
                    {
                        CategoryEntity cat = new CategoryEntity
                        {
                            Name = name
                        };
                        context.Categories.Add(cat);
                        context.SaveChanges();
                    }
                }
                
            }
        }
    }
}
