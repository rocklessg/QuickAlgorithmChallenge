using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class AsyncAwaitKiss
    {
        // Async/await
        async Task MakeDinnerAsync()
        {
            // Start boiling water asynchronously
            Task boilWaterTask = BoilWaterAsync();

            // While water is boiling, chop vegetables
            ChopVegetables();

            // Wait for the water to finish boiling
            await boilWaterTask;

            // Continue with the next step
            CookPasta();
        }

        //await MakeDinnerAsync();
        async Task BoilWaterAsync()
        {
            Console.WriteLine("Boiling water...");
            await Task.Delay(5000); // Simulate waiting for 5 seconds
            Console.WriteLine("Water is ready!");
        }

        void ChopVegetables()
        {
            Console.WriteLine("Chopping vegetables...");
        }

        void CookPasta()
        {
            Console.WriteLine("Cook Pasta...");
        }

    }
}
