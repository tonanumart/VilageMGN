using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Village.Model;

namespace Village.DataAccess
{
    public class VillageDb : DbContext
    {
        public DbSet<House> Houses { get; set; }

    }
}
