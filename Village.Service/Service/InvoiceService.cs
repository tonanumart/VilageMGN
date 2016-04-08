using System;
using System.Collections.Generic;
using Village.Model;
using Village.Service.Repository;

namespace Village.Service.Service
{
    public class InvoiceService
    {
        private IInvoiceRepository invoiceRepository;
        private IHouseFakeDb houseRepository;


        public InvoiceService() { }

        public InvoiceService(IInvoiceRepository _invoiceRepo, IHouseFakeDb _houseRepository)
        {
            this.invoiceRepository = _invoiceRepo;
            this.houseRepository = _houseRepository;
        }

        /// <summary>
        ///  Create Invoices in this month
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public List<Invoice> GenerateInvoices(int year, int month)
        {
            IEnumerable<House> houseList = houseRepository.GetAllHouse();

            List<Invoice> invoiceList = new List<Invoice>();

            //houseList.ForEach(House =>
            //{
            //    //invoiceList.Ad
            //});

            //var invoice = GenerateInvoice(year, month,null);
            return invoiceList;
        }

        public Invoice GenerateInvoice(int year, int month, int ownerId)
        {
            Invoice invoice = new Invoice()
            {
                CreateDate = DateTime.Now,
                DueDate = new DateTime(year, month + 1, 5),
                InvoiceId = Guid.NewGuid(),
                OwnerId = ownerId
            };
            return invoice;
        }

        public List<Invoice> GetInvoiceByService(int ownerId)
        {
            return this.invoiceRepository.GetInvoiceByOwner(ownerId);
        }
    }
}