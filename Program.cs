// See https://aka.ms/new-console-template for more information
// Создать класс сотрудники (имя, возраст, должность, зарплата)
// Создать геттреры и сеттеры с проверкой.
// Заполнить обьект с клавиатуры и вывести на экран
//staff - сотрудники
//_name _age    
using static System.Console;
namespace SimpleProject
{
    class Example
    {
        int _num;
        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            Write("Введите целое число:");
            example.Num = int.Parse(ReadLine()); // set
            
        Write("Вы ввели:");
            WriteLine(example.Num); // get
        }
    }
}
