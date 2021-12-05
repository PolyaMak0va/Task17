using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{ /*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
  * Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
  * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса, параметризированного различными типам. 
  * Заполнить его поля и вывести информацию об экземпляре класса на печать.
  */
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> account1 = new BankAccount<int>("Иванов Иван Иванович", 23785634, 23.56);
            account1.Print();
            BankAccount<string> account2 = new BankAccount<string>("Васильев Радион Жукович", "H09U923", 123765.27);
            account2.Print();
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        private string ID_Owner { get; set; }
        private T AccNumber { get; set; }
        private double AccBalance { get; set; }

        public BankAccount(string identifierOwner, T accountNumber, double accountBalance)
        {
            ID_Owner = identifierOwner;
            AccNumber = accountNumber;
            AccBalance = accountBalance;
        }
        public void Print()
        {
            Console.WriteLine(new string('=', 60));
            Console.Write("ФИО владельца:         \t{0}", ID_Owner);
            Console.Write("\nНомер счёта владельца: \t{0}", AccNumber);
            Console.Write("\nБаланс счёта:    \t{0} руб.\n", AccBalance);
            Console.WriteLine(new string('=', 60));
            Console.WriteLine();
        }
    }
}
