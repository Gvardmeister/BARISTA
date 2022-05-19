using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class Sale
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int Count { get; set; }

        public ICollection<Menu> menus { get; set; }
        public ICollection<Check> checks { get; set; }

        public Sale()
        {
            menus = new List<Menu>();
            checks = new List<Check>();
        }
    }
}
