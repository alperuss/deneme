using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlperleGrubum.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MaxLength(15)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Byte[] Image { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }


    }
}
