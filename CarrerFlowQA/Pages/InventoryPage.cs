using Microsoft.Playwright;
using System.Threading.Tasks;
//using NUnit.Framework;

namespace CareerflowQA.Pages
{
    public class InventoryPage : BasePage
    {
        public InventoryPage(IPage page) : base(page) { }

        public async Task ValidateInventoryLoadedAsync()
        {
            var isVisible = await page.Locator(".inventory_list").IsVisibleAsync();
            Assert.IsTrue(isVisible, "Inventory page did not load");
        }

        public async Task AddItemToCartAsync()
        {
            await page.ClickAsync(".inventory_item button");
        }

        public async Task GoToCartAsync()
        {
            await page.ClickAsync(".shopping_cart_link");
        }
    }
}