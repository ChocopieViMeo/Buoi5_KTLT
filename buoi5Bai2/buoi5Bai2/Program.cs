using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            List<Book> list = new List<Book>();
            int choice = -1;
            do
            {
                Console.WriteLine("1. Nhập 1 cuốn sách: ");
                Console.WriteLine("2. Xuất 1 cuốn sách: ");
                Console.WriteLine("3. Nhập nhiều cuốn sách: ");
                Console.WriteLine("4. Xuất nhiều cuốn sách: ");
                Console.WriteLine("=========================");
                Console.Write("Nhập lựa chọn: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            b.Input();
                            break;
                        }
                    case 2:
                        {
                            b.ToString();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhập số cuốn sách: ");
                            break;
                        }
                }

            }



        }
    }
}
