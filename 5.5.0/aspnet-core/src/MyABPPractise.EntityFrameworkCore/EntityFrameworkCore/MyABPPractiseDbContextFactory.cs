using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyABPPractise.Configuration;
using MyABPPractise.Web;

namespace MyABPPractise.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyABPPractiseDbContextFactory : IDesignTimeDbContextFactory<MyABPPractiseDbContext>
    {
        public MyABPPractiseDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyABPPractiseDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyABPPractiseDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyABPPractiseConsts.ConnectionStringName));

            return new MyABPPractiseDbContext(builder.Options);
        }
    }
}
