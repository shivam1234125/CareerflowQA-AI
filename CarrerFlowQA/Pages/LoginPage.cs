using Microsoft.Playwright;
using System.Threading.Tasks;

namespace CareerflowQA.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IPage page) : base(page) { }

        public async Task NavigateAsync()
        {
            await page.GotoAsync("https://www.saucedemo.com/");
        }

        public async Task LoginAsync(string username, string password)
        {
            await page.FillAsync("#user-name", username);
            await page.FillAsync("#password", password);
            await page.ClickAsync("#login-button");
        }
    }
}