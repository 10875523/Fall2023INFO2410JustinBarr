using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Barr_Justin_Nutrition_Tracking_Application_XAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Sets the file name to a variable
        private const string DataFileName = "nutrition.txt";
        //Creates a dictionary to hold food information
        private Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();

        /// <summary>
        /// Runs the main Window functionality
        /// </summary>
        public MainWindow()
        {
            //Initializes MainWindow
            InitializeComponent();

            //Calls LoadData function
            LoadDataFromFile();

            //Attach an event handler for when an item is selected in the ComboBox
            comboBox.SelectionChanged += ComboBox_SelectionChanged;
        }

        /// <summary>
        /// Reads txt file and puts information into the comboBox
        /// </summary>
        private void LoadDataFromFile()
        {
            //Try the enclosed code
            try
            {
                //Open the text file
                using (StreamReader reader = File.OpenText(DataFileName))
                {
                    //Try the enclosed code
                    try
                    {
                        //Basically skips the first line which only describes the format of the file
                        reader.ReadLine();
                    }
                    //If above code doesn't work, run following code
                    catch(Exception)
                    {
                        //Display an error message
                        MessageBox.Show("File is empty. Please input data first.");
                    } 
                    //For as long as there is more information in the file, execute the enclosed code
                    while (!reader.EndOfStream)
                    {
                        //Sets one line of information from file to line variable
                        string line = reader.ReadLine();
                        //Parse the line and create a Food object
                        Food food = ParseFoodData(line);
                        //Add the Food object to the dictionary
                        foodDictionary[food.FoodName] = food;
                        //Add the FoodName to the ComboBox
                        comboBox.Items.Add(food.FoodName);
                    }
                    //Closes the streamreader
                    reader.Close();
                }        
            }
            //If the above code doesn't work, execute the following code
            catch (IOException ex)
            {
                //Display error message
                MessageBox.Show($"Error loading data from {DataFileName}: {ex.Message}");
            }
        }

        /// <summary>
        /// Takes the string, parses the information, and returns a new food object
        /// </summary>
        /// <param name="line">Line of text from txt file</param>
        /// <returns>Food object from Food class</returns>
        private Food ParseFoodData(string line)
        {
            //Try to execute the enclosed code
            try
            {
                //Split the line by tabs to extract individual data fields assigning it to a string array
                string[] dataFields = line.Split('\t');

                //Check if there are enough fields
                if (dataFields.Length >= 28)
                {
                    //Parse individual data fields and create a Food object with proper variable type
                    string foodName = dataFields[0].Trim();
                    double calcium = double.Parse(dataFields[1].Trim());
                    string servingSize = dataFields[2].Trim();
                    double weight = double.Parse(dataFields[3].Trim());
                    double percentWater = double.Parse(dataFields[4].Trim());
                    double calories = double.Parse(dataFields[5].Trim());
                    double protein = double.Parse(dataFields[6].Trim());
                    double carbohydrate = double.Parse(dataFields[7].Trim());
                    double fiber = double.Parse(dataFields[8].Trim());
                    double cholesterol = double.Parse(dataFields[9].Trim());
                    double totalFat = double.Parse(dataFields[10].Trim());
                    double saturatedFat = double.Parse(dataFields[11].Trim());
                    double monosaturatedFat = double.Parse(dataFields[12].Trim());
                    double polyunsaturatedFat = double.Parse(dataFields[13].Trim());
                    double iron = double.Parse(dataFields[14].Trim());
                    double magnesium = double.Parse(dataFields[15].Trim());
                    double sodium = double.Parse(dataFields[16].Trim());
                    double phosphorous = double.Parse(dataFields[17].Trim());
                    double caPRatio = double.Parse(dataFields[18].Trim());
                    double potassium = double.Parse(dataFields[19].Trim());
                    double zinc = double.Parse(dataFields[20].Trim());
                    double niacin = double.Parse(dataFields[21].Trim());
                    double thiamin = double.Parse(dataFields[22].Trim());
                    double riboflavin = double.Parse(dataFields[23].Trim());
                    double vitaminA = double.Parse(dataFields[24].Trim());
                    double vitaminB6 = double.Parse(dataFields[25].Trim());
                    double vitaminC = double.Parse(dataFields[26].Trim());
                    string foodType = dataFields[27].Trim();

                    //Create and return a Food object
                    return new Food(foodName, foodType, servingSize, weight, percentWater, calories, protein, carbohydrate, fiber, cholesterol, totalFat, saturatedFat, monosaturatedFat, polyunsaturatedFat, calcium, iron, magnesium, sodium, phosphorous, caPRatio, potassium, zinc, niacin, thiamin, riboflavin, vitaminA, vitaminB6, vitaminC);
                }
                //If there aren't enough fields, execute the code inside
                else
                {
                    //Show error message and return null
                    MessageBox.Show("Data does not fit file format. Please correct and try again.");
                    return null;
                }
            }
            //If above code doesn't work, execute the following
            catch (Exception)
            {
                //Show error message and return null
                MessageBox.Show($"The file does not contain proper data types.");
                return null;
            }
        }

        /// <summary>
        /// Detects if the comboBox has a selected food item and displays detail window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //If the comboBox has a selected item, execute enclosed code
            if (comboBox.SelectedItem != null)
            {
                //Set the comboBox selection to a string variable to pass through dictionary
                string selectedFoodName = comboBox.SelectedItem.ToString();

                //If comboBox selection is in the dictionary, execute enclosed code
                if (foodDictionary.ContainsKey(selectedFoodName))
                {
                    //Get the selected Food object from the dictionary and assign it a variable
                    Food selectedFood = foodDictionary[selectedFoodName];

                    //Create a DetailWindow and pass the selected Food object variable
                    DetailWindow detailWindow = new DetailWindow();
                    detailWindow.SetNutritionalValues(selectedFood);

                    //Show the DetailWindow
                    detailWindow.ShowDialog();
                }
            }
        }
    }
}