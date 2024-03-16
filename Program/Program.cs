using ExampleLib;

namespace example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] p = new Person[20];          //создание массива p с объектами типа Person
            for(int i = 0; i < p.Length; i++)
            {
                if (i <= 10)
                {
                    p[i] = new Person();
                    p[i].Init();
                }
                else if(i <=15 && i > 10)
                {
                    p[i] = new Employee();
                    p[i].Init();
                }
                else
                {
                    p[i] = new Engineer();
                    p[i].Init();
                }
            }
            
            Employee[] emp = new Employee[10];  //создание массива emp с объектами типа Employee
            for (int i = 0; i < emp.Length; i++)
            {
                if (i <= 5)
                {
                    emp[i] = new Employee();
                    emp[i].Init();
                }
                else
                {
                    emp[i] = new Engineer();
                    emp[i].Init();
                }
            }

            Array.Sort(p);  //сортировка массива p по Name с помощью интерфейса IComparable

            Console.WriteLine("\nSorted by IComparable");
            foreach (Person item in p)
            {
                Console.WriteLine(item);
            }

            Array.Sort(emp, new SortByExperience());  //сортировка массива emp по Experience с помощью интерфейса IComparer

            Console.WriteLine("\nSorted by IComparer");
            foreach (Employee item in emp)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Введите имя для поиска");
            string findName = Console.ReadLine();

            Console.WriteLine("Введите возраст для поиска");
            int findAge = int.Parse(Console.ReadLine());

            int pos = Array.BinarySearch(p, new Person(findName, "Иванов", findAge));  //бинарный поиск в массиве p по имени и возрасту

            if (pos < 0) Console.WriteLine("Не найден");
            else Console.WriteLine($"Pos = {pos}");

            IInit[] array = new IInit[20];                                             //создание массива элементов, реализующих интерфейс IInit
            for (int i = 0; i < array.Length; i++)
            {
                if (i <= 5)
                {
                    array[i] = new Person();
                    array[i].Init();
                }
                else if (i > 5 && i <= 10)
                {
                    array[i] = new Employee();
                    array[i].Init();                    
                }
                else if(i > 10 && i <= 15)
                {
                    array[i] = new Engineer();
                    array[i].Init();
                }
                else
                {
                    array[i] = new Animal();
                    array[i].Init();
                }
            }

            foreach(IInit item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}