using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Factory.Abstract;

namespace AbstractFactoryPattern
{
    public class DatabaseOperations
    {
        private readonly IDatabaseFactory _dbFactory;
        private readonly Connection _con;
        private readonly Command _cmd;

        public DatabaseOperations(IDatabaseFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _cmd = _dbFactory.CreateCommand();
            _con = _dbFactory.CreateConnection();
        }

        public void RemoveId(int id){
            _con.Open();
            _cmd.Execute("Delete from table where id = " + id);
            _con.Close();
        }
    }
}