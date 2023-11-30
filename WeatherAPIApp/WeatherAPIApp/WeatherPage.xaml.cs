// Namespace for the WeatherAPIApp.
namespace WeatherAPIApp
{
    // Partial class representing the WeatherPage, presumably a page to display weather information.
    public partial class WeatherPage : ContentPage
    {
        // Constructor for WeatherPage, called when the page is created.
        public WeatherPage()
        {
            // Initialize the components of the page.
            InitializeComponent();

            // Set the text of the city label to the city stored in WeatherGV.
            LblCity.Text = WeatherGV.City;

            // Set the text of the current temperature label to the current temperature stored in WeatherGV.
            LblCurTemp.Text = $"Current Temp: {WeatherGV.CurTemp.ToString("N2")}";

            // Set the text of the high temperature label to the high temperature stored in WeatherGV.
            LblHighTemp.Text = $"High Temp: {WeatherGV.HighTemp.ToString("N2")}";

            // Set the text of the low temperature label to the low temperature stored in WeatherGV.
            LblLowTemp.Text = $"Low Temp: {WeatherGV.LowTemp.ToString("N2")}";
        }
    }
}
