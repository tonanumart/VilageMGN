using System;
using Village.Model;

namespace Village.Service
{
    public class ReceiptService
    {
        public ReceiptService()
        {
        }

        public Receipt CreateReceipt( int invoiceId)
        {
            return new Receipt()
            {
                //InvoiceId = invoiceId
            };
        }
    }
}