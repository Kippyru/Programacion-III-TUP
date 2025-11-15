using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace FormTiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class WeatherForecast
        {
            public string date { get; set; }
            public int temperatureC { get; set; }
            public string summary { get; set; }
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            actualizarBtn_Click(sender, e, new HttpClient());
        }

        private async void actualizarBtn_Click(object sender, EventArgs e, HttpClient client)
        {
            try
            {
                
                string url = "https://localhost:7015/WeatherForecast";

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                
                var weatherList = JsonSerializer.Deserialize<List<WeatherForecast>>(json);

                if (weatherList != null && weatherList.Count > 0)
                {
                    var firstWeather = weatherList[0];

                    dateTxt.Text = firstWeather.date;
                    tempTxt.Text = firstWeather.temperatureC.ToString();
                    summaryTxt.Text = firstWeather.summary;
                }
                else
                {
                    MessageBox.Show("No se recibieron datos del clima.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
            }
        }

        private void dateTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tempTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void summaryTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
