using System.Threading.Tasks;
using EndlessShop.Models.TokenAuth;
using EndlessShop.Web.Controllers;
using Shouldly;
using Xunit;

namespace EndlessShop.Web.Tests.Controllers
{
    public class HomeController_Tests: EndlessShopWebTestBase
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