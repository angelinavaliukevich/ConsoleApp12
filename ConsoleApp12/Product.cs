using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Product
    {
        private string name;
        private int price;
        private int id;
        private int data;
        

        public Product(string name,int price, int id, int data)

        {
            this.price = price;
            this.id = id;
            this.data = data;
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;

            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;

            }
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;

            }
        }
        public int Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;

            }
        }
        public void about;
       
        class Program
        {
            static void Main(string[] args)

            {
                Console.WriteLine("Введите название товара");
                var name = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                var price = Console.ReadLine();
                Console.WriteLine("Введите id товара");
                var id = Console.ReadLine();
                Console.WriteLine("Введите количество товара");
                var data = Console.ReadLine();
            }



        }
    }
}