using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Concrete;
using AbstractFactoryPattern.Factory.Abstract;

namespace AbstractFactoryPattern.Factory.Concrete
{
    public class OracleDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        => new OracleCommand();

        public Connection CreateConnection()
        =>new OracleConnection();
    }
}