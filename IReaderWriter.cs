using System;
using System.Collections.Generic;
using System.Text;

namespace dateCalculator
{
    interface IReaderWriter
    {
        void WriteLine(string input);
        int Read();
        string ReadLine();
    }
}
