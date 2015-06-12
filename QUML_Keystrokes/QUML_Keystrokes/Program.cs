/*
 * Author: Pranav Krishnamurthy
 * File Name: ManhattanDistance.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- ---------------
 * 1.0      03/05/2015  PKR     Original Version
 * 1.1      29/05/2015  PKR     Adding more users in-code and also calculating the Mean vectors under the Manhattan Distance class
 * 1.2      09/06/2015  PKR     Adding users in-code
 * 1.3      10/06/2015  PKR     More method calls from the ManhattanDistance.cs class file for calculation purposes
 * 1.2      11/06/2015  PKR     Adding more users - in the repository
 * 1.4      12/06/2015  PKR     Adding more users in-code, updating in-code documentation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // Required using statement for File I/O

///<summary>
/// Source of the Data: http://www.eecs.qmul.ac.uk/~ccloy/downloads_keystroke100.html
///</summary>

namespace QUML_Keystrokes
{
    /// <summary>
    /// This is the main class where all of the execution will be taking place. 
    /// </summary>
    class Program
    {
        #region Static 2D Double arrays for all of the users - using the DataFilter.ParseData(string filepath) method
        static double[,] s001; 
        static double[,] s002;
        static double[,] s003;
        static double[,] s004;
        static double[,] s005;

        // Added the new users 6 through 9 - 13th May 2015
        static double[,] s006; 
        static double[,] s007;
        static double[,] s008;
        static double[,] s009;

        // Adding the users 10, 11, and 12 - 27th May 2015
        static double[,] s010; 
        static double[,] s011;
        static double[,] s012;

        // Adding the users 13 through 20 - 29th May 2015
        static double[,] s013; 
        static double[,] s014;
        static double[,] s015;
        static double[,] s016;
        static double[,] s017;
        static double[,] s018;
        static double[,] s019;
        static double[,] s020; 

        // Adding the users 21 through 23 - 9th June 2015
        static double[,] s021;
        static double[,] s022;
        static double[,] s023; 
        #endregion

        #region Static Double arrays for each user - these are the mean arrays, also known as the templates
        static double[] s001Mean;
        static double[] s002Mean;
        static double[] s003Mean;
        static double[] s004Mean;
        static double[] s005Mean;
        static double[] s006Mean; 
        
        // Added the new users 6 through 9 - 13th May 2015
        static double[] s007Mean;
        static double[] s008Mean;
        static double[] s009Mean;
        static double[] s010Mean; 
        
        // Adding the mean vectors for users 10, 11, and 12 - 27th May 2015
        static double[] s011Mean;
        static double[] s012Mean;
        static double[] s013Mean;
        static double[] s014Mean;
        static double[] s015Mean;
        static double[] s016Mean;
        static double[] s017Mean;
        static double[] s018Mean;
        static double[] s019Mean;
        static double[] s020Mean;

        // Adding the mean vectors for users 21 through 23 - 9th June 2015
        static double[] s021Mean;
        static double[] s022Mean;
        static double[] s023Mean;
        #endregion

        #region Here having the static 2D double arrays for the genuine scores of each user
        // Adding the genuine scores for users 1 through 12 - 29th May 2015
        static double[,] s001Gen;
        static double[,] s002Gen;
        static double[,] s003Gen;
        static double[,] s004Gen;
        static double[,] s005Gen;
        static double[,] s006Gen;
        static double[,] s007Gen;
        static double[,] s008Gen;
        static double[,] s009Gen;
        static double[,] s010Gen;
        static double[,] s011Gen;
        static double[,] s012Gen;

        // Adding the genuine scores for users 13 through 20 - 29th May 2015 @ 5:34 pm
        static double[,] s013Gen;
        static double[,] s014Gen;
        static double[,] s015Gen;
        static double[,] s016Gen;
        static double[,] s017Gen;
        static double[,] s018Gen;
        static double[,] s019Gen;
        static double[,] s020Gen; 

        // Adding the genuine scores for users 21 through 23 - 9th June 2015
        static double[,] s021Gen;
        static double[,] s022Gen;
        static double[,] s023Gen;
        #endregion

        /// <summary>
        /// This is the main point of the program execution. 
        /// </summary>
        static void Main(string[] args)
        {
            // Greeting of the Console
            Console.WriteLine("Welcome to the QUML Analyzer!" + Environment.NewLine);

            // Importing the DataFiltering class
            DataFiltering DataFilter = new DataFiltering(); 

            #region Data Extraction - This will be done before jumping into the use of any verifier
            s001 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user1.csv");
            s002 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user2.csv");
            s003 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user3.csv");
            s004 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user4.csv");
            s005 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user5.csv");

            // Parsing the csv files of users 6 through 9 - 13th May 2015
            s006 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user6.csv"); 
            s007 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user7.csv");
            s008 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user8.csv");
            s009 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user9.csv");

            // Parsing the CSV files for users 10, 11, and 12 - 27th May 2015
            s010 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user10.csv");
            s011 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user11.csv");
            s012 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user12.csv"); 

            // Parsing the CSV files for users 13 through 20 - 29th May 2015
            s013 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user13.csv");
            s014 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user14.csv");
            s015 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user15.csv");
            s016 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user16.csv");
            s017 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user17.csv");
            s018 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user18.csv");
            s019 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user19.csv");
            s020 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user20.csv"); 

            // Inserting the CSV files to be parsed for users 21 through 23 - 9th June 2015
            s021 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user21.csv");
            s022 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user22.csv");
            s023 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user23.csv");
            #endregion

            Console.WriteLine("Now choose your verifier: " + Environment.NewLine + "0 for Manhattan" + Environment.NewLine + "1 for Euclidean" + Environment.NewLine + "2 for Scaled Manhattan" + Environment.NewLine + "3 for Scaled Euclidean, or" + Environment.NewLine + "4 to Quit.");

            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    // Accesses the Manhattan Verifier method - Accesses the ManhattanDistance.cs class file 
                    UseManhattanVerifier();
                    break;
                case "1":
                    // Accesses the Euclidean Verifier method - Accesses the EuclideanDistance.cs class file
                    UseEuclideanVerifier();
                    break; 
                case "2":
                    UseScaledManhattanVerifier();
                    break;
                case "3":
                    UseScaledEuclideanVerifier();
                    break; 
                case "4":
                    Console.WriteLine("The program will now quit. Good Bye!");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("No option selected, or input is not one of the options. Program will now quit."); 
                    break;
            }

            // Default exiting of the program
            Console.ReadKey(); 
        }

        #region Verifier calls
        /// <summary>
        /// This is the method which will jump to the Scaled Euclidean Class and then 
        /// the various methods associated with this class file will be executed.
        /// </summary>
        private static void UseScaledEuclideanVerifier()
        {
            // Temporary place holder for the time being
            Console.WriteLine("Scaled Euclidean Verifer - TBC (To Be Coded)");
        }

        /// <summary>
        /// This is the method to be executed for which the Scaled Manhattan Verifier will be executed. 
        /// </summary>
        private static void UseScaledManhattanVerifier()
        {
            // Some temporary place holder text
            Console.WriteLine("Scaled Manhattan Verifier - TBC");
        }

        /// <summary>
        /// This is the method that will be executed when calculating the Euclidean verifier, and 
        /// will now be having this method be active. 
        /// </summary>
        private static void UseEuclideanVerifier()
        {
            // Use of professional practices (coding standards) in this solution. 
            EuclideanDistance EuclidDist = new EuclideanDistance();

            #region Populating the mean arrays for each user under the Euclidean Distance method
            // Adding users 1 through 23 here - 9th June 2015

            // First users 1 through 10
            s001Mean = EuclidDist.CalculateMeanVector(s001);
            s002Mean = EuclidDist.CalculateMeanVector(s002);
            s003Mean = EuclidDist.CalculateMeanVector(s003);
            s004Mean = EuclidDist.CalculateMeanVector(s004);
            s005Mean = EuclidDist.CalculateMeanVector(s005);
            s006Mean = EuclidDist.CalculateMeanVector(s006);
            s007Mean = EuclidDist.CalculateMeanVector(s007);
            s008Mean = EuclidDist.CalculateMeanVector(s008);
            s009Mean = EuclidDist.CalculateMeanVector(s009);
            s010Mean = EuclidDist.CalculateMeanVector(s010); 

            // Next users 10 through 23
            s011Mean = EuclidDist.CalculateMeanVector(s011);
            s012Mean = EuclidDist.CalculateMeanVector(s012);
            s013Mean = EuclidDist.CalculateMeanVector(s013);
            s014Mean = EuclidDist.CalculateMeanVector(s014);
            s015Mean = EuclidDist.CalculateMeanVector(s015);
            s016Mean = EuclidDist.CalculateMeanVector(s016);
            s017Mean = EuclidDist.CalculateMeanVector(s017);
            s018Mean = EuclidDist.CalculateMeanVector(s018);
            s019Mean = EuclidDist.CalculateMeanVector(s019);
            s020Mean = EuclidDist.CalculateMeanVector(s020);
            s021Mean = EuclidDist.CalculateMeanVector(s021);
            s022Mean = EuclidDist.CalculateMeanVector(s022);
            s023Mean = EuclidDist.CalculateMeanVector(s023); 
            #endregion
        }

        /// <summary>
        /// This method will now jump to the ManhattanDistance class file and execute those methods.
        /// </summary>
        private static void UseManhattanVerifier()
        {
            // Will now be going for the Manhattan Verifier class
            ManhattanDistance ManhDist = new ManhattanDistance();

            #region Populating the mean arrays for each user
            s001Mean = ManhDist.CalculateMeanVector(s001);
            s002Mean = ManhDist.CalculateMeanVector(s002);
            s003Mean = ManhDist.CalculateMeanVector(s003);
            s004Mean = ManhDist.CalculateMeanVector(s004);
            s005Mean = ManhDist.CalculateMeanVector(s005); 

            // Adding the mean vectors for users 6 through 9 here.
            s006Mean = ManhDist.CalculateMeanVector(s006);
            s007Mean = ManhDist.CalculateMeanVector(s007);
            s008Mean = ManhDist.CalculateMeanVector(s008);
            s009Mean = ManhDist.CalculateMeanVector(s009); 

            // Adding the mean vectors for users 10 through 20 here - 29th May 2015
            s010Mean = ManhDist.CalculateMeanVector(s010);
            s011Mean = ManhDist.CalculateMeanVector(s011);
            s012Mean = ManhDist.CalculateMeanVector(s012);
            s013Mean = ManhDist.CalculateMeanVector(s013);
            s014Mean = ManhDist.CalculateMeanVector(s014);
            s015Mean = ManhDist.CalculateMeanVector(s015);
            s016Mean = ManhDist.CalculateMeanVector(s016);
            s017Mean = ManhDist.CalculateMeanVector(s017);
            s018Mean = ManhDist.CalculateMeanVector(s018);
            s019Mean = ManhDist.CalculateMeanVector(s019);
            s020Mean = ManhDist.CalculateMeanVector(s020);
 
            // Adding the mean vectors for users 21 through 23 - 9th June 2015
            s021Mean = ManhDist.CalculateMeanVector(s021);
            s022Mean = ManhDist.CalculateMeanVector(s022);
            s023Mean = ManhDist.CalculateMeanVector(s023); 
            #endregion

            /**
             * Having the genuine scores being calculated for 20 users (so far) - 29th May 2015
             * Adding the genuine scores for users 21 through 23 - 9th June 2015.  
             **/
            #region Calculating the genuine scores for each user
            s001Gen = ManhDist.CalculateGenuineScores(s001, s001Mean);
            s002Gen = ManhDist.CalculateGenuineScores(s002, s002Mean);
            s003Gen = ManhDist.CalculateGenuineScores(s003, s003Mean);
            s004Gen = ManhDist.CalculateGenuineScores(s004, s004Mean);
            s005Gen = ManhDist.CalculateGenuineScores(s005, s005Mean);
            s006Gen = ManhDist.CalculateGenuineScores(s006, s006Mean);
            s007Gen = ManhDist.CalculateGenuineScores(s007, s007Mean);
            s008Gen = ManhDist.CalculateGenuineScores(s008, s008Mean);
            s009Gen = ManhDist.CalculateGenuineScores(s009, s009Mean);
            s010Gen = ManhDist.CalculateGenuineScores(s010, s010Mean);
            s011Gen = ManhDist.CalculateGenuineScores(s011, s011Mean);
            s012Gen = ManhDist.CalculateGenuineScores(s012, s012Mean);
            s013Gen = ManhDist.CalculateGenuineScores(s013, s013Mean);
            s014Gen = ManhDist.CalculateGenuineScores(s014, s014Mean);
            s015Gen = ManhDist.CalculateGenuineScores(s015, s015Mean);
            s016Gen = ManhDist.CalculateGenuineScores(s016, s016Mean);
            s017Gen = ManhDist.CalculateGenuineScores(s017, s017Mean);
            s018Gen = ManhDist.CalculateGenuineScores(s018, s018Mean);
            s019Gen = ManhDist.CalculateGenuineScores(s019, s019Mean);
            s020Gen = ManhDist.CalculateGenuineScores(s020, s020Mean);

            // Adding the genuine scores for users 21 through 23 - 9th June 2015
            s021Gen = ManhDist.CalculateGenuineScores(s021, s021Mean);
            s022Gen = ManhDist.CalculateGenuineScores(s022, s022Mean);
            s023Gen = ManhDist.CalculateGenuineScores(s023, s023Mean); 
            #endregion
        }
        #endregion
    }
}