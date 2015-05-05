using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // Required using statement for File I/O

///<summary>
/// Pranav S. Krishnamurthy
/// Project: Analyzing a Keystrokes data set on my own. 
/// Version: 0.2
/// Verifier: Manhattan Verifier
/// 
/// Source of the Data: http://www.eecs.qmul.ac.uk/~ccloy/downloads_keystroke100.html
///</summary>

namespace QUML_Keystrokes
{
    class Program
    {
        #region Static 2D Double arrays for all of the users
        static double[,] s001;
        static double[,] s002;
        static double[,] s003; 
        #endregion

        #region Static Double arrays for each user - these are the mean arrays
        static double[] s001_Mean;
        static double[] s002_Mean;
        static double[] s003_Mean;
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the QUML Analyzer!");

            #region Data Extraction
            s001 = ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user1.csv");
            s002 = ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user2.csv");
            s003 = ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user3.csv");
            #endregion

            // Will now be going for the Manhattan Verifier class
            ManhattanDistance mD = new ManhattanDistance(); 

            // Executing the Test method
            // mD.Test(); 

            // Executing the Print method in the Manhattan Distance class
            mD.Print(s001); 

            // Populating the mean array for the first user
            s001_Mean = mD.CalculateMeanVector(s001);

            Console.Write(Environment.NewLine); 

            // Printing out locally here in the main class
            for (int i = 0; i < s001_Mean.Length; i++)
            {
                // Print the average
                Console.Write(s001_Mean[i] + " "); 
            }

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