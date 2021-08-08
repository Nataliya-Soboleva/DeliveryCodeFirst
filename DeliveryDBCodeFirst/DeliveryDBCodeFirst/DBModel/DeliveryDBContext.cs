using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDBCodeFirst.DBModel
{
    public class DeliveryDBContext: DbContext
    {
        public DeliveryDBContext():base("name=DeliveryDB")
        {

        }
        public DbSet<Couriers> Couriers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStatuses> OrderStatuses { get; set; }


    }
}
