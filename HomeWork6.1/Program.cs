internal class Program
{
    private static void Main()
    {
        var venus = new
        {
            Name = "Венера",
            IdFromSun = 2,
            EquatorLength = 38025,
        };
        var earth = new
        {
            Name = "Земля",
            IdFromSun = 3,
            EquatorLength = 40075,
            PreviousPlanet = venus
        };
        var mars = new
        {
            Name = "Марс",
            IdFromSun = 4,
            EquatorLength = 21344,
            PreviousPlanet = earth
        };
        var venus2 = new
        {
            Name = "Венера",
            IdFromSun = 2,
            EquatorLength = 38025,
            PreviousPlanet = mars
        };
        PrintPlanet(venus,earth,mars,venus2);
    }

    private static void PrintPlanet(params object[] obj)
    {
        foreach (object item in obj)
        {
            Console.WriteLine(item);
        }
    }
}