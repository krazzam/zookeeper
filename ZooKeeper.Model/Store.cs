﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    public class Store
    {
        List<Animal> store = new List<Animal>();

        public Store() { }

        public bool ImportFrom(IReader reader)
        {
            return reader.populate(this);
        }

        public bool ExportTo(IWriter writer)
        {
            return writer.export(this);
        }

        public void AddAnimal(Animal animal)
        {
            store.Add(animal);
        }

        public List<Animal> FindBySpecies(string species)
        {
            List<Animal> results = new List<Animal>();

            foreach (Animal animal in store)
            {
                if (animal.Classification.Species == species)
                {
                    results.Add(animal);
                }
            }

            return results;
        }

        public List<Animal> FindByLocation(string location)
        {
            List<Animal> results = new List<Animal>();

            foreach (Animal animal in store)
            {
                if (animal.Exhibit == location)
                {
                    results.Add(animal);
                }
            }

            return results;
        }

        public Animal FindById(string id)
        {
            Animal result = null;
            Predicate<Animal> animal = (Animal a) => { return a.ID == id; };
            result = store.Find(animal);

            return result;
        }

        public bool RemoveAnimal(string id)
        {
            bool status = false;

            Animal result = null;
            result = FindById(id);
            if (result != null)
            {
                store.Remove(result);
                status = true;
            }

            return status;
        }

        public List<Animal> GetAllAnimals
        {
            get { return store; }
        }
    }
}
