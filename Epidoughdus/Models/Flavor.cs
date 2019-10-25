using System.Collections.Generic;

namespace Epidoughdus.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string Type { get; set; }
        public virtual ICollection<FlavorTreat> Treats { get; set; }
    }
}