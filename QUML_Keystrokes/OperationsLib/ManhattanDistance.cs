/*
 * Author: Pranav S. Krishnamurthy
 * 
 * File Name: ManhattanDistance.cs
 * 
 * Version History
 * 
 * Version  Date        Author     Description
 * -------  ----------  ------- ---------------
 * 1.0      05/05/2015  PKR     Original Version
 * 1.2      11/06/2015  PKR     Calculated the genuine and impostor scores
 * 1.3      13/06/2015  PKR     Organizing the various using statements, and updating the in-code documentation
 * 1.3.1    23/06/2015  PKR     Right now having the in-code documentation for this class being cleaned up
 * 1.3.2    25/06/2015  PKR     Cleaning up the in-code documentation
 * 1.3.3.   30/08/2015  PKR     Updating the code header (first line by Author:...)
 * 2.0      05/09/2015  PKR     Adding the ManhattanDistance class file to the OperationsLib .dll project
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperationsLib
{
    public class ManhattanDistance
    {
        /// <summary>
        /// This method will calculate the mean vector for the user file that I have already specified. 
        /// </summary>
        /// <param name="s001">This is the 2D double array that is already created from the user CSV file.</param>
        /// <returns>What is returned is a 1D array (or a normal array) that is of type double that represents the mean vector.</returns>
        public double[] CalculateMeanVector(double[,] s001)
        {
            #region Creating two single dimension double arrays
            double[] Sum = new double[s001.GetLength(1)];
            double[] Mean = new double[s001.GetLength(1)];
            #endregion

            for (int i = 0; i < s001.GetLength(0); i++)
            {
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    Sum[j] += s001[i, j]; 
                }
            }

            for (int z = 0; z < Sum.Length; z++)
            {
                Mean[z] = Sum[z] / 10; 
            }

            return Mean;
        }

        /// <summary>
        /// This is the method to calculate the genuine scores given the following parameters
        /// </summary>
        /// <param name="s001">The original user data that is in the form of a 2D double array</param>
        /// <param name="s001Mean">The mean vector that is formed from the original user data.</param>
        /// <returns>The 2D double array of genuine scores</returns>
        public double[,] CalculateGenuineScores(double[,] s001, double[] s001Mean)
        {
            double[,] genScoreMatrix = new double[s001.GetLength(0), s001.GetLength(1)];

            for (int i = 0; i < s001.GetLength(0); i++)
            {
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    genScoreMatrix[i, j] += (Math.Abs(s001[i, j] - s001Mean[j])) / 10.0;
                }
            }

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
            double[,] impScoreMatrix = new double[s002.GetLength(0), s002.GetLength(1)]; 

            for (int i = 0; i < s002.GetLength(0); i++)
            {
                for (int j = 0; j < s002.GetLength(1); j++)
                {
                    impScoreMatrix[i, j] += (Math.Abs(s002[i, j] - s001Mean[j])) / 10.0; 
                }
            }

            return impScoreMatrix; 
        }
    }
}