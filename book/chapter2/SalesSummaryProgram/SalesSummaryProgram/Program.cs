using System;
using System.Collections.Generic;
using System.IO;

namespace SalesSummaryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // 売り上げデータを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath)
        {
            var sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                var items = line.Split(',');
                var sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);
            }

            return sales;
        }
    }
}
