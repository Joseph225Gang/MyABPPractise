using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyABPPractise.Configuration.Dto;

namespace MyABPPractise.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyABPPractiseAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
