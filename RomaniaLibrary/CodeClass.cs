using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RomaniaLibrary
{
    public class CodeClass
    {
        
        public string GenerateCode(string lastName, int gender, DateTime dateBirdth, string resident/*, string city*/)
        {
            string number = "";
            if (dateBirdth.Year>=1900&& dateBirdth.Year<=1949)
            {
                number +="1";
            }
            if (dateBirdth.Year >= 1950 && dateBirdth.Year <= 1999)
            {
                number += "2";
            }
            if (dateBirdth.Year >= 1800 && dateBirdth.Year <= 1849)
            {
                number += "3";
            }
            if (dateBirdth.Year >= 1850 && dateBirdth.Year <= 1899)
            {
                number += "4";
            }
            if (dateBirdth.Year >= 2000 && dateBirdth.Year <= 2049)
            {
                number += "5";
            }
            if (dateBirdth.Year >= 2050&& dateBirdth.Year <= 2099)
            {
                number += "6";
            }
            string year = Convert.ToString(dateBirdth.Year).Substring(2,2);
            string month = Convert.ToString(dateBirdth.Month).Substring(0,2);
            string day = Convert.ToString(dateBirdth.Day);
            number += year;
            number += year;
            number += month;
            number += month;
            number += day;
            number += day;
            //
            if (gender=="1")
            {
                number +=1;
            }
            if (gender == "2")
            {
                number += 2;
            }


            return number;

        }
    }
}
