using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BigData.Model;
using FileHelpers;

namespace BigData.BL
{
    public class CSVReader
    {
        public IEnumerable<Product> ReadProductsAsync(string filePath)
        {
            var engine = new FileHelperEngine<Product>();
            engine.Options.IgnoreFirstLines = 1; 
            var result = engine.ReadFile(filePath);
            return result;
        }
    }
}