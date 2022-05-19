using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class PrescriptionProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int Count { get; set; }

        public ICollection<Warehouse> warehouses { get; set; }
        public ICollection<Menu> menus { get; set; }

        public PrescriptionProduct()
        {
            warehouses = new List<Warehouse>();
            menus = new List<Menu>();
        }
    }
}
