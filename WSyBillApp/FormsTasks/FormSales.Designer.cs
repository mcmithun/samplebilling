
namespace WSyBillApp.FormsTasks
{
    partial class FormSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSales));
            this.labelTax = new System.Windows.Forms.Label();
            this.textBoxQuantitySelected = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.textBoxDealerId = new System.Windows.Forms.TextBox();
            this.labelDealerId = new System.Windows.Forms.Label();
            this.textBoxInvoice = new System.Windows.Forms.TextBox();
            this.labelInvoice = new System.Windows.Forms.Label();
            this.buttonAddBillInvoice = new System.Windows.Forms.Button();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.dateTimePickerSales = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxPriceValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonCartClose = new System.Windows.Forms.Button();
            this.buttonInvoicePrint = new System.Windows.Forms.Button();
            this.comboBoxInvoiceType = new System.Windows.Forms.ComboBox();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlPanelBillInvoice = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddItemToBill = new System.Windows.Forms.Button();
            this.comboBoxTaxSlabs = new System.Windows.Forms.ComboBox();
            this.buttonChooseDealerId = new System.Windows.Forms.Button();
            this.buttonChooseItem = new System.Windows.Forms.Button();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(218, 43);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(34, 20);
            this.labelTax.TabIndex = 21;
            this.labelTax.Text = "Tax ";
            // 
            // textBoxQuantitySelected
            // 
            this.textBoxQuantitySelected.Location = new System.Drawing.Point(87, 70);
            this.textBoxQuantitySelected.Name = "textBoxQuantitySelected";
            this.textBoxQuantitySelected.Size = new System.Drawing.Size(125, 27);
            this.textBoxQuantitySelected.TabIndex = 5;
            this.textBoxQuantitySelected.Text = "1";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(3, 73);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(65, 20);
            this.labelUnit.TabIndex = 19;
            this.labelUnit.Text = "Quantity";
            // 
            // textBoxItemId
            // 
            this.textBoxItemId.Location = new System.Drawing.Point(296, 7);
            this.textBoxItemId.Name = "textBoxItemId";
            this.textBoxItemId.Size = new System.Drawing.Size(98, 27);
            this.textBoxItemId.TabIndex = 1;
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Location = new System.Drawing.Point(218, 10);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(78, 20);
            this.labelItemId.TabIndex = 17;
            this.labelItemId.Text = "Item Code";
            // 
            // textBoxDealerId
            // 
            this.textBoxDealerId.Location = new System.Drawing.Point(87, 7);
            this.textBoxDealerId.Name = "textBoxDealerId";
            this.textBoxDealerId.Size = new System.Drawing.Size(98, 27);
            this.textBoxDealerId.TabIndex = 0;
            // 
            // labelDealerId
            // 
            this.labelDealerId.AutoSize = true;
            this.labelDealerId.Location = new System.Drawing.Point(3, 10);
            this.labelDealerId.Name = "labelDealerId";
            this.labelDealerId.Size = new System.Drawing.Size(72, 20);
            this.labelDealerId.TabIndex = 15;
            this.labelDealerId.Text = "Dealer ID";
            // 
            // textBoxInvoice
            // 
            this.textBoxInvoice.Location = new System.Drawing.Point(87, 40);
            this.textBoxInvoice.Name = "textBoxInvoice";
            this.textBoxInvoice.Size = new System.Drawing.Size(125, 27);
            this.textBoxInvoice.TabIndex = 3;
            // 
            // labelInvoice
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Location = new System.Drawing.Point(3, 43);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(56, 20);
            this.labelInvoice.TabIndex = 13;
            this.labelInvoice.Text = "Invoice";
            // 
            // buttonAddBillInvoice
            // 
            this.buttonAddBillInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBillInvoice.Enabled = false;
            this.buttonAddBillInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddBillInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddBillInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddBillInvoice.Image")));
            this.buttonAddBillInvoice.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddBillInvoice.Location = new System.Drawing.Point(476, 612);
            this.buttonAddBillInvoice.Name = "buttonAddBillInvoice";
            this.buttonAddBillInvoice.Size = new System.Drawing.Size(144, 44);
            this.buttonAddBillInvoice.TabIndex = 12;
            this.buttonAddBillInvoice.Text = "Add Invoice";
            this.buttonAddBillInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddBillInvoice.UseVisualStyleBackColor = true;
            this.buttonAddBillInvoice.Click += new System.EventHandler(this.buttonAddBillInvoice_Click);
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(296, 70);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(125, 27);
            this.textBoxUnitPrice.TabIndex = 6;
            this.textBoxUnitPrice.Text = "0.00";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(218, 73);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.labelUnitPrice.TabIndex = 23;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // dateTimePickerSales
            // 
            this.dateTimePickerSales.Location = new System.Drawing.Point(495, 8);
            this.dateTimePickerSales.Name = "dateTimePickerSales";
            this.dateTimePickerSales.Size = new System.Drawing.Size(175, 27);
            this.dateTimePickerSales.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(448, 13);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 20);
            this.labelDate.TabIndex = 26;
            this.labelDate.Text = "Date";
            // 
            // textBoxPriceValue
            // 
            this.textBoxPriceValue.Location = new System.Drawing.Point(495, 70);
            this.textBoxPriceValue.Name = "textBoxPriceValue";
            this.textBoxPriceValue.Size = new System.Drawing.Size(125, 27);
            this.textBoxPriceValue.TabIndex = 7;
            this.textBoxPriceValue.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Price";
            // 
            // panelControl
            // 
            this.panelControl.AutoSize = true;
            this.panelControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.buttonCartClose);
            this.panelControl.Controls.Add(this.buttonInvoicePrint);
            this.panelControl.Controls.Add(this.comboBoxInvoiceType);
            this.panelControl.Controls.Add(this.dataGridViewCart);
            this.panelControl.Controls.Add(this.htmlPanelBillInvoice);
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Controls.Add(this.buttonAddBillInvoice);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(782, 662);
            this.panelControl.TabIndex = 29;
            // 
            // buttonCartClose
            // 
            this.buttonCartClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCartClose.Enabled = false;
            this.buttonCartClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCartClose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCartClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonCartClose.Image")));
            this.buttonCartClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCartClose.Location = new System.Drawing.Point(326, 612);
            this.buttonCartClose.Name = "buttonCartClose";
            this.buttonCartClose.Size = new System.Drawing.Size(144, 44);
            this.buttonCartClose.TabIndex = 17;
            this.buttonCartClose.Text = "Apply Cart";
            this.buttonCartClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCartClose.UseVisualStyleBackColor = true;
            this.buttonCartClose.Click += new System.EventHandler(this.buttonCartClose_Click);
            // 
            // buttonInvoicePrint
            // 
            this.buttonInvoicePrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInvoicePrint.Enabled = false;
            this.buttonInvoicePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInvoicePrint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInvoicePrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonInvoicePrint.Image")));
            this.buttonInvoicePrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonInvoicePrint.Location = new System.Drawing.Point(626, 612);
            this.buttonInvoicePrint.Name = "buttonInvoicePrint";
            this.buttonInvoicePrint.Size = new System.Drawing.Size(144, 44);
            this.buttonInvoicePrint.TabIndex = 16;
            this.buttonInvoicePrint.Text = "Invoice Print";
            this.buttonInvoicePrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInvoicePrint.UseVisualStyleBackColor = true;
            this.buttonInvoicePrint.Click += new System.EventHandler(this.buttonInvoicePrint_Click);
            // 
            // comboBoxInvoiceType
            // 
            this.comboBoxInvoiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInvoiceType.DisplayMember = "Invoice";
            this.comboBoxInvoiceType.FormattingEnabled = true;
            this.comboBoxInvoiceType.Items.AddRange(new object[] {
            "Proposal",
            "Invoice"});
            this.comboBoxInvoiceType.Location = new System.Drawing.Point(145, 621);
            this.comboBoxInvoiceType.Name = "comboBoxInvoiceType";
            this.comboBoxInvoiceType.Size = new System.Drawing.Size(151, 28);
            this.comboBoxInvoiceType.TabIndex = 15;
            this.comboBoxInvoiceType.ValueMember = "Invoice";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCart.Location = new System.Drawing.Point(0, 105);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 29;
            this.dataGridViewCart.Size = new System.Drawing.Size(780, 162);
            this.dataGridViewCart.TabIndex = 14;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 52);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.editToolStripMenuItem.Text = "Edit/Update";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // htmlPanelBillInvoice
            // 
            this.htmlPanelBillInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlPanelBillInvoice.AutoScroll = true;
            this.htmlPanelBillInvoice.AutoScrollMinSize = new System.Drawing.Size(773, 0);
            this.htmlPanelBillInvoice.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanelBillInvoice.BaseStylesheet = null;
            this.htmlPanelBillInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.htmlPanelBillInvoice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.htmlPanelBillInvoice.Location = new System.Drawing.Point(0, 273);
            this.htmlPanelBillInvoice.Name = "htmlPanelBillInvoice";
            this.htmlPanelBillInvoice.Size = new System.Drawing.Size(777, 334);
            this.htmlPanelBillInvoice.TabIndex = 13;
            this.htmlPanelBillInvoice.Text = "<Bill>";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDealerId);
            this.panel1.Controls.Add(this.textBoxQuantitySelected);
            this.panel1.Controls.Add(this.labelTax);
            this.panel1.Controls.Add(this.buttonAddItemToBill);
            this.panel1.Controls.Add(this.comboBoxTaxSlabs);
            this.panel1.Controls.Add(this.labelUnit);
            this.panel1.Controls.Add(this.buttonChooseDealerId);
            this.panel1.Controls.Add(this.textBoxItemId);
            this.panel1.Controls.Add(this.buttonChooseItem);
            this.panel1.Controls.Add(this.labelUnitPrice);
            this.panel1.Controls.Add(this.textBoxDealerId);
            this.panel1.Controls.Add(this.labelItemId);
            this.panel1.Controls.Add(this.textBoxUnitPrice);
            this.panel1.Controls.Add(this.textBoxPriceValue);
            this.panel1.Controls.Add(this.dateTimePickerSales);
            this.panel1.Controls.Add(this.textBoxInvoice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelInvoice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 105);
            this.panel1.TabIndex = 8;
            // 
            // buttonAddItemToBill
            // 
            this.buttonAddItemToBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddItemToBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddItemToBill.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddItemToBill.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddItemToBill.Image")));
            this.buttonAddItemToBill.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddItemToBill.Location = new System.Drawing.Point(633, 58);
            this.buttonAddItemToBill.Name = "buttonAddItemToBill";
            this.buttonAddItemToBill.Size = new System.Drawing.Size(144, 44);
            this.buttonAddItemToBill.TabIndex = 10;
            this.buttonAddItemToBill.Text = "Add Item";
            this.buttonAddItemToBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddItemToBill.UseVisualStyleBackColor = true;
            this.buttonAddItemToBill.Click += new System.EventHandler(this.buttonAddItemToBill_Click);
            // 
            // comboBoxTaxSlabs
            // 
            this.comboBoxTaxSlabs.FormattingEnabled = true;
            this.comboBoxTaxSlabs.Items.AddRange(new object[] {
            "3",
            "5",
            "12",
            "18",
            "28"});
            this.comboBoxTaxSlabs.Location = new System.Drawing.Point(296, 40);
            this.comboBoxTaxSlabs.Name = "comboBoxTaxSlabs";
            this.comboBoxTaxSlabs.Size = new System.Drawing.Size(125, 28);
            this.comboBoxTaxSlabs.TabIndex = 4;
            // 
            // buttonChooseDealerId
            // 
            this.buttonChooseDealerId.Location = new System.Drawing.Point(186, 6);
            this.buttonChooseDealerId.Name = "buttonChooseDealerId";
            this.buttonChooseDealerId.Size = new System.Drawing.Size(26, 29);
            this.buttonChooseDealerId.TabIndex = 31;
            this.buttonChooseDealerId.Text = "...";
            this.buttonChooseDealerId.UseVisualStyleBackColor = true;
            this.buttonChooseDealerId.Click += new System.EventHandler(this.buttonChooseDealerId_Click);
            // 
            // buttonChooseItem
            // 
            this.buttonChooseItem.Location = new System.Drawing.Point(395, 6);
            this.buttonChooseItem.Name = "buttonChooseItem";
            this.buttonChooseItem.Size = new System.Drawing.Size(26, 29);
            this.buttonChooseItem.TabIndex = 30;
            this.buttonChooseItem.Text = "...";
            this.buttonChooseItem.UseVisualStyleBackColor = true;
            this.buttonChooseItem.Click += new System.EventHandler(this.buttonChooseItem_Click);
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 662);
            this.Controls.Add(this.panelControl);
            this.Name = "FormSales";
            this.Text = "FormSales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.TextBox textBoxQuantitySelected;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.TextBox textBoxDealerId;
        private System.Windows.Forms.Label labelDealerId;
        private System.Windows.Forms.TextBox textBoxInvoice;
        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.Button buttonAddBillInvoice;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerSales;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxPriceValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonChooseItem;
        private System.Windows.Forms.Button buttonChooseDealerId;
        private System.Windows.Forms.ComboBox comboBoxTaxSlabs;
        private System.Windows.Forms.Button buttonAddItemToBill;
        private System.Windows.Forms.Panel panel1;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel htmlPanelBillInvoice;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.ComboBox comboBoxInvoiceType;
        private System.Windows.Forms.Button buttonInvoicePrint;
        private System.Windows.Forms.Button buttonCartClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}