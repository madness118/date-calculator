using System;
using System.Collections.Generic;
using System.Text;

namespace DateStuff
{
    class DateUtility
    {
        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        /*
        public static Dictionary<int, string> CalculateTimeToAdd(string input) //calculate amount of time to add as a dictionary, separate two values in a different function
        {
            IDictionary<int, string> timeToAdd_dict = new Dictionary<int, string>();

            int n;

            for (int i = 0; i < keywords.Length; i++)
                if (input.Contains(keywords[i]) == true)
                {
                    string[] strings = input.Split(' ');
                    for (int j = 0; j < strings.Length; j+=2)
                    {
                        n = int.Parse(strings[j]);
                        timeToAdd_dict.Add(n, strings[j+=1]);
                    }
                }

            return (Dictionary<int, string>)timeToAdd_dict;
        }
        */

        public string GetNewDateAdd(string timeS, int timeI)
        {
            DateTime newDate = new DateTime();
            DateTime now = GetCurrentDate();

            switch (timeS)
            {
                case "day":
                    newDate = now.AddDays(timeI);
                    break;
                case "week":
                    newDate = now.AddDays(timeI * 7);
                    break;
                case "month":
                    newDate = now.AddMonths(timeI);
                    break;
                case "year":
                    newDate = now.AddYears(timeI);
                    break;
            }

            string result = newDate.ToString("F");
            return result;
        }

        public string GetNewDateSubtract(string timeS, int timeI)
        {
            DateTime newDate = new DateTime();
            DateTime now = GetCurrentDate();

            switch (timeS)
            {
                case "day":
                    newDate = now.AddDays(-timeI);
                    break;
                case "week":
                    newDate = now.AddDays(-(timeI * 7));
                    break;
                case "month":
                    newDate = now.AddMonths(-timeI);
                    break;
                case "year":
                    newDate = now.AddYears(-timeI);
                    break;
            }

            string result = newDate.ToString("F");
            return result;
        }

        public DateTime GetCompareDate(string userInput)
        {
            DateTime compareDate = new DateTime();
            string[] dateArray = { };
            for (int i = 0; i < 3; i++)
            {
                dateArray = userInput.Split(" ");
            }
            for (int i = 0; i < 3; i++)
            {
                return compareDate;
            }
            return DateTime.Now;
        }
    }
}
