using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPPractise.EntityFrameworkCore;
using MyABPPractise.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyABPPractise.Web.Tests
{
    [DependsOn(
        typeof(MyABPPractiseWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyABPPractiseWebTestModule : AbpModule
    {
        public MyABPPractiseWebTestModule(MyABPPractiseEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPPractiseWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyABPPractiseWebMvcModule).Assembly);
        }
    }
}