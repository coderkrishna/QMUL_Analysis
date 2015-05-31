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
        #region Static 2D Double arrays for all of the users - using the dataFilter.ParseData(string filepath) method
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
        #endregion

        #region Static Double arrays for each user - these are the mean arrays, also known as the templates
        static double[] s001_Mean;
        static double[] s002_Mean;
        static double[] s003_Mean;
        static double[] s004_Mean;
        static double[] s005_Mean;
        static double[] s006_Mean; 
        
        // Added the new users 6 through 9 - 13th May 2015
        static double[] s007_Mean;
        static double[] s008_Mean;
        static double[] s009_Mean;
        static double[] s010_Mean; 
        
        // Adding the mean vectors for users 10, 11, and 12 - 27th May 2015
        static double[] s011_Mean;
        static double[] s012_Mean;
        static double[] s013_Mean;
        static double[] s014_Mean;
        static double[] s015_Mean;
        static double[] s016_Mean;
        static double[] s017_Mean;
        static double[] s018_Mean;
        static double[] s019_Mean;
        static double[] s020_Mean;
        #endregion

        #region Here having the static 2D double arrays for the genuine scores of each user
        // Adding the genuine scores for users 1 through 12 - 29th May 2015
        static double[,] s001_Gen;
        static double[,] s002_Gen;
        static double[,] s003_Gen;
        static double[,] s004_Gen;
        static double[,] s005_Gen;
        static double[,] s006_Gen;
        static double[,] s007_Gen;
        static double[,] s008_Gen;
        static double[,] s009_Gen;
        static double[,] s010_Gen;
        static double[,] s011_Gen;
        static double[,] s012_Gen;

        // Adding the genuine scores for users 13 through 20 - 29th May 2015 @ 5:34 pm
        static double[,] s013_Gen;
        static double[,] s014_Gen;
        static double[,] s015_Gen;
        static double[,] s016_Gen;
        static double[,] s017_Gen;
        static double[,] s018_Gen;
        static double[,] s019_Gen;
        static double[,] s020_Gen; 
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

            // Parsing the csv files of users 6 through 9 - 13th May 2015
            s006 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user6.csv"); 
            s007 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user7.csv");
            s008 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user8.csv");
            s009 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user9.csv");

            // Parsing the CSV files for users 10, 11, and 12 - 27th May 2015
            s010 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user10.csv");
            s011 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user11.csv");
            s012 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user12.csv"); 

            // Parsing the CSV files for users 13 through 20 - 29th May 2015
            s013 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user13.csv");
            s014 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user14.csv");
            s015 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user15.csv");
            s016 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user16.csv");
            s017 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user17.csv");
            s018 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user18.csv");
            s019 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user19.csv");
            s020 = dataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user20.csv"); 
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

            // Adding the mean vectors for users 10 through 20 here - 29th May 2015
            s010_Mean = mD.CalculateMeanVector(s010);
            s011_Mean = mD.CalculateMeanVector(s011);
            s012_Mean = mD.CalculateMeanVector(s012);
            s013_Mean = mD.CalculateMeanVector(s013);
            s014_Mean = mD.CalculateMeanVector(s014);
            s015_Mean = mD.CalculateMeanVector(s015);
            s016_Mean = mD.CalculateMeanVector(s016);
            s017_Mean = mD.CalculateMeanVector(s017);
            s018_Mean = mD.CalculateMeanVector(s018);
            s019_Mean = mD.CalculateMeanVector(s019);
            s020_Mean = mD.CalculateMeanVector(s020); 
            #endregion

            // This code region is designated for the calculations of the genuine scores (20 so far) - 29th May 2015
            #region Calculating the genuine scores for each user
            s001_Gen = mD.CalculateGenuineScores(s001, s001_Mean);
            s002_Gen = mD.CalculateGenuineScores(s002, s002_Mean);
            s003_Gen = mD.CalculateGenuineScores(s003, s003_Mean);
            s004_Gen = mD.CalculateGenuineScores(s004, s004_Mean);
            s005_Gen = mD.CalculateGenuineScores(s005, s005_Mean);
            s006_Gen = mD.CalculateGenuineScores(s006, s006_Mean);
            s007_Gen = mD.CalculateGenuineScores(s007, s007_Mean);
            s008_Gen = mD.CalculateGenuineScores(s008, s008_Mean);
            s009_Gen = mD.CalculateGenuineScores(s009, s009_Mean);
            s010_Gen = mD.CalculateGenuineScores(s010, s010_Mean);
            s011_Gen = mD.CalculateGenuineScores(s011, s011_Mean);
            s012_Gen = mD.CalculateGenuineScores(s012, s012_Mean);
            s013_Gen = mD.CalculateGenuineScores(s013, s013_Mean);
            s014_Gen = mD.CalculateGenuineScores(s014, s014_Mean);
            s015_Gen = mD.CalculateGenuineScores(s015, s015_Mean);
            s016_Gen = mD.CalculateGenuineScores(s016, s016_Mean);
            s017_Gen = mD.CalculateGenuineScores(s017, s017_Mean);
            s018_Gen = mD.CalculateGenuineScores(s018, s018_Mean);
            s019_Gen = mD.CalculateGenuineScores(s019, s019_Mean);
            s020_Gen = mD.CalculateGenuineScores(s020, s020_Mean); 
            #endregion

            // Printing out a test
            for (int i = 0; i < s001.GetLength(0); i++)
            {
                for (int j = 0; j < s001.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", s001_Gen[i, j])); 
                }
                Console.WriteLine(); 
            }
        }
        #endregion
    }
}