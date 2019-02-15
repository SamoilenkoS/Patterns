using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerCopierMFU
{
    public class Document : IDocument
    {
        public string GetText()
        {
            return "Document text";
        }
    }
}
