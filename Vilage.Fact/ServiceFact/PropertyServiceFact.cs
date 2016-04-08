using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Should;
using Village.Model;
using Moq;
using Village.Service;
using Village.DataAccess.Repository;

namespace Vilage.Fact.ServiceFact
{
    public class PropertyServiceFact
    {
        public class HouseFact
        {
            private House h;
            public HouseFact()
            {
                h = new House();
            }

            [Fact]
            public void GetHouse_MustCall_HouseMockRepo()
            {
                var h = new List<House>() {
                    new House
                    {
                        HouseNo = "1/1",
                        AreaSquareWa = 100
                    }
                    ,new House
                    {
                        HouseNo = "1/2",
                        AreaSquareWa = 110
                    }
                };

                Mock<IPropertyRepository> fakeRepo = new Mock<IPropertyRepository>();
                fakeRepo.Setup(fake => fake.GetAllHouse()).Returns(() => h);
                PropertyService sut = new PropertyService(fakeRepo.Object);

                IEnumerable<House> houses = sut.GetAllHouse();

                houses.Count().ShouldEqual(2);
                fakeRepo.Verify(fake => fake.GetAllHouse(), Times.Exactly(1));
            }
        }
    }
}
