using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    public interface IAnimal
    {
        string ID { get; }
        string Exhibit { get; set; }
        Classification Classification { get; }
        DateTime LastHealthExam { get; set; }
    }
}
