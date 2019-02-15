using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerCopierMFU
{
    public class MFU : IPrint, IScan, ICopy
    {
        public IDocument Copy(IDocument document)
        {
            throw new NotImplementedException();
        }

        public void Print(IDocument document)
        {
            throw new NotImplementedException();
        }

        public IDocument Scan()
        {
            throw new NotImplementedException();
        }
    }
}
