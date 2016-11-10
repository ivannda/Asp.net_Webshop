using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebComputerShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Item_Discription { get; set; }
        public string Price { get; set; }

        //public virtual ICollection<ApplicationUser> Buyer { get; set; }



    }
}