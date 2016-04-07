using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Should;
using Village.Model;
using Moq;
using Village.Service.Repository;
using Village.Service;

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
                Mock<IHouseFakeDb> fakeRepo = new Mock<IHouseFakeDb>();
                fakeRepo.Setup(fake => fake.GetAllHouse());
                PropertyService sut = new PropertyService(fakeRepo.Object);
                List<House> house = sut.GetAllHouse();
                fakeRepo.Verify(fake => fake.GetAllHouse(), Times.Exactly(1));
            }

        }
    }
}
