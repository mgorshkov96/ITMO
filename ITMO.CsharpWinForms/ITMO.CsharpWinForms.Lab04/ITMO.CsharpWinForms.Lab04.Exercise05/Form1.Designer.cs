namespace ITMO.CsharpWinForms.Lab04.Exercise05
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.rtxtAnswer = new System.Windows.Forms.RichTextBox();
            this.btnSetRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Значения функции sin(x) на интервале:";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(12, 42);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(0, 15);
            this.lblInterval.TabIndex = 1;
            // 
            // rtxtAnswer
            // 
            this.rtxtAnswer.Location = new System.Drawing.Point(12, 69);
            this.rtxtAnswer.Name = "rtxtAnswer";
            this.rtxtAnswer.Size = new System.Drawing.Size(153, 178);
            this.rtxtAnswer.TabIndex = 2;
            this.rtxtAnswer.Text = "";
            // 
            // btnSetRange
            // 
            this.btnSetRange.Location = new System.Drawing.Point(171, 69);
            this.btnSetRange.Name = "btnSetRange";
            this.btnSetRange.Size = new System.Drawing.Size(75, 45);
            this.btnSetRange.TabIndex = 3;
            this.btnSetRange.Text = "Задать интервал";
            this.btnSetRange.UseVisualStyleBackColor = true;
            this.btnSetRange.Click += new System.EventHandler(this.btnSetRange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSetRange);
            this.Controls.Add(this.rtxtAnswer);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sin(x)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblInterval;
        private RichTextBox rtxtAnswer;
        private Button btnSetRange;
    }
}