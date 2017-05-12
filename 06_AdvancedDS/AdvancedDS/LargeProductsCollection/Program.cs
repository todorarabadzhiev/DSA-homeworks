using System;
using System.Diagnostics;
using System.Linq;
using Wintellect.PowerCollections;

namespace LargeProductsCollection
{
    public class Program
    {
        private static readonly Random randGen = new Random();

        public static void Main()
        {
            int productsNumber = 500000;
            int searchesNumber = 1000000;
            int nameLenLow = 3;
            int nameLenUp = 10;
            double priceLow = 0.01;
            double priceUp = 10000.00;
            int takeCount = 20;

            Stopwatch timer = new Stopwatch();
            timer.Start();
            OrderedBag<Product> productsBag = GenerateProducts(productsNumber,
                    nameLenLow, nameLenUp, priceLow, priceUp);
            timer.Stop();
            Console.WriteLine($"Time to fill SortedBag with {productsNumber} random products is {timer.Elapsed}");

            timer.Restart();
            for (int i = 0; i < searchesNumber; i++)
            {
                decimal lowerBoundary = RandomDecimal(priceLow, priceUp - 0.01);
                decimal upperBoundary = RandomDecimal((double)lowerBoundary + 0.01, priceUp);

                Product minProduct = new Product("name", lowerBoundary);
                Product maxProduct = new Product("name", upperBoundary);
                var foundProducts = productsBag.Range(minProduct, true, maxProduct, false).Take(takeCount);
                //Console.WriteLine($"{i}.1: Range({lowerBoundary}-{upperBoundary}) - {foundProducts.First()}");
            }
            timer.Stop();
            Console.WriteLine($"Time to perform {searchesNumber} seaches by random price ranges is {timer.Elapsed}");
        }

        private static OrderedBag<Product> GenerateProducts(int productsNumber,
            int strLow, int strUp, double decimalLow, double decimalUp)
        {
            OrderedBag<Product> productsCollection = new OrderedBag<Product>();
            for (int i = 0; i < productsNumber; i++)
            {
                string name = RandomString(randGen.Next(strLow, strUp));
                decimal price = RandomDecimal(decimalLow, decimalUp);

                Product product = new Product(name, price);
                productsCollection.Add(product);
            }

            return productsCollection;
        }

        private static decimal RandomDecimal(double min, double max)
        {
            double result = randGen.NextDouble() * (max - min) + min;
            return (decimal)result;
        }

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] randString = new char[length];
            for (int i = 0; i < randString.Length; i++)
            {
                randString[i] = chars[randGen.Next(chars.Length)];
            }

            return new string(randString);
        }
    }
}
