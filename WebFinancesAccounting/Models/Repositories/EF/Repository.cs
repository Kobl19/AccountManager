using Domain;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFinancesAccounting.Models.Repositories.Interfaces;

namespace WebFinancesAccounting.Models.Repositories.EF
{
    public class Repository:IRepository
    {
        private AccountContext db;
        public Repository()
        {
            this.db = new AccountContext("DefaultConnection");
        }
        public User FindUser(int UserId)
        {
            return db.Users.FirstOrDefault(x => x.Id == UserId);
        }

        public IEnumerable<Account> AllAccount()
        {
            return db.Acoounts;
        }
        public Account FindAccount(int AccountId)
        {
            return db.Acoounts.FirstOrDefault(x=>x.Id==AccountId);
        }
        public void AddAccount(Account account)
        {
            db.Acoounts.Add(account);
            db.SaveChanges();
        }
        public void ChangeAccount(Account account)
        {
            Account previousAccount= db.Acoounts.FirstOrDefault(x => x.Id == account.Id);
            int counter = 0;
            if (previousAccount.Count != account.Count)
            {
                previousAccount.Count = account.Count;
                counter++;
            }
            if (previousAccount.CurrencyName != account.CurrencyName)
            {
                previousAccount.CurrencyName = account.CurrencyName;
                counter++;
            }
            if (counter>0)
            {
                previousAccount.DateLastChanges = DateTime.Now;
                db.SaveChanges();
            }
        }

        public IEnumerable<User> AllUsers()
        {
            return db.Users;
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}