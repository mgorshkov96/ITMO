namespace ITMO.ADONET.Lab02.Exercise02
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConnectList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConnectDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisconnectDB = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnProductList = new System.Windows.Forms.Button();
            this.lvProductList = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnectList,
            this.menuConnectDB,
            this.menuDisconnectDB});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuConnectList
            // 
            this.menuConnectList.Name = "menuConnectList";
            this.menuConnectList.Size = new System.Drawing.Size(180, 22);
            this.menuConnectList.Text = "Connection list";
            this.menuConnectList.Click += new System.EventHandler(this.menuConnectList_Click);
            // 
            // menuConnectDB
            // 
            this.menuConnectDB.Name = "menuConnectDB";
            this.menuConnectDB.Size = new System.Drawing.Size(180, 22);
            this.menuConnectDB.Text = "Connect to DB";
            this.menuConnectDB.Click += new System.EventHandler(this.menuConnectDB_Click);
            // 
            // menuDisconnectDB
            // 
            this.menuDisconnectDB.Name = "menuDisconnectDB";
            this.menuDisconnectDB.Size = new System.Drawing.Size(180, 22);
            this.menuDisconnectDB.Text = "Disconnect from DB";
            this.menuDisconnectDB.Click += new System.EventHandler(this.menuDisconnectDB_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 52);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(113, 23);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Сколько продуктов";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(142, 57);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 2;
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(12, 113);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(113, 23);
            this.btnProductList.TabIndex = 3;
            this.btnProductList.Text = "Список продуктов";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // lvProductList
            // 
            this.lvProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.lvProductList.HideSelection = false;
            this.lvProductList.Location = new System.Drawing.Point(145, 113);
            this.lvProductList.Name = "lvProductList";
            this.lvProductList.Size = new System.Drawing.Size(180, 170);
            this.lvProductList.TabIndex = 4;
            this.lvProductList.UseCompatibleStateImageBehavior = false;
            this.lvProductList.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Название продукта";
            this.columnName.Width = 134;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvProductList);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuConnectList;
        private System.Windows.Forms.ToolStripMenuItem menuConnectDB;
        private System.Windows.Forms.ToolStripMenuItem menuDisconnectDB;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.ListView lvProductList;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}

