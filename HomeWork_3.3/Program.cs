using System;

// Product: House
class House
{
    public string Foundation { get; set; }
    public string Walls { get; set; }
    public string Roof { get; set; }

    public void Display()
    {
        Console.WriteLine($"Foundation: {Foundation}");
        Console.WriteLine($"Walls: {Walls}");
        Console.WriteLine($"Roof: {Roof}");
    }
}

// Builder interface
interface IHouseBuilder
{
    void BuildFoundation();
    void BuildWalls();
    void BuildRoof();
    House GetHouse();
}

// ConcreteBuilder: CottageBuilder
class CottageBuilder : IHouseBuilder
{
    private House house = new House();

    public void BuildFoundation()
    {
        house.Foundation = "Cottage Foundation";
    }

    public void BuildWalls()
    {
        house.Walls = "Cottage Walls";
    }

    public void BuildRoof()
    {
        house.Roof = "Cottage Roof";
    }

    public House GetHouse()
    {
        return house;
    }
}

// Director: HouseDirector
class HouseDirector
{
    public void Construct(IHouseBuilder builder)
    {
        builder.BuildFoundation();
        builder.BuildWalls();
        builder.BuildRoof();
    }
}

class Program
{
    static void Main()
    {
        // Client using HouseDirector and CottageBuilder
        IHouseBuilder builder = new CottageBuilder();
        HouseDirector director = new HouseDirector();

        director.Construct(builder);

        House house = builder.GetHouse();
        house.Display();

        Console.ReadLine();
    }
}