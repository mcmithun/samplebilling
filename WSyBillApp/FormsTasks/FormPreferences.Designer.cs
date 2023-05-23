
namespace WSyBillApp.FormsTasks
{
    partial class FormPreferences
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTaxSlabs = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonDoRestore = new System.Windows.Forms.Button();
            this.textBoxDbFilePath = new System.Windows.Forms.TextBox();
            this.buttonDbRestore = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEditInvoiceGen = new System.Windows.Forms.Button();
            this.textBoxInvGenCapt = new System.Windows.Forms.TextBox();
            this.textBoxDatabackUpPath = new System.Windows.Forms.TextBox();
            this.textBoxAddressPin = new System.Windows.Forms.TextBox();
            this.textBoxAddressL2 = new System.Windows.Forms.TextBox();
            this.textBoxAddressL1 = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Slabs";
            // 
            // textBoxTaxSlabs
            // 
            this.textBoxTaxSlabs.Location = new System.Drawing.Point(191, 187);
            this.textBoxTaxSlabs.Name = "textBoxTaxSlabs";
            this.textBoxTaxSlabs.Size = new System.Drawing.Size(181, 27);
            this.textBoxTaxSlabs.TabIndex = 1;
            this.textBoxTaxSlabs.Text = "3, 5, 12, 18, 28";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(626, 397);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(144, 44);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.label9);
            this.panelControl.Controls.Add(this.textBoxPhoneNo);
            this.panelControl.Controls.Add(this.buttonDoRestore);
            this.panelControl.Controls.Add(this.textBoxDbFilePath);
            this.panelControl.Controls.Add(this.buttonDbRestore);
            this.panelControl.Controls.Add(this.label8);
            this.panelControl.Controls.Add(this.label7);
            this.panelControl.Controls.Add(this.label6);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.buttonEditInvoiceGen);
            this.panelControl.Controls.Add(this.textBoxInvGenCapt);
            this.panelControl.Controls.Add(this.textBoxDatabackUpPath);
            this.panelControl.Controls.Add(this.textBoxAddressPin);
            this.panelControl.Controls.Add(this.textBoxAddressL2);
            this.panelControl.Controls.Add(this.textBoxAddressL1);
            this.panelControl.Controls.Add(this.textBoxCompanyName);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.textBoxTaxSlabs);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.buttonApply);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(782, 453);
            this.panelControl.TabIndex = 4;
            // 
            // buttonDoRestore
            // 
            this.buttonDoRestore.Location = new System.Drawing.Point(532, 285);
            this.buttonDoRestore.Name = "buttonDoRestore";
            this.buttonDoRestore.Size = new System.Drawing.Size(94, 29);
            this.buttonDoRestore.TabIndex = 20;
            this.buttonDoRestore.Text = "Do Restore";
            this.buttonDoRestore.UseVisualStyleBackColor = true;
            this.buttonDoRestore.Click += new System.EventHandler(this.buttonDoRestore_Click);
            // 
            // textBoxDbFilePath
            // 
            this.textBoxDbFilePath.Location = new System.Drawing.Point(191, 286);
            this.textBoxDbFilePath.Name = "textBoxDbFilePath";
            this.textBoxDbFilePath.Size = new System.Drawing.Size(335, 27);
            this.textBoxDbFilePath.TabIndex = 19;
            // 
            // buttonDbRestore
            // 
            this.buttonDbRestore.Location = new System.Drawing.Point(21, 286);
            this.buttonDbRestore.Name = "buttonDbRestore";
            this.buttonDbRestore.Size = new System.Drawing.Size(166, 29);
            this.buttonDbRestore.TabIndex = 18;
            this.buttonDbRestore.Text = "Restore DB from  File";
            this.buttonDbRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDbRestore.UseVisualStyleBackColor = true;
            this.buttonDbRestore.Click += new System.EventHandler(this.buttonDbRestore_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address Line 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address Line 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Invoice Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data Backup Path";
            // 
            // buttonEditInvoiceGen
            // 
            this.buttonEditInvoiceGen.Location = new System.Drawing.Point(368, 253);
            this.buttonEditInvoiceGen.Name = "buttonEditInvoiceGen";
            this.buttonEditInvoiceGen.Size = new System.Drawing.Size(31, 27);
            this.buttonEditInvoiceGen.TabIndex = 12;
            this.buttonEditInvoiceGen.Text = "...";
            this.buttonEditInvoiceGen.UseVisualStyleBackColor = true;
            // 
            // textBoxInvGenCapt
            // 
            this.textBoxInvGenCapt.Enabled = false;
            this.textBoxInvGenCapt.Location = new System.Drawing.Point(191, 253);
            this.textBoxInvGenCapt.Name = "textBoxInvGenCapt";
            this.textBoxInvGenCapt.Size = new System.Drawing.Size(171, 27);
            this.textBoxInvGenCapt.TabIndex = 11;
            // 
            // textBoxDatabackUpPath
            // 
            this.textBoxDatabackUpPath.Location = new System.Drawing.Point(191, 220);
            this.textBoxDatabackUpPath.Name = "textBoxDatabackUpPath";
            this.textBoxDatabackUpPath.Size = new System.Drawing.Size(335, 27);
            this.textBoxDatabackUpPath.TabIndex = 10;
            // 
            // textBoxAddressPin
            // 
            this.textBoxAddressPin.Location = new System.Drawing.Point(191, 154);
            this.textBoxAddressPin.Name = "textBoxAddressPin";
            this.textBoxAddressPin.Size = new System.Drawing.Size(208, 27);
            this.textBoxAddressPin.TabIndex = 9;
            // 
            // textBoxAddressL2
            // 
            this.textBoxAddressL2.Location = new System.Drawing.Point(191, 88);
            this.textBoxAddressL2.Name = "textBoxAddressL2";
            this.textBoxAddressL2.Size = new System.Drawing.Size(208, 27);
            this.textBoxAddressL2.TabIndex = 8;
            // 
            // textBoxAddressL1
            // 
            this.textBoxAddressL1.Location = new System.Drawing.Point(191, 55);
            this.textBoxAddressL1.Name = "textBoxAddressL1";
            this.textBoxAddressL1.Size = new System.Drawing.Size(208, 27);
            this.textBoxAddressL1.TabIndex = 7;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(191, 22);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(171, 27);
            this.textBoxCompanyName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Billing Organization";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phone";
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(191, 121);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(208, 27);
            this.textBoxPhoneNo.TabIndex = 21;
            // 
            // FormPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panelControl);
            this.Name = "FormPreferences";
            this.Text = "FormPreferences";
            this.Load += new System.EventHandler(this.FormPreferences_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTaxSlabs;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxInvGenCapt;
        private System.Windows.Forms.TextBox textBoxDatabackUpPath;
        private System.Windows.Forms.TextBox textBoxAddressPin;
        private System.Windows.Forms.TextBox textBoxAddressL2;
        private System.Windows.Forms.TextBox textBoxAddressL1;
        private System.Windows.Forms.Button buttonEditInvoiceGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDbFilePath;
        private System.Windows.Forms.Button buttonDbRestore;
        private System.Windows.Forms.Button buttonDoRestore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
    }
}