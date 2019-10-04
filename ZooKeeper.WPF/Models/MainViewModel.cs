using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeper.Model;
using ZooKeeper.WPF.Presenters;

namespace ZooKeeper.WPF.Models
{
    class MainViewModel
    {
        public Store store;
        public EntryPagePresenter presenter;

        public MainViewModel(EntryPagePresenter presenter)
        {
            store = new Store();
            this.presenter = presenter;
        }
    }
}
