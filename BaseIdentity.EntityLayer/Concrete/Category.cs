using System;
using System.Collections.Generic;

namespace BaseIdentity.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public int CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
