using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSyBillApp.FormsTasks
{
    public partial class FormReports : FormTasks
    {
        private string[] purchaseColumns = new string[] { "ID", "BILLNO", "ITEM_ID", "SELLER_ID", "DATE", "QUANTITY", "TAX", "PRICE_PMRP" };
        public string[] purchaseValues = new string[] { "0", "BILLNO", "0", "0", "DATE", "0", "0", "0" };
        private string[] salesColumns = new string[] { "ID", "INVOICE", "DATE", "DEALER_ID", "ITEM_ID", "QUANTITY", "TAX", "UNIT_PRICE", "PRICE" };
        public string[] salesValues = new string[] { "0", "INVOICE", "DATE", "0", "0", "0", "0", "0", "0" };
        public int selectedGridRowIndex { get; private set; }
        public FormReports()
        {
            InitializeComponent();
            sqlConnection = SqliteConnection.Instance(SettingsUtilityWSBilling.databaseFileCompletepath);
            this.comboBoxPurticularTypes.SelectedIndex = 0;
            selectedGridRowIndex = -1;
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
        }
        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = this.dataGridView.HitTest(e.X, e.Y);
                this.dataGridView.ClearSelection();
                if (this.dataGridView.Rows.Count > 0)
                {
                    this.dataGridView.Rows[hti.RowIndex].Selected = true;
                }
            }
        }
        private void FormReports_Load(object sender, EventArgs e)
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
            labelFrom.ForeColor = ThemeColor.SecondaryColor;
            labelTo.ForeColor = ThemeColor.PrimaryColor;
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // check and display the changes
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }
        private void buttonGetReport_Click(object sender, EventArgs e)
        {
            string fromDate = dateTimePickerFrom.Value.ToString(SettingsUtilityWSBilling.DateTimeFormatForQuery);
            string toDate = dateTimePickerTo.Value.ToString(SettingsUtilityWSBilling.DateTimeFormatForQuery);
            string sqlQuery = $"{SettingsUtilityWSBilling.SelectAllFromTable} {tableName} " +
                              $"WHERE `DATE` BETWEEN '{fromDate}' AND '{toDate}' ;";
            Console.WriteLine(sqlQuery);
            this.dataGridView.DataSource = GetDataTableSource(sqlQuery, sqlConnection.sqlConnection);
        }
        private void comboBoxPurticularTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableName = this.comboBoxPurticularTypes.Text;
            dataGridView.DataSource = null;
            dataGridView.Refresh();
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($" dataGridView_CellContentClick {e.RowIndex} ");
        }
        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dataGridView.ClearSelection();
                    this.dataGridView.Rows[rowSelected].Selected = true;
                }
            }
        }
        private void dataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            Console.WriteLine($" dataGridView_CellContextMenuStripNeeded {e.RowIndex} ");
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Rows are not relevent.", "Error");
                return;
            }
            selectedGridRowIndex = e.RowIndex;
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {   //{ "ID", "BILLNO", "ITEM_ID", "SELLER_ID", "DATE", "QUANTITY", "TAX", "PRICE_PMRP" };
            //{ "ID", "INVOICE", "DATE", "DEALER_ID", "ITEM_ID", "QUANTITY", "TAX", "UNIT_PRICE", "PRICE" };
            //{ "ID", "INVOICE", "DISCOUNT", "TAX_SST", "TAX_CST", "TAX_GST", "SUM", "TYPEOFPAY", "DATE" };
            Console.WriteLine($" updateToolStripMenuItem_Click {e.ToString()} ");
            if (selectedGridRowIndex < 0)
            {
                MessageBox.Show("Rows are not relevent.", "Error");
                return;
            }
            if (tableName == "SALE")
            {
                salesValues[0] = this.dataGridView.Rows[selectedGridRowIndex].Cells[0].Value.ToString();
                salesValues[1] = this.dataGridView.Rows[selectedGridRowIndex].Cells[1].Value.ToString();
                salesValues[2] = this.dataGridView.Rows[selectedGridRowIndex].Cells[2].Value.ToString();
                salesValues[3] = this.dataGridView.Rows[selectedGridRowIndex].Cells[3].Value.ToString();
                salesValues[4] = this.dataGridView.Rows[selectedGridRowIndex].Cells[4].Value.ToString();
                salesValues[5] = this.dataGridView.Rows[selectedGridRowIndex].Cells[5].Value.ToString();
                salesValues[6] = this.dataGridView.Rows[selectedGridRowIndex].Cells[6].Value.ToString();
                salesValues[7] = this.dataGridView.Rows[selectedGridRowIndex].Cells[7].Value.ToString();
                salesValues[8] = this.dataGridView.Rows[selectedGridRowIndex].Cells[8].Value.ToString();

                string sqlQuery = $"{SettingsUtilityWSBilling.UpdateTable} {tableName}" +
                    $"{SettingsUtilityWSBilling.SetTag} " +
                    $"{salesColumns[1]} {SettingsUtilityWSBilling.EqualTag} '{salesValues[1]}'," +
                    $"{salesColumns[2]} {SettingsUtilityWSBilling.EqualTag} '{salesValues[2]}'," +
                    $"{salesColumns[3]} {SettingsUtilityWSBilling.EqualTag} {salesValues[3]}," +
                    $"{salesColumns[4]} {SettingsUtilityWSBilling.EqualTag} {salesValues[4]}," +
                    $"{salesColumns[5]} {SettingsUtilityWSBilling.EqualTag} {salesValues[5]}," +
                    $"{salesColumns[6]} {SettingsUtilityWSBilling.EqualTag} {salesValues[6]}," +
                    $"{salesColumns[7]} {SettingsUtilityWSBilling.EqualTag} {salesValues[7]}," +
                    $"{salesColumns[8]} {SettingsUtilityWSBilling.EqualTag} {salesValues[8]} " +
                    $"{SettingsUtilityWSBilling.WhereTag} {salesColumns[0]} {SettingsUtilityWSBilling.EqualTag} {salesValues[0]}" +
                    $"{SettingsUtilityWSBilling.QueryEndTag}";
                Console.WriteLine($"SALES update: {sqlQuery}");
            }
            else
            {
                purchaseValues[0] = this.dataGridView.Rows[selectedGridRowIndex].Cells[0].Value.ToString();
                purchaseValues[1] = this.dataGridView.Rows[selectedGridRowIndex].Cells[1].Value.ToString();
                purchaseValues[2] = this.dataGridView.Rows[selectedGridRowIndex].Cells[2].Value.ToString();
                purchaseValues[3] = this.dataGridView.Rows[selectedGridRowIndex].Cells[3].Value.ToString();
                purchaseValues[4] = this.dataGridView.Rows[selectedGridRowIndex].Cells[4].Value.ToString();
                purchaseValues[5] = this.dataGridView.Rows[selectedGridRowIndex].Cells[5].Value.ToString();
                purchaseValues[6] = this.dataGridView.Rows[selectedGridRowIndex].Cells[6].Value.ToString();
                purchaseValues[7] = this.dataGridView.Rows[selectedGridRowIndex].Cells[7].Value.ToString();

                string sqlQuery = $"{SettingsUtilityWSBilling.UpdateTable} {tableName}" +
                    $"{SettingsUtilityWSBilling.SetTag} " +
                    $"{purchaseColumns[1]} {SettingsUtilityWSBilling.EqualTag} '{purchaseValues[1]}'," +
                    $"{purchaseColumns[2]} {SettingsUtilityWSBilling.EqualTag} {purchaseValues[2]}," +
                    $"{purchaseColumns[3]} {SettingsUtilityWSBilling.EqualTag} {purchaseValues[3]}," +
                    $"{purchaseColumns[4]} {SettingsUtilityWSBilling.EqualTag} '{purchaseValues[4]}'," +
                    $"{purchaseColumns[5]} {SettingsUtilityWSBilling.EqualTag} {purchaseValues[5]}," +
                    $"{purchaseColumns[6]} {SettingsUtilityWSBilling.EqualTag} {purchaseValues[6]}," +
                    $"{purchaseColumns[7]} {SettingsUtilityWSBilling.EqualTag} {purchaseValues[7]}," +
                    $"{SettingsUtilityWSBilling.WhereTag} " +
                    $"{purchaseColumns[0]} {SettingsUtilityWSBilling.EqualTag} {purchaseValues[0]}" +
                    $"{SettingsUtilityWSBilling.QueryEndTag}";
                Console.WriteLine($"PURCHASE update: {sqlQuery}");
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine($" deleteToolStripMenuItem_Click {e.ToString()} ");
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check and display the changes
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }
    }
}
