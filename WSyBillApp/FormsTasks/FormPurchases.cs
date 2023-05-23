using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSyBillApp.FormsTasks
{
    public partial class FormPurchases : FormTasks
{
        FormProducts chooseItem;
        FormDealers chooseDealer;
        private string itemName = "";
        private string itemCategory = "";
        private string[] columns = new string[] { "ID", "BILLNO", "ITEM_ID", "SELLER_ID", "DATE", "QUANTITY", "TAX", "PRICE_PMRP" };
        public string[] values = new string[] { "ID", "BILLNO", "ITEM_ID", "SELLER", "DATE", "QUANTITY", "TAX", "PRICE_PMRP" };
        public FormPurchases()
        {
            tableName = "PURCHASE";
            InitializeComponent();
            sqlConnection = SqliteConnection.Instance(SettingsUtilityWSBilling.databaseFileCompletepath);
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
        }
        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = this.dataGridView.HitTest(e.X, e.Y);
                this.dataGridView.ClearSelection();
            }
        }
        private void FormPurchases_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.panelControl.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelBillNo.ForeColor = ThemeColor.SecondaryColor;
            labelItemId.ForeColor = ThemeColor.PrimaryColor;
            labelPhone.ForeColor = ThemeColor.SecondaryColor;
            labelPrice.ForeColor = ThemeColor.PrimaryColor;
            labelTax.ForeColor = ThemeColor.SecondaryColor;
            labelUnit.ForeColor = ThemeColor.SecondaryColor;
            labelDate.ForeColor = ThemeColor.SecondaryColor;

        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"{SettingsUtilityWSBilling.SelectAllFromTable} {tableName};";
            this.dataGridView.DataSource = GetDataTableSource(sqlQuery, sqlConnection.sqlConnection);
        }
        private void buttonChooseDealerId_Click(object sender, EventArgs e)
        {
            chooseDealer = new FormDealers();
            chooseDealer.buttonDoneFinished.Show();
            chooseDealer.ShowDialog();
            this.textBoxDealerId.Text = chooseDealer.values[0];
        }
        private void buttonChooseItem_Click(object sender, EventArgs e)
        {
            chooseItem = new FormProducts();
            chooseItem.buttonDoneFinished.Show();
            chooseItem.ShowDialog();
            this.textBoxItemId.Text = chooseItem.values[0];
            itemName = chooseItem.values[1];
            itemCategory = chooseItem.values[2];
        }
        private void buttonSearchPurchase_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"{SettingsUtilityWSBilling.SelectAllFromTable} {tableName}";
            if (this.textBoxBillNo.Text != "")
            {
                sqlQuery += $"{SettingsUtilityWSBilling.WhereTag} {columns[1]}" +
                            $" {SettingsUtilityWSBilling.EqualTag} '{this.textBoxBillNo.Text}'" +
                            $" {SettingsUtilityWSBilling.QueryEndTag}";
            }
            Console.WriteLine($"{sqlQuery}");
            this.dataGridView.DataSource = GetDataTableSource(sqlQuery, sqlConnection.sqlConnection);
        }
        private void buttonAddBill_Click(object sender, EventArgs e)
        {// { "ID", "BILLNO", "ITEM_ID", "SELLER_ID", "DATE", "QUANTITY", "TAX", "PRICE_PMRP" };
            values[1] = this.textBoxBillNo.Text;
            values[2] = this.textBoxItemId.Text;
            values[3] = this.textBoxDealerId.Text;
            values[4] = this.dateTimePickerSales.Value.ToString(SettingsUtilityWSBilling.DateTimeFormatForQuery); ;
            values[5] = this.textBoxUnit.Text;
            values[6] = this.textBoxTax.Text;
            values[7] = this.textBoxPriceValue.Text;
            
            string sqlQuery = $"{SettingsUtilityWSBilling.InsertTable} {tableName} " +
                              $"({columns[1]}, {columns[2]}, {columns[3]}, {columns[4]}, {columns[5]}, {columns[6]}, {columns[7]})" +
                              $" VALUES('{values[1]}', {values[2]}, {values[3]}, " +
                              $"{SettingsUtilityWSBilling.DateTimeSqlFuncTag}('{values[4]}')," +
                              $" {values[5]}, {values[6]}, {values[7]});";
            Console.WriteLine($" Inserting Item sqlQuery: {sqlQuery}");

            if (values[1] == "" || values[2] == "" || values[3] == "" || values[5] == "" || values[6] == "" || values[7] == "" )
            {
                MessageBox.Show($"Incomplete information \n{sqlQuery}", "Error");
                return;
            }
            string ret = sqlConnection.ExecuteSqlQueryScalar(sqlQuery);
            if (ret.Contains(SettingsUtilityWSBilling.ExceptionStr))
            {
                MessageBox.Show($" Inserting Item had exception: {ret}");
            }
            // to refresh automatically
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
            // Also in near future, quantity shall be also updated in to product table as stocks available.
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {// { "ID", "BILLNO", "ITEM_ID", "SELLER_ID", "DATE", "QUANTITY", "TAX", "PRICE_PMRP" };
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                Console.WriteLine($"Check the click ( {e.RowIndex}, {e.ColumnIndex}) => {senderGrid.Rows[e.RowIndex].Cells[0].Value} ");
                values[0] = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                values[1] = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                values[2] = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                values[3] = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                values[4] = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                values[5] = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                values[6] = senderGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                values[7] = senderGrid.Rows[e.RowIndex].Cells[7].Value.ToString();

                this.textBoxBillNo.Text = values[1];
                this.textBoxItemId.Text = values[2];
                this.textBoxDealerId.Text = values[3];
                this.dateTimePickerSales.Text = values[4];
                this.textBoxUnit.Text = values[5];
                this.textBoxTax.Text = values[6];
                this.textBoxPriceValue.Text = values[7];
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // to refresh automatically
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }
    }
}
