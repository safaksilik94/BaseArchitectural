using Safak.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Entities.Concrete
{
    public class Product :IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public Int16 UnitsOnOrder { get; set; }
        public Int16 ReorderLevel { get; set; }
        public Boolean Discontinued { get; set; }

    }
}
