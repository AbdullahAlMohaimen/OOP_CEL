using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    //interface
    interface Transaction
    {
        //all method must be use
        string Deposite(int amount);
        string Withdraw(int amount);
        int BalanceCheck();
    }


    //Saving Account
    public class SavingAccount : Transaction
    {
        public string AccNo;
        public string Name;
        public int Balance;

        private int withdrawLimit = 20000;    //daily withdraw amount limit
        private int TodayWithdrawAmount = 0;  //daily withdraw amount

        //deposite method for saving account
        public string Deposite(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Deposited Amount:  {amount}"); //show deposite amount
            return "Successffully Deposited";
        }

        //withdraw method for saving account
        public string Withdraw(int amount)
        {
            if (Balance <= amount)
            {
                return "Insufficient balance!"; 
            }
            else if (TodayWithdrawAmount + amount > withdrawLimit)
            {
                return "You doesn't have limit";
            }
            else
            {
                Balance = Balance - amount;
                TodayWithdrawAmount = TodayWithdrawAmount + amount;  //daily withdraw amount calculate
                Console.WriteLine($"Withdraw Amount: {amount}");     //show withdraw amount
                return "Successfully withdrawna";
            }
        }



        public int BalanceCheck()
        {
            return Balance;
        }
    }




    //Current Account
    public class CurrentAccount :Transaction
    {
        public string AccNo;
        public string Name;
        public int Balance;

        //deposite method for crrent account
        public string Deposite(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Deposited Amount:  {amount}");    //show deposite amount
            return "Successffully Deposited";
        }

        //withdraw method for current account
        public string Withdraw(int amount)
        {
            if (Balance <= amount)
            {
                return "Insufficient balance!";
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine($"Withdraw Amount: {amount}"); //show withdraw amount
                return "Successfully withdrawna";
            }
        }

        //Balance check
        public int  BalanceCheck()
        {
            
            return Balance;
        }
    }
}
