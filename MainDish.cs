using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantte
{
    public class MainDish : IProducts
    {
        private Dictionary<string, int> main_dict = new Dictionary<string, int>()
        {
            {"Biryani",250},
            {"Kabab",300 },
            {"Fish fry",400 }

        };
       
        public int items()
        {
            Menu obj = new Menu();
           return obj.itemselector(main_dict);
        }


        
    }
}
