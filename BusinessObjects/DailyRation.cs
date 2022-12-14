using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class DailyRation : BusinessObject
    {
        public int N { get; set; } // number of meal times per day (by default - 3)
        public Dictionary<string, MealTime> MealTimes { get; set; } // food for each mealtime
        public DailyRation(int n=3)
        {
            N = n;
            MealTimes = new Dictionary<string, MealTime>();
            MealTimes["Завтрак"] = new MealTime("Завтрак");
            MealTimes["Обед"] = new MealTime("Обед");
            MealTimes["Ужин"] = new MealTime("Ужин");
        }
        // number of calories per day
        public double GetCalories()
        {
            double calories = 0;
            foreach (string s in MealTimes.Keys)
            {
                foreach (Product p in MealTimes[s].Meal)
                    calories += p.Calories;
            }
            return calories;
        } 
        public override string ToString()
        {
            String output = String.Empty;
            foreach (string s in MealTimes.Keys)
            {
                output += s+": "+"\n";
                foreach (Product p in MealTimes[s].Meal)
                {
                    output += p.ToString() + "\n";
                }
            }
            return output;
        }
    }
}
