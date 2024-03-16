namespace ExampleLib
{
    public class Person: IInit, IComparable
    {
        protected string[] names = { "Иван", "Антон", "Павел", "Олег", "Денис" };
        protected string[] lastNames = { "Иванов", "Антонов", "Павлов", "Петров", "Денисов" };
        protected string name;
        int age;
        protected static Random rnd = new Random();
        protected string Name { get; set; }
        protected string LastName { get; set; }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 80)
                {
                    age = 18;
                }
                else
                {
                    age = value;
                }
            }
        }

        public Person()
        {
            Name = "No name";
            LastName = "No last name";
            Age = 18;
        }

        public Person(string name, string last_name, int age)
        {
            Name = name;
            LastName = last_name;
            Age = age;
        }

        public virtual void RandomInit()
        {
            Random rnd = new Random();
            Name = names[rnd.Next(names.Length)];
            LastName = lastNames[rnd.Next(lastNames.Length)];
            Age = rnd.Next(18, 100);
        }

        public virtual void Show()
        {
            Console.WriteLine($"ФИО: {Name + " " + LastName}, возраст: {Age}");
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person p)
            {
                return Name == p.Name || LastName == p.LastName || Age == p.Age;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Name} {LastName}, возраст {Age}";
        }

        public virtual void Init()
        {
            Name = names[rnd.Next(names.Length)];
            LastName = lastNames[rnd.Next(lastNames.Length)];
            Age = rnd.Next(18, 100);
        }

        public virtual int CompareTo(object? obj)
        {
            return String.Compare(this.Name, ((Person)obj).Name);
        }

        
    }
}