using ITMO.ASPNET.MVC.WebMVCR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPNET.MVC.WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index(string hel)
        {
            //string Greeting = ModelClass.ModelHello() + ", " + hel;
            //return Greeting;

            // string res = ExeEnum();

            // string res = ExeStruct();

            // string res = StudyCsharp.SetStatus(3);

            // string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));

            // string res = StudyCsharp.GetFunction(0, 9);

            string res = ExeFactorial(5);

            return res;
        }

        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Тип банковского счёта {0}", goldAccount);
            string res2 = String.Format("Тип банковского счёта {0}", platinumAccount);
            string res = res1 + "<p>" + res2;
            return res;
        }

        public string ExeStruct()
        {
            BankAccount goldBankAccount;
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;

            // string res = String.Format("Информация о банковском счете: {0}", goldBankAccount);
            string res = $"Информация о банковском счете: {goldBankAccount}";

            return res;
        }

        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);

            if (ok)
            {
                return String.Format("Факториал числа {0} равен {1} ", x, f);
            }
            else
            {
                return "Невозможно вычислить факториал";
            }
        }
    }
}