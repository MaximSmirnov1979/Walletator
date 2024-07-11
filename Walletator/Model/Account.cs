using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walletator.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Title { get; set; } //  заголовок
        public string Identity { get; set; } // номер счета
        public decimal Balance { get; set; } //баланс счета
        public int BankId { get; set; } //банк id

        [ForeignKey("BankId")] //аннотация указывает на связь банка с id
        public Bank? Bank { get; set; } // навигационное свойство связи

        //конструктор
        public Account()
        {
            Id = 0;
            Balance = 0;
            Title = "";
            Identity = "";
            BankId = 0;
            Bank = null;

        }
        //To string
        public override string ToString()
        {
            return $"{Id} - {Title} - {Balance}";
        }


    }
}
