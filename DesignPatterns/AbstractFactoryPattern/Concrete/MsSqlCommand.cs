using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern.Concrete
{
    public class MsSqlCommand : Command
    {
        public override void Execute(string query)
        => Console.WriteLine($"Command executed in MsSql: {query}");
    }
}