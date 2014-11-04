using System;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    abstract public class Meal : Recipe, IMeal
    {
        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare , bool isVegan):
            base (name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.Unit = MetricUnit.Grams;
        }

        public bool IsVegan { get; private set; }

        public void ToggleVegan()
        {
            IsVegan = !IsVegan;
        }
    }
}
