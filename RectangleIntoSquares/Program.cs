using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntoSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sqInRect(5, 3));
            Console.ReadKey();
        }

        public static List<int> sqInRect(int lng, int wdth)
        {
            if (lng == wdth)
            {
                return null;
            }
            var squares = new List<int>();
            while (lng > 0 && wdth > 0)
            {
                if (lng < wdth)
                {
                    squares.Add(lng);
                    wdth -= lng;
                }
                else
                {
                    squares.Add(wdth);
                    lng -= wdth;
                }
            }

            return squares;
        }

        public static List<int> sqInRect1(int lng, int wdth)
        {
            if (lng == wdth) return null;
            List<int> list = new List<int>();
            while (lng > 0 && wdth > 0)
            {
                int max = Math.Max(lng, wdth);
                int min = Math.Min(lng, wdth);
                list.Add(min);
                wdth = min;
                lng = max - min;
            }
            return list;
        }

        public static List<int> sqInRect3(int lng, int wdth)
        {
            return (lng == wdth) ? null : EnumerateSquares(lng, wdth).ToList();
        }

        public static IEnumerable<int> EnumerateSquares(int length, int width)
        {
            while (length != width)
            {
                if (length > width)
                {
                    yield return width;
                    length -= width;
                }
                else
                {
                    yield return length;
                    width -= length;
                }
            }

            yield return length;
        }
    }
}
