using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX4;
namespace EX4Tests
{
    [TestClass]
    public class UnitTest1
    {
        DomainInfo domainInfo;

        [TestInitialize]
        public void TestInitialize() {
            domainInfo = new DomainInfo();
        }


        [TestMethod]
        public void TestAreEqual_FindUserNameAndDomain_juhanjuurikasatcompanyeu_Juhan_Juurikas_Company()
        {
            string result = domainInfo.FindUserNameAndDomain("juhan.juurikas@company.eu");
            string expected = "Name: Juhan Juurikas Domain: Company";
            Assert.AreEqual(expected, result);
            
        }

        [TestMethod]
        public void TestAreEqual_FindUserNameAndDomain_company_juhan_juurikas_Juhan_Juurikas_Company()
        {
            string result = domainInfo.FindUserNameAndDomain("company/juhan.juurikas");
            string expected = "Name: Juhan Juurikas Domain: Company";
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAreNotEqual_FindUserNameAndDomain_company_juhan_juurikas_Juhan_Juurikas_Company()
        {
            string result = domainInfo.FindUserNameAndDomain("company@juhan.juurikas");
            string expected = "Name: Juhan Juurikas Domain: Company"; ;
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestAreNotEqual_FindUserNameAndDomain_juhan_juurikas_Juhan_Juurikas_Company()
        {
            string result = domainInfo.FindUserNameAndDomain("juhan.juurikas");
            string expected = "Name: Juhan Juurikas Domain: Company"; ;
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestAreEqual_GenerateEmailAccount_juhan_juurikas_company_juhan_juurikas_at_company_eu()
        {
            string result = domainInfo.GenerateEmailAccount("juhan juurikas company");
            string expected = "juhan.juurikas@company.eu";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAreEqual_GenerateEmailAccount_juhan_märt_juurikas_company_juhanmart_juurik_at_company_eu()
        {
            string result = domainInfo.GenerateEmailAccount("juhan märt juurikas company");
            string expected = "juhanmart.juurik@company.eu";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAreNotEqual_GenerateEmailAccount_juhan_märt_juhanmart_juurik_at_company_eu()
        {
            string result = domainInfo.GenerateEmailAccount("juhan märt");
            string expected = "juhan.mart@company.eu";
            Assert.AreNotEqual(expected, result);
        }


        [TestMethod]
        public void TestAreEqual_GenerateDomainAccount_juhan_juurikas_company_company_juhan_juurikas()
        {
            string result = domainInfo.GenerateDomainAccount("juhan juurikas company");
            string expected = "company/juhan.juurikas";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAreEqual_GenerateDomainAccount_juhan_märt_juurikas_company_company_juhanmart_juurik()
        {
            string result = domainInfo.GenerateDomainAccount("juhan märt juurikas company");
            string expected = "company/juhanmart.juurik";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAreNotEqual_GenerateDomainAccount_juhan_märt_juurikas_company_juhanmart_juurik()
        {
            string result = domainInfo.GenerateDomainAccount("juhan märt juurikas");
            string expected = "company/juhanmart.juurik";
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestAreEqual_GenerateUserName_juhan_märt_juurikas_juhanmart_juurik()
        {
            string result = domainInfo.GenerateUserName("juhan märt juurikas");
            string expected = "juhanmart.juurik";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAreNotEqual_GenerateUserName_juhan_juurikas_company_juhanjuurikas_co()
        {
            string result = domainInfo.GenerateUserName("juhan märt juurikas");
            string expected = "juhanjuurikas.co";
            Assert.AreNotEqual(expected, result);
        }

    }
}
