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
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUML_Keystrokes
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
    }
}