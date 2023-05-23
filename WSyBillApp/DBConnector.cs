namespace WSyBillApp
{
    public abstract class DBConnector
    {
        public abstract bool ConnectionStatus();
        public abstract bool CreateTable();
        public abstract bool RemoveTable();
        public abstract int InsertData();
        public abstract int UpdateData();
        public abstract void ClearTableInDb();
        public abstract void ClearDatabase();

    }
}
