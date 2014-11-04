using System;

namespace RestaurantManager.Models
{

    using Interfaces;

    class Salad : Meal, ISalad
    {

        private const bool PastaIsVegan = true;
        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare, PastaIsVegan)
        {
            this.ContainsPasta = containPasta;
        }

        public bool ContainsPasta { get; private set; }

        public override string ToString()
        {
            string salad = String.Format(@"[VEGAN] ==  {0} == ${1}
Per serving: {2} {3}, {4} kcal
Ready in {5} minutes
Contains pasta: {6}",
                    this.Name, String.Format("{0:0.00}", this.Price),
                    this.QuantityPerServing, "g", this.Calories,
                    this.TimeToPrepare, this.ContainsPasta ? "yes" : "no");

            return salad;
        }
    }
}
