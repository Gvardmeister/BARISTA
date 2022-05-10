using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class Vendor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Telephon { get; set; }

        public ICollection<Catalog> catalogs { get; set; }

        public Vendor()
        {
            catalogs = new List<Catalog>();
        }
    }
}
