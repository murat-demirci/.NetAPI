using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern.Concrete
{
    public class OracleConnection : Connection
    {
        public override bool Close() => false;
        public override bool Open() => true;
    }
}