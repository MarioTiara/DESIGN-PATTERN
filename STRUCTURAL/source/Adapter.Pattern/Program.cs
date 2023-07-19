using Adapter.Pattern;

MallardDuck duck = new();
WildTurkey turkey = new();
Duck turkeyAdapter= new TurkeyAdapter(turkey);

Console.WriteLine("The Turkey says .. ");
turkey.gobble();
turkey.fly();

Console.WriteLine("\n The Duck says..");
testDuck(duck);

Console.WriteLine("\nThe TurkeyAdapter says..");
testDuck(turkeyAdapter);

static void testDuck(Duck duck){
    duck.quack();
    duck.fly();
}
