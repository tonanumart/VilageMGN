using System;
using Village.Model.Model;
using Village.Model.Partail;

namespace Village.Service.Service
{
    public class InvoiceService
    {
        public Invoice GenerateInvoice(int year, int month)
        {
            var invoice = new Invoice();
            invoice.CreateDate = new DateTime(year,month,5);
            return invoice;
        }

        public Invoice GenerateInvoice(int year, int month, int ownerId)
        {
            Invoice invoice = this.GenerateInvoice(year, month);
            invoice.OwnerId = ownerId;
            return invoice;
        }
    }
}