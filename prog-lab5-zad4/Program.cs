using System;
using System.Collections.Generic;

namespace prog_lab5_zad4
{
    class Sklad
    {
        private List<string[]> data = new List<string[]>();

        // добавление продукта на склад
        public void addProduct(string name, string dateOfDelivery, float price, float weight, string provider)
        {
            string[] product = { name, dateOfDelivery, price.ToString(), weight.ToString(), provider };
            data.Add(product);
        }
                
        // поиск продукта
        public List<string[]> searchProduct(int typeOfData, string matchString)
        {
            List<string[]> result = new List<string[]>();

            foreach (string[] a in data)
                if (a[typeOfData] == matchString)
                    result.Add(a);
            return result;
        }

        // сортировка
        public List<string[]> sortProducts(int typeOfData)
        {
            data.Sort((a, b) => a[typeOfData].CompareTo(b[typeOfData]));
            return data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sklad skladOne = new Sklad();
            int a = 0; // номер операции 1-4
            while (a != 4) // 4 - exit
            {
                Console.Write("1. Add a product\n2. Search a product\n3.Sort products\n4.Exit\nChoose an operation: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {

                    case 1:
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Delivery date: ");
                        string dateOfDelivery = Console.ReadLine();
                        Console.Write("Price: ");
                        float price = float.Parse(Console.ReadLine());
                        Console.Write("Weight: ");
                        float weight = float.Parse(Console.ReadLine());
                        Console.Write("Provider: ");
                        string provider = Console.ReadLine();
                        skladOne.addProduct(name, dateOfDelivery, price, weight, provider);
                        Console.WriteLine("The product has been added successfully!");
                        break;

                    case 2:
                        Console.WriteLine("Search products by:\n1 - name, 2 - date, 3 - price, 4 - weight, 5 - provider.");
                        int typeOfData = int.Parse(Console.ReadLine());
                        Console.Write("Searching word/number:");
                        string matchString = Console.ReadLine();
                        List<string[]> list1 = skladOne.searchProduct(typeOfData - 1, matchString);
                        foreach (string[] str in list1)
                        {
                            foreach (string pieceString in str)
                                Console.Write(pieceString + "  ");
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Sort products by:\n1 - name, 2 - date, 3 - price, 4 - weight, 5 - provider.");
                        int typeOfDataSort = int.Parse(Console.ReadLine());
                        List<string[]> list2 = skladOne.sortProducts(typeOfDataSort - 1);
                        foreach (string[] str in list2)
                        {
                            foreach (string pieceString in str)
                                Console.Write(pieceString + "  ");
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        System.Environment.Exit(1);
                        break;
                        
                    default:
                        Console.WriteLine("Input digit 1, 2, 3 or 4\n");
                        break;

                }
                Console.WriteLine();
            }
        }
    }
}
