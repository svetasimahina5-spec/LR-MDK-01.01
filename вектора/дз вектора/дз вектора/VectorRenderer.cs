using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_вектора
{
    public static class VectorRenderer
    {
        public static void DrawArrow(Vector v)
        {
            int offset = 10;
            int width = 25;
            int height = 15;

            char[,] canvas = new char[height, width];

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    canvas[y, x] = ' ';

            int x1 = v.Start.X_ + offset;
            int y1 = (height - 1) - (v.Start.Y_ + offset);
            int x2 = v.End.X_ + offset;
            int y2 = (height - 1) - (v.End.Y_ + offset);

            if (IsInBounds(x1, y1, width, height)) canvas[y1, x1] = 'S';
            if (IsInBounds(x2, y2, width, height)) canvas[y2, x2] = 'E';

            int dx = Math.Abs(x2 - x1), sx = x1 < x2 ? 1 : -1;
            int dy = -Math.Abs(y2 - y1), sy = y1 < y2 ? 1 : -1;
            int err = dx + dy, e2;

            int curX = x1;
            int curY = y1;

            while (true)
            {
                if (curX == x2 && curY == y2) break;
                e2 = 2 * err;
                if (e2 >= dy) { err += dy; curX += sx; }
                if (e2 <= dx) { err += dx; curY += sy; }

                if (IsInBounds(curX, curY, width, height))
                {
                    if (canvas[curY, curX] == ' ')
                    {
                        canvas[curY, curX] = '*';
                    }
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(canvas[y, x]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInBounds(int x, int y, int width, int height)
        {
            return x >= 0 && x < width && y >= 0 && y < height;
        }
    }
}
