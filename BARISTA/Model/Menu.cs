using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace BARISTA.Model
{
    internal class Menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Recepti { get; set; }
        public decimal Price { get; set; }

        public ICollection<PrescriptionProduct> prescriptionProducts { get; set; }
        public ICollection<Sale> sales { get; set; }

        public Menu()
        {
            prescriptionProducts = new List<PrescriptionProduct>();
            sales = new List<Sale>();
        }
    }
}
