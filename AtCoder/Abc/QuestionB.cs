using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/adt_all_20250116_3/tasks/abc306_a
    class QuestionB
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 文字列の入力
            String str = new(Console.ReadLine());

            string result = "";

            for (int i = 0; i < n * 2; i++)
            {
                result += str[i / 2];
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
