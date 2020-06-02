using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPPractise.Configuration;

namespace MyABPPractise.Web.Host.Startup
{
    [DependsOn(
       typeof(MyABPPractiseWebCoreModule))]
    public class MyABPPractiseWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyABPPractiseWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPPractiseWebHostModule).GetAssembly());
        }
    }
}
