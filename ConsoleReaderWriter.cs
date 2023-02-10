using System;
using System.Collections.Generic;
using System.Text;

namespace dateCalculator
{
    class ConsoleReaderWriter : IReaderWriter
    {
        public int Read()
        {
            return Console.Read();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
