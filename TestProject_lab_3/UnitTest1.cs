using ClassLibrary_lab_3;
namespace TestProject_lab_3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double s1 = 2.5;
            double s2 = 3.5;
            double h = 17;
            

            var res = Class1.VolumeCon(s1, s2, h);

            double est = 2.9;
            Assert.AreEqual(est, res, 0.1);
        }
        [Test]
        public void Test2()
        {
            double s1 = -2.5;
            double s2 = 3.5;
            double h = 17;
            Exception ex = Assert.Throws<Exception>(
            () => Class1.VolumeCon(s1, s2, h));



        }
    }
}