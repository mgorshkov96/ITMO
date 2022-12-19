namespace ITMO.CsharpWinForms.Test.WindowsCalculator
{
    partial class Сoefficients
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
            this.lblСoefficientsA = new System.Windows.Forms.Label();
            this.lblСoefficientsB = new System.Windows.Forms.Label();
            this.lblСoefficientsC = new System.Windows.Forms.Label();
            this.txtСoefficientsA = new System.Windows.Forms.TextBox();
            this.txtСoefficientsB = new System.Windows.Forms.TextBox();
            this.txtСoefficientsC = new System.Windows.Forms.TextBox();
            this.btnСoefficientsOK = new System.Windows.Forms.Button();
            this.btnСoefficientsCancel = new System.Windows.Forms.Button();
            this.lblСoefficientsEquation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblСoefficientsA
            // 
            this.lblСoefficientsA.AutoSize = true;
            this.lblСoefficientsA.Location = new System.Drawing.Point(12, 47);
            this.lblСoefficientsA.Name = "lblСoefficientsA";
            this.lblСoefficientsA.Size = new System.Drawing.Size(22, 13);
            this.lblСoefficientsA.TabIndex = 0;
            this.lblСoefficientsA.Text = "a =";
            // 
            // lblСoefficientsB
            // 
            this.lblСoefficientsB.AutoSize = true;
            this.lblСoefficientsB.Location = new System.Drawing.Point(146, 47);
            this.lblСoefficientsB.Name = "lblСoefficientsB";
            this.lblСoefficientsB.Size = new System.Drawing.Size(22, 13);
            this.lblСoefficientsB.TabIndex = 1;
            this.lblСoefficientsB.Text = "b =";
            // 
            // lblСoefficientsC
            // 
            this.lblСoefficientsC.AutoSize = true;
            this.lblСoefficientsC.Location = new System.Drawing.Point(280, 47);
            this.lblСoefficientsC.Name = "lblСoefficientsC";
            this.lblСoefficientsC.Size = new System.Drawing.Size(22, 13);
            this.lblСoefficientsC.TabIndex = 2;
            this.lblСoefficientsC.Text = "c =";
            // 
            // txtСoefficientsA
            // 
            this.txtСoefficientsA.Location = new System.Drawing.Point(40, 44);
            this.txtСoefficientsA.Name = "txtСoefficientsA";
            this.txtСoefficientsA.Size = new System.Drawing.Size(100, 20);
            this.txtСoefficientsA.TabIndex = 3;
            this.txtСoefficientsA.Text = "0";
            this.txtСoefficientsA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtСoefficientsA_KeyPress);
            // 
            // txtСoefficientsB
            // 
            this.txtСoefficientsB.Location = new System.Drawing.Point(174, 44);
            this.txtСoefficientsB.Name = "txtСoefficientsB";
            this.txtСoefficientsB.Size = new System.Drawing.Size(100, 20);
            this.txtСoefficientsB.TabIndex = 4;
            this.txtСoefficientsB.Text = "0";
            this.txtСoefficientsB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtСoefficientsB_KeyPress);
            // 
            // txtСoefficientsC
            // 
            this.txtСoefficientsC.Location = new System.Drawing.Point(308, 44);
            this.txtСoefficientsC.Name = "txtСoefficientsC";
            this.txtСoefficientsC.Size = new System.Drawing.Size(100, 20);
            this.txtСoefficientsC.TabIndex = 5;
            this.txtСoefficientsC.Text = "0";
            this.txtСoefficientsC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtСoefficientsC_KeyPress);
            // 
            // btnСoefficientsOK
            // 
            this.btnСoefficientsOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnСoefficientsOK.Location = new System.Drawing.Point(130, 81);
            this.btnСoefficientsOK.Name = "btnСoefficientsOK";
            this.btnСoefficientsOK.Size = new System.Drawing.Size(75, 23);
            this.btnСoefficientsOK.TabIndex = 6;
            this.btnСoefficientsOK.Text = "Посчитать";
            this.btnСoefficientsOK.UseVisualStyleBackColor = true;
            // 
            // btnСoefficientsCancel
            // 
            this.btnСoefficientsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnСoefficientsCancel.Location = new System.Drawing.Point(221, 81);
            this.btnСoefficientsCancel.Name = "btnСoefficientsCancel";
            this.btnСoefficientsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnСoefficientsCancel.TabIndex = 7;
            this.btnСoefficientsCancel.Text = "Отмена";
            this.btnСoefficientsCancel.UseVisualStyleBackColor = true;
            // 
            // lblСoefficientsEquation
            // 
            this.lblСoefficientsEquation.AutoSize = true;
            this.lblСoefficientsEquation.Location = new System.Drawing.Point(171, 18);
            this.lblСoefficientsEquation.Name = "lblСoefficientsEquation";
            this.lblСoefficientsEquation.Size = new System.Drawing.Size(80, 13);
            this.lblСoefficientsEquation.TabIndex = 8;
            this.lblСoefficientsEquation.Text = "ax² + bx + c = 0";
            // 
            // Сoefficients
            // 
            this.AcceptButton = this.btnСoefficientsOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 121);
            this.Controls.Add(this.lblСoefficientsEquation);
            this.Controls.Add(this.btnСoefficientsCancel);
            this.Controls.Add(this.btnСoefficientsOK);
            this.Controls.Add(this.txtСoefficientsC);
            this.Controls.Add(this.txtСoefficientsB);
            this.Controls.Add(this.txtСoefficientsA);
            this.Controls.Add(this.lblСoefficientsC);
            this.Controls.Add(this.lblСoefficientsB);
            this.Controls.Add(this.lblСoefficientsA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 160);
            this.MinimumSize = new System.Drawing.Size(440, 160);
            this.Name = "Сoefficients";
            this.ShowInTaskbar = false;
            this.Text = "Коэффициенты уравнения";
            this.Load += new System.EventHandler(this.Сoefficients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblСoefficientsA;
        private System.Windows.Forms.Label lblСoefficientsB;
        private System.Windows.Forms.Label lblСoefficientsC;
        private System.Windows.Forms.TextBox txtСoefficientsA;
        private System.Windows.Forms.TextBox txtСoefficientsB;
        private System.Windows.Forms.TextBox txtСoefficientsC;
        private System.Windows.Forms.Button btnСoefficientsOK;
        private System.Windows.Forms.Button btnСoefficientsCancel;
        private System.Windows.Forms.Label lblСoefficientsEquation;
    }
}