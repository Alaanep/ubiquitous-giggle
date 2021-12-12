using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX1;


namespace TestCountryCode
{
    [TestClass]
    public class UnitTest1
    {
        CountryCodeFinder countryCodeFinder;

        [TestInitialize]
        public void TestInitialize()
        {
            countryCodeFinder = new CountryCodeFinder();
        }

        
        
    }
}
