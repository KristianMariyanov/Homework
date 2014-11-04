using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    using System;
    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;

    public class RecipeFactory : IRecipeFactory
    {
        public IDrink CreateDrink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
        {
            return new Drink(name, price, calories, quantityPerServing, timeToPrepare, isCarbonated);
        }

        public ISalad CreateSalad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
        {
            return new Salad(name, price, calories, quantityPerServing, timeToPrepare, containsPasta);
        }

        public IMainCourse CreateMainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
        {
            MainCourseType enumType = GetMainCourseType(type);
            return new MainCourse(name, price, calories, quantityPerServing, timeToPrepare, isVegan, enumType);
        }

        public IDessert CreateDessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
        {
            return new Dessert(name, price, calories, quantityPerServing, timeToPrepare, isVegan);
        }

        private MainCourseType GetMainCourseType(string type)
        {
            MainCourseType enumType;
            switch (type)
            {
                case "Pasta":
                    enumType = MainCourseType.Pasta;
                    break;
                case "Soup":
                    enumType = MainCourseType.Soup;
                    break;
                case "Entree":
                    enumType = MainCourseType.Entree;
                    break;
                case "Side":
                    enumType = MainCourseType.Side;
                    break;
                case "Meat":
                    enumType = MainCourseType.Meat;
                    break;
                case "Other":
                    enumType = MainCourseType.Other;
                    break;
                default:
                    throw new ArgumentException("The type of Main course is not valid");

            }
            return enumType;
        }
    }
}