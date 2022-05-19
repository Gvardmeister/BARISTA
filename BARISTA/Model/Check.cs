using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BARISTA.Model
{
    internal class Check
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public decimal price { get; set; }

        public int? SaleId { get; set; }
        public Sale sale { get; set; }
        public Employee employee { get; set; }
    }
}
