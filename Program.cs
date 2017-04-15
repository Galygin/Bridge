using System;

namespace Bridge
{
    internal class Program
    {
        private static void Main()
        {
            Abstraction abstraction = new Abstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction = new Abstraction(new ConcreteImplementorB());
            abstraction.Operation();
            Console.ReadLine();
        }


        internal interface IAbstraction
        {
            void Operation();
        }

        internal class Abstraction : IAbstraction
        {

            protected IMplementor Implementor;

            public Abstraction(IMplementor imp)
            {
                Implementor = imp;
            }

            public void Operation()
            {
                Implementor.OperationImp();
            }
        }

        internal interface IMplementor
        {
            void OperationImp();
        }


        internal class ConcreteImplementorA : IMplementor
        {
            public void OperationImp()
            {
                Console.WriteLine("ImplementorA");
            }
        }

        internal class ConcreteImplementorB : IMplementor
        {
            public void OperationImp()
            {
                Console.WriteLine("ImplementorB");
            }
        }
    }
}