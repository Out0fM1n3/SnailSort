using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailSort
{
    using System.Collections.Generic;

    public class Solution
    {
        public static List<int> Snail(int[,] array)
        {
            var result = new List<int>();
            int n = array.GetLength(0);
            int m = array.GetLength(1);

            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = m - 1;

            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    result.Add(array[top, i]);
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    result.Add(array[i, right]);
                }
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(array[bottom, i]);
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(array[i, left]);
                    }
                    left++;
                }
            }

            return result;
        }
    }

}
