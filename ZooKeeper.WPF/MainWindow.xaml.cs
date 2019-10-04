using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZooKeeper.Model;
using ZooKeeper.WPF.Presenters;
using ZooKeeper.WPF.Pages;

namespace ZooKeeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Store store;
        MainPage mainPage;
        AddEntryPage addEntryPage;
        public EntryPagePresenter presenter;

        public MainWindow()
        {
            InitializeComponent();

            store = new Store();
            mainPage = new MainPage(this);
            addEntryPage = new AddEntryPage(this);
            presenter = new EntryPagePresenter(mainPage, addEntryPage, store);
            Main.Content = mainPage;
        }

        private void toolBarAddEntry_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = addEntryPage;
        }
    }
}
