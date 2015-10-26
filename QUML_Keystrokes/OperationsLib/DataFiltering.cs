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
 * 1.2      13/06/2015  PKR     Editing the number of lines of code that were written, and updating the in-code documentation
 * 1.2.1    25/06/2105  PKR     Cleaning up the in-code documentation of the DataFiltering.cs class
 * 2.0      05/09/2015  PKR     Creating a new .dll library for the operations - all the mathematical calculations will be done. 
 * 2.1      26/10/2015  PKR     Reviewing this code, and updating the in-code documentation accordingly
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OperationsLib
{
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
            String inputFile = File.ReadAllText(filePath);

            int i = 0, j = 0;

            double[,] dataVals = new double[10, 7];

            foreach (var row in inputFile.Split('\n'))
            {
                j = 0;

                foreach (var col in row.Trim().Split(','))
                {
                    dataVals[i, j] = double.Parse(col.Trim());
                    j++;
                }
                i++;
            }

            // Spitting back to the variable that was created
            return dataVals;
        }
    }
}