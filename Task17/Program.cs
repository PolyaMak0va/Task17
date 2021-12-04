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
            BankAccount account = new BankAccount();
            Console.WriteLine("Введите поля для заполнения: ");
            account.Ask();
            account.ToString();
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        protected string identifierOwner;
        protected int accountNumbers;
        protected double accountBalance;
        //T accountType;

        public BankAccount(string identifierOwner, int accountNumbers, double accountBalance)
        {
            this.identifierOwner = identifierOwner;
            this.accountNumbers = accountNumbers;
            this.accountBalance = accountBalance;
        }
        public string IdentifierOwner
        {
            set
            {
                identifierOwner = value;
            }
            get 
            { 
                return identifierOwner; 
            }
        }
        public int AccountNumbers
        {
            set
            {
                accountNumbers = value;
            }
            get
            {
                return accountNumbers;
            }
        }
        public double AccountBalance
        {
            set
            {
                if (value > 0)
                {
                    accountBalance = value;
                }
                else
                { 
                    throw new ArgumentException("The operation failed");                  
                }                
            }
            get
            {
                return accountBalance;
            }
        }
        //T AccountType
        //{
        //    Ordinary,
        //    Deposit
        //}
        public void Print()
        {
            Console.Write("\nВведите ФИО владельца:         \t{0}", identifierOwner);
            Console.Write("\nВведите номер счёта владельца: \t{0}", accountNumbers);
            Console.Write("\nВведите сумму на счёте: \t{0}", accountBalance);
        }
    }
    class Client<T> : BankAccount<T>
    {
        protected T accountType;
        public Client(string identifierOwner, int accountNumbers, double accountBalance, T accountType)
            : base(identifierOwner, accountNumbers, accountBalance)
        {
            base.identifierOwner = Convert.ToString(Console.ReadLine());
            this.accountNumbers = Convert.ToInt32(Console.ReadLine());
            this.AccountBalance = Convert.ToDouble(Console.ReadLine());
            this.accountType = accountType;
        }
        public T AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Номер счёта - {0} | Фамилия владельца - {1} | Баланас счёта - {2}", this.accountNumbers, this.identifierOwner, this.accountBalance);
        }
    }
}
