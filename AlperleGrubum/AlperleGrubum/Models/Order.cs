using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlperleGrubum.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required, MaxLength(5)]
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }

        [Required, MaxLength(40)]
        public string ShipName { get; set; }
        [Required, MaxLength(60)]
        public string ShipAddress { get; set; }
        [Required, MaxLength(15)]
        public string ShipCity { get; set; }
        [Required, MaxLength(15)]
        public string ShipRegion { get; set; }
        [Required,  MaxLength(10)]
        public string ShipPostalCode { get; set; }
        [Required, MaxLength(15)]
        public string ShipCountry { get; set; }

        public int OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }

    }
}
