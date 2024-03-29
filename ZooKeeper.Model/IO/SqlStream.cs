﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Model
{
    class SqlStream : IReader, IWriter
    {
        public SqlStream(string filepath)
        {
            Filepath = filepath;
        }

        public bool populate(Store store)
        {
            return true;
        }

        public bool export(Store store)
        {
            return true;
        }

        public string Filepath { get; set; }
    }
}
