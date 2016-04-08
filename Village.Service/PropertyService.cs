using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Village.DataAccess.Repository;
using Village.Model;

namespace Village.Service
{
    public  class PropertyService
    {
        public IPropertyRepository propertyRe { get; set; }

        public PropertyService(IPropertyRepository _propertyRe) {
            this.propertyRe = _propertyRe;
        }

        public IEnumerable<House> GetAllHouse()
        {
            return this.propertyRe.GetAllHouse();
        }

        public House GetHouseByHouseNo(string HouseNo)
        {
            return this.propertyRe.GetHouseByHouseNo(HouseNo);
        }
    }
}
