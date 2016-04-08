﻿using Moq;
using System.Collections.Generic;
using Village.DataAccess.Repository;
using Village.Model;
using Village.Service.Service;
using Xunit;

namespace Vilage.Fact.TestingService
{
    public class InvoiceServiceTest
    {


        [Fact]
        public void GenerateInvoice()
        {
            var mock = new Mock<IInvoiceRepository>();
            var fakeHouse = new Mock<IPropertyRepository>();
            InvoiceService sut = new InvoiceService(mock.Object, fakeHouse.Object);
            int year = 2005;
            int month = 4;
            var owner = new Owner();
            Invoice invoice = sut.GenerateInvoice(year, month, owner);
            Assert.Equal(year, invoice.DueDate.Year);
            Assert.Equal(month+1, invoice.DueDate.Month);
            Assert.Same(owner, invoice.Owner);
            //Assert.Equal(ownerId, invoice.OwnerId);
        }

        [Fact]
        public void GenerateInvoices_Equal_2()
        {
            var mock = new Mock<IInvoiceRepository>();
            var fakeHouse = new Mock<IPropertyRepository>();

            var listHouse = new List<House>() {
               new House() {
                    //Owner = new Owner()
               },
               new House() {
                    //Owner = new Owner()
               },
               new House() {
               }
            };

            fakeHouse.Setup(fakeRepo => fakeRepo.GetAllHouse()).Returns(listHouse);
            InvoiceService sut = new InvoiceService(mock.Object, fakeHouse.Object);
            int year = 2005;
            int month = 3;
            List<Invoice> invoiceList = sut.GenerateInvoices(year, month);
            fakeHouse.Verify(repo => repo.GetAllHouse(), Times.Once);
            Assert.NotNull(invoiceList);
            Assert.Equal(2, invoiceList.Count);
        }
    }
}
