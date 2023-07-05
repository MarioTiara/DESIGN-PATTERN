
using System.Runtime.CompilerServices;
namespace  BuilderPattern;
internal class Program
{
    private static void Main(string[] args)
    {
        var director = new Director ();
        var builder = new ConcreteBuilder();
        director.Builder=builder;


        Console.WriteLine("Standard basic product:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Standard full feature products:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());
    }
}