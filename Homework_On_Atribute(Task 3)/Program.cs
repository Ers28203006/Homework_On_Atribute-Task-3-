using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_On_Atribute_Task_3_
{


    class Program
    {

        static void Main(string[] args)
        {
            RegistrationWindow user = new RegistrationWindow();

            user.Login = EnterLogin();

            string password;
            password = EnterPassword();
            user.Password = password;
        }


        #region Ввод логина

        static string EnterLogin()
        {
            string login = "";
            bool corectEnterLogin = false;
            while (corectEnterLogin == false)
            {
                Type type = typeof(RegistrationWindow);
                Type tUPerDateAttr = typeof(UserPersonalDateAttribute);
                UserPersonalDateAttribute upda = (UserPersonalDateAttribute)
                    Attribute.GetCustomAttribute(type, tUPerDateAttr);

                Console.WriteLine(upda.Login);

                login = Console.ReadLine();

                for (int i = 0; i < login.Length; i++)
                {
                    if ((((login[i] >= 'а') || (login[i] >= 'А')) && ((login[i] >= 'я') || (login[i] >= 'Я'))) || (login.Length < 4))
                    {
                        corectEnterLogin = false;
                    }

                    else
                    {
                        corectEnterLogin = true;
                    }
                }

                type = typeof(RegistrationWindow);
                Type tRemAttr = typeof(RemarkAttribute);
                RemarkAttribute remark = (RemarkAttribute)
                    Attribute.GetCustomAttribute(type, tRemAttr);

                if (corectEnterLogin == false)
                {
                    
                    Console.WriteLine(remark.Remark2);
                }

                else
                {
                    Console.WriteLine(remark.Remark1);
                }
            }
            return login;
        }

        #endregion

        #region Ввод пароля

        static string EnterPassword()
        {
            bool corectEnterPassword = false;
            int strength;
            string password = "";
            while (corectEnterPassword == false)
            {
                strength = 0;
                Type type = typeof(RegistrationWindow);
                Type tUPerDateAttr = typeof(UserPersonalDateAttribute);
                UserPersonalDateAttribute upda = (UserPersonalDateAttribute)
                    Attribute.GetCustomAttribute(type, tUPerDateAttr);
                Console.WriteLine(upda.Password);
                password = ReadPassword();

                if (ContainsDigit(password)) strength++;
                if (ContainsLowerLetter(password)) strength++;
                if (ContainsPunctuation(password)) strength++;
                if (ContainsSeparator(password)) strength++;
                if (ContainsUpperLetter(password)) strength++;

                    type = typeof(RegistrationWindow);
                    Type tRemAttr = typeof(RemarkAttribute);
                    RemarkAttribute remark=(RemarkAttribute)
                        Attribute.GetCustomAttribute(type, tRemAttr);
                if (strength < 4 || password.Length < 8)
                {
                    Console.WriteLine(remark.Remark2);
                    corectEnterPassword = false;
                }
                else 
                {
                    Console.WriteLine(remark.Remark1);
                    corectEnterPassword = true;
                }
            }
            return password;
        }


        static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {

                        password = password.Substring(0, password.Length - 1);

                        int pos = Console.CursorLeft;

                        Console.SetCursorPosition(pos - 1, Console.CursorTop);

                        Console.Write(" ");

                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            Console.WriteLine();
            return password;
        }


        static bool ContainsLowerLetter(string _password)
        {
            foreach (char c in _password)
            {
                if ((Char.IsLetter(c)) && (Char.IsLower(c)))
                    return true;
            }
            return false;
        }

        static bool ContainsUpperLetter(string _password)
        {
            foreach (char c in _password)
            {
                if ((Char.IsLetter(c)) && (Char.IsUpper(c)))
                    return true;
            }
            return false;
        }

        static bool ContainsDigit(string _password)
        {
            foreach (char c in _password)
            {
                if (Char.IsDigit(c))
                    return true;
            }
            return false;
        }

        static bool ContainsPunctuation(string _password)
        {
            foreach (char c in _password)
            {
                if (Char.IsPunctuation(c))
                    return true;
            }
            return false;
        }

        static bool ContainsSeparator(string _password)
        {
            foreach (char c in _password)
            {
                if (Char.IsSeparator(c))
                    return true;
            }
            return false;
        }

        #endregion
    }
}
