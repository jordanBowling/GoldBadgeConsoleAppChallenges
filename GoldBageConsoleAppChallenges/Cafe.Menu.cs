using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeChallenge
{
    public class Menu
    {
        public int ComboNumber { get; set; }

        public string MealName { get; set; }
        
        public string Description { get; set; }
        
        public string Ingredients { get; set; }

        public double Price { get; set; }

        public Menu() { }

        public Menu(int comboNumber, string mealName, string description, string ingredients, double price)
        {
            ComboNumber = comboNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }









    }
}
