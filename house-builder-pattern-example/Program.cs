using house_builder_pattern_example.builder;
using house_builder_pattern_example.director;
using house_builder_pattern_example.structure;

internal class Program
{
    private static void Main(string[] args)
    {
        IBuilder houseBuilder = new HouseBuilder();
        IDirector houseDirector = new HouseDirector();
        Structure house = houseDirector.Instruct(houseBuilder);
        house.ShowStructure();
    }
}