using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSyBillApp.FormsTasks
{
    public partial class FormDealers : FormTasks
    {
        private string[] columns = { "ID", "GSTIN", "NAME", "PHONE", "ADDRESS", "CATEGORY" };
        public string[] values = { "ID", "GSTIN", "NAME", "PHONE", "ADDRESS", "CATEGORY" };
        public FormDealers()
        {
            tableName = "DEALER";
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
        private void FormDealers_Load(object sender, EventArgs e)
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
            labelName.ForeColor = ThemeColor.PrimaryColor;
            labelPhone.ForeColor = ThemeColor.PrimaryColor;
            labelAddress.ForeColor = ThemeColor.PrimaryColor;
            labelGstin.ForeColor = ThemeColor.PrimaryColor;
            labelCategory.ForeColor = ThemeColor.PrimaryColor;
        }

        private void buttonAddDealer_Click(object sender, EventArgs e)
        {
            bool valueCategory = checkBoxIsSupplier.Checked;
            values[1] = textBoxGstin.Text;
            values[2] = textBoxName.Text;
            values[3] = textBoxPhone.Text;
            values[4] = textBoxAddress.Text;
            values[5] = checkBoxIsSupplier.Checked.ToString();

            if (values[0] == "" || values[1] == "")
            {
                return;
            }
            else
            {
                string sqlQuery = $"{SettingsUtilityWSBilling.InsertTable} " +
                                  $"{tableName} ({columns[1]}, {columns[2]}, {columns[3]}, {columns[4]}, {columns[5]} )" +
                                  $" VALUES('{values[1]}', '{values[2]}', '{values[3]}', '{values[4]}', {valueCategory});";
                Console.WriteLine($"{sqlQuery} \nfor insert dealer");
                string ret = sqlConnection.ExecuteSqlQueryScalar(sqlQuery);
                if (ret.Contains(SettingsUtilityWSBilling.ExceptionStr))
                {
                    MessageBox.Show($" Inserting Item had exception: {ret}");
                }
            }
            // check and display the changes
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }

        private void buttonSearchItem_Click(object sender, EventArgs e)
        {
            string gstin = textBoxGstin.Text;
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            bool categorySupp = checkBoxIsSupplier.Checked;
            /*
             * Search query creation.
             */
            string sqlQuery = $"{SettingsUtilityWSBilling.SelectAllFromTable} {tableName} ";
            sqlQuery += $" {SettingsUtilityWSBilling.WhereTag} {columns[5]} = {categorySupp} "; 
            if (gstin != "")
            {
                sqlQuery += $"{SettingsUtilityWSBilling.WhereTag} {columns[0]} = '{gstin}' ";
            }
            if (name != "")
            {
                sqlQuery += $"{SettingsUtilityWSBilling.WhereTag} {columns[1]} = '{name}' ";
            }
            if (phone != "")
            {
                sqlQuery += $"{SettingsUtilityWSBilling.WhereTag} {columns[2]} = '{phone}' ";
            }
            sqlQuery += SettingsUtilityWSBilling.QueryEndTag;

            Console.WriteLine($"{sqlQuery} - Valid?????");
            this.dataGridView.DataSource = GetDataTableSource(sqlQuery, sqlConnection.sqlConnection);
        }

        private void buttonDoneFinished_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                values[5] = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check and display the changes
            this.dataGridView.DataSource = RetrieveFromTable(SettingsUtilityWSBilling.SelectAllFromTable);
        }
    }
}
