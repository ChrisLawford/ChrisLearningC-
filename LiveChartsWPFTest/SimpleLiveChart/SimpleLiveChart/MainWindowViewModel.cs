using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Configurations;
using LiveCharts.Defaults;

namespace SimpleLiveChart
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            valuesA = new ChartValues<ObservablePoint>
            {
                new ObservablePoint(0, 0)
            };
        }

        private double x_value;

        public double X_Value
        {
            get { return x_value; }
            set
            {
                x_value = value;
                OnPropertyChanged("X_Value");
                AddObservablePoint();
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
                AddObservablePoint();
            }
        }
        private ChartValues<ObservablePoint> valuesA;
        public ChartValues<ObservablePoint> ValuesA
        {
            get { return valuesA; }
            set
            {
                valuesA = value;
                OnPropertyChanged("ValuesA");
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
        private void AddObservablePoint()
        {
            ValuesA.Add(new ObservablePoint(X_Value, Y_Value));
        }
        #endregion Methods
    }
}
