using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int x = 23;
                bool t = true;
                string text = $"ala nie ma{x} kota bo jej nie stac.{t}";
                StringBuilder sb = new StringBuilder();
                sb.Append(text);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < 100000; i++)
                {
                    //text += i.ToString();
                    sb.Append(i.ToString());
                }
                text = sb.ToString();
                stopwatch.Stop();
                Console.WriteLine(stopwatch.ElapsedMilliseconds);
                //text = text.Trim();
                //text = text.Replace("ala", "Roman");
                //text = text.Remove(10, 2);
                //Console.WriteLine(text,text);
                //if ("a" != "b")
                //{
                //    if(string.Compare("c", "C", false) == 0)
                //    {

                //    }

                //}
                //var stringArray = text.Split(' ');
                //var x = string.Join(";", stringArray);
                //var array = text.ToArray();
                //Console.WriteLine(array[1]);
                //Console.WriteLine(args[0]);
                //Console.WriteLine(args[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void Print(string firstParam)
        {
            Console.WriteLine(firstParam);

        }
        static void Print(string firstParam, int age = 0)
        {
            Console.WriteLine(firstParam);
            Console.WriteLine(age);
        }
    }
}
