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
    }
}
