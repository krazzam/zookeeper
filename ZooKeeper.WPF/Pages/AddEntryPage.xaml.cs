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
using ZooKeeper.WPF.Presenters;
using ZooKeeper.WPF.Models;

namespace ZooKeeper.WPF.Pages
{
    /// <summary>
    /// Interaction logic for AddEntryPage.xaml
    /// </summary>
    public partial class AddEntryPage : Page
    {
        MainWindow window;
        ZooConstants zooConstants = new ZooConstants();

        public AddEntryPage(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            init();
        }

        public string getClass()
        {
            return classComboBoxText.Text;
        }

        public string getOrder()
        {
            return orderComboBoxText.Text;
        }

        public string getSpecies()
        {
            return speciesTextBox.Text;
        }

        public string getLocation()
        {
            return locationComboTextBox.Text;
        }

        public string getLastHealthRecord()
        {
            return lastHealthExamDateBox.ToString();
        }

        public void setTag(string tag)
        {
            idTextBox.Text = tag;
        }

        private void addAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            window.presenter?.AddAnimal();
        }

        void init()
        {
            
            foreach (string item in zooConstants.AnimalClasses)
            {
                classComboBoxText.Items.Add(item);
            }

            foreach (string item in zooConstants.Exhibits)
            {
                locationComboTextBox.Items.Add(item);
            }
        }

        private void classComboBoxText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var source = e.Source as ComboBox;
            orderComboBoxText.Items.Clear();

            if (source.SelectedItem.ToString() == "Mammals")
            {
                foreach (string item in zooConstants.MammalOrders)
                {
                    orderComboBoxText.Items.Add(item);
                }
            }
            else if (source.SelectedItem.ToString() == "Reptiles")
            {
                foreach (string item in zooConstants.ReptileOrders)
                {
                    orderComboBoxText.Items.Add(item);
                }
            }
            else
            {
                //nothing
            }
        }
    }
}
