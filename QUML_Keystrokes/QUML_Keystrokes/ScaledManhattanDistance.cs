﻿/* 
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
 * 1.2      03/07/2015  PKR     Completed the method to calculate
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
    }
}
