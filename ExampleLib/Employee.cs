using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExampleLib
{
    public class Employee: Person
    {
        protected string[] departments = { "Администрация", "Управление", "Бухгалтерия", "Экономический", "Изыскательский" };
        protected int[] salary = { 20000, 30000, 40000, 50000, 60000 };
        protected string dep;
        protected int sal;
        protected int exp;
        protected static Random rnd = new Random();
        protected int[] experience = { 2, 6, 10, 12, 15, 20, 25 };
        protected string Department { get; set; }
        protected int Salary
        {
            get => sal;
            set
            {
                if (value <= 15000 || value >= 10000)
                {
                    sal = 15000;
                }
                else
                {
                    sal = value;
                }
            }
        }

        public int Experience
        {
            get => exp;
            set
            {
                if (value <= 0 || value > 30) exp = 1;
                else exp = value;
            }
        }


        public Employee() : base()
        {
            Department = "No department";
            Salary = 0;
            Experience = 0;
        }

        public Employee(string name, string last_name, int age, string dep, int sal, int exp) : base(name, last_name, age)
        {
            Department = dep;
            Salary = sal;
            Experience = exp;
        }

        public override void Init()
        {
            base.Init();
            Department = departments[rnd.Next(departments.Length)];
            Salary = salary[rnd.Next(salary.Length)];
            Experience = experience[rnd.Next(experience.Length)];
        }

        public override void Show()
        {
            Console.WriteLine($"ФИО: {Name + " " + LastName}, возраст: {Age}, департамент: {Department}, ЗП: {Salary}");
        }

        public override string ToString()
        {
            return $"{Name} {LastName}, стаж {Experience}";
        }
    }
}
