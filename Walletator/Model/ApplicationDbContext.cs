using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walletator.Model
{
    internal class ApplicationDbContext : DbContext
    {
        //описание таблицы банков
        public DbSet<Bank> Banks { get; set; }

        //описание таблицы категорий
        public DbSet<Category> Categories { get; set; }

        // описание таблицы аккаунтов
        public DbSet<Account> Accounts { get; set; }

        //описание таблицы операций
        public DbSet<Operation> Operations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=DESKTOP-M4U5492\\SQLEXPRESS;Initial Catalog=walletator_db;Integrated Security=SSPI;TrustServerCertificate=True"; //строка подключения к базе данных
            optionsBuilder.UseSqlServer(connectionString);
        }

        

       
    }
}
