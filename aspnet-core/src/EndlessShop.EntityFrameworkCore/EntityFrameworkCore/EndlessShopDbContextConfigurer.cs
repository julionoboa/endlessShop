using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EndlessShop.EntityFrameworkCore
{
    public static class EndlessShopDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EndlessShopDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EndlessShopDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
