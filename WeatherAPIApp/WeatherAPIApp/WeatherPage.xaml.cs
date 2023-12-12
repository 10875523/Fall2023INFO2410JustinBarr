// Namespace for the WeatherAPIApp.
namespace WeatherAPIApp
{

    // Partial class representing the WeatherPage, presumably a page to display weather information.
    public partial class WeatherPage : ContentPage
    {
        double dir = WeatherGV.Direction;
        string direction;
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

            LblWindSpeed.Text = $"Wind Speed: {WeatherGV.WindSpeed.ToString("N2")}";

            LblWindDirection.Text = $"Wind Direction: {GetWindDirection()}";

        }


        public string GetWindDirection()
        {
            if ((dir > 345 && dir <= 360) || (dir > 0 && dir <= 15))
            {
                direction = "N";
            }
            else if (dir > 15 && dir <= 35)
            {
                direction = "N/NE";
            }
            else if (dir > 35 && dir <= 55)
            {
                direction = "NE";
            }
            else if (dir > 55 && dir <= 75)
            {
                direction = "E/NE";
            }
            else if (dir > 75 && dir <= 105)
            {
                direction = "E";
            }
            else if (dir > 105 && dir <= 125)
            {
                direction = "E/SE";
            }
            else if (dir > 125 && dir <= 145)
            {
                direction = "SE";
            }
            else if (dir > 145 && dir <= 165)
            {
                direction = "S/SE";
            }
            else if (dir > 165 && dir <= 195)
            {
                direction = "S";
            }
            else if (dir > 195 && dir <= 215)
            {
                direction = "S/SW";
            }
            else if (dir > 215 && dir <= 235)
            {
                direction = "SW";
            }
            else if (dir > 235 && dir <= 255)
            {
                direction = "W/SW";
            }
            else if (dir > 255 && dir <= 285)
            {
                direction = "W";
            }
            else if (dir > 285 && dir <= 305)
            {
                direction = "W/NW";
            }
            else if (dir > 305 && dir <= 325)
            {
                direction = "NW";
            }
            else if (dir > 325 && dir <= 345)
            {
                direction = "N/NW";
            }
            else
            {
                direction = "No Wind";
            }

            return direction;
        }
    }


}
