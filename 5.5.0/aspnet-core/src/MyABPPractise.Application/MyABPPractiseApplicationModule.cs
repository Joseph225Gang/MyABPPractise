using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPPractise.Authorization;

namespace MyABPPractise
{
    [DependsOn(
        typeof(MyABPPractiseCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyABPPractiseApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyABPPractiseAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyABPPractiseApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
