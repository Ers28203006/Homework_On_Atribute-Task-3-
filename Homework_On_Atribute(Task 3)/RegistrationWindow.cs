using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_On_Atribute_Task_3_
{
    [UserPersonalDate("Логин: ", "Пароль: ")]
    [Remark("Вы ввели верные данные!!!", "Введены не верные данные!!!")]
    class RegistrationWindow
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
