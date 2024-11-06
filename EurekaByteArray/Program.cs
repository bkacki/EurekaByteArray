using System.IO;
using System.Text;

namespace EurekaByteArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("eureka.txt", "Eureka!", Encoding.Unicode);
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach(byte b in eurekaBytes)
                Console.Write($"{b}".PadLeft(5));
            Console.WriteLine();
            foreach(byte b in eurekaBytes)
                Console.Write($"{b:x2}".PadLeft(5));
            Console.WriteLine();
            Console.WriteLine(Encoding.Unicode.GetString(eurekaBytes, 2, eurekaBytes.Length-2));
        }
    }
}
