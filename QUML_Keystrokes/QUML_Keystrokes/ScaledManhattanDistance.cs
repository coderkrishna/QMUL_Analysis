/* 
 * Author: Pranav S. Krishnamurthy
 * 
 * File Name: ScaledManhattanDistance.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- --------------
 * 1.0      29/06/2015  PKR     The creation of the Scaled Manhattan Distance class file - Used for calculating the scaled manhattan distance for this solution.
 * 1.0.1    29/06/2015  PKR     Now updating the in-code documentation, and also writing the CalculateMeanVectors(double[,] s001); method
 * 1.0.2    29/06/2015  PKR     Updating the in-code documentation
 * 1.1      03/07/2015  PKR     Writing the method to calculate the standard deviation of the user data.
 * 1.2      03/07/2015  PKR     Completed the method to calculate the standard deviation given the inputs of the user data and the mean vector of the user
 * 1.3      08/07/2015  PKR     Right now will be writing the method to calculate the genuine scores under the Scaled Manhattan Verifier
 * 1.4      14/07/2015  PKR     Will be writing the CalculateImpostorScores method to be able to return the calculations properly
 * 1.4.1    30/08/2015  PKR     Updating the in-code documentation where it is appropriate
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUML_Keystrokes
{
    public class ScaledManhattanDistance
    {
        /// <summary>
        /// As with the other verifiers, the first step with this verifier is the same. 
        /// Calculate the mean vector, or the template vector.
        /// </summary>
        /// <param name="s001">The user data in 2D double array</param>
        /// <returns>The template vector of the user</returns>
        public double[] CalculateMeanVector(double[,] s001)
        {
            double[] Sum = new double[s001.GetLength(1)];
            double[] Mean = new double[s001.GetLength(1)];
            
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
        /// This is the method that will be calculating the standard deviation
        /// given the mean vector the the raw user data extracted from the csv
        /// files
        /// </summary>
        /// <param name="s001">The original user data which has been extracted from the CSV</param>
        /// <param name="s001Mean">This is the mean vector that has been previously calculated in the code written above</param>
        /// <returns>The standard deviation vector of the user</returns>
        public double[] CalculateStandardDeviation(double[] s001Mean, double[,] s001)
        {
            double[] variance = new double[s001.GetLength(1)];
            double[] stdDev = new double[s001.GetLength(1)];

            for (int i = 0; i < s001.GetLength(0); i++)
            {
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    variance[j] += Math.Pow((s001[i, j] - s001Mean[j]), 2); 
                }
            }

            for (int k = 0; k < stdDev.Length; k++)
            {
                stdDev[k] += Math.Sqrt(variance[k]) / 10; 
            }

            return stdDev; 
        }

        /// <summary>
        /// This method will now be calculating the genuine scores
        /// under the Scaled Manhattan Verifier
        /// </summary>
        /// <param name="s001Mean">The mean vector</param>
        /// <param name="stdDevUser1">The standard deviation vector</param>
        /// <param name="s001">User data</param>
        /// <returns>The genuine scores</returns>
        public double[,] CalculateGenuineScores(double[] s001Mean, double[] stdDevUser1, double[,] s001)
        {
            double[,] genuineScores = new double[s001.GetLength(0), s001.GetLength(1)];

            for (int i = 0; i < s001.GetLength(0); i++)
            {
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    genuineScores[i, j] += 0.1 * (Math.Abs(s001[i, j] - s001Mean[j]) / stdDevUser1[j]); 
                }
            }

            return genuineScores; 
        }

        /// <summary>
        /// This method will be now calculating the impostor scores
        /// </summary>
        /// <param name="s001Mean">The mean vector for the user</param>
        /// <param name="stdDevUser1">The standard deviation vector for the user</param>
        /// <param name="s002">User 2, so this is going with another user (not the same)</param>
        /// <returns>The 2D double array of impostor scores</returns>
        public double[,] CalculateImpostorScores(double[] s001Mean, double[] stdDevUser1, double[,] s002)
        {
            // The impostorScores 2D double array being declared and initialized with the number of rows and columns!
            double[,] impostorScores = new double[s002.GetLength(0), s002.GetLength(1)];

            for (int i = 0; i < s002.GetLength(0); i++)
            {
                for (int j = 0; j < s002.GetLength(1); j++)
                {
                    impostorScores[i, j] += 0.1 * (Math.Abs(s002[i, j] - s001Mean[j]) / stdDevUser1[j]); 
                }
            }

            return impostorScores;
        }
    }
}