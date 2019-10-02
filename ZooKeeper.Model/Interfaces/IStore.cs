using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    public interface IStore
    {
        List<Animal> FindBySpecies(string species);

        List<Animal> FindByLocation(string location);

        List<Animal> FindById(int id);

        bool AddAnimal(Animal animal);

        bool RemoveAnimal(int id);
    }
}
