using System;
using System.Threading;

namespace DelegatesExampleWithLambdas
{
    class Program
    {
        private delegate void CallMethod();
        private delegate double Calculate(double d1, double d2);

        private static double MeasureExecutionTime(CallMethod methodToExecute)
        {
            var executionStart = DateTime.Now;
            methodToExecute();
            var executionEnd = DateTime.Now;
            return (executionEnd - executionStart).TotalMilliseconds;
        }

        static void Main(string[] args)
        {
            /*int timeToWait = 2000;
            Console.WriteLine($"Execution Time: {MeasureExecutionTime(() => Thread.Sleep(timeToWait))} ms.");
            Console.ReadLine();*/

            Console.WriteLine($"Tiempo de ejecucion de Func1: " +
                MeasureExecutionTime(() =>
                {
                    if(DateTime.Now.Hour > 12)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Thread.Sleep(2000);
                    }
                }) + "ms");
                           
            Console.WriteLine($"Tiempo de ejecucion de Func2: {MeasureExecutionTime(() => Thread.Sleep(2000))} ms");
            Console.WriteLine($"Tiempo de ejecucion de Func3: {MeasureExecutionTime(() => Thread.Sleep(3000))} ms");
            Calculate c = (double d1, double d2) =>
            {
                return d1 * d2;
            };
            var result = c(25, 35);
            Console.ReadLine();
        }
    }
}
