using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StrayKidsSHOP
{
    public class User
    {
        public static User user;
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public decimal Money { get; set; }

        public decimal Points { get; set; }

        private User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
            Money = 1000000;
            Points = 100;
        }


        private static bool CheckUser(string login, string password)
        {
            string[] client_count = Directory.GetFiles("Users");
            bool flag = false; 
            foreach (string file in client_count)
            {
                StreamReader reader = new StreamReader(file);
                string[] mas = reader.ReadLine().Split(' ');
                if (mas[0] == login && mas[1] == password)
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
        private static bool CheckUser(string login)
        {
            string[] client_count = Directory.GetFiles("Users");
            bool flag = false;
            foreach (string file in client_count)
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
        internal static User SignupUser(string name, string login, string password) //registration
        {
            if(CheckUser(login))
            {
                 user = new User(name, login, password);
               

                string s = login + " " + password + " " + name + " " + user.Money + " " + user.Points; 
                File.WriteAllText("Users\\" + user.Login +".txt", s);
                return user;
            }
           return null;
        }
        internal static User LoginUser(string login, string password)
        {
            if (CheckUser(login, password))
            {
                string[] mas = File.ReadAllText("Users\\"+login + ".txt").Split(' ');

                user = new User(mas[2], mas[0], mas[1]);
                user.Money = Convert.ToDecimal(mas[3]);
                user.Points = Convert.ToDecimal(mas[4]);
                return user;
            }
            
            return null;
        }
        internal void Pay()
        {
            string s = this.Login + " " + this.Password + " " + this.Name + " " + user.Money + " " + user.Points;
            File.WriteAllText("Users\\" + user.Login + ".txt", s);
        }
    }
}
