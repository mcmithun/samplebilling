using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WSyBillApp.FormsTasks
{
    public partial class FormProducts : FormTasks
    {
        private string[] columns = { "ID", "NAME", "TYPE", "TAXSLAB", "VARIABLE", "PUNIT_PRICE", "PMRP_PRICE", "MRP_PRICE" };
        public string[] values = { "ID", "NAME", "TYPE", "TAXSLAB", "VARIABLE", "PUNIT_PRICE", "PMRP_PRICE", "MRP_PRICE" };
        public FormProducts()
        {
            tableName = "ITEM";
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
        private void FormProducts_Load(object sender, EventArgs e)
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
            labelItemName.ForeColor = ThemeColor.SecondaryColor;
            labelItemType.ForeColor = ThemeColor.PrimaryColor;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }

        private void buttonSearchItem_Click(object sender, EventArgs e)
        {
            string name = comboBoxItemName.Text;
            string type = comboBoxItemType.Text;
            /*
             * Search query creation. If name or type present, search has a WHERE condition.
             * Similarly, if type is present, add that condition after the "where".
             * If second variable also is present then use an AND, else only second var as cond. 
             */
            string sqlQuery = $"{SettingsUtilityWSBilling.SelectAllFromTable} {tableName} ";
            if (name != "" || type != "")
            {
                sqlQuery += SettingsUtilityWSBilling.WhereTag;
            }
            if (type != "")
            {
                sqlQuery += $"{columns[1]} = '{type}' ";
            }
            if (name != "" && type != "")
            {
                sqlQuery += SettingsUtilityWSBilling.AndTag;
            }
            if (name != "")
            {
                sqlQuery += $"{columns[0]} = '{name}' ";
            }
            sqlQuery += SettingsUtilityWSBilling.QueryEndTag;

            Console.WriteLine($"{sqlQuery} - Valid?????");
            this.dataGridView.DataSource = GetDataTableSource(sqlQuery, sqlConnection.sqlConnection);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

                comboBoxItemName.Text = values[1];
                comboBoxItemType.Text = values[2];
                comboBoxPurchaseSlab.Text = values[3];
                textBoxVariyingCes.Text = values[4];
                textBoxUnitPrice.Text = values[5];
                textBoxNetPurMRP.Text = values[6];
                textBoxMRP.Text = values[7];
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (comboBoxItemName.Text == "" || comboBoxItemType.Text == "")
            {
                MessageBox.Show($" Inserting Item has improper information.");
                return;
            }
            string sqlQuery = $"{SettingsUtilityWSBilling.InsertTable} {tableName} " +
                                $"({columns[1]}, {columns[2]}, {columns[3]}, {columns[4]}, {columns[5]}, {columns[6]}, {columns[7]})" +
                                $" VALUES('{comboBoxItemName.Text}', '{comboBoxItemType.Text}', {comboBoxPurchaseSlab.Text}," +
                                $" {textBoxVariyingCes.Text}, {textBoxUnitPrice.Text}, {textBoxNetPurMRP.Text}, {textBoxMRP.Text});";

            MessageBox.Show($" Inserting Item sqlQuery: {sqlQuery}");
            string ret = sqlConnection.ExecuteSqlQueryScalar(sqlQuery);
            if (ret.Contains(SettingsUtilityWSBilling.ExceptionStr))
            {
                MessageBox.Show($" Inserting Item had exception: {ret}");
            }
            // to refresh automatically
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }

        private void buttonDoneFinished_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // to refresh automatically
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }
    }
}
