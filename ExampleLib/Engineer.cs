using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExampleLib
{
    public class Engineer: Employee
    {
        protected string[] profile = { "Электромеханик", "Главный инженер", "Инженер 1 категории", "Инженер", "Инженер-технолог" };
        protected string prof;

        protected static Random rnd = new Random();
        public string Profile { get; set; }
        public Engineer() : base()
        {
            Profile = "No profile";
        }
        public Engineer(string name, string last_name, int age, string dep, int sal, int exp, string prof) : base(name, last_name, age, dep, sal, exp)
        {
            Profile = prof;
        }
        public override void Init()
        {
            base.Init();
            Profile = profile[rnd.Next(profile.Length)];
        }
        public override void Show()
        {
            Console.WriteLine($"ФИО: {Name + " " + LastName}, возраст: {Age}, департамент: {Department}, ЗП: {Salary}\n" +
                $"профиль: {Profile}");
        }

        public override string ToString()
        {
            return $"{Name} {LastName}, возраст {Age}, департамент {Department}, ЗП {Salary}, профиль {Profile}, стаж {Experience}";
        }
    }
}
