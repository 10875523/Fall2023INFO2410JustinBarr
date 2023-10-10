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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MO3Part
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creates Dictionary to hold created plants
        Dictionary<string, Plant> plantDict = new Dictionary<string, Plant>();

        /// <summary>
        /// Initializes mainwindow and calls loadvalues function
        /// </summary>
        public MainWindow()
        {
            //Initialize Main Window and Call LoadValues Function
            InitializeComponent();
            LoadValues();
        }

        /// <summary>
        /// Puts premade values into dropdown boxes
        /// </summary>
        private void LoadValues()
        {
            //Puts Environments into the Environment ComboBox
            CbEnvironment.Items.Add("Forest");
            CbEnvironment.Items.Add("Desert");
            CbEnvironment.Items.Add("Tropical");

            //Puts Types into the type ComboBox
            CbType.Items.Add("Flower");
            CbType.Items.Add("Tree");
            CbType.Items.Add("Shrub");
        }

        /// <summary>
        /// When made plant is selected, display details about selected plant in new window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
        {
            //If a plant has been selected
            if (LstBoxPlants.SelectedIndex > -1)
            {
                //If selected plant exists in plant dictionary
                if (plantDict.TryGetValue(LstBoxPlants.SelectedItem.ToString(), out Plant selectedPlant))
                {
                    //Create an instance of the PlantDetailsWindow
                    PlantDetailsWindow pdw = new PlantDetailsWindow();
                    //Make the Details window have properties of selected plant
                    pdw.NewPlant = selectedPlant;
                    //Update the details window and show it
                    pdw.UpdateGUI();
                    pdw.Show();
                }
                else
                {
                    //Error message
                    MessageBox.Show("Couldn't find the plant in the database.");
                }
            }
            else
            {
                //Error message
                MessageBox.Show("Please select a plant first.");
            }
        }

        /// <summary>
        /// Adds the plant information to plant dictionary and shows it in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            //If the input doesn't cause errors
            if (InputIsValid())
            {
                //Set variables to the input information
                string name = TxtBoxName.Text;
                string env = CbEnvironment.SelectedItem.ToString();
                string type = CbType.SelectedItem.ToString();

                //Create an instance of plant class to fill out
                Plant plant = null;

                //Checks to see what type of plant was chosen, and creates an instance of that class
                switch (CbType.SelectedItem.ToString())
                {

                    case "Flower":
                        plant = new Flower(type, env, name);
                        break;
                    case "Tree":
                        plant = new Tree(type, env, name);
                        break;
                    case "Shrub":
                        plant = new Shrub(type, env, name);
                        break;
                    default:
                        MessageBox.Show("Unexpected Error!");
                        break;
                }
                //If the plant instance was succesfully filled out
                if (plant != null)
                {
                    //If the plant is already in dictionary
                    if (plantDict.ContainsKey(plant.Name))
                    {
                        //Error message
                        MessageBox.Show("Plant already made.");
                    }
                    //If the plant isn't in the dictionary
                    else
                    {
                        //Add the plant to the dictionary
                        plantDict.Add(plant.Name, plant);
                        //Add the plant to the list box
                        LstBoxPlants.Items.Add(plant.Name);
                    }

                }

            }
        }

        /// <summary>
        /// Checks to ensure user input is valid to create plant
        /// </summary>
        /// <returns></returns>
        private bool InputIsValid()
        {
            //Empty error message variable
            string errorMessage = "";

            //If the user didn't put a name in for plant
            if (TxtBoxName.Text == string.Empty)
            {
                //Put this error message on one line of variable
                errorMessage += "Please enter a plant name.\n\n";
            }
            //If the Environment hasn't been selected
            if (CbEnvironment.SelectedIndex == -1)
            {
                //Put this error message on one line of variable
                errorMessage += "Please select an environment.\n\n";
            }
            //If the type hasn't been selected
            if (CbType.SelectedIndex == -1)
            {
                //Put this error message on one line of variable
                errorMessage += "Please select a plant type.\n\n";
            }
            //If the error message variable has any message
            if (errorMessage != "")
            {
                //Display the error message and return false
                MessageBox.Show(errorMessage);
                return false;
            }
            //If the error message variable is still empty
            else
            {
                //Return true
                return true;
            }
        }

        /// <summary>
        /// Changes the image which represents the selected environment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbEnvironment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //If the selected environment is equal to one of the case requirments, select corresponding image and update it
            switch (CbEnvironment.SelectedItem.ToString())
            {
                case "Desert":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/desert.png", UriKind.Relative));
                    break;
                case "Forest":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/forest.png", UriKind.Relative));
                    break;
                case "Tropical":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/tropical.jpg", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Changes the image which represents the selected type of plant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //If the selected type is equal to one of the case requirments, select corresponding image and update it
            switch (CbType.SelectedItem.ToString())
            {
                case "Flower":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/rose.png", UriKind.Relative));
                    break;
                case "Tree":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/tree.jpg", UriKind.Relative));
                    break;
                case "Shrub":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/shrub.png", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }
    }
}
