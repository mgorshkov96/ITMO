namespace ITMO.CsharpWinForms.Lab04.Exercise04
{
    partial class Form2
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
            this.buttonF2 = new System.Windows.Forms.Button();
            this.textBoxF21 = new System.Windows.Forms.TextBox();
            this.textBoxF22 = new System.Windows.Forms.TextBox();
            this.textBoxF23 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonF2
            // 
            this.buttonF2.Location = new System.Drawing.Point(26, 112);
            this.buttonF2.Name = "buttonF2";
            this.buttonF2.Size = new System.Drawing.Size(150, 23);
            this.buttonF2.TabIndex = 0;
            this.buttonF2.Text = "Объеденить строки";
            this.buttonF2.UseVisualStyleBackColor = true;
            this.buttonF2.Click += new System.EventHandler(this.buttonF2_Click);
            // 
            // textBoxF21
            // 
            this.textBoxF21.Location = new System.Drawing.Point(26, 12);
            this.textBoxF21.Name = "textBoxF21";
            this.textBoxF21.Size = new System.Drawing.Size(150, 23);
            this.textBoxF21.TabIndex = 1;
            // 
            // textBoxF22
            // 
            this.textBoxF22.Location = new System.Drawing.Point(26, 41);
            this.textBoxF22.Name = "textBoxF22";
            this.textBoxF22.Size = new System.Drawing.Size(150, 23);
            this.textBoxF22.TabIndex = 2;
            // 
            // textBoxF23
            // 
            this.textBoxF23.Location = new System.Drawing.Point(26, 70);
            this.textBoxF23.Name = "textBoxF23";
            this.textBoxF23.Size = new System.Drawing.Size(150, 23);
            this.textBoxF23.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 147);
            this.Controls.Add(this.textBoxF23);
            this.Controls.Add(this.textBoxF22);
            this.Controls.Add(this.textBoxF21);
            this.Controls.Add(this.buttonF2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonF2;
        private TextBox textBoxF21;
        private TextBox textBoxF22;
        private TextBox textBoxF23;
    }
}