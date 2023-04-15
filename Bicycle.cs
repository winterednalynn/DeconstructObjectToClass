using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructObjectToClass
{
    public class Bicycle
    {
        //FIELDS 
        string _color = "Cool Mint";
        string _type = "Beaumont City Bike - Step Through 7 Speed ";
        string information = "Expertly crafted for conquering the city.\r\n" +
            "Cruise your city in classic Euro-style with Beaumont. " +
            "A step through frame makes getting on and off a breeze. " +
            "The rear rack and optional basket are perfect for running small errands. And the full-wrap fenders make it possible to ride, rain or shine"; 
        double price= 329.99;

        //ONLY USING PROPERTIES 
        public string Color { get => _color;  }
        public string Type { get => _type;  }
        public string Information { get => information;  }
        public double Price { get => price;  }
    }
}
