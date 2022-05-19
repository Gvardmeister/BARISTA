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

        public int Id { get; set; }
        public int LastRecources { get; set; }

        public ICollection<Supply> supplies { get; set; }
        public int WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        public SupplyAccounting()
        {
            supplies = new List<Supply>();
        }
    }
}
