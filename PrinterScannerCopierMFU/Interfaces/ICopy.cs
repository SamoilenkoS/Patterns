using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerCopierMFU
{
    public interface ICopy
    {
        IDocument Copy(IDocument document);
    }
}
