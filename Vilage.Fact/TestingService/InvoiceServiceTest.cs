using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Village.Model.Model;
using Village.Service.Service;
using Xunit;

namespace Vilage.Fact.TestingService
{
    public class InvoiceServiceTest
    {
        [Fact]
        public void GenerateInvoice()
        {
            InvoiceService sut = new InvoiceService();
            int year = 2005;
            int month = 3;
            Invoice invoice = sut.GenerateInvoice(year, month);
            Assert.Equal(year, invoice.CreateDate.Year);
            Assert.Equal(month, invoice.CreateDate.Month);
        }

        [Fact]
        public void GenerateInvoiceWithOwnerId()
        {
            InvoiceService sut = new InvoiceService();
            int year = 2005;
            int month = 4;
            int ownerId = 99;
            Invoice invoice = sut.GenerateInvoice(year, month, ownerId);
            Assert.Equal(year, invoice.CreateDate.Year);
            Assert.Equal(month, invoice.CreateDate.Month);
            Assert.Equal(ownerId, invoice.OwnerId);
        }
    }
}
