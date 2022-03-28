using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        private int _accountNumber;
        private int _balance = -1;
        private TypeBankAccount _typeBankAccount;

        private static int numberOfAccount;

        public BankAccount()
        {

        }

        public BankAccount(int balance) : this(balance, TypeBankAccount.CurrentAccount)
        {

        }

        public BankAccount(TypeBankAccount typeBankAccount) : this(-1, typeBankAccount)
        {

        }

        public BankAccount(int balance, TypeBankAccount typeBankAccount)
        {
            numberOfAccount += 1;
            _accountNumber = numberOfAccount;

            _balance = balance;
            _typeBankAccount = typeBankAccount;
        }

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public TypeBankAccount TypeBankAccount
        {
            get
            {
                return _typeBankAccount;
            }
            set
            {
                _typeBankAccount = value;
            }
        }

        public void toDeposit(int value)
        {
            _balance += value;
        }

        public void Withdraw(int value)
        {
            int resultBalance = _balance - value;
            if (resultBalance >= 0)
            {
                _balance = resultBalance; 
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }
    }
}
