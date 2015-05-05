using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // Required using statement for File I/O

///<summary>
/// Pranav S. Krishnamurthy
/// 5th May 2015
/// * Revisiting this project after a while to brush up on various things
/// * Also to further develop this code to be more readable, usable, etc... 
/// 
/// Verifier: Manhattan Verifier
/// 
/// Source of the Data: http://www.eecs.qmul.ac.uk/~ccloy/downloads_keystroke100.html
///</summary>

namespace QUML_Keystrokes
{
    class Program
    {
        #region Static 2D Double arrays
        static double[,] s001;
        static double[,] s002;
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the QUML Analyzer!");

            #region Data Extraction
            s001 = ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user1.csv");
            s002 = ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user2.csv"); 
            #endregion

            // Printing out the 2D double array to be sure of proper data extraction
            #region Printing out, this is a test
            for (int i = 0; i < s002.GetLength(0); i++)
            {
                for (int j = 0; j < s002.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", s001[i, j])); 
                }
                Console.Write(Environment.NewLine); 
            } 
            #endregion

            Console.ReadKey(); 
        }

        /// <summary>
        /// This is the method that will convert the file into a 2D double array or whichever type of 2D array that is required for whatever
        /// problem is being solved. 
        /// </summary>
        /// <param name="filePath">The path the file which is going to be used to convert from file to 2D array</param>
        /// <returns>The 2D double array</returns>
        static double[,] ParseData(string filePath)
        {
            // Using the String class, will now be able to start the conversion of the CSV file to a 2D double array
            String input = File.ReadAllText(filePath); 

            // Initialize the counters for the rows and columns
            int i = 0, j = 0; 

            // Initialize the new 2D double array which has 10 rows and 7 columns
            double[,] dataVals = new double[10, 7]; 

            // Using nested foreach loop here, each row being separated by the new line ('\n')
            foreach (var row in input.Split('\n'))
            {
                j = 0; 

                // This inner foreach loop will look at the columns being separated by the comma (',')
                foreach(var col in row.Trim().Split(','))
                {
                    // Populating the values of the 2D double array dataVals
                    dataVals[i, j] = double.Parse(col.Trim());
                    j++; // Increment the column
                }
                i++; // Increment the row
            }

            // Outputs the 2D double array dataVals in this return statement, and I will print out in the main method. 
            return dataVals;
        }
    }
}