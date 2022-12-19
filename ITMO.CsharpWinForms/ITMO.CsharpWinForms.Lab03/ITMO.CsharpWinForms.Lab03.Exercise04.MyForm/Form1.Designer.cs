namespace ITMO.CsharpWinForms.Lab03.Exercise04.MyForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlUser1 = new ITMO.CsharpWinForms.Lab03.Exercise04.Library.ctrlUser();
            this.rtxtUsers = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlUser1
            // 
            this.ctrlUser1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlUser1.Email = "";
            this.ctrlUser1.FirstName = "";
            this.ctrlUser1.Location = new System.Drawing.Point(12, 12);
            this.ctrlUser1.MaximumSize = new System.Drawing.Size(260, 320);
            this.ctrlUser1.MinimumSize = new System.Drawing.Size(260, 320);
            this.ctrlUser1.Name = "ctrlUser1";
            this.ctrlUser1.Patronymic = "";
            this.ctrlUser1.Phone = "";
            this.ctrlUser1.SecondName = "";
            this.ctrlUser1.Size = new System.Drawing.Size(260, 320);
            this.ctrlUser1.TabIndex = 0;
            // 
            // rtxtUsers
            // 
            this.rtxtUsers.Location = new System.Drawing.Point(278, 14);
            this.rtxtUsers.Name = "rtxtUsers";
            this.rtxtUsers.ReadOnly = true;
            this.rtxtUsers.Size = new System.Drawing.Size(260, 289);
            this.rtxtUsers.TabIndex = 1;
            this.rtxtUsers.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показать пользователей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxtUsers);
            this.Controls.Add(this.ctrlUser1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 380);
            this.MinimumSize = new System.Drawing.Size(565, 380);
            this.Name = "Form1";
            this.Text = "MyProgram";
            this.ResumeLayout(false);

        }

        #endregion

        private Library.ctrlUser ctrlUser1;
        private RichTextBox rtxtUsers;
        private Button button1;
    }
}