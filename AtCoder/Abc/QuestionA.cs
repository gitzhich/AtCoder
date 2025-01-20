using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/adt_all_20250116_3/tasks/abc339_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s = Console.ReadLine();

            List<string> words = new List<string>(s.Split("."));

            string result = words.Last();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
