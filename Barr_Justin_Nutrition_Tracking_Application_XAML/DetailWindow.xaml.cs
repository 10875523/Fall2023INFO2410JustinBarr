using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Barr_Justin_Nutrition_Tracking_Application_XAML.MainWindow;

namespace Barr_Justin_Nutrition_Tracking_Application_XAML
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        /// <summary>
        /// Runs the DetailWindow initializing code
        /// </summary>
        public DetailWindow()
        {
            //Initializes DetailWindow
            InitializeComponent();
        }

        /// <summary>
        /// Set and display nutritional values in the DetailWindow
        /// </summary>
        /// <param name="food">Food object from Food class</param>
        public void SetNutritionalValues(Food food)
        {
            //Set detail window lables to the information from Food object
            lbFoodName.Content = food.FoodName;
            lbFoodType.Content = food.FoodType;
            lbServingSize.Content = food.ServingSize;
            lbWeight.Content = food.Weight.ToString();
            lbPercentWater.Content = food.PercentWater.ToString();
            lbCalories.Content = food.Calories.ToString();
            lbProtein.Content = food.Protein.ToString();
            lbCarbohydrates.Content = food.Carbohydrate.ToString();
            lbFiber.Content = food.Fiber.ToString();
            lbCholesterol.Content = food.Cholesterol.ToString();
            lbTotalFat.Content = food.TotalFat.ToString();
            lbSaturatedFat.Content = food.SaturatedFat.ToString();
            lbMonosaturatedFat.Content = food.MonosaturatedFat.ToString();
            lbPolyunsaturatedFat.Content = food.PolyunsaturatedFat.ToString();
            lbCalcium.Content = food.Calcium.ToString();
            lbIron.Content = food.Iron.ToString();
            lbMagnesium.Content = food.Magnesium.ToString();
            lbSodium.Content = food.Sodium.ToString();
            lbPhosphorous.Content = food.Phosphorous.ToString();
            lbCaPRatio.Content = food.CaPRatio.ToString();
            lbPotassium.Content = food.Potassium.ToString();
            lbZinc.Content = food.Zinc.ToString();
            lbNiacin.Content = food.Niacin.ToString();
            lbThiamin.Content = food.Thiamin.ToString();
            lbRiboflavin.Content = food.Riboflavin.ToString();
            lbVitaminA.Content = food.VitaminA.ToString();
            lbVitaminB6.Content = food.VitaminB6.ToString();
            lbVitaminC.Content = food.VitaminC.ToString();

        }
    }
}
