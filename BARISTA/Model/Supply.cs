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
        public DateTime dateTime { get; set; }
        public int Count { get; set; }
        public DateTime dateExpire { get; set; }

        public ICollection<SupplyOfGoods> supplyOfGoods { get; set; }
        public ICollection<SupplyAccounting> supplies { get; set; }
        // еще поле

        public Supply()
        {
            supplyOfGoods = new List<SupplyOfGoods>();
            supplies = new List<SupplyAccounting>();
        }
    }
}
