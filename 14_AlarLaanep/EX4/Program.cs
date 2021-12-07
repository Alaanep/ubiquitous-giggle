using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            DomainInfo domainInfo = new DomainInfo();
            Console.WriteLine(domainInfo.FindUserNameAndDomain("juhan.juurikas@company.eu"));
            Console.WriteLine(domainInfo.FindUserNameAndDomain("company/alar.laaneppeeter"));
            Console.WriteLine(domainInfo.GenerateEmailAccount("Juhan Märt juurikas company"));
            Console.WriteLine(domainInfo.GenerateUserName("Jöäään Mrt juurikas company"));
            Console.WriteLine(domainInfo.GenerateDomainAccount("Juhan Märt Juurikas company"));
        }
    }
}
