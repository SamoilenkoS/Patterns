using System;

namespace Facade
{
    public class Facade
    {
        private readonly SubsystemA sybsystemA = new SubsystemA();
        private readonly SubsystemB sybsystemB = new SubsystemB();
        private readonly SubsystemC sybsystemC = new SubsystemC();

        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" +
                              sybsystemA.A1() +
                              sybsystemA.A2() +
                              sybsystemB.B1());
        }
        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" +
                              sybsystemB.B1() +
                              sybsystemC.C1());
        }
    }
}