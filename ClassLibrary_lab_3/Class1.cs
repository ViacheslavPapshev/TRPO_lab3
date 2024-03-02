namespace ClassLibrary_lab_3
{
    public class Class1
    {
        static public double VolumeCon(double s1, double s2, double h)
        {
            return 1.0 / 3 * (s1 + s2 + Math.Pow(s1 * s2, 0.5));
        }
    }
}
