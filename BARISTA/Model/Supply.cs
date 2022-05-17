using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARISTA.Model
{
    internal class Supply
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime datetime { get; set; }
        public int Count { get; set; }
        public DateTime DateExpire { get; set; }

        public ICollection<SupplyOfGoods> supplyOfGoods { get; set; }
        public ICollection<SupplyAccounting> supplies { get; set; }
        public ICollection<Employee> employees { get; set; }

        public Supply()
        {
            supplyOfGoods = new List<SupplyOfGoods>();
            supplies = new List<SupplyAccounting>();
            employees = new List<Employee>();
        }
    }
}
