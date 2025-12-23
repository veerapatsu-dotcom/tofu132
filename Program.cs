using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tofu132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Progra.Calculate(new double[] { 5, 2, 9, 1, 7, 3 });
        }

        private class Progra
        {
            public static void Calculate(double[] data)
            {
                Console.WriteLine("ค่าเฉลี่ย: " + data.Average());

                Console.WriteLine("ค่าสูงสุด: " + data.Max());

                Console.WriteLine("ค่าต่ำสุด: " + data.Min());

                var sorted = data.OrderBy(x => x).ToArray();
                double median = (sorted.Length % 2 == 0)
                    ? (sorted[sorted.Length / 2 - 1] + sorted[sorted.Length / 2]) / 2
                    : sorted[sorted.Length / 2];

                Console.WriteLine("ค่ากลางข้อมูล: " + median);

                Console.WriteLine("เรียงจากมากไปน้อย: " +
                    string.Join(", ", data.OrderByDescending(x => x)));

                Console.WriteLine("เรียงจากน้อยไปมาก: " +
                    string.Join(", ", data.OrderBy(x => x)));
            }
        }
    }
}