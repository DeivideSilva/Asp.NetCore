using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanches.Data
{
    public static class SeedData
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            //inclui perfis customizados
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            //define os perfis em um array de srings
            string[] roleNames = { "Admin", "Member" };
            IdentityResult roleResult;

            //percorre o array de strings
            //verifica se o perfil já existe
            foreach (var roleName in roleNames)
            {
                //cria perfis e os inclui no banco de dados
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            //cria um super usuário que pode manter a aplicação web
            var poweruser = new IdentityUser
            {
                //obtem o nome  o email do arquivo de configuração
                UserName = configuration.GetSection("UserSettings")["UserName"],
                Email = configuration.GetSection("UserSettings")["UserEmail"]
            };

            //obtem a senha do arquivo de configuração
            string userPassword = configuration.GetSection("UserSettings")["UserPassword"];

            //verifica se existe um usuário com o email informado
            var user = await UserManager.FindByEmailAsync(configuration.GetSection("UserSettings")["UserEmail"]);

            if (user == null)
            {
                //cria o super usuário com os dados informados
                var createPowerUser = await UserManager.CreateAsync(poweruser, userPassword);
                if (createPowerUser.Succeeded)
                {
                    //atribui o usuário ao perfil admin
                    await UserManager.AddToRoleAsync(poweruser, "Admin");
                }
            }

        }
    }
}

