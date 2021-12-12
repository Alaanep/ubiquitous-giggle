using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EX2
{
    public class TrafficAccidentAnalyzer
    {
        
        private Dictionary<string, Dictionary<string, double>> accidents = new Dictionary<string, Dictionary<string, double>>();

        private Dictionary<string, Dictionary<string, double>> deaths = new Dictionary<string, Dictionary<string, double>>();

        public TrafficAccidentAnalyzer()
        {
            accidents.Add("1999", ReadFromFile("1999accidents.txt"));
            accidents.Add("2009", ReadFromFile("2009accidents.txt"));
            accidents.Add("2019", ReadFromFile("2019accidents.txt"));

            deaths.Add("1999", ReadFromFile("1999accidentsDeaths.txt"));
            deaths.Add("2009", ReadFromFile("2009accidentsDeaths.txt"));
            deaths.Add("2019", ReadFromFile("2019accidentsDeaths.txt"));
        }

        private Dictionary<string, double> ReadFromFile(string fileName)
        {
            Dictionary<string, double> dic = new Dictionary<string, double>();
            string[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = "";
                    int i = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            dic.Add(months[i], double.Parse(line));
                            i++;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dic;
        }

        public void FindYearAndMonthWithMostAccidents()
        {
            prettyPrint();
            Console.WriteLine("Year and month with most accidents:");
            double mostAccidents = 0;
            string yearWithMostAccidents = string.Empty;
            string monthWithMostAccidents = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, double>> year in accidents)
            {
                //Console.WriteLine($"Key: {year.Key}, Value: {year.Value}");
                foreach (KeyValuePair<string, double> accident in year.Value)
                {
                    if (accident.Value > mostAccidents)
                    {
                        yearWithMostAccidents = year.Key;
                        monthWithMostAccidents = accident.Key;
                        mostAccidents = accident.Value;
                    }
                    //Console.WriteLine($"Year: {year.Key}, Month: {accident.Key}, Value: {accident.Value}");
                }
            }
            Console.WriteLine($"Most accidents happened in {yearWithMostAccidents} {monthWithMostAccidents} with total of {mostAccidents} accidents.");
            Console.WriteLine();
        }

        public void FindPerctangeOfAccidentsWhichEndWithDeadth()
        {
            prettyPrint();
            Console.WriteLine("Percetange of accidents that end with death for every year and month.");
            string currentYear = string.Empty;
            string currentMonth = string.Empty;
            double accidentCount = 0;
            double deathCount = 0;

            foreach (KeyValuePair<string, Dictionary<string, double>> year in accidents)
            {
                //Console.WriteLine($"Key: {year.Key}, Value: {year.Value}");
                foreach (KeyValuePair<string, double> accident in year.Value)
                {
                    currentYear = year.Key;
                    currentMonth = accident.Key;
                    accidentCount = accident.Value;
                    deathCount = deaths[year.Key][accident.Key];
                    double deathPercentage = (deathCount / accidentCount) * 100;

                    Console.WriteLine($"{currentYear} {currentMonth} Death %: {string.Format("{0:0.00}", deathPercentage)}");
                }
            }
            Console.WriteLine();
        }

        public void FindAverageDeathRatePercentage()
        {
            prettyPrint();
            Console.WriteLine("Average death rate per year and deadliest year");
            string deadliestyear = "";
            double maxAverage = 0;
            foreach (KeyValuePair<string, Dictionary<string, double>> year in accidents)
            {
                string currentYear = year.Key;
                double totalAccidentsPerYear = 0;
                double totalDeathPerYear = 0;
                double averageDeathPercentage = 0;

                //Console.WriteLine($"Key: {year.Key}, Value: {year.Value}");
                foreach (KeyValuePair<string, double> accident in year.Value)
                {
                    totalAccidentsPerYear += accident.Value;
                    totalDeathPerYear += deaths[year.Key][accident.Key];
                }

                averageDeathPercentage = (totalDeathPerYear / totalAccidentsPerYear) * 100;
                if (averageDeathPercentage > maxAverage)
                {
                    maxAverage = averageDeathPercentage;
                    deadliestyear = currentYear;
                }
                Console.WriteLine($"{currentYear} Average death percentage per year: {string.Format("{0:0.00}", averageDeathPercentage)}");
            }
            Console.WriteLine($"Deadliest year was {deadliestyear} with average death % of {string.Format("{0:0.00}", maxAverage)}");
            Console.WriteLine();
        }

        public void FindTotalNumberOfAccidentsPerYear()
        {
            prettyPrint();
            Console.WriteLine("Total number of accidents per year in decreasing order");
            Dictionary<string, double> totalAccidentsPerYear = new Dictionary<string, double>();
            foreach (KeyValuePair<string, Dictionary<string, double>> year in accidents)
            {
                double totalAccidents = 0;
                string currentYear = year.Key;
                //Console.WriteLine($"Key: {year.Key}, Value: {year.Value}");
                foreach (KeyValuePair<string, double> accident in year.Value)
                {
                    totalAccidents += accident.Value;

                    //Console.WriteLine($"Year: {year.Key}, Month: {accident.Key}, Value: {accident.Value}");
                }
                totalAccidentsPerYear.Add(currentYear, totalAccidents);
            }

            foreach (KeyValuePair<string, double> item in totalAccidentsPerYear.OrderByDescending(key => key.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value} accidents");
            }
            Console.WriteLine();
        }

        

        public  void FindYearAndMonthWithMostDeaths()
        {
            prettyPrint();
            Console.WriteLine("Year and month with most deaths");
            double mostDeaths = 0;
            string yearWithMostDeaths = string.Empty;
            string monthWithMostDeaths = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, double>> year in deaths)
            {
                //Console.WriteLine($"Key: {year.Key}, Value: {year.Value}");
                foreach (KeyValuePair<string, double> death in year.Value)
                {
                    if (death.Value > mostDeaths)
                    {
                        yearWithMostDeaths = year.Key;
                        monthWithMostDeaths = death.Key;
                        mostDeaths = death.Value;
                    }
                    //Console.WriteLine($"Year: {year.Key}, Month: {accident.Key}, Value: {accident.Value}");
                }
            }
            Console.WriteLine($"Most deaths happened in {yearWithMostDeaths} {monthWithMostDeaths} with total of {mostDeaths} deaths.");
            Console.WriteLine();
        }

        private void prettyPrint()
        {
            for(int i = 0; i< 15; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
