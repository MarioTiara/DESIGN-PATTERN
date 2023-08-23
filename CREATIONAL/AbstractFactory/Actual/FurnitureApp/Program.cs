using FurnitureApp;

Console.WriteLine("Client: Testing cliebt Code with the first factory type..");
ClientMethod(new ArtDecoFurniture());
ClientMethod(new ModernFuniture());




void ClientMethod(IFurnitureFactory furnitureFactory)
{
    var chair= furnitureFactory.CreateChair();
    var table = furnitureFactory.CreateTable();

    Console.WriteLine($"Chair-> Sit On {chair.SitOn()} it has leg:{chair.HasLegs()}");
    Console.WriteLine($"Table-> shape: {table.Shape()} it has leg:{table.HasLegs()}");
}
