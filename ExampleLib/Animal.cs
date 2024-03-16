using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLib
{
    public class Animal: IInit
    {
        string[] types = { "кошка", "мышка", "собачка", "ежик", "лошадка" };
        string[] names = { "Рекс", "Шарик", "Машка", "Жучка", "Тузик", "Гектор", "Ася", "Кузя" };
        static Random rnd = new Random(); // static - общий для всего класса

        public string Type { get; set; } //строка, поэтому автосвойство
        public string Name { get; set; }
        int age;
        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || age > 30)
                    age = 1;
                else
                    age = value;
            }
        }

        public Animal() //конструктор без параметров
        {
            Name = "No name";
            Type = "No type";
            Age = 1;            
        }

        public Animal(string name, string type, int age, int nom) // конструктор с параметрами
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Type} : {Name}, {Age}";
        }        

        public virtual void Init()
        {
            Type = types[rnd.Next(types.Length)];
            Name = names[rnd.Next(names.Length)];
            Age = rnd.Next(0, 30);            
        }
    }
}
