﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    abstract class BankClient
    {
        public int N { get; protected set; }
        List<BaseAccount> accountsList = new List<BaseAccount>();

        public virtual void AddAccount(BaseAccount account)
        {
            int listCount = accountsList.Count;
            if (listCount < N)
            {
                accountsList.Add(account);
            }
            else
            {
                Console.WriteLine("Можно только 3 счета");
            }
        }

        public void PrintAccountNumber()
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                Console.WriteLine($"Сумма Обычного клиента: {accountsList[i].ReturnCurrentSum}, Номер счета: {accountsList[i].AccountNumber}, ФИО: {accountsList[i].ReturnFIO}");
            }
        }

        public void CloseClientAccount(string accountNumber)
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                if (accountsList[i].AccountNumber == accountNumber)
                {
                    accountsList.RemoveAt(i);
                    Console.WriteLine("Счет с номером: " + accountNumber + " - закрыт");
                }
            }
        }
    }
}
