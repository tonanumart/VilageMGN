using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village.Model
{
    public class House
    {
        [Key]
        public string HouseNo { get; set; }
        public double AreaSquareWa { get; set; }

        public decimal MonthlyFee { get; set; }

        public virtual ICollection<Owner> Owners { get; set; }
        public Owner Owner => Owners.OrderByDescending(x=>x.StartDate)
            .FirstOrDefault();
    }
}
