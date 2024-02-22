using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18
{
    internal class BankAccount <T>
    {
        public T Number { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public void Input()
        {
            Console.WriteLine("Введите номер счёта");
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите количество средств");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
        }
        public string GetInfo()
        {
            return $"Номер счёта: {Number}, Баланс: {Balance}, Имя: {Name}";
        }
    }
}
