using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailID { get; set; }

        //Order entity relationship
        public int OrderID { get; set; }
        public OrdersModel Order { get; set; }

        //Items entity relationship
        public int ItemID { get; set; }
        public ItemsModel Item { get; set; }


    }
}
