namespace ITMO.CsharpWinForms.Lab04.Exercise05
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeftBorder = new System.Windows.Forms.TextBox();
            this.txtRightBorder = new System.Windows.Forms.TextBox();
            this.btnF2OK = new System.Windows.Forms.Button();
            this.btnF2Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Границы интервала";
            // 
            // txtLeftBorder
            // 
            this.txtLeftBorder.Location = new System.Drawing.Point(12, 41);
            this.txtLeftBorder.Name = "txtLeftBorder";
            this.txtLeftBorder.Size = new System.Drawing.Size(130, 23);
            this.txtLeftBorder.TabIndex = 1;
            this.txtLeftBorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Borders_KeyPress);
            // 
            // txtRightBorder
            // 
            this.txtRightBorder.Location = new System.Drawing.Point(148, 41);
            this.txtRightBorder.Name = "txtRightBorder";
            this.txtRightBorder.Size = new System.Drawing.Size(130, 23);
            this.txtRightBorder.TabIndex = 2;
            this.txtRightBorder.KeyPress += this.Borders_KeyPress;
            // 
            // btnF2OK
            // 
            this.btnF2OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnF2OK.Location = new System.Drawing.Point(12, 81);
            this.btnF2OK.Name = "btnF2OK";
            this.btnF2OK.Size = new System.Drawing.Size(130, 23);
            this.btnF2OK.TabIndex = 3;
            this.btnF2OK.Text = "Передать данные";
            this.btnF2OK.UseVisualStyleBackColor = true;
            // 
            // btnF2Cancel
            // 
            this.btnF2Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnF2Cancel.Location = new System.Drawing.Point(148, 81);
            this.btnF2Cancel.Name = "btnF2Cancel";
            this.btnF2Cancel.Size = new System.Drawing.Size(130, 23);
            this.btnF2Cancel.TabIndex = 4;
            this.btnF2Cancel.Text = "Отменить передачу";
            this.btnF2Cancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnF2OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnF2Cancel;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btnF2Cancel);
            this.Controls.Add(this.btnF2OK);
            this.Controls.Add(this.txtRightBorder);
            this.Controls.Add(this.txtLeftBorder);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 160);
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "FormRange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtLeftBorder;
        private TextBox txtRightBorder;
        private Button btnF2OK;
        private Button btnF2Cancel;
    }
}