using System;
using System.Collections.Generic;
using System.Linq;

namespace AnalysisForVotingRegions
{
    public static class PersonalCodeValidator
    {
        //private int year = GetYear(_personalCode;);
        //private int month = GetMonth(_personalCode;);
        //private int day = GetDay(_personalCode;);

        public static DateTime GetBirthDate(string idCode)
        {
            DateTime birthDate = new DateTime(GetYear(idCode), GetMonth(idCode), GetDay(idCode));
            return birthDate;
        }

        //decode day from idCode
        public static int GetDay(string idCode)
        {
            return int.Parse(idCode.Substring(5, 2));
        }

        //decode month from idCode
        public static int GetMonth(string idCode)
        {
            return int.Parse(idCode.Substring(3, 2));
        }

        //decode year from idCode
        public static int GetYear(string idCode)
        {
            int year = 0;
            int firstNum = int.Parse(idCode.Substring(0, 1));

            switch (firstNum)
            {
                case 1:
                case 2:
                    year = 1800;
                    break;
                case 3:
                case 4:
                    year = 1900;
                    break;
                case 5:
                case 6:
                    year = 2000;
                    break;
            }
            return year + int.Parse(idCode.Substring(1, 2));
        }


        //validate idCode
        public static bool ValidateIdCode(string idCode)
        {
            //check if idCode is all digits
            if (CheckAllDigits(idCode))
            {
                //check if idCode is 11 digits long
                if (CheckLength(idCode))
                {
                    //check if IdCode first char is beteen 1-6
                    if (CheckFirstCharRange(idCode))
                    {
                        //validate birthdate numbers from 1-7
                        if (CheckBirthdate(idCode))
                        {
                            //validate check nr
                            if (CheckCheckNr(idCode))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        //validate checknr
        public static bool CheckCheckNr(string idCode)
        {
            int[] kordajad1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int[] kordajad2 = new int[] { 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            List<int> idCodeList = new List<int>();
            for (int i = 0; i < idCode.Length; i++)
            {
                idCodeList.Add(int.Parse(idCode[i].ToString()));
            }

            if (calculateCheckNr(idCodeList, kordajad1) == idCodeList[10])
            {
                return true;
            }
            else if (calculateCheckNr(idCodeList, kordajad2) == idCodeList[10])
            {
                return true;
            }
            else
            {
                //Console.WriteLine("Invalid checknr");
                return false;
            }


        }
        //calculate check nr
        public static int calculateCheckNr(List<int> idCodeList, int[] kordaja)
        {
            int total = 0;
            for (int i = 0; i < idCodeList.Count - 1; i++)
            {
                total += idCodeList[i] * kordaja[i];
            }
            return total % 11;
        }

        //check idCode birthdate
        public static bool CheckBirthdate(string idCode)
        {
            try
            {
                DateTime birthDate = new DateTime(GetYear(idCode), GetMonth(idCode), GetDay(idCode));
                if (birthDate > DateTime.Today)
                {
                    //Console.WriteLine("invalid idcode, Birthdate cannot be in future");
                    return false;
                }
                return true;

            }
            catch (ArgumentOutOfRangeException)
            {
                //Console.WriteLine(ex.Message);
                
                return false;
            }
        }

        //check idCode first char range
        public static bool CheckFirstCharRange(string idCode)
        {
            if (int.Parse(idCode.Substring(0, 1)) < 1 || int.Parse(idCode.Substring(0, 1)) > 6)
            {
                //Console.WriteLine("invalid idcode, first nr should be between 1-6");
                return false;
            }
            return true;
        }

        //check idCode length
        public static bool CheckLength(string idCode)
        {
            if (idCode.Length != 11)
            {
                //Console.WriteLine("invalid idcode, length should be 11 digits");
                return false;
            }
            return true;
        }

        //check if all chars in idCode are digits
        public static bool CheckAllDigits(string idCode)
        {
            //check if idCode is all digits
            if (!idCode.All(char.IsDigit))
            {
                //Console.WriteLine("invalid idcode, not all chars are digits");
                return false;
            }
            return true;
        }
    }
}
