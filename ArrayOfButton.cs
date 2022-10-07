using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBrothersSafe
{
    public static class ArrayOfButton
    {
        public static Tuple<int, int> CoordinatesOf<T>(this List<List<T>> matrix, T value)
        {
            int w = matrix.Count; // width

            for (int x = 0; x < w; ++x)
            {
                int h = matrix[x].Count; // height
                for (int y = 0; y < h; ++y)
                {
                    if (matrix[x][y].Equals(value))
                        return Tuple.Create(x, y);
                }
            }

            return Tuple.Create(-1, -1);
        }
    }
}
