using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogoSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // 46627 max so far.. 
            Console.WriteLine("Iterations: " + Bogo("elentpha", "elephant"));
        }

        static int Bogo(string startText, string finalText)
        {
            Random random = new Random();
            int iterations = 0;
            while (startText != finalText)
            {
                iterations++;
                
                finalText = new string(finalText.ToCharArray().OrderBy(s => (random.Next(2) % 2) == 0).ToArray());
            }

            return iterations;
        }
    }
}