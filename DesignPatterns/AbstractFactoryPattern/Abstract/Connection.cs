using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Abstract
{
    public abstract class Connection
    {
        public abstract bool Open();
        public abstract bool Close();
    }
}