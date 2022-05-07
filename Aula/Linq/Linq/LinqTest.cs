using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    internal class LinqTest
    {
        public static void Teste()
        {
            //Filtering:
            //      Where, OfType

            //Sorting:
            //      OrderBy, OrderByDecending, ThenBy, ThenByDescending, Reverse

            //Set:
            //      Distinct, Except, Intersect, Union

            //Quantification:
            //      All, Any, Contains

            //Projection:
            //      Skip, Take

            //Partition:
            //      Skip, Take

            //Join:
            //      Join, GroupJoin

            //Grouping:
            //      GroupBy

            //Generational:
            //      Empty

            //Equality:
            //      SequenceEquals

            //Element:
            //      ElementAt, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault

            //Conversions:
            //      AsEnumerable, AsQueryable

            //Concatenation:
            //      Concat

            //Aggregation:
            //      Aggregate, Average, Count, LongCount, Max, Min, Sum

            //Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}