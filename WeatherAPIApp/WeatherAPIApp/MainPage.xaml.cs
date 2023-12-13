using Newtonsoft.Json.Linq;

namespace WeatherAPIApp
{
    // The MainPage class represents the main page of the Xamarin.Forms app.
    public partial class MainPage : ContentPage
    {
        // A counter variable, initialized to 0.
        int count = 0;

        /// <summary>
        /// Constructor for MainPage, called when the page is created.
        /// </summary>
        public MainPage()
        {
            // Initialize the components of the page.
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnShowTemp_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Using HttpClient to make an HTTP request.
                using (HttpClient client = new HttpClient())
                {
                    // Constructing the OpenWeatherMap API URL with the provided zip code.
                    string url = $"http://api.openweathermap.org/data/2.5/weather?zip={TxtBoxZipCode.Text}&appid=adfb04e9ff8ea36a39d5b6e096283362&units=imperial";

                    // Sending an asynchronous GET request and awaiting the response.
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Check if the response indicates success (HTTP status code 2xx).
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string.
                        string content = await response.Content.ReadAsStringAsync();

                        // Parse the content into JSON C# objects.
                        JObject jo = JObject.Parse(content);

                        // Extracting temperature, air pressure, and humidity information from the JSON response.
                        JObject main = JObject.Parse(jo["main"].ToString());
                        WeatherGV.CurTemp = double.Parse(main["temp"].ToString());
                        WeatherGV.HighTemp = double.Parse(main["temp_max"].ToString());
                        WeatherGV.LowTemp = double.Parse(main["temp_min"].ToString());
                        WeatherGV.AirPressure = double.Parse(main["pressure"].ToString());
                        WeatherGV.Humidity = double.Parse(main["humidity"].ToString());

                        // Extracting wind information from the JSON response.
                        JObject wind = JObject.Parse(jo["wind"].ToString());
                        WeatherGV.WindSpeed = double.Parse(wind["speed"].ToString());
                        WeatherGV.Direction = double.Parse(wind["deg"].ToString());

                        // Extracting time information from the JSON response.
                        JObject sys = JObject.Parse(jo["sys"].ToString());
                        WeatherGV.Sunrise = int.Parse(sys["sunrise"].ToString());
                        WeatherGV.Sunset = int.Parse(sys["sunset"].ToString());

                        // Extracting city information from the JSON response.
                        WeatherGV.City = jo["name"].ToString();

                        // Navigate to a new page (WeatherPage) to display the weather information.
                        await Navigation.PushAsync(new WeatherPage());
                    }
                    else
                    {
                        // Display an alert in case of an API error.
                        await DisplayAlert("API Error", $"Unable to receive response from the API.\n Respose Error: {response.StatusCode}", "Close");
                    }
                }
            }
            // Catching exceptions and displaying an alert with the error message.
            catch (Exception ex)
            {
                await DisplayAlert("API Error", ex.Message, "Close");
            }
        }
    }
}
