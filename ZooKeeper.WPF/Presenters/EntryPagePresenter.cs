using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeper.WPF.Pages;
using ZooKeeper.Model;

namespace ZooKeeper.WPF.Presenters
{
    public class EntryPagePresenter
    {
        AddEntryPage entryPage;
        MainPage mainPage;
        public Store store;

        public EntryPagePresenter(MainPage mainPage, AddEntryPage entryPage, Store store)
        {
            this.mainPage = mainPage;
            this.entryPage = entryPage;
            this.store = store;
        }

        public void AddAnimal()
        {
            string aClass = entryPage.getClass();
            string order = entryPage.getOrder();
            string species = entryPage.getSpecies();
            string location = entryPage.getLocation();
            Classification classification = new Classification(aClass, order, species);

            Animal animal = new Animal(classification);
            animal.Exhibit = location;
            store.AddAnimal(animal);

            entryPage.setTag(animal.ID);

            mainPage.showAnimals(store);

        }
    }
}
