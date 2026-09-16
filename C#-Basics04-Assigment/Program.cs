

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

            #region Q7: AddBonusPagesByRef (Pass by Reference)
            Console.WriteLine("Q7: AddBonusPagesByRef ");
            int refPages = 400;
            AddBonusPagesByRef(ref refPages);
            Console.WriteLine($"Pages after AddBonusPagesByRef: {refPages}");
            Console.WriteLine("Expectation: 450. The result is different because we used the 'ref' keyword,\n which passes the memory address of the variable,\n allowing the method to modify the original variable.\n");
            #endregion

            #region Q8: ReplaceArray
            Console.WriteLine("Q8: ReplaceArray ");
            double[] myPrices = { 25.5, 40.0, 33.75 };
            ReplaceArray(ref myPrices);
            Console.WriteLine($"Length of array after ReplaceArray: {myPrices.Length}\n");
            // The expectation is that the length of the array will be 3,
            // because we replaced the original array with a new one inside the method.
            // Let's print the new prices to verify
            foreach (var price in myPrices)
            {
                Console.WriteLine($"Price: {price}");

            }
            //but without the ref keyword, the original array would not be replaced as the parameter isd only a copy of the reference to the original array,
            //and reassigning it inside the method would not affect the original array outside the method.
            #endregion

            #region Q9: TryGetPrice (out parameter)
            Console.WriteLine("\nQ9: TryGetPrice ");
            // Call the TryGetPrice method to attempt to get the price of a book
            //the out parameter allows the method to return an additional value (the price) along with the boolean result indicating success or failure
            double myprice = 0;
            bool found = TryGetPrice("Clean Code", out myprice);
            if (found)
            {


                Console.WriteLine($"Price found: {myprice}");
            }
            else
            {
                Console.WriteLine($"Price not found. And the price is : {myprice}");
            }
            Console.WriteLine();
            #endregion

            #region Q10: PrintBookInfo (Optional parameters)
            Console.WriteLine("Q10: PrintBookInfo ");
            Console.WriteLine("-Calling PrintBookInfo with only the title:");
            PrintBookInfo("Clean Code"); // title only
            Console.WriteLine("-Calling PrintBookInfo with both title and pages:");
            PrintBookInfo("The Pragmatic Programmer", 320); // both
            Console.WriteLine();

            #endregion

            #region Q11: PrintBookInfo (Named parameters)
            //when we use named parameters, we can specify the values for the parameters in any order,
            //and we can also skip optional parameters if we want to use their default values.
            Console.WriteLine("Q11: PrintBookInfo (Named parameters)");
            PrintBookInfo(pages: 464, title: "Refactoring");
            Console.WriteLine();
            #endregion

            #region Q12: PrintAllTitles (params keyword)
            Console.WriteLine("Q12: PrintAllTitles (params keyword)");
            PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");
            Console.WriteLine();
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

        #region Q7 Method
        // This method demonstrates passing a value type by reference using the 'ref' keyword
        static void AddBonusPagesByRef(ref int pages)
        {
            // Since we are using 'ref', we can modify the original variable directly
            pages += 50;
        }
        #endregion

        #region Q8 Method
        static void ReplaceArray(ref double[] prices)
        {
            // This method demonstrates replacing the entire array by passing it by reference using the 'ref' keyword
            // We create a new array and assigin it to the parameter, which will affect the original array outside this method
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion

        #region Q9 Method
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        #endregion

        #region Q10 & Q11 Method
        static void PrintBookInfo(string title, int pages = 300)
        {
            // This method demonstrates the use of optional parameters in C#
            // The 'pages' parameter has a default value of 300,
            // so if it is not provided when the method is called, it will default to 300
            Console.WriteLine($"Book: {title}, Pages: {pages}");
        }

        #endregion

        #region Q12 Method
        static void PrintAllTitles(params string[] titles)
        {
            //params keyword used on arrays and collections to allow to pass the value of this array as seperated values 
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }

        #endregion

        #endregion

    }


}