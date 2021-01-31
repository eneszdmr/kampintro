using System;

namespace InterfaceAnlama
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleDatabase oracleDatabase = new OracleDatabase();

            IDatabaseManager databaseManager = new MysqlDatabase();
            databaseManager.add();


        }
    }
}
