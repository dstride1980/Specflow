using OpenQA.Selenium;
using RedTarn.Selenium.Core.Bootstrap.Contexts.Interfaces;

namespace RedTarn.Selenium.Core.XUnitExample.UI
{
    public class CompanyDetailsPage : BaseUIItem
    {
        public CompanyDetailsPage(IContext context) : base(context, By.Id("page-container"))
        {
        }
    }
}
