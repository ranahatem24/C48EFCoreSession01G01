using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48EFCoreSession01.Models
{
    //Model|Entity|POCO Class(Plain Old CLR Object) C#Class that define your data structure
    internal class Product
    {
        public int Id { get; set; }
        public string?ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

    }
}
