using ClassLibrary_lab_3;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WebApplication2.Models
{
    public class Presentation_Model : INotifyPropertyChanged
    {
        private double result;

        private double square_1;

        private double square_2;

        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged(nameof(Height));
                Result = Class1.VolumeCon(height, square_1, square_2);
                OnPropertyChanged(nameof(Result));

            }
        }

        public double Square_1
        {
            get { return square_1; }
            set
            {
                square_1 = value;
                OnPropertyChanged(nameof(Square_1));
                Result = Class1.VolumeCon(height, square_1, square_2);
                OnPropertyChanged(nameof(Result));
            }
        }

        public double Square_2
        {
            get { return square_2; }
            set
            {
                square_2 = value;
                OnPropertyChanged(nameof(Square_2));
                Result = Class1.VolumeCon(height, square_1, square_2);
                OnPropertyChanged(nameof(Result));
            }
        }
        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            }


        }
    }
}
