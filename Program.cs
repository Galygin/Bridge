using System;

namespace Bridge
{
    internal class Program
    {
        private static void Main()
        {
            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction = new RefinedAbstraction(new ConcreteImplementorB());
           abstraction.Operation();
            Console.ReadLine();
        }
    }

    internal interface IAbstraction
    {
         void Operation();
    }

    internal class Abstraction : IAbstraction
    {

        protected Implementor Implementor;

        protected Abstraction(Implementor imp)
        {
            Implementor = imp;
        }

        public virtual void Operation()
        {
            Implementor.OperationImp();
        }
    }

    internal interface Implementor
    {
        void OperationImp();
    }

    internal class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor imp) : base(imp)
        {
        }

        /*public override void Operation()
        {
            base.Operation();
        }*/
    }

    internal class ConcreteImplementorA : Implementor
    {
        public  void OperationImp()
        {
            Console.WriteLine("ImplementorA");
        }
    }

    internal class ConcreteImplementorB : Implementor
    {
        public void OperationImp()
        {
            Console.WriteLine("ImplementorB");
        }
    }
}