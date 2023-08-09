using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern.Factory.Abstract
{
    public interface IDatabaseFactory
    {
        Connection CreateConnection();
        Command CreateCommand();
    }
}