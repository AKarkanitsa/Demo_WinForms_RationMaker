using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class MealTime : BusinessObject
    {
        public string Name { get; set; } //breakfast, lunch, dinner, etc.
        public List<Product> Meal { get; set; } // list of meals for one meal time
        public MealTime(string name)
        {
            Name = name;
            Meal = new List<Product>();
        }
        public double GetCalories()
        {
            double calories = 0;
            foreach (Product p in Meal) calories += p.Calories;
            return calories;
        }
    }
}
