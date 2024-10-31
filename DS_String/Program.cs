using Microsoft.VisualBasic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DS_String
{
    internal class Program
    {
        /*
        * **************
        * Description *
        * **************
            Strings in C# are an essential data structure, commonly used to store and manipulate text. 
            In C#, strings are immutable, meaning that once a string is created, it cannot be modified. 
            Any operation that appears to modify a string actually creates a new string instance. 
            Here’s an in-depth look at strings, with examples for common operations and use cases.
        */
        static void Main(string[] args)
        {
            #region 1. Declaring and Initializing Strings
            /* In C#, strings are instances of the System.String class, 
                making them powerful objects with a range of methods.
            */

            #region  Basic string initialization
            //string greeting = "Hello , World";
            #endregion

            #region Using string interpolation
            //string name = "Mohamed";
            //string welcomeMessage = $"Hello, {name}"; // Output: Hello, Mohamed!
            #endregion

            #region Using concatenation
            //string fullName = "Mohamed" + " " + "Abdullah" ; // Output: Mohamed Abdullah
            #endregion

            #endregion

            #region 2. Accessing and Modifying Strings
            /* Since strings are immutable, you can't modify them directly. You can, however, 
                create new strings by combining or altering existing ones 
            */

            #region Accessing a character by index
            //string text = "Youtube";
            //char firstLetter =text[0] ;
            //Console.WriteLine(firstLetter); // Output Y
            #endregion

            #region Concatenating strings
            //string modifiedText = text + " Is Amazing";
            //Console.WriteLine(modifiedText); // Output Youtube Is Amazing
            #endregion

            #endregion

            #region 3. Common String Operations

            #region Concatenation
            /* You can concatenate strings using the + operator or the string.Concat method */

            //string part1 = "Hello";
            //string part2 = "World";
            //string message = part1 + " " + part2; // Output: Hello World
            #endregion

            #region String Interpolation
            /* C# provides string interpolation (using $"..." syntax), which is convenient and more readable */

            //string name = "Mohamed";
            //string message = $"Welcome, {name}!"; // Output: Welcome, Mohamed!
            #endregion

            #region Substring
            /* The Substring method extracts part of a string, starting at a specified index */

            //string text = "Youtube";
            //string subText = text.Substring(0 , 4); // Extracts "Yout"
            //Console.WriteLine(subText); // Output: Yout
            #endregion

            #region Searching within Strings
            /* Methods like IndexOf and Contains help locate substrings. */

            //string name = "Hello, World!";
            //int index = name.IndexOf("World"); // Output 7
            //bool contains = name.Contains("World"); // Output: True
            #endregion

            #endregion

            #region 4. Manipulating Case
            /* Changing the case of strings can be useful in text formatting or comparison */
            //string text = "Youtube";
            //string upperText = text.ToUpper(); // Output: YOUTUBE
            //string lowerText = text.ToLower(); // Output: youtube
            #endregion

            #region 5. Trimming and Removing White Space
            /* Trim, TrimStart, and TrimEnd remove whitespace from the beginning or end of a string */
            //string text = "  Youtube  ";
            //string trimmedText = text.Trim(); // Output: "Youtube"
            #endregion

            #region 6. Replacing Characters or Substrings
            /* The Replace method substitutes characters or substrings */
            //string text = "Hello, World!";
            //string newText = text.Replace("World", "C#"); // Output: Hello, C#!
            #endregion

            #region 7. Splitting and Joining Strings
            /* Splitting divides a string based on a delimiter, while joining combines elements with a separator */

            //string sentence = "I love programming in C#";
            //string[] words = sentence.Split(' '); // Splits sentence into array of words

            //string[] fruits = { "Apple", "Banana", "Cherry" };
            //string fruitList = string.Join(", ", fruits); // Output: "Apple, Banana, Cherry"
            #endregion

            #region 8. Checking for Null or Empty Strings
            /* It’s essential to check if a string is empty or null before performing operations */

            //string text = null;
            //bool isEmpty = string.IsNullOrEmpty(text); // True if text is null or empty
            //bool isWhitespace = string.IsNullOrWhiteSpace(text); // True if text is null, empty, or whitespace
            #endregion

            #region 9. Comparing Strings
            /* C# provides several methods for comparing strings, including case-insensitive comparisons */
            //string text1 = "YouTube";
            //string text2 = "youtube";

            //bool areEqual = text1.Equals(text2);// Output: False
            //bool areEqual = text1.Equals(text2 , StringComparison.OrdinalIgnoreCase);// Output: True

            //int comparisonResult = string.Compare(text1, text2, true); // 0 if equal, ignoring case
            #endregion

            #region 10. StringBuilder for Efficient String Manipulation
            /* Since strings are immutable, frequent modifications (e.g., in loops) 
                can create performance issues due to the creation of new instances each time. 
                StringBuilder provides a mutable alternative 
            */

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //sb.Append(" ");
            //sb.Append("World");

            //string result = sb.ToString(); // Output: Hello World
            #endregion

            #region 11. Multi-line Strings
            /* In C# 11 and later, you can use raw string literals to handle multi-line text, 
                 which respects indentation and special characters 
             */

            //        string multiLineText = """
            //This is a multi-line string.
            //It preserves whitespace and special characters
            //""";
            //        Console.WriteLine(multiLineText);
            #endregion

            #region 12. Practical Use Cases for Strings
            /* Strings are widely used across applications for: */

            // 1- User Input: Collecting and storing user input.
            // 2- Data Processing: Manipulating data like JSON, CSV, or XML.
            // 3- Logging: Generating log messages for debugging.
            // 4- Text Formatting: Displaying formatted output to users.
            // 5- File Paths and URLs: Managing file locations and web addresses.
            #endregion

            #region Example: Basic Text Processing in C#
            /* Here’s an example where we format and manipulate a string to create a formatted message: */
            //string name = "Mohamed";
            //string message = "Hello";
            //int age = 27;

            //string output = $"{message}, {name}! You are {age} years old";
            //Console.WriteLine(output); // Output: Hello, Mohamed! You are 27 years old.


            #region  Extract and manipulate
            //int indexOfExclamation = output.IndexOf("!");
            //string extractedText = output.Substring(0, indexOfExclamation); // "Hello, Mohamed"
            //Console.WriteLine(extractedText);
            #endregion

            #region Replace text
            //string newMessage = output.Replace("Mohamed", "Rayyan");
            //Console.WriteLine(newMessage); // Output: Hello, Rayyan! You are 25 years old.
            #endregion
            #endregion

            #region Summary
            /* 
             * Strings in C# offer a wide array of built-in methods that make them a flexible and powerful 
                tool for text manipulation. However, due to immutability, repeated modifications should use 
                StringBuilder for performance. By mastering string manipulation, you can effectively handle 
                text-based data and apply it across various C# applications
             */
            #endregion
        }
    }
}
