using Microsoft.Playwright;
using System.Threading.Tasks;
//using NUnit.Framework;

namespace CareerflowQA.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IPage page) : base(page) { }

        public async Task CompleteCheckoutAsync()
        {
            await page.ClickAsync("#checkout");

            await page.FillAsync("#first-name", "Shivam");
            await page.FillAsync("#last-name", "Tomar");
            await page.FillAsync("#postal-code", "201001");

            await page.ClickAsync("#continue");
            await page.ClickAsync("#finish");
        }

        public async Task ValidateOrderSuccessAsync()
        {
            var text = await page.InnerTextAsync(".complete-header");
            Assert.AreEqual("Thank you for your order!", text);
        }
    }
}