using CareerflowQA.Pages;
using Microsoft.Playwright;

namespace CarrerFlowQA.Tests
{
    [TestClass]
    public class Test1 : PageTest
    {
        private IPage page;
        [TestMethod]

        public async Task EndToEndCheckoutTest()
        {
            var loginPage = new LoginPage(page);
            var inventoryPage = new InventoryPage(page);
            var checkoutPage = new CheckoutPage(page);

            await loginPage.NavigateAsync();
            await loginPage.LoginAsync("standard_user", "secret_sauce");

            await inventoryPage.ValidateInventoryLoadedAsync();
            await inventoryPage.AddItemToCartAsync();
            await inventoryPage.GoToCartAsync();

            await checkoutPage.CompleteCheckoutAsync();
            await checkoutPage.ValidateOrderSuccessAsync();
        }
    }
    
}
