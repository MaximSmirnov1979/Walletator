using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walletator.Model;

namespace Walletator.Service
{
    internal class OperationService
    {
        // метод извлечения отфильтрованных операций
        public List<Operation> FilterOperations(OperationFilterParam param, int accountId)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var operations = db.Operations
                    .Include(operation => operation.Category)
                    .Where(operation =>
                        operation.AccountId == accountId &&
                        operation.Day >= param.PeriodFrom &&
                        operation.Day <= param.PeriodTo);

                     // фильтрация по списанию/зачислению
                if (!param.IsAll)
                {
                    if (param.IsAdd)
                    {
                        operations = operations.Where(operation => operation.Amount >= 0);
                    }
                    else
                    {
                        operations = operations.Where(operation => operation.Amount < 0);
                    }
                }

                //фильтрация по комментарию
                if (!param.IsNoComment)
                {
                    operations = operations
                        .Where(operation => operation.Comment.ToLower().Contains(param.Comment.ToLower()));
                }


                //фильтрация по категории
                if (!param.IsNoCategory)
                {
                    operations = operations
                        .Where(operation => operation.Category.Name.ToLower().Contains(param.Category.ToLower()));
                }

                //фильтрация по сумме от
                if (!param.IsNoAmountFrom)
                {
                    operations = operations
                        .Where(operation => Math.Abs (operation.Amount) >= param.AmountFrom);
                }

                //фильтрация по сумме до
                if (!param.IsNoAmountTo)
                {
                    operations = operations
                        .Where(operation => Math.Abs(operation.Amount) <= param.AmountTo);
                }
                return operations.ToList();
            }
        }

        //Add - метод добавление операции в таблицу
        public Operation Add(Operation operation)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                operation.Day = new DateTime(operation.Day.Year, operation.Day.Month, operation.Day.Day, 0, 0, 0);
                db.Operations.Add(operation);
                db.SaveChanges();
                // если операция зарегистрирована, то меняется баланс счета на сумму операции
                // получаем нужный счет
                Account account = db.Accounts.First(account => account.Id == operation.AccountId);
                // добаляем значение операции к балансу счета
                account.Balance += operation.Amount;
                db.Accounts.Update(account);
                db.SaveChanges();
                return operation;
            }
        }

        
        

        

        //метод вывода всех операций  по id счета в обратном порядке
        public List<Operation> FilterByAccountIdDesc(OperationFilterParam param, int accountId)
        {
            List<Operation> operations = FilterOperations (param, accountId);
            operations.Reverse();
            return operations;
        }

        //метод вывода всех операций  отсортированных по дате
        public List<Operation> FilterByAccountIdOrderByDay(OperationFilterParam param, int accountId)
        {
            List<Operation> operations = FilterOperations(param, accountId);
            
            return operations.OrderBy(operation => operation.Day).ToList();

        }

        //метод вывода всех операций  отсортированных по дате в обратном порядке 
        public List<Operation> FilterByAccountIdOrderByDayDesc(OperationFilterParam param, int accountId)
        {
            List<Operation> operations = FilterByAccountIdOrderByDay(param, accountId);
            operations.Reverse();
            return operations;
        }

        //метод вывода всех операций  отсортированных по сумме операций
        public List<Operation> FilterByAccountIdOrderByAmount(OperationFilterParam param, int accountId)
        {
            List<Operation> operations = FilterOperations(param, accountId);

            return operations.OrderBy(operation => operation.Amount).ToList();
        }

        //метод вывода всех операций  отсортированных по сумме операций в обратном порядке 
        public List<Operation> FilterByAccountIdOrderByAmountDesc(OperationFilterParam param, int accountId)
        {
            List<Operation> operations = FilterByAccountIdOrderByAmount(param, accountId);
            operations.Reverse();
            return operations;
        }

        //метод вывода всех операций  отсортированных по категории 
        public List<Operation> FilterByAccountIdOrderByCategory(OperationFilterParam param, int accountId)
        {
            List<Operation> operations = FilterOperations(param, accountId);

            return operations.OrderBy(operation => operation.CategoryId).ToList();
        }

        //метод вывода всех операций  отсортированных по категории в обратном порядке 
        public List<Operation> FilterByAccountIdOrderByCategoryDesc(OperationFilterParam param, int accountId)
        {
            List<Operation> operations = FilterByAccountIdOrderByCategory(param, accountId);
            operations.Reverse();
            return operations;
        }
        //удаление операции из таблицы по id
        public Operation? RemoveById(int id)
        {
            Operation? deleted = GetById(id); 
            if (deleted != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    db.Operations.Remove(deleted);
                    db.SaveChanges();
                    // если операция удалена, то меняется баланс счета на сумму операции
                    // получаем нужный счет
                    Account account = db.Accounts.First(account => account.Id == deleted.AccountId);
                    // удаляем значение операции из балансу счета
                    account.Balance -= deleted.Amount;
                    db.Accounts.Update(account);
                    db.SaveChanges();
                    return deleted;
                }
            }
            return null;
        }

        //получение операции по id
        public Operation? GetById(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Operations.FirstOrDefault((operation) => operation.Id == id);
            }
        }

    }
}
