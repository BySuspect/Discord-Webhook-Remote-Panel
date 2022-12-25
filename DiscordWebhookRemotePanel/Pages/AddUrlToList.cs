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
    public partial class AddUrlToList : Form
    {
        public AddUrlToList()
        {
            InitializeComponent();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtUrl.Text))
            {
                try
                {

                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Wrong Entry!");
                }
            }
            else MessageBox.Show("Wrong Entry!");
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
    }
}
