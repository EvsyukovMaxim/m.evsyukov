﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class VipClient : BankClient
    {
        List<BaseAccount> accountsList = new List<BaseAccount>();
        public override void AddAccount(BaseAccount account)
        {
            N = 10;
            base.AddAccount(account);
        }
    }
}
