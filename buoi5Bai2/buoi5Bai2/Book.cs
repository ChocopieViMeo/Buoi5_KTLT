using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5Bai2
{
    internal class Book
    {
        string name;
        Author author;
        double price;
        int qty;

        public string Name { get { return name; } set { name = value; } }
        public double Price {  get { return price; } set { price = value; } }
        public int Qty { get { return qty; } set { qty = value; } }

        public Author Author { get { return author; } set { author = value; } }
        public Book() { }
        public Book ( string name, Author author, double price, int qty)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }
        public void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("--- Nhập tên sách: ");
            name = Console.ReadLine();
            Console.WriteLine("--- Tác giả: ");
            author = new Author();
            author.Input();
            do
            {
                Console.Write("Nhập giá bán: ");
                price = double.Parse(Console.ReadLine());
            } while (price <= 0);
            do
            {
                Console.Write("Nhập số lượng: ");
                qty = int.Parse(Console.ReadLine());
            } while (qty <= 0);
        }
        public override string ToString()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"--- Tên sách: {name}");
            Console.WriteLine($"--- Tác giả: ");
            author.ToString();
            Console.WriteLine($"--- Giá bán: {price}");
            Console.WriteLine($"--- Số lượng: {qty}");
            Console.WriteLine($"--- Thành tiền: {qty * price}");
            return base.ToString();
        }
    }
}
