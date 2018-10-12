using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace OpenAQ
{
    public class LegendViewEventArgs : EventArgs
    {
        public string Text { get; set; }
        public bool Visible { get; set; }
    }
    /// <summary>
    /// Interaction logic for CustomersLegend.xaml
    /// </summary>
    public partial class CustomersLegend : UserControl, IChartLegend
    {
        private List<SeriesViewModel> _series;

        public CustomersLegend()
        {
            InitializeComponent();

            DataContext = this;
            
        }

        public List<SeriesViewModel> Series
        {
            get { return _series; }
            set
            {
                _series = value;
                OnPropertyChanged("Series");
            }
        }
        public event EventHandler<LegendViewEventArgs> LegendClickText;
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
