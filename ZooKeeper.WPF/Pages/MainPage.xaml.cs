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

namespace ZooKeeper.WPF.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        MainWindow window;

        public MainPage(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        public void showAnimals(Store store)
        {
            treeView.Items.Clear();

            foreach (Animal animal in store.GetAllAnimals)
            {
                addNode(animal);
            }
        }

        void addNode(Animal animal)
        {
            treeView.Items.Add(animal.Classification.Species);
        }
    }
}
