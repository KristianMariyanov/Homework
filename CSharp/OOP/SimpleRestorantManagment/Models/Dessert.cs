using System;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Dessert : Meal, IDessert
    {
        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan) : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.WithSugar = true;
        }

        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            const string ifNoSugar = "[NO SUGAR] ";
            const string ifVegan = "[VEGAN] ";
            string dessert = String.Format(@"{0}{1}==  {2} == ${3}
Per serving: {4} {5}, {6} kcal
Ready in {7} minutes", 
                     this.WithSugar == false ? ifNoSugar : "", 
                     this.IsVegan == true ? ifVegan : "",
                     this.Name, String.Format("{0:0.00}", this.Price),
                     this.QuantityPerServing,
                     "g", this.Calories, this.TimeToPrepare);

            return dessert;
        }
    }
}
