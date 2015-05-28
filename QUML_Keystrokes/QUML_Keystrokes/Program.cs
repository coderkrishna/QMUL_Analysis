using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // Required using statement for File I/O

///<summary>
/// Pranav S. Krishnamurthy
/// Project: Analyzing a Keystrokes data set on my own. 
/// Version: 0.2
/// Verifier: Manhattan Verifier
/// 
/// Source of the Data: http://www.eecs.qmul.ac.uk/~ccloy/downloads_keystroke100.html
///</summary>

namespace QUML_Keystrokes
{
    /// <summary>
    /// This is the main class where all of the execution will be taking place. 
    /// Right now here is what is going on:
    /// 1. DataFiltering class will be called in order to properly make sure the data is in the right format for processing
    /// 2. ManhattanDistance class will then be called for all of the data to be properly manipulated. 
    /// </summary>
    class Program
    {
        #region Static 2D Double arrays for all of the users
        static double[,] s001; 
        static double[,] s002;
        static double[,] s003;
        static double[,] s004;
        static double[,] s005;
        static double[,] s006; // Added the new users 6 through 9 - 13th May 2015
        static double[,] s007;
        static double[,] s008;
        static double[,] s009;
        static double[,] s010; // Adding the users 10, 11, and 12 - 27th May 2015
        static double[,] s011;
        static double[,] s012;
        #endregion

        #region Static Double arrays for each user - these are the mean arrays
        static double[] s001_Mean;
        static double[] s002_Mean;
        static double[] s003_Mean;
        static double[] s004_Mean;
        static double[] s005_Mean;
        static double[] s006_Mean; // Added the new users 6 through 9 - 13th May 2015
        static double[] s007_Mean;
        static double[] s008_Mean;
        static double[] s009_Mean;
        static double[] s010_Mean; // Adding the mean vectors for users 10, 11, and 12 - 27th May 2015
        static double[] s011_Mean;
        static double[] s012_Mean;
        #endregion

        /// <summary>
        /// This is the main point of the program execution. 
        /// </summary>
        static void Main(string[] args)
        {
            // Greeting of the Console
            Console.WriteLine("Welcome to the QUML Analyzer!" + Environment.NewLine);

            // Importing the DataFiltering class
            DataFiltering dataFilter = new DataFiltering(); 

            #region Data Extraction - This will be done before jumping into the use of any verifier
            s001 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user1.csv");
            s002 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user2.csv");
            s003 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user3.csv");
            s004 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user4.csv");
            s005 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user5.csv");
            s006 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user6.csv"); // Parsing the csv files of users 6 through 9 - 13th May 2015
            s007 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user7.csv");
            s008 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user8.csv");
            s009 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user9.csv");

            // Parsing the CSV files for users 10, 11, and 12 - 27th May 2015
            s010 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user10.csv");
            s011 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user11.csv");
            s012 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QUML_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user12.csv"); 
            #endregion

            Console.WriteLine("Now choose your verifier: " + Environment.NewLine + "0 for Manhattan" + Environment.NewLine + "1 for Euclidean" + Environment.NewLine + "2 for Scaled Manhattan" + Environment.NewLine + "3 for Scaled Euclidean, or" + Environment.NewLine + "4 to Quit.");

            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    ManhattanVerifier();
                    break;
                case "1":
                    EuclideanVerifier();
                    break; 
                case "2":
                    SMVerifier();
                    break;
                case "3":
                    SEVerifier();
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
        private static void SEVerifier()
        {
            // Temporary place holder for the time being
            Console.WriteLine("Scaled Euclidean Verifer - TBC (To Be Coded)");
        }

        /// <summary>
        /// This is the method to be executed for which the Scaled Manhattan Verifier will be executed. 
        /// </summary>
        private static void SMVerifier()
        {
            // Some temporary place holder text
            Console.WriteLine("Scaled Manhattan Verifier - TBC");
        }

        /// <summary>
        /// This is the method that will be executed when calculating the Euclidean verifier. 
        /// </summary>
        private static void EuclideanVerifier()
        {
            // Temporary place holder for the time being
            Console.WriteLine("Going to now be calculating the Euclidean verifier - TBC");
        }

        /// <summary>
        /// This method will now jump to the ManhattanDistance class file and execute those methods.
        /// </summary>
        private static void ManhattanVerifier()
        {
            // Will now be going for the Manhattan Verifier class
            ManhattanDistance mD = new ManhattanDistance();

            #region Populating the mean arrays for each user
            s001_Mean = mD.CalculateMeanVector(s001);
            s002_Mean = mD.CalculateMeanVector(s002);
            s003_Mean = mD.CalculateMeanVector(s003);
            s004_Mean = mD.CalculateMeanVector(s004);
            s005_Mean = mD.CalculateMeanVector(s005); 

            // Adding the mean vectors for users 6 through 9 here.
            s006_Mean = mD.CalculateMeanVector(s006);
            s007_Mean = mD.CalculateMeanVector(s007);
            s008_Mean = mD.CalculateMeanVector(s008);
            s009_Mean = mD.CalculateMeanVector(s009); 
            #endregion

            // Adding this code region to make the calculations
            #region Calculating the genuine scores for each user
            
            #endregion
        }
        #endregion
    }
}