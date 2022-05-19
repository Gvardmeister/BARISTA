using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class SupplyOfGoods
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int Count { get; set; }

        public ICollection<Catalog> catalogs { get; set; }
        public ICollection<Supply> supplies { get; set; }

        public SupplyOfGoods()
        {
            catalogs = new List<Catalog>();
            supplies = new List<Supply>();
        }
    }
}
