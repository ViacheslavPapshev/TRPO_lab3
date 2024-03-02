using ClassLibrary_lab_3;
double s1, s2, h;

Console.WriteLine("Введите s1, s2, h усеченного конуса");
s1 = Convert.ToDouble(Console.ReadLine());
s2 = Convert.ToDouble(Console.ReadLine());
h = Convert.ToDouble(Console.ReadLine());

Console.Write("Объем усеченного конуса =  ");
Console.Write(Class1.VolumeCon(s1, s2, h));