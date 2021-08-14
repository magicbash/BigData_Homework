using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BigData.Model;

namespace BigData.BL
{
    public static class ProductAnalyzer
    {
        public static IEnumerable<CalculateResult> Calculate(IEnumerable<Product> products)
        {
            var grouped = products.GroupBy(a=> a.OriginCountry);
            var result = new List<CalculateResult>();
            foreach (var grouping in grouped)
            {
                var groupingSum = grouping.Sum(a => a.RatingCount);
                var fiveSum = grouping.Sum(a => a.RatingFiveCount ?? 0);
                result.Add(new CalculateResult
                {
                    OriginCountry = grouping.Key, 
                    AvgPrice = grouping.Average(a => a.Price), 
                    ShareOfFiveStars = groupingSum == 0 ? 0 : (double)fiveSum / groupingSum 
                });
            }

            return result;
        }
    }
}