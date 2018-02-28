using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;

namespace SimpleLiveChart
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            
            collection = new SeriesCollection {
                new LineSeries
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                },
                new LineSeries
                {
                    Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                }}; 
        }
        private ChartValues<double> Values;

        private double x_value;

        public double X_Value
        {
            get { return x_value; }
            set
            {
                x_value = value;
                OnPropertyChanged("X_Value");
            }
        }

        private double y_value;

        public double Y_Value
        {
            get { return y_value; }
            set
            {
                y_value = value;
                OnPropertyChanged("Y_Value");
            }
        }

        private SeriesCollection collection;

        public SeriesCollection Collection
        {
            get { return collection; }
            set
            {
                collection = value;
                OnPropertyChanged("Collection");
            }
        }

        #region Methods
        public void OnX_ValueIncreased()
        {
            X_Value = X_Value + 1;
        }

        public void OnX_ValueDecreased()
        {
            X_Value = X_Value - 1;
        }
        public void OnY_ValueIncreased()
        {
            Y_Value = Y_Value + 1;
        }
        public void OnY_ValueDecreased()
        {
            Y_Value = Y_Value - 1;
        }

        #endregion Methods
    }
}
