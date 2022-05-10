using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class Catalog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<Vendor> vendors { get; set; }
        public ICollection<Manufacturer> manufacturers { get; set; }
        public ICollection<SupplyOfGoods> supplyOfGoods { get; set; }

        public Catalog()
        {
            vendors = new List<Vendor>();
            manufacturers = new List<Manufacturer>();
            supplyOfGoods = new List<SupplyOfGoods>();
        }
    }
}
