using System;
using System.Collections.Generic;
using Village.Model;
using Village.Service.Repository;

namespace Village.Service.Service
{
    public class InvoiceService
    {
        private IInvoiceRepository invoiceRepository;

        public InvoiceService() { }

        public InvoiceService(IInvoiceRepository _invoiceRepo)
        {
            this.invoiceRepository = _invoiceRepo;
        }

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

        public List<Invoice> GetInvoiceByService(int ownerId)
        {
            return this.invoiceRepository.GetInvoiceByOwner(ownerId);
        }
    }
}