using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlperleGrubum.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required,MaxLength(40)]
        public string ProductName { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }
        [Required,MaxLength(20)]
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public int OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }
    
        public List<Supplier> Supplier { get; set; }
        public List<Category> Categories { get; set; }
    }
}
