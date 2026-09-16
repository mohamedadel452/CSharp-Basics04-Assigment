

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

            #region Q3: PrintWelcomeMessage
            // Call the PrintWelcomeMessage method to display a welcome message
            //this method is defined below the Main method
            // The method is static, so we can call it directly without creating an instance of the Program class
            // The method does not take any parameters and does not return any value
            Console.WriteLine("\nQ3: PrintWelcomeMessage ");
            PrintWelcomeMessage();
            Console.WriteLine();
            #endregion

            #region Q4: PrintBookTitle
            // Call the PrintBookTitle method to display the title of a book
            Console.WriteLine("Q4: PrintBookTitle ");
            // The method takes a string parameter (the title of the book) and does not return any value
            PrintBookTitle("Clean Code");
            Console.WriteLine();
            #endregion

            #region Q5: AddBonusPages (Pass by Value)
            Console.WriteLine("Q5: AddBonusPages ");
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine($"Pages after AddBonusPages: {pages}");
            Console.WriteLine("Expectation: 400. Why? Because 'pages' is a value type passed by value\n, meaning only a copy of the variable was modified inside the method.\n");
            #endregion

            #region Q6: ApplyDiscount (Pass by Reference Type)
            Console.WriteLine("Q6: ApplyDiscount ");
            double[] discountPrices = { 25.5, 40.0 };
            ApplyDiscount(discountPrices);
            Console.WriteLine($"discountPrices[0] after ApplyDiscount: {discountPrices[0]}");
            Console.WriteLine("Expectation: 20.5. Why? Because arrays are reference types.\n Modifying the elements of the array inside the method modifies the original array.\n");
            #endregion











        }


        #region outer methods

        #region Q3 Method
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion

        #region Q4 Method
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }
        #endregion

        #region Q5 Method
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        #endregion

        #region Q6 Method
        static void ApplyDiscount(double[] prices)
        {
            // Check if the array is not null and has at least one element before modifying it
            if (prices != null && prices.Length > 0)
            {
                // As we have the reference to the original array, we can modify its elements directly
                prices[0] -= 5;
            }
        }

        #endregion





        #endregion

    }


}