using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructObjectToClass
{
    public class Mugs
    {
        string _coverTitle;
        string _colorOfmug;
        string _typeOfmug;
        int _ounce;

        public Mugs(string coverTitle, string colorOfmug, string typeOfmug, int ounce)
        {
            _coverTitle = coverTitle;
            _colorOfmug = colorOfmug;
            _typeOfmug = typeOfmug;
            _ounce = ounce;
        }
        public string CoverTitle { get => _coverTitle; set => _coverTitle = value; }
        public string ColorOfmug { get => _colorOfmug; set => _colorOfmug = value; }
        public string TypeOfmug { get => _typeOfmug; set => _typeOfmug = value; }
        public int Ounce { get => _ounce; set => _ounce = value; }

        public override string ToString()
        {
            return $"On the mug it will say {_coverTitle} \n The color of the mug will be {_colorOfmug} \n The mug will be {_typeOfmug} \n The mug can hold up to {_ounce}ounce of coffee";
        }
    }

       
    
}
