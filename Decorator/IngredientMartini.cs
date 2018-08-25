using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class IngredientMartini : CocktailIngredient
    {
        public IngredientMartini(ICocktail cocktailPart) : base(cocktailPart)
        {
            _name = "Martini";
        }
    }
}
