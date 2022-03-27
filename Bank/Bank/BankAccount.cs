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
        private int _balance;
        private TypeBankAccount _typeBankAccount;

        private static int numberOfAccount;

        public BankAccount()
        {
            numberOfAccount += 1;
            _accountNumber = numberOfAccount;
        }

        public int getAccountNumber()
        {
            return _accountNumber;
        }

        public int getBalance()
        {
            return _balance;
        }

        public TypeBankAccount getTypeBankAccount()
        {
            return _typeBankAccount;
        }

        public void setAccountNumber(int accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public void setBalance(int balance)
        {
            _balance = balance;
        }

        public void setTypeBankAccount(TypeBankAccount typeBankAccount)
        {
            _typeBankAccount = typeBankAccount;
        }

    }
}
