using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walletator.Model
{
    public class Operation
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public decimal Amount { get; set; }
        public DateTime Day { get; set; }
        public int AccountId { get; set; } //аккаунт id
        
        [ForeignKey("AccountId")] //аннотация указывает на связь аккаунта с id
        public Account? Account { get; set; } // навигационное свойство связи
        public int CategoryId { get; set; } //категория id

        [ForeignKey("CategoryId")] //аннотация указывает на связь категории с id
        public Category? Category { get; set; } // навигационное свойство связи
        
        //конструктор по умолчанию
        public Operation()
        {
            Id = 0;
            Comment = "";
            Amount = 0;
            Day = new DateTime();
            AccountId = 0;
            Account = null;
            CategoryId = 0;
            Category = null;

        }
        public override string ToString()
        {
            return $"{Id} - {Comment} - {Amount} - {Day} - {Category}";
        }
    }
}
