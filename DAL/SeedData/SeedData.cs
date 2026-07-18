using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DAL.SeedData
{
    public class SeedData
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public SeedData(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task SeedRolesAsync()
        {
            string[] Roles = { "Admin", "Customer" };
            foreach (var role in Roles)
            {
                if (!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
