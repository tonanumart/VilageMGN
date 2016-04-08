using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Village.Model
{
    public class Owner
    {
        [Key]
        [Column(Order = 1)]
        public virtual House House { get; set; }
        [Key]
        [Column(Order = 2)]
        public virtual Person Person { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
