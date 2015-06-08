using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // This is required for the I/O with regards to text files and all that. 

namespace QUML_Keystrokes
{
    /// <summary>
    /// Author: Pranav S. Krishnamurthy
    /// Purpose: To be able to calculate the Euclidean Distance with the raw data that has been
    /// given already. 
    /// Version: 0.1
    /// Date Created: 7th June 2015
    /// </summary>
    public class EuclideanDistance
    {
        /// <summary>
        /// This method will be calculating the mean vector with the Euclidean Distance (verifier) which
        /// is another statistical measure with regards to continuous authentication/anomaly detection.
        /// </summary>
        /// <param name="s001">2D-double array of raw data</param>
        /// <returns>The mean vector (array)</returns>
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
    }
}