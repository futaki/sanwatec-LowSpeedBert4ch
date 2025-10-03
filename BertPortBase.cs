using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERT
{
    public abstract class BertPortBase
    {
        protected string name;

        public string Name { get { return name; } }

        public abstract bool IsOpen { get; }

        public abstract Task Open();

        public abstract void Close();

        public abstract void WriteLine(string command);

        public abstract string ReadLine();

        public abstract void BertPortNameSet(string name);
    }
}
