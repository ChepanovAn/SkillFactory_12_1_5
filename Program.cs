using System;

namespace SkillFactory_12_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите: Логин \nИмя \nНаличие премиум подписки (Ответ: True либо False)");
            string login = Console.ReadLine();
            string name = Console.ReadLine();
            bool subscription = Convert.ToBoolean(Console.ReadLine());

            User Person = new User(login, name, subscription);
            Console.WriteLine($"Привет {Person.Name}");

            if (!Person.IsPremium)
                User.ShowAds();
        }
    }
}
