using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQSuccinctly.Capitulo1;

namespace LINQSuccinctly
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Capitulo1();
            Console.ReadKey();

        }

        #region Capitulo 1
        private static void Capitulo1()
        {

            //Capitulo 1
            ExampleScalarReturnAndOutputSequences();
            Console.WriteLine();
            ExampleDeferredExecution();
            Console.WriteLine();
            ExampleLocalAndInterpretedQueries();
            Console.WriteLine();
        }

        private static void ExampleScalarReturnAndOutputSequences()
        {
            Console.WriteLine("Scalar value return and Output sequences");
            ScalarReturnAndOutputSequences.ScalarValueAndOutputSequences();
        }

        private static void ExampleDeferredExecution()
        {
            Console.WriteLine("Deferred Execution");
            Console.WriteLine("Antes de Materializar");
            DeferredExecution.AlteradoAntesDeMaterializarAQuery();
            Console.WriteLine("Depois de Materializar");
            DeferredExecution.AlteradoDepoisDeMaterializarAQuery();
        }

        private static void ExampleLocalAndInterpretedQueries()
        {
            Console.WriteLine("Local and interpreted queries");
            LocalAndIntepretedQueries.LerXML();
        }
        #endregion

    }
}
