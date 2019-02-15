using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerCopierMFU
{
    public class Scanner : IScan
    {
        public IDocument Scan()
        {
            return new Document();
        }
    }
}
