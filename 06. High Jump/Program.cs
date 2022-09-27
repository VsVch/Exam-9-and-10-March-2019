using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {

            double hihgWants = double.Parse(Console.ReadLine());

            double highStarts = hihgWants - 30;
            double highCurant = double.Parse(Console.ReadLine());
            int br = 1;
            

            while (highCurant <= hihgWants)
            {
                
                highCurant = double.Parse(Console.ReadLine());
                br++;
                int brFail = 0;
                if (highCurant <= highStarts)
                {
                    
                    brFail++;
                    if (brFail == 3)
                    {
                        break;
                    }


                }
                else if (highCurant >= hihgWants)
                {
                    brFail = 0;
                    highStarts += 5;

                }

               


            }


            if (highCurant >= hihgWants)
            {
                Console.WriteLine($"Tihomir failed at {highCurant}cm after {br} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {hihgWants}cm after {br} jumps.");
            }




        }
    }
}
