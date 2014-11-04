using System;

namespace RestaurantManager.Models
{
    using Interfaces;

    public class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, MainCourseType type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = type;
        }

        public MainCourseType Type { get; private set; }

        public override string ToString()
        {
            string ifVegan = "[VEGAN] ";
            string MainCourse = String.Format(@"{0}==  {1} == ${2}
Per serving: {3} {4}, {5} kcal
Ready in {6} minutes
Type: {7}", 
          this.IsVegan == true ? ifVegan : "", this.Name,
          String.Format("{0:0.00}", this.Price), this.QuantityPerServing, 
          "g", this.Calories, this.TimeToPrepare, this.Type);
            return MainCourse;

        }
    }
}
