using ClassLibrary_lab_3;

namespace WebApplication2.Models
{
    public class Presentation_Model
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
                Result = Class1.VolumeCon(height, square_1, square_2);

            }
        }

        public double Square_1
        {
            get { return square_1; }
            set
            {
                square_1 = value;
                Result = Class1.VolumeCon(height, square_1, square_2);
            }
        }

        public double Square_2
        {
            get { return square_2; }
            set
            {
                Result = Class1.VolumeCon(height, square_1, square_2);
            }
        }
        public double Result
        {
            get { return result; }
            set
            {
                result = value;
            }
        }
    }
}
