using System;

namespace Opp1
{
    class processname : processordercal
    {
        public override void checkdata()
        {
            Console.WriteLine("I am in Subclass");
        }
    }
    class newclass : ITestinter
    {
        public void getname()
        {
            Console.WriteLine("I am supriyo");
        }
        public int calc(int a)
        {
            return a * 45;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git");
            processname newprocess = new processname();
            newprocess.checkdata();
            newclass obj3 = new newclass();
            var values = obj3.calc(10);
            obj3.getname();

        }
    }
}
