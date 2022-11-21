using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Net.Http;

namespace _17
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BankAccount<string> account1= new BankAccount<string>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());
            BankAccount<int> account2 = new BankAccount<int>();
            account2.Input();
            Console.WriteLine(account2.GetInfo());
            Console.ReadKey();
        }
    }


}

