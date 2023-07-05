namespace  AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new client().Main();
        }
    }

    class client 
    {
        public void Main()
        {
            Console.WriteLine("Client: Testing client code the the firct factory type..");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the socond factory type ...");
            ClientMethod( new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory){
            var productA= factory.CreateProductA();
            var productB= factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
