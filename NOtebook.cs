using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructObjectToClass
{
    internal class NOtebook
    {
        string favoriteSong = "Calm Down \n Favorite Part: Baby show me you can calm down, calm down \n";
        string mostHeartbreakingSong = "Lose You To Love Me";
        string worstBoyfriend = "Justin Bieber";
        int InstgramFollowers = 412;

        public string FavoriteSong { get => favoriteSong;  }
        public string MostHeartbreakingSong { get => mostHeartbreakingSong;  }
        public string WorstBoyfriend { get => worstBoyfriend;  }
        public int InstgramFollowers1 { get => InstgramFollowers;  }

        public override string ToString()
        {
            return $"Selena's favorite song is {favoriteSong}, The song she sang when her heart broke is {mostHeartbreakingSong}, In her notebook she does talk about her worst boyfriend and that is: {worstBoyfriend}, and she has all the name of her followers which calculates to {InstgramFollowers} million.";
}   }   }

