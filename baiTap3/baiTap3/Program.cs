using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập phần thực số phức A: ");
            double aReal = double.Parse(Console.ReadLine());
            Console.Write("Nhập phần số ảo số phức A: ");
            double aImaginary = double.Parse(Console.ReadLine());

            Console.Write("Nhập phần thực số phức B: ");
            double bReal = double.Parse(Console.ReadLine());
            Console.Write("Nhập phần số ảo số phức B: ");
            double bImaginary = double.Parse(Console.ReadLine());

            complexNumber A = new complexNumber(aReal, aImaginary);
            complexNumber B = new complexNumber(bReal, bImaginary);

            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"A / B = {A / B}");
        }
    }
}
