using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace WSyBillApp.FormsTasks
{
    struct Items
    {
        public string m_itemName;
        public string m_itemCategory;
        public string m_itemQuanitity;
        public string m_itemTaxPercent;
        public string m_itemItemTaxValue;
        public string m_itemTaxableValue;
        public string m_itemUnitPriceMrp;
        public string m_itemPrice;
        public string m_ItemsQueryPending;

        public Items(string itemName, string itemCategory, string itemQuanitity, 
                     string itemTaxPercent, string itemUnitPrice, string itemPrice,
                     string sqlQuery)
        {
            m_itemName = itemName;
            m_itemCategory = itemCategory;
            m_itemQuanitity = itemQuanitity;
            m_itemTaxPercent = itemTaxPercent;
            m_itemUnitPriceMrp = itemUnitPrice;
            m_itemPrice = itemPrice;
            m_ItemsQueryPending = sqlQuery;
            m_itemItemTaxValue = "";
            m_itemTaxableValue = "";
            m_itemItemTaxValue = getTaxValue();
            m_itemTaxableValue = getTaxableValue();
        }
        private string getTaxValue()
        {
            Func<string, float> getFloat = (string strValue) =>
            {
                return float.Parse(strValue, CultureInfo.InvariantCulture.NumberFormat);
            };
            // using the MRP here
            float _itemPrice = getFloat(m_itemUnitPriceMrp) * (getFloat(m_itemTaxPercent) / 100);
            return _itemPrice.ToString();
        }
        private string getTaxableValue()
        {
            Func<string, float> getFloat = (string strValue) =>
            {
                return float.Parse(strValue, CultureInfo.InvariantCulture.NumberFormat);
            };
            // using the unitprice here [unitprice * (100 / tax% + 100)]
            float _itemTaxableValue = getFloat(m_itemUnitPriceMrp) * (100/(getFloat(m_itemTaxPercent) + 100));
            return _itemTaxableValue.ToString();
        }
    }

    public partial class FormSales : FormTasks
    {
        private enum State
        {
            addItems,
            addCartClose,
            addInvoice,
            addProposal,
            printbill
        }
        private SettingsUtilityWSBilling genericWsUitilty;
        private string invoiceStr = "";
        private string billDateInv = "";
        private string itemName = "";
        private string itemCategory = "";
        private DataTable dtGridViewCart = null;
        private DateTime localDateTime = DateTime.Now;
        List<Items> itemsInInvoice;
        FormProducts chooseItem;
        FormDealers chooseDealer;
        private float m_totalTaxValue = 0;
        private float m_totalPrice = 0;
        private float m_totalPriceSum = 0;
        private string m_panelBillInvoice = "";
        private string m_tableSaleBill = "SALE_BILL";
        WebBrowser wBrowser = null;
        State currentState = State.addItems;        
        private string[] columns = new string[] { "ID", "INVOICE", "DATE", "DEALER_ID", "ITEM_ID", "QUANTITY", "TAX", "UNIT_PRICE", "PRICE" };
        private string[] sbColumns = new string[] { "ID", "INVOICE", "DISCOUNT", "TAX_SST", "TAX_CST", "TAX_GST", "SUM", "TYPEOFPAY", "DATE" };
        public string[] values = new string[] { "ID", "INVOICE", "DATE", "DEALER_ID", "ITEM_ID", "QUANTITY", "TAX", "UNIT_PRICE", "PRICE" };

        public FormSales()
        {
            tableName = "SALE";
            dtGridViewCart = new DataTable();
            genericWsUitilty = SettingsUtilityWSBilling.Instance();
            itemsInInvoice = new List<Items>();
            InitializeComponent();
            SetStateNext(State.addItems);
            sqlConnection = SqliteConnection.Instance(SettingsUtilityWSBilling.databaseFileCompletepath);
            invoiceStr = "INV-NO-" + SettingsUtilityWSBilling.NanoTime().ToString();
            billDateInv = localDateTime.ToString(SettingsUtilityWSBilling.DateTimeFormatForQuery);
            m_panelBillInvoice = File.ReadAllText(SettingsUtilityWSBilling.BillHtml);
            this.htmlPanelBillInvoice.Text = m_panelBillInvoice;

            AddInvoice();
            AddBillDate();
            AddOrganizationDetails();
            AddTaxSlabsToComboBox();
            this.dataGridViewCart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridViewCart_MouseDown);
        }
        private void DataGridViewCart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = this.dataGridViewCart.HitTest(e.X, e.Y);
                this.dataGridViewCart.ClearSelection();
            }
        }
        private void SetStateNext(State value)
        {
            currentState = value;
            SetButtonStates(currentState);
        }
        private void SetButtonStates(State currentState)
        {
            switch (currentState)
            {
                case State.addItems:
                    this.buttonAddItemToBill.Enabled = true;
                    this.buttonCartClose.Enabled = false;
                    this.buttonAddBillInvoice.Enabled = false;
                    this.buttonInvoicePrint.Enabled = false;
                    break;
                case State.addCartClose:
                    this.buttonAddItemToBill.Enabled = true;
                    this.buttonCartClose.Enabled = true;
                    this.buttonAddBillInvoice.Enabled = false;
                    this.buttonInvoicePrint.Enabled = false;
                    break;
                case State.addInvoice://| State.addProposal:
                    this.buttonAddItemToBill.Enabled = false;
                    this.buttonCartClose.Enabled = false;
                    this.buttonAddBillInvoice.Enabled = true;
                    this.buttonInvoicePrint.Enabled = false;
                    break;
                case State.printbill:
                    this.buttonAddItemToBill.Enabled = false;
                    this.buttonCartClose.Enabled = false;
                    this.buttonAddBillInvoice.Enabled = false;
                    this.buttonInvoicePrint.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void FormSales_Load(object sender, EventArgs e)
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
            labelDealerId.ForeColor = ThemeColor.SecondaryColor;
            labelInvoice.ForeColor = ThemeColor.PrimaryColor;
            labelItemId.ForeColor = ThemeColor.SecondaryColor;
            labelTax.ForeColor = ThemeColor.PrimaryColor;
            labelUnit.ForeColor = ThemeColor.SecondaryColor;
            labelUnitPrice.ForeColor = ThemeColor.PrimaryColor;
            labelDate.ForeColor = ThemeColor.SecondaryColor;
        }
        private void buttonChooseItem_Click(object sender, EventArgs e)
        {
            chooseItem = new FormProducts();
            chooseItem.buttonDoneFinished.Show();
            chooseItem.ShowDialog();
            this.textBoxItemId.Text = chooseItem.values[0];
            itemName = chooseItem.values[1];
            itemCategory = chooseItem.values[2];
            this.textBoxUnitPrice.Text = chooseItem.values[5];
            this.textBoxPriceValue.Text = chooseItem.values[7];
        }
        private void buttonChooseDealerId_Click(object sender, EventArgs e)
        {
            chooseDealer = new FormDealers();
            chooseDealer.buttonDoneFinished.Show();
            chooseDealer.ShowDialog();
            this.textBoxDealerId.Text = chooseDealer.values[0];
            AddDealerDetails(chooseDealer.values[1]+"#"+ chooseDealer.values[2],
                             chooseDealer.values[4], chooseDealer.values[3]);
        }
        private Tuple<float, float, float, string> iterationOnItemsCalculated()
        {
            var sumOfValues = GetTotalSumValueOfAddedItems();
            AddItemsTotalCalcualtedToBill(sumOfValues);
            return sumOfValues;
        }
        private void buttonAddBillInvoice_Click(object sender, EventArgs e)
        {
            int typeofpay = 0; // create and get the index from combo
            int totalDiscount = 0; // create and get the value from input
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (row.DataBoundItem != null)
                {
                    string sqlQuery = $"{SettingsUtilityWSBilling.InsertTable} {tableName} " +
                                  $"({columns[1]}, {columns[2]}, {columns[3]}, {columns[4]}, {columns[5]}, {columns[6]}, {columns[7]}, {columns[8]} )" +
                                  $" VALUES(" +
                                  $"'{row.Cells[1].Value.ToString()}', '{row.Cells[2].Value.ToString()}', " +
                                  $"'{row.Cells[3].Value.ToString()}', '{row.Cells[4].Value.ToString()}', " +
                                  $"'{row.Cells[5].Value.ToString()}', '{row.Cells[6].Value.ToString()}', " +
                                  $"'{row.Cells[7].Value.ToString()}', '{row.Cells[8].Value.ToString()}');";

                    var item = new Items(itemName, itemCategory, row.Cells[5].Value.ToString(),
                                         row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(),
                                         row.Cells[8].Value.ToString(), sqlQuery);
                    itemsInInvoice.Add(item);
                    AddItemtagToBill(item);
                }
            }
            var summarizedBillData = iterationOnItemsCalculated();
            var sqlquerytoexecute = summarizedBillData.Item4.ToString();
            Console.WriteLine($" check this query:\n {sqlquerytoexecute}");
            string ret = sqlConnection.ExecuteSqlQueryScalar(sqlquerytoexecute);
            if (ret.Contains(SettingsUtilityWSBilling.ExceptionStr))
            {
                MessageBox.Show($" Inserting Item had exception: {ret}");
            }
            string billSqlQuery = $"{SettingsUtilityWSBilling.InsertTable} {m_tableSaleBill}" +
                                  $"({sbColumns[1]}, {sbColumns[2]}, {sbColumns[3]}, {sbColumns[4]}, {sbColumns[5]}, {sbColumns[6]}, {sbColumns[7]}, {sbColumns[8]}) " +
                                  $"{SettingsUtilityWSBilling.ValueTag}(" +
                                  $"'{invoiceStr}', {totalDiscount}, {(summarizedBillData.Item2 / 2).ToString()}, " +
                                  $"{(summarizedBillData.Item2/2).ToString()}, {summarizedBillData.Item2.ToString()}, " +
                                  $"{summarizedBillData.Item3.ToString()}, {typeofpay}, '{billDateInv}')" +
                                  $"{SettingsUtilityWSBilling.QueryEndTag}";
            Console.WriteLine($"Bill sale add:\n {billSqlQuery}");
            string ret1 = sqlConnection.ExecuteSqlQueryScalar(billSqlQuery);
            if (ret.Contains(SettingsUtilityWSBilling.ExceptionStr))
            {
                MessageBox.Show($" Inserting Item had exception: {ret1}");
            }
            SetStateNext(State.printbill);
        }
        private void buttonAddItemToBill_Click(object sender, EventArgs e)
        {
            CreateGridTableCart();
            //{ "ID", "INVOICE", "DATE", "DEALER_ID", "ITEM_ID", "QUANTITY", "TAX", "UNIT_PRICE", "PRICE" };
            values[1] = this.textBoxInvoice.Text;
            values[2] = this.dateTimePickerSales.Value.ToString(SettingsUtilityWSBilling.DateTimeFormatForQuery);
            values[3] = this.textBoxDealerId.Text;
            values[4] = this.textBoxItemId.Text;
            values[5] = this.textBoxQuantitySelected.Text;
            values[6] = this.comboBoxTaxSlabs.Text;
            values[7] = this.textBoxUnitPrice.Text;
            values[8] = this.textBoxPriceValue.Text;

            if (values[3] == "" || values[4] == "" || values[5] == "0" || values[8] == "0.00")
            {
                MessageBox.Show("There is inproper information. Return!");
                return;
            }
            else
            {
                AddRowInToSalesItemCart(values);
            }
            SetStateNext(State.addCartClose);
        }
        private void buttonInvoicePrint_Click(object sender, EventArgs e)
        {
            if (currentState == State.printbill)
            {
                wBrowser = new WebBrowser();
                // Add an event handler that prints the document after it loads.
                wBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(PrintDocument);
                wBrowser.DocumentText = this.htmlPanelBillInvoice.Text;
            }
            SetStateNext(State.addItems);
        }
        private void buttonCartClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that to proceed with the items in cart?",
                                            "Confrim closing cart!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            SetStateNext(State.addInvoice);
        }
        private void PrintDocument(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Print the document now that it is fully loaded.
            ((WebBrowser)sender).Print();
        }
        private void CreateGridTableCart()
        {
            if (dtGridViewCart.Columns.Count == 0)
            {
                foreach (string value in columns)
                {
                    Console.WriteLine($" columns - create {value} ");
                    dtGridViewCart.Columns.Add(value);
                }                
            }
        }
        private void AddRowInToSalesItemCart(string[] values)
        {
            DataRow newRow = dtGridViewCart.NewRow();
            for (int i = 1; i < values.Length; i++)
            {
                Console.WriteLine($" Fill at {i} {values[i]} ");
                newRow[i] = values[i];
            }
            dtGridViewCart.Rows.Add(newRow);
            dataGridViewCart.DataSource = dtGridViewCart;
        }
        private void AddInvoice()
        {
            string htmlbillstr = this.htmlPanelBillInvoice.Text;
            this.htmlPanelBillInvoice.Text = htmlbillstr.Replace(SettingsUtilityWSBilling.BillInvoice, invoiceStr);
            this.textBoxInvoice.Text = invoiceStr;
        }
        private void AddBillDate()
        {
            string htmlbillstr = this.htmlPanelBillInvoice.Text;
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillDate, billDateInv);
            this.htmlPanelBillInvoice.Text = htmlbillstr;
        }
        private void AddOrganizationDetails() 
        {
            string htmlbillstr = this.htmlPanelBillInvoice.Text;
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillOrganization, genericWsUitilty.orgDetails.Name);
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillOrgRoad, genericWsUitilty.orgDetails.Road);
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillPlace, genericWsUitilty.orgDetails.Place);
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillPhones, genericWsUitilty.orgDetails.Phone);
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillOrgPin, genericWsUitilty.orgDetails.Pin);
            this.htmlPanelBillInvoice.Text = htmlbillstr;
        }
        private void AddTaxSlabsToComboBox()
        {
            this.comboBoxTaxSlabs.DataSource = FactGetBindingsource(genericWsUitilty.taxSlabPreferences);
        }
        private void AddDealerDetails(string _name = "customer gstn", string _address = "N/A", string _phonenum = "N/A")
        {
            string htmlbillstr = this.htmlPanelBillInvoice.Text;
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillDealerName, _name);
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillDealerAddress, _address);
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillDealerPhone, _phonenum);
            this.htmlPanelBillInvoice.Text = htmlbillstr;
        }
        private void AddItemtagToBill(Items _item) 
        {
            Console.WriteLine($" &*&*&*&*  {_item.m_itemName}_{_item.m_itemCategory}, {_item.m_itemQuanitity}," +
                                    $" {_item.m_itemTaxPercent}, {_item.m_itemPrice}");
            string htmlbillstr = this.htmlPanelBillInvoice.Text;
            string itemTag = SettingsUtilityWSBilling.ItemAddTagSlot_default;
            itemTag = itemTag.Replace(SettingsUtilityWSBilling.BillItemDetails, $"{_item.m_itemName}_{_item.m_itemCategory}");
            itemTag = itemTag.Replace(SettingsUtilityWSBilling.BillItemQuantities, _item.m_itemQuanitity);
            itemTag = itemTag.Replace(SettingsUtilityWSBilling.BillItemTax, _item.m_itemTaxPercent);
            itemTag = itemTag.Replace(SettingsUtilityWSBilling.BillItemTaxValue, _item.m_itemItemTaxValue);
            itemTag = itemTag.Replace(SettingsUtilityWSBilling.BillItemTaxableValue, _item.m_itemTaxableValue);
            itemTag = itemTag.Replace(SettingsUtilityWSBilling.BillItemMrp, _item.m_itemUnitPriceMrp);
            itemTag = itemTag.Replace(SettingsUtilityWSBilling.BillItemPrice, _item.m_itemPrice);
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.BillTagItemsAdd, itemTag);
            this.htmlPanelBillInvoice.Text = htmlbillstr; 
        }
        private void AddItemsTotalCalcualtedToBill(Tuple<float, float, float, string> _sumOfValues)
        {
            string htmlbillstr = this.htmlPanelBillInvoice.Text;
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.SumTaxes, _sumOfValues.Item1.ToString());
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.SumItems, _sumOfValues.Item2.ToString());
            htmlbillstr = htmlbillstr.Replace(SettingsUtilityWSBilling.SumItemsTaxes, _sumOfValues.Item3.ToString());
            this.htmlPanelBillInvoice.Text = htmlbillstr;
        }
        private Tuple<float, float, float, string> GetTotalSumValueOfAddedItems()
        {
            string sqlQueryFormated = "";
            Func<string, float> getFloat = (string strValue) =>
            {
                return float.Parse(strValue, CultureInfo.InvariantCulture.NumberFormat);
            };

            foreach(Items _items in itemsInInvoice )
            {
                m_totalPrice += getFloat(_items.m_itemPrice) * getFloat(_items.m_itemQuanitity);
                m_totalTaxValue += getFloat(_items.m_itemItemTaxValue) * getFloat(_items.m_itemQuanitity);
                sqlQueryFormated += _items.m_ItemsQueryPending;
            }
            m_totalPriceSum = m_totalTaxValue + m_totalPrice;
            return Tuple.Create(m_totalTaxValue, m_totalPrice, m_totalPriceSum, sqlQueryFormated);
        }
        public override void ResetAllOfForm()
        {
            currentState = State.addItems;
            itemsInInvoice.Clear();
            dtGridViewCart.Clear();
            itemName = "";
            itemCategory = "";
            dtGridViewCart = new DataTable();
            SetStateNext(State.addItems);
            localDateTime = DateTime.Now;
            m_totalTaxValue = 0;
            m_totalPrice = 0;
            m_totalPriceSum = 0;
            invoiceStr = "INV-NO-" + SettingsUtilityWSBilling.NanoTime().ToString();
            billDateInv = localDateTime.ToString(SettingsUtilityWSBilling.DateTimeFormatForQuery);
            this.textBoxDealerId.Text = "";
            this.textBoxItemId.Text = "";
            this.htmlPanelBillInvoice.Text = m_panelBillInvoice;

            AddInvoice();
            AddBillDate();
            AddOrganizationDetails();
            AddTaxSlabsToComboBox();
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
