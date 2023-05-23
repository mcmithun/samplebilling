
namespace WSyBillApp.FormsTasks
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemType = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPurchaseSlab = new System.Windows.Forms.ComboBox();
            this.textBoxVariyingCes = new System.Windows.Forms.TextBox();
            this.textBoxMRP = new System.Windows.Forms.TextBox();
            this.textBoxNetPurMRP = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.buttonSearchItem = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDoneFinished = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddItem.Image")));
            this.buttonAddItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddItem.Location = new System.Drawing.Point(634, 95);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(145, 44);
            this.buttonAddItem.TabIndex = 0;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(141, 10);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(169, 26);
            this.comboBoxItemName.TabIndex = 1;
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(141, 39);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(169, 26);
            this.comboBoxItemType.TabIndex = 2;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItemName.Location = new System.Drawing.Point(12, 13);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(80, 18);
            this.labelItemName.TabIndex = 3;
            this.labelItemName.Text = "Item Name";
            // 
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItemType.Location = new System.Drawing.Point(12, 42);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(72, 18);
            this.labelItemType.TabIndex = 4;
            this.labelItemType.Text = "Item Type";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.comboBoxPurchaseSlab);
            this.panelControl.Controls.Add(this.textBoxVariyingCes);
            this.panelControl.Controls.Add(this.textBoxMRP);
            this.panelControl.Controls.Add(this.textBoxNetPurMRP);
            this.panelControl.Controls.Add(this.textBoxUnitPrice);
            this.panelControl.Controls.Add(this.buttonSearchItem);
            this.panelControl.Controls.Add(this.labelItemName);
            this.panelControl.Controls.Add(this.labelItemType);
            this.panelControl.Controls.Add(this.buttonAddItem);
            this.panelControl.Controls.Add(this.comboBoxItemName);
            this.panelControl.Controls.Add(this.comboBoxItemType);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(782, 142);
            this.panelControl.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tax Slab";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Net MRP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Variable%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "MRP";
            // 
            // comboBoxPurchaseSlab
            // 
            this.comboBoxPurchaseSlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPurchaseSlab.FormattingEnabled = true;
            this.comboBoxPurchaseSlab.Location = new System.Drawing.Point(665, 10);
            this.comboBoxPurchaseSlab.Name = "comboBoxPurchaseSlab";
            this.comboBoxPurchaseSlab.Size = new System.Drawing.Size(105, 26);
            this.comboBoxPurchaseSlab.TabIndex = 10;
            // 
            // textBoxVariyingCes
            // 
            this.textBoxVariyingCes.Location = new System.Drawing.Point(401, 39);
            this.textBoxVariyingCes.Name = "textBoxVariyingCes";
            this.textBoxVariyingCes.Size = new System.Drawing.Size(169, 24);
            this.textBoxVariyingCes.TabIndex = 9;
            // 
            // textBoxMRP
            // 
            this.textBoxMRP.Location = new System.Drawing.Point(401, 10);
            this.textBoxMRP.Name = "textBoxMRP";
            this.textBoxMRP.Size = new System.Drawing.Size(169, 24);
            this.textBoxMRP.TabIndex = 8;
            // 
            // textBoxNetPurMRP
            // 
            this.textBoxNetPurMRP.Location = new System.Drawing.Point(141, 95);
            this.textBoxNetPurMRP.Name = "textBoxNetPurMRP";
            this.textBoxNetPurMRP.Size = new System.Drawing.Size(169, 24);
            this.textBoxNetPurMRP.TabIndex = 7;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(141, 68);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(169, 24);
            this.textBoxUnitPrice.TabIndex = 6;
            // 
            // buttonSearchItem
            // 
            this.buttonSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearchItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchItem.Image")));
            this.buttonSearchItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchItem.Location = new System.Drawing.Point(527, 95);
            this.buttonSearchItem.Name = "buttonSearchItem";
            this.buttonSearchItem.Size = new System.Drawing.Size(101, 44);
            this.buttonSearchItem.TabIndex = 5;
            this.buttonSearchItem.Text = "Search";
            this.buttonSearchItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchItem.UseVisualStyleBackColor = true;
            this.buttonSearchItem.Click += new System.EventHandler(this.buttonSearchItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 142);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(782, 278);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(754, 399);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(25, 21);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDoneFinished
            // 
            this.buttonDoneFinished.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDoneFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoneFinished.Location = new System.Drawing.Point(688, 420);
            this.buttonDoneFinished.Name = "buttonDoneFinished";
            this.buttonDoneFinished.Size = new System.Drawing.Size(94, 33);
            this.buttonDoneFinished.TabIndex = 15;
            this.buttonDoneFinished.Text = "Done";
            this.buttonDoneFinished.UseVisualStyleBackColor = true;
            this.buttonDoneFinished.Visible = false;
            this.buttonDoneFinished.Click += new System.EventHandler(this.buttonDoneFinished_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.buttonDoneFinished);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearchItem;
        public System.Windows.Forms.Button buttonAddItem;
        public System.Windows.Forms.Button buttonDoneFinished;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxVariyingCes;
        private System.Windows.Forms.TextBox textBoxMRP;
        private System.Windows.Forms.TextBox textBoxNetPurMRP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPurchaseSlab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}