using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SellersWebsite.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Product name")]
        public string ProductName { get; set; }
        [DisplayName("Available amount")]
        public int AvailableAmount { get; set; }
        public double Price { get; set; }
        [DisplayName("Expiry date")]
        public DateTime ExpiryDate { get; set; }
    }
}
