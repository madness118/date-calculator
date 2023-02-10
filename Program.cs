using DateStuff;
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

        static void Main(string[] args)
        {
            var myDateUtility = new DateUtility();
            var readerWriterFactory = new ReaderWriterFactory();
            var readerWriter = readerWriterFactory.Create(ReaderWriterType.Console);

            readerWriter.WriteLine($"It is currently {myDateUtility.GetCurrentDate():F} \n\n");
            string timeType;
            int quantity;
            int result;
            int userAction;
            string compareDate;

            readerWriter.WriteLine("Choose your action \n1) Calculate the date after a certain period of time\n2) Find difference between two dates  \nAnswer: ");
            try
            {
                userAction = int.Parse(readerWriter.ReadLine());
                if (userAction == 1)
                {
                    readerWriter.WriteLine("Enter a singular measurement of time (e.g week not weeks): ");
                    timeType = readerWriter.ReadLine();
                    readerWriter.WriteLine($"Enter the quantity of {timeType}s: ");
                    quantity = int.Parse(readerWriter.ReadLine());
                    readerWriter.WriteLine($"Enter 1 (add {timeType}s) or 2 (subtract {timeType}s): ");
                    result = int.Parse(readerWriter.ReadLine());

                    if (result == 1)
                    {
                        readerWriter.WriteLine($"\n\nIn {quantity} {timeType}s, it will be {myDateUtility.GetNewDateAdd(timeType, quantity)}");
                    }
                    else if (result == 2)
                    {
                        readerWriter.WriteLine($"\n\n{quantity} {timeType}s ago, the date was {myDateUtility.GetNewDateSubtract(timeType, quantity)}");
                    }
                }
                else if (userAction == 2)
                {
                    readerWriter.WriteLine("Enter a date to compare in the form of: yyyy mm dd\nDate: ");
                    compareDate = readerWriter.ReadLine();
                }
            }
            catch
            {
                readerWriter.WriteLine("Cannot accept, try again");
            }
        }
    }
}