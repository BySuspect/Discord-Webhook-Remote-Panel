using System.Windows.Forms;

namespace DiscordWebhookRemotePanel.Pages
{
    partial class CreateEmbed
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
            this.btnSendEmbed = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Red;
            this.btnExitApp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExitApp.FlatAppearance.BorderSize = 0;
            this.btnExitApp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Location = new System.Drawing.Point(846, 0);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(74, 29);
            this.btnExitApp.TabIndex = 3;
            this.btnExitApp.Text = "X";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnSendEmbed
            // 
            this.btnSendEmbed.Location = new System.Drawing.Point(124, 265);
            this.btnSendEmbed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendEmbed.Name = "btnSendEmbed";
            this.btnSendEmbed.Size = new System.Drawing.Size(86, 31);
            this.btnSendEmbed.TabIndex = 4;
            this.btnSendEmbed.Text = "Send";
            this.btnSendEmbed.UseVisualStyleBackColor = true;
            this.btnSendEmbed.Click += new System.EventHandler(this.btnSendEmbed_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(124, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(114, 27);
            this.txtTitle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 27);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 90);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 27);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Footer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color:";
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Location = new System.Drawing.Point(124, 124);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(114, 30);
            this.btnColorPicker.TabIndex = 7;
            this.btnColorPicker.Text = "SelectColor";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // CreateEmbed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(919, 435);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSendEmbed);
            this.Controls.Add(this.btnExitApp);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateEmbed";
            this.Text = "CreateEmbed";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExitApp;
        private Button btnSendEmbed;
        private TextBox txtTitle;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Button btnColorPicker;
        private ColorDialog ColorPicker;
    }
}