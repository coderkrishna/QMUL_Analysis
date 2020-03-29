/*
 * Author: Pranav Krishnamurthy
 * 
 * File Name: DataFiltering.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- --------------- 
 * 2.1      26/10/2015  PKR     Reviewing this code, and updating the in-code documentation accordingly
 * 3.0      19/05/2018  PKR     Adding in a method for outputting the data
 */
namespace OperationsLib
{
    using System;
    using System.IO;

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

            double[,] dataVals = new double[10,7];

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

        /// <summary>
        /// Printing out the genuine scores to the console screen
        /// </summary>
        /// <param name="genScore">The genuine scores that are to be printed out</param>
        public void PrintGenuineScores(double[,] genScore)
        {
            if (genScore == null)
            {
                throw new ArgumentNullException(nameof(genScore));
            }

            for (int i = 0; i < genScore.GetLength(0); i++)
            {
                for (int j = 0; j < genScore.GetLength(1); j++)
                {
                    Console.Write(genScore[i, j] + " "); 
                }

                Console.WriteLine(); 
            }
        }
    }
}