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
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using LiveCharts;

namespace OpenAQ
{
    public partial class Form1 : Form
    {
        public class ComparerDate : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                if (Convert.ToDateTime(x) == Convert.ToDateTime(y))
                    return 0;
                if (Convert.ToDateTime(x) < Convert.ToDateTime(y))
                    return -1;
                return 1;
            }
        }
        public void Init(List<Pollution> pollutions)
        {
            //pollutions = new List<Pollution>()
            //{
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.017},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.011},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.014},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.015},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.016},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("07.11.2016"),Value=0.046},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("20.07.2017"),Value=0.05},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.013},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.017},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.018}

            //};
            cartesianChart1.Series.Clear();
            //pollutions = _pollutionContext.Pollutions.Where(p => p.City == "Tucson" && p.Location == "22nd Street & Craycr" && p.Parameter == "o3").ToList();
            var map = Mappers.Xy<DataModel>().X(p => p.Number).Y(p => p.Value);
            var dates = pollutions.Select(p => p.LastUpdate.ToString("dd.MM.yyyy HH:mm:ss")).ToList();
            dates = dates.Distinct().ToList();
            dates.Sort(new ComparerDate());
            foreach (var item in pollutions)
            {
                if (!cartesianChart1.Series.Any(p => p.Title == item.Location))
                {
                    Series series;
                    if (pollutions.FindAll(p => p.Location == item.Location).Count > 1)
                    {
                        series = new LineSeries(map);
                    }
                    else
                    {
                        series = new LineSeries(map) { PointGeometrySize=19};
                    }
                    series.Title = item.Location;
                    series.Values = new ChartValues<DataModel>()
                    {
                        new DataModel
                        {
                            Value = item.Value,
                            Number = dates.FindIndex(p => p == item.LastUpdate.ToString("dd.MM.yyyy HH:mm:ss"))
                        }
                    };


                    cartesianChart1.Series.Add(series);
                    var checkBox = new CheckBox();
                    checkBox.Text = series.Title;
                    checkBox.Checked = true;
                    checkBox.Dock = DockStyle.Left;
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                    panel2.Controls.Add(checkBox);
                }
                else
                {
                    cartesianChart1.Series.FirstOrDefault(p => p.Title == item.Location).Values.Add(

                         new DataModel { Value = item.Value, Number = dates.FindIndex(p => p == item.LastUpdate.ToString("dd.MM.yyyy HH:mm:ss")) });
                }
            }
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis { Labels = dates });
            cartesianChart1.LegendLocation = LegendLocation.Right;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (sender as CheckBox);
            if (!checkBox.Checked)
            {
                (cartesianChart1.Series.Where(p => p.Title == checkBox.Text).FirstOrDefault() as LineSeries).Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                (cartesianChart1.Series.Where(p => p.Title == checkBox.Text).FirstOrDefault() as LineSeries).Visibility = System.Windows.Visibility.Visible;
            }
        }

        public Form1()
        {
            InitializeComponent();
            cartesianChart1.ChartLegend = new CustomersLegend();
        }

        private void chart1_LegendClickText(object sender, LegendViewEventArgs e)
        {
           
        }

        private DataBase.DatabaseContext _pollutionContext;

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

        private async void Form1_Load(object sender, EventArgs e)
        {
            _pollutionContext = new DataBase.DatabaseContext();
            Observer.ObserverPollution observerPollution = new Observer.ObserverPollution();
            observerPollution.Start();
            comboBoxCity.Items.AddRange(_pollutionContext.Pollutions.Select(x => x.City).Distinct().ToArray());
            comboBoxPollution.Items.AddRange(_pollutionContext.Pollutions.Select(x=>x.Parameter).Distinct().ToArray());
            cartesianChart1.ChartLegend.MouseDoubleClick += ChartLegend_MouseDoubleClick;
        }


        private void FindPollution()
        {
            if (comboBoxCity.SelectedIndex < 0 || comboBoxPollution.SelectedIndex < 0 || comboBoxPeriod.SelectedIndex < 0) return;
            DateTime date = DateTime.Now;
            switch (comboBoxPeriod.SelectedIndex)
            {
                case 0:
                    date = DateTime.Now.AddDays(-1);
                    break;
                case 1:
                    date = DateTime.Now.AddDays(-7);
                    break;
                case 2:
                    date = DateTime.Now.AddDays(-30);
                    break;
                default:
                    break;
            }
            Init(_pollutionContext.Pollutions.
                Where(x => x.City == comboBoxCity.SelectedItem.ToString() &&
                x.Parameter == comboBoxPollution.SelectedItem.ToString()&&
                x.LastUpdate>=date).ToList());
            cartesianChart1.AxisY.FirstOrDefault().LabelFormatter = p => p + " " + p.ToString(_pollutionContext.Pollutions.Where(x => x.Parameter == comboBoxPollution.SelectedItem.ToString()).FirstOrDefault().Unit);
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindPollution();
            
        }

        private void ChartLegend_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("123");
        }
    }
}
