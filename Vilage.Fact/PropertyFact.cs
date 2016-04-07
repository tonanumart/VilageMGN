using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Should;
using Village.Model;

namespace Vilage.Fact
{
    public class PropertyFact
    {
        public class HouseFact
        {
            private House h;

            public HouseFact()
            {
                h = new House();
            }

            [Fact]
            public void GetHouseIsNull()
            {
            }
        }
    }
}
