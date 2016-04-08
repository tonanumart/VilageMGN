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

        [Fact]
        public void GetInvoiceByOwner_CallRepo()
        {
           
            int ownerId = 9999;
            Mock<IInvoiceRepository> mock = new Mock<IInvoiceRepository>();
            mock.Setup(repo => repo.GetInvoiceByOwner(ownerId));
            InvoiceService sut = new InvoiceService(mock.Object);
            List<Invoice> listOfInvoice = sut.GetInvoiceByService(ownerId);
            mock.Verify(repo => repo.GetInvoiceByOwner(ownerId), Times.Once());
        }
    }
}
