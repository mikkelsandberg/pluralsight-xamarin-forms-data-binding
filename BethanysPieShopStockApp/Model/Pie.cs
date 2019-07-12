using System.ComponentModel;

namespace BethanysPieShopStockApp.Model
{
    public class Pie : INotifyPropertyChanged
    {
        private int _id;
        private string _pieName;
        private double _piePrice;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string PieName
        {
            get => _pieName;
            set
            {
                _pieName = value;
                RaisePropertyChanged(nameof(PieName));
            }
        }

        public double PiePrice
        {
            get => _piePrice;
            set
            {
                _piePrice = value;
                RaisePropertyChanged(nameof(PiePrice));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
