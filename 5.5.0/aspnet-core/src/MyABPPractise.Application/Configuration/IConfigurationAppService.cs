using System.Threading.Tasks;
using MyABPPractise.Configuration.Dto;

namespace MyABPPractise.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
