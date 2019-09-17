using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    class XmlStream : IReader, IWriter
    {
        string filepath;

        public XmlStream(string filepath)
        {
            this.filepath = filepath;
        }

        public bool populate(Store store)
        {
            return true;
        }

        public bool export(Store store)
        {
            return true;
        }

        public string Filepath
        {
            get { return filepath; }
            set { filepath = value; }
        }
    }
}
