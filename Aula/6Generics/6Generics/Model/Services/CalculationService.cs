using System;
using System.Collections.Generic;
using System.Text;

namespace _6Generics.Model.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentOutOfRangeException("Lista sem produtos.");
            }
            T temp = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(temp) > 0)
                {
                    temp = list[i];
                }
            }

            return temp;
        }
    }
}