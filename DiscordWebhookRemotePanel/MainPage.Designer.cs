using System.Windows.Forms;

namespace DiscordWebhookRemotePanel
{
    partial class MainPage
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
            this.lblWebhookName = new System.Windows.Forms.Label();
            this.btnOpenList = new System.Windows.Forms.Button();
            this.txtNormalMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbTicketSelect = new System.Windows.Forms.ComboBox();
            this.btnAddTicked = new System.Windows.Forms.Button();
            this.btnFriendAdd = new System.Windows.Forms.Button();
            this.btnWebhookEdit = new System.Windows.Forms.Button();
            this.btnSendEmbed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Red;
            this.btnExitApp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExitApp.FlatAppearance.BorderSize = 0;
            this.btnExitApp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Location = new System.Drawing.Point(566, -2);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(65, 28);
            this.btnExitApp.TabIndex = 2;
            this.btnExitApp.Text = "X";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected Webhook: ";
            // 
            // lblWebhookName
            // 
            this.lblWebhookName.AutoSize = true;
            this.lblWebhookName.Location = new System.Drawing.Point(413, 35);
            this.lblWebhookName.Name = "lblWebhookName";
            this.lblWebhookName.Size = new System.Drawing.Size(15, 20);
            this.lblWebhookName.TabIndex = 4;
            this.lblWebhookName.Text = "-";
            // 
            // btnOpenList
            // 
            this.btnOpenList.Location = new System.Drawing.Point(413, 53);
            this.btnOpenList.Name = "btnOpenList";
            this.btnOpenList.Size = new System.Drawing.Size(140, 30);
            this.btnOpenList.TabIndex = 7;
            this.btnOpenList.Text = "Open List";
            this.btnOpenList.UseVisualStyleBackColor = true;
            this.btnOpenList.Click += new System.EventHandler(this.btnOpenList_Click);
            // 
            // txtNormalMessage
            // 
            this.txtNormalMessage.Location = new System.Drawing.Point(12, 12);
            this.txtNormalMessage.Name = "txtNormalMessage";
            this.txtNormalMessage.Size = new System.Drawing.Size(162, 27);
            this.txtNormalMessage.TabIndex = 0;
            this.txtNormalMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNormalMessage_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(162, 38);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbTicketSelect
            // 
            this.cbTicketSelect.FormattingEnabled = true;
            this.cbTicketSelect.Location = new System.Drawing.Point(180, 12);
            this.cbTicketSelect.Name = "cbTicketSelect";
            this.cbTicketSelect.Size = new System.Drawing.Size(121, 28);
            this.cbTicketSelect.TabIndex = 3;
            this.cbTicketSelect.Text = "Select Ticket";
            // 
            // btnAddTicked
            // 
            this.btnAddTicked.Location = new System.Drawing.Point(180, 46);
            this.btnAddTicked.Name = "btnAddTicked";
            this.btnAddTicked.Size = new System.Drawing.Size(121, 37);
            this.btnAddTicked.TabIndex = 5;
            this.btnAddTicked.Text = "ADD";
            this.btnAddTicked.UseVisualStyleBackColor = true;
            this.btnAddTicked.Click += new System.EventHandler(this.btnAddTicked_Click);
            // 
            // btnFriendAdd
            // 
            this.btnFriendAdd.Location = new System.Drawing.Point(307, 12);
            this.btnFriendAdd.Name = "btnFriendAdd";
            this.btnFriendAdd.Size = new System.Drawing.Size(100, 28);
            this.btnFriendAdd.TabIndex = 4;
            this.btnFriendAdd.Text = "Add To List";
            this.btnFriendAdd.UseVisualStyleBackColor = true;
            this.btnFriendAdd.Click += new System.EventHandler(this.btnFriendAdd_Click);
            // 
            // btnWebhookEdit
            // 
            this.btnWebhookEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWebhookEdit.Location = new System.Drawing.Point(307, 46);
            this.btnWebhookEdit.Name = "btnWebhookEdit";
            this.btnWebhookEdit.Size = new System.Drawing.Size(100, 37);
            this.btnWebhookEdit.TabIndex = 6;
            this.btnWebhookEdit.Text = "Edit Webhook";
            this.btnWebhookEdit.UseVisualStyleBackColor = true;
            this.btnWebhookEdit.Click += new System.EventHandler(this.btnWebhookEdit_Click);
            // 
            // btnSendEmbed
            // 
            this.btnSendEmbed.Location = new System.Drawing.Point(12, 87);
            this.btnSendEmbed.Name = "btnSendEmbed";
            this.btnSendEmbed.Size = new System.Drawing.Size(162, 38);
            this.btnSendEmbed.TabIndex = 2;
            this.btnSendEmbed.Text = "SendEmbed";
            this.btnSendEmbed.UseVisualStyleBackColor = true;
            this.btnSendEmbed.Click += new System.EventHandler(this.btnSendEmbed_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 137);
            this.Controls.Add(this.btnFriendAdd);
            this.Controls.Add(this.btnWebhookEdit);
            this.Controls.Add(this.btnAddTicked);
            this.Controls.Add(this.cbTicketSelect);
            this.Controls.Add(this.btnSendEmbed);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtNormalMessage);
            this.Controls.Add(this.btnOpenList);
            this.Controls.Add(this.lblWebhookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitApp);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainPage";
            this.Text = "DetailedSend";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExitApp;
        private Label label1;
        private Label lblWebhookName;
        private Button btnOpenList;
        private TextBox txtNormalMessage;
        private Button btnSend;
        private ComboBox cbTicketSelect;
        private Button btnAddTicked;
        private Button btnFriendAdd;
        private Button btnWebhookEdit;
        private Button btnSendEmbed;
    }
}