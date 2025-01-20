using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/adt_all_20250116_3/tasks/abc310_b
    class QuestionC
    {
        private class Product
        {
            public long Price { get; set; }
            public long FuncCount { get; set; }
            public List<long> Funcs { get; set; }
        }

        private static bool isStrictlySuperior(Product productA, Product productB)
        {
            return productA.Price >= productB.Price &&
                productA.Funcs.All(x => productB.Funcs.Contains(x)) &&
                (productA.Price > productB.Price || !productB.Funcs.All(y => productA.Funcs.Contains(y)));
        }

        private static bool hasSuperiorPair(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                for (int j = 0; j < products.Count; j++)
                {
                    if (isStrictlySuperior(products[i], products[j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var nm = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long n = nm[0];
            long m = nm[1];

            List<Product> products = new List<Product>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToList();
                Product product = new Product();
                product.Price = input[0];
                product.FuncCount = input[1];
                product.Funcs = input.GetRange(2, input.Count - 2);
                products.Add(product);
            }

            string result = hasSuperiorPair(products) ? "Yes" : "No";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
