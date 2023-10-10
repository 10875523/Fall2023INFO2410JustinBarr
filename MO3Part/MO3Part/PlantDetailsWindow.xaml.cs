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

namespace MO3Part
{
    /// <summary>
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window
    {
        //Readable and writable instance of plant
        public Plant NewPlant { get; set; }


        /// <summary>
        /// Initializes Plant Details Window
        /// </summary>
        public PlantDetailsWindow()
        {
            //Initializes Details window
            InitializeComponent();
        }

        /// <summary>
        /// Closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            //Closes the window
            Close();
        }

        /// <summary>
        /// Updates the labels for the details window
        /// </summary>
        public void UpdateGUI()
        {
            //Sets the environment, name, and type labels
            LblPlantEnv.Content = NewPlant.Environment;
            LblPlantName.Content = NewPlant.Name;
            LblPlantType.Content = NewPlant.Type;
        }

        /// <summary>
        /// Retrieves the sniff function from the different plant classes and displays it in a window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSniff_Click(object sender, RoutedEventArgs e)
        {
            //Shows the text from the sniff function based on its class
            MessageBox.Show(NewPlant.Sniff());
        }
    }
}
