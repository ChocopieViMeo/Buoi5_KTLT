using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.InPut();
            Console.WriteLine($"User entered day : {date}");           
            Console.ReadKey();
        }
    }
}
