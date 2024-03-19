using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EndlessShop.Authorization.Roles;
using EndlessShop.Authorization.Users;
using EndlessShop.MultiTenancy;

namespace EndlessShop.EntityFrameworkCore
{
    public class EndlessShopDbContext : AbpZeroDbContext<Tenant, Role, User, EndlessShopDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EndlessShopDbContext(DbContextOptions<EndlessShopDbContext> options)
            : base(options)
        {
        }
    }
}
