namespace ITMO.CsharpWinForms.Lab01.Exercise05.Test02
{
    partial class ParentForm
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
            this.menuStripParent = new System.Windows.Forms.MenuStrip();
            this.clickMeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripParent
            // 
            this.menuStripParent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickMeMenuItem});
            this.menuStripParent.Location = new System.Drawing.Point(0, 0);
            this.menuStripParent.Name = "menuStripParent";
            this.menuStripParent.Size = new System.Drawing.Size(800, 24);
            this.menuStripParent.TabIndex = 1;
            this.menuStripParent.Text = "menuStrip1";
            // 
            // clickMeMenuItem
            // 
            this.clickMeMenuItem.Name = "clickMeMenuItem";
            this.clickMeMenuItem.Size = new System.Drawing.Size(68, 20);
            this.clickMeMenuItem.Text = "&Click me!";
            this.clickMeMenuItem.Click += new System.EventHandler(this.clickMeMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripParent);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripParent;
            this.Name = "ParentForm";
            this.Text = "Form";
            this.menuStripParent.ResumeLayout(false);
            this.menuStripParent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripParent;
        private ToolStripMenuItem clickMeMenuItem;
    }
}