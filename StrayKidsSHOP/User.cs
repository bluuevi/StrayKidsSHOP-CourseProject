using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StrayKidsSHOP
{
    public class User //класс пользователь
    {
        public static User user;  //объект для инициализации пользователя
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public decimal Money { get; set; }

        public decimal Points { get; set; }

        private User(string name, string login, string password) //конструктор пользователя
        {
            Name = name;
            Login = login;
            Password = password;
            Money = 1000000;
            Points = 100;
        }

        // статические методы для инициализации пользователя
        private static bool CheckUser(string login, string password) //проверка существования файла с данным логином и соответствия пароля
        {
            string[] user_count = Directory.GetFiles("Users"); //подсчет колва файлов
            bool flag = false; 
            foreach (string file in user_count) 
            {
                StreamReader reader = new StreamReader(file);
                string[] mas = reader.ReadLine().Split(' '); //разделение слов пробелами
                if (mas[0] == login && mas[1] == password) //если логин и пароль соответствуют искомым
                {
                    flag = true; reader.Close();
                    break;
                }
                reader.Close();
            }
            if (!flag)
            {
                return false;
            }
            else return true;
        }
        private static bool CheckUser(string login) //проверка на существование заданного логина
        {
            string[] user_count = Directory.GetFiles("Users");
            bool flag = false;
            foreach (string file in user_count) 
            {
                StreamReader reader = new StreamReader(file);
                string[] mas = reader.ReadLine().Split(' '); if (mas[0] == login)
                {
                    flag = true;
                    reader.Close(); break;
                }
                reader.Close();
            }
            if (!flag)
            {
                return true;
            }
            else return false;
        }
        internal static User SignupUser(string name, string login, string password) //регистрация пользователя
        {
            if(CheckUser(login)) //если нет пользователя с данным логином
            {
                 user = new User(name, login, password); //создаем пользователя
               

                string s = login + " " + password + " " + name + " " + user.Money + " " + user.Points; 
                File.WriteAllText("Users\\" + user.Login +".txt", s); //записываем в файл логин пароль и имя
                return user;
            }
           return null;
        }
        internal static User LoginUser(string login, string password) //авторизация пользователя
        {
            if (CheckUser(login, password)) //если есть такой пользователь
            {
                string[] mas = File.ReadAllText("Users\\"+login + ".txt").Split(' ');
                //информацию из файла записываем в соответствующие поля
                user = new User(mas[2], mas[0], mas[1]);
                user.Money = Convert.ToDecimal(mas[3]);
                user.Points = Convert.ToDecimal(mas[4]);
                return user;
            }
            
            return null;
        }
        internal void Pay() //после оплаты
        {
            //переписываем файл пользователя с новыми значениями денег и бонусов
            string s = this.Login + " " + this.Password + " " + this.Name + " " + user.Money + " " + user.Points;
            File.WriteAllText("Users\\" + user.Login + ".txt", s);
        }
    }
}
