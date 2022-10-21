//  See https://aka.ms/new-console-template for more information
//  Создать класс сотрудники (имя, возраст, должность, зарплата)
//  Создать геттреры и сеттеры с проверкой.
//  Заполнить обьект с клавиатуры и вывести на экран
//  Staff - сотрудники
//  _name - имя 
//  _age - возраст
//  _post - должность
//  _salary - зарплата

using System.Xml.Linq;

using static System.Console;
namespace SimpleProject
{
    class Staff
    {
        private String _name; // поле имя
        private int _age; // поле возраст
        private string _post; // поле должность
        private int _salary; // поле зарплата

        public Staff()
        {
            string _name;
            int _age;
            string _post;
            int _salary;
        }
        public Staff(string name, int age, string post, int salary)
        {
            _name = name;
            _age = age;
            _post = post;
            _salary = salary;
            _name = name;
        }
        public void print()
        {
            Console.WriteLine("Имя : \t{0}\t" +
                "Возраст : {1}\t" +
                "должность : \t{2}\t\t"+
                "Зарплата : \t{3}\t", _name,_age,_post,_salary);

        }
        public String Name { get { return _name; } set { _name = value; } }// дать взять имя
        public int Age { get { return _age; } set { _age = value; } }       // дать взять возраст
        public String Post { get { return _post; } set { _post = value; } } // дать взять должность
        public int Salary { get { return _salary; } set { _salary = value; } } // дать взять зарплату
    }
   

    class Program
    {
        static void Main()
        {
            Staff one = new Staff();
            Write("Введите имя:\t");
            one.Name = Console.ReadLine(); // set
            Write("Введите возраст:\t");
            one.Age = int.Parse(ReadLine()); // set
            Write("Введите должность:\t");
            one.Post = ReadLine(); // set
            Write("Введите зарплату:\t");
            one.Salary = int.Parse(ReadLine()); // set
            one.print();
        }
    }
}

