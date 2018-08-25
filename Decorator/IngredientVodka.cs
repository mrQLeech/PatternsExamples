using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class IngredientVodka : CocktailIngredient
    {
        
        public IngredientVodka(ICocktail cocktailPart) : base(cocktailPart)
        {
            _name = "Vodka";
        }
    }
}
