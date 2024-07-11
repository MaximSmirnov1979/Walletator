using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walletator.Model
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //конструктор по умолчанию
        public Bank()
        {
            Id = 0;
            Name = "";
        }
        //To string
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
