using System;

namespace CodeCoverage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                Calculate.Divide(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
            }
            else
            {
                Console.WriteLine("No operation performs");
            }
        }
    }
}
