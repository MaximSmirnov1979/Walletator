using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walletator.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category()
        {
             Id = 0;
             Name = "";
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
