using System.Windows.Forms;

namespace DiscordWebhookRemotePanel.Pages
{
    partial class AddUrlToList
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
            this.btnExitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Red;
            this.btnExitApp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExitApp.FlatAppearance.BorderSize = 0;
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Location = new System.Drawing.Point(144, -2);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(75, 23);
            this.btnExitApp.TabIndex = 3;
            this.btnExitApp.Text = "X";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Url:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(55, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 16);
            this.txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ok";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // txtUrl
            // 
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrl.Location = new System.Drawing.Point(55, 49);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 16);
            this.txtUrl.TabIndex = 1;
            // 
            // AddUrlToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 102);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitApp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUrlToList";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExitApp;
        private Label label1;
        private Button btnAdd;
        private Label label2;
        public TextBox txtName;
        public TextBox txtUrl;
    }
}