using System.Windows.Forms;

namespace DiscordWebhookRemotePanel.Pages
{
    partial class EditWebhookView
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
            this.components = new System.ComponentModel.Container();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.lvSavedSettings = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Red;
            this.btnExitApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExitApp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExitApp.FlatAppearance.BorderSize = 0;
            this.btnExitApp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnExitApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnExitApp.Location = new System.Drawing.Point(430, -1);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(65, 28);
            this.btnExitApp.TabIndex = 3;
            this.btnExitApp.Text = "X";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(321, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 27);
            this.txtName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(387, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avatar Url";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(321, 79);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(136, 27);
            this.txturl.TabIndex = 1;
            // 
            // lvSavedSettings
            // 
            this.lvSavedSettings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSavedSettings.ContextMenuStrip = this.contextMenuStrip1;
            this.lvSavedSettings.FullRowSelect = true;
            this.lvSavedSettings.GridLines = true;
            this.lvSavedSettings.HideSelection = false;
            this.lvSavedSettings.Location = new System.Drawing.Point(12, 27);
            this.lvSavedSettings.MultiSelect = false;
            this.lvSavedSettings.Name = "lvSavedSettings";
            this.lvSavedSettings.Size = new System.Drawing.Size(224, 151);
            this.lvSavedSettings.TabIndex = 5;
            this.lvSavedSettings.UseCompatibleStateImageBehavior = false;
            this.lvSavedSettings.View = System.Windows.Forms.View.Details;
            this.lvSavedSettings.Click += new System.EventHandler(this.lvSavedSettings_Click);
            this.lvSavedSettings.DoubleClick += new System.EventHandler(this.lvSavedSettings_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Url";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "id";
            this.columnHeader3.Width = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.selectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(321, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EditWebhookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 204);
            this.Controls.Add(this.lvSavedSettings);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitApp);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditWebhookView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditWebhookView";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExitApp;
        private Label label1;
        public TextBox txtName;
        private Button btnSave;
        private Label label2;
        public TextBox txturl;
        public ListView lvSavedSettings;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button btnAdd;
        private ToolStripMenuItem selectToolStripMenuItem;
    }
}