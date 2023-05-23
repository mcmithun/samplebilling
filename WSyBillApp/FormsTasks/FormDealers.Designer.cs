
namespace WSyBillApp.FormsTasks
{
    partial class FormDealers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDealers));
            this.buttonAddDealer = new System.Windows.Forms.Button();
            this.labelGstin = new System.Windows.Forms.Label();
            this.textBoxGstin = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.checkBoxIsSupplier = new System.Windows.Forms.CheckBox();
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
            // buttonAddDealer
            // 
            this.buttonAddDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddDealer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddDealer.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddDealer.Image")));
            this.buttonAddDealer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddDealer.Location = new System.Drawing.Point(635, 38);
            this.buttonAddDealer.Name = "buttonAddDealer";
            this.buttonAddDealer.Size = new System.Drawing.Size(144, 44);
            this.buttonAddDealer.TabIndex = 1;
            this.buttonAddDealer.Text = "Add Dealer";
            this.buttonAddDealer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddDealer.UseVisualStyleBackColor = true;
            this.buttonAddDealer.Click += new System.EventHandler(this.buttonAddDealer_Click);
            // 
            // labelGstin
            // 
            this.labelGstin.AutoSize = true;
            this.labelGstin.Location = new System.Drawing.Point(3, 9);
            this.labelGstin.Name = "labelGstin";
            this.labelGstin.Size = new System.Drawing.Size(50, 20);
            this.labelGstin.TabIndex = 2;
            this.labelGstin.Text = "GSTIN";
            // 
            // textBoxGstin
            // 
            this.textBoxGstin.Location = new System.Drawing.Point(76, 6);
            this.textBoxGstin.Name = "textBoxGstin";
            this.textBoxGstin.Size = new System.Drawing.Size(125, 27);
            this.textBoxGstin.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(290, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(207, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(493, 6);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(136, 27);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(437, 9);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 20);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(76, 39);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(125, 27);
            this.textBoxAddress.TabIndex = 9;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(3, 42);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 20);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(207, 42);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 20);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Text = "Category";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.checkBoxIsSupplier);
            this.panelControl.Controls.Add(this.buttonSearchItem);
            this.panelControl.Controls.Add(this.textBoxAddress);
            this.panelControl.Controls.Add(this.buttonAddDealer);
            this.panelControl.Controls.Add(this.labelCategory);
            this.panelControl.Controls.Add(this.labelGstin);
            this.panelControl.Controls.Add(this.textBoxGstin);
            this.panelControl.Controls.Add(this.labelAddress);
            this.panelControl.Controls.Add(this.labelName);
            this.panelControl.Controls.Add(this.textBoxPhone);
            this.panelControl.Controls.Add(this.textBoxName);
            this.panelControl.Controls.Add(this.labelPhone);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(782, 85);
            this.panelControl.TabIndex = 12;
            // 
            // checkBoxIsSupplier
            // 
            this.checkBoxIsSupplier.AutoSize = true;
            this.checkBoxIsSupplier.Checked = true;
            this.checkBoxIsSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsSupplier.Location = new System.Drawing.Point(315, 41);
            this.checkBoxIsSupplier.Name = "checkBoxIsSupplier";
            this.checkBoxIsSupplier.Size = new System.Drawing.Size(100, 24);
            this.checkBoxIsSupplier.TabIndex = 18;
            this.checkBoxIsSupplier.Text = "A Supplier";
            this.checkBoxIsSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonSearchItem
            // 
            this.buttonSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearchItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchItem.Image")));
            this.buttonSearchItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchItem.Location = new System.Drawing.Point(528, 38);
            this.buttonSearchItem.Name = "buttonSearchItem";
            this.buttonSearchItem.Size = new System.Drawing.Size(101, 44);
            this.buttonSearchItem.TabIndex = 17;
            this.buttonSearchItem.Text = "Search";
            this.buttonSearchItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearchItem.UseVisualStyleBackColor = true;
            this.buttonSearchItem.Click += new System.EventHandler(this.buttonSearchItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(782, 361);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(754, 420);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(25, 21);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDoneFinished
            // 
            this.buttonDoneFinished.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDoneFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoneFinished.Location = new System.Drawing.Point(688, 446);
            this.buttonDoneFinished.Name = "buttonDoneFinished";
            this.buttonDoneFinished.Size = new System.Drawing.Size(94, 31);
            this.buttonDoneFinished.TabIndex = 16;
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
            // FormDealers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 477);
            this.Controls.Add(this.buttonDoneFinished);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelControl);
            this.Name = "FormDealers";
            this.Text = "FormDealers";
            this.Load += new System.EventHandler(this.FormDealers_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelGstin;
        private System.Windows.Forms.TextBox textBoxGstin;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.Button buttonDoneFinished;
        private System.Windows.Forms.Button buttonSearchItem;
        private System.Windows.Forms.CheckBox checkBoxIsSupplier;
        public System.Windows.Forms.Button buttonAddDealer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}