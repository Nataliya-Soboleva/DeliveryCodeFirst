using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDBCodeFirst.DBModel
{
    public class Couriers
    {
        [Key]
        public int CourierID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool AvailabilityRights { get; set; }     
        public string RightsСategory { get; set; }
       
    }


}

