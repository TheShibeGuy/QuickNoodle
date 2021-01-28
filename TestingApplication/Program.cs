using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
            {
                //Console.WriteLine(interpolate(0, 100, i, 255));
                Console.WriteLine(interpolate(1, 255, i, 255));
            }
            
            Console.ReadKey();
        }
        // This only works for numbers, idk why you would think it works with strings
        public static float interpolate(float startingValue /* Starting Value */, float endingValue /* Ending Value */, int currentStep /* current step */, int numSteps /* total number of steps */)
        {
            if (startingValue < endingValue)
            {
                Console.WriteLine(((endingValue - startingValue) * (currentStep / numSteps)) + startingValue);
                return ((endingValue - startingValue) * (currentStep / numSteps)) + startingValue;
            }
            else
            {
                return ((startingValue - endingValue) * (1 - (currentStep / numSteps))) + endingValue;
            }
        }
    }
}
