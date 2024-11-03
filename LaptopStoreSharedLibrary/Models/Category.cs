using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStoreSharedLibrary.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //RelationShip: One to Many
        public List<Product>? Products { get; set; } 
    }
}
