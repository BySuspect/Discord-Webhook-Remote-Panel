using DiscordWebhookRemotePanel.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DiscordWebhookRemotePanel.Pages
{
    public partial class UrlList : Form
    {
        string tempPath = Path.GetTempPath();
        string folderPath = @"DiscordWebhooks\";
        string FilePath = @"Webhooks.txt";
        string fullFilePath;
        List<UrlData> _urlist = new List<UrlData>();
        List<UrlData> _editedurlist = new List<UrlData>();
        string selectedId;
        public string selectedName;
        public string selectedUrl;
        public UrlList()
        {
            InitializeComponent();
            CheckFile();
            _refeshList();
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

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnaddurl_Click(object sender, EventArgs e)
        {
            AddUrlToList addurlform = new AddUrlToList();
            DialogResult addresult = addurlform.ShowDialog();
            if (addresult == DialogResult.OK)
            {
                WriteDataToFile(Guid.NewGuid() + "|" + addurlform.txtName.Text + "|" + addurlform.txtUrl.Text);
            }
            _refeshList();
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
        private void btnSelectUrl_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUrl.SelectedItems[0].Text != null)
                {
                    selectedName = lvUrl.SelectedItems[0].Text;
                    selectedUrl = lvUrl.SelectedItems[0].SubItems[1].Text;
                    selectedId = lvUrl.SelectedItems[0].SubItems[2].Text;
                    DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Please select item on list");
            }
        }

        private void btnDeleteListItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUrl.SelectedItems != null)
                {
                    selectedName = lvUrl.SelectedItems[0].Text;
                    selectedUrl = lvUrl.SelectedItems[0].SubItems[1].Text;
                    selectedId = lvUrl.SelectedItems[0].SubItems[2].Text;
                    foreach (var item in _urlist)
                    {
                        if (item.Id == selectedId)
                        {
                            continue;
                        }
                        else
                        {
                            _editedurlist.Add(item);
                        }
                    }
                }
                File.WriteAllText(fullFilePath, "");
                foreach (var item in _editedurlist)
                {
                    WriteDataToFile(item.Id + "|" + item.WebhookUrlName + "|" + item.Url);
                }
                _editedurlist.Clear();
                _refeshList();
            }
            catch
            {
                MessageBox.Show("Please select item on list");
            }
        }
        void _refeshList()
        {
            try
            {
                CheckFile();
                _urlist.Clear();
                lvUrl.Items.Clear();
                string[] readedFileData = File.ReadAllLines(fullFilePath);
                foreach (var item in readedFileData)
                {
                    string[] splited = item.Split('|');
                    _urlist.Add(new UrlData { Id = splited[0], WebhookUrlName = splited[1], Url = splited[2] });
                }
                foreach (var item in _urlist)
                {
                    ListViewItem lw = new ListViewItem();
                    lw.Text = item.WebhookUrlName;
                    lw.SubItems.Add(item.Url.ToString());
                    lw.SubItems.Add(item.Id.ToString());
                    lvUrl.Items.Add(lw);
                }
            }
            catch
            {
                CheckFile();
                _urlist.Clear();
                File.WriteAllText(fullFilePath, "");
                lvUrl.Items.Clear();
                _refeshList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvUrl.SelectedItems != null)
                {
                    selectedName = lvUrl.SelectedItems[0].Text;
                    selectedUrl = lvUrl.SelectedItems[0].SubItems[1].Text;
                    selectedId = lvUrl.SelectedItems[0].SubItems[2].Text;
                    foreach (var item in _urlist)
                    {
                        if (item.Id == selectedId)
                        {
                            AddUrlToList addform = new AddUrlToList();
                            addform.txtName.Text = item.WebhookUrlName;
                            addform.txtUrl.Text = item.Url;
                            DialogResult result = addform.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                _editedurlist.Add(new UrlData { Id = item.Id, WebhookUrlName = addform.txtName.Text, Url = addform.txtUrl.Text });
                            }
                            else
                            {
                                _editedurlist.Add(item);
                            }
                        }
                        else
                        {
                            _editedurlist.Add(item);
                        }
                    }
                }
                File.WriteAllText(fullFilePath, "");
                foreach (var item in _editedurlist)
                {
                    WriteDataToFile(item.Id + "|" + item.WebhookUrlName + "|" + item.Url);
                }
                _editedurlist.Clear();
                _refeshList();
            }
            catch
            {
                MessageBox.Show("Please select item on list");
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are You Sure a Delete All?", "!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _urlist.Clear();
                File.WriteAllText(fullFilePath, "");
                lvUrl.Items.Clear();
            }
        }
    }
}
