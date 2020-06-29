using System;

namespace Lab2_4VarSyntaxConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 2_4 Great 2 times....Yeah! Yeah!

            // In the Main() code block, write the following lines of C# code.
            Console.WriteLine("Hello World!");

            // 1. Create a variable called myFirstNumber as an integer with the value of 19.
            int myFirstNumber = 19;

            // 2. Create a variable called mySecondNumber as an integer with the value of 244.
            int mySecondNumber = 244;

            // 3. Use Console.WriteLine to print the results of multiplying myFirstNumber and mySecondNumber.
            Console.WriteLine(myFirstNumber * mySecondNumber);

            // 4. Create a variable called myText as a string with the value "Some Text".
            string myText = "Some Text";

            // 5. Use Console.WriteLine to print the results of myText and mySecondNumber together.
            Console.WriteLine(myText + mySecondNumber);
            Console.WriteLine(myText + " " + mySecondNumber);

            // 6. Create a variable called moreText as a string with the value "Goes Here".
            string moreText = "Goes Here";

            // 7. Use Console.WriteLine to print the results of adding myText and moreText.
            Console.WriteLine(myText + " " + moreText);
            Console.WriteLine($"{myText} {moreText}");

            // 8. Create two strings with the name color1 and color2.  Assign color1 the value "Yellow". Assign color2 the value "Red".
            string color1 = "Yellow";
            string color2 = "Red";

            // 9. Create two bools, isYellow and isGreen. Set isYellow to true  and isGreen to false.
            bool isYellow = true;
            bool isGreen = false;

            // 10.Use Console.WriteLine to print the values of color1, isYellow, color2, isGreen.
            Console.WriteLine(color1 + " " + isYellow + " " + color2 + " " + isGreen);
            Console.WriteLine($"{color1} {isYellow} {color2} {isGreen}");

            // 11. Create a variable called numbers as a double, but don't assign it any value yet.
            double numbers;

            // 12. On a new line, assign numbers the value of mySecondNumber divided by myFirstNumber.
            numbers = mySecondNumber / myFirstNumber;

            // 13. Print the value of numbers to the console.
            Console.WriteLine(numbers);

            // 14. On a new line, assign numbers the value of mySecondNumber divided by myFirstNumber, but this time, cast myFirstNumber as a double.
            numbers = mySecondNumber / (double)myFirstNumber;

            // 15. Print the value of numbers to the console.
            Console.WriteLine(numbers);

            // 16.Use Console.WriteLine to print the text "Breakpoint Here".   Insert a breakpoint to pause execution at this line. Run the program, 
            // and inspect the values of all of your variables. Hover your mouse over the variable to see it’s value appear.
            Console.WriteLine("Breakpoint Here");

            // 17. Create a variable called textToNumber as a string with the value "80473"
            string textToNumber = "80473";

            // 18. Create a variable called results as an integer and assign it the value of 99 * textToNumber. Use int.Parse() 
            // to complete the operation. Print the results.
            int results = 99 * int.Parse(textToNumber);

            // 19. Create a DateTime variable called rightNow and set it’s value to Datetime.Now. Print the results.
            DateTime rightNow = DateTime.Now;

        }
    }
}
