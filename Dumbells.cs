using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructObjectToClass
{
    public class Dumbells
    {

        //FIELDS 
        string _benefits = "Benefits of using a dumbell:\n"+
            "*Lower health risks. Weight lifting with dumbbells lowers your risk of heart attack, stroke, and cardiovascular disease"+
            "\r\n*Better sleep. Using dumbbells in the gym can lead to improved shut-eye. ..." +
            "\r\n*Weight loss. When you build lean muscle mass and burn fat, it leads to weight loss."; //USING GET PROPERTIES 
        string _color;
        int _weight;
        int _price;
   


        //CONSTRUCTORS
        public Dumbells(string color, int weight, int price)
        {
            Color = color;
            Weight = weight;
            Price = price;
        }


       
        //PROPERTIES 
        public string Benefits { get => _benefits; }
        public string Color { get => _color; set => _color = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int Price { get => _price; set => _price = value; }

        public override string ToString()
        {
            return $" Dumbell Color: {_color} \n Dumbell Weight: {_weight} \n Price: {_price}"; 

    }
}       }

