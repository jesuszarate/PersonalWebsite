using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zaratEngineering.Models
{
    public class WishItemImage
    {
        String imagePath = 
            "~/Images/s6-edge.jpg"; 

        public String ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
    }
}