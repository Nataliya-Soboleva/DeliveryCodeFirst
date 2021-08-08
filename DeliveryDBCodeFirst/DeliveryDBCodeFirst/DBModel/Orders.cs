using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDBCodeFirst.DBModel
{
   public  class Orders
    {

        [Key]
        public int OrderID { get; set; }
        [Required]
        public string AddressTo { get; set; }
        [Required]
        public string DescriptionOfCargo { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public Couriers CourierID { get; set; }
        [Required]
        public OrderStatuses StatusID { get; set; }
        
    }


}

