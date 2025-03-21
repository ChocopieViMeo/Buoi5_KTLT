using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5Bai2
{
    internal class Author
    {
        string name;
        string email;
        char gender;

        public string Name
        { get { return name; } set { name = value;} }
        public string Email
        { get { return email; } set { email = value;} }
        public char Gender
        { get { return gender; } set { gender = value;} }

        public Author() { }
        public Author ( string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public void Input()
        {
            Console.Write("Nhập tên tác giả: ");
            name = Console.ReadLine();
            Console.Write("Nhập email: ");
            email = Console.ReadLine();
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.Write("Nhập gới tính (Male / FeMale): ");
                gender = char.Parse(Console.ReadLine());
            } while (gender != 'm' && gender != 'f');
        }
        public override string ToString()
        {
            Console.WriteLine($"--- Tên tác giả: {name}");
            Console.WriteLine($"--- Email: {email}");
            Console.WriteLine($"--- Giới tính: ");
            Console.OutputEncoding = Encoding.UTF8;
            return base.ToString();
        }
    }
}
