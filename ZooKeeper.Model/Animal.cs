using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    public class Animal : IAnimal
    {
        private static int id_seed = 1000000;

        public Animal(Classification classification)
        {
            Classification = classification;
            ID = id_seed.ToString();
            id_seed++;
        }

        public string ID { get; }
        public string DOB { get; set; }
        public string Exhibit { get; set; }
        public Classification Classification { get; }
        public DateTime LastHealthExam { get; set; }
    }
}
