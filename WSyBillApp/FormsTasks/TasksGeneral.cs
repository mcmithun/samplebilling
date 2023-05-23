using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WSyBillApp.FormsTasks
{
    public partial class FormTasks : Form
    {
        public SqliteConnection sqlConnection = null;
        public SQLiteDataAdapter sqlda = null;
        public DataTable dt = null;
        public string tableName = "default";
        public FormTasks()
        {
            //sqlConnection = SqliteConnection.Instance(GenericWSBilling.DatabaseFileCompletepath);
        }
        public virtual void ResetAllOfForm() { }
        public DataTable RetrieveFromTable(string typeQuery)
        {
            string sqlQuery = $"{typeQuery} {tableName};";
            return GetDataTableSource(sqlQuery, sqlConnection.sqlConnection);
        }
        public DataTable GetDataTableSource(string sqlQuery, SQLiteConnection objSQLiteConnection)
        {
            sqlda = new SQLiteDataAdapter(sqlQuery, objSQLiteConnection);
            dt = new DataTable();
            try
            {
                sqlda.Fill(dt);
            }
            catch(SQLiteException e)
            {
                MessageBox.Show($" exception in dataAdapter: {e.ToString()}");
            }
            return dt;
        }
        public BindingSource FactGetBindingsource(List<string> listOfData)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = listOfData;
            return bs;
        }
    }
}
