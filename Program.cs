using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace dateCalculator
{
    class Program
    {
        public static string[] keywords = { "day", "week", "month", "year" };


        public static DateTime GetCurrentDate()
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


        public static DateTime GetNewDate(string timeS, int timeI)
        {
            DateTime newDate = new DateTime();
            DateTime now = GetCurrentDate();

            switch (timeS)
            {
                case "day":
                    newDate = now.AddDays(timeI);
                    break;
                case "week":
                    newDate = now.AddDays(timeI*7);
                    break;
                case "month":
                    newDate = now.AddMonths(timeI);
                    break;
                case "year":
                    newDate = now.AddYears(timeI);
                    break;
            }

            return newDate;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"It is currently {GetCurrentDate():F}");
            string timeType;
            int quantity;

            Console.WriteLine("Enter a singular measurement of time (e.g week not weeks): ");
            timeType = Console.ReadLine();
            Console.WriteLine($"Enter the quantity of {timeType}s: ");
            quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n\nIn {quantity} {timeType}s, it will be {GetNewDate(timeType, quantity)}");
        }
    }
}