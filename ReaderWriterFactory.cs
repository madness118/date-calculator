using System;
using System.Collections.Generic;
using System.Text;

namespace dateCalculator
{
    public enum ReaderWriterType
    {
        Console,
        Html,
        WinForm
    }

    class ReaderWriterFactory
    {
        public IReaderWriter Create(ReaderWriterType readerWriterType)
        {
            switch (readerWriterType)
            {
                case ReaderWriterType.Console:
                    return new ConsoleReaderWriter();

                case ReaderWriterType.Html:
                    return null;

                case ReaderWriterType.WinForm:
                    return null;

                default:
                    return null;
            }
        }
    }
}
