namespace assigment3.route;

class Program
{
    static void Main(string[] args)
    {
        #region q1

        // Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
        // the second price (index 1).
        // double[] prices = { 25.5, 40.0, 33.75 };
        // Console.WriteLine(prices?[1]);

        #endregion

        #region q2
        // Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
        // shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
        // int[,] shelfcopies ={{3,5},{1,4}};
        // Console.WriteLine(shelfcopies[1,0]);


        #endregion

        #region q3
        // Write a method called PrintWelcomeMessage that takes no parameters and prints
        // "Welcome to the Library!". Call it from Main.

        // void PrintWelcomeMessage()
        // {
        //     Console.WriteLine("Welcome to the Library!");
        // }
        // ;
        // PrintWelcomeMessage();


        #endregion

        #region q4

        // Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
        // "Clean Code".

        // string bookTitle = "clean code";
        //
        // static void PrintBookTitle(string title)
        // {
        //     Console.WriteLine($"book title is {title}");
        //     }
        //
        // ;
        //
        // PrintBookTitle(bookTitle);
        
        #endregion

        #region q5

        // Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
        // int pages = 400; and print pages afterward. What do you expect to see, and why?

//         static void AddBonusPages(int pages)
//         {
//             pages += 50;
//         }
//
//         int pages = 400;
//
// AddBonusPages(pages);
// Console.WriteLine($"page after calling method={pages}");
// //i expect 400 because its passing by value and passing by value assigned acopy
//of the variable to  the parameter

        #endregion

        #region q6

        // Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
        //     with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
        //     see, and why?
//         static void ApplyDiscount(double[] prices)
//         {
//             prices[0]-= 5;
//
//         }
//
//         double[] prices = { 25.5, 40.0 };
//         ApplyDiscount(prices);
//         Console.WriteLine($"print prices[0] afterward{prices[0]}");
// //passing by value in reference type make change in the original array 

        #endregion

        #region q7

        // Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
        // Call it and print pages afterward. How is the result different from question 5?


//         static void AddBonusPages( ref int pages)
//         {
//             pages += 50;
//         }
//
//         int pages = 400;
//
// AddBonusPages(ref pages);
// Console.WriteLine($"page after calling method={pages}");//450
// //passing by ref in value tytpe it sends the actual variable to the paramter
//         
        #endregion

        #region q8

        // Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
        // new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
        // afterward.
        // static void ReplaceArray(ref double[] prices)
        // {
        //    
        //     prices = new double[] { 10.0, 12.5, 15.0 };
        // }
        //
        // double[] replacementPrices = {1,4};
        //
        // ReplaceArray(ref replacementPrices);
        // Console.WriteLine(replacementPrices[0]);
        // Console.WriteLine(replacementPrices.Length);
        #endregion

        #region q9

        // Write a method bool TryGetPrice(string title, out double price) that returns true and sets
        // price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it 

       // static bool TryGetPrice(string title, out double price)
       //  {
       //      if (title == "clean code")
       //      {
       //          price = 25.5;
       //          return true;
       //      }
       //      else
       //      {
       //          price = 0;
       //          return false;
       //      }
       //  }
       //
       //  string booktitle = "clean code";//لازم اعمل initiaization
       //  double price; 
       //  //مش لازم ابعت فاليو عشان هو اوت
       // bool result= TryGetPrice(booktitle, out price);
       // Console.WriteLine(result);
        #endregion

        #region q10

        // Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
        //     it once with only a title, and once passing both a title and pages.
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
        }
        PrintBookInfo("clean code");
        PrintBookInfo("clean code",600);
        #endregion

    }
        
    
    }
