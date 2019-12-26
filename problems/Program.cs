using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var word = words.Where(w => w.Contains("th"));
            foreach (var item in word)
            {
                 Console.WriteLine(item);
            }

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var name = names.Select(n => n).Distinct();
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            //Problem 3
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55"};
            var aveGrades = classGrades.Select(cg => cg.Split(',').Select(g => Convert.ToInt32(g)).OrderByDescending(n => n).Take(cg.Split(',').Length - 1).Average()).Average();
            Console.WriteLine(aveGrades);

            //Problem 4
            string random = "helloworld";
            var str = random.OrderBy(l=>l).GroupBy(l=>l).Select(l=>l.Distinct().Concat(Convert.ToString(l.Count())).ToList()).ToList();

            foreach (var item in str)
            {
                Console.Write(item[0]+""+item[1]);
            }
            Console.ReadLine();
        }
    }
}
