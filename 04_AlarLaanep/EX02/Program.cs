using System;
using System.Collections.Generic;
using System.IO;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> beginnings;
            List<string> endings;
            List<string> restoredIds;

            //read beginnings from file and save to list
            beginnings = FileReader("beginnings.txt");
            //read endings from file and save to list
            endings = FileReader("endings.txt");
            //restore ids and save result to list
            restoredIds = RestoreIdCodes(beginnings, endings);
            //write restored ids from list to result file
            FileWriter(restoredIds, "result.txt", false);

            //for(int i = 0; i< beginnings.Count; i++)
            //{
            //    Console.WriteLine($"beginning: {beginnings[i]} Ending: {endings[i]} Restored: {restoredIds[i]}");
            //}
        }

        //method for reading content of file, saves filecontent to list and returns it
        public static List<string> FileReader(string fileName)
        {
            List<string> fileContent = new List<string>();
            try { 
                using (StreamReader reader = new StreamReader(fileName)) {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        fileContent.Add(line);
                    }
                }
            } catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return fileContent;
        }

        //method for restoring Id codes
        public static List<string> RestoreIdCodes(List<string> beg, List<string> end)
        {
            List<string> restored = new List<string>();
            List<string> begs = beg;
            List<string> ends = end;

            const int IDLENGTH = 11;

            //iterate over beginnings List
            for (int i = 0; i < begs.Count; i++)
            {
                string idCode;
                //Console.WriteLine($"{begs[i]}, {begs[i].Length} Lookfor: {IDLENGTH- begs[i].Length}");
                //calculate string length to look for from beginnings List
                int lengthToLookFor = IDLENGTH - begs[i].Length;

                for(int j = 0; j < ends.Count; j++)
                {
                    //If the item in endings List is the same length we are looking for
                    if (ends[j].Length == lengthToLookFor)
                    {
                        //Concatenate beginning and ending
                        idCode = string.Concat(begs[i], ends[j]);
                        //add concatenated string into restored List
                        restored.Add(idCode);
                    }
                }
            }
            return restored;
        }

        //method for writing from list into the file
        public static void FileWriter(List<string> myList, string fileName, bool append)
        {
            try { 
                using(StreamWriter writer = new StreamWriter(fileName, append))
                {
                    foreach(string line in myList)
                    {
                        writer.WriteLine(line);
                    }
                }
            } catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }


    }



}
