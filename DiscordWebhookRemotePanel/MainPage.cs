using DiscordWebhookRemotePanel.Pages;
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
using CSharpDiscordWebhook.NET.Discord;

namespace DiscordWebhookRemotePanel
{
    public partial class MainPage : Form
    {
        DiscordWebhook hook = new DiscordWebhook();
        List<FriendData> _FriendList = new List<FriendData>();
        string tempPath = Path.GetTempPath();
        string folderPath = @"DiscordWebhooks\";
        string FilePath = @"FriendList.txt";
        string fullFilePath;
        string selectedTicketId, selectedBotEditId;
        string WebhookUsername = null, WebhookAvatarUrl = null;
        public MainPage()
        {
            InitializeComponent();
            FriendListRefesh();
            WebhookSettingsRefesh();
        }
        async Task FriendListRefesh()
        {
            cbTicketSelect.Items.Clear();
            _FriendList.Clear();

            CheckFile();
            string[] readedFileData = File.ReadAllLines(fullFilePath);
            foreach (var item in readedFileData)
            {
                string[] splited = item.Split('|');
                _FriendList.Add(new FriendData { name = splited[0], Id = splited[1] });
            }
            foreach (var item in _FriendList)
            {
                cbTicketSelect.Items.Add(item.name);
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
        void WebhookSettingsRefesh()
        {
            EditWebhookView editwebhookForm = new EditWebhookView();
            editwebhookForm._refeshList();
            WebhookUsername = editwebhookForm.txtName.Text;
            WebhookAvatarUrl = editwebhookForm.txturl.Text;
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
            Application.Exit();
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

        private void btnOpenList_Click(object sender, EventArgs e)
        {
            UrlList _URLliste = new UrlList();
            DialogResult listeDialogResult = _URLliste.ShowDialog();
            if (listeDialogResult == DialogResult.OK)
            {
                lblWebhookName.Text = _URLliste.selectedName;
                hook.Uri = new Uri(_URLliste.selectedUrl);
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            /*
            DiscordMessage message = new DiscordMessage();
            DiscordEmbed embed = new DiscordEmbed();
            message.Embeds = new List<DiscordEmbed>();
            embed = new DiscordEmbed();

            embed.Title = "Embed title";
            embed.Description = "Embed description";
            embed.Timestamp = DateTime.Now;
            embed.Color = Color.Purple; //alpha will be ignored, you can use any RGB color
            embed.Footer = new EmbedFooter() { Text = "Footer Text", IconUrl = "https://i.pinimg.com/originals/dc/6f/e5/dc6fe5d49bc6be74fd302a720e7bcd96.jpg"};
            embed.Image = new EmbedMedia() { Url = "https://www.youtube.com/watch?v=bmd6f_ou8L8" }; //valid for thumb and video
            //embed.Provider = new EmbedProvider() { Name = "Provider Name", Url = "https://www.youtube.com/watch?v=64224V5nKv4" };
            embed.Author = new EmbedAuthor() { Name = "Author", Url = "https://www.youtube.com/watch?v=64224V5nKv4"};

            message.Embeds.Add(embed);
            hook.Send(message);/**/


            if (hook.Uri != null)
            {
                if (!string.IsNullOrEmpty(txtNormalMessage.Text))
                {
                    this.Enabled = false;
                    DiscordMessage message = new DiscordMessage();
                    message.Content = txtNormalMessage.Text;//message
                    //message.TTS = true; //read message to everyone on the channel
                    if (WebhookUsername != null) message.Username = WebhookUsername; //Username your webhook/bot
                    if (WebhookAvatarUrl != null) message.AvatarUrl = WebhookAvatarUrl; //avatar url your webhook/bot
                    _ = hook.SendAsync(message);
                    txtNormalMessage.Text = "";//Clear textbox
                    this.Enabled = true;
                    txtNormalMessage.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please first select Webhook!");
                btnOpenList_Click(null, null);
            }/**/
        }
        private void btnAddTicked_Click(object sender, EventArgs e)
        {
            foreach (var item in _FriendList)
            {
                if (item.name == cbTicketSelect.SelectedItem)
                {
                    txtNormalMessage.Text += item.Id;
                }
            }
        }

        private void txtNormalMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(null, null);
            }
        }

        private void btnFriendAdd_Click(object sender, EventArgs e)
        {
            AddFriendList _addfriendlist = new AddFriendList();
            DialogResult dres = _addfriendlist.ShowDialog();
            if (dres == DialogResult.OK)
            {
                _FriendList.Add(new FriendData { name = _addfriendlist.txtName.Text, Id = _addfriendlist.txtId.Text });
                WriteDataToFile(_addfriendlist.txtName.Text + "|<@" + _addfriendlist.txtId.Text + ">");
            }
            FriendListRefesh();
        }


        private async void btnSendEmbed_Click(object sender, EventArgs e)
        {
            if (hook.Uri != null)
            {
                CreateEmbed embedform = new CreateEmbed(hook.Uri);
                DialogResult = embedform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please first select Webhook!");
                btnOpenList_Click(null, null);
            }
        }

        private void btnWebhookEdit_Click(object sender, EventArgs e)
        {
            EditWebhookView editwebhookForm = new EditWebhookView();
            DialogResult dres = editwebhookForm.ShowDialog();
            if (dres == DialogResult.OK)
            {
                WebhookUsername = editwebhookForm.txtName.Text;
                WebhookAvatarUrl = editwebhookForm.txturl.Text;
            }
        }
    }
}
