using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    /// <summary>
    /// 定义一个个人账户类
    /// 用户Id
    /// 口令Password
    /// 姓名Name
    /// 钱decimal Money
    /// </summary>
    public class Account
    {
        /// <summary>
        /// 账户Id
        /// </summary>
        public string Id { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        private decimal money;
  
        public Account(string id,string password,decimal money=0m)
        {
            this.Id = id;
            this.Password = password;
            this.money = money;
        }
        public bool SaveMoney(decimal money)
        {
            if (money < 0) return false;
            this.money = money;
            return true;
        }
        public bool DrawMoney(decimal money)
        {
            if(money<0 || money > this.money) return false;
            this.money -= money;
            return true;
        }
    }

    /// <summary>
    /// 银行类用于保存账户和开户
    /// </summary>
    class Bank
    {
        /// <summary>
        /// 银行名
        /// </summary>
        public string Name { get; }
        List<Account> Accounts = new List<Account>();
        public Bank(string name)
        {
            this.Name = name;
        }
        public bool OpenAccount(string id,string password,decimal money = 0, string name="")
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password)) return false;
            Account a = new Account(id, password, money);
            a.Name = name;
            Accounts.Add(a);
            return true;
        }
        public object CloseAccount(string id,string password)
        {
            Account account;
            account = FindAccount(id, password);
            if (account!=null)
            {
                this.Accounts.Remove(account);
                return true;
            }
            else
            {
                return "未找到用户";
            }
        }
        public Account FindAccount(string id,string password)
        {

           foreach(Account a in this.Accounts)
            {
                if (a.Id==id && a.Password == password)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
