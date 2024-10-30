using System;
using System.Drawing;
using System.Threading.Channels;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DS_Arrays
{
    internal class Program
    {
        /*
        * **************
        * Description *
        * **************
            * Arrays are one of the simplest and most fundamental data structures in programming. 
             In C#, an array is a fixed-size, ordered collection of elements of the same type
        */
        static void Main(string[] args)
        {
            #region 1. Basics of Arrays
            /* An array is essentially a sequence of elements that are stored in contiguous memory locations. 
                Each element in the array is accessed using an index, starting from 0.*/

            #region Declaration and Initialization
            //int[] numbers1; 
            #endregion

            #region Declaration with initialization 
            //int[] numbers2 = new int[5]; // An array that can hold 5 integers, initially set to 0 
            #endregion

            #region Initialization with known values
            //int [] numbers3 = { 1,2,3,4,5}; // Array of 5 integers with specific values 
            #endregion

            #region Multi-dimensional array
            //int[,] matrix = new int[3, 3]; // A 3x3 matrix (two-dimensional array) 
            #endregion

            #region Jagged array (an array of arrays)
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[3];
            //jaggedArray[2] = new int[4];
            // OR 
            //int[][] jaggedArray = 
            //{
            //     new int [2],
            //     new int [3],
            //     new int [4],
            //}; 
            #endregion

            #endregion

            #region 2. Accessing and Modifying Elements
            /* Elements in an array are accessed using their index */

            //int[] numbers = { 10,20,30,40,50};
            //Console.WriteLine(numbers[0]); // Output: 10

            #region Modify an element
            //numbers[2] = 35;
            //Console.WriteLine(numbers[2]); // Output: 35 
            #endregion

            #endregion

            #region 3. Traversing an Array
            /* There are several ways to loop through an array, depending on what you need to accomplish */

            #region For Loop
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Foreach Loop
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}  
            #endregion

            #endregion

            #region 4. Common Operations on Arrays
            /* Let’s explore some common array operations: */

            #region Finding the Length
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Length of array: " + numbers.Length); // Output: 5 
            #endregion

            #region Searching for an Element
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int index = Array.IndexOf(numbers, 3);
            //Console.WriteLine("Index of 3: " + index); // Output: 2 
            #endregion

            #region Sorting an Array
            //int[] numbers = {5,2,8,1,3};
            //Array.Sort(numbers);
            //Console.WriteLine("Sorted Array:" + string.Join(", " , numbers)); // Output: 1, 2, 3, 5, 8 
            #endregion

            #region Reversing an Array
            //int[] numbers = {1,2,3,4,5};
            //Array.Reverse(numbers);
            //Console.WriteLine("Reversed Array:" + string.Join(", " , numbers)); // Output 5, 4, 3, 2, 1 
            #endregion


            #endregion

            #region 5. Multi-Dimensional Arrays
            /* Multi - dimensional arrays are arrays with more than one dimension, like a matrix */

            //int[,] matrix =
            //{
            //    { 1,2,3},
            //    { 4,5,6},
            //    { 7,8,9},
            //};

            /* Access element at row 1, column 2 */
            //Console.WriteLine(matrix[1 , 2]); // Output: 6

            #region Traversing a Multi-Dimensional Array
            //int[,] matrix = 
            //    {
            //        { 1, 2, 3 },
            //        { 4, 5, 6 },
            //        { 7, 8, 9 }
            //    };
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int a = 0; a < matrix.GetLength(1); a++)
            //    {
            //        Console.Write(matrix[i , a] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #endregion

            #region 6. Jagged Arrays
            /* A jagged array is an array of arrays, allowing you to have arrays of different sizes. */

            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1,2 };
            //jaggedArray[1] = new int[] { 1,2,3 };
            //jaggedArray[2] = new int[] { 1,2,3,4 };

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 7. Array Methods
            /* C#’s Array class provides several methods to manipulate arrays */

            #region Copy: Copies elements from one array to another
            //int[] source = { 1, 2, 3};
            //int[] destination = new int[3];
            //Array.Copy(source, destination, 3);
            //Console.WriteLine(string.Join(", ", destination)); // Output: 1, 2, 3

            /* Example Another */

            //int[] source = {1, 2, 3, 4};
            //int[] destination = new int[3];
            //Array.Copy(source, 1, destination, 0, 3);
            //Console.WriteLine(string.Join(", ", destination)); // Output: 2, 3, 4
            #endregion

            #region Clear: Sets elements to default values (e.g., 0 for integers).
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Array.Clear(numbers , 1 , 2);
            //Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 0, 0, 4, 5

            #endregion

            #endregion

            #region 8. Limitations of Arrays
            /*
             * Fixed Size: Once an array is created, its size cannot be changed.
             
             * Performance with Insertions/ Deletions: Inserting or deleting elements 
                in the middle  of an array is inefficient because elements need to be shifted.

             * Type - Safe but Single-Type: Arrays are type - safe, meaning all elements are 
                of the same type, which limits flexibility compared to more advanced collections like List<T>.
            */
            #endregion

            #region Practical Use Cases of Arrays
            /*
                1- Data Storage: Arrays are commonly used when data is structured and has a fixed size, 
                    such as storing sensor readings or the pixels in an image.

                2- Game Development: Arrays are useful in game development for storing elements like game 
                    grids(2D arrays for board games) or fixed inventories.

                3- Batch Processing: Arrays help in batch processing when you know the number of records 
                    in advance and can process data sequentially.
            */

            #endregion

            #region Summary
            /*
              Arrays in C# are powerful but have limitations due to their fixed size and static nature. 
                For scenarios requiring a fixed, efficient, and indexed collection, arrays are an excellent choice.
                When flexibility is required, however, dynamic collections like List<T> may be more appropriate.
            */
            #endregion
        }
    }
}
