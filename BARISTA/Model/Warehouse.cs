using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class Warehouse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public ICollection<SupplyAccounting> supplies { get; set; }
        public ICollection<PrescriptionProduct> prescriptionProducts { get; set; }

        public Warehouse()
        {
            supplies = new List<SupplyAccounting>();
            prescriptionProducts = new List<PrescriptionProduct>();
        }
    }
}
