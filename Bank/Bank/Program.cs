using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //int balance = 100;
            //TypeBankAccount typeBankAccount = TypeBankAccount.CurrentAccount;

            BankAccount bankAccount1 = new BankAccount(1000);
            BankAccount bankAccount2 = new BankAccount(TypeBankAccount.CreditAccount);
            BankAccount bankAccount3 = new BankAccount(3000, TypeBankAccount.DepositAccount);

            bankAccount1.TypeBankAccount = TypeBankAccount.CurrentAccount;
            bankAccount2.Balance = 2000;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount1);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            foreach (var bankAccount in bankAccounts)
            {
                Console.WriteLine(bankAccount.AccountNumber);
                Console.WriteLine(bankAccount.Balance);
                Console.WriteLine(bankAccount.TypeBankAccount);
            }

            BankAccount bankAccount4 = new BankAccount(0, TypeBankAccount.CurrentAccount);
            bankAccount4.toDeposit(500);
            Console.WriteLine(bankAccount4.AccountNumber);
            Console.WriteLine(bankAccount4.Balance); 

            bankAccount4.Withdraw(200);
            Console.WriteLine(bankAccount4.AccountNumber);
            Console.WriteLine(bankAccount4.Balance);

            bankAccount4.Withdraw(300);
            Console.WriteLine(bankAccount4.AccountNumber);
            Console.WriteLine(bankAccount4.Balance);

            bankAccount4.Withdraw(300);
            Console.WriteLine(bankAccount4.AccountNumber);
            Console.WriteLine(bankAccount4.Balance);




        }
    }
}
