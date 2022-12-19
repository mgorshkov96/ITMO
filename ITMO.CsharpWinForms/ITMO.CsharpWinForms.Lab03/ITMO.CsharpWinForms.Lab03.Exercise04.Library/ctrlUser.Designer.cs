namespace ITMO.CsharpWinForms.Lab03.Exercise04.Library
{
    partial class ctrlUser
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.lblUserFirstName = new System.Windows.Forms.Label();
            this.lblUserSecondName = new System.Windows.Forms.Label();
            this.txtUserSecondName = new System.Windows.Forms.TextBox();
            this.lblUserPatronymic = new System.Windows.Forms.Label();
            this.txtUserPatronymic = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Информация о пользователе";
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.Location = new System.Drawing.Point(67, 105);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(160, 23);
            this.txtUserFirstName.TabIndex = 4;
            this.txtUserFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserFirstName_KeyPress);
            // 
            // lblUserFirstName
            // 
            this.lblUserFirstName.AutoSize = true;
            this.lblUserFirstName.Location = new System.Drawing.Point(3, 108);
            this.lblUserFirstName.Name = "lblUserFirstName";
            this.lblUserFirstName.Size = new System.Drawing.Size(31, 15);
            this.lblUserFirstName.TabIndex = 2;
            this.lblUserFirstName.Text = "Имя";
            // 
            // lblUserSecondName
            // 
            this.lblUserSecondName.AutoSize = true;
            this.lblUserSecondName.Location = new System.Drawing.Point(3, 75);
            this.lblUserSecondName.Name = "lblUserSecondName";
            this.lblUserSecondName.Size = new System.Drawing.Size(58, 15);
            this.lblUserSecondName.TabIndex = 3;
            this.lblUserSecondName.Text = "Фамилия";
            // 
            // txtUserSecondName
            // 
            this.txtUserSecondName.Location = new System.Drawing.Point(67, 72);
            this.txtUserSecondName.Name = "txtUserSecondName";
            this.txtUserSecondName.Size = new System.Drawing.Size(160, 23);
            this.txtUserSecondName.TabIndex = 1;
            this.txtUserSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserSecondName_KeyPress);
            // 
            // lblUserPatronymic
            // 
            this.lblUserPatronymic.AutoSize = true;
            this.lblUserPatronymic.Location = new System.Drawing.Point(3, 140);
            this.lblUserPatronymic.Name = "lblUserPatronymic";
            this.lblUserPatronymic.Size = new System.Drawing.Size(58, 15);
            this.lblUserPatronymic.TabIndex = 5;
            this.lblUserPatronymic.Text = "Отчество";
            // 
            // txtUserPatronymic
            // 
            this.txtUserPatronymic.Location = new System.Drawing.Point(67, 140);
            this.txtUserPatronymic.Name = "txtUserPatronymic";
            this.txtUserPatronymic.Size = new System.Drawing.Size(160, 23);
            this.txtUserPatronymic.TabIndex = 6;
            this.txtUserPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPatronymic_KeyPress);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(3, 197);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(59, 15);
            this.lblUserEmail.TabIndex = 7;
            this.lblUserEmail.Text = "Эл. почта";
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.Location = new System.Drawing.Point(3, 231);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(55, 15);
            this.lblUserPhone.TabIndex = 8;
            this.lblUserPhone.Text = "Телефон";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(68, 194);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(160, 23);
            this.txtUserEmail.TabIndex = 9;
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(68, 228);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(160, 23);
            this.txtUserPhone.TabIndex = 10;
            this.txtUserPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPhone_KeyPress);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(88, 272);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblUserPhone);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.txtUserPatronymic);
            this.Controls.Add(this.lblUserPatronymic);
            this.Controls.Add(this.txtUserSecondName);
            this.Controls.Add(this.lblUserSecondName);
            this.Controls.Add(this.lblUserFirstName);
            this.Controls.Add(this.txtUserFirstName);
            this.Controls.Add(this.lblTitle);
            this.MaximumSize = new System.Drawing.Size(260, 320);
            this.MinimumSize = new System.Drawing.Size(260, 320);
            this.Name = "ctrlUser";
            this.Size = new System.Drawing.Size(260, 320);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox txtUserFirstName;
        private Label lblUserFirstName;
        private Label lblUserSecondName;
        private TextBox txtUserSecondName;
        private Label lblUserPatronymic;
        private TextBox txtUserPatronymic;
        private Label lblUserEmail;
        private Label lblUserPhone;
        private TextBox txtUserEmail;
        private TextBox txtUserPhone;
        private Button btnAddUser;
        private ErrorProvider errorProvider1;
    }
}