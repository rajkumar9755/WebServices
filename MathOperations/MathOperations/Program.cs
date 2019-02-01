using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MathOperations
{
    class Program
    {
        public static List<dynamic> toList(params dynamic[] inp)
        {
            return inp.OfType<dynamic>().ToList();
        }
        static void Main(string[] args)
        {
            //MyReference.MathService math = new MyReference.MathService();
            Maths.MathService mat = new Maths.MathService();
            Console.WriteLine("Integer:");
            Console.WriteLine("Add :"+ mat.Add(JsonConvert.SerializeObject(toList(1,2,3,4,5,6))));
            Console.WriteLine("Sub :" + mat.Sub(JsonConvert.SerializeObject(toList(5,2,1))));
            Console.WriteLine("\nFloat:");
            Console.WriteLine("Add :" + mat.Add(JsonConvert.SerializeObject(toList(4.5,7.3,8.1,2.7))));
            Console.WriteLine("Sub :" + mat.Sub(JsonConvert.SerializeObject(toList(10.5,5.2,2.1))));
            Console.WriteLine("\nString:");
            Console.WriteLine("Add :" + mat.Add(JsonConvert.SerializeObject(toList("Raj", "Kumar"))));
            Console.ReadLine();
        }
    }
}
