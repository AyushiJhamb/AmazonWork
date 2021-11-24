using AmazonWork.Locators;
using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace AmazonWork.Modules
{
   public class Home_Page : Common_Page
    {
        protected static ExtentTest Test;
        public Home_Page() : base()
        {
        }
        public void VerifyContentCanBeSearched(string valueSearch)
        {
            _SeleniumCommonActions.WaitForPageLoad();
            By searchInputBox = By.CssSelector(HomePage_Locators.inputBoxByCss);
            _SeleniumCommonActions.CLearAndTyeKeys(searchInputBox,valueSearch);
            //Test.Log(Status.Pass, searchInputBox + "is entered to with"+ valueSearch+"to get searched");
            By searchButton = By.CssSelector(HomePage_Locators.searchBoxByCss);
            _SeleniumCommonActions.ClickElement(searchButton);
            //Test.Log(Status.Pass, searchButton+ "is clicked");
           
        }

        public bool VerifyPosterPresent()
        {
           By verifyPoster = By.CssSelector(HomePage_Locators.verifyPosterByCss);
            return _SeleniumCommonActions.IsDisplayed(verifyPoster);
        }


    }
}
