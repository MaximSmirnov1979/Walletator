using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walletator.Model;

namespace Walletator.Service
{
    
    
    internal class AccountService
    {
        //Add - метод добавление счета в таблицу
        public Account Add(Account account)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return account;
            }
        }

        //метод вывода всех счетов
        public List<Account> GetAll()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Accounts.ToList();
            }
        }

        //получение счета по id
        public Account? GetById(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Accounts.FirstOrDefault((account) => account.Id == id);
            }
        }

        //редактирование счета
        public Account Update(Account account)
        {
            Account? updated = GetById(account.Id);
            if (updated != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {

                    db.Accounts.Update(account);
                    db.SaveChanges();
                    return updated;
                }
            }
            return null;
        }

        //удаление счета из таблицы по id
        public Account? RemoveById(int id)
        {
            Account? deleted = GetById(id);
            if (deleted != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    db.Accounts.Remove(deleted);
                    db.SaveChanges();
                    return deleted;
                }
            }
            return null;
        }
        //получение баланса на момент конца определенного дня

        public decimal BalancePerDay(int accountId, DateTime day)
        {
            Account? account = GetById(accountId);
            if(account == null)
            {
                throw new InvalidOperationException("account not found");
            }
            decimal balance = account.Balance;
            day = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0);
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Operations
                    .Where(operation => operation.AccountId == accountId && operation.Day > day)
                    .ToList().ForEach(operation => { balance -= operation.Amount; });
                return balance;
            }

        }
    }
}
