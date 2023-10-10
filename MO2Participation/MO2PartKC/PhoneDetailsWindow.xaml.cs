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

namespace MO2PartKC
{
    /// <summary>
    /// Interaction logic for PhoneDetailsWindow.xaml
    /// </summary>
    public partial class PhoneDetailsWindow : Window
    {
        public PhoneDetailsWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the GUI on the phone details window
        /// </summary>
        /// <param name="phone">Creates instance of phone class</param>
        public void UpdateGUI(Phone phone)
        {
            //Set the content equal to the formmatted variables
            LblDisplay.Content = phone.Display.Trim();
            LblMake.Content = phone.Make.Trim();
            LblModel.Content = phone.Model.Trim();
            LblPrice.Content = phone.Price.ToString("c2").Trim();
            LblStorage.Content = phone.Storage.Trim();
        }
        
        /// <summary>
        /// Closes the phone details window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            //Closes the window
            Close();
        }
    }
}
