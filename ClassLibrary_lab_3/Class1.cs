namespace ClassLibrary_lab_3
{
    public class Class1
    {
        static public double VolumeCon(double s1, double s2, double h)
        {
            if((s1<0) || (s2<0) || (h < 0)){
                throw new Exception();
            }
            return 1.0 / 3 * (s1 + s2 + Math.Pow(s1 * s2, 0.5));
        }
    }
}
