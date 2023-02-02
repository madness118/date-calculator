using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dateCalculator
{
    class Program
    {
        public static DateTime GetCurrentDate()
        {
            DateTime now = DateTime.Now;

            return now;
        }


        public static Dictionary<int, string> CalculateTimeToAdd(string time) //calculate amount of time to add as a dictionary, separate two values in a different function
        {
            string[] keywords = { "day", "week", "month", "year" };
            IDictionary<int, string> timeToAdd = new Dictionary<int, string>();
            DateTime newTime = new DateTime();

            while (true)
            {
                try
                {
                    Console.WriteLine("\n\nEnter a time of any length in the format <measure of time>, <quantity> :  ");
                    time = Console.ReadLine();  
                }
                catch
                {
                    Console.WriteLine("Cannot accept. Please try again.");
                }
                for (int i = 0; i < keywords.Length; i++)
                    if (time.Contains(keywords[i]) == true)
                    {
                        //keywordsUsed.Add(); add quantity, then substring containing keyword into dictionary
                    }
            }

            return (Dictionary<int, string>)timeToAdd;
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine($"It is currently {GetCurrentDate():F}");
        }
    }
}