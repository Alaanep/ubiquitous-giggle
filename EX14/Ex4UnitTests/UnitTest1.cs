using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX4;

namespace Ex4UnitTests
{
    
    [TestClass]
    public class UnitTest1
    {
        public EmailUtility emailUtility;

        [TestInitialize]
        public void TestInitialize()
        {
            emailUtility = new EmailUtility();
        }

        [TestMethod]
        public void ValidateEmailAddress_IfContains_Atsign_Alar_Test()
        {
           bool result= emailUtility.ValidateEmailAddress("Alar");
           Assert.IsFalse(result);
        }
        public void ValidateEmailAddress_IfContains_Atsign_karukeelatsign_Test()
        {
            bool result = emailUtility.ValidateEmailAddress("karukeel@");
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void ValidateEmailAddress_IfEmaillengtisatleast_5_Alar_Test()
        {
            bool result = emailUtility.ValidateEmailAddress("Alar");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ValidateEmailAddress_IfEmaillengtisatleast_5_Alatmeco_Test()
        {
            bool result = emailUtility.ValidateEmailAddress("A@m.co");
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void ValidateEmailAddress_IfDomainname_exist_Alaratsign_Test()
        {
            bool result = emailUtility.ValidateEmailAddress("alarlaanep@gmail.com");
            Assert.IsTrue(result);
        }

        

    }
}
