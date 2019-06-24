using System;
using System.Threading;

namespace DelegatesExample
{
    class Program
    {
        private delegate void CallMethod();

        private static void Func1()
        {
            Thread.Sleep(1000);
        }

        private static void Func2()
        {
            Thread.Sleep(2000);
        }

        private static void Func3()
        {
            Thread.Sleep(3000);
        }

        private static double MeasureExecutionTime(CallMethod methodToExecute)
        {
            var executionStart = DateTime.Now;
            methodToExecute();
            var executionEnd = DateTime.Now;
            return (executionEnd - executionStart).TotalMilliseconds;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Tiempo de ejecucion de Func1: {MeasureExecutionTime(Func1)} ms");
            Console.WriteLine($"Tiempo de ejecucion de Func2: {MeasureExecutionTime(Func2)} ms");
            Console.WriteLine($"Tiempo de ejecucion de Func3: {MeasureExecutionTime(Func3)} ms");
            Console.ReadLine();
        }
    }
}
