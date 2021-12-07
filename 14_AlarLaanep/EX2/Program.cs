using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficAccidentAnalyzer accidentAnalyzer = new TrafficAccidentAnalyzer();
            accidentAnalyzer.FindYearAndMonthWithMostAccidents();
            accidentAnalyzer.FindPerctangeOfAccidentsWhichEndWithDeadth();
            accidentAnalyzer.FindAverageDeathRatePercentage();
            accidentAnalyzer.FindTotalNumberOfAccidentsPerYear();
            accidentAnalyzer.FindYearAndMonthWithMostDeaths();
        }
    }
}
