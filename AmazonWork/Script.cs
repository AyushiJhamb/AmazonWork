using AmazonWork.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonWork
{
    [TestClass]
    public class Script : BaseTest
    {
        Home_Page _HomePage;
       
        [ClassInitialize]
        public static void ClassInitialization(TestContext context)
        {
            OneTimeSetUp(context);
        }

        [TestInitialize]
        public void TestInitializtion()
        {
            _HomePage = new Home_Page();
        }

        [TestMethod]
        public void searchTestCase()
        {
            _HomePage.VerifyContentCanBeSearched("java");
        }

        [TestMethod]
        public void verifyHomePagePosterTestCase()
        {
            _HomePage.VerifyPosterPresent();
        }

       
        [ClassCleanup()]
        public static void ClassCleanUp()
        {
            OneTimeTearDown();
            //ExtentReportUtility.ClassClean; No need already called above
        }
    }
}
