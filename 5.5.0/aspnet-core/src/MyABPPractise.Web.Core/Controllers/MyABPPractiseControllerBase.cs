using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyABPPractise.Controllers
{
    public abstract class MyABPPractiseControllerBase: AbpController
    {
        protected MyABPPractiseControllerBase()
        {
            LocalizationSourceName = MyABPPractiseConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
