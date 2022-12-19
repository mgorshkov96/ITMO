namespace ITMO.CsharpWinForms.Lab03.Exercise04.Library
{
    public partial class ctrlUser : UserControl
    {
        public ctrlUser()
        {
            InitializeComponent();
        }

        public static List <User> users = new List<User>();

        public string FirstName 
        { 
            get { return txtUserFirstName.Text; }
            set { txtUserFirstName.Text = value; }
        }
        public string SecondName 
        { 
            get { return txtUserSecondName.Text; }
            set { txtUserSecondName.Text = value; }
        }
        public string Patronymic 
        { 
            get { return txtUserPatronymic.Text; }
            set { txtUserPatronymic.Text = value; }
        }
        public string Email 
        { 
            get { return txtUserEmail.Text; }
            set { txtUserEmail.Text = value; }
        }
        public string Phone 
        {
            get { return txtUserPhone.Text; }
            set { txtUserPhone.Text = value; }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool checkPhone = int.TryParse(Phone, out int phoneParsed);

            if ((checkPhone == false) | (FirstName == "") | (SecondName == "") | (Patronymic == "") | (Email == "") | (Phone == ""))
            {
                MessageBox.Show("Вы заполнили не все поля, либо допустили ошибку в номере");
            }
            else
            {
                // Создаем нового пользователя и помещаем его в List
                User user = new User(FirstName, SecondName, Patronymic, Email, phoneParsed);
                users.Add(user);

                // Отчищаем поля ctrlUser
                MessageBox.Show("Пользователь добавлен!");
                FirstName = SecondName = Patronymic = Email = Phone = "";
                errorProvider1.Clear();
            }
        }

        private void txtUserPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & (e.KeyChar != 8))
            {
                e.Handled = true;
            }

            if (txtUserPhone.Text.Length > 12)
            {
                errorProvider1.SetError(txtUserPhone, "Номер не может содержать более 11 цифр");
            }            
        }

        private void txtUserSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 48 & e.KeyChar < 57)
            {
                e.Handled = true;
            }                   
        }

        private void txtUserFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 48 & e.KeyChar < 57)
            {
                e.Handled = true;
            }
        }

        private void txtUserPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 48 & e.KeyChar < 57)
            {
                e.Handled = true;
            }
        }
    }
}