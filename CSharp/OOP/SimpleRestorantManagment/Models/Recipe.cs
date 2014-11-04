namespace RestaurantManager.Models
{
    
    using System;
    using Interfaces;

    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;

        protected Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }

        public Recipe(string name, decimal price, int quantityPerServing)
        {
            this.name = name;
            this.price = price;
            this.quantityPerServing = quantityPerServing;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Name of the resturant cannot be null");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The Price must be positive number");
                }
                this.price = value;
            }
        }

        public virtual int Calories
        {
            get { return this.calories; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The Calories must be positive number");
                }
                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The Quantity must be positive number");
                }
                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; protected set; }

        public virtual int TimeToPrepare
        {
            get { return this.timeToPrepare; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The time to prepare must be positive number");
                }
                this.timeToPrepare = value;
            }
        }
    }
}
