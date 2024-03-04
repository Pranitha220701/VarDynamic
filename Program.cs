using System.Security.Cryptography.X509Certificates;

namespace VarDynamic
{
    public class VarDynamic
    {
        public static void Main(string[] args)
        {
            var a = 3;
            dynamic b;
            Console.WriteLine("Enter b value:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + b);
        }
    }
}