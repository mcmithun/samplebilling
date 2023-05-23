using System;
using System.Data.SQLite;
using System.IO;

namespace WSyBillApp
{
    public sealed class SqliteConnection : DBConnector
    {
        public SQLiteConnection sqlConnection = null;
        public SqliteCommandStm sqlCommandStm = null;

        private static SqliteConnection instance = null;
        private bool connectionStatus = false;

        private SqliteConnection(string dbfile)
        {
            ConnectToDatabase(dbfile);
        }
        public static SqliteConnection Instance(string dbfile)
        {
            if (instance == null)
            {
                instance = new SqliteConnection(dbfile);
            }
            return instance;
        }

        private bool ConnectToDatabase(string dbfile)
        {
            sqlConnection = new SQLiteConnection(SettingsUtilityWSBilling.UriFile + dbfile);
            sqlConnection.Open();
            if (sqlConnection == null || sqlConnection.State.ToString() != "Open")
            {
                Console.WriteLine("Opening Failed!");
                return false;
            }
            else
            {
                connectionStatus = true;
            }
            sqlCommandStm = SqliteCommandStm.Instance(sqlConnection);
            string version = sqlCommandStm.GetExecuteCommand("SELECT SQLITE_VERSION()", false);
            Console.WriteLine($"SQLite version: {version} and OPEN"); // Only to make sure that version has been returned by default.
            InitiateCreateTableStructure();
            return connectionStatus;
        }
        public override bool ConnectionStatus()
        {
            return connectionStatus;
        }
        public override bool CreateTable()
        {
            return true;
        }
        public override bool RemoveTable()
        {
            return false;
        }
        public override int InsertData() { return 0; }
        public override int UpdateData() { return 0; }
        public override void ClearTableInDb() { }
        public override void ClearDatabase() { }
        public void InitiateCreateTableStructure()
        {
            // Check is there any table structure present
            ExecuteSqlFile(SettingsUtilityWSBilling.InitiateSqlDataBaseFile);
        }
        public void ExecuteSqlFile(string fileName)
        {
            string sqlQuery = File.ReadAllText(fileName);
            Console.WriteLine($"QUERY:\n {sqlQuery}");
            var ret = sqlCommandStm.GetExecuteCommand(sqlQuery);// Execute the scalar command
            if (ret.Contains("exception"))
            {
                Console.WriteLine($"Caught Exception: {ret} ");
            }
        }

        public string ExecuteSqlQueryScalar(string sqlQuery)
        {
            var ret = sqlCommandStm.GetExecuteCommand(sqlQuery);// Execute the scalar command
            if (ret.Contains("exception"))
            {
                Console.WriteLine($"Caught Exception: {ret} ");
            }
            return ret;
        }
        public string ExecuteSqlQueryNonScalar(string sqlQuery)
        {
            var ret = sqlCommandStm.GetExecuteCommand(sqlQuery, false);// Execute the non scalar command
            if (ret.Contains("exception"))
            {
                Console.WriteLine($"Caught Exception: {ret} ");
            }
            return ret;
        }
    }
}
