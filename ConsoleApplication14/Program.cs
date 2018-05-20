using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication14
{
    
    class Program
    {
        private static void WriteToFile(IEnumerable<int> result, string filename)
        {
            var str = new StreamWriter(filename);
            foreach (var number in result)
            {
                str.WriteLine(number);
            }
            str.Close();
        }
        static void Main(string[] args)
        {
            string texts123 = File.ReadAllText("task1(1,2,3).txt", Encoding.Default);
            int[] a = texts123.Split(' ').Select(int.Parse).ToArray();

            
            var under0 = from i in a where i < 0 select i;
            Console.WriteLine("Numbers below 0 are: ");
            foreach (var numU20 in under0)
            {
                Console.WriteLine(numU20);
            }
            WriteToFile(under0, "task1(1)result.txt");

            

            var odd = from i in a where (i % 2 != 0) select i;
            odd = odd.Distinct();
            Console.WriteLine("Odd numbers ");
            foreach (var Odd in odd)
            {
                Console.WriteLine(Odd);
            }
            WriteToFile(odd, "task1(2)result.txt");

            
            var over20 = from i in a where (i > 9 && i < 100) orderby (i) select i;
            Console.WriteLine("Sorted numbers which are consists of 2 numerics");
            foreach (var numer20 in over20)
            {
                Console.WriteLine(numer20);
            }
            WriteToFile(over20, "task1(3)result.txt");


            
            string task1_4 = File.ReadAllText("task1(4).txt", Encoding.Default);
            string[] Task1_4 = task1_4.Split(' ').ToArray();
            var words = Task1_4.OrderBy(s => s.Length).ThenByDescending(s => s);
            Console.WriteLine("Sorted words by length");
            foreach (var Words in words)
            {
                Console.WriteLine(Words);
            }
            StreamWriter answer1 = new StreamWriter("task1(4)result.txt");
            foreach (var word in words)
            {
                answer1.WriteLine(word);
            }

            answer1.Close();

            
            string task_5_number = File.ReadAllText("task1(5)Number.txt", Encoding.Default);
            int Task_5_number = Int32.Parse(task_5_number);
            string task_5_array = File.ReadAllText("task1(5).txt", Encoding.Default);
            int[] Task_5_array = task_5_array.Split(' ').Select(int.Parse).ToArray();
            var result = from res in Task_5_array where res > Task_5_number && res > 0 && res % 2 != 0 select res;
            result = result.Reverse();
            Console.WriteLine("Reversed odd >0 numbers from the file task_5_array bigger than number in the file task_5_number");
            foreach (var Result in result)
            {
                Console.WriteLine(Result);
            }
            WriteToFile(result, "task1(5)result.txt");

            

            string k1 = File.ReadAllText("task2(1)K1.txt", Encoding.Default);
            int K1 = Int32.Parse(k1);
            string k2 = File.ReadAllText("task2(1)K2.txt", Encoding.Default);
            int K2 = Int32.Parse(k2);

            string A = File.ReadAllText("task2(1)ArrayA.txt", Encoding.Default);
            var arrA = A.Split(' ').Select(int.Parse).ToList();

            string B = File.ReadAllText("task2(1)ArrayB.txt", Encoding.Default);
            var arrB = B.Split(' ').Select(int.Parse).ToList();

            var rEs = arrA.Where(x => x > K1).Concat(arrB.Where(x => x < K2)).OrderBy(x => x).ToList();
            Console.WriteLine("Sorted arrays");
            foreach (var REs in rEs)
            {
                Console.WriteLine(REs);
            }
            WriteToFile(rEs, "task2(1)result.txt");

            
            string l1 = File.ReadAllText("task2(2)L1.txt", Encoding.Default);
            int L1 = Int32.Parse(l1);
            string l2 = File.ReadAllText("task2(2)L2.txt", Encoding.Default);
            int L2 = Int32.Parse(l2);

            string task2WordsA = File.ReadAllText("task2(2)WordsA.txt", Encoding.Default);
            var Task2WordsA = A.Split(' ').ToList();

            string task2WordsB = File.ReadAllText("task2(2)WordsB.txt", Encoding.Default);
            var Task2WordsB = A.Split(' ').ToList();

            var task5_result = Task2WordsA.Where(x => x.Length == L1).Concat(Task2WordsB.Where(x => x.Length == L2)).OrderByDescending(x => x).ToList();
            foreach (var Task_5_result in task5_result)
            {
                Console.WriteLine(Task_5_result);
            }
            StreamWriter answer2 = new StreamWriter("file2(2)result.txt");
            foreach (string word in task5_result)
            {
                answer2.WriteLine(word);
            }
            answer2.Close();

            Console.ReadKey();
        }
    }
}