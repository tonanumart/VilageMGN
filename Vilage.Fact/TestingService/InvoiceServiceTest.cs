using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Village.Model;
using Village.Service.Repository;
using Village.Service.Service;
using Xunit;

namespace Vilage.Fact.TestingService
{
    public class InvoiceServiceTest
    {


        [Fact]
        public void GenerateInvoiceWithOwnerId()
        {
            Mock<IInvoiceRepository> mock = new Mock<IInvoiceRepository>();
            Mock<IHouseFakeDb> fakeHouse = new Mock<IHouseFakeDb>();
            InvoiceService sut = new InvoiceService(mock.Object, fakeHouse.Object);
            int year = 2005;
            int month = 4;
            string temp = string.Empty;
            int ownerId = 99; 
            Invoice invoice = sut.GenerateInvoice(year, month, ownerId);
            Assert.Equal(year, invoice.DueDate.Year);
            Assert.Equal(month+1, invoice.DueDate.Month);
            Assert.Equal(ownerId, invoice.OwnerId);
        }

        //[Fact]
        //public void GenerateInvoices()
        //{
        //    InvoiceService sut = new InvoiceService();
        //    int year = 2005;
        //    int month = 3;
        //    List<Invoice> invoiceList = sut.GenerateInvoices(year, month);
        //    Assert.NotNull(invoiceList);
        //}
    }
}
