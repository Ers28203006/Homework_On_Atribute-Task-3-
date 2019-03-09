using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_On_Atribute_Task_3_
{
    [AttributeUsage(AttributeTargets.All)]
    class UserPersonalDateAttribute: System.Attribute
    {
        public string Login { get; set; }
        public string Password { get; set; }
       

        public UserPersonalDateAttribute(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
