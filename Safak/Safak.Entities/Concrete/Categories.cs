using Safak.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Safak.Entities.Concrete
{
    public class Categories:IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        //public int Description { get; set; }
        //public int Picture { get; set; }

    }
}
