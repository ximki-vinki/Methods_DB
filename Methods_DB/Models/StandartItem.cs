using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_DB.Models
{
    internal class CountStandartItems
    {
        public string Name { get; set; }
        
        public ICollection<StandartItem> Counts { get; set; }
    } 




    internal class StandartItem
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public string Name3 { get; set; }
            }
}
