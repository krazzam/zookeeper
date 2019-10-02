using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    public class Classification
    {
        public Classification(string Class, string Order, string Species)
        {
            this.Class = Class;
            this.Order = Order;
            this.Species = Species;
        }

        public string Class { get; }
        public string Order { get; }
        public string Species { get; }
    }
}
