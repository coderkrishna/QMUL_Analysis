/*
 * Author: Pranav S. Krishnamurthy
 * 
 * File Name: EuclideanDistance.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- ---------------
 * 1.0      07/06/2015  PKR     Original Version
 * 1.1      12/06/2015  PKR     Updating various aspects with regards to in-code documentation
 * 1.2      19/06/2015  PKR     Cleaning up the in-code documentation and applying most of the comments at the top of the file in the header. 
 * 1.2.1    21/06/2015  PKR     Renamed some variables in this class, and made sure all code compiled, removed any unused using statements
 * 1.2.2    21/06/2015  PKR     Now writing the method to calculate the genuine scores for the EuclideanVerifier - that is done.
 * 1.3      22/06/2015  PKR     Writing the method the to calculate the impostor scores for the users.
 * 1.4      23/06/2015  PKR     Changing the method signature (method parameters order) to be fitting with the way that variables are declared in Program.cs file. 
 * 2.0      05/09/2015  PKR     Adding the EuclideanDistance.cs class file to the OperationsLib .dll project
 * 2.1      23/03/2018  PKR     Adding the methods to calculate the false reject rate and cleaning up the code
 */

using System;

namespace OperationsLib
{
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
        /// The method that calculates the genuine scores as defined by 
        /// the normalized Euclidean Verifier
        /// </summary>
        /// <param name="s001">Raw 2D double array</param>
        /// <param name="s001Mean">The template vector</param>
        /// <returns>The genuine scores as calculated by the Euclidean Verifier</returns>
        public double[,] CalculateGenuineScores(double[,] s001, double[] s001Mean)
        {
            double[,] Differences = new double[s001.GetLength(0), s001.GetLength(1)];

            for (int i = 0; i < s001.GetLength(0); i++)
            {
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    Differences[i, j] += Math.Sqrt(Math.Pow((s001[i, j] - s001Mean[j]), 2) / 10.0);
                }
            }

            return Differences;
        }

        /// <summary>
        /// This method will calculate the impostor scores for each user
        /// </summary>
        /// <param name="s001Mean">The mean vector for the user</param>
        /// <param name="s002">The raw data of the user</param>
        /// <returns>The zero-effort impostor scores for a specific user</returns>
        public double[,] CalculateImpostorScores(double[] s001Mean, double[,] s002)
        {
            double[,] impostorScoresMatrix = new double[s002.GetLength(0), s002.GetLength(1)];

            for (int i = 0; i < s002.GetLength(0); i++)
            {
                for (int j = 0; j < s002.GetLength(1); j++)
                {
                    // This is populating the 2D array
                    impostorScoresMatrix[i, j] += Math.Sqrt(Math.Pow((s002[i, j] - s001Mean[j]), 2) / 10.0);
                }
            }

            return impostorScoresMatrix;
        }

        public double CalculateFalseRejectRate(double[,] s001Gen, int N)
        {
            Console.Write("Enter your threshold T to find the False Reject Rate for " + N + " samples." + Environment.NewLine + "T = ");
            double threshold_FRR = double.Parse(Console.ReadLine());

            int impostor = 0, genuine = 0;
            int FRR_Total = N * 100;

            // Using nested for loop to find out where the false reject rates occur
            // The logic here is a little funky, but it works somehow
            for (int i = 0; i < s001Gen.GetLength(0); i++)
            {
                for (int j = 0; j < s001Gen.GetLength(1); j++)
                {
                    if (threshold_FRR <= s001Gen[i,j])
                    {
                        impostor++;
                    }
                    else
                    {
                        genuine++;
                    }
                }
            }

            Console.Write(impostor + " scores which have been marked as impostor out of " + FRR_Total + " scores.");

            double FRR = Convert.ToDouble(impostor) / FRR_Total;

            Console.Write("The false reject rate, FRR = " + FRR + " with N = " + N + " samples at the threshold T = " + threshold_FRR + Environment.NewLine);

            return FRR; 
        }
    }
}