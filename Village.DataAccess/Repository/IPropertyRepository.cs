using System;
using System.Collections.Generic;
using Village.Model;

namespace Village.DataAccess.Repository
{
    public interface IPropertyRepository
    {
        IEnumerable<House> GetAllHouse();
        House GetHouseByHouseNo(string HouseNo);
    }

}