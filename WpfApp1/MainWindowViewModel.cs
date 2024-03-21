using ClassLibrary_lab_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            }
            
        }

        private double result;

        private double square_1;

        private double square_2;

        private double height;

        public double Height { get { return height; } set { height = value; Result = Class1.VolumeCon(height, square_1, square_2); OnPropertyChanged(nameof(Height)); } }

        public double Square_1 { get { return square_1; } set { square_1 = value; Result = Class1.VolumeCon(height, square_1, square_2); OnPropertyChanged(nameof(Square_1)); } }

        public double Square_2 { get { return square_2; } set { square_2 = value; Result = Class1.VolumeCon(height, square_1, square_2); OnPropertyChanged(nameof(Square_2)); } }
        public double Result { get { return result;} set { result = value; OnPropertyChanged(nameof(Result)); } }

        //public MainWindowViewModel(double height, double square_1, double square_2)
        //{
        //    this.Height = height;
        //    this.Square_1 = square_1;
        //    this.Square_2 = square_2;
        //    this.Result = Class1.VolumeCon(this.Height, this.Square_1, this.Square_2);
        //}

    }
}
