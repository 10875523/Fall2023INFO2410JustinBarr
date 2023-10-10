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

namespace JustinBarrTheAnimalFarmMO3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creates instance of animal class
        private Animal animal;

        /// <summary>
        /// Initializes main window and sets image source
        /// </summary>
        public MainWindow()
        {
            //Initializes main window and sets image source
            InitializeComponent();
            AnimalImage.Source = new BitmapImage(new Uri("Images/Default.jpg", UriKind.Relative));
        }

        /// <summary>
        /// Checks to see if a radio button has been pressed, creates the corresponding subclass of animal, and updates the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimalRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //If the Dog, Cat, or Chicken radio button is pressed, create the correct class
            if (DogRadioButton.IsChecked == true)
                animal = new Dog();
            else if (CatRadioButton.IsChecked == true)
                animal = new Cat();
            else if (ChickenRadioButton.IsChecked == true)
                animal = new Chicken();
            
            //Call the UpdateAnimalImage function
            UpdateAnimalImage();
        }

        /// <summary>
        /// Updates the Image to match the user selection
        /// </summary>
        private void UpdateAnimalImage()
        {
            //If the user selects Dog, Cat, or Chicken, update the image to display the new source
            if (animal is Dog)
                AnimalImage.Source = new BitmapImage(new Uri("Images/Dog.jpg", UriKind.Relative));
            else if (animal is Cat)
                AnimalImage.Source = new BitmapImage(new Uri("Images/Cat.jpg", UriKind.Relative));
            else if (animal is Chicken)
                AnimalImage.Source = new BitmapImage(new Uri("Images/Chicken.jpg", UriKind.Relative));
            //If a selection hasn't been made, show the default image
            else
                AnimalImage.Source = new BitmapImage(new Uri("Images/Default.jpg", UriKind.Relative));
        }

        /// <summary>
        /// If a button that calls a class or subclass method is clicked, display the proper content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MethodButton_Click(object sender, RoutedEventArgs e)
        {
            //If an animal hasn't been selected
            if (animal == null)
            {
                //Display error message
                ResultLabel.Content = "Please select an animal first.";
                return;
            }

            //If the EatButton, MoveButton, ReproduceButton, or UniqueButton is pressed, update the content to the strings from class or subclass
            if (sender == EatButton)
                ResultLabel.Content = animal.Eat();
            else if (sender == MoveButton)
                ResultLabel.Content = animal.Move();
            else if (sender == ReproduceButton)
                ResultLabel.Content = animal.Reproduce();
            else if (sender == UniqueButton)
                ResultLabel.Content = animal.Unique();
        }

        /// <summary>
        ///If the SkinType button is pressed, display proper skin type from subclass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinTypeButton_Click(object sender, RoutedEventArgs e)
        {
            //If an animal hasn't been selected
            if (animal == null)
            {
                //Display error message
                ResultLabel.Content = "Please select an animal first.";
                return;
            }

            //If animal has been selected, update content to say the skin type
            ResultLabel.Content = $"Skin Type: {animal.SkinType}";
        }

        /// <summary>
        /// If FoodType button has been clicked, update the content from the proper subclass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoodTypeButton_Click(object sender, RoutedEventArgs e)
        {
            //If an animal hasn't been selected
            if (animal == null)
            {
                //Display error message
                ResultLabel.Content = "Please select an animal first.";
                return;
            }

            //If animal has been selected, update content to proper food type
            ResultLabel.Content = $"Food Type: {animal.FoodType}";
        }
    }
}
