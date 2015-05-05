using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // This is for the I/O

namespace QUML_Keystrokes
{
    /// <summary>
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
        /// This method will calculate the mean vector for the user
        /// </summary>
        /// <param name="s001"></param>
        /// <returns></returns>
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
                    // Going from 2D to a 1D array.
                    sum[j] += s001[i, j]; 
                }
            }

            // Now to calculate the mean vector
            for (int z = 0; z < sum.Length; z++)
            {
                mean[z] = sum[z] / 10; 
            }

            return mean;
        }
    }
}
