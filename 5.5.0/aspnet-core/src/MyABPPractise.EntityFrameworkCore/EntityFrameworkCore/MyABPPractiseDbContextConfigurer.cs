using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyABPPractise.EntityFrameworkCore
{
    public static class MyABPPractiseDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyABPPractiseDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyABPPractiseDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
