﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WSyBillApp.FormsTasks;

namespace WSyBillApp
{
    public partial class WsyBilling : Form
    {
        private const string HomeTitle = "Home";
        private SettingsUtilityWSBilling genericWsUitilty;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private object currentSender;
        private int tabIndexCaptured = 0;
        private SqliteConnection sqlConnection;
        public WsyBilling()
        {
            genericWsUitilty = SettingsUtilityWSBilling.Instance();
            InitializeComponent();

            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            sqlConnection = SqliteConnection.Instance(SettingsUtilityWSBilling.databaseFileCompletepath);

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnection.sqlConnection.Close();
            System.Windows.Forms.Application.ExitThread();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void buttonSalesMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsTasks.FormSales(), sender);
        }

        private void buttonPurchaseMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsTasks.FormPurchases(), sender);
        }
        private void buttonItemsMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsTasks.FormProducts(), sender);
        }

        private void buttonDealerMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsTasks.FormDealers(), sender);
        }
        private void buttonReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsTasks.FormReports(), sender);
        }

        private void buttonPreferences_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsTasks.FormPreferences(), sender);
        }
        private void masterBillingSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsTasks.FormPreferences(), sender);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            if (sqlConnection.sqlConnection != null)
            {
                if (sqlConnection.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.sqlConnection.Close();
                }
            }
            
            System.Windows.Forms.Application.ExitThread();
            Application.Exit();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            this.lblTitle.ResetText();
            this.lblTitle.Text = HomeTitle;
            activeForm.Close();
        }

        private void buttonRefreshFormToNew_Click(object sender, EventArgs e)
        {
            FormTasks obj = (FormTasks)activeForm;
            obj.ResetAllOfForm();
        }
    }
}
