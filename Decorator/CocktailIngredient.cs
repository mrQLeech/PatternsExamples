using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CocktailIngredient : ICocktail
    {
        private double _volumeMilliliters = 0d;
        protected ICocktail _cocktailPart;
        protected string _name;

        public CocktailIngredient(ICocktail cocktailPart)
        {
            _cocktailPart = cocktailPart;
        }

        public double VolumeMilliliters
        {
            set
            {
                _volumeMilliliters = value;
            }
        }



        public void Mix()
        {
            _cocktailPart.Mix();
            Console.WriteLine($"Ingredient {_name}\t{Math.Round(_volumeMilliliters, 2)} ml.");
        }
    }
}
