using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAsbtractProductB CreateProductB();
    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAsbtractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

      public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAsbtractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }

    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The Result of the product A1.";
        }
    }
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
    public interface IAsbtractProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }

    public class ConcreteProductB1 : IAsbtractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result=collaborator.UsefulFunctionA();
            return $"The result of B1 collaborating with ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B1";
        }
    }

    public class ConcreteProductB2 : IAsbtractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result= collaborator.UsefulFunctionA();
            return $"The result of the B2 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
             return "The result of the product B2";
        }
    }
}