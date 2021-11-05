using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_10
{
    public class Cat
    {
        //ToDo: finish this method
        public bool CatIsPlaying(bool isSummer, int temp)
        {
            //first parameter indicates if it is summer or not
            //second parameter indicates temperature
            //Add content here so all tests would pass!
            if (temp >= 25)
            {
                if(isSummer && temp <= 45)
                {
                    return true;
                }
                else if(!isSummer && temp <= 35)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
