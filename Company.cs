using System;
using SQLite;

namespace DBDemo
{
    public class Company
    { 
        [PrimaryKey]
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.Name + "(" + this.Address + ")";

        }

    }
}
