using ClassLibrary_lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainWindowViewModel
    {
        public double result;
        public double Height { get; set; }
        public double Square_1 { get; set; }

        public double Square_2 { get; set; }

        public double Result { get { return Class1.VolumeCon(this.Height, this.Square_1, this.Square_2); } set { result = value; } }

        //public MainWindowViewModel(double height, double square_1, double square_2)
        //{
        //    this.Height = height;
        //    this.Square_1 = square_1;
        //    this.Square_2 = square_2;
        //    this.Result = Class1.VolumeCon(this.Height, this.Square_1, this.Square_2);
        //}

    }
}
