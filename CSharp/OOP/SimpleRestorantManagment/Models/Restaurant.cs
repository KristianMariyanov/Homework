using System.Linq;

namespace RestaurantManager.Models
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class Restaurant : IRestaurant
    {

        private string name;
        private string location;

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Name of the resturant cannot be null");
                }
                this.name = value;
            }
        }

        public string Location
        {
            get { return this.location; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Name of the resturant cannot be null");
                }
                this.location = value;
            }
        }

        public IList<IRecipe> Recipes { get; private set; }

        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            var menu = new StringBuilder();
            string headerMenu = String.Format("***** {0} - {1} *****", this.Name, this.Location);
            menu.AppendLine(headerMenu);

            var drinkRecipes = Recipes.Where(r => r is Drink);
            if (drinkRecipes.Any())
            {
                menu.AppendLine("~~~~~ DRINKS ~~~~~");

                foreach (var recipe in drinkRecipes)
                {
                    menu.AppendLine(recipe.ToString());
                }
            }

            var saladRecipes = Recipes.Where(r => r is Salad);
            if (saladRecipes.Any())
            {
                menu.AppendLine("~~~~~ SALADS ~~~~~");

                foreach (var recipe in saladRecipes)
                {
                    menu.AppendLine(recipe.ToString());
                }
            }

            var mainCourseRecipes = Recipes.Where(r => r is MainCourse);
            if (mainCourseRecipes.Any())
            {
                menu.AppendLine("~~~~~ MAIN COURSES ~~~~~");

                foreach (var recipe in mainCourseRecipes)
                {
                    menu.AppendLine(recipe.ToString());
                }
            }

            var dessertRecipes = Recipes.Where(r => r is Dessert);
            if (dessertRecipes.Any())
            {

                menu.AppendLine("~~~~~ DESSERTS ~~~~~");

                foreach (var recipe in dessertRecipes)
                {                  
                    menu.AppendLine(recipe.ToString());
                }
            }

            if (!dessertRecipes.Any() &&
                !saladRecipes.Any() &&
                !mainCourseRecipes.Any() &&
                !drinkRecipes.Any())
            {
                menu.AppendLine("No recipes... yet");
            }
            return menu.ToString().TrimEnd('\n', '\r');

        }
    }
}
