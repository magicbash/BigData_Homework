using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BigData.BL;
using BigData.Model;

namespace BigData
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new CSVReader();

            var products = reader.ReadProductsAsync("test-task_dataset_summer_products.csv");

            var result = ProductAnalyzer.Calculate(products);
            
            OutputResult(result);
        }

        private static void OutputResult(IEnumerable<CalculateResult> result)
        {
            foreach (var calculateResult in result)
            {
                Console.WriteLine(
                    $"Country: {calculateResult.OriginCountry}, Average Price: {calculateResult.AvgPrice}, Share of five star products: {calculateResult.ShareOfFiveStars:P}");
            }
        }
    }
}