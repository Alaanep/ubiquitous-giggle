using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryCodeFinder countryCodeFinder = new CountryCodeFinder();
            Console.WriteLine(countryCodeFinder.GetCountryInfo("37256241779"));
            Console.WriteLine(countryCodeFinder.GetCountryInfo("+372ABC"));
            Console.WriteLine(countryCodeFinder.GetCountryInfo("+1234556"));
            Console.WriteLine(countryCodeFinder.GetCountryInfo("+12462567"));
            Console.WriteLine(countryCodeFinder.GetCountryInfo("+12684567"));

        }
    }
}
