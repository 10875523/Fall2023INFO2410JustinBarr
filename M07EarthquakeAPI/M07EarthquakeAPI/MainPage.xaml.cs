using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Microsoft.Maui.Controls;

namespace M07EarthquakeAPI
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Initializes Main page
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Find" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BTNFind_Clicked(object sender, EventArgs e)
        {
            // Get the selected start and end dates and earthquake size from the user inputs
            DateTime startDate = StartDatePicker.Date;
            DateTime endDate = EndDatePicker.Date;
            double earthquakeSize;

            // Validate that the magnitude is between 1 and 10
            if (Convert.ToDouble(TXTMagnitudeEntry.Text) > 10 || Convert.ToDouble(TXTMagnitudeEntry.Text) < 0)
            {
                // Display an alert for invalid magnitude input
                await DisplayAlert("Magnitude Error", "Please input a number between 1 and 10 for the magnitude.", "Close");
                return;
            }

            // Convert the magnitude input to a double
            earthquakeSize = Convert.ToDouble(TXTMagnitudeEntry.Text);

            try
            {
                // Display a loading message while waiting for API response
                LblResults.Text = "Loading Results...";

                // Using HttpClient to make an HTTP request.
                using (HttpClient client = new HttpClient())
                {
                    // Constructing the Earthquake API URL with the provided parameters.
                    string url = $"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime={startDate}&endtime={endDate}&minmagnitude={earthquakeSize}";

                    // Sending an asynchronous GET request and awaiting the response.
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Check if the response indicates success (HTTP status code 2xx).
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string.
                        string content = await response.Content.ReadAsStringAsync();

                        // Parse the content into JSON C# objects.
                        JObject jo = JObject.Parse(content);

                        // Extracting earthquake information from the JSON response.
                        JArray eQjArray = JArray.Parse(jo["features"].ToString());

                        // Get the number of earthquakes
                        int count = 0;
                        int.TryParse(jo["metadata"]["count"].ToString(), out count);

                        if (count == 0)
                        {
                            // Handle the case where no earthquakes were found
                            await DisplayAlert("Results Error", "There were no earthquakes found within the given dates at the given magnitude", "Close");
                            return;
                        }

                        // Creates a list of earthquakes and gets values from the API
                        List<Earthquake> eqList = new List<Earthquake>();
                        int idx = 1;
                        foreach (var eq in eQjArray)
                        {
                            JObject eqJObj = JObject.Parse(eq["properties"].ToString());
                            Earthquake earthquake = new Earthquake
                            {
                                EQid = idx,
                                EQSize = eqJObj["mag"].ToString(),
                                EQLocation = eqJObj["place"].ToString()
                            };
                            eqList.Add(earthquake);

                        }
                        // Selects a random Earthquake with information from list and displays it.
                        Random random = new Random();
                        int randeq = random.Next(1, eqList.Count + 1);
                        Earthquake displayEQ = eqList[randeq];
                        LblResults.Text = $"There were {count} earthquakes during this time.\n\n" +
                           $"Details of one of them:\nPlace: {displayEQ.EQLocation}, \nMagnitude: {displayEQ.EQSize}.";
                    }
                    else
                    {
                        // Clear previous results and display an alert in case of an API error.
                        LblResults.Text = "";
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
