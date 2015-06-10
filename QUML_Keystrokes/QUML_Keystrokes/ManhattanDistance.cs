using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // This is for the I/O

namespace QUML_Keystrokes
{
    /// <summary>
    /// Pranav S. Krishnamurthy
    /// Date Created: 5th May 2015
    /// This class will now  be used for calculating the Manhattan Distance for the various parameters and will be returning
    /// back to the Main driver class when it is appropriately done so.
    /// </summary>
    public class ManhattanDistance
    {
        /// <summary>
        /// This is simply a test method which will now become obsolete
        /// aka deprecated
        /// </summary>
        [Obsolete("This method will now become deprecated")]
        public void Test()
        {
            Console.WriteLine("You have now hit the Manhattan Distance Class"); 
        }

        /// <summary>
        /// This is the method that will print out the original data. 
        /// </summary>
        /// <param name="s001">Original 2D double array (aka raw data)</param>
        [Obsolete("This method will not be needed since there is a print code written in the main program itself.")]
        public void Print(double[,] s001)
        {
            // This will now iterate through the 2D array.
 
            // Going through the rows
            for (int i = 0; i < s001.GetLength(0); i++)
            {
                // Going through the columns
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    // Printing out the contents
                    Console.Write(string.Format("{0} ", s001[i, j]));
                }

                // New line after each line has been printed out
                Console.Write(Environment.NewLine);
            } 
        }

        /// <summary>
        /// This method will calculate the mean vector for the user file that I have already specified. 
        /// </summary>
        /// <param name="s001">This is the 2D double array that is already created from the user CSV file.</param>
        /// <returns>What is returned is a 1D array (or a normal array) that is of type double that represents the mean vector.</returns>
        public double[] CalculateMeanVector(double[,] s001)
        {
            #region Creating two single dimension double arrays
            double[] sum = new double[s001.GetLength(1)];
            double[] mean = new double[s001.GetLength(1)];
            #endregion

            // Iterating over the 2D array in its entirety
            for (int i = 0; i < s001.GetLength(0); i++)
            {
                // Iterate over the columns of the 2D array so that it can be able to properly calculate the sum and then the mean
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    // Going from 2D to a 1D array, by doing a column-wise addition. 
                    sum[j] += s001[i, j]; 
                }
            }

            // Now to calculate the mean vector
            for (int z = 0; z < sum.Length; z++)
            {
                // Each value of the mean array is divided by n = 10 [The number of features]
                mean[z] = sum[z] / 10; 
            }

            // This is the return statement of the method. 
            return mean;
        }

        /// <summary>
        /// This is the method to calculate the genuine scores given the following parameters
        /// </summary>
        /// <param name="s001">The original user data that is in the form of a 2D double array</param>
        /// <param name="s001Mean">The mean vector that is formed from the original user data.</param>
        /// <returns>The 2D double array of genuine scores</returns>
        public double[,] CalculateGenuineScores(double[,] s001, double[] s001Mean)
        {
            // Creating the variable for the Genuine Scores here. (Local variable)
            double[,] genScoreMatrix = new double[s001.GetLength(0), s001.GetLength(1)];

            // Iterating over the 2D double array.
            for (int i = 0; i < s001.GetLength(0); i++)
            {
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    // This is populating the 2D double array of genuine scores. - Make sure to that the mean's 
                    // indeces are on the indeces of the inner most loop (31st May 2015)
                    genScoreMatrix[i, j] += (Math.Abs(s001[i, j] - s001Mean[j])) / 10.0;
                }
            }

            // Returns the Genuine Scores that are being calculated by the Manhattan Distance class
            return genScoreMatrix; 
        }

        /// <summary>
        /// This is the method where the zero-effort impostor scores are calculated.
        /// Zero-Effort means that the training data (used for Genuine Scores) and
        /// the testing data (used for Impostor Scores) are all in the same data set. 
        /// </summary>
        /// <param name="s001Mean">The mean of the user for which we are calculating impostor scores</param>
        /// <param name="s002">Data that will be used as test data, which comes from another user</param>
        /// <returns>The impostor scores for a specific user will be returned</returns>
        public double[,] CalculateImpostorScores(double[] s001Mean, double[,] s002)
        {
            // Creating the variable for the Impostor scores here (local variable). 
            double[,] impScoreMatrix = new double[s002.GetLength(0), s002.GetLength(1)]; 

            /*
             * Iterating over the test vector (s002 as the test vector), and going over
             * each row and column, making sure that each and every element is accessed
             * and that the correct mathematical operations are being performed and the
             * results can be double-checked later on.  
             */
            for (int i = 0; i < s002.GetLength(0); i++)
            {
                for (int j = 0; j < s002.GetLength(1); j++)
                {
                    // Performing the calculations and populating the impScoreMatrix
                    impScoreMatrix[i, j] += (Math.Abs(s002[i, j] - s001Mean[j])) / 10.0; 
                }
            }

            // Returning the results of the impostor score matrix
            return impScoreMatrix; 
        }
    }
}