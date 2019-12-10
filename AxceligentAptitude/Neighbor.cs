using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentAptitude
{
    public static class Neighbor
    {
        public static int Challenge(int[] input)
        {
            var dictN = new Dictionary<int, int>();
            int maxValue_M = GetMaxValue(input, dictN);
            List<int> selectedValues = new List<int>();
            GetSelectedValues(input, dictN, maxValue_M, selectedValues);
            return GetBiggestNeighbor(selectedValues);
        }

        private static int GetBiggestNeighbor(List<int> selectedValues)
        {
            List<int> listBigNeighbor = new List<int>();
            for (int num = 0; num < selectedValues.Count(); num++)
            {
                if (num + 1 < selectedValues.Count())
                {
                    listBigNeighbor.Add(selectedValues[num] + selectedValues[num + 1]);
                }
            }
            Console.WriteLine("Sum Of Biggest Neighbor is {0}", listBigNeighbor.Max());
            return listBigNeighbor.Max();
        }

        private static void GetSelectedValues(int[] input, Dictionary<int, int> dictN, int maxValue_M, List<int> selectedValues)
        {
            List<int> valueNeedToRemove = new List<int>();
            foreach (var pair in dictN)
            {
                Console.WriteLine("number {0} repeated {1} times,", pair.Key, pair.Value);
                if (pair.Value != maxValue_M && pair.Value != maxValue_M - 1)
                {
                    valueNeedToRemove.Add(pair.Key);
                }
            }
            for (int num = 0; num < input.Count(); num++)
            {
                if (!valueNeedToRemove.Contains(input[num]))
                {
                    selectedValues.Add(input[num]);
                }
            }
        }

        private static int GetMaxValue(int[] input, Dictionary<int, int> dictN)
        {
            foreach (var value in input)
            {
                if (dictN.ContainsKey(value))
                    dictN[value]++;
                else
                    dictN[value] = 1;
            }

            var maxValue_M = dictN.Values.Max();
            Console.WriteLine("maximum M is {0},", maxValue_M);
            return maxValue_M;
        }
    }

}
