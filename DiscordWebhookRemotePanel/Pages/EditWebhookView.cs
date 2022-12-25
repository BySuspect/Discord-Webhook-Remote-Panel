using DiscordWebhookRemotePanel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebhookRemotePanel.Pages
{
    public partial class EditWebhookView : Form
    {
        string tempPath = Path.GetTempPath();
        string folderPath = @"DiscordWebhooks\";
        string FilePath = @"WebhookSettings.txt";
        string fullFilePath;
        string? _selectedId;
        List<WebhookSettingsData> _dataList = new List<WebhookSettingsData>();
        List<WebhookSettingsData> _editedDataList = new List<WebhookSettingsData>();
        public EditWebhookView()
        {
            InitializeComponent();
            _refeshList();
        }
        public void _refeshList()
        {
            try
            {
                CheckFile();
                _dataList.Clear();
                lvSavedSettings.Items.Clear();
                _selectedId = null;
                string[] readedFileData = File.ReadAllLines(fullFilePath);
                foreach (var item in readedFileData)
                {
                    string[] splited = item.Split('|');
                    _dataList.Add(new WebhookSettingsData { guid = splited[0], username = splited[1], avatarUrl = splited[2] });
                }            
                foreach (var item in _dataList)
                {
                    ListViewItem lw = new ListViewItem();
                    lw.Text = item.username;
                    lw.SubItems.Add(item.avatarUrl);
                    lw.SubItems.Add(item.guid);
                    lvSavedSettings.Items.Add(lw);
                }/**/
                txtName.Text = "";
                txturl.Text = "";
                _selectedId = "";
            }
            catch
            {
                CheckFile();
                _dataList.Clear();
                File.WriteAllText(fullFilePath, "");
                _refeshList();
            }
        }
        private void CheckFile()
        {
            // Checking folder returns true or false.
            if (!Directory.Exists(tempPath + folderPath))
            {
                Directory.CreateDirectory(tempPath + folderPath);
            }//Creaing Folder

            // Checking file returns true or false.
            if (!File.Exists(tempPath + folderPath + FilePath))
            {
                using (File.Create(tempPath + folderPath + FilePath))
                { }// Creating file.
            }

            fullFilePath = tempPath + folderPath + FilePath;
        }

        void WriteDataToFile(string _data)
        {
            //Writing data to file.
            using (StreamWriter file = new StreamWriter(tempPath + folderPath + FilePath, true))
            {
                file.WriteLine(_data);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (true/*lvSavedSettings.SelectedItems[0].Text != null/**/)
                {
                    if (txtName.Text != null && txturl.Text != null)
                    {
                        saveFile();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {

                    }

                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch
            {

                throw;
            }
        }

        private void lvSavedSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvSavedSettings.SelectedItems[0].Text != null)
                {
                    txtName.Text = lvSavedSettings.SelectedItems[0].Text;
                    txturl.Text = lvSavedSettings.SelectedItems[0].SubItems[1].Text;
                    _selectedId = lvSavedSettings.SelectedItems[0].SubItems[2].Text;
                }
            }
            catch
            {

            }
        }

        #region Mouse move codes
        private Point _mouseLoc;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        #endregion

        void saveFile()
        {
            if (_selectedId != null)
            {
                _editedDataList.Clear();
                foreach (var item in _dataList)
                {
                    if (item.guid == _selectedId)
                    {
                        _editedDataList.Add(new WebhookSettingsData { guid = _selectedId, username = txtName.Text, avatarUrl = txturl.Text });
                    }
                    else
                    {
                        _editedDataList.Add(item);
                    }
                }
                File.WriteAllText(fullFilePath, "");
                foreach (var item in _editedDataList)
                {
                    WriteDataToFile(item.guid + "|" + item.username + "|" + item.avatarUrl);//write settings to file
                }
            }
            else
            {
                CheckFile();
                WriteDataToFile(Guid.NewGuid() + "|" + txtName.Text + "|" + txturl.Text);//write settings to file
            }
        }
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckFile();
            WriteDataToFile(Guid.NewGuid() + "|" + txtName.Text + "|" + txturl.Text);//write settings to file
            _refeshList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvSavedSettings.SelectedItems != null)
                {
                    _editedDataList.Clear();
                    _selectedId = lvSavedSettings.SelectedItems[0].SubItems[2].Text;
                    foreach (var item in _dataList)
                    {
                        if (item.guid == _selectedId)
                        {
                            continue;
                        }
                        else
                        {
                            _editedDataList.Add(item);
                        }
                    }
                    _selectedId = null;
                }
                File.WriteAllText(fullFilePath, "");
                foreach (var item in _editedDataList)
                {
                    WriteDataToFile(item.guid + "|" + item.username + "|" + item.avatarUrl);//write settings to file
                }
                _editedDataList.Clear();
                _refeshList();
            }
            catch
            {
                MessageBox.Show("Please select item on list");
            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvSavedSettings.SelectedItems[0].Text != null)
                {
                    txtName.Text = lvSavedSettings.SelectedItems[0].Text;
                    txturl.Text = lvSavedSettings.SelectedItems[0].SubItems[1].Text;
                    _selectedId = lvSavedSettings.SelectedItems[0].SubItems[2].Text;
                    DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Please select item on list");
            }
        }

        private void lvSavedSettings_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lvSavedSettings.SelectedItems[0].Text != null)
                {
                    txtName.Text = lvSavedSettings.SelectedItems[0].Text;
                    txturl.Text = lvSavedSettings.SelectedItems[0].SubItems[1].Text;
                    _selectedId = lvSavedSettings.SelectedItems[0].SubItems[2].Text;
                    DialogResult = DialogResult.OK;
                }
            }
            catch
            {

            }
        }
    }
}
