/*
 * Author: Pranav Krishnamurthy
 * 
 * File Name: DataFiltering.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- ---------------
 * 1.0      11/05/2015  PKR     Original Version
 * 1.1      12/06/2015  PKR     Updating in-code documentation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace QUML_Keystrokes
{
    /// <summary>
    /// This class will be converting a .csv class file into a 2D double array to be used
    /// for calculations with various statistical measures (or verifiers)
    /// </summary>
    public class DataFiltering
    {
        /// <summary>
        /// This is the method that will convert the file into a 2D double array or whichever type of 2D array that is required for whatever
        /// problem is being solved. 
        /// </summary>
        /// <param name="filePath">The path the file which is going to be used to convert from file to 2D array</param>
        /// <returns>The 2D double array</returns>
        public double[,] ParseData(string filePath)
        {
            // Using the String class, will now be able to start the conversion of the CSV file to a 2D double array
            String inputFile = File.ReadAllText(filePath);

            // Initialize the counters for the rows and columns
            int i = 0, j = 0;

            // Initialize the new 2D double array which has 10 rows and 7 columns
            double[,] dataVals = new double[10, 7];

            // Using nested foreach loop here, each row being separated by the new line ('\n')
            foreach (var row in inputFile.Split('\n'))
            {
                j = 0;

                // This inner foreach loop will look at the columns being separated by the comma (',')
                foreach (var col in row.Trim().Split(','))
                {
                    // Populating the values of the 2D double array dataVals
                    dataVals[i, j] = double.Parse(col.Trim());

                    // Increment the column
                    j++; 
                }
                i++; // Increment the row
            }

            // Outputs the 2D double array dataVals in this return statement, and I will print out in the main method. 
            return dataVals;
        }
    }
}
