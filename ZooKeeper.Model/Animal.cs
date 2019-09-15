using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    class Animal
    {
        private string species;
        readonly int id;
        private string exhibit;
        private DateTime lastHealthExam;

        public Animal(string species, string exhibit)
        {
            Species = species;
            Exhibit = exhibit;

            // generate a random id
            Random random = new Random();
            id = random.Next(10000000);
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public int ID
        {
            get { return id; }
        }

        public string Exhibit
        {
            get { return exhibit; }
            set { exhibit = value; }
        }

        public DateTime LastHealthExam
        {
            get { return lastHealthExam; }
            set { lastHealthExam = value; }
        }
    }
}
