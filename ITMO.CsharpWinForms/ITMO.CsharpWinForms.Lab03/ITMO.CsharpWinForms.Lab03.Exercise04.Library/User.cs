using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpWinForms.Lab03.Exercise04.Library
{
    public class User
    {
        private string firstName;
        private string secondName;
        private string patronymic;
        private string email;
        private int phone;

        public User(string firstName, string secondName, string patronymic, string email, int phone)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.patronymic = patronymic;
            this.email = email;
            this.phone = phone;
        }

        public override string ToString()
        {
            return "Пользователь\nФамилия: " + secondName + "\nИмя: " + firstName + "\nОтчество: " + patronymic + "\nЭл. почта: " + email + "\nТелефон: " + phone.ToString();
        }
    }
}
