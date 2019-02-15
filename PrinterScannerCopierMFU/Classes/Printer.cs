using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerCopierMFU
{
    public class Printer : IPrint
    {
        public void Print(IDocument document)
        {
            Console.WriteLine(document.GetText());
        }
    }
}
