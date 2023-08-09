using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Concrete;
using AbstractFactoryPattern.Factory.Abstract;

namespace AbstractFactoryPattern.Factory.Concrete
{
    public class MsSqlDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        => new MsSqlCommand();

        public Connection CreateConnection()
        => new MsSqlConnection();
    }
}