

namespace Session4Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Q1: One-dimensional array
            Console.WriteLine("Q1: One-dimensional array ");
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"Second price (index 1): {prices[1]}\n");
            #endregion

            #region Q2: Multidimensional array
            Console.WriteLine("Q2: Multidimensional array ");
            // Create a 2D array to represent the number of copies of books on two shelves
            // we can delete this new int []
            int[,] shelfCopies = new int[2, 2] {
                { 3, 5 }, // Shelf 0    
                { 1, 4 }  // Shelf 1
            };

            Console.WriteLine($"Copies on shelf 0, slot 0: {shelfCopies[0, 0]}");
            Console.WriteLine($"Copies on shelf 0, slot 1: {shelfCopies[0, 1]}");
            Console.WriteLine($"Copies on shelf 1, slot 0: {shelfCopies[1, 0]}");
            Console.WriteLine($"Copies on shelf 1, slot 1: {shelfCopies[1, 1]}");
           
            #endregion





        }

    }
   
}