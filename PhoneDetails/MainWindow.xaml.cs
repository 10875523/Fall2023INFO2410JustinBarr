using System.IO;
using System.Collections.Generic;
using System.Windows;


namespace PhoneDetails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Phone> phoneDict = new Dictionary<string, Phone>();

        public MainWindow()
        {
            InitializeComponent();

            LoadPhones();
        }

        private void LoadPhones()
        {
            StreamReader inputFile;
            string[] tempPhone;

            try
            {
                inputFile = File.OpenText("phones.txt");
                while (!inputFile.EndOfStream)
                {
                    tempPhone = inputFile.ReadLine().Split(',');
                    CbPhones.Items.Add(tempPhone[1].Trim());
                    phoneDict.Add(tempPhone[1].Trim(), new Phone(tempPhone));
                }
                inputFile.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPhoneDetails_Click(object sender, RoutedEventArgs e)
        {

            PhoneDetailsWindow pdw = new PhoneDetailsWindow();

            if (CbPhones.SelectedIndex > -1)
            {
                if (phoneDict.TryGetValue(CbPhones.SelectedItem.ToString(), out Phone selectedPhone))
                {
                    pdw.UpdateGUI(selectedPhone);
                }

                Show();
            }
            else
            {
                MessageBox.Show("Please select a phone first.");
            }
        }
    }
}
