using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class SupplyAccounting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int LastRecources { get; set; }

        public ICollection<Supply> supplies { get; set; }
        public ICollection<Warehouse> warehouses { get; set; }

        public SupplyAccounting()
        {
            supplies = new List<Supply>();
            warehouses = new List<Warehouse>();
        }
    }
}
