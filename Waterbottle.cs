using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructObjectToClass
{
    internal class Waterbottle
    {
        //FIELDS ARE ALREADY IDENTIFIED & DATA PUT 
        double _price = 11.00;
        string _color = "Pink"; 
        string _brand = "Brand";
        int _ounces = 32;
        string information = "Morning & Evening Reminders. Made from Tritan Plastic. LEAK PROOF & DROP RESISTANT. Portable & Durable";


        //PROPERTIES = GET ONLY 
        public double Price { get => _price;  }
        public string Color { get => _color;  }
        public string Brand { get => _brand; }
        public int Ounces { get => _ounces;  }
        public string Information { get => information; }
    }
}
