using Microsoft.Playwright;

namespace CareerflowQA.Pages
{
    public class BasePage
    {
        protected readonly IPage page;

        public BasePage(IPage page)
        {
            this.page = page;
        }
    }
}