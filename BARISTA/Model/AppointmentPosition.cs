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
        [Key]
        [ForeignKey("Position, Employee")] // не уверен, что правильно

        public DateTime dateTime { get; set; }

        public Position position { get; set; }
        public Employee employee { get; set; }
    }
}
