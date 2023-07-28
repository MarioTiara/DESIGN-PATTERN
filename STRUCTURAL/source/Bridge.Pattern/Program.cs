
using Bridge.Pattern;

Client client= new ();

Abstraction abstraction;

abstraction = new Abstraction(new ConcreteImplementationA());
client.ClientCode(abstraction);


Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
client.ClientCode(abstraction);
