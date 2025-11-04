class Circle
{
    static void Main(string[] args)
    {
        const double pi = 3.14;
        Console.WriteLine("enter radius = ");
        int r = Convert.ToInt32(Console.ReadLine());
        double areaofcircle = pi * r * r;
        Console.WriteLine("area of circle = "+areaofcircle);
        double permiterofcircle = (2*(pi * r));
        Console.WriteLine("permiter of circle = "+permiterofcircle);


    }
}