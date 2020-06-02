using System.Threading.Tasks;
using MyABPPractise.Models.TokenAuth;
using MyABPPractise.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyABPPractise.Web.Tests.Controllers
{
    public class HomeController_Tests: MyABPPractiseWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}