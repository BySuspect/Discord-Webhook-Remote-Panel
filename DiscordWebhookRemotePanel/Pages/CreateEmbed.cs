using CSharpDiscordWebhook.NET.Discord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebhookRemotePanel.Pages
{
    public partial class CreateEmbed : Form
    {
        DiscordWebhook hook = new DiscordWebhook();
        public CreateEmbed(Uri uri)
        {
            InitializeComponent();
            hook.Uri = uri;
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
        private async void btnSendEmbed_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            DiscordMessage message = new DiscordMessage();
            DiscordEmbed embed = new DiscordEmbed();

            embed.Title = "Embed title";
            embed.Description = "Embed description";
            //embed.Url = "Embed Url"; //idk what is this
            embed.Timestamp = DateTime.Now;
            embed.Color = Color.Red; //alpha will be ignored, you can use any RGB color
            embed.Footer = new EmbedFooter() { Text = "Footer Text", IconUrl = "https://cdn.discordapp.com/attachments/750464609303134339/990535140159655976/asunapfp.jpg" };
            embed.Image = new EmbedMedia() { Url = "https://cdn.discordapp.com/attachments/750464609303134339/990535140159655976/asunapfp.jpg" }; //valid for thumb and video
            embed.Provider = new EmbedProvider() { Name = "Provider Name", Url = "https://github.com/BySuspect" };
            embed.Author = new EmbedAuthor() { Name = "Author Name", Url = "https://github.com/BySuspect", IconUrl = "https://cdn.discordapp.com/attachments/750464609303134339/990535140159655976/asunapfp.jpg" };

            //set embed
            message.Embeds = new List<DiscordEmbed>();
            message.Embeds.Add(embed);

            //message
            await hook.SendAsync(message);

            this.Enabled = true;
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            var res = ColorPicker.ShowDialog();
            if (res == DialogResult.OK)
            {
                var c = ColorPicker.Color;
            }
        }
    }
}
