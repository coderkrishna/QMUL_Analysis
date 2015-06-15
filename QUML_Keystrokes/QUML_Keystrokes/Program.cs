/* Below is a header that I plan to use from now on with any code that I plan to write
 * Author: Pranav Krishnamurthy
 * 
 * File Name: Program.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- ---------------
 * 1.5.2    14/06/2015  PKR     Declaring more user variables: users 51 through 60, and then the mean templates and genuine scores later will be declared
 * 1.5.3    14/06/2015  PKR     Fixing Git issues, and also making sure to add more users to the repository  (solution)
 * 1.5.4    14/06/2015  PKR     Fixed Git issues, now initializing the 2D double arrays for users 41 through 50 and added data for 54 users so far (in solution/repo)
 * 1.5.5    15/06/2015  PKR     Git issues are fixed and right now will be adding more user data files, and also then initializing the variables (filling up the data)
 * 1.5.6    15/06/2015  PKR     Now initialized 60 users, and will be initializing the data for the mean templates, and genuine scores for the 60 users 
 * 1.5.7    15/06/2015  PKR     Right now, I will be initializing the genuine scores for users 41 through 60 before tackling the impostor scores
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// The required using statement for the conducting of I/O operations (file I/O as an example)
using System.IO;

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
        static double[,] s001; static double[,] s002;
        static double[,] s003; static double[,] s004;
        static double[,] s005;

        // Added the new users 6 through 9 - 13th May 2015
        static double[,] s006; static double[,] s007;
        static double[,] s008; static double[,] s009;

        // Adding the users 10, 11, and 12 - 27th May 2015
        static double[,] s010;  static double[,] s011; static double[,] s012;

        // Adding the users 13 through 20 - 29th May 2015
        static double[,] s013; static double[,] s014;  static double[,] s015;
        static double[,] s016; static double[,] s017;  static double[,] s018;
        static double[,] s019; static double[,] s020; 

        // Adding the users 21 through 23 - 9th June 2015
        static double[,] s021; static double[,] s022; static double[,] s023; 

        // Adding users 24 through 26 - 12th June 2015
        static double[,] s024; static double[,] s025; static double[,] s026; 

        // Adding users 27 through 30 - 12th June 2015
        static double[,] s027; static double[,] s028;
        static double[,] s029; static double[,] s030;

        // Adding users 31,32, and 33 - 13th June 2015
        static double[,] s031; static double[,] s032; static double[,] s033;

        // Adding users 34 through 40 here - 13th June 2015
        static double[,] s034; static double[,] s035; static double[,] s036;
        static double[,] s037; static double[,] s038; static double[,] s039;
        static double[,] s040;

        // Declaring the variables for users 41 through 50 - 14th June 2015
        static double[,] s041; static double[,] s042; static double[,] s043;
        static double[,] s044; static double[,] s045; static double[,] s046;
        static double[,] s047; static double[,] s048; static double[,] s049;
        static double[,] s050; 

        // Declaring variables for users 51 through 60 - 14th June 2015
        static double[,] s051; static double[,] s052; static double[,] s053;
        static double[,] s054; static double[,] s055; static double[,] s056;
        static double[,] s057; static double[,] s058; static double[,] s059;
        static double[,] s060;
        #endregion

        #region Static Double arrays for each user - these are the mean arrays, also known as the templates
        static double[] s001Mean; static double[] s002Mean; static double[] s003Mean;
        static double[] s004Mean; static double[] s005Mean; static double[] s006Mean; 
        
        // Added the new users 6 through 9 - 13th May 2015
        static double[] s007Mean; static double[] s008Mean;
        static double[] s009Mean; static double[] s010Mean; 
        
        // Adding the mean vectors for users 10, 11, and 12 - 27th May 2015
        static double[] s011Mean; static double[] s012Mean;
        static double[] s013Mean; static double[] s014Mean;
        static double[] s015Mean; static double[] s016Mean;
        static double[] s017Mean; static double[] s018Mean;
        static double[] s019Mean; static double[] s020Mean;

        // Adding the mean vectors for users 21 through 23 - 9th June 2015
        static double[] s021Mean; static double[] s022Mean; static double[] s023Mean;

        // Adding the mean vectors for users 24 through 26 - 12th June 2015
        static double[] s024Mean; static double[] s025Mean; static double[] s026Mean; 

        // Adding the mean vectors for users 27 through 30 - 12th June 2015
        static double[] s027Mean; static double[] s028Mean;
        static double[] s029Mean; static double[] s030Mean;

        // Adding the mean vectors for users 31 and 32, and 33 - 13th June 2015
        static double[] s031Mean; static double[] s032Mean; static double[] s033Mean;

        // Adding the mean vectors for user 34 through 40 - 13th June 2015
        static double[] s034Mean; static double[] s035Mean; static double[] s036Mean;
        static double[] s037Mean; static double[] s038Mean; static double[] s039Mean;
        static double[] s040Mean;

        // Declaring the mean vectors for users 41 through 60 - 14th June 2015
        static double[] s041Mean; static double[] s042Mean; static double[] s043Mean;
        static double[] s044Mean; static double[] s045Mean; static double[] s046Mean; 
        static double[] s047Mean; static double[] s048Mean; static double[] s049Mean; 
        static double[] s050Mean; static double[] s051Mean; static double[] s052Mean; 
        static double[] s053Mean; static double[] s054Mean; static double[] s055Mean; 
        static double[] s056Mean; static double[] s057Mean; static double[] s058Mean;
        static double[] s059Mean; static double[] s060Mean;
        #endregion

        #region Here having the static 2D double arrays for the genuine scores of each user
        // Adding the genuine scores for users 1 through 12 - 29th May 2015
        static double[,] s001Gen; static double[,] s002Gen; static double[,] s003Gen;
        static double[,] s004Gen; static double[,] s005Gen; static double[,] s006Gen;
        static double[,] s007Gen; static double[,] s008Gen; static double[,] s009Gen;
        static double[,] s010Gen; static double[,] s011Gen; static double[,] s012Gen;

        // Adding the genuine scores for users 13 through 20 - 29th May 2015 @ 5:34 pm
        static double[,] s013Gen; static double[,] s014Gen; static double[,] s015Gen;
        static double[,] s016Gen; static double[,] s017Gen; static double[,] s018Gen;
        static double[,] s019Gen; static double[,] s020Gen; 

        // Adding the genuine scores for users 21 through 23 - 9th June 2015
        static double[,] s021Gen; static double[,] s022Gen; static double[,] s023Gen;

        // Adding the genuine scores for users 24 through 26 - 12th June 2015
        static double[,] s024Gen; static double[,] s025Gen; static double[,] s026Gen;

        // Adding the genuine scores users 27 through 30 - 13th June 2015
        static double[,] s027Gen; static double[,] s028Gen;
        static double[,] s029Gen; static double[,] s030Gen;

        // Adding the genuine scores user 31 and 32 and 33 - 13th June 2015
        static double[,] s031Gen; static double[,] s032Gen; static double[,] s033Gen;

        // Adding the genuine scores for users 34 through 40 here - 13th June 2015
        static double[,] s034Gen; static double[,] s035Gen; static double[,] s036Gen;
        static double[,] s037Gen; static double[,] s038Gen; static double[,] s039Gen;
        static double[,] s040Gen;

        // Adding the genuine scores for users 41 through 60 here - 14th June 2015
        static double[,] s041Gen; static double[,] s042Gen; static double[,] s043Gen;
        static double[,] s044Gen; static double[,] s045Gen; static double[,] s046Gen;
        static double[,] s047Gen; static double[,] s048Gen; static double[,] s049Gen;
        static double[,] s050Gen; static double[,] s051Gen; static double[,] s052Gen;
        static double[,] s053Gen; static double[,] s054Gen; static double[,] s055Gen;
        static double[,] s056Gen; static double[,] s057Gen; static double[,] s058Gen;
        static double[,] s059Gen; static double[,] s060Gen;
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

        // The impostor score 2D double arrays with user 1 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser1User34;
        static double[,] impostorScoresUser1User35;
        static double[,] impostorScoresUser1User36;
        static double[,] impostorScoresUser1User37;
        static double[,] impostorScoresUser1User38;
        static double[,] impostorScoresUser1User39;
        static double[,] impostorScoresUser1User40;
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

        // The impostor score 2D double arrays with user 1 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser2User34;
        static double[,] impostorScoresUser2User35;
        static double[,] impostorScoresUser2User36;
        static double[,] impostorScoresUser2User37;
        static double[,] impostorScoresUser2User38;
        static double[,] impostorScoresUser2User39;
        static double[,] impostorScoresUser2User40;
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

        // The impostor score 2D double arrays with user 3 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser3User34;
        static double[,] impostorScoresUser3User35;
        static double[,] impostorScoresUser3User36;
        static double[,] impostorScoresUser3User37;
        static double[,] impostorScoresUser3User38;
        static double[,] impostorScoresUser3User39;
        static double[,] impostorScoresUser3User40;
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

        // The impostor score 2D double arrays with user 4 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser4User34;
        static double[,] impostorScoresUser4User35;
        static double[,] impostorScoresUser4User36;
        static double[,] impostorScoresUser4User37;
        static double[,] impostorScoresUser4User38;
        static double[,] impostorScoresUser4User39;
        static double[,] impostorScoresUser4User40;
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

        // The impostor score 2D double arrays with user 5 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser5User34;
        static double[,] impostorScoresUser5User35;
        static double[,] impostorScoresUser5User36;
        static double[,] impostorScoresUser5User37;
        static double[,] impostorScoresUser5User38;
        static double[,] impostorScoresUser5User39;
        static double[,] impostorScoresUser5User40;
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

        // The impostor score 2D double arrays with user 6 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser6User34;
        static double[,] impostorScoresUser6User35;
        static double[,] impostorScoresUser6User36;
        static double[,] impostorScoresUser6User37;
        static double[,] impostorScoresUser6User38;
        static double[,] impostorScoresUser6User39;
        static double[,] impostorScoresUser6User40;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 7 as the template
        static double[,] impostorScoresUser7User1;
        static double[,] impostorScoresUser7User2;
        static double[,] impostorScoresUser7User3;
        static double[,] impostorScoresUser7User4;
        static double[,] impostorScoresUser7User5;
        static double[,] impostorScoresUser7User6;
        static double[,] impostorScoresUser7User8;
        static double[,] impostorScoresUser7User9;
        static double[,] impostorScoresUser7User10;
        static double[,] impostorScoresUser7User11;
        static double[,] impostorScoresUser7User12;
        static double[,] impostorScoresUser7User13;
        static double[,] impostorScoresUser7User14;
        static double[,] impostorScoresUser7User15;
        static double[,] impostorScoresUser7User16;
        static double[,] impostorScoresUser7User17;
        static double[,] impostorScoresUser7User18;
        static double[,] impostorScoresUser7User19;
        static double[,] impostorScoresUser7User20;
        static double[,] impostorScoresUser7User21;
        static double[,] impostorScoresUser7User22;
        static double[,] impostorScoresUser7User23;
        static double[,] impostorScoresUser7User24;
        static double[,] impostorScoresUser7User25;
        static double[,] impostorScoresUser7User26;
        static double[,] impostorScoresUser7User27;
        static double[,] impostorScoresUser7User28;
        static double[,] impostorScoresUser7User29;
        static double[,] impostorScoresUser7User30;
        static double[,] impostorScoresUser7User31;
        static double[,] impostorScoresUser7User32;
        static double[,] impostorScoresUser7User33;

        // The impostor score 2D double arrays with user 7 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser7User34;
        static double[,] impostorScoresUser7User35;
        static double[,] impostorScoresUser7User36;
        static double[,] impostorScoresUser7User37;
        static double[,] impostorScoresUser7User38;
        static double[,] impostorScoresUser7User39;
        static double[,] impostorScoresUser7User40;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 8 as the template
        static double[,] impostorScoresUser8User1;
        static double[,] impostorScoresUser8User2;
        static double[,] impostorScoresUser8User3;
        static double[,] impostorScoresUser8User4;
        static double[,] impostorScoresUser8User5;
        static double[,] impostorScoresUser8User6;
        static double[,] impostorScoresUser8User7;
        static double[,] impostorScoresUser8User9;
        static double[,] impostorScoresUser8User10;
        static double[,] impostorScoresUser8User11;
        static double[,] impostorScoresUser8User12;
        static double[,] impostorScoresUser8User13;
        static double[,] impostorScoresUser8User14;
        static double[,] impostorScoresUser8User15;
        static double[,] impostorScoresUser8User16;
        static double[,] impostorScoresUser8User17;
        static double[,] impostorScoresUser8User18;
        static double[,] impostorScoresUser8User19;
        static double[,] impostorScoresUser8User20;
        static double[,] impostorScoresUser8User21;
        static double[,] impostorScoresUser8User22;
        static double[,] impostorScoresUser8User23;
        static double[,] impostorScoresUser8User24;
        static double[,] impostorScoresUser8User25;
        static double[,] impostorScoresUser8User26;
        static double[,] impostorScoresUser8User27;
        static double[,] impostorScoresUser8User28;
        static double[,] impostorScoresUser8User29;
        static double[,] impostorScoresUser8User30;
        static double[,] impostorScoresUser8User31;
        static double[,] impostorScoresUser8User32;
        static double[,] impostorScoresUser8User33;

        // The impostor score 2D double arrays with user 8 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser8User34;
        static double[,] impostorScoresUser8User35;
        static double[,] impostorScoresUser8User36;
        static double[,] impostorScoresUser8User37;
        static double[,] impostorScoresUser8User38;
        static double[,] impostorScoresUser8User39;
        static double[,] impostorScoresUser8User40;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 9 as the template
        static double[,] impostorScoresUser9User1;
        static double[,] impostorScoresUser9User2;
        static double[,] impostorScoresUser9User3;
        static double[,] impostorScoresUser9User4;
        static double[,] impostorScoresUser9User5;
        static double[,] impostorScoresUser9User6;
        static double[,] impostorScoresUser9User7;
        static double[,] impostorScoresUser9User8;
        static double[,] impostorScoresUser9User10;
        static double[,] impostorScoresUser9User11;
        static double[,] impostorScoresUser9User12;
        static double[,] impostorScoresUser9User13;
        static double[,] impostorScoresUser9User14;
        static double[,] impostorScoresUser9User15;
        static double[,] impostorScoresUser9User16;
        static double[,] impostorScoresUser9User17;
        static double[,] impostorScoresUser9User18;
        static double[,] impostorScoresUser9User19;
        static double[,] impostorScoresUser9User20;
        static double[,] impostorScoresUser9User21;
        static double[,] impostorScoresUser9User22;
        static double[,] impostorScoresUser9User23;
        static double[,] impostorScoresUser9User24;
        static double[,] impostorScoresUser9User25;
        static double[,] impostorScoresUser9User26;
        static double[,] impostorScoresUser9User27;
        static double[,] impostorScoresUser9User28;
        static double[,] impostorScoresUser9User29;
        static double[,] impostorScoresUser9User30;
        static double[,] impostorScoresUser9User31;
        static double[,] impostorScoresUser9User32;
        static double[,] impostorScoresUser9User33;

        // The impostor score 2D double arrays with user 9 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser9User34;
        static double[,] impostorScoresUser9User35;
        static double[,] impostorScoresUser9User36;
        static double[,] impostorScoresUser9User37;
        static double[,] impostorScoresUser9User38;
        static double[,] impostorScoresUser9User39;
        static double[,] impostorScoresUser9User40;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 10 as the template
        static double[,] impostorScoresUser10User1;
        static double[,] impostorScoresUser10User2;
        static double[,] impostorScoresUser10User3;
        static double[,] impostorScoresUser10User4;
        static double[,] impostorScoresUser10User5;
        static double[,] impostorScoresUser10User6;
        static double[,] impostorScoresUser10User7;
        static double[,] impostorScoresUser10User8;
        static double[,] impostorScoresUser10User9;
        static double[,] impostorScoresUser10User11;
        static double[,] impostorScoresUser10User12;
        static double[,] impostorScoresUser10User13;
        static double[,] impostorScoresUser10User14;
        static double[,] impostorScoresUser10User15;
        static double[,] impostorScoresUser10User16;
        static double[,] impostorScoresUser10User17;
        static double[,] impostorScoresUser10User18;
        static double[,] impostorScoresUser10User19;
        static double[,] impostorScoresUser10User20;
        static double[,] impostorScoresUser10User21;
        static double[,] impostorScoresUser10User22;
        static double[,] impostorScoresUser10User23;
        static double[,] impostorScoresUser10User24;
        static double[,] impostorScoresUser10User25;
        static double[,] impostorScoresUser10User26;
        static double[,] impostorScoresUser10User27;
        static double[,] impostorScoresUser10User28;
        static double[,] impostorScoresUser10User29;
        static double[,] impostorScoresUser10User30;
        static double[,] impostorScoresUser10User31;
        static double[,] impostorScoresUser10User32;
        static double[,] impostorScoresUser10User33;

        // The impostor score 2D double arrays with user 10 as the template and looking at users 34 through 40 - 14th June 2015
        static double[,] impostorScoresUser10User34;
        static double[,] impostorScoresUser10User35;
        static double[,] impostorScoresUser10User36;
        static double[,] impostorScoresUser10User37;
        static double[,] impostorScoresUser10User38;
        static double[,] impostorScoresUser10User39;
        static double[,] impostorScoresUser10User40;
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

            // Inserting the CSV files to be parsed for users 34 through 40 - 13th June 2015
            s034 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user34.csv");
            s035 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user35.csv");
            s036 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user36.csv");
            s037 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user37.csv");
            s038 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user38.csv");
            s039 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user39.csv");
            s040 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user40.csv");

            // Inserting the CSV files to be parsed for users 41 through 50 - 14th June 2015
            s041 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user41.csv");
            s042 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user42.csv");
            s043 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user43.csv");
            s044 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user44.csv");
            s045 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user45.csv");
            s046 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user46.csv");
            s047 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user47.csv");
            s048 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user48.csv");
            s049 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user49.csv");
            s050 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user50.csv"); 

            // Inserting the CSV files to be parsed for users 51 through 60 - 15th June 2015
            s051 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user51.csv");
            s052 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user52.csv");
            s053 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user53.csv");
            s054 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user54.csv");
            s055 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user55.csv");
            s056 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user56.csv");
            s057 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user57.csv");
            s058 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user58.csv");
            s059 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user59.csv");
            s060 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user60.csv"); 
            #endregion

            Console.WriteLine("Now choose your verifier: " + Environment.NewLine + "0 for Manhattan" + Environment.NewLine + "1 for Euclidean" + Environment.NewLine + "2 for Scaled Manhattan" + Environment.NewLine + "3 for Scaled Euclidean, or" + Environment.NewLine + "4 to Quit.");

            // The input condition that will be the parameters for the switch statement that follows this. - 14th June 2015
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

            // Adding the mean vectors for users 34 through 40 - 13th June 2015
            s034Mean = ManhDist.CalculateMeanVector(s034);
            s035Mean = ManhDist.CalculateMeanVector(s035);
            s036Mean = ManhDist.CalculateMeanVector(s036);
            s037Mean = ManhDist.CalculateMeanVector(s037);
            s038Mean = ManhDist.CalculateMeanVector(s038);
            s039Mean = ManhDist.CalculateMeanVector(s039);
            s040Mean = ManhDist.CalculateMeanVector(s040);

            // Adding the mean vectors for user 41 through 60 - 15th June 2015
            s041Mean = ManhDist.CalculateMeanVector(s041);
            s042Mean = ManhDist.CalculateMeanVector(s042);
            s043Mean = ManhDist.CalculateMeanVector(s043);
            s044Mean = ManhDist.CalculateMeanVector(s044);
            s045Mean = ManhDist.CalculateMeanVector(s045);
            s046Mean = ManhDist.CalculateMeanVector(s046);
            s047Mean = ManhDist.CalculateMeanVector(s047);
            s048Mean = ManhDist.CalculateMeanVector(s048);
            s049Mean = ManhDist.CalculateMeanVector(s049);
            s050Mean = ManhDist.CalculateMeanVector(s050);
            s051Mean = ManhDist.CalculateMeanVector(s051);
            s052Mean = ManhDist.CalculateMeanVector(s052);
            s053Mean = ManhDist.CalculateMeanVector(s053);
            s054Mean = ManhDist.CalculateMeanVector(s054);
            s055Mean = ManhDist.CalculateMeanVector(s055);
            s056Mean = ManhDist.CalculateMeanVector(s056);
            s057Mean = ManhDist.CalculateMeanVector(s057);
            s058Mean = ManhDist.CalculateMeanVector(s058);
            s059Mean = ManhDist.CalculateMeanVector(s059);
            s060Mean = ManhDist.CalculateMeanVector(s060); 
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

            // Adding the genuine scores for users 34 through 40 - 14th June 2015
            s034Gen = ManhDist.CalculateGenuineScores(s034, s034Mean);
            s035Gen = ManhDist.CalculateGenuineScores(s035, s035Mean);
            s036Gen = ManhDist.CalculateGenuineScores(s036, s036Mean);
            s037Gen = ManhDist.CalculateGenuineScores(s037, s037Mean);
            s038Gen = ManhDist.CalculateGenuineScores(s038, s038Mean);
            s039Gen = ManhDist.CalculateGenuineScores(s039, s039Mean);
            s040Gen = ManhDist.CalculateGenuineScores(s040, s040Mean);

            // Adding the genuine scores for users 41 through 60 - 15th June 2015
            s041Gen = ManhDist.CalculateGenuineScores(s041, s041Mean);
            s042Gen = ManhDist.CalculateGenuineScores(s042, s042Mean);
            s043Gen = ManhDist.CalculateGenuineScores(s043, s043Mean);
            s044Gen = ManhDist.CalculateGenuineScores(s044, s044Mean);
            s045Gen = ManhDist.CalculateGenuineScores(s045, s045Mean);
            s046Gen = ManhDist.CalculateGenuineScores(s046, s046Mean);
            s047Gen = ManhDist.CalculateGenuineScores(s047, s047Mean);
            s048Gen = ManhDist.CalculateGenuineScores(s048, s048Mean);
            s049Gen = ManhDist.CalculateGenuineScores(s049, s049Mean);
            s050Gen = ManhDist.CalculateGenuineScores(s050, s050Mean);
            s051Gen = ManhDist.CalculateGenuineScores(s051, s051Mean);
            s052Gen = ManhDist.CalculateGenuineScores(s052, s052Mean);
            s053Gen = ManhDist.CalculateGenuineScores(s053, s053Mean);
            s054Gen = ManhDist.CalculateGenuineScores(s054, s054Mean);
            s055Gen = ManhDist.CalculateGenuineScores(s055, s055Mean);
            s056Gen = ManhDist.CalculateGenuineScores(s056, s056Mean);
            s057Gen = ManhDist.CalculateGenuineScores(s057, s057Mean);
            s058Gen = ManhDist.CalculateGenuineScores(s058, s058Mean);
            s059Gen = ManhDist.CalculateGenuineScores(s059, s059Mean);
            s060Gen = ManhDist.CalculateGenuineScores(s060, s060Mean); 
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
            impostorScoresUser1User11 = ManhDist.CalculateImpostorScores(s001Mean, s011);
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

            // Adding the impostor scores for users 34 through 40 using user 1 as the template vector - 14th June 2015
            impostorScoresUser1User34 = ManhDist.CalculateImpostorScores(s001Mean, s034);
            impostorScoresUser1User35 = ManhDist.CalculateImpostorScores(s001Mean, s035);
            impostorScoresUser1User36 = ManhDist.CalculateImpostorScores(s001Mean, s036);
            impostorScoresUser1User37 = ManhDist.CalculateImpostorScores(s001Mean, s037);
            impostorScoresUser1User38 = ManhDist.CalculateImpostorScores(s001Mean, s038);
            impostorScoresUser1User39 = ManhDist.CalculateImpostorScores(s001Mean, s039);
            impostorScoresUser1User40 = ManhDist.CalculateImpostorScores(s001Mean, s040);
            #endregion

            #region User 2 Impostor Scores
            impostorScoresUser2User1 = ManhDist.CalculateImpostorScores(s002Mean, s001);
            impostorScoresUser2User3 = ManhDist.CalculateImpostorScores(s002Mean, s003);
            impostorScoresUser2User4 = ManhDist.CalculateImpostorScores(s002Mean, s004);
            impostorScoresUser2User5 = ManhDist.CalculateImpostorScores(s002Mean, s005);
            impostorScoresUser2User6 = ManhDist.CalculateImpostorScores(s002Mean, s006);
            impostorScoresUser2User7 = ManhDist.CalculateImpostorScores(s002Mean, s007);
            impostorScoresUser2User8 = ManhDist.CalculateImpostorScores(s002Mean, s008);
            impostorScoresUser2User9 = ManhDist.CalculateImpostorScores(s002Mean, s009);
            impostorScoresUser2User10 = ManhDist.CalculateImpostorScores(s002Mean, s010);
            impostorScoresUser2User11 = ManhDist.CalculateImpostorScores(s002Mean, s011);
            impostorScoresUser2User12 = ManhDist.CalculateImpostorScores(s002Mean, s012);
            impostorScoresUser2User13 = ManhDist.CalculateImpostorScores(s002Mean, s013);
            impostorScoresUser2User14 = ManhDist.CalculateImpostorScores(s002Mean, s014);
            impostorScoresUser2User15 = ManhDist.CalculateImpostorScores(s002Mean, s015);
            impostorScoresUser2User16 = ManhDist.CalculateImpostorScores(s002Mean, s016);
            impostorScoresUser2User17 = ManhDist.CalculateImpostorScores(s002Mean, s017);
            impostorScoresUser2User18 = ManhDist.CalculateImpostorScores(s002Mean, s018);
            impostorScoresUser2User19 = ManhDist.CalculateImpostorScores(s002Mean, s019);
            impostorScoresUser2User20 = ManhDist.CalculateImpostorScores(s002Mean, s020);
            impostorScoresUser2User21 = ManhDist.CalculateImpostorScores(s002Mean, s021);
            impostorScoresUser2User22 = ManhDist.CalculateImpostorScores(s002Mean, s022);
            impostorScoresUser2User23 = ManhDist.CalculateImpostorScores(s002Mean, s023);
            impostorScoresUser2User24 = ManhDist.CalculateImpostorScores(s002Mean, s024);
            impostorScoresUser2User25 = ManhDist.CalculateImpostorScores(s002Mean, s025);
            impostorScoresUser2User26 = ManhDist.CalculateImpostorScores(s002Mean, s026);
            impostorScoresUser2User27 = ManhDist.CalculateImpostorScores(s002Mean, s027);
            impostorScoresUser2User28 = ManhDist.CalculateImpostorScores(s002Mean, s028);
            impostorScoresUser2User29 = ManhDist.CalculateImpostorScores(s002Mean, s029);
            impostorScoresUser2User30 = ManhDist.CalculateImpostorScores(s002Mean, s030);
            impostorScoresUser2User31 = ManhDist.CalculateImpostorScores(s002Mean, s031);
            impostorScoresUser2User32 = ManhDist.CalculateImpostorScores(s002Mean, s032);
            impostorScoresUser2User33 = ManhDist.CalculateImpostorScores(s002Mean, s033); 

            // Adding the users 34 through 40, using the data from user 2 as the template vector
            impostorScoresUser2User34 = ManhDist.CalculateImpostorScores(s002Mean, s034);
            impostorScoresUser2User35 = ManhDist.CalculateImpostorScores(s002Mean, s035);
            impostorScoresUser2User36 = ManhDist.CalculateImpostorScores(s002Mean, s036);
            impostorScoresUser2User37 = ManhDist.CalculateImpostorScores(s002Mean, s037);
            impostorScoresUser2User38 = ManhDist.CalculateImpostorScores(s002Mean, s038);
            impostorScoresUser2User39 = ManhDist.CalculateImpostorScores(s002Mean, s039);
            impostorScoresUser2User40 = ManhDist.CalculateImpostorScores(s002Mean, s040); 
            #endregion

            #region User 3 Impostor Scores
            // Populating the impostor scores for user 3 - using user 3 mean vectors as template
            impostorScoresUser3User1 = ManhDist.CalculateImpostorScores(s003Mean, s001);
            impostorScoresUser3User2 = ManhDist.CalculateImpostorScores(s003Mean, s002);
            impostorScoresUser3User4 = ManhDist.CalculateImpostorScores(s003Mean, s004); 
            #endregion

            #endregion
        }
        #endregion
    }
}