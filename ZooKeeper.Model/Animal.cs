using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    public class Animal
    {
        private static int id_seed = 1000000;

        public Animal(string species, string exhibit)
        {
            Species = species;
            Exhibit = exhibit;
            ID = id_seed.ToString();
            id_seed++;
        }

        public string Species { get; set; }
        public string ID { get; }
        public string Exhibit { get; set; }
        public DateTime LastHealthExam { get; set; }
    }
}
