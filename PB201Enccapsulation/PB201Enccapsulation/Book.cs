using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Enccapsulation
{
    public class Book : Product
    {
        public string Genre { get; set; }
        public Book(int id) : base(id){ }

        public Book(int id, string name) : base(id, name) { }


        public Book(int id, string name, double price) : base(id, name, price) { }
        

        public Book(int id, string name, double price,string genre) : this(id, name, price)
        {
            Genre = genre;
        }
    }
}
