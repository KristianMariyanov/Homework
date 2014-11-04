
namespace RestaurantManager.Models
{

    using System;
    using Interfaces;

    public class Drink : Recipe, IDrink
    {
        private int calories;
        private int timeToPrepare;

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated) 
            : base(name, price, quantityPerServing)
        {
            this.Calories = calories;
            this.TimeToPrepare = timeToPrepare;
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
        }

        public bool IsCarbonated { get; private set; }

        public override sealed int Calories
        {
            get { return this.calories; }
            protected set
            {
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("The Calories of a drink cannot be more then 100");
                }
                this.calories = value;
            } 
        }

        public override sealed int TimeToPrepare 
        {
            get { return this.timeToPrepare; }
            protected set
            {
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("The Time to prepare of a drink cannot be more then 20");
                }
                this.timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            string drinkInformation =
                String.Format(@"==  {0} == ${1}
Per serving: {2} {3}, {4} kcal
Ready in {5} minutes
Carbonated: {6}",
                this.Name, String.Format("{0:0.00}", this.Price), this.QuantityPerServing, 
                "ml"
                , this.Calories, this.TimeToPrepare, this.IsCarbonated ? "yes" : "no");
            return drinkInformation;
        }
    }
}
