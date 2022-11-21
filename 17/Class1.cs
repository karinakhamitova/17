using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class BankAccount<T>
        
    {
        private T Num { get; set; }
        private string Name { get; set; }
        private double AccountBalance { get; set; }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
          Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс счета");
            AccountBalance = Convert.ToDouble(Console.ReadLine());
        }
        public string GetInfo()
        { 
        return $"{Num} {Name} {AccountBalance}";    
        }
    }
}
