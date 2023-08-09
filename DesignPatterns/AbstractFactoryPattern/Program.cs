using AbstractFactoryPattern;
using AbstractFactoryPattern.Factory.Concrete;

DatabaseOperations oracleDb = new(new OracleDatabaseFactory());
oracleDb.RemoveId(1);

DatabaseOperations mssqlDb = new(new MsSqlDatabaseFactory());
mssqlDb.RemoveId(2);