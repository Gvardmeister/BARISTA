using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BARISTA.Model
{
    internal class AppointmentPosition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public DateTime Time { get; set; }

        public Position position { get; set; }
        public Employee employee { get; set; }
    }
}
