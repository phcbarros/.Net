using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSuccinctly.Capitulo1
{
    public static class DeferredExecution
    {
        public static void AlteradoAntesDeMaterializarAQuery()
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };

            //Contructor the query
            IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2);

            // At this point the query has been created but not executed

            // Chante the first element of the input sequence
            fibonacci[0] = 99;

            //Cause the query to be executed (enumerated)
            foreach (var number in numbersGreaterThanTwoQuery)
            {
                Console.WriteLine(number);
            }

        }

        public static void AlteradoDepoisDeMaterializarAQuery()
        {

            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
            // Construct the query
            IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2)
             .ToArray();
            // At this point the query has been executed because of the .ToArray()
            // Change the first element of the input sequence
            fibonacci[0] = 99;
            // Enumerate the results
            foreach (var number in numbersGreaterThanTwoQuery)
            {
                Console.WriteLine(number);
            }

        }


    }
}
