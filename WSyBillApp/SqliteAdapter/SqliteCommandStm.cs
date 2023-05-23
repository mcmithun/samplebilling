using System.Data.SQLite;

namespace WSyBillApp
{
    public class SqliteCommandStm
    {
        private static SQLiteCommand stmCommand = null;
        private static SqliteCommandStm instance = null;
        private SqliteCommandStm(SQLiteConnection sqlConnection)
        {
            stmCommand = new SQLiteCommand("", sqlConnection);
        }
        public static SqliteCommandStm Instance(SQLiteConnection _sqlConnection)
        {
            if (instance == null)
            {
                instance = new SqliteCommandStm(_sqlConnection);
            }
            return instance;
        }

        public string GetExecuteCommand(string _statement, bool scalar = true/*true: execute and forget*/)
        {
            string output = "default";
            stmCommand.CommandText = _statement;
            if (scalar)
            {
                try
                {
                    output += " {" + stmCommand.ExecuteNonQuery() + "} effected.";
                }
                catch (SQLiteException localException)
                {
                    output = "SQLiteException: " + localException.Message;
                }
            }
            else
            {
                try
                {
                    output = stmCommand.ExecuteScalar().ToString();
                }
                catch (SQLiteException localException)
                {
                    output = "SQLiteException: " + localException.Message;
                }
            }
            return output;
        }
        public void CloseCommand()
        {
            stmCommand.Dispose();
        }
    }
}
