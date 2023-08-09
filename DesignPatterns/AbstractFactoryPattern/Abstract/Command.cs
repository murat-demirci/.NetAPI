using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Abstract
{
    public abstract class Command
    {
        public abstract void Execute(string query);
    }
}