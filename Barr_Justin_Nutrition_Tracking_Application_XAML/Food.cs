using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barr_Justin_Nutrition_Tracking_Application_XAML
{
   /// <summary>
   /// Creates Food class with readable and writeable variables
   /// </summary>
    public class Food
    {
        //Creates variables that can be retrieved and set
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public string ServingSize { get; set; }
        public double Weight { get; set; }
        public double PercentWater { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fiber { get; set; }
        public double Cholesterol { get; set; }
        public double TotalFat { get; set; }
        public double SaturatedFat { get; set; }
        public double MonosaturatedFat { get; set; }
        public double PolyunsaturatedFat { get; set; }
        public double Calcium { get; set; }
        public double Iron { get; set; }
        public double Magnesium { get; set; }
        public double Sodium { get; set; }
        public double Phosphorous { get; set; }
        public double CaPRatio { get; set; }
        public double Potassium { get; set; }
        public double Zinc { get; set; }
        public double Niacin { get; set; }
        public double Thiamin { get; set; }
        public double Riboflavin { get; set; }
        public double VitaminA { get; set; }
        public double VitaminB6 { get; set; }
        public double VitaminC { get; set; }

        /// <summary>
        /// Creates Food object
        /// </summary>
        /// <param name="name">Food name from txt file</param>
        /// <param name="type">Food type from txt file</param>
        /// <param name="servingSize">Serving size from txt file</param>
        /// <param name="weight">Food weight from txt file</param>
        /// <param name="percentWater">Percentage of Water from txt file</param>
        /// <param name="calories">Calorie count from txt file</param>
        /// <param name="protein">Protein count from txt file</param>
        /// <param name="carbohydrate">Carbohydrate count from txt file</param>
        /// <param name="fiber">Fiber amount from txt file</param>
        /// <param name="cholesterol">Cholesterol amount from txt file</param>
        /// <param name="totalFat">Total Fats amount from txt file</param>
        /// <param name="saturatedFat">Saturated Fat amount from txt file</param>
        /// <param name="monosaturatedFat">Monosaturated Fat amount from txt file</param>
        /// <param name="polyunsaturatedFat">Polyunsaturated Fat amount from txt file</param>
        /// <param name="calcium">Calcium amount from txt file</param>
        /// <param name="iron">Iron amount from txt file</param>
        /// <param name="magnesium">Magnesium amount from txt file</param>
        /// <param name="sodium">Sodium amount from txt file</param>
        /// <param name="phosphorous">Phosphorous amount from txt file</param>
        /// <param name="caPRatio">caP Ration from txt file</param>
        /// <param name="potassium">Potassium amount from txt file</param>
        /// <param name="zinc">Zinc amount from txt file</param>
        /// <param name="niacin">Niacin amount from txt file</param>
        /// <param name="thiamin">Thiamin amount from txt file</param>
        /// <param name="riboflavin">Riboflavin amount from txt file</param>
        /// <param name="vitaminA">Vitamin A amount from txt file</param>
        /// <param name="vitaminB6">Vitamin B6 amount from txt file</param>
        /// <param name="vitaminC">Vitamin C amount from txt file</param>
        public Food(string name, string type, string servingSize, double weight, double percentWater, double calories, double protein, double carbohydrate, double fiber, double cholesterol, double totalFat, double saturatedFat, double monosaturatedFat, double polyunsaturatedFat, double calcium, double iron, double magnesium, double sodium, double phosphorous, double caPRatio, double potassium, double zinc, double niacin, double thiamin, double riboflavin, double vitaminA, double vitaminB6, double vitaminC)
        {
            //Sets Food variable to the parameters passed through
            FoodName = name;
            FoodType = type;
            ServingSize = servingSize;
            Weight = weight;
            PercentWater = percentWater;
            Calories = calories;
            Protein = protein;
            Carbohydrate = carbohydrate;
            Fiber = fiber;
            Cholesterol = cholesterol;
            TotalFat = totalFat;
            SaturatedFat = saturatedFat;
            MonosaturatedFat = monosaturatedFat;
            PolyunsaturatedFat = polyunsaturatedFat;
            Calcium = calcium;
            Iron = iron;
            Magnesium = magnesium;
            Sodium = sodium;
            Phosphorous = phosphorous;
            CaPRatio = caPRatio;
            Potassium = potassium;
            Zinc = zinc;
            Niacin = niacin;
            Thiamin = thiamin;
            Riboflavin = riboflavin;
            VitaminA = vitaminA;
            VitaminB6 = vitaminB6;
            VitaminC = vitaminC;
        }
    }

}
