namespace ITMO.CsharpWinForms.Lab04.Exercise02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPersonForm editForm = new EditPersonForm();
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Вначале метода реализуйте проверку, что не выбран элемент для
            //редактирования и присвойте выбранный элемент экземпляру
            //списка
            if (personsListView.SelectedItems.Count == 0)
                return;
            ListViewItem item = personsListView.SelectedItems[0];

            //Создайте форму диалогового окна и передайте содержимое
            //элементов списка главной формы в свойства диалогового окна
            EditPersonForm editForm = new EditPersonForm();
            editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            //В случае изменения данных и нажатия кнопки Сохранить на
            //форме диалога передайте новые значения свойств в
            //соответствующие элементы списка
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            item.Text = editForm.FirstName;
            item.SubItems[1].Text = editForm.LastName;
            item.SubItems[2].Text = editForm.Age.ToString();
        }
    }
}