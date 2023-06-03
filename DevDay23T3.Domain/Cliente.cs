using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay23T3.Domain
{
    public class Cliente
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; } //"CPF"
        public void seila(Guid id)
        {
            Console.WriteLine("id " + id);
        }
    }

}
