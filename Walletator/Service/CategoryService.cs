using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walletator.Model;

namespace Walletator.Service
{
    //класс для работы с категориями
    internal class CategoryService
    {
        //методы работы с категориями

        // добавление новой категории
        public Category Add(Category category)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return category;
            }
        }

        //получение категории по id
        public Category? GetById(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Categories.FirstOrDefault((category) => category.Id == id);
            }
        }

        //редактирование категорий
        public Category? Update(Category category)
        {
            Category? updated = GetById(category.Id);
            if (updated != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {

                    db.Categories.Update(category);
                    db.SaveChanges();
                    
                }
            }
            return updated;
        }

        //метод вывода всех категорий
        public List<Category> GetAll()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Categories.ToList();
            }
        }

        //удаление категории из таблицы по id
        public Category? RemoveById(int id)
        {
            Category? deleted = GetById(id);
            if (deleted != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    db.Categories.Remove(deleted);
                    db.SaveChanges();
                    return deleted;
                }
            }
            return null;
        }
    }
}
