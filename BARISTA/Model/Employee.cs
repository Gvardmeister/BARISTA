using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public int Telephone { get; set; }
        public DateTime DateBirthday { get; set; }

        public AppointmentPosition Appointment { get; set; }
        public Check check { get; set; }
        
        public ICollection<Supply> supplies { get; set; }

        public Employee()
        {
            supplies = new List<Supply>();
        }
    }
}
