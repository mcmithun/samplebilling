using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WSyBillApp.FormsTasks
{
    public partial class FormPreferences : FormTasks
    {
        private string settingsData = "";
        private List<string> settingsDataSplited;
        private string filedbpath = "";
        public FormPreferences()
        {
            tableName = "Default";
            sqlConnection = SqliteConnection.Instance(SettingsUtilityWSBilling.databaseFileCompletepath);
            filedbpath = sqlConnection.sqlConnection.ConnectionString.Replace(SettingsUtilityWSBilling.UriFile, "");
            InitializeComponent();
            settingsData = File.ReadAllText(SettingsUtilityWSBilling.PreferenceFile);
            settingsDataSplited = new List<string>(settingsData.Split(";"));
            //MessageBox.Show("", "", MessageBoxButtons.OK);
            /*MessageBox.Show($"\n{settingsDataSplited[0]}" +
                            $"\n{settingsDataSplited[0].Split("=")[1].Split(",")[0]}" +
                            $"\n{settingsDataSplited[0].Split("=")[1].Split(",")[1]}" +
                            $"\n{settingsDataSplited[0].Split("=")[1].Split(",")[2]}" +
                            $"\n{settingsDataSplited[0].Split("=")[1].Split(",")[3]}" +
                            $"\n{settingsDataSplited[0].Split("=")[1].Split(",")[4]}" +
                            $"\n{settingsDataSplited[2].Split("=")[1]}",
                            $"\n", MessageBoxButtons.OK);*/
            this.textBoxCompanyName.Text = settingsDataSplited[0].Split("=")[1].Split(",")[0];
            this.textBoxAddressL1.Text = settingsDataSplited[0].Split("=")[1].Split(",")[1];
            this.textBoxAddressL2.Text = settingsDataSplited[0].Split("=")[1].Split(",")[2];
            this.textBoxPhoneNo.Text = settingsDataSplited[0].Split("=")[1].Split(",")[3];
            this.textBoxAddressPin.Text = settingsDataSplited[0].Split("=")[1].Split(",")[4];
            this.textBoxInvGenCapt.Text = settingsDataSplited[2].Split("=")[1];
            this.textBoxDatabackUpPath.Text = settingsDataSplited[3].Split("=")[1];
        }

        private void FormPreferences_Load(object sender, EventArgs e)
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
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
        }
        private void doBackUpDatabaseAtInterval()
        {
            if (this.textBoxDatabackUpPath.Text != "")
            {
                File.Copy(filedbpath, this.textBoxDatabackUpPath.Text);
            }
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            settingsData = settingsData.Replace(settingsDataSplited[0].Split("=")[1].Split(",")[0], this.textBoxCompanyName.Text);
            settingsData = settingsData.Replace(settingsDataSplited[0].Split("=")[1].Split(",")[1], this.textBoxAddressL1.Text);
            settingsData = settingsData.Replace(settingsDataSplited[0].Split("=")[1].Split(",")[2], this.textBoxAddressL2.Text);
            settingsData = settingsData.Replace(settingsDataSplited[0].Split("=")[1].Split(",")[3], this.textBoxPhoneNo.Text);
            settingsData = settingsData.Replace(settingsDataSplited[0].Split("=")[1].Split(",")[4], this.textBoxAddressPin.Text);
            settingsData = settingsData.Replace(settingsDataSplited[2].Split("=")[1], this.textBoxInvGenCapt.Text);
            settingsData = settingsData.Replace(settingsDataSplited[3].Split("=")[1], this.textBoxDatabackUpPath.Text);
            DialogResult dialogResult = MessageBox.Show($"{settingsData}", $"Are you to proceed with below settings?", 
                                                        MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            File.WriteAllText(SettingsUtilityWSBilling.PreferenceFile, settingsData);
        }

        private void buttonDbRestore_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }

            MessageBox.Show("File Content at path: " + filePath, "File choosen:", MessageBoxButtons.OK);
            this.textBoxDbFilePath.Text = filePath;
        }

        private void buttonDoRestore_Click(object sender, EventArgs e)
        {
            filedbpath = sqlConnection.sqlConnection.ConnectionString.Replace(SettingsUtilityWSBilling.UriFile,"");
            sqlConnection.sqlConnection.Close();
            sqlConnection.sqlCommandStm.CloseCommand();
            sqlConnection.sqlConnection.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers(); 
            ReplaceFile(filedbpath, this.textBoxDbFilePath.Text, $"{filedbpath}.{DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss")}_bak.db");
            sqlConnection = null;
            MessageBox.Show("Warning! Please restart the application as you have reseted the database!", "Warning!", MessageBoxButtons.OK);
        }
        public static void ReplaceFile(string fileToMoveAndDelete, string fileToReplace, string backupOfFileToReplace)
        {
            MessageBox.Show($"Going to replace {fileToMoveAndDelete} , with - {fileToReplace}, " +
                            $"and do a backup as {backupOfFileToReplace}", "File backup:", MessageBoxButtons.OK); 
            File.Replace(fileToReplace, fileToMoveAndDelete, backupOfFileToReplace);
        }
    }
}
