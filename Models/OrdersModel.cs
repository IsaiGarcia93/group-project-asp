using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class OrdersModel
    {
        [Key]
        [Display(Name = "Order Number")]
        public int OrderID { get; set; }
    
        //propably display title in <view> instead of [Display(Name = "")]
        //or do we need both??
        //[Required]
        //public int ItemId { get; set; }

        [Display(Name = "Date")]
        [Required]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Total")]
        public decimal TotalAmount { get; set; }

        public ICollection<OrderDetails> OrderDetails{ get; set; }
    }
}
