using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_TSP.AGClass
{
    public static class Utils
    {
        public static List<int> RandomNumbers(int start, int end)
        {
            List<int> numbers = new List<int>();
            for (int i = start; i < end; i++)
            {
                numbers.Add(i);
            }

            //embaralhar a lista
            for (int i = 0; i < numbers.Count; i++)
            {
                int a = ConfigurationGA.Random.Next(numbers.Count);
                int temp = numbers[i];
                numbers[i] = numbers[a];
                numbers[a] = temp;
            }

            return numbers.GetRange(0, end);
        }
    }
}
