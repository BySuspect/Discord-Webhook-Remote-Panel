using System.Windows.Forms;

namespace DiscordWebhookRemotePanel.Pages
{
    partial class UrlList
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
            this.btnaddurl = new System.Windows.Forms.Button();
            this.btnSelectUrl = new System.Windows.Forms.Button();
            this.btnDeleteListItem = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.ListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmbtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lvUrl = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ListContextMenu.SuspendLayout();
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
            this.btnExitApp.Location = new System.Drawing.Point(583, -1);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(57, 35);
            this.btnExitApp.TabIndex = 4;
            this.btnExitApp.Text = "X";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnaddurl
            // 
            this.btnaddurl.Location = new System.Drawing.Point(423, 12);
            this.btnaddurl.Name = "btnaddurl";
            this.btnaddurl.Size = new System.Drawing.Size(97, 23);
            this.btnaddurl.TabIndex = 0;
            this.btnaddurl.Text = "Add Url";
            this.btnaddurl.UseVisualStyleBackColor = true;
            this.btnaddurl.Click += new System.EventHandler(this.btnaddurl_Click);
            // 
            // btnSelectUrl
            // 
            this.btnSelectUrl.Location = new System.Drawing.Point(423, 41);
            this.btnSelectUrl.Name = "btnSelectUrl";
            this.btnSelectUrl.Size = new System.Drawing.Size(97, 23);
            this.btnSelectUrl.TabIndex = 1;
            this.btnSelectUrl.Text = "Select";
            this.btnSelectUrl.UseVisualStyleBackColor = true;
            this.btnSelectUrl.Click += new System.EventHandler(this.btnSelectUrl_Click);
            // 
            // btnDeleteListItem
            // 
            this.btnDeleteListItem.Location = new System.Drawing.Point(423, 99);
            this.btnDeleteListItem.Name = "btnDeleteListItem";
            this.btnDeleteListItem.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteListItem.TabIndex = 3;
            this.btnDeleteListItem.Text = "Delete";
            this.btnDeleteListItem.UseVisualStyleBackColor = true;
            this.btnDeleteListItem.Click += new System.EventHandler(this.btnDeleteListItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(423, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearList.Location = new System.Drawing.Point(423, 164);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(97, 23);
            this.btnClearList.TabIndex = 5;
            this.btnClearList.Text = "ClearList";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // ListContextMenu
            // 
            this.ListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbtnEdit,
            this.cmbtnDelete});
            this.ListContextMenu.Name = "ListContextMenu";
            this.ListContextMenu.Size = new System.Drawing.Size(108, 48);
            this.ListContextMenu.Text = "Delete";
            // 
            // cmbtnEdit
            // 
            this.cmbtnEdit.Name = "cmbtnEdit";
            this.cmbtnEdit.Size = new System.Drawing.Size(107, 22);
            this.cmbtnEdit.Text = "Edit";
            this.cmbtnEdit.ToolTipText = "Edit";
            this.cmbtnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbtnDelete
            // 
            this.cmbtnDelete.Name = "cmbtnDelete";
            this.cmbtnDelete.Size = new System.Drawing.Size(107, 22);
            this.cmbtnDelete.Text = "Delete";
            this.cmbtnDelete.ToolTipText = "Delete";
            this.cmbtnDelete.Click += new System.EventHandler(this.btnDeleteListItem_Click);
            // 
            // lvUrl
            // 
            this.lvUrl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvUrl.ContextMenuStrip = this.ListContextMenu;
            this.lvUrl.FullRowSelect = true;
            this.lvUrl.GridLines = true;
            this.lvUrl.HideSelection = false;
            this.lvUrl.Location = new System.Drawing.Point(12, 12);
            this.lvUrl.MultiSelect = false;
            this.lvUrl.Name = "lvUrl";
            this.lvUrl.Size = new System.Drawing.Size(405, 175);
            this.lvUrl.TabIndex = 5;
            this.lvUrl.UseCompatibleStateImageBehavior = false;
            this.lvUrl.View = System.Windows.Forms.View.Details;
            this.lvUrl.DoubleClick += new System.EventHandler(this.btnSelectUrl_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Url";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 0;
            // 
            // UrlList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(641, 199);
            this.Controls.Add(this.lvUrl);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteListItem);
            this.Controls.Add(this.btnSelectUrl);
            this.Controls.Add(this.btnaddurl);
            this.Controls.Add(this.btnExitApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrlList";
            this.Text = "NormalSend";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExitApp;
        private Button btnaddurl;
        private Button btnSelectUrl;
        private Button btnDeleteListItem;
        private Button btnEdit;
        private Button btnClearList;
        private ContextMenuStrip ListContextMenu;
        private ToolStripMenuItem cmbtnEdit;
        private ToolStripMenuItem cmbtnDelete;
        private ListView lvUrl;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}