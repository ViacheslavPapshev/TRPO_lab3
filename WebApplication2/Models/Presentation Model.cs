using ClassLibrary_lab_3;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WebApplication2.Models
{
    public class Presentation_Model
    {
        public double Height { get; set; }
        public double Square_1 { get; set; }
        public double Square_2 { get; set; }

        public double Result { get; set; }

        public Presentation_Model (double height, double square_1, double square_2, double result)
        {
            Height = height;
            Square_1 = square_1;
            Square_2 = square_2;
            Result = result;
        }
    }
}
