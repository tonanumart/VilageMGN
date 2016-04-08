using System;
using System.Collections.Generic;
using Village.Model;

namespace Village.Service.Repository
{
    public interface IHouseFakeDb
    {
        List<House> GetAllHouse();
        House GetHouseById(int HouseId);
    }

}