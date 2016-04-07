using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Village.Model;
using Village.Service.Repository;

namespace Village.Service
{
    public  class PropertyService
    {
        public IHouseFakeDb fakeDb { get; set; }

        public PropertyService(IHouseFakeDb _fakeDb) {
            this.fakeDb = _fakeDb;
        }

        public List<House> GetAllHouse()
        {
            return this.fakeDb.GetAllHouse();
        }

        public House GetHouseByAddr(int addr)
        {
            return this.fakeDb.GetHouseById(addr);
        }
    }
}
