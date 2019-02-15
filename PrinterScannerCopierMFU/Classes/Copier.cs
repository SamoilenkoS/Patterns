using System;

namespace PrinterScannerCopierMFU
{
    public class Copier : ICopy
    {
        public IDocument Copy(IDocument document)
        {
            return document;
        }
    }
}
