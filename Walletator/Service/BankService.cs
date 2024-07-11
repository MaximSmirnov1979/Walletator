using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walletator.Model;

namespace Walletator.Service
{
    //класс для работы с банками
    internal class BankService
    {
        //Add - метод добавление банка в таблицу
        public Bank Add(Bank bank) 
        { 
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Banks.Add(bank);
                db.SaveChanges();
                return bank;
            }
        }
        //удаление банка из таблицы по id
        public Bank? RemoveById(int id)
        {
            Bank? deleted = GetById(id);
            if(deleted != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    db.Banks.Remove(deleted);
                    db.SaveChanges();
                    return deleted;
                }
            }
            return null;
        }

        //получение банка по id
        public Bank? GetById(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Banks.FirstOrDefault((bank) => bank.Id == id);
            }
        }

        //редактирование банка
        public Bank Update(Bank bank)
        {
            Bank? updated = GetById(bank.Id);
            if(updated != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    
                    db.Banks.Update(bank);
                    db.SaveChanges();
                    return updated;
                }
            }
            return null;
        }

        //метод вывода всех банков
        public List<Bank> GetAll()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Banks.ToList();
            }
        }
    }
}
