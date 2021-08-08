using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDBCodeFirst.DBModel
{
   public  class OrderStatuses
    {

        [Key]
        public int OrderStatusID { get; set; }
        [Required]
        public string OrderStatusName { get; set; }


    }
}
