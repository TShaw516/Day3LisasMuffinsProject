using System;

namespace LisasMuffins
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variable
            int cupsOfSugarRecipe = 7;
            int currentCupsOfSugar = 2;
            int remainingCupsRequired = 0;

            //variable computation
            remainingCupsRequired = cupsOfSugarRecipe - currentCupsOfSugar;

            //variable output
            Console.WriteLine("Remaining cups required is {0}", remainingCupsRequired);

            Console.ReadKey();


        }
    }
}
