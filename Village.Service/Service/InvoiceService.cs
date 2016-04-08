using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Village.DataAccess.Repository;
using Village.Model;

namespace Village.Service.Service
{
    public class InvoiceService
    {
        private IInvoiceRepository invoiceRepository;
        private IPropertyRepository houseRepository;

        public InvoiceService(IInvoiceRepository _invoiceRepo, IPropertyRepository _houseRepository)
        {
            this.invoiceRepository = _invoiceRepo;
            this.houseRepository = _houseRepository;
        }

        /// <summary>
        ///  Create Invoices in this month
        /// </summary>
        /// <param name="year">Year</param>
        /// <param name="month">Month</param>
        /// <returns></returns>
        public List<Invoice> GenerateInvoices(int year, int month)
        {
            var houseList = houseRepository.GetAllHouse();
            return houseList
                .Where(house=>house.Owner != null).Select(house => this.GenerateInvoice(year, month, house.Owner)).ToList();
        }

        public Invoice GenerateInvoice(int year, int month, Owner owner)
        {
            Invoice invoice = new Invoice()
            {
                CreateDate = DateTime.Now,
                DueDate = new DateTime(year, month + 1, 5),
                Owner = owner
            };
            return invoice;
        }

        public List<Invoice> GetInvoiceByService(int ownerId)
        {
            return this.invoiceRepository.GetInvoiceByOwner(ownerId);
        }
    }
}