using Microsoft.Playwright;
using System.Threading.Tasks;

namespace CareerflowQA.Utils
{
    public class PlaywrightFactory
    {
        public static async Task<IPage> InitAsync()
        {
            var playwright = await Playwright.CreateAsync();

            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            var context = await browser.NewContextAsync();
            return await context.NewPageAsync();
        }
    }
}