using System;
using Microsoft.Owin;
using Owin;
using JaBak.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

[assembly: OwinStartupAttribute(typeof(JaBak.Startup))]
namespace JaBak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        private void createRolesandUsers()
        {

            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // Creating "fournisseur" role    
            if (!roleManager.RoleExists("fournisseur"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "fournisseur";
                roleManager.Create(role);

            }

            // Creating "client" role    
            if (!roleManager.RoleExists("client"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "client";
                roleManager.Create(role);

            }
        }
    }
}
