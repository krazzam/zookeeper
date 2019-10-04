using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.WPF.Models
{
    public class ZooConstants
    {
        public readonly List<string> AnimalClasses = new List<string>(new string[]
        {
            "Mammals",
            "Reptiles",
            "Birds",
            "Fish"
        });

        public readonly List<string> MammalOrders = new List<string>(new string[]
        {
            "Carnivores",
            "Primates",
            "Marsupials",
        });


        public readonly List<string> ReptileOrders = new List<string>(new string[]
        {
            "Crododilians",
            "Turtles",
            "Lizards",
            "Snakes"
        });


        public readonly List<string> BirdOrders = new List<string>(new string[]
        {
            "Parrots",
            "Penguins"
        });

        public readonly List<string> Exhibits = new List<string>(new string[]
{
            "Exhibit 1-D",
            "Exhibit 1-F",
            "Exhibit 1-G",
            "Exhibit 2-A",
            "Exhibit 2-B",
            "Exhibit 2-C",
            "Exhibit 2-G",
            "Exhibit 3-A",
            "Exhibit 3-B",
            "Exhibit 3-C",
            "Exhibit 3-G",
            "Exhibit 4-J",
            "Exhibit 5-D",
});
    }
}
