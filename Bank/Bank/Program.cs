using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 100;
            TypeBankAccount typeBankAccount = TypeBankAccount.CurrentAccount;

            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();
            BankAccount bankAccount3 = new BankAccount();

            List<BankAccount> bank = new List<BankAccount>();
            bank.Add(bankAccount1);
            bank.Add(bankAccount2);
            bank.Add(bankAccount3);

            foreach (var bankAccount in bank)
            {
                bankAccount.setBalance(balance);
                bankAccount.setTypeBankAccount(typeBankAccount);
                Console.WriteLine(bankAccount.getAccountNumber());
                Console.WriteLine(bankAccount.getBalance());
                Console.WriteLine(bankAccount.getTypeBankAccount());
            }

        }
    }
}
