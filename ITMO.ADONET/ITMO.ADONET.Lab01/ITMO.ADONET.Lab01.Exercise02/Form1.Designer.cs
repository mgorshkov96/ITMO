﻿namespace ITMO.ADONET.Lab01.Exercise02
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
            this.menuConnectDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisconnectDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnectDB,
            this.menuDisconnectDB});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuConnectDB
            // 
            this.menuConnectDB.Name = "menuConnectDB";
            this.menuConnectDB.Size = new System.Drawing.Size(96, 20);
            this.menuConnectDB.Text = "Connect to DB";
            this.menuConnectDB.Click += new System.EventHandler(this.menuConnectDB_Click);
            // 
            // menuDisconnectDB
            // 
            this.menuDisconnectDB.Name = "menuDisconnectDB";
            this.menuDisconnectDB.Size = new System.Drawing.Size(125, 20);
            this.menuDisconnectDB.Text = "Disconnect from DB";
            this.menuDisconnectDB.Click += new System.EventHandler(this.menuDisonnectDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem menuConnectDB;
        private System.Windows.Forms.ToolStripMenuItem menuDisconnectDB;
    }
}

