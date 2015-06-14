/* Below is a header that I plan to use from now on with any code that I plan to write
 * Author: Pranav Krishnamurthy
 * 
 * File Name: Program.cs
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
 * 1.4.1    12/06/2015  PKR     Adding the static variables for more users, will have to populate all of them soon. 
 * 1.4.2    12/06/2015  PKR     Added users 24 through 26 in-code right now. 
 * 1.4.3    12/06/2015  PKR     Adding users 27 through 30 in the repository, declared and initialized the 2D double arrays for users 27-30
 * 1.4.4    13/06/2015  PKR     Now after initializing users 27-30, calculating their mean vectors and their genuine scores
 * 1.4.5    13/06/2015  PKR     Initializing the impostor scores for users 1 through 5, and will also be adding more user data users 31 and 32
 * 1.4.6    13/06/2015  PKR     Adding user 33 data and also now populating the impostor scores arrays. 
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
        #region Static 2D double arrays that will be used/created
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

        // Adding users 24 through 26 - 12th June 2015
        static double[,] s024;
        static double[,] s025;
        static double[,] s026; 

        // Adding users 27 through 30 - 12th June 2015
        static double[,] s027;
        static double[,] s028;
        static double[,] s029;
        static double[,] s030;

        // Adding users 31,32, and 33 - 13th June 2015
        static double[,] s031;
        static double[,] s032;
        static double[,] s033;
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

        // Adding the mean vectors for users 24 through 26 - 12th June 2015
        static double[] s024Mean;
        static double[] s025Mean;
        static double[] s026Mean; 

        // Adding the mean vectors for users 27 through 30 - 12th June 2015
        static double[] s027Mean;
        static double[] s028Mean;
        static double[] s029Mean;
        static double[] s030Mean;

        // Adding the mean vectors for users 31 and 32, and 33 - 13th June 2015
        static double[] s031Mean;
        static double[] s032Mean;
        static double[] s033Mean;
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

        // Adding the genuine scores for users 24 through 26 - 12th June 2015
        static double[,] s024Gen;
        static double[,] s025Gen;
        static double[,] s026Gen;

        // Adding the genuine scores users 27 through 30 - 13th June 2015
        static double[,] s027Gen;
        static double[,] s028Gen;
        static double[,] s029Gen;
        static double[,] s030Gen;

        // Adding the genuine scores user 31 and 32 and 33 - 13th June 2015
        static double[,] s031Gen;
        static double[,] s032Gen;
        static double[,] s033Gen;
        #endregion

        #region These are the impostor scores for each user combination
        #region Having static 2D double arrays for the impostor scores with user 1 as the template
        static double[,] impostorScoresUser1User2;
        static double[,] impostorScoresUser1User3;
        static double[,] impostorScoresUser1User4;
        static double[,] impostorScoresUser1User5;
        static double[,] impostorScoresUser1User6;
        static double[,] impostorScoresUser1User7;
        static double[,] impostorScoresUser1User8;
        static double[,] impostorScoresUser1User9;
        static double[,] impostorScoresUser1User10;
        static double[,] impostorScoresUser1User11;
        static double[,] impostorScoresUser1User12;
        static double[,] impostorScoresUser1User13;
        static double[,] impostorScoresUser1User14;
        static double[,] impostorScoresUser1User15;
        static double[,] impostorScoresUser1User16;
        static double[,] impostorScoresUser1User17;
        static double[,] impostorScoresUser1User18;
        static double[,] impostorScoresUser1User19;
        static double[,] impostorScoresUser1User20;
        static double[,] impostorScoresUser1User21;
        static double[,] impostorScoresUser1User22;
        static double[,] impostorScoresUser1User23;
        static double[,] impostorScoresUser1User24;
        static double[,] impostorScoresUser1User25;
        static double[,] impostorScoresUser1User26;
        static double[,] impostorScoresUser1User27;
        static double[,] impostorScoresUser1User28;
        static double[,] impostorScoresUser1User29;
        static double[,] impostorScoresUser1User30;
        static double[,] impostorScoresUser1User31;
        static double[,] impostorScoresUser1User32;
        static double[,] impostorScoresUser1User33;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 2 as the template
        static double[,] impostorScoresUser2User1;
        static double[,] impostorScoresUser2User3;
        static double[,] impostorScoresUser2User4;
        static double[,] impostorScoresUser2User5;
        static double[,] impostorScoresUser2User6;
        static double[,] impostorScoresUser2User7;
        static double[,] impostorScoresUser2User8;
        static double[,] impostorScoresUser2User9;
        static double[,] impostorScoresUser2User10;
        static double[,] impostorScoresUser2User11;
        static double[,] impostorScoresUser2User12;
        static double[,] impostorScoresUser2User13;
        static double[,] impostorScoresUser2User14;
        static double[,] impostorScoresUser2User15;
        static double[,] impostorScoresUser2User16;
        static double[,] impostorScoresUser2User17;
        static double[,] impostorScoresUser2User18;
        static double[,] impostorScoresUser2User19;
        static double[,] impostorScoresUser2User20;
        static double[,] impostorScoresUser2User21;
        static double[,] impostorScoresUser2User22;
        static double[,] impostorScoresUser2User23;
        static double[,] impostorScoresUser2User24;
        static double[,] impostorScoresUser2User25;
        static double[,] impostorScoresUser2User26;
        static double[,] impostorScoresUser2User27;
        static double[,] impostorScoresUser2User28;
        static double[,] impostorScoresUser2User29;
        static double[,] impostorScoresUser2User30;
        static double[,] impostorScoresUser2User31;
        static double[,] impostorScoresUser2User32;
        static double[,] impostorScoresUser2User33;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 3 as the template
        static double[,] impostorScoresUser3User1;
        static double[,] impostorScoresUser3User2;
        static double[,] impostorScoresUser3User4;
        static double[,] impostorScoresUser3User5;
        static double[,] impostorScoresUser3User6;
        static double[,] impostorScoresUser3User7;
        static double[,] impostorScoresUser3User8;
        static double[,] impostorScoresUser3User9;
        static double[,] impostorScoresUser3User10;
        static double[,] impostorScoresUser3User11;
        static double[,] impostorScoresUser3User12;
        static double[,] impostorScoresUser3User13;
        static double[,] impostorScoresUser3User14;
        static double[,] impostorScoresUser3User15;
        static double[,] impostorScoresUser3User16;
        static double[,] impostorScoresUser3User17;
        static double[,] impostorScoresUser3User18;
        static double[,] impostorScoresUser3User19;
        static double[,] impostorScoresUser3User20;
        static double[,] impostorScoresUser3User21;
        static double[,] impostorScoresUser3User22;
        static double[,] impostorScoresUser3User23;
        static double[,] impostorScoresUser3User24;
        static double[,] impostorScoresUser3User25;
        static double[,] impostorScoresUser3User26;
        static double[,] impostorScoresUser3User27;
        static double[,] impostorScoresUser3User28;
        static double[,] impostorScoresUser3User29;
        static double[,] impostorScoresUser3User30;
        static double[,] impostorScoresUser3User31;
        static double[,] impostorScoresUser3User32;
        static double[,] impostorScoresUser3User33;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 4 as the template
        static double[,] impostorScoresUser4User1;
        static double[,] impostorScoresUser4User2;
        static double[,] impostorScoresUser4User3;
        static double[,] impostorScoresUser4User5;
        static double[,] impostorScoresUser4User6;
        static double[,] impostorScoresUser4User7;
        static double[,] impostorScoresUser4User8;
        static double[,] impostorScoresUser4User9;
        static double[,] impostorScoresUser4User10;
        static double[,] impostorScoresUser4User11;
        static double[,] impostorScoresUser4User12;
        static double[,] impostorScoresUser4User13;
        static double[,] impostorScoresUser4User14;
        static double[,] impostorScoresUser4User15;
        static double[,] impostorScoresUser4User16;
        static double[,] impostorScoresUser4User17;
        static double[,] impostorScoresUser4User18;
        static double[,] impostorScoresUser4User19;
        static double[,] impostorScoresUser4User20;
        static double[,] impostorScoresUser4User21;
        static double[,] impostorScoresUser4User22;
        static double[,] impostorScoresUser4User23;
        static double[,] impostorScoresUser4User24;
        static double[,] impostorScoresUser4User25;
        static double[,] impostorScoresUser4User26;
        static double[,] impostorScoresUser4User27;
        static double[,] impostorScoresUser4User28;
        static double[,] impostorScoresUser4User29;
        static double[,] impostorScoresUser4User30;
        static double[,] impostorScoresUser4User31;
        static double[,] impostorScoresUser4User32;
        static double[,] impostorScoresUser4User33;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 5 as the template
        static double[,] impostorScoresUser5User1;
        static double[,] impostorScoresUser5User2;
        static double[,] impostorScoresUser5User3;
        static double[,] impostorScoresUser5User4;
        static double[,] impostorScoresUser5User6;
        static double[,] impostorScoresUser5User7;
        static double[,] impostorScoresUser5User8;
        static double[,] impostorScoresUser5User9;
        static double[,] impostorScoresUser5User10;
        static double[,] impostorScoresUser5User11;
        static double[,] impostorScoresUser5User12;
        static double[,] impostorScoresUser5User13;
        static double[,] impostorScoresUser5User14;
        static double[,] impostorScoresUser5User15;
        static double[,] impostorScoresUser5User16;
        static double[,] impostorScoresUser5User17;
        static double[,] impostorScoresUser5User18;
        static double[,] impostorScoresUser5User19;
        static double[,] impostorScoresUser5User20;
        static double[,] impostorScoresUser5User21;
        static double[,] impostorScoresUser5User22;
        static double[,] impostorScoresUser5User23;
        static double[,] impostorScoresUser5User24;
        static double[,] impostorScoresUser5User25;
        static double[,] impostorScoresUser5User26;
        static double[,] impostorScoresUser5User27;
        static double[,] impostorScoresUser5User28;
        static double[,] impostorScoresUser5User29;
        static double[,] impostorScoresUser5User30;
        static double[,] impostorScoresUser5User31;
        static double[,] impostorScoresUser5User32;
        static double[,] impostorScoresUser5User33;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 6 as the template
        static double[,] impostorScoresUser6User1;
        static double[,] impostorScoresUser6User2;
        static double[,] impostorScoresUser6User3;
        static double[,] impostorScoresUser6User4;
        static double[,] impostorScoresUser6User5;
        static double[,] impostorScoresUser6User7;
        static double[,] impostorScoresUser6User8;
        static double[,] impostorScoresUser6User9;
        static double[,] impostorScoresUser6User10;
        static double[,] impostorScoresUser6User11;
        static double[,] impostorScoresUser6User12;
        static double[,] impostorScoresUser6User13;
        static double[,] impostorScoresUser6User14;
        static double[,] impostorScoresUser6User15;
        static double[,] impostorScoresUser6User16;
        static double[,] impostorScoresUser6User17;
        static double[,] impostorScoresUser6User18;
        static double[,] impostorScoresUser6User19;
        static double[,] impostorScoresUser6User20;
        static double[,] impostorScoresUser6User21;
        static double[,] impostorScoresUser6User22;
        static double[,] impostorScoresUser6User23;
        static double[,] impostorScoresUser6User24;
        static double[,] impostorScoresUser6User25;
        static double[,] impostorScoresUser6User26;
        static double[,] impostorScoresUser6User27;
        static double[,] impostorScoresUser6User28;
        static double[,] impostorScoresUser6User29;
        static double[,] impostorScoresUser6User30;
        static double[,] impostorScoresUser6User31;
        static double[,] impostorScoresUser6User32;
        static double[,] impostorScoresUser6User33;
        #endregion
        #endregion
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

            // Inserting the CSV files to be parsed for users 24 through 26 - 12th June 2015
            s024 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user24.csv");
            s025 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user25.csv");
            s026 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user26.csv");

            // Inserting the CSV files to be parsed for user 27 through 30 - 12th June 2015
            s027 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user27.csv");
            s028 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user28.csv");
            s029 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user29.csv");
            s030 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user30.csv");

            // Inserting the CSV files to be parsed for users 31 and 32 and 33 - 13th June 2015
            s031 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user31.csv");
            s032 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user32.csv");
            s033 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user33.csv");
            #endregion

            Console.WriteLine("Now choose your verifier: " + Environment.NewLine + "0 for Manhattan" + Environment.NewLine + "1 for Euclidean" + Environment.NewLine + "2 for Scaled Manhattan" + Environment.NewLine + "3 for Scaled Euclidean, or" + Environment.NewLine + "4 to Quit.");

            // The input condition that will be the parameters for the switch statement that follows this. 
            string input = Console.ReadLine();

            /*
             * The user option determines which class, and methods are executed 
             * when and then further user input will be determined if necessary
             * for further calculations. 
             */
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

            // Adding the mean vectors for users 24 through 26 - 12th June 2015
            s024Mean = ManhDist.CalculateMeanVector(s024);
            s025Mean = ManhDist.CalculateMeanVector(s025);
            s026Mean = ManhDist.CalculateMeanVector(s026); 

            // Adding the mean vectors for users 27 through 30 - 13th June 2015
            s027Mean = ManhDist.CalculateMeanVector(s027);
            s028Mean = ManhDist.CalculateMeanVector(s028);
            s029Mean = ManhDist.CalculateMeanVector(s029);
            s030Mean = ManhDist.CalculateMeanVector(s030); 

            // Adding the mean vectors for users 31 and 32 and 33 - 13th June 2015
            s031Mean = ManhDist.CalculateMeanVector(s031);
            s032Mean = ManhDist.CalculateMeanVector(s032);
            s033Mean = ManhDist.CalculateMeanVector(s033);
            #endregion

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

            // Adding the genuine scores for users 24 through 26 - 12th June 2015
            s024Gen = ManhDist.CalculateGenuineScores(s024, s024Mean);
            s025Gen = ManhDist.CalculateGenuineScores(s025, s025Mean);
            s026Gen = ManhDist.CalculateGenuineScores(s026, s026Mean); 

            // Adding the genuine scores for users 27 through 30 - 13th June 2015
            s027Gen = ManhDist.CalculateGenuineScores(s027, s027Mean);
            s028Gen = ManhDist.CalculateGenuineScores(s028, s028Mean);
            s029Gen = ManhDist.CalculateGenuineScores(s029, s029Mean);
            s030Gen = ManhDist.CalculateGenuineScores(s030, s030Mean); 

            // Adding the genuine scores for users 31 and 32 - 13th June 2015
            s031Gen = ManhDist.CalculateGenuineScores(s031, s031Mean);
            s032Gen = ManhDist.CalculateGenuineScores(s032, s032Mean);
            s033Gen = ManhDist.CalculateGenuineScores(s033, s033Mean); 
            #endregion

            /*
             * Now this is where I will also calculate the impostor scores here.
             * The parameters are the mean vector of the first user, and the 
             * raw scores of the other users.  This is also known as a zero
             * effort attack because all the training data and testing data are
             * in the same place. 
             */
            #region Calculating the impostor scores next - and populating them
            #region User 1 Impostor Scores
            impostorScoresUser1User2 = ManhDist.CalculateImpostorScores(s001Mean, s002);
            impostorScoresUser1User3 = ManhDist.CalculateImpostorScores(s001Mean, s003);
            impostorScoresUser1User4 = ManhDist.CalculateImpostorScores(s001Mean, s004);
            impostorScoresUser1User5 = ManhDist.CalculateImpostorScores(s001Mean, s005);
            impostorScoresUser1User6 = ManhDist.CalculateImpostorScores(s001Mean, s006);
            impostorScoresUser1User7 = ManhDist.CalculateImpostorScores(s001Mean, s007);
            impostorScoresUser1User8 = ManhDist.CalculateImpostorScores(s001Mean, s008);
            impostorScoresUser1User9 = ManhDist.CalculateImpostorScores(s001Mean, s009);
            impostorScoresUser1User10 = ManhDist.CalculateImpostorScores(s001Mean, s010);
            impostorScoresUser2User11 = ManhDist.CalculateImpostorScores(s001Mean, s011);
            impostorScoresUser1User12 = ManhDist.CalculateImpostorScores(s001Mean, s012);
            impostorScoresUser1User13 = ManhDist.CalculateImpostorScores(s001Mean, s013);
            impostorScoresUser1User14 = ManhDist.CalculateImpostorScores(s001Mean, s014);
            impostorScoresUser1User15 = ManhDist.CalculateImpostorScores(s001Mean, s015);
            impostorScoresUser1User16 = ManhDist.CalculateImpostorScores(s001Mean, s016);
            impostorScoresUser1User17 = ManhDist.CalculateImpostorScores(s001Mean, s017);
            impostorScoresUser1User18 = ManhDist.CalculateImpostorScores(s001Mean, s018);
            impostorScoresUser1User19 = ManhDist.CalculateImpostorScores(s001Mean, s019);
            impostorScoresUser1User20 = ManhDist.CalculateImpostorScores(s001Mean, s020);
            impostorScoresUser1User21 = ManhDist.CalculateImpostorScores(s001Mean, s021);
            impostorScoresUser1User22 = ManhDist.CalculateImpostorScores(s001Mean, s022);
            impostorScoresUser1User23 = ManhDist.CalculateImpostorScores(s001Mean, s023);
            impostorScoresUser1User24 = ManhDist.CalculateImpostorScores(s001Mean, s024);
            impostorScoresUser1User25 = ManhDist.CalculateImpostorScores(s001Mean, s025);
            impostorScoresUser1User26 = ManhDist.CalculateImpostorScores(s001Mean, s026);
            impostorScoresUser1User27 = ManhDist.CalculateImpostorScores(s001Mean, s027);
            impostorScoresUser1User28 = ManhDist.CalculateImpostorScores(s001Mean, s028);
            impostorScoresUser1User29 = ManhDist.CalculateImpostorScores(s001Mean, s029);
            impostorScoresUser1User30 = ManhDist.CalculateImpostorScores(s001Mean, s030);
            impostorScoresUser1User31 = ManhDist.CalculateImpostorScores(s001Mean, s031);
            impostorScoresUser1User32 = ManhDist.CalculateImpostorScores(s001Mean, s032);
            impostorScoresUser1User33 = ManhDist.CalculateImpostorScores(s001Mean, s033);
            #endregion

            #region User 2 Impostor Scores
            
            #endregion
            #endregion
        }
        #endregion
    }
}