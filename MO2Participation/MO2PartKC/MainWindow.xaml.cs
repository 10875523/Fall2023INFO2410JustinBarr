using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace MO2PartKC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create dictionary for phones
        Dictionary<string, Phone> allPhones = new Dictionary<string, Phone>();
        public MainWindow()
        {
            InitializeComponent();
            LoadPhones();
        }

        /// <summary>
        /// Puts phones from txt file into dictionary for phones
        /// </summary>
        private void LoadPhones()
        {
            //Creates instance of streamreader
            StreamReader inputFile;
            //Creates a string array for variable use
            string[] tempPhone;

            //Attempt enclosed code
            try
            {
                //Open the txt file
                inputFile = File.OpenText("phones.txt");
                //Continue enclosed code until there is no more in txt file
                while (!inputFile.EndOfStream)
                {
                    //Set string array equal to each line in txt file splitting at the comma
                    tempPhone = inputFile.ReadLine().Split(',');
                    //Add details to the dictionary
                    allPhones.Add(tempPhone[1], new Phone(tempPhone));
                    //Add Information to combobox
                    CbPhones.Items.Add(tempPhone[1]);
                }
                //Closes txt file
                inputFile.Close();
            }
            //Catch exception rather than crash
            catch (Exception ex)
            {
                //Show the error
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens phone details window when button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDetails_Click(object sender, RoutedEventArgs e)
        {
            //Create instance of Phone details window
            PhoneDetailsWindow pdw = new PhoneDetailsWindow();

            //Test to see if a phone has been selected
            if (CbPhones.SelectedIndex > -1)
            {
                //Set the selection to key variable
                string key = CbPhones.SelectedItem.ToString();
                //Test to see if selected phone is in dictionary
                if (allPhones.TryGetValue(key, out Phone SelectedPhone))
                {
                    //Update and display GUI for selected phone
                    pdw.UpdateGUI(SelectedPhone);
                    pdw.Show();
                }
                else
                {
                    //If selected phone isn't in dictionary, state so
                    MessageBox.Show($"Could not find {key} in the dictionary");
                }
            }
            else
            {
                //If user didn't select a phone, state so.
                MessageBox.Show("Please select a phone first.");
            }
        }
    }
}
