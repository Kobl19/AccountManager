using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFinancesAccounting.Models.Repositories.Interfaces
{
    public interface IRepository:IDisposable
    {
        IEnumerable<User> AllUsers();
        IEnumerable<Account> AllAccount();
        User FindUser(int UserId);
        Account FindAccount(int AccountId);
        void ChangeAccount(Account account);
        void AddAccount(Account account);
    }
}
