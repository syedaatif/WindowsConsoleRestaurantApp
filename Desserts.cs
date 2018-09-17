using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantte
{
    class Desserts
    {
        private Dictionary<string, int> dess_dict = new Dictionary<string, int>()
        {
            {"Chocolate icecream",300 },
            {"Strawberry punch",200},
            {"Chocolate cake",450 }

        };

        public int items()
        {
          
                Menu obj = new Menu();
                return obj.itemselector(dess_dict);
            
        }
    }
}
