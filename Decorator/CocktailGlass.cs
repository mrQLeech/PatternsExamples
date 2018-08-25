using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CocktailGlass : ICocktail
    {

        public void Mix()
        {
            Console.WriteLine("Creating cocktail. Add to glass:");
        }
    }
}
