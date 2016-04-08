using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Village.Model;

namespace Village.DataAccess.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private VillageDb vdb = new VillageDb();

        public IEnumerable<House> GetAllHouse()
        {
            return vdb.Houses.AsEnumerable();
        }


        public House GetHouseByHouseNo(string HouseNo)
        {
            throw new NotImplementedException();
        }
    }
}
