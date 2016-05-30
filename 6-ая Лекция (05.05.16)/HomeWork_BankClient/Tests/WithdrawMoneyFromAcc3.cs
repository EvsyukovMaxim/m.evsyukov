﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class WithdrawMoneyFromAcc3
    {
        [TestMethod]
        public void WithdrawMoneyFromAccount3()
        {
            //Arange
            BaseAccount example = new BaseAccount("");

            //Act
            example.WithdrawMoneyFromAccount(-1000);

            //Assert
            Assert.AreEqual(101000, example.ReturnCurrentSum);
        }
    }
}
