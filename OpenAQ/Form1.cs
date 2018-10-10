using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Json;
using System.Windows.Shapes;

namespace OpenAQ
{
    public partial class Form1 : Form
    {
        class CityAPI
        {
            private static string url = "https://api.openaq.org/v1/cities";
            private static readonly HttpClient client = new HttpClient();
            public async static Task<IEnumerable<City>> Get()
            {
                List<City> city = new List<City>();
                var response = await client.GetAsync(url);
                var responseString = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseString);
                var token=json["results"];
                foreach(var item in token.Children())
                {
                    city.Add(JsonConvert.DeserializeObject<City>(item.ToString()));
                }
                return city;
            }
        }
        public Form1()
        {
            InitializeComponent();
            Rectangle     
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCity_Click(object sender, EventArgs e)
        {
            line.Top = (sender as Bunifu.Framework.UI.BunifuFlatButton).Top;
        }

        private void buttonCountry_Click(object sender, EventArgs e)
        {
            line.Top = (sender as Bunifu.Framework.UI.BunifuFlatButton).Top;
        }

        private void buttonPollution_Click(object sender, EventArgs e)
        {
            line.Top = (sender as Bunifu.Framework.UI.BunifuFlatButton).Top;
        }

        private void buttonForecast_Click(object sender, EventArgs e)
        {
            line.Top = (sender as Bunifu.Framework.UI.BunifuFlatButton).Top;
        }
    }
}
