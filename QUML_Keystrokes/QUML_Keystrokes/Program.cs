/* 
 * Author: Pranav S. Krishnamurthy
 * 
 * File Name: Program.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- --------------
 * 1.8.16   30/06/2015  PKR     Now declaring the variables for the impostor scores for user 8
 * 1.8.17   30/06/2015  PKR     Finished declaring and populating the impostor scores for user 8 under both Manhattan and Euclidean verifiers
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

///<summary>
/// Source of the Data: http://www.eecs.qmul.ac.uk/~ccloy/downloads_keystroke100.html
///</summary>

namespace QUML_Keystrokes
{
    class Program
    {
        #region Static 2D double arrays that will be initialized and used
        #region Static 2D Double arrays for all of the users - using the DataFilter.ParseData(string filepath) method
        static double[,] s001; static double[,] s002;
        static double[,] s003; static double[,] s004;
        static double[,] s005;

        static double[,] s006; static double[,] s007;
        static double[,] s008; static double[,] s009;

        static double[,] s010;  static double[,] s011; static double[,] s012;

        static double[,] s013; static double[,] s014;  static double[,] s015;
        static double[,] s016; static double[,] s017;  static double[,] s018;
        static double[,] s019; static double[,] s020; 

        static double[,] s021; static double[,] s022; static double[,] s023; 

        static double[,] s024; static double[,] s025; static double[,] s026; 

        static double[,] s027; static double[,] s028;
        static double[,] s029; static double[,] s030;

        static double[,] s031; static double[,] s032; static double[,] s033;

        static double[,] s034; static double[,] s035; static double[,] s036;
        static double[,] s037; static double[,] s038; static double[,] s039;
        static double[,] s040;

        static double[,] s041; static double[,] s042; static double[,] s043;
        static double[,] s044; static double[,] s045; static double[,] s046;
        static double[,] s047; static double[,] s048; static double[,] s049;
        static double[,] s050; 

        static double[,] s051; static double[,] s052; static double[,] s053;
        static double[,] s054; static double[,] s055; static double[,] s056;
        static double[,] s057; static double[,] s058; static double[,] s059;
        static double[,] s060;

        static double[,] s061; static double[,] s062; static double[,] s063;
        static double[,] s064;

        static double[,] s065; static double[,] s066; static double[,] s067;
        static double[,] s068; static double[,] s069; static double[,] s070;

        static double[,] s071; static double[,] s072; static double[,] s073;
        static double[,] s074; static double[,] s075;

        static double[,] s076; static double[,] s077; static double[,] s078;
        static double[,] s079; static double[,] s080; static double[,] s081;
        static double[,] s082; static double[,] s083; static double[,] s084;
        static double[,] s085; static double[,] s086; static double[,] s087;
        static double[,] s088; static double[,] s089; static double[,] s090;

        static double[,] s091; static double[,] s092; static double[,] s093;
        static double[,] s094; static double[,] s095; static double[,] s096;
        static double[,] s097; static double[,] s098; static double[,] s099;
        static double[,] s100; 
        #endregion

        #region Static Double arrays for each user - these are the mean arrays, also known as the templates
        static double[] s001Mean; static double[] s002Mean; static double[] s003Mean;
        static double[] s004Mean; static double[] s005Mean; static double[] s006Mean; 
        
        static double[] s007Mean; static double[] s008Mean;
        static double[] s009Mean; static double[] s010Mean; 
        
        static double[] s011Mean; static double[] s012Mean;
        static double[] s013Mean; static double[] s014Mean;
        static double[] s015Mean; static double[] s016Mean;
        static double[] s017Mean; static double[] s018Mean;
        static double[] s019Mean; static double[] s020Mean;

        static double[] s021Mean; static double[] s022Mean; static double[] s023Mean;

        static double[] s024Mean; static double[] s025Mean; static double[] s026Mean; 

        static double[] s027Mean; static double[] s028Mean;
        static double[] s029Mean; static double[] s030Mean;

        static double[] s031Mean; static double[] s032Mean; static double[] s033Mean;

        static double[] s034Mean; static double[] s035Mean; static double[] s036Mean;
        static double[] s037Mean; static double[] s038Mean; static double[] s039Mean;
        static double[] s040Mean;

        static double[] s041Mean; static double[] s042Mean; static double[] s043Mean;
        static double[] s044Mean; static double[] s045Mean; static double[] s046Mean; 
        static double[] s047Mean; static double[] s048Mean; static double[] s049Mean; 
        static double[] s050Mean; static double[] s051Mean; static double[] s052Mean; 
        static double[] s053Mean; static double[] s054Mean; static double[] s055Mean; 
        static double[] s056Mean; static double[] s057Mean; static double[] s058Mean;
        static double[] s059Mean; static double[] s060Mean;

        static double[] s061Mean; static double[] s062Mean; static double[] s063Mean;
        static double[] s064Mean;

        static double[] s065Mean; static double[] s066Mean; static double[] s067Mean;
        static double[] s068Mean; static double[] s069Mean; static double[] s070Mean;

        static double[] s071Mean; static double[] s072Mean; static double[] s073Mean;
        static double[] s074Mean; static double[] s075Mean;

        static double[] s076Mean; static double[] s077Mean; static double[] s078Mean;
        static double[] s079Mean; static double[] s080Mean; static double[] s081Mean;
        static double[] s082Mean; static double[] s083Mean; static double[] s084Mean;
        static double[] s085Mean; static double[] s086Mean; static double[] s087Mean;
        static double[] s088Mean; static double[] s089Mean; static double[] s090Mean;

        static double[] s091Mean; static double[] s092Mean; static double[] s093Mean;
        static double[] s094Mean; static double[] s095Mean; static double[] s096Mean;
        static double[] s097Mean; static double[] s098Mean; static double[] s099Mean;
        static double[] s100Mean; 
        #endregion

        #region Here having the static 2D double arrays for the genuine scores of each user
        static double[,] s001Gen; static double[,] s002Gen; static double[,] s003Gen;
        static double[,] s004Gen; static double[,] s005Gen; static double[,] s006Gen;
        static double[,] s007Gen; static double[,] s008Gen; static double[,] s009Gen;
        static double[,] s010Gen; static double[,] s011Gen; static double[,] s012Gen;

        static double[,] s013Gen; static double[,] s014Gen; static double[,] s015Gen;
        static double[,] s016Gen; static double[,] s017Gen; static double[,] s018Gen;
        static double[,] s019Gen; static double[,] s020Gen; 

        static double[,] s021Gen; static double[,] s022Gen; static double[,] s023Gen;

        static double[,] s024Gen; static double[,] s025Gen; static double[,] s026Gen;

        static double[,] s027Gen; static double[,] s028Gen;
        static double[,] s029Gen; static double[,] s030Gen;

        static double[,] s031Gen; static double[,] s032Gen; static double[,] s033Gen;

        static double[,] s034Gen; static double[,] s035Gen; static double[,] s036Gen;
        static double[,] s037Gen; static double[,] s038Gen; static double[,] s039Gen;
        static double[,] s040Gen;

        static double[,] s041Gen; static double[,] s042Gen; static double[,] s043Gen;
        static double[,] s044Gen; static double[,] s045Gen; static double[,] s046Gen;
        static double[,] s047Gen; static double[,] s048Gen; static double[,] s049Gen;
        static double[,] s050Gen; static double[,] s051Gen; static double[,] s052Gen;
        static double[,] s053Gen; static double[,] s054Gen; static double[,] s055Gen;
        static double[,] s056Gen; static double[,] s057Gen; static double[,] s058Gen;
        static double[,] s059Gen; static double[,] s060Gen;

        static double[,] s061Gen; static double[,] s062Gen; static double[,] s063Gen;
        static double[,] s064Gen;

        static double[,] s065Gen; static double[,] s066Gen; static double[,] s067Gen;
        static double[,] s068Gen; static double[,] s069Gen; static double[,] s070Gen;

        static double[,] s071Gen; static double[,] s072Gen; static double[,] s073Gen;
        static double[,] s074Gen; static double[,] s075Gen;

        static double[,] s076Gen; static double[,] s077Gen; static double[,] s078Gen;
        static double[,] s079Gen; static double[,] s080Gen; static double[,] s081Gen;
        static double[,] s082Gen; static double[,] s083Gen; static double[,] s084Gen;
        static double[,] s085Gen; static double[,] s086Gen; static double[,] s087Gen;
        static double[,] s088Gen; static double[,] s089Gen; static double[,] s090Gen;

        static double[,] s091Gen; static double[,] s092Gen; static double[,] s093Gen;
        static double[,] s094Gen; static double[,] s095Gen; static double[,] s096Gen;
        static double[,] s097Gen; static double[,] s098Gen; static double[,] s099Gen;
        static double[,] s100Gen;
        #endregion

        #region These are the impostor scores for each user combination
        #region Having static 2D double arrays for the impostor scores with user 1 as the training (using the mean vector for user 1 in calculating the impostor scores)
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
        static double[,] impostorScoresUser1User34;
        static double[,] impostorScoresUser1User35;
        static double[,] impostorScoresUser1User36;
        static double[,] impostorScoresUser1User37;
        static double[,] impostorScoresUser1User38;
        static double[,] impostorScoresUser1User39;
        static double[,] impostorScoresUser1User40;

        static double[,] impostorScoresUser1User41;
        static double[,] impostorScoresUser1User42;
        static double[,] impostorScoresUser1User43;
        static double[,] impostorScoresUser1User44;
        static double[,] impostorScoresUser1User45;
        static double[,] impostorScoresUser1User46;
        static double[,] impostorScoresUser1User47;
        static double[,] impostorScoresUser1User48;
        static double[,] impostorScoresUser1User49;
        static double[,] impostorScoresUser1User50;

        static double[,] impostorScoresUser1User51;
        static double[,] impostorScoresUser1User52;
        static double[,] impostorScoresUser1User53;
        static double[,] impostorScoresUser1User54;
        static double[,] impostorScoresUser1User55;
        static double[,] impostorScoresUser1User56;
        static double[,] impostorScoresUser1User57;
        static double[,] impostorScoresUser1User58;
        static double[,] impostorScoresUser1User59;
        static double[,] impostorScoresUser1User60;

        static double[,] impostorScoresUser1User61;
        static double[,] impostorScoresUser1User62;
        static double[,] impostorScoresUser1User63;
        static double[,] impostorScoresUser1User64;
        static double[,] impostorScoresUser1User65;
        static double[,] impostorScoresUser1User66;
        static double[,] impostorScoresUser1User67;
        static double[,] impostorScoresUser1User68;
        static double[,] impostorScoresUser1User69;
        static double[,] impostorScoresUser1User70;

        static double[,] impostorScoresUser1User71;
        static double[,] impostorScoresUser1User72;
        static double[,] impostorScoresUser1User73;
        static double[,] impostorScoresUser1User74;
        static double[,] impostorScoresUser1User75;
        static double[,] impostorScoresUser1User76;
        static double[,] impostorScoresUser1User77;
        static double[,] impostorScoresUser1User78;
        static double[,] impostorScoresUser1User79;
        static double[,] impostorScoresUser1User80;

        static double[,] impostorScoresUser1User81;
        static double[,] impostorScoresUser1User82;
        static double[,] impostorScoresUser1User83;
        static double[,] impostorScoresUser1User84;
        static double[,] impostorScoresUser1User85;
        static double[,] impostorScoresUser1User86;
        static double[,] impostorScoresUser1User87;
        static double[,] impostorScoresUser1User88;
        static double[,] impostorScoresUser1User89;
        static double[,] impostorScoresUser1User90;

        static double[,] impostorScoresUser1User91;
        static double[,] impostorScoresUser1User92;
        static double[,] impostorScoresUser1User93;
        static double[,] impostorScoresUser1User94;
        static double[,] impostorScoresUser1User95;
        static double[,] impostorScoresUser1User96;
        static double[,] impostorScoresUser1User97;
        static double[,] impostorScoresUser1User98;
        static double[,] impostorScoresUser1User99;
        static double[,] impostorScoresUser1User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 2 as the training (using the mean vector for user 2 in calculating the impostor scores)
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
        static double[,] impostorScoresUser2User34;
        static double[,] impostorScoresUser2User35;
        static double[,] impostorScoresUser2User36;
        static double[,] impostorScoresUser2User37;
        static double[,] impostorScoresUser2User38;
        static double[,] impostorScoresUser2User39;
        static double[,] impostorScoresUser2User40;

        static double[,] impostorScoresUser2User41;
        static double[,] impostorScoresUser2User42;
        static double[,] impostorScoresUser2User43;
        static double[,] impostorScoresUser2User44;
        static double[,] impostorScoresUser2User45;
        static double[,] impostorScoresUser2User46;
        static double[,] impostorScoresUser2User47;
        static double[,] impostorScoresUser2User48;
        static double[,] impostorScoresUser2User49;
        static double[,] impostorScoresUser2User50;

        static double[,] impostorScoresUser2User51;
        static double[,] impostorScoresUser2User52;
        static double[,] impostorScoresUser2User53;
        static double[,] impostorScoresUser2User54;
        static double[,] impostorScoresUser2User55;
        static double[,] impostorScoresUser2User56;
        static double[,] impostorScoresUser2User57;
        static double[,] impostorScoresUser2User58;
        static double[,] impostorScoresUser2User59;
        static double[,] impostorScoresUser2User60;

        static double[,] impostorScoresUser2User61;
        static double[,] impostorScoresUser2User62;
        static double[,] impostorScoresUser2User63;
        static double[,] impostorScoresUser2User64;
        static double[,] impostorScoresUser2User65;
        static double[,] impostorScoresUser2User66;
        static double[,] impostorScoresUser2User67;
        static double[,] impostorScoresUser2User68;
        static double[,] impostorScoresUser2User69;
        static double[,] impostorScoresUser2User70;

        static double[,] impostorScoresUser2User71;
        static double[,] impostorScoresUser2User72;
        static double[,] impostorScoresUser2User73;
        static double[,] impostorScoresUser2User74;
        static double[,] impostorScoresUser2User75;
        static double[,] impostorScoresUser2User76;
        static double[,] impostorScoresUser2User77;
        static double[,] impostorScoresUser2User78;
        static double[,] impostorScoresUser2User79;
        static double[,] impostorScoresUser2User80;

        static double[,] impostorScoresUser2User81;
        static double[,] impostorScoresUser2User82;
        static double[,] impostorScoresUser2User83;
        static double[,] impostorScoresUser2User84;
        static double[,] impostorScoresUser2User85;
        static double[,] impostorScoresUser2User86;
        static double[,] impostorScoresUser2User87;
        static double[,] impostorScoresUser2User88;
        static double[,] impostorScoresUser2User89;
        static double[,] impostorScoresUser2User90;

        static double[,] impostorScoresUser2User91;
        static double[,] impostorScoresUser2User92;
        static double[,] impostorScoresUser2User93;
        static double[,] impostorScoresUser2User94;
        static double[,] impostorScoresUser2User95;
        static double[,] impostorScoresUser2User96;
        static double[,] impostorScoresUser2User97;
        static double[,] impostorScoresUser2User98;
        static double[,] impostorScoresUser2User99;
        static double[,] impostorScoresUser2User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 3 as the training (using the mean vector for user 3 in calculating the impostor scores)
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
        static double[,] impostorScoresUser3User34;
        static double[,] impostorScoresUser3User35;
        static double[,] impostorScoresUser3User36;
        static double[,] impostorScoresUser3User37;
        static double[,] impostorScoresUser3User38;
        static double[,] impostorScoresUser3User39;
        static double[,] impostorScoresUser3User40;

        static double[,] impostorScoresUser3User41;
        static double[,] impostorScoresUser3User42;
        static double[,] impostorScoresUser3User43;
        static double[,] impostorScoresUser3User44;
        static double[,] impostorScoresUser3User45;
        static double[,] impostorScoresUser3User46;
        static double[,] impostorScoresUser3User47;
        static double[,] impostorScoresUser3User48;
        static double[,] impostorScoresUser3User49;
        static double[,] impostorScoresUser3User50;

        static double[,] impostorScoresUser3User51;
        static double[,] impostorScoresUser3User52;
        static double[,] impostorScoresUser3User53;
        static double[,] impostorScoresUser3User54;
        static double[,] impostorScoresUser3User55;
        static double[,] impostorScoresUser3User56;
        static double[,] impostorScoresUser3User57;
        static double[,] impostorScoresUser3User58;
        static double[,] impostorScoresUser3User59;
        static double[,] impostorScoresUser3User60;

        static double[,] impostorScoresUser3User61;
        static double[,] impostorScoresUser3User62;
        static double[,] impostorScoresUser3User63;
        static double[,] impostorScoresUser3User64;
        static double[,] impostorScoresUser3User65;
        static double[,] impostorScoresUser3User66;
        static double[,] impostorScoresUser3User67;
        static double[,] impostorScoresUser3User68;
        static double[,] impostorScoresUser3User69;
        static double[,] impostorScoresUser3User70;

        static double[,] impostorScoresUser3User71;
        static double[,] impostorScoresUser3User72;
        static double[,] impostorScoresUser3User73;
        static double[,] impostorScoresUser3User74;
        static double[,] impostorScoresUser3User75;
        static double[,] impostorScoresUser3User76;
        static double[,] impostorScoresUser3User77;
        static double[,] impostorScoresUser3User78;
        static double[,] impostorScoresUser3User79;
        static double[,] impostorScoresUser3User80;

        static double[,] impostorScoresUser3User81;
        static double[,] impostorScoresUser3User82;
        static double[,] impostorScoresUser3User83;
        static double[,] impostorScoresUser3User84;
        static double[,] impostorScoresUser3User85;
        static double[,] impostorScoresUser3User86;
        static double[,] impostorScoresUser3User87;
        static double[,] impostorScoresUser3User88;
        static double[,] impostorScoresUser3User89;
        static double[,] impostorScoresUser3User90;

        static double[,] impostorScoresUser3User91;
        static double[,] impostorScoresUser3User92;
        static double[,] impostorScoresUser3User93;
        static double[,] impostorScoresUser3User94;
        static double[,] impostorScoresUser3User95;
        static double[,] impostorScoresUser3User96;
        static double[,] impostorScoresUser3User97;
        static double[,] impostorScoresUser3User98;
        static double[,] impostorScoresUser3User99;
        static double[,] impostorScoresUser3User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 4 as the training (using the mean vector for user 4 in calculating the impostor scores)
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
        static double[,] impostorScoresUser4User34;
        static double[,] impostorScoresUser4User35;
        static double[,] impostorScoresUser4User36;
        static double[,] impostorScoresUser4User37;
        static double[,] impostorScoresUser4User38;
        static double[,] impostorScoresUser4User39;
        static double[,] impostorScoresUser4User40;

        static double[,] impostorScoresUser4User41;
        static double[,] impostorScoresUser4User42;
        static double[,] impostorScoresUser4User43;
        static double[,] impostorScoresUser4User44;
        static double[,] impostorScoresUser4User45;
        static double[,] impostorScoresUser4User46;
        static double[,] impostorScoresUser4User47;
        static double[,] impostorScoresUser4User48;
        static double[,] impostorScoresUser4User49;
        static double[,] impostorScoresUser4User50;

        static double[,] impostorScoresUser4User51;
        static double[,] impostorScoresUser4User52;
        static double[,] impostorScoresUser4User53;
        static double[,] impostorScoresUser4User54;
        static double[,] impostorScoresUser4User55;
        static double[,] impostorScoresUser4User56;
        static double[,] impostorScoresUser4User57;
        static double[,] impostorScoresUser4User58;
        static double[,] impostorScoresUser4User59;
        static double[,] impostorScoresUser4User60;

        static double[,] impostorScoresUser4User61;
        static double[,] impostorScoresUser4User62;
        static double[,] impostorScoresUser4User63;
        static double[,] impostorScoresUser4User64;
        static double[,] impostorScoresUser4User65;
        static double[,] impostorScoresUser4User66;
        static double[,] impostorScoresUser4User67;
        static double[,] impostorScoresUser4User68;
        static double[,] impostorScoresUser4User69;
        static double[,] impostorScoresUser4User70;

        static double[,] impostorScoresUser4User71;
        static double[,] impostorScoresUser4User72;
        static double[,] impostorScoresUser4User73;
        static double[,] impostorScoresUser4User74;
        static double[,] impostorScoresUser4User75;
        static double[,] impostorScoresUser4User76;
        static double[,] impostorScoresUser4User77;
        static double[,] impostorScoresUser4User78;
        static double[,] impostorScoresUser4User79;
        static double[,] impostorScoresUser4User80;

        static double[,] impostorScoresUser4User81;
        static double[,] impostorScoresUser4User82;
        static double[,] impostorScoresUser4User83;
        static double[,] impostorScoresUser4User84;
        static double[,] impostorScoresUser4User85;
        static double[,] impostorScoresUser4User86;
        static double[,] impostorScoresUser4User87;
        static double[,] impostorScoresUser4User88;
        static double[,] impostorScoresUser4User89;
        static double[,] impostorScoresUser4User90;

        static double[,] impostorScoresUser4User91;
        static double[,] impostorScoresUser4User92;
        static double[,] impostorScoresUser4User93;
        static double[,] impostorScoresUser4User94;
        static double[,] impostorScoresUser4User95;
        static double[,] impostorScoresUser4User96;
        static double[,] impostorScoresUser4User97;
        static double[,] impostorScoresUser4User98;
        static double[,] impostorScoresUser4User99;
        static double[,] impostorScoresUser4User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 5 as the training (using the mean vector for user 5 in calculating the impostor scores)
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
        static double[,] impostorScoresUser5User34;
        static double[,] impostorScoresUser5User35;
        static double[,] impostorScoresUser5User36;
        static double[,] impostorScoresUser5User37;
        static double[,] impostorScoresUser5User38;
        static double[,] impostorScoresUser5User39;
        static double[,] impostorScoresUser5User40;

        static double[,] impostorScoresUser5User41;
        static double[,] impostorScoresUser5User42;
        static double[,] impostorScoresUser5User43;
        static double[,] impostorScoresUser5User44;
        static double[,] impostorScoresUser5User45;
        static double[,] impostorScoresUser5User46;
        static double[,] impostorScoresUser5User47;
        static double[,] impostorScoresUser5User48;
        static double[,] impostorScoresUser5User49;
        static double[,] impostorScoresUser5User50;

        static double[,] impostorScoresUser5User51;
        static double[,] impostorScoresUser5User52;
        static double[,] impostorScoresUser5User53;
        static double[,] impostorScoresUser5User54;
        static double[,] impostorScoresUser5User55;
        static double[,] impostorScoresUser5User56;
        static double[,] impostorScoresUser5User57;
        static double[,] impostorScoresUser5User58;
        static double[,] impostorScoresUser5User59;
        static double[,] impostorScoresUser5User60;

        static double[,] impostorScoresUser5User61;
        static double[,] impostorScoresUser5User62;
        static double[,] impostorScoresUser5User63;
        static double[,] impostorScoresUser5User64;
        static double[,] impostorScoresUser5User65;
        static double[,] impostorScoresUser5User66;
        static double[,] impostorScoresUser5User67;
        static double[,] impostorScoresUser5User68;
        static double[,] impostorScoresUser5User69;
        static double[,] impostorScoresUser5User70;

        static double[,] impostorScoresUser5User71;
        static double[,] impostorScoresUser5User72;
        static double[,] impostorScoresUser5User73;
        static double[,] impostorScoresUser5User74;
        static double[,] impostorScoresUser5User75;
        static double[,] impostorScoresUser5User76;
        static double[,] impostorScoresUser5User77;
        static double[,] impostorScoresUser5User78;
        static double[,] impostorScoresUser5User79;
        static double[,] impostorScoresUser5User80;

        static double[,] impostorScoresUser5User81;
        static double[,] impostorScoresUser5User82;
        static double[,] impostorScoresUser5User83;
        static double[,] impostorScoresUser5User84;
        static double[,] impostorScoresUser5User85;
        static double[,] impostorScoresUser5User86;
        static double[,] impostorScoresUser5User87;
        static double[,] impostorScoresUser5User88;
        static double[,] impostorScoresUser5User89;
        static double[,] impostorScoresUser5User90;

        static double[,] impostorScoresUser5User91;
        static double[,] impostorScoresUser5User92;
        static double[,] impostorScoresUser5User93;
        static double[,] impostorScoresUser5User94;
        static double[,] impostorScoresUser5User95;
        static double[,] impostorScoresUser5User96;
        static double[,] impostorScoresUser5User97;
        static double[,] impostorScoresUser5User98;
        static double[,] impostorScoresUser5User99;
        static double[,] impostorScoresUser5User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 6 as the training (using the mean vector for user 6 in calculating the impostor scores)
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
        static double[,] impostorScoresUser6User34;
        static double[,] impostorScoresUser6User35;
        static double[,] impostorScoresUser6User36;
        static double[,] impostorScoresUser6User37;
        static double[,] impostorScoresUser6User38;
        static double[,] impostorScoresUser6User39;
        static double[,] impostorScoresUser6User40;

        static double[,] impostorScoresUser6User41;
        static double[,] impostorScoresUser6User42;
        static double[,] impostorScoresUser6User43;
        static double[,] impostorScoresUser6User44;
        static double[,] impostorScoresUser6User45;
        static double[,] impostorScoresUser6User46;
        static double[,] impostorScoresUser6User47;
        static double[,] impostorScoresUser6User48;
        static double[,] impostorScoresUser6User49;
        static double[,] impostorScoresUser6User50;

        static double[,] impostorScoresUser6User51;
        static double[,] impostorScoresUser6User52;
        static double[,] impostorScoresUser6User53;
        static double[,] impostorScoresUser6User54;
        static double[,] impostorScoresUser6User55;
        static double[,] impostorScoresUser6User56;
        static double[,] impostorScoresUser6User57;
        static double[,] impostorScoresUser6User58;
        static double[,] impostorScoresUser6User59;
        static double[,] impostorScoresUser6User60;

        static double[,] impostorScoresUser6User61;
        static double[,] impostorScoresUser6User62;
        static double[,] impostorScoresUser6User63;
        static double[,] impostorScoresUser6User64;
        static double[,] impostorScoresUser6User65;
        static double[,] impostorScoresUser6User66;
        static double[,] impostorScoresUser6User67;
        static double[,] impostorScoresUser6User68;
        static double[,] impostorScoresUser6User69;
        static double[,] impostorScoresUser6User70;

        static double[,] impostorScoresUser6User71;
        static double[,] impostorScoresUser6User72;
        static double[,] impostorScoresUser6User73;
        static double[,] impostorScoresUser6User74;
        static double[,] impostorScoresUser6User75;
        static double[,] impostorScoresUser6User76;
        static double[,] impostorScoresUser6User77;
        static double[,] impostorScoresUser6User78;
        static double[,] impostorScoresUser6User79;
        static double[,] impostorScoresUser6User80;

        static double[,] impostorScoresUser6User81;
        static double[,] impostorScoresUser6User82;
        static double[,] impostorScoresUser6User83;
        static double[,] impostorScoresUser6User84;
        static double[,] impostorScoresUser6User85;
        static double[,] impostorScoresUser6User86;
        static double[,] impostorScoresUser6User87;
        static double[,] impostorScoresUser6User88;
        static double[,] impostorScoresUser6User89;
        static double[,] impostorScoresUser6User90;

        static double[,] impostorScoresUser6User91;
        static double[,] impostorScoresUser6User92;
        static double[,] impostorScoresUser6User93;
        static double[,] impostorScoresUser6User94;
        static double[,] impostorScoresUser6User95;
        static double[,] impostorScoresUser6User96;
        static double[,] impostorScoresUser6User97;
        static double[,] impostorScoresUser6User98;
        static double[,] impostorScoresUser6User99;
        static double[,] impostorScoresUser6User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 7 as the training (using the mean vector for user 7 in calculating the impostor scores)
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
        static double[,] impostorScoresUser7User34;
        static double[,] impostorScoresUser7User35;
        static double[,] impostorScoresUser7User36;
        static double[,] impostorScoresUser7User37;
        static double[,] impostorScoresUser7User38;
        static double[,] impostorScoresUser7User39;
        static double[,] impostorScoresUser7User40;

        static double[,] impostorScoresUser7User41;
        static double[,] impostorScoresUser7User42;
        static double[,] impostorScoresUser7User43;
        static double[,] impostorScoresUser7User44;
        static double[,] impostorScoresUser7User45;
        static double[,] impostorScoresUser7User46;
        static double[,] impostorScoresUser7User47;
        static double[,] impostorScoresUser7User48;
        static double[,] impostorScoresUser7User49;
        static double[,] impostorScoresUser7User50;

        static double[,] impostorScoresUser7User51;
        static double[,] impostorScoresUser7User52;
        static double[,] impostorScoresUser7User53;
        static double[,] impostorScoresUser7User54;
        static double[,] impostorScoresUser7User55;
        static double[,] impostorScoresUser7User56;
        static double[,] impostorScoresUser7User57;
        static double[,] impostorScoresUser7User58;
        static double[,] impostorScoresUser7User59;
        static double[,] impostorScoresUser7User60;

        static double[,] impostorScoresUser7User61;
        static double[,] impostorScoresUser7User62;
        static double[,] impostorScoresUser7User63;
        static double[,] impostorScoresUser7User64;
        static double[,] impostorScoresUser7User65;
        static double[,] impostorScoresUser7User66;
        static double[,] impostorScoresUser7User67;
        static double[,] impostorScoresUser7User68;
        static double[,] impostorScoresUser7User69;
        static double[,] impostorScoresUser7User70;

        static double[,] impostorScoresUser7User71;
        static double[,] impostorScoresUser7User72;
        static double[,] impostorScoresUser7User73;
        static double[,] impostorScoresUser7User74;
        static double[,] impostorScoresUser7User75;
        static double[,] impostorScoresUser7User76;
        static double[,] impostorScoresUser7User77;
        static double[,] impostorScoresUser7User78;
        static double[,] impostorScoresUser7User79;
        static double[,] impostorScoresUser7User80;

        static double[,] impostorScoresUser7User81;
        static double[,] impostorScoresUser7User82;
        static double[,] impostorScoresUser7User83;
        static double[,] impostorScoresUser7User84;
        static double[,] impostorScoresUser7User85;
        static double[,] impostorScoresUser7User86;
        static double[,] impostorScoresUser7User87;
        static double[,] impostorScoresUser7User88;
        static double[,] impostorScoresUser7User89;
        static double[,] impostorScoresUser7User90;

        static double[,] impostorScoresUser7User91;
        static double[,] impostorScoresUser7User92;
        static double[,] impostorScoresUser7User93;
        static double[,] impostorScoresUser7User94;
        static double[,] impostorScoresUser7User95;
        static double[,] impostorScoresUser7User96;
        static double[,] impostorScoresUser7User97;
        static double[,] impostorScoresUser7User98;
        static double[,] impostorScoresUser7User99;
        static double[,] impostorScoresUser7User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 8 as the training (using the mean vector for user 8 in calculating the impostor scores)
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
        static double[,] impostorScoresUser8User34;
        static double[,] impostorScoresUser8User35;
        static double[,] impostorScoresUser8User36;
        static double[,] impostorScoresUser8User37;
        static double[,] impostorScoresUser8User38;
        static double[,] impostorScoresUser8User39;
        static double[,] impostorScoresUser8User40;

        static double[,] impostorScoresUser8User41;
        static double[,] impostorScoresUser8User42;
        static double[,] impostorScoresUser8User43;
        static double[,] impostorScoresUser8User44;
        static double[,] impostorScoresUser8User45;
        static double[,] impostorScoresUser8User46;
        static double[,] impostorScoresUser8User47;
        static double[,] impostorScoresUser8User48;
        static double[,] impostorScoresUser8User49;
        static double[,] impostorScoresUser8User50;

        static double[,] impostorScoresUser8User51;
        static double[,] impostorScoresUser8User52;
        static double[,] impostorScoresUser8User53;
        static double[,] impostorScoresUser8User54;
        static double[,] impostorScoresUser8User55;
        static double[,] impostorScoresUser8User56;
        static double[,] impostorScoresUser8User57;
        static double[,] impostorScoresUser8User58;
        static double[,] impostorScoresUser8User59;
        static double[,] impostorScoresUser8User60;

        static double[,] impostorScoresUser8User61;
        static double[,] impostorScoresUser8User62;
        static double[,] impostorScoresUser8User63;
        static double[,] impostorScoresUser8User64;
        static double[,] impostorScoresUser8User65;
        static double[,] impostorScoresUser8User66;
        static double[,] impostorScoresUser8User67;
        static double[,] impostorScoresUser8User68;
        static double[,] impostorScoresUser8User69;
        static double[,] impostorScoresUser8User70;

        static double[,] impostorScoresUser8User71;
        static double[,] impostorScoresUser8User72;
        static double[,] impostorScoresUser8User73;
        static double[,] impostorScoresUser8User74;
        static double[,] impostorScoresUser8User75;
        static double[,] impostorScoresUser8User76;
        static double[,] impostorScoresUser8User77;
        static double[,] impostorScoresUser8User78;
        static double[,] impostorScoresUser8User79;
        static double[,] impostorScoresUser8User80;

        static double[,] impostorScoresUser8User81;
        static double[,] impostorScoresUser8User82;
        static double[,] impostorScoresUser8User83;
        static double[,] impostorScoresUser8User84;
        static double[,] impostorScoresUser8User85;
        static double[,] impostorScoresUser8User86;
        static double[,] impostorScoresUser8User87;
        static double[,] impostorScoresUser8User88;
        static double[,] impostorScoresUser8User89;
        static double[,] impostorScoresUser8User90;

        static double[,] impostorScoresUser8User91;
        static double[,] impostorScoresUser8User92;
        static double[,] impostorScoresUser8User93;
        static double[,] impostorScoresUser8User94;
        static double[,] impostorScoresUser8User95;
        static double[,] impostorScoresUser8User96;
        static double[,] impostorScoresUser8User97;
        static double[,] impostorScoresUser8User98;
        static double[,] impostorScoresUser8User99;
        static double[,] impostorScoresUser8User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 9 as the training (using the mean vector for user 9 in calculating the impostor scores)
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
        static double[,] impostorScoresUser9User34;
        static double[,] impostorScoresUser9User35;
        static double[,] impostorScoresUser9User36;
        static double[,] impostorScoresUser9User37;
        static double[,] impostorScoresUser9User38;
        static double[,] impostorScoresUser9User39;
        static double[,] impostorScoresUser9User40;

        static double[,] impostorScoresUser9User41;
        static double[,] impostorScoresUser9User42;
        static double[,] impostorScoresUser9User43;
        static double[,] impostorScoresUser9User44;
        static double[,] impostorScoresUser9User45;
        static double[,] impostorScoresUser9User46;
        static double[,] impostorScoresUser9User47;
        static double[,] impostorScoresUser9User48;
        static double[,] impostorScoresUser9User49;
        static double[,] impostorScoresUser9User50;

        static double[,] impostorScoresUser9User51;
        static double[,] impostorScoresUser9User52;
        static double[,] impostorScoresUser9User53;
        static double[,] impostorScoresUser9User54;
        static double[,] impostorScoresUser9User55;
        static double[,] impostorScoresUser9User56;
        static double[,] impostorScoresUser9User57;
        static double[,] impostorScoresUser9User58;
        static double[,] impostorScoresUser9User59;
        static double[,] impostorScoresUser9User60;

        static double[,] impostorScoresUser9User61;
        static double[,] impostorScoresUser9User62;
        static double[,] impostorScoresUser9User63;
        static double[,] impostorScoresUser9User64;
        static double[,] impostorScoresUser9User65;
        static double[,] impostorScoresUser9User66;
        static double[,] impostorScoresUser9User67;
        static double[,] impostorScoresUser9User68;
        static double[,] impostorScoresUser9User69;
        static double[,] impostorScoresUser9User70;

        static double[,] impostorScoresUser9User71;
        static double[,] impostorScoresUser9User72;
        static double[,] impostorScoresUser9User73;
        static double[,] impostorScoresUser9User74;
        static double[,] impostorScoresUser9User75;
        static double[,] impostorScoresUser9User76;
        static double[,] impostorScoresUser9User77;
        static double[,] impostorScoresUser9User78;
        static double[,] impostorScoresUser9User79;
        static double[,] impostorScoresUser9User80;

        static double[,] impostorScoresUser9User81;
        static double[,] impostorScoresUser9User82;
        static double[,] impostorScoresUser9User83;
        static double[,] impostorScoresUser9User84;
        static double[,] impostorScoresUser9User85;
        static double[,] impostorScoresUser9User86;
        static double[,] impostorScoresUser9User87;
        static double[,] impostorScoresUser9User88;
        static double[,] impostorScoresUser9User89;
        static double[,] impostorScoresUser9User90;

        static double[,] impostorScoresUser9User91;
        static double[,] impostorScoresUser9User92;
        static double[,] impostorScoresUser9User93;
        static double[,] impostorScoresUser9User94;
        static double[,] impostorScoresUser9User95;
        static double[,] impostorScoresUser9User96;
        static double[,] impostorScoresUser9User97;
        static double[,] impostorScoresUser9User98;
        static double[,] impostorScoresUser9User99;
        static double[,] impostorScoresUser9User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 10 as the training (using the mean vector for user 10 in calculating the impostor scores)
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
        static double[,] impostorScoresUser10User34;
        static double[,] impostorScoresUser10User35;
        static double[,] impostorScoresUser10User36;
        static double[,] impostorScoresUser10User37;
        static double[,] impostorScoresUser10User38;
        static double[,] impostorScoresUser10User39;
        static double[,] impostorScoresUser10User40;

        static double[,] impostorScoresUser10User41;
        static double[,] impostorScoresUser10User42;
        static double[,] impostorScoresUser10User43;
        static double[,] impostorScoresUser10User44;
        static double[,] impostorScoresUser10User45;
        static double[,] impostorScoresUser10User46;
        static double[,] impostorScoresUser10User47;
        static double[,] impostorScoresUser10User48;
        static double[,] impostorScoresUser10User49;
        static double[,] impostorScoresUser10User50;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 11 as the training (using the mean vector for user 11 in calculating the impostor scores)
        
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

            DataFiltering DataFilter = new DataFiltering(); 

            #region Data Extraction - This will be done before jumping into the use of any verifier
            s001 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user1.csv");
            s002 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user2.csv");
            s003 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user3.csv");
            s004 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user4.csv");
            s005 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user5.csv");
            s006 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user6.csv"); 
            s007 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user7.csv");
            s008 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user8.csv");
            s009 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user9.csv");
            s010 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user10.csv");
            
            s011 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user11.csv");
            s012 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user12.csv"); 
            s013 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user13.csv");
            s014 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user14.csv");
            s015 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user15.csv");
            s016 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user16.csv");
            s017 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user17.csv");
            s018 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user18.csv");
            s019 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user19.csv");
            s020 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user20.csv"); 

            s021 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user21.csv");
            s022 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user22.csv");
            s023 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user23.csv");
            s024 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user24.csv");
            s025 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user25.csv");
            s026 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user26.csv");
            s027 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user27.csv");
            s028 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user28.csv");
            s029 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user29.csv");
            s030 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user30.csv");

            s031 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user31.csv");
            s032 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user32.csv");
            s033 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user33.csv");
            s034 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user34.csv");
            s035 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user35.csv");
            s036 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user36.csv");
            s037 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user37.csv");
            s038 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user38.csv");
            s039 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user39.csv");
            s040 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user40.csv");

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

            s061 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user61.csv");
            s062 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user62.csv");
            s063 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user63.csv");
            s064 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user64.csv");
            s065 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user65.csv");
            s066 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user66.csv");
            s067 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user67.csv");
            s068 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user68.csv");
            s069 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user69.csv");
            s070 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user70.csv");

            s071 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user71.csv");
            s072 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user72.csv");
            s073 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user73.csv");
            s074 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user74.csv");
            s075 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user75.csv");
            s076 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user76.csv");
            s077 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user77.csv");
            s078 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user78.csv");
            s079 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user79.csv");
            s080 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user80.csv");

            s081 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user81.csv");
            s082 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user82.csv");
            s083 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user83.csv");
            s084 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user84.csv");
            s085 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user85.csv");
            s086 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user86.csv");
            s087 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user87.csv");
            s088 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user88.csv");
            s089 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user89.csv");
            s090 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user90.csv");

            s091 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user91.csv");
            s092 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user92.csv");
            s093 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user93.csv");
            s094 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user94.csv");
            s095 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user95.csv");
            s096 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user96.csv");
            s097 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user97.csv");
            s098 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user98.csv");
            s099 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user99.csv");
            s100 = DataFilter.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user100.csv"); 
            #endregion

            Console.WriteLine("Now choose your verifier: " + Environment.NewLine + "0 for Manhattan" + Environment.NewLine + "1 for Euclidean" + Environment.NewLine + "2 for Scaled Manhattan" + Environment.NewLine + "3 for Scaled Euclidean, or" + Environment.NewLine + "4 to Quit.");

            string input = Console.ReadLine();

            // The user option determines which class, and methods are executed  
            switch (input)
            {
                case "0":
                    UseManhattanVerifier();
                    break;
                case "1":
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
        private static void UseScaledEuclideanVerifier()
        {
            Console.WriteLine("The Scaled Euclidean Verifier is to be coded - TBC"); 
        }

        private static void UseScaledManhattanVerifier()
        {
            ScaledManhattanDistance ScaledManhDist = new ScaledManhattanDistance();

            #region Calculating the mean vectors for all 100 subjects
            s001Mean = ScaledManhDist.CalculateMeanVector(s001);
            s002Mean = ScaledManhDist.CalculateMeanVector(s002);
            s003Mean = ScaledManhDist.CalculateMeanVector(s003);
            s004Mean = ScaledManhDist.CalculateMeanVector(s004);
            s005Mean = ScaledManhDist.CalculateMeanVector(s005);
            s006Mean = ScaledManhDist.CalculateMeanVector(s006);
            s007Mean = ScaledManhDist.CalculateMeanVector(s007);
            s008Mean = ScaledManhDist.CalculateMeanVector(s008);
            s009Mean = ScaledManhDist.CalculateMeanVector(s009);
            s010Mean = ScaledManhDist.CalculateMeanVector(s010);

            s011Mean = ScaledManhDist.CalculateMeanVector(s011);
            s012Mean = ScaledManhDist.CalculateMeanVector(s012);
            s013Mean = ScaledManhDist.CalculateMeanVector(s013);
            s014Mean = ScaledManhDist.CalculateMeanVector(s014);
            s015Mean = ScaledManhDist.CalculateMeanVector(s015);
            s016Mean = ScaledManhDist.CalculateMeanVector(s016);
            s017Mean = ScaledManhDist.CalculateMeanVector(s017);
            s018Mean = ScaledManhDist.CalculateMeanVector(s018);
            s019Mean = ScaledManhDist.CalculateMeanVector(s019);
            s020Mean = ScaledManhDist.CalculateMeanVector(s020);

            s021Mean = ScaledManhDist.CalculateMeanVector(s021);
            s022Mean = ScaledManhDist.CalculateMeanVector(s022);
            s023Mean = ScaledManhDist.CalculateMeanVector(s023);
            s024Mean = ScaledManhDist.CalculateMeanVector(s024);
            s025Mean = ScaledManhDist.CalculateMeanVector(s025);
            s026Mean = ScaledManhDist.CalculateMeanVector(s026);
            s027Mean = ScaledManhDist.CalculateMeanVector(s027);
            s028Mean = ScaledManhDist.CalculateMeanVector(s028);
            s029Mean = ScaledManhDist.CalculateMeanVector(s029);
            s030Mean = ScaledManhDist.CalculateMeanVector(s030);

            s031Mean = ScaledManhDist.CalculateMeanVector(s031);
            s032Mean = ScaledManhDist.CalculateMeanVector(s032);
            s033Mean = ScaledManhDist.CalculateMeanVector(s033);
            s034Mean = ScaledManhDist.CalculateMeanVector(s034);
            s035Mean = ScaledManhDist.CalculateMeanVector(s035);
            s036Mean = ScaledManhDist.CalculateMeanVector(s036);
            s037Mean = ScaledManhDist.CalculateMeanVector(s037);
            s038Mean = ScaledManhDist.CalculateMeanVector(s038);
            s039Mean = ScaledManhDist.CalculateMeanVector(s039);
            s040Mean = ScaledManhDist.CalculateMeanVector(s040);

            s041Mean = ScaledManhDist.CalculateMeanVector(s041);
            s042Mean = ScaledManhDist.CalculateMeanVector(s042);
            s043Mean = ScaledManhDist.CalculateMeanVector(s043);
            s044Mean = ScaledManhDist.CalculateMeanVector(s044);
            s045Mean = ScaledManhDist.CalculateMeanVector(s045);
            s046Mean = ScaledManhDist.CalculateMeanVector(s046);
            s047Mean = ScaledManhDist.CalculateMeanVector(s047);
            s048Mean = ScaledManhDist.CalculateMeanVector(s048);
            s049Mean = ScaledManhDist.CalculateMeanVector(s049);
            s050Mean = ScaledManhDist.CalculateMeanVector(s050);

            s051Mean = ScaledManhDist.CalculateMeanVector(s051);
            s052Mean = ScaledManhDist.CalculateMeanVector(s052);
            s053Mean = ScaledManhDist.CalculateMeanVector(s053);
            s054Mean = ScaledManhDist.CalculateMeanVector(s054);
            s055Mean = ScaledManhDist.CalculateMeanVector(s055);
            s056Mean = ScaledManhDist.CalculateMeanVector(s056);
            s057Mean = ScaledManhDist.CalculateMeanVector(s057);
            s058Mean = ScaledManhDist.CalculateMeanVector(s058);
            s059Mean = ScaledManhDist.CalculateMeanVector(s059);
            s060Mean = ScaledManhDist.CalculateMeanVector(s060);

            s061Mean = ScaledManhDist.CalculateMeanVector(s061);
            s062Mean = ScaledManhDist.CalculateMeanVector(s062);
            s063Mean = ScaledManhDist.CalculateMeanVector(s063);
            s064Mean = ScaledManhDist.CalculateMeanVector(s064);
            s065Mean = ScaledManhDist.CalculateMeanVector(s065);
            s066Mean = ScaledManhDist.CalculateMeanVector(s066);
            s067Mean = ScaledManhDist.CalculateMeanVector(s067);
            s068Mean = ScaledManhDist.CalculateMeanVector(s068);
            s069Mean = ScaledManhDist.CalculateMeanVector(s069);
            s070Mean = ScaledManhDist.CalculateMeanVector(s070);

            s071Mean = ScaledManhDist.CalculateMeanVector(s071);
            s072Mean = ScaledManhDist.CalculateMeanVector(s072);
            s073Mean = ScaledManhDist.CalculateMeanVector(s073);
            s074Mean = ScaledManhDist.CalculateMeanVector(s074);
            s075Mean = ScaledManhDist.CalculateMeanVector(s075);
            s076Mean = ScaledManhDist.CalculateMeanVector(s076);
            s077Mean = ScaledManhDist.CalculateMeanVector(s077);
            s078Mean = ScaledManhDist.CalculateMeanVector(s078);
            s079Mean = ScaledManhDist.CalculateMeanVector(s079);
            s080Mean = ScaledManhDist.CalculateMeanVector(s080);

            s081Mean = ScaledManhDist.CalculateMeanVector(s081);
            s082Mean = ScaledManhDist.CalculateMeanVector(s082);
            s083Mean = ScaledManhDist.CalculateMeanVector(s083);
            s084Mean = ScaledManhDist.CalculateMeanVector(s084);
            s085Mean = ScaledManhDist.CalculateMeanVector(s085);
            s086Mean = ScaledManhDist.CalculateMeanVector(s086);
            s087Mean = ScaledManhDist.CalculateMeanVector(s087);
            s088Mean = ScaledManhDist.CalculateMeanVector(s088);
            s089Mean = ScaledManhDist.CalculateMeanVector(s089);
            s090Mean = ScaledManhDist.CalculateMeanVector(s090);

            s091Mean = ScaledManhDist.CalculateMeanVector(s091);
            s092Mean = ScaledManhDist.CalculateMeanVector(s092);
            s093Mean = ScaledManhDist.CalculateMeanVector(s093);
            s094Mean = ScaledManhDist.CalculateMeanVector(s094);
            s095Mean = ScaledManhDist.CalculateMeanVector(s095);
            s096Mean = ScaledManhDist.CalculateMeanVector(s096);
            s097Mean = ScaledManhDist.CalculateMeanVector(s097);
            s098Mean = ScaledManhDist.CalculateMeanVector(s098);
            s099Mean = ScaledManhDist.CalculateMeanVector(s099);
            s100Mean = ScaledManhDist.CalculateMeanVector(s100);
            #endregion
        }

        private static void UseEuclideanVerifier()
        {
            EuclideanDistance EuclidDist = new EuclideanDistance();

            #region Populating the mean arrays for each user under the Euclidean Distance method
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
            s024Mean = EuclidDist.CalculateMeanVector(s024);
            s025Mean = EuclidDist.CalculateMeanVector(s025);
            s026Mean = EuclidDist.CalculateMeanVector(s026);
            s027Mean = EuclidDist.CalculateMeanVector(s027);
            s028Mean = EuclidDist.CalculateMeanVector(s028);
            s029Mean = EuclidDist.CalculateMeanVector(s029);
            s030Mean = EuclidDist.CalculateMeanVector(s030);

            s031Mean = EuclidDist.CalculateMeanVector(s031);
            s032Mean = EuclidDist.CalculateMeanVector(s032);
            s033Mean = EuclidDist.CalculateMeanVector(s033);
            s034Mean = EuclidDist.CalculateMeanVector(s034);
            s035Mean = EuclidDist.CalculateMeanVector(s035);
            s036Mean = EuclidDist.CalculateMeanVector(s036);
            s037Mean = EuclidDist.CalculateMeanVector(s037);
            s038Mean = EuclidDist.CalculateMeanVector(s038);
            s039Mean = EuclidDist.CalculateMeanVector(s039);
            s040Mean = EuclidDist.CalculateMeanVector(s040);

            s041Mean = EuclidDist.CalculateMeanVector(s041);
            s042Mean = EuclidDist.CalculateMeanVector(s042);
            s043Mean = EuclidDist.CalculateMeanVector(s043);
            s044Mean = EuclidDist.CalculateMeanVector(s044);
            s045Mean = EuclidDist.CalculateMeanVector(s045);
            s046Mean = EuclidDist.CalculateMeanVector(s046);
            s047Mean = EuclidDist.CalculateMeanVector(s047);
            s048Mean = EuclidDist.CalculateMeanVector(s048);
            s049Mean = EuclidDist.CalculateMeanVector(s049);
            s050Mean = EuclidDist.CalculateMeanVector(s050);

            s051Mean = EuclidDist.CalculateMeanVector(s051);
            s052Mean = EuclidDist.CalculateMeanVector(s052);
            s053Mean = EuclidDist.CalculateMeanVector(s053);
            s054Mean = EuclidDist.CalculateMeanVector(s054);
            s055Mean = EuclidDist.CalculateMeanVector(s055);
            s056Mean = EuclidDist.CalculateMeanVector(s056);
            s057Mean = EuclidDist.CalculateMeanVector(s057);
            s058Mean = EuclidDist.CalculateMeanVector(s058);
            s059Mean = EuclidDist.CalculateMeanVector(s059);
            s060Mean = EuclidDist.CalculateMeanVector(s060);
            
            s061Mean = EuclidDist.CalculateMeanVector(s061);
            s062Mean = EuclidDist.CalculateMeanVector(s062);
            s063Mean = EuclidDist.CalculateMeanVector(s063);
            s064Mean = EuclidDist.CalculateMeanVector(s064);
            s065Mean = EuclidDist.CalculateMeanVector(s065);
            s066Mean = EuclidDist.CalculateMeanVector(s066);
            s067Mean = EuclidDist.CalculateMeanVector(s067);
            s068Mean = EuclidDist.CalculateMeanVector(s068);
            s069Mean = EuclidDist.CalculateMeanVector(s069);
            s070Mean = EuclidDist.CalculateMeanVector(s070);

            s071Mean = EuclidDist.CalculateMeanVector(s071);
            s072Mean = EuclidDist.CalculateMeanVector(s072);
            s073Mean = EuclidDist.CalculateMeanVector(s073);
            s074Mean = EuclidDist.CalculateMeanVector(s074);
            s075Mean = EuclidDist.CalculateMeanVector(s075);
            s076Mean = EuclidDist.CalculateMeanVector(s076);
            s077Mean = EuclidDist.CalculateMeanVector(s077);
            s078Mean = EuclidDist.CalculateMeanVector(s078);
            s079Mean = EuclidDist.CalculateMeanVector(s079);
            s080Mean = EuclidDist.CalculateMeanVector(s080);

            s081Mean = EuclidDist.CalculateMeanVector(s081);
            s082Mean = EuclidDist.CalculateMeanVector(s082);
            s083Mean = EuclidDist.CalculateMeanVector(s083);
            s084Mean = EuclidDist.CalculateMeanVector(s084);
            s085Mean = EuclidDist.CalculateMeanVector(s085);
            s086Mean = EuclidDist.CalculateMeanVector(s086);
            s087Mean = EuclidDist.CalculateMeanVector(s087);
            s088Mean = EuclidDist.CalculateMeanVector(s088);
            s089Mean = EuclidDist.CalculateMeanVector(s089);
            s090Mean = EuclidDist.CalculateMeanVector(s090);

            s091Mean = EuclidDist.CalculateMeanVector(s091);
            s092Mean = EuclidDist.CalculateMeanVector(s092);
            s093Mean = EuclidDist.CalculateMeanVector(s093);
            s094Mean = EuclidDist.CalculateMeanVector(s094);
            s095Mean = EuclidDist.CalculateMeanVector(s095);
            s096Mean = EuclidDist.CalculateMeanVector(s096);
            s097Mean = EuclidDist.CalculateMeanVector(s097);
            s098Mean = EuclidDist.CalculateMeanVector(s098);
            s099Mean = EuclidDist.CalculateMeanVector(s099);
            s100Mean = EuclidDist.CalculateMeanVector(s100); 
            #endregion

            #region Populating the genuine scores for each user as outlined by the Normalized Euclidean Distance
            s001Gen = EuclidDist.CalculateGenuineScores(s001, s001Mean);
            s002Gen = EuclidDist.CalculateGenuineScores(s002, s002Mean);
            s003Gen = EuclidDist.CalculateGenuineScores(s003, s003Mean);
            s004Gen = EuclidDist.CalculateGenuineScores(s004, s004Mean);
            s005Gen = EuclidDist.CalculateGenuineScores(s005, s005Mean);
            s006Gen = EuclidDist.CalculateGenuineScores(s006, s006Mean);
            s007Gen = EuclidDist.CalculateGenuineScores(s007, s007Mean);
            s008Gen = EuclidDist.CalculateGenuineScores(s008, s008Mean);
            s009Gen = EuclidDist.CalculateGenuineScores(s009, s009Mean);
            s010Gen = EuclidDist.CalculateGenuineScores(s010, s010Mean);
            
            s011Gen = EuclidDist.CalculateGenuineScores(s011, s011Mean);
            s012Gen = EuclidDist.CalculateGenuineScores(s012, s012Mean);
            s013Gen = EuclidDist.CalculateGenuineScores(s013, s013Mean);
            s014Gen = EuclidDist.CalculateGenuineScores(s014, s014Mean);
            s015Gen = EuclidDist.CalculateGenuineScores(s015, s015Mean);
            s016Gen = EuclidDist.CalculateGenuineScores(s016, s016Mean);
            s017Gen = EuclidDist.CalculateGenuineScores(s017, s017Mean);
            s018Gen = EuclidDist.CalculateGenuineScores(s018, s018Mean);
            s019Gen = EuclidDist.CalculateGenuineScores(s019, s019Mean);
            s020Gen = EuclidDist.CalculateGenuineScores(s020, s020Mean);

            s021Gen = EuclidDist.CalculateGenuineScores(s021, s021Mean);
            s022Gen = EuclidDist.CalculateGenuineScores(s022, s022Mean);
            s023Gen = EuclidDist.CalculateGenuineScores(s023, s023Mean);
            s024Gen = EuclidDist.CalculateGenuineScores(s024, s024Mean);
            s025Gen = EuclidDist.CalculateGenuineScores(s025, s025Mean);
            s026Gen = EuclidDist.CalculateGenuineScores(s026, s026Mean);
            s027Gen = EuclidDist.CalculateGenuineScores(s027, s027Mean);
            s028Gen = EuclidDist.CalculateGenuineScores(s028, s028Mean);
            s029Gen = EuclidDist.CalculateGenuineScores(s029, s029Mean);
            s030Gen = EuclidDist.CalculateGenuineScores(s030, s030Mean);

            s031Gen = EuclidDist.CalculateGenuineScores(s031, s031Mean);
            s032Gen = EuclidDist.CalculateGenuineScores(s032, s032Mean);
            s033Gen = EuclidDist.CalculateGenuineScores(s033, s033Mean);
            s034Gen = EuclidDist.CalculateGenuineScores(s034, s034Mean);
            s035Gen = EuclidDist.CalculateGenuineScores(s035, s035Mean);
            s036Gen = EuclidDist.CalculateGenuineScores(s036, s036Mean);
            s037Gen = EuclidDist.CalculateGenuineScores(s037, s037Mean);
            s038Gen = EuclidDist.CalculateGenuineScores(s038, s038Mean);
            s039Gen = EuclidDist.CalculateGenuineScores(s039, s039Mean);
            s040Gen = EuclidDist.CalculateGenuineScores(s040, s040Mean);

            s041Gen = EuclidDist.CalculateGenuineScores(s041, s041Mean);
            s042Gen = EuclidDist.CalculateGenuineScores(s042, s042Mean);
            s043Gen = EuclidDist.CalculateGenuineScores(s043, s043Mean);
            s044Gen = EuclidDist.CalculateGenuineScores(s044, s044Mean);
            s045Gen = EuclidDist.CalculateGenuineScores(s045, s045Mean);
            s046Gen = EuclidDist.CalculateGenuineScores(s046, s046Mean);
            s047Gen = EuclidDist.CalculateGenuineScores(s047, s047Mean);
            s048Gen = EuclidDist.CalculateGenuineScores(s048, s048Mean);
            s049Gen = EuclidDist.CalculateGenuineScores(s049, s049Mean);
            s050Gen = EuclidDist.CalculateGenuineScores(s050, s050Mean);

            s051Gen = EuclidDist.CalculateGenuineScores(s051, s051Mean);
            s052Gen = EuclidDist.CalculateGenuineScores(s052, s052Mean);
            s053Gen = EuclidDist.CalculateGenuineScores(s053, s053Mean);
            s054Gen = EuclidDist.CalculateGenuineScores(s054, s054Mean);
            s055Gen = EuclidDist.CalculateGenuineScores(s055, s055Mean);
            s056Gen = EuclidDist.CalculateGenuineScores(s056, s056Mean);
            s057Gen = EuclidDist.CalculateGenuineScores(s057, s057Mean);
            s058Gen = EuclidDist.CalculateGenuineScores(s058, s058Mean);
            s059Gen = EuclidDist.CalculateGenuineScores(s059, s059Mean);
            s060Gen = EuclidDist.CalculateGenuineScores(s060, s060Mean);

            s061Gen = EuclidDist.CalculateGenuineScores(s061, s061Mean);
            s062Gen = EuclidDist.CalculateGenuineScores(s062, s062Mean);
            s063Gen = EuclidDist.CalculateGenuineScores(s063, s063Mean);
            s064Gen = EuclidDist.CalculateGenuineScores(s064, s064Mean);
            s065Gen = EuclidDist.CalculateGenuineScores(s065, s065Mean);
            s066Gen = EuclidDist.CalculateGenuineScores(s066, s066Mean);
            s067Gen = EuclidDist.CalculateGenuineScores(s067, s067Mean);
            s068Gen = EuclidDist.CalculateGenuineScores(s068, s068Mean);
            s069Gen = EuclidDist.CalculateGenuineScores(s069, s069Mean);
            s070Gen = EuclidDist.CalculateGenuineScores(s070, s070Mean);

            s071Gen = EuclidDist.CalculateGenuineScores(s071, s071Mean);
            s072Gen = EuclidDist.CalculateGenuineScores(s072, s072Mean);
            s073Gen = EuclidDist.CalculateGenuineScores(s073, s073Mean);
            s074Gen = EuclidDist.CalculateGenuineScores(s075, s075Mean);
            s076Gen = EuclidDist.CalculateGenuineScores(s076, s076Mean);
            s077Gen = EuclidDist.CalculateGenuineScores(s077, s077Mean);
            s078Gen = EuclidDist.CalculateGenuineScores(s078, s078Mean);
            s079Gen = EuclidDist.CalculateGenuineScores(s079, s079Mean);
            s080Gen = EuclidDist.CalculateGenuineScores(s080, s080Mean);

            s081Gen = EuclidDist.CalculateGenuineScores(s081, s081Mean);
            s082Gen = EuclidDist.CalculateGenuineScores(s082, s082Mean);
            s083Gen = EuclidDist.CalculateGenuineScores(s083, s083Mean);
            s084Gen = EuclidDist.CalculateGenuineScores(s084, s084Mean);
            s085Gen = EuclidDist.CalculateGenuineScores(s085, s085Mean);
            s086Gen = EuclidDist.CalculateGenuineScores(s086, s086Mean);
            s087Gen = EuclidDist.CalculateGenuineScores(s087, s087Mean);
            s088Gen = EuclidDist.CalculateGenuineScores(s088, s088Mean);
            s089Gen = EuclidDist.CalculateGenuineScores(s089, s089Mean);
            s090Gen = EuclidDist.CalculateGenuineScores(s090, s090Mean);

            s091Gen = EuclidDist.CalculateGenuineScores(s091, s091Mean);
            s092Gen = EuclidDist.CalculateGenuineScores(s092, s092Mean);
            s093Gen = EuclidDist.CalculateGenuineScores(s093, s093Mean);
            s094Gen = EuclidDist.CalculateGenuineScores(s093, s093Mean);
            s094Gen = EuclidDist.CalculateGenuineScores(s094, s094Mean);
            s095Gen = EuclidDist.CalculateGenuineScores(s095, s095Mean);
            s096Gen = EuclidDist.CalculateGenuineScores(s096, s096Mean);
            s097Gen = EuclidDist.CalculateGenuineScores(s097, s097Mean);
            s098Gen = EuclidDist.CalculateGenuineScores(s098, s098Mean);
            s099Gen = EuclidDist.CalculateGenuineScores(s099, s099Mean);
            s100Gen = EuclidDist.CalculateGenuineScores(s100, s100Mean); 
            #endregion

            #region Populating the impostor score 2D double arrays

            #region User 1 impostor scores
            impostorScoresUser1User2 = EuclidDist.CalculateImpostorScores(s001Mean, s002);
            impostorScoresUser1User3 = EuclidDist.CalculateImpostorScores(s001Mean, s003);
            impostorScoresUser1User4 = EuclidDist.CalculateImpostorScores(s001Mean, s004);
            impostorScoresUser1User5 = EuclidDist.CalculateImpostorScores(s001Mean, s005);
            impostorScoresUser1User6 = EuclidDist.CalculateImpostorScores(s001Mean, s006);
            impostorScoresUser1User7 = EuclidDist.CalculateImpostorScores(s001Mean, s007);
            impostorScoresUser1User8 = EuclidDist.CalculateImpostorScores(s001Mean, s008);
            impostorScoresUser1User9 = EuclidDist.CalculateImpostorScores(s001Mean, s009);
            impostorScoresUser1User10 = EuclidDist.CalculateImpostorScores(s001Mean, s010);

            impostorScoresUser1User11 = EuclidDist.CalculateImpostorScores(s001Mean, s011);
            impostorScoresUser1User12 = EuclidDist.CalculateImpostorScores(s001Mean, s012);
            impostorScoresUser1User13 = EuclidDist.CalculateImpostorScores(s001Mean, s013);
            impostorScoresUser1User14 = EuclidDist.CalculateImpostorScores(s001Mean, s014);
            impostorScoresUser1User15 = EuclidDist.CalculateImpostorScores(s001Mean, s015);
            impostorScoresUser1User16 = EuclidDist.CalculateImpostorScores(s001Mean, s016);
            impostorScoresUser1User17 = EuclidDist.CalculateImpostorScores(s001Mean, s017);
            impostorScoresUser1User18 = EuclidDist.CalculateImpostorScores(s001Mean, s018);
            impostorScoresUser1User19 = EuclidDist.CalculateImpostorScores(s001Mean, s019);
            impostorScoresUser1User20 = EuclidDist.CalculateImpostorScores(s001Mean, s020);

            impostorScoresUser1User21 = EuclidDist.CalculateImpostorScores(s001Mean, s021);
            impostorScoresUser1User22 = EuclidDist.CalculateImpostorScores(s001Mean, s022);
            impostorScoresUser1User23 = EuclidDist.CalculateImpostorScores(s001Mean, s023);
            impostorScoresUser1User24 = EuclidDist.CalculateImpostorScores(s001Mean, s024);
            impostorScoresUser1User25 = EuclidDist.CalculateImpostorScores(s001Mean, s025);
            impostorScoresUser1User26 = EuclidDist.CalculateImpostorScores(s001Mean, s026);
            impostorScoresUser1User27 = EuclidDist.CalculateImpostorScores(s001Mean, s027);
            impostorScoresUser1User28 = EuclidDist.CalculateImpostorScores(s001Mean, s028);
            impostorScoresUser1User29 = EuclidDist.CalculateImpostorScores(s001Mean, s029);
            impostorScoresUser1User30 = EuclidDist.CalculateImpostorScores(s001Mean, s030);

            impostorScoresUser1User31 = EuclidDist.CalculateImpostorScores(s001Mean, s031);
            impostorScoresUser1User32 = EuclidDist.CalculateImpostorScores(s001Mean, s032);
            impostorScoresUser1User33 = EuclidDist.CalculateImpostorScores(s001Mean, s033);
            impostorScoresUser1User34 = EuclidDist.CalculateImpostorScores(s001Mean, s034);
            impostorScoresUser1User35 = EuclidDist.CalculateImpostorScores(s001Mean, s035);
            impostorScoresUser1User36 = EuclidDist.CalculateImpostorScores(s001Mean, s036);
            impostorScoresUser1User37 = EuclidDist.CalculateImpostorScores(s001Mean, s037);
            impostorScoresUser1User38 = EuclidDist.CalculateImpostorScores(s001Mean, s038);
            impostorScoresUser1User39 = EuclidDist.CalculateImpostorScores(s001Mean, s039);
            impostorScoresUser1User40 = EuclidDist.CalculateImpostorScores(s001Mean, s040);

            impostorScoresUser1User41 = EuclidDist.CalculateImpostorScores(s001Mean, s041);
            impostorScoresUser1User42 = EuclidDist.CalculateImpostorScores(s001Mean, s042);
            impostorScoresUser1User43 = EuclidDist.CalculateImpostorScores(s001Mean, s043);
            impostorScoresUser1User44 = EuclidDist.CalculateImpostorScores(s001Mean, s044);
            impostorScoresUser1User45 = EuclidDist.CalculateImpostorScores(s001Mean, s045);
            impostorScoresUser1User46 = EuclidDist.CalculateImpostorScores(s001Mean, s046);
            impostorScoresUser1User47 = EuclidDist.CalculateImpostorScores(s001Mean, s047);
            impostorScoresUser1User48 = EuclidDist.CalculateImpostorScores(s001Mean, s048);
            impostorScoresUser1User49 = EuclidDist.CalculateImpostorScores(s001Mean, s049);
            impostorScoresUser1User50 = EuclidDist.CalculateImpostorScores(s001Mean, s050);

            impostorScoresUser1User51 = EuclidDist.CalculateImpostorScores(s001Mean, s051);
            impostorScoresUser1User52 = EuclidDist.CalculateImpostorScores(s001Mean, s052);
            impostorScoresUser1User53 = EuclidDist.CalculateImpostorScores(s001Mean, s053);
            impostorScoresUser1User54 = EuclidDist.CalculateImpostorScores(s001Mean, s054);
            impostorScoresUser1User55 = EuclidDist.CalculateImpostorScores(s001Mean, s055);
            impostorScoresUser1User56 = EuclidDist.CalculateImpostorScores(s001Mean, s056);
            impostorScoresUser1User57 = EuclidDist.CalculateImpostorScores(s001Mean, s057);
            impostorScoresUser1User58 = EuclidDist.CalculateImpostorScores(s001Mean, s058);
            impostorScoresUser1User59 = EuclidDist.CalculateImpostorScores(s001Mean, s059);
            impostorScoresUser1User60 = EuclidDist.CalculateImpostorScores(s001Mean, s060);

            impostorScoresUser1User61 = EuclidDist.CalculateImpostorScores(s001Mean, s061);
            impostorScoresUser1User62 = EuclidDist.CalculateImpostorScores(s001Mean, s062);
            impostorScoresUser1User63 = EuclidDist.CalculateImpostorScores(s001Mean, s063);
            impostorScoresUser1User64 = EuclidDist.CalculateImpostorScores(s001Mean, s064);
            impostorScoresUser1User65 = EuclidDist.CalculateImpostorScores(s001Mean, s065);
            impostorScoresUser1User66 = EuclidDist.CalculateImpostorScores(s001Mean, s066);
            impostorScoresUser1User67 = EuclidDist.CalculateImpostorScores(s001Mean, s067);
            impostorScoresUser1User68 = EuclidDist.CalculateImpostorScores(s001Mean, s068);
            impostorScoresUser1User69 = EuclidDist.CalculateImpostorScores(s001Mean, s069);
            impostorScoresUser1User70 = EuclidDist.CalculateImpostorScores(s001Mean, s070);

            impostorScoresUser1User71 = EuclidDist.CalculateImpostorScores(s001Mean, s071);
            impostorScoresUser1User72 = EuclidDist.CalculateImpostorScores(s001Mean, s072);
            impostorScoresUser1User73 = EuclidDist.CalculateImpostorScores(s001Mean, s073);
            impostorScoresUser1User74 = EuclidDist.CalculateImpostorScores(s001Mean, s074);
            impostorScoresUser1User75 = EuclidDist.CalculateImpostorScores(s001Mean, s075);
            impostorScoresUser1User76 = EuclidDist.CalculateImpostorScores(s001Mean, s076);
            impostorScoresUser1User77 = EuclidDist.CalculateImpostorScores(s001Mean, s077);
            impostorScoresUser1User78 = EuclidDist.CalculateImpostorScores(s001Mean, s078);
            impostorScoresUser1User79 = EuclidDist.CalculateImpostorScores(s001Mean, s079);
            impostorScoresUser1User80 = EuclidDist.CalculateImpostorScores(s001Mean, s080);

            impostorScoresUser1User81 = EuclidDist.CalculateImpostorScores(s001Mean, s081);
            impostorScoresUser1User82 = EuclidDist.CalculateImpostorScores(s001Mean, s082);
            impostorScoresUser1User83 = EuclidDist.CalculateImpostorScores(s001Mean, s083);
            impostorScoresUser1User84 = EuclidDist.CalculateImpostorScores(s001Mean, s084);
            impostorScoresUser1User85 = EuclidDist.CalculateImpostorScores(s001Mean, s085);
            impostorScoresUser1User86 = EuclidDist.CalculateImpostorScores(s001Mean, s086);
            impostorScoresUser1User87 = EuclidDist.CalculateImpostorScores(s001Mean, s087);
            impostorScoresUser1User88 = EuclidDist.CalculateImpostorScores(s001Mean, s088);
            impostorScoresUser1User89 = EuclidDist.CalculateImpostorScores(s001Mean, s089);
            impostorScoresUser1User90 = EuclidDist.CalculateImpostorScores(s001Mean, s090);

            impostorScoresUser1User91 = EuclidDist.CalculateImpostorScores(s001Mean, s091);
            impostorScoresUser1User92 = EuclidDist.CalculateImpostorScores(s001Mean, s092);
            impostorScoresUser1User93 = EuclidDist.CalculateImpostorScores(s001Mean, s093);
            impostorScoresUser1User94 = EuclidDist.CalculateImpostorScores(s001Mean, s094);
            impostorScoresUser1User95 = EuclidDist.CalculateImpostorScores(s001Mean, s095);
            impostorScoresUser1User96 = EuclidDist.CalculateImpostorScores(s001Mean, s096);
            impostorScoresUser1User97 = EuclidDist.CalculateImpostorScores(s001Mean, s097);
            impostorScoresUser1User98 = EuclidDist.CalculateImpostorScores(s001Mean, s098);
            impostorScoresUser1User99 = EuclidDist.CalculateImpostorScores(s001Mean, s099);
            impostorScoresUser1User100 = EuclidDist.CalculateImpostorScores(s001Mean, s100); 
            #endregion

            #region User 2 impostor scores
            impostorScoresUser2User1 = EuclidDist.CalculateImpostorScores(s002Mean, s001);
            impostorScoresUser2User3 = EuclidDist.CalculateImpostorScores(s002Mean, s003);
            impostorScoresUser2User4 = EuclidDist.CalculateImpostorScores(s002Mean, s004);
            impostorScoresUser2User5 = EuclidDist.CalculateImpostorScores(s002Mean, s005);
            impostorScoresUser2User6 = EuclidDist.CalculateImpostorScores(s002Mean, s006);
            impostorScoresUser2User7 = EuclidDist.CalculateImpostorScores(s002Mean, s007);
            impostorScoresUser2User8 = EuclidDist.CalculateImpostorScores(s002Mean, s008);
            impostorScoresUser2User9 = EuclidDist.CalculateImpostorScores(s002Mean, s009);
            impostorScoresUser2User10 = EuclidDist.CalculateImpostorScores(s002Mean, s010);
            
            impostorScoresUser2User11 = EuclidDist.CalculateImpostorScores(s002Mean, s011);
            impostorScoresUser2User12 = EuclidDist.CalculateImpostorScores(s002Mean, s012);
            impostorScoresUser2User13 = EuclidDist.CalculateImpostorScores(s002Mean, s013);
            impostorScoresUser2User14 = EuclidDist.CalculateImpostorScores(s002Mean, s014);
            impostorScoresUser2User15 = EuclidDist.CalculateImpostorScores(s002Mean, s015);
            impostorScoresUser2User16 = EuclidDist.CalculateImpostorScores(s002Mean, s016);
            impostorScoresUser2User17 = EuclidDist.CalculateImpostorScores(s002Mean, s017);
            impostorScoresUser2User18 = EuclidDist.CalculateImpostorScores(s002Mean, s018);
            impostorScoresUser2User19 = EuclidDist.CalculateImpostorScores(s002Mean, s019);
            impostorScoresUser2User20 = EuclidDist.CalculateImpostorScores(s002Mean, s020);

            impostorScoresUser2User21 = EuclidDist.CalculateImpostorScores(s002Mean, s021);
            impostorScoresUser2User22 = EuclidDist.CalculateImpostorScores(s002Mean, s022);
            impostorScoresUser2User23 = EuclidDist.CalculateImpostorScores(s002Mean, s023);
            impostorScoresUser2User24 = EuclidDist.CalculateImpostorScores(s002Mean, s024);
            impostorScoresUser2User25 = EuclidDist.CalculateImpostorScores(s002Mean, s025);
            impostorScoresUser2User26 = EuclidDist.CalculateImpostorScores(s002Mean, s026);
            impostorScoresUser2User27 = EuclidDist.CalculateImpostorScores(s002Mean, s027);
            impostorScoresUser2User28 = EuclidDist.CalculateImpostorScores(s002Mean, s028);
            impostorScoresUser2User29 = EuclidDist.CalculateImpostorScores(s002Mean, s029);
            impostorScoresUser2User30 = EuclidDist.CalculateImpostorScores(s002Mean, s030);

            impostorScoresUser2User31 = EuclidDist.CalculateImpostorScores(s002Mean, s031);
            impostorScoresUser2User32 = EuclidDist.CalculateImpostorScores(s002Mean, s032);
            impostorScoresUser2User33 = EuclidDist.CalculateImpostorScores(s002Mean, s033);
            impostorScoresUser2User34 = EuclidDist.CalculateImpostorScores(s002Mean, s034);
            impostorScoresUser2User35 = EuclidDist.CalculateImpostorScores(s002Mean, s035);
            impostorScoresUser2User36 = EuclidDist.CalculateImpostorScores(s002Mean, s036);
            impostorScoresUser2User37 = EuclidDist.CalculateImpostorScores(s002Mean, s037);
            impostorScoresUser2User38 = EuclidDist.CalculateImpostorScores(s002Mean, s038);
            impostorScoresUser2User39 = EuclidDist.CalculateImpostorScores(s002Mean, s039);
            impostorScoresUser2User40 = EuclidDist.CalculateImpostorScores(s002Mean, s040);

            impostorScoresUser2User41 = EuclidDist.CalculateImpostorScores(s002Mean, s041);
            impostorScoresUser2User42 = EuclidDist.CalculateImpostorScores(s002Mean, s042);
            impostorScoresUser2User43 = EuclidDist.CalculateImpostorScores(s002Mean, s043);
            impostorScoresUser2User44 = EuclidDist.CalculateImpostorScores(s002Mean, s044);
            impostorScoresUser2User45 = EuclidDist.CalculateImpostorScores(s002Mean, s045);
            impostorScoresUser2User46 = EuclidDist.CalculateImpostorScores(s002Mean, s046);
            impostorScoresUser2User47 = EuclidDist.CalculateImpostorScores(s002Mean, s047);
            impostorScoresUser2User48 = EuclidDist.CalculateImpostorScores(s002Mean, s048);
            impostorScoresUser2User49 = EuclidDist.CalculateImpostorScores(s002Mean, s049);
            impostorScoresUser2User50 = EuclidDist.CalculateImpostorScores(s002Mean, s050);

            impostorScoresUser2User51 = EuclidDist.CalculateImpostorScores(s002Mean, s051);
            impostorScoresUser2User52 = EuclidDist.CalculateImpostorScores(s002Mean, s052);
            impostorScoresUser2User53 = EuclidDist.CalculateImpostorScores(s002Mean, s053);
            impostorScoresUser2User54 = EuclidDist.CalculateImpostorScores(s002Mean, s054);
            impostorScoresUser2User55 = EuclidDist.CalculateImpostorScores(s002Mean, s055);
            impostorScoresUser2User56 = EuclidDist.CalculateImpostorScores(s002Mean, s056);
            impostorScoresUser2User57 = EuclidDist.CalculateImpostorScores(s002Mean, s057);
            impostorScoresUser2User58 = EuclidDist.CalculateImpostorScores(s002Mean, s058);
            impostorScoresUser2User59 = EuclidDist.CalculateImpostorScores(s002Mean, s059);
            impostorScoresUser2User60 = EuclidDist.CalculateImpostorScores(s002Mean, s060);

            impostorScoresUser2User61 = EuclidDist.CalculateImpostorScores(s002Mean, s061);
            impostorScoresUser2User62 = EuclidDist.CalculateImpostorScores(s002Mean, s062);
            impostorScoresUser2User63 = EuclidDist.CalculateImpostorScores(s002Mean, s063);
            impostorScoresUser2User64 = EuclidDist.CalculateImpostorScores(s002Mean, s064);
            impostorScoresUser2User65 = EuclidDist.CalculateImpostorScores(s002Mean, s065);
            impostorScoresUser2User66 = EuclidDist.CalculateImpostorScores(s002Mean, s066);
            impostorScoresUser2User67 = EuclidDist.CalculateImpostorScores(s002Mean, s067);
            impostorScoresUser2User68 = EuclidDist.CalculateImpostorScores(s002Mean, s068);
            impostorScoresUser2User69 = EuclidDist.CalculateImpostorScores(s002Mean, s069);
            impostorScoresUser2User70 = EuclidDist.CalculateImpostorScores(s002Mean, s070);

            impostorScoresUser2User71 = EuclidDist.CalculateImpostorScores(s002Mean, s071);
            impostorScoresUser2User72 = EuclidDist.CalculateImpostorScores(s002Mean, s072);
            impostorScoresUser2User73 = EuclidDist.CalculateImpostorScores(s002Mean, s073);
            impostorScoresUser2User74 = EuclidDist.CalculateImpostorScores(s002Mean, s074);
            impostorScoresUser2User75 = EuclidDist.CalculateImpostorScores(s002Mean, s075);
            impostorScoresUser2User76 = EuclidDist.CalculateImpostorScores(s002Mean, s076);
            impostorScoresUser2User77 = EuclidDist.CalculateImpostorScores(s002Mean, s077);
            impostorScoresUser2User78 = EuclidDist.CalculateImpostorScores(s002Mean, s078);
            impostorScoresUser2User79 = EuclidDist.CalculateImpostorScores(s002Mean, s079);
            impostorScoresUser2User80 = EuclidDist.CalculateImpostorScores(s002Mean, s080);

            impostorScoresUser2User81 = EuclidDist.CalculateImpostorScores(s002Mean, s081);
            impostorScoresUser2User82 = EuclidDist.CalculateImpostorScores(s002Mean, s082);
            impostorScoresUser2User83 = EuclidDist.CalculateImpostorScores(s002Mean, s083);
            impostorScoresUser2User84 = EuclidDist.CalculateImpostorScores(s002Mean, s084);
            impostorScoresUser2User85 = EuclidDist.CalculateImpostorScores(s002Mean, s085);
            impostorScoresUser2User86 = EuclidDist.CalculateImpostorScores(s002Mean, s086);
            impostorScoresUser2User87 = EuclidDist.CalculateImpostorScores(s002Mean, s087);
            impostorScoresUser2User88 = EuclidDist.CalculateImpostorScores(s002Mean, s088);
            impostorScoresUser2User89 = EuclidDist.CalculateImpostorScores(s002Mean, s089);
            impostorScoresUser2User90 = EuclidDist.CalculateImpostorScores(s002Mean, s090);

            impostorScoresUser2User91 = EuclidDist.CalculateImpostorScores(s002Mean, s091);
            impostorScoresUser2User92 = EuclidDist.CalculateImpostorScores(s002Mean, s092);
            impostorScoresUser2User93 = EuclidDist.CalculateImpostorScores(s002Mean, s093);
            impostorScoresUser2User94 = EuclidDist.CalculateImpostorScores(s002Mean, s094);
            impostorScoresUser2User95 = EuclidDist.CalculateImpostorScores(s002Mean, s095);
            impostorScoresUser2User96 = EuclidDist.CalculateImpostorScores(s002Mean, s096);
            impostorScoresUser2User97 = EuclidDist.CalculateImpostorScores(s002Mean, s097);
            impostorScoresUser2User98 = EuclidDist.CalculateImpostorScores(s002Mean, s098);
            impostorScoresUser2User99 = EuclidDist.CalculateImpostorScores(s002Mean, s099);
            impostorScoresUser2User100 = EuclidDist.CalculateImpostorScores(s002Mean, s100);
            #endregion

            #region User 3 impostor scores
            impostorScoresUser3User1 = EuclidDist.CalculateImpostorScores(s003Mean, s001); 
            impostorScoresUser3User2 = EuclidDist.CalculateImpostorScores(s003Mean, s002);
            impostorScoresUser3User4 = EuclidDist.CalculateImpostorScores(s003Mean, s004);
            impostorScoresUser3User5 = EuclidDist.CalculateImpostorScores(s003Mean, s005);
            impostorScoresUser3User6 = EuclidDist.CalculateImpostorScores(s003Mean, s006);
            impostorScoresUser3User7 = EuclidDist.CalculateImpostorScores(s003Mean, s007);
            impostorScoresUser3User8 = EuclidDist.CalculateImpostorScores(s003Mean, s008);
            impostorScoresUser3User9 = EuclidDist.CalculateImpostorScores(s003Mean, s009);

            impostorScoresUser3User10 = EuclidDist.CalculateImpostorScores(s003Mean, s010);
            impostorScoresUser3User11 = EuclidDist.CalculateImpostorScores(s003Mean, s011);
            impostorScoresUser3User12 = EuclidDist.CalculateImpostorScores(s003Mean, s012);
            impostorScoresUser3User13 = EuclidDist.CalculateImpostorScores(s003Mean, s013);
            impostorScoresUser3User14 = EuclidDist.CalculateImpostorScores(s003Mean, s014);
            impostorScoresUser3User15 = EuclidDist.CalculateImpostorScores(s003Mean, s015);
            impostorScoresUser3User16 = EuclidDist.CalculateImpostorScores(s003Mean, s016);
            impostorScoresUser3User17 = EuclidDist.CalculateImpostorScores(s003Mean, s017);
            impostorScoresUser3User18 = EuclidDist.CalculateImpostorScores(s003Mean, s018);
            impostorScoresUser3User19 = EuclidDist.CalculateImpostorScores(s003Mean, s019);
            impostorScoresUser3User20 = EuclidDist.CalculateImpostorScores(s003Mean, s020);

            impostorScoresUser3User21 = EuclidDist.CalculateImpostorScores(s003Mean, s021);
            impostorScoresUser3User22 = EuclidDist.CalculateImpostorScores(s003Mean, s022);
            impostorScoresUser3User23 = EuclidDist.CalculateImpostorScores(s003Mean, s023);
            impostorScoresUser3User24 = EuclidDist.CalculateImpostorScores(s003Mean, s024);
            impostorScoresUser3User25 = EuclidDist.CalculateImpostorScores(s003Mean, s025);
            impostorScoresUser3User26 = EuclidDist.CalculateImpostorScores(s003Mean, s026);
            impostorScoresUser3User27 = EuclidDist.CalculateImpostorScores(s003Mean, s027);
            impostorScoresUser3User28 = EuclidDist.CalculateImpostorScores(s003Mean, s028);
            impostorScoresUser3User29 = EuclidDist.CalculateImpostorScores(s003Mean, s029);
            impostorScoresUser3User30 = EuclidDist.CalculateImpostorScores(s003Mean, s030);

            impostorScoresUser3User31 = EuclidDist.CalculateImpostorScores(s003Mean, s031);
            impostorScoresUser3User32 = EuclidDist.CalculateImpostorScores(s003Mean, s032);
            impostorScoresUser3User33 = EuclidDist.CalculateImpostorScores(s003Mean, s033);
            impostorScoresUser3User34 = EuclidDist.CalculateImpostorScores(s003Mean, s034);
            impostorScoresUser3User35 = EuclidDist.CalculateImpostorScores(s003Mean, s035);
            impostorScoresUser3User36 = EuclidDist.CalculateImpostorScores(s003Mean, s036);
            impostorScoresUser3User37 = EuclidDist.CalculateImpostorScores(s003Mean, s037);
            impostorScoresUser3User38 = EuclidDist.CalculateImpostorScores(s003Mean, s038);
            impostorScoresUser3User39 = EuclidDist.CalculateImpostorScores(s003Mean, s039);
            impostorScoresUser3User40 = EuclidDist.CalculateImpostorScores(s003Mean, s040);

            impostorScoresUser3User41 = EuclidDist.CalculateImpostorScores(s003Mean, s041);
            impostorScoresUser3User42 = EuclidDist.CalculateImpostorScores(s003Mean, s042);
            impostorScoresUser3User43 = EuclidDist.CalculateImpostorScores(s003Mean, s043);
            impostorScoresUser3User44 = EuclidDist.CalculateImpostorScores(s003Mean, s044);
            impostorScoresUser3User45 = EuclidDist.CalculateImpostorScores(s003Mean, s045);
            impostorScoresUser3User46 = EuclidDist.CalculateImpostorScores(s003Mean, s046);
            impostorScoresUser3User47 = EuclidDist.CalculateImpostorScores(s003Mean, s047);
            impostorScoresUser3User48 = EuclidDist.CalculateImpostorScores(s003Mean, s048);
            impostorScoresUser3User49 = EuclidDist.CalculateImpostorScores(s003Mean, s049);
            impostorScoresUser3User50 = EuclidDist.CalculateImpostorScores(s003Mean, s050);

            impostorScoresUser3User51 = EuclidDist.CalculateImpostorScores(s003Mean, s051);
            impostorScoresUser3User52 = EuclidDist.CalculateImpostorScores(s003Mean, s052);
            impostorScoresUser3User53 = EuclidDist.CalculateImpostorScores(s003Mean, s053);
            impostorScoresUser3User54 = EuclidDist.CalculateImpostorScores(s003Mean, s054);
            impostorScoresUser3User55 = EuclidDist.CalculateImpostorScores(s003Mean, s055);
            impostorScoresUser3User56 = EuclidDist.CalculateImpostorScores(s003Mean, s056);
            impostorScoresUser3User57 = EuclidDist.CalculateImpostorScores(s003Mean, s057);
            impostorScoresUser3User58 = EuclidDist.CalculateImpostorScores(s003Mean, s058);
            impostorScoresUser3User59 = EuclidDist.CalculateImpostorScores(s003Mean, s059);
            impostorScoresUser3User60 = EuclidDist.CalculateImpostorScores(s003Mean, s060);

            impostorScoresUser3User61 = EuclidDist.CalculateImpostorScores(s003Mean, s061);
            impostorScoresUser3User62 = EuclidDist.CalculateImpostorScores(s003Mean, s062);
            impostorScoresUser3User63 = EuclidDist.CalculateImpostorScores(s003Mean, s063);
            impostorScoresUser3User64 = EuclidDist.CalculateImpostorScores(s003Mean, s064);
            impostorScoresUser3User65 = EuclidDist.CalculateImpostorScores(s003Mean, s065);
            impostorScoresUser3User66 = EuclidDist.CalculateImpostorScores(s003Mean, s066);
            impostorScoresUser3User67 = EuclidDist.CalculateImpostorScores(s003Mean, s067);
            impostorScoresUser3User68 = EuclidDist.CalculateImpostorScores(s003Mean, s068);
            impostorScoresUser3User69 = EuclidDist.CalculateImpostorScores(s003Mean, s069);
            impostorScoresUser3User70 = EuclidDist.CalculateImpostorScores(s003Mean, s070);

            impostorScoresUser3User71 = EuclidDist.CalculateImpostorScores(s003Mean, s071);
            impostorScoresUser3User72 = EuclidDist.CalculateImpostorScores(s003Mean, s072);
            impostorScoresUser3User73 = EuclidDist.CalculateImpostorScores(s003Mean, s073);
            impostorScoresUser3User74 = EuclidDist.CalculateImpostorScores(s003Mean, s074);
            impostorScoresUser3User75 = EuclidDist.CalculateImpostorScores(s003Mean, s075);
            impostorScoresUser3User76 = EuclidDist.CalculateImpostorScores(s003Mean, s076);
            impostorScoresUser3User77 = EuclidDist.CalculateImpostorScores(s003Mean, s077);
            impostorScoresUser3User78 = EuclidDist.CalculateImpostorScores(s003Mean, s078);
            impostorScoresUser3User79 = EuclidDist.CalculateImpostorScores(s003Mean, s079);
            impostorScoresUser3User80 = EuclidDist.CalculateImpostorScores(s003Mean, s080);

            impostorScoresUser3User81 = EuclidDist.CalculateImpostorScores(s003Mean, s081);
            impostorScoresUser3User82 = EuclidDist.CalculateImpostorScores(s003Mean, s082);
            impostorScoresUser3User83 = EuclidDist.CalculateImpostorScores(s003Mean, s083);
            impostorScoresUser3User84 = EuclidDist.CalculateImpostorScores(s003Mean, s084);
            impostorScoresUser3User85 = EuclidDist.CalculateImpostorScores(s003Mean, s085);
            impostorScoresUser3User86 = EuclidDist.CalculateImpostorScores(s003Mean, s086);
            impostorScoresUser3User87 = EuclidDist.CalculateImpostorScores(s003Mean, s087);
            impostorScoresUser3User88 = EuclidDist.CalculateImpostorScores(s003Mean, s088);
            impostorScoresUser3User89 = EuclidDist.CalculateImpostorScores(s003Mean, s089);
            impostorScoresUser3User90 = EuclidDist.CalculateImpostorScores(s003Mean, s090);

            impostorScoresUser3User91 = EuclidDist.CalculateImpostorScores(s003Mean, s091);
            impostorScoresUser3User92 = EuclidDist.CalculateImpostorScores(s003Mean, s092);
            impostorScoresUser3User93 = EuclidDist.CalculateImpostorScores(s003Mean, s093);
            impostorScoresUser3User94 = EuclidDist.CalculateImpostorScores(s003Mean, s094);
            impostorScoresUser3User95 = EuclidDist.CalculateImpostorScores(s003Mean, s095);
            impostorScoresUser3User96 = EuclidDist.CalculateImpostorScores(s003Mean, s096);
            impostorScoresUser3User97 = EuclidDist.CalculateImpostorScores(s003Mean, s097);
            impostorScoresUser3User98 = EuclidDist.CalculateImpostorScores(s003Mean, s098);
            impostorScoresUser3User99 = EuclidDist.CalculateImpostorScores(s003Mean, s099);
            impostorScoresUser3User100 = EuclidDist.CalculateImpostorScores(s003Mean, s100);
            #endregion

            #region User 4 impostor scores
            impostorScoresUser4User1 = EuclidDist.CalculateImpostorScores(s004Mean, s001);
            impostorScoresUser4User2 = EuclidDist.CalculateImpostorScores(s004Mean, s002);
            impostorScoresUser4User3 = EuclidDist.CalculateImpostorScores(s004Mean, s003);
            impostorScoresUser4User5 = EuclidDist.CalculateImpostorScores(s004Mean, s005);
            impostorScoresUser4User6 = EuclidDist.CalculateImpostorScores(s004Mean, s006);
            impostorScoresUser4User7 = EuclidDist.CalculateImpostorScores(s004Mean, s007);
            impostorScoresUser4User8 = EuclidDist.CalculateImpostorScores(s004Mean, s008);
            impostorScoresUser4User9 = EuclidDist.CalculateImpostorScores(s004Mean, s009);
            impostorScoresUser4User10 = EuclidDist.CalculateImpostorScores(s004Mean, s010);

            impostorScoresUser4User11 = EuclidDist.CalculateImpostorScores(s004Mean, s011);
            impostorScoresUser4User12 = EuclidDist.CalculateImpostorScores(s004Mean, s012);
            impostorScoresUser4User13 = EuclidDist.CalculateImpostorScores(s004Mean, s013);
            impostorScoresUser4User14 = EuclidDist.CalculateImpostorScores(s004Mean, s014);
            impostorScoresUser4User15 = EuclidDist.CalculateImpostorScores(s004Mean, s015);
            impostorScoresUser4User16 = EuclidDist.CalculateImpostorScores(s004Mean, s016);
            impostorScoresUser4User17 = EuclidDist.CalculateImpostorScores(s004Mean, s017);
            impostorScoresUser4User18 = EuclidDist.CalculateImpostorScores(s004Mean, s018);
            impostorScoresUser4User19 = EuclidDist.CalculateImpostorScores(s004Mean, s019);
            impostorScoresUser4User20 = EuclidDist.CalculateImpostorScores(s004Mean, s020);

            impostorScoresUser4User21 = EuclidDist.CalculateImpostorScores(s004Mean, s021);
            impostorScoresUser4User22 = EuclidDist.CalculateImpostorScores(s004Mean, s022);
            impostorScoresUser4User23 = EuclidDist.CalculateImpostorScores(s004Mean, s023);
            impostorScoresUser4User24 = EuclidDist.CalculateImpostorScores(s004Mean, s024);
            impostorScoresUser4User25 = EuclidDist.CalculateImpostorScores(s004Mean, s025);
            impostorScoresUser4User26 = EuclidDist.CalculateImpostorScores(s004Mean, s026);
            impostorScoresUser4User27 = EuclidDist.CalculateImpostorScores(s004Mean, s027);
            impostorScoresUser4User28 = EuclidDist.CalculateImpostorScores(s004Mean, s028);
            impostorScoresUser4User29 = EuclidDist.CalculateImpostorScores(s004Mean, s029);
            impostorScoresUser4User30 = EuclidDist.CalculateImpostorScores(s004Mean, s030);

            impostorScoresUser4User31 = EuclidDist.CalculateImpostorScores(s004Mean, s031);
            impostorScoresUser4User32 = EuclidDist.CalculateImpostorScores(s004Mean, s032);
            impostorScoresUser4User33 = EuclidDist.CalculateImpostorScores(s004Mean, s033);
            impostorScoresUser4User34 = EuclidDist.CalculateImpostorScores(s004Mean, s034);
            impostorScoresUser4User35 = EuclidDist.CalculateImpostorScores(s004Mean, s035);
            impostorScoresUser4User36 = EuclidDist.CalculateImpostorScores(s004Mean, s036);
            impostorScoresUser4User37 = EuclidDist.CalculateImpostorScores(s004Mean, s037);
            impostorScoresUser4User38 = EuclidDist.CalculateImpostorScores(s004Mean, s038);
            impostorScoresUser4User39 = EuclidDist.CalculateImpostorScores(s004Mean, s039);
            impostorScoresUser4User40 = EuclidDist.CalculateImpostorScores(s004Mean, s040);

            impostorScoresUser4User41 = EuclidDist.CalculateImpostorScores(s004Mean, s041);
            impostorScoresUser4User42 = EuclidDist.CalculateImpostorScores(s004Mean, s042);
            impostorScoresUser4User43 = EuclidDist.CalculateImpostorScores(s004Mean, s043);
            impostorScoresUser4User44 = EuclidDist.CalculateImpostorScores(s004Mean, s044);
            impostorScoresUser4User45 = EuclidDist.CalculateImpostorScores(s004Mean, s045);
            impostorScoresUser4User46 = EuclidDist.CalculateImpostorScores(s004Mean, s046);
            impostorScoresUser4User47 = EuclidDist.CalculateImpostorScores(s004Mean, s047);
            impostorScoresUser4User48 = EuclidDist.CalculateImpostorScores(s004Mean, s048);
            impostorScoresUser4User49 = EuclidDist.CalculateImpostorScores(s004Mean, s049);
            impostorScoresUser4User50 = EuclidDist.CalculateImpostorScores(s004Mean, s050);

            impostorScoresUser4User51 = EuclidDist.CalculateImpostorScores(s004Mean, s051);
            impostorScoresUser4User52 = EuclidDist.CalculateImpostorScores(s004Mean, s052);
            impostorScoresUser4User53 = EuclidDist.CalculateImpostorScores(s004Mean, s053);
            impostorScoresUser4User54 = EuclidDist.CalculateImpostorScores(s004Mean, s054);
            impostorScoresUser4User55 = EuclidDist.CalculateImpostorScores(s004Mean, s055);
            impostorScoresUser4User56 = EuclidDist.CalculateImpostorScores(s004Mean, s056);
            impostorScoresUser4User57 = EuclidDist.CalculateImpostorScores(s004Mean, s057);
            impostorScoresUser4User58 = EuclidDist.CalculateImpostorScores(s004Mean, s058);
            impostorScoresUser4User59 = EuclidDist.CalculateImpostorScores(s004Mean, s059);
            impostorScoresUser4User60 = EuclidDist.CalculateImpostorScores(s004Mean, s060);

            impostorScoresUser4User61 = EuclidDist.CalculateImpostorScores(s004Mean, s061);
            impostorScoresUser4User62 = EuclidDist.CalculateImpostorScores(s004Mean, s062);
            impostorScoresUser4User63 = EuclidDist.CalculateImpostorScores(s004Mean, s063);
            impostorScoresUser4User64 = EuclidDist.CalculateImpostorScores(s004Mean, s064);
            impostorScoresUser4User65 = EuclidDist.CalculateImpostorScores(s004Mean, s065);
            impostorScoresUser4User66 = EuclidDist.CalculateImpostorScores(s004Mean, s066);
            impostorScoresUser4User67 = EuclidDist.CalculateImpostorScores(s004Mean, s067);
            impostorScoresUser4User68 = EuclidDist.CalculateImpostorScores(s004Mean, s068);
            impostorScoresUser4User69 = EuclidDist.CalculateImpostorScores(s004Mean, s069);
            impostorScoresUser4User70 = EuclidDist.CalculateImpostorScores(s004Mean, s070);

            impostorScoresUser4User71 = EuclidDist.CalculateImpostorScores(s004Mean, s071);
            impostorScoresUser4User72 = EuclidDist.CalculateImpostorScores(s004Mean, s072);
            impostorScoresUser4User73 = EuclidDist.CalculateImpostorScores(s004Mean, s073);
            impostorScoresUser4User74 = EuclidDist.CalculateImpostorScores(s004Mean, s074);
            impostorScoresUser4User75 = EuclidDist.CalculateImpostorScores(s004Mean, s075);
            impostorScoresUser4User76 = EuclidDist.CalculateImpostorScores(s004Mean, s076);
            impostorScoresUser4User77 = EuclidDist.CalculateImpostorScores(s004Mean, s077);
            impostorScoresUser4User78 = EuclidDist.CalculateImpostorScores(s004Mean, s078);
            impostorScoresUser4User79 = EuclidDist.CalculateImpostorScores(s004Mean, s079);
            impostorScoresUser4User80 = EuclidDist.CalculateImpostorScores(s004Mean, s080);

            impostorScoresUser4User81 = EuclidDist.CalculateImpostorScores(s004Mean, s081);
            impostorScoresUser4User82 = EuclidDist.CalculateImpostorScores(s004Mean, s082);
            impostorScoresUser4User83 = EuclidDist.CalculateImpostorScores(s004Mean, s083);
            impostorScoresUser4User84 = EuclidDist.CalculateImpostorScores(s004Mean, s084);
            impostorScoresUser4User85 = EuclidDist.CalculateImpostorScores(s004Mean, s085);
            impostorScoresUser4User86 = EuclidDist.CalculateImpostorScores(s004Mean, s086);
            impostorScoresUser4User87 = EuclidDist.CalculateImpostorScores(s004Mean, s087);
            impostorScoresUser4User88 = EuclidDist.CalculateImpostorScores(s004Mean, s088);
            impostorScoresUser4User89 = EuclidDist.CalculateImpostorScores(s004Mean, s089);
            impostorScoresUser4User90 = EuclidDist.CalculateImpostorScores(s004Mean, s090);

            impostorScoresUser4User91 = EuclidDist.CalculateImpostorScores(s004Mean, s091);
            impostorScoresUser4User92 = EuclidDist.CalculateImpostorScores(s004Mean, s092);
            impostorScoresUser4User93 = EuclidDist.CalculateImpostorScores(s004Mean, s093);
            impostorScoresUser4User94 = EuclidDist.CalculateImpostorScores(s004Mean, s094);
            impostorScoresUser4User95 = EuclidDist.CalculateImpostorScores(s004Mean, s095);
            impostorScoresUser4User96 = EuclidDist.CalculateImpostorScores(s004Mean, s096);
            impostorScoresUser4User97 = EuclidDist.CalculateImpostorScores(s004Mean, s097);
            impostorScoresUser4User98 = EuclidDist.CalculateImpostorScores(s004Mean, s098);
            impostorScoresUser4User99 = EuclidDist.CalculateImpostorScores(s004Mean, s099);
            impostorScoresUser4User100 = EuclidDist.CalculateImpostorScores(s004Mean, s100); 
            #endregion

            #region User 5 impostor scores
            impostorScoresUser5User1 = EuclidDist.CalculateImpostorScores(s005Mean, s001);
            impostorScoresUser5User2 = EuclidDist.CalculateImpostorScores(s005Mean, s002);
            impostorScoresUser5User3 = EuclidDist.CalculateImpostorScores(s005Mean, s003);
            impostorScoresUser5User4 = EuclidDist.CalculateImpostorScores(s005Mean, s004);
            impostorScoresUser5User6 = EuclidDist.CalculateImpostorScores(s005Mean, s006);
            impostorScoresUser5User7 = EuclidDist.CalculateImpostorScores(s005Mean, s007);
            impostorScoresUser5User8 = EuclidDist.CalculateImpostorScores(s005Mean, s008);
            impostorScoresUser5User9 = EuclidDist.CalculateImpostorScores(s005Mean, s009);
            impostorScoresUser5User10 = EuclidDist.CalculateImpostorScores(s005Mean, s010);

            impostorScoresUser5User11 = EuclidDist.CalculateImpostorScores(s005Mean, s011);
            impostorScoresUser5User12 = EuclidDist.CalculateImpostorScores(s005Mean, s012);
            impostorScoresUser5User13 = EuclidDist.CalculateImpostorScores(s005Mean, s013);
            impostorScoresUser5User14 = EuclidDist.CalculateImpostorScores(s005Mean, s014);
            impostorScoresUser5User15 = EuclidDist.CalculateImpostorScores(s005Mean, s015);
            impostorScoresUser5User16 = EuclidDist.CalculateImpostorScores(s005Mean, s016);
            impostorScoresUser5User17 = EuclidDist.CalculateImpostorScores(s005Mean, s017);
            impostorScoresUser5User18 = EuclidDist.CalculateImpostorScores(s005Mean, s018);
            impostorScoresUser5User19 = EuclidDist.CalculateImpostorScores(s005Mean, s019);
            impostorScoresUser5User20 = EuclidDist.CalculateImpostorScores(s005Mean, s020);

            impostorScoresUser5User21 = EuclidDist.CalculateImpostorScores(s005Mean, s021);
            impostorScoresUser5User22 = EuclidDist.CalculateImpostorScores(s005Mean, s022);
            impostorScoresUser5User23 = EuclidDist.CalculateImpostorScores(s005Mean, s023);
            impostorScoresUser5User24 = EuclidDist.CalculateImpostorScores(s005Mean, s024);
            impostorScoresUser5User25 = EuclidDist.CalculateImpostorScores(s005Mean, s025);
            impostorScoresUser5User26 = EuclidDist.CalculateImpostorScores(s005Mean, s026);
            impostorScoresUser5User27 = EuclidDist.CalculateImpostorScores(s005Mean, s027);
            impostorScoresUser5User28 = EuclidDist.CalculateImpostorScores(s005Mean, s028);
            impostorScoresUser5User29 = EuclidDist.CalculateImpostorScores(s005Mean, s029);
            impostorScoresUser5User30 = EuclidDist.CalculateImpostorScores(s005Mean, s030);

            impostorScoresUser5User31 = EuclidDist.CalculateImpostorScores(s005Mean, s031);
            impostorScoresUser5User32 = EuclidDist.CalculateImpostorScores(s005Mean, s032);
            impostorScoresUser5User33 = EuclidDist.CalculateImpostorScores(s005Mean, s033);
            impostorScoresUser5User34 = EuclidDist.CalculateImpostorScores(s005Mean, s034);
            impostorScoresUser5User35 = EuclidDist.CalculateImpostorScores(s005Mean, s035);
            impostorScoresUser5User36 = EuclidDist.CalculateImpostorScores(s005Mean, s036);
            impostorScoresUser5User37 = EuclidDist.CalculateImpostorScores(s005Mean, s037);
            impostorScoresUser5User38 = EuclidDist.CalculateImpostorScores(s005Mean, s038);
            impostorScoresUser5User39 = EuclidDist.CalculateImpostorScores(s005Mean, s039);
            impostorScoresUser5User40 = EuclidDist.CalculateImpostorScores(s005Mean, s040);

            impostorScoresUser5User41 = EuclidDist.CalculateImpostorScores(s005Mean, s041);
            impostorScoresUser5User42 = EuclidDist.CalculateImpostorScores(s005Mean, s042);
            impostorScoresUser5User43 = EuclidDist.CalculateImpostorScores(s005Mean, s043);
            impostorScoresUser5User44 = EuclidDist.CalculateImpostorScores(s005Mean, s044);
            impostorScoresUser5User45 = EuclidDist.CalculateImpostorScores(s005Mean, s045);
            impostorScoresUser5User46 = EuclidDist.CalculateImpostorScores(s005Mean, s046);
            impostorScoresUser5User47 = EuclidDist.CalculateImpostorScores(s005Mean, s047);
            impostorScoresUser5User48 = EuclidDist.CalculateImpostorScores(s005Mean, s048);
            impostorScoresUser5User49 = EuclidDist.CalculateImpostorScores(s005Mean, s049);
            impostorScoresUser5User50 = EuclidDist.CalculateImpostorScores(s005Mean, s050);

            impostorScoresUser5User51 = EuclidDist.CalculateImpostorScores(s005Mean, s051);
            impostorScoresUser5User52 = EuclidDist.CalculateImpostorScores(s005Mean, s052);
            impostorScoresUser5User53 = EuclidDist.CalculateImpostorScores(s005Mean, s053);
            impostorScoresUser5User54 = EuclidDist.CalculateImpostorScores(s005Mean, s054);
            impostorScoresUser5User55 = EuclidDist.CalculateImpostorScores(s005Mean, s055);
            impostorScoresUser5User56 = EuclidDist.CalculateImpostorScores(s005Mean, s056);
            impostorScoresUser5User57 = EuclidDist.CalculateImpostorScores(s005Mean, s057);
            impostorScoresUser5User58 = EuclidDist.CalculateImpostorScores(s005Mean, s058);
            impostorScoresUser5User59 = EuclidDist.CalculateImpostorScores(s005Mean, s059);
            impostorScoresUser5User60 = EuclidDist.CalculateImpostorScores(s005Mean, s060);

            impostorScoresUser5User61 = EuclidDist.CalculateImpostorScores(s005Mean, s061);
            impostorScoresUser5User62 = EuclidDist.CalculateImpostorScores(s005Mean, s062);
            impostorScoresUser5User63 = EuclidDist.CalculateImpostorScores(s005Mean, s063);
            impostorScoresUser5User64 = EuclidDist.CalculateImpostorScores(s005Mean, s064);
            impostorScoresUser5User65 = EuclidDist.CalculateImpostorScores(s005Mean, s065);
            impostorScoresUser5User66 = EuclidDist.CalculateImpostorScores(s005Mean, s066);
            impostorScoresUser5User67 = EuclidDist.CalculateImpostorScores(s005Mean, s067);
            impostorScoresUser5User68 = EuclidDist.CalculateImpostorScores(s005Mean, s068);
            impostorScoresUser5User69 = EuclidDist.CalculateImpostorScores(s005Mean, s069);
            impostorScoresUser5User70 = EuclidDist.CalculateImpostorScores(s005Mean, s070);

            impostorScoresUser5User71 = EuclidDist.CalculateImpostorScores(s005Mean, s071);
            impostorScoresUser5User72 = EuclidDist.CalculateImpostorScores(s005Mean, s072);
            impostorScoresUser5User73 = EuclidDist.CalculateImpostorScores(s005Mean, s073);
            impostorScoresUser5User74 = EuclidDist.CalculateImpostorScores(s005Mean, s074);
            impostorScoresUser5User75 = EuclidDist.CalculateImpostorScores(s005Mean, s075);
            impostorScoresUser5User76 = EuclidDist.CalculateImpostorScores(s005Mean, s076);
            impostorScoresUser5User77 = EuclidDist.CalculateImpostorScores(s005Mean, s077);
            impostorScoresUser5User78 = EuclidDist.CalculateImpostorScores(s005Mean, s078);
            impostorScoresUser5User79 = EuclidDist.CalculateImpostorScores(s005Mean, s079);
            impostorScoresUser5User80 = EuclidDist.CalculateImpostorScores(s005Mean, s080);

            impostorScoresUser5User81 = EuclidDist.CalculateImpostorScores(s005Mean, s081);
            impostorScoresUser5User82 = EuclidDist.CalculateImpostorScores(s005Mean, s082);
            impostorScoresUser5User83 = EuclidDist.CalculateImpostorScores(s005Mean, s083);
            impostorScoresUser5User84 = EuclidDist.CalculateImpostorScores(s005Mean, s084);
            impostorScoresUser5User85 = EuclidDist.CalculateImpostorScores(s005Mean, s085);
            impostorScoresUser5User86 = EuclidDist.CalculateImpostorScores(s005Mean, s086);
            impostorScoresUser5User87 = EuclidDist.CalculateImpostorScores(s005Mean, s087);
            impostorScoresUser5User88 = EuclidDist.CalculateImpostorScores(s005Mean, s088);
            impostorScoresUser5User89 = EuclidDist.CalculateImpostorScores(s005Mean, s089);
            impostorScoresUser5User90 = EuclidDist.CalculateImpostorScores(s005Mean, s090);

            impostorScoresUser5User91 = EuclidDist.CalculateImpostorScores(s005Mean, s091);
            impostorScoresUser5User92 = EuclidDist.CalculateImpostorScores(s005Mean, s092);
            impostorScoresUser5User93 = EuclidDist.CalculateImpostorScores(s005Mean, s093);
            impostorScoresUser5User94 = EuclidDist.CalculateImpostorScores(s005Mean, s094);
            impostorScoresUser5User95 = EuclidDist.CalculateImpostorScores(s005Mean, s095);
            impostorScoresUser5User96 = EuclidDist.CalculateImpostorScores(s005Mean, s096);
            impostorScoresUser5User97 = EuclidDist.CalculateImpostorScores(s005Mean, s097);
            impostorScoresUser5User98 = EuclidDist.CalculateImpostorScores(s005Mean, s098);
            impostorScoresUser5User99 = EuclidDist.CalculateImpostorScores(s005Mean, s099);
            impostorScoresUser5User100 = EuclidDist.CalculateImpostorScores(s005Mean, s100);
            #endregion

            #region User 6 impostor scores
            impostorScoresUser6User1 = EuclidDist.CalculateImpostorScores(s006Mean, s001);
            impostorScoresUser6User2 = EuclidDist.CalculateImpostorScores(s006Mean, s002);
            impostorScoresUser6User3 = EuclidDist.CalculateImpostorScores(s006Mean, s003);
            impostorScoresUser6User4 = EuclidDist.CalculateImpostorScores(s006Mean, s004);
            impostorScoresUser6User5 = EuclidDist.CalculateImpostorScores(s006Mean, s005);
            impostorScoresUser6User7 = EuclidDist.CalculateImpostorScores(s006Mean, s007);
            impostorScoresUser6User8 = EuclidDist.CalculateImpostorScores(s006Mean, s008);
            impostorScoresUser6User9 = EuclidDist.CalculateImpostorScores(s006Mean, s009);
            impostorScoresUser6User10 = EuclidDist.CalculateImpostorScores(s006Mean, s010);

            impostorScoresUser6User11 = EuclidDist.CalculateImpostorScores(s006Mean, s011);
            impostorScoresUser6User12 = EuclidDist.CalculateImpostorScores(s006Mean, s012);
            impostorScoresUser6User13 = EuclidDist.CalculateImpostorScores(s006Mean, s013);
            impostorScoresUser6User14 = EuclidDist.CalculateImpostorScores(s006Mean, s014);
            impostorScoresUser6User15 = EuclidDist.CalculateImpostorScores(s006Mean, s015);
            impostorScoresUser6User16 = EuclidDist.CalculateImpostorScores(s006Mean, s016);
            impostorScoresUser6User17 = EuclidDist.CalculateImpostorScores(s006Mean, s017);
            impostorScoresUser6User18 = EuclidDist.CalculateImpostorScores(s006Mean, s018);
            impostorScoresUser6User19 = EuclidDist.CalculateImpostorScores(s006Mean, s019);
            impostorScoresUser6User20 = EuclidDist.CalculateImpostorScores(s006Mean, s020);

            impostorScoresUser6User21 = EuclidDist.CalculateImpostorScores(s006Mean, s021);
            impostorScoresUser6User22 = EuclidDist.CalculateImpostorScores(s006Mean, s022);
            impostorScoresUser6User23 = EuclidDist.CalculateImpostorScores(s006Mean, s023);
            impostorScoresUser6User24 = EuclidDist.CalculateImpostorScores(s006Mean, s024);
            impostorScoresUser6User25 = EuclidDist.CalculateImpostorScores(s006Mean, s025);
            impostorScoresUser6User26 = EuclidDist.CalculateImpostorScores(s006Mean, s026);
            impostorScoresUser6User27 = EuclidDist.CalculateImpostorScores(s006Mean, s027);
            impostorScoresUser6User28 = EuclidDist.CalculateImpostorScores(s006Mean, s028);
            impostorScoresUser6User29 = EuclidDist.CalculateImpostorScores(s006Mean, s029);
            impostorScoresUser6User30 = EuclidDist.CalculateImpostorScores(s006Mean, s030);

            impostorScoresUser6User31 = EuclidDist.CalculateImpostorScores(s006Mean, s031);
            impostorScoresUser6User32 = EuclidDist.CalculateImpostorScores(s006Mean, s032);
            impostorScoresUser6User33 = EuclidDist.CalculateImpostorScores(s006Mean, s033);
            impostorScoresUser6User34 = EuclidDist.CalculateImpostorScores(s006Mean, s034);
            impostorScoresUser6User35 = EuclidDist.CalculateImpostorScores(s006Mean, s035);
            impostorScoresUser6User36 = EuclidDist.CalculateImpostorScores(s006Mean, s036);
            impostorScoresUser6User37 = EuclidDist.CalculateImpostorScores(s006Mean, s037);
            impostorScoresUser6User38 = EuclidDist.CalculateImpostorScores(s006Mean, s038);
            impostorScoresUser6User39 = EuclidDist.CalculateImpostorScores(s006Mean, s039);
            impostorScoresUser6User40 = EuclidDist.CalculateImpostorScores(s006Mean, s040);

            impostorScoresUser6User41 = EuclidDist.CalculateImpostorScores(s006Mean, s041);
            impostorScoresUser6User42 = EuclidDist.CalculateImpostorScores(s006Mean, s042);
            impostorScoresUser6User43 = EuclidDist.CalculateImpostorScores(s006Mean, s043);
            impostorScoresUser6User44 = EuclidDist.CalculateImpostorScores(s006Mean, s044);
            impostorScoresUser6User45 = EuclidDist.CalculateImpostorScores(s006Mean, s045);
            impostorScoresUser6User46 = EuclidDist.CalculateImpostorScores(s006Mean, s046);
            impostorScoresUser6User47 = EuclidDist.CalculateImpostorScores(s006Mean, s047);
            impostorScoresUser6User48 = EuclidDist.CalculateImpostorScores(s006Mean, s048);
            impostorScoresUser6User49 = EuclidDist.CalculateImpostorScores(s006Mean, s049);
            impostorScoresUser6User50 = EuclidDist.CalculateImpostorScores(s006Mean, s050);

            impostorScoresUser6User51 = EuclidDist.CalculateImpostorScores(s006Mean, s051);
            impostorScoresUser6User52 = EuclidDist.CalculateImpostorScores(s006Mean, s052);
            impostorScoresUser6User53 = EuclidDist.CalculateImpostorScores(s006Mean, s053);
            impostorScoresUser6User54 = EuclidDist.CalculateImpostorScores(s006Mean, s054);
            impostorScoresUser6User55 = EuclidDist.CalculateImpostorScores(s006Mean, s055);
            impostorScoresUser6User56 = EuclidDist.CalculateImpostorScores(s006Mean, s056);
            impostorScoresUser6User57 = EuclidDist.CalculateImpostorScores(s006Mean, s057);
            impostorScoresUser6User58 = EuclidDist.CalculateImpostorScores(s006Mean, s058);
            impostorScoresUser6User59 = EuclidDist.CalculateImpostorScores(s006Mean, s059);
            impostorScoresUser6User60 = EuclidDist.CalculateImpostorScores(s006Mean, s060);

            impostorScoresUser6User61 = EuclidDist.CalculateImpostorScores(s006Mean, s061);
            impostorScoresUser6User62 = EuclidDist.CalculateImpostorScores(s006Mean, s062);
            impostorScoresUser6User63 = EuclidDist.CalculateImpostorScores(s006Mean, s063);
            impostorScoresUser6User64 = EuclidDist.CalculateImpostorScores(s006Mean, s064);
            impostorScoresUser6User65 = EuclidDist.CalculateImpostorScores(s006Mean, s065);
            impostorScoresUser6User66 = EuclidDist.CalculateImpostorScores(s006Mean, s066);
            impostorScoresUser6User67 = EuclidDist.CalculateImpostorScores(s006Mean, s067);
            impostorScoresUser6User68 = EuclidDist.CalculateImpostorScores(s006Mean, s068);
            impostorScoresUser6User69 = EuclidDist.CalculateImpostorScores(s006Mean, s069);
            impostorScoresUser6User70 = EuclidDist.CalculateImpostorScores(s006Mean, s070);

            impostorScoresUser6User71 = EuclidDist.CalculateImpostorScores(s006Mean, s071);
            impostorScoresUser6User72 = EuclidDist.CalculateImpostorScores(s006Mean, s072);
            impostorScoresUser6User73 = EuclidDist.CalculateImpostorScores(s006Mean, s073);
            impostorScoresUser6User74 = EuclidDist.CalculateImpostorScores(s006Mean, s074);
            impostorScoresUser6User75 = EuclidDist.CalculateImpostorScores(s006Mean, s075);
            impostorScoresUser6User76 = EuclidDist.CalculateImpostorScores(s006Mean, s076);
            impostorScoresUser6User77 = EuclidDist.CalculateImpostorScores(s006Mean, s077);
            impostorScoresUser6User78 = EuclidDist.CalculateImpostorScores(s006Mean, s078);
            impostorScoresUser6User79 = EuclidDist.CalculateImpostorScores(s006Mean, s079);
            impostorScoresUser6User80 = EuclidDist.CalculateImpostorScores(s006Mean, s080);

            impostorScoresUser6User81 = EuclidDist.CalculateImpostorScores(s006Mean, s081);
            impostorScoresUser6User82 = EuclidDist.CalculateImpostorScores(s006Mean, s082);
            impostorScoresUser6User83 = EuclidDist.CalculateImpostorScores(s006Mean, s083);
            impostorScoresUser6User84 = EuclidDist.CalculateImpostorScores(s006Mean, s084);
            impostorScoresUser6User85 = EuclidDist.CalculateImpostorScores(s006Mean, s085);
            impostorScoresUser6User86 = EuclidDist.CalculateImpostorScores(s006Mean, s086);
            impostorScoresUser6User87 = EuclidDist.CalculateImpostorScores(s006Mean, s087);
            impostorScoresUser6User88 = EuclidDist.CalculateImpostorScores(s006Mean, s088);
            impostorScoresUser6User89 = EuclidDist.CalculateImpostorScores(s006Mean, s089);
            impostorScoresUser6User90 = EuclidDist.CalculateImpostorScores(s006Mean, s090);

            impostorScoresUser6User91 = EuclidDist.CalculateImpostorScores(s006Mean, s091);
            impostorScoresUser6User92 = EuclidDist.CalculateImpostorScores(s006Mean, s092);
            impostorScoresUser6User93 = EuclidDist.CalculateImpostorScores(s006Mean, s093);
            impostorScoresUser6User94 = EuclidDist.CalculateImpostorScores(s006Mean, s094);
            impostorScoresUser6User95 = EuclidDist.CalculateImpostorScores(s006Mean, s095);
            impostorScoresUser6User96 = EuclidDist.CalculateImpostorScores(s006Mean, s096);
            impostorScoresUser6User97 = EuclidDist.CalculateImpostorScores(s006Mean, s097);
            impostorScoresUser6User98 = EuclidDist.CalculateImpostorScores(s006Mean, s098);
            impostorScoresUser6User99 = EuclidDist.CalculateImpostorScores(s006Mean, s099);
            impostorScoresUser6User100 = EuclidDist.CalculateImpostorScores(s006Mean, s100);
            #endregion

            #region User 7 impostor scores
            impostorScoresUser7User1 = EuclidDist.CalculateImpostorScores(s007Mean, s001);
            impostorScoresUser7User2 = EuclidDist.CalculateImpostorScores(s007Mean, s002);
            impostorScoresUser7User3 = EuclidDist.CalculateImpostorScores(s007Mean, s003);
            impostorScoresUser7User4 = EuclidDist.CalculateImpostorScores(s007Mean, s004);
            impostorScoresUser7User5 = EuclidDist.CalculateImpostorScores(s007Mean, s005);
            impostorScoresUser7User6 = EuclidDist.CalculateImpostorScores(s007Mean, s006);
            impostorScoresUser7User8 = EuclidDist.CalculateImpostorScores(s007Mean, s008);
            impostorScoresUser7User9 = EuclidDist.CalculateImpostorScores(s007Mean, s009);
            impostorScoresUser7User10 = EuclidDist.CalculateImpostorScores(s007Mean, s010);

            impostorScoresUser7User11 = EuclidDist.CalculateImpostorScores(s007Mean, s011);
            impostorScoresUser7User12 = EuclidDist.CalculateImpostorScores(s007Mean, s012);
            impostorScoresUser7User13 = EuclidDist.CalculateImpostorScores(s007Mean, s013);
            impostorScoresUser7User14 = EuclidDist.CalculateImpostorScores(s007Mean, s014);
            impostorScoresUser7User15 = EuclidDist.CalculateImpostorScores(s007Mean, s015);
            impostorScoresUser7User16 = EuclidDist.CalculateImpostorScores(s007Mean, s016);
            impostorScoresUser7User17 = EuclidDist.CalculateImpostorScores(s007Mean, s017);
            impostorScoresUser7User18 = EuclidDist.CalculateImpostorScores(s007Mean, s018);
            impostorScoresUser7User19 = EuclidDist.CalculateImpostorScores(s007Mean, s019);
            impostorScoresUser7User20 = EuclidDist.CalculateImpostorScores(s007Mean, s020);

            impostorScoresUser7User21 = EuclidDist.CalculateImpostorScores(s007Mean, s021);
            impostorScoresUser7User22 = EuclidDist.CalculateImpostorScores(s007Mean, s022);
            impostorScoresUser7User23 = EuclidDist.CalculateImpostorScores(s007Mean, s023);
            impostorScoresUser7User24 = EuclidDist.CalculateImpostorScores(s007Mean, s024);
            impostorScoresUser7User25 = EuclidDist.CalculateImpostorScores(s007Mean, s025);
            impostorScoresUser7User26 = EuclidDist.CalculateImpostorScores(s007Mean, s026);
            impostorScoresUser7User27 = EuclidDist.CalculateImpostorScores(s007Mean, s027);
            impostorScoresUser7User28 = EuclidDist.CalculateImpostorScores(s007Mean, s028);
            impostorScoresUser7User29 = EuclidDist.CalculateImpostorScores(s007Mean, s029);
            impostorScoresUser7User30 = EuclidDist.CalculateImpostorScores(s007Mean, s030);

            impostorScoresUser7User31 = EuclidDist.CalculateImpostorScores(s007Mean, s031);
            impostorScoresUser7User32 = EuclidDist.CalculateImpostorScores(s007Mean, s032);
            impostorScoresUser7User33 = EuclidDist.CalculateImpostorScores(s007Mean, s033);
            impostorScoresUser7User34 = EuclidDist.CalculateImpostorScores(s007Mean, s034);
            impostorScoresUser7User35 = EuclidDist.CalculateImpostorScores(s007Mean, s035);
            impostorScoresUser7User36 = EuclidDist.CalculateImpostorScores(s007Mean, s036);
            impostorScoresUser7User37 = EuclidDist.CalculateImpostorScores(s007Mean, s037);
            impostorScoresUser7User38 = EuclidDist.CalculateImpostorScores(s007Mean, s038);
            impostorScoresUser7User39 = EuclidDist.CalculateImpostorScores(s007Mean, s039);
            impostorScoresUser7User40 = EuclidDist.CalculateImpostorScores(s007Mean, s040);

            impostorScoresUser7User41 = EuclidDist.CalculateImpostorScores(s007Mean, s041);
            impostorScoresUser7User42 = EuclidDist.CalculateImpostorScores(s007Mean, s042);
            impostorScoresUser7User43 = EuclidDist.CalculateImpostorScores(s007Mean, s043);
            impostorScoresUser7User44 = EuclidDist.CalculateImpostorScores(s007Mean, s044);
            impostorScoresUser7User45 = EuclidDist.CalculateImpostorScores(s007Mean, s045);
            impostorScoresUser7User46 = EuclidDist.CalculateImpostorScores(s007Mean, s046);
            impostorScoresUser7User47 = EuclidDist.CalculateImpostorScores(s007Mean, s047);
            impostorScoresUser7User48 = EuclidDist.CalculateImpostorScores(s007Mean, s048);
            impostorScoresUser7User49 = EuclidDist.CalculateImpostorScores(s007Mean, s049);
            impostorScoresUser7User50 = EuclidDist.CalculateImpostorScores(s007Mean, s050);

            impostorScoresUser7User51 = EuclidDist.CalculateImpostorScores(s007Mean, s051);
            impostorScoresUser7User52 = EuclidDist.CalculateImpostorScores(s007Mean, s052);
            impostorScoresUser7User53 = EuclidDist.CalculateImpostorScores(s007Mean, s053);
            impostorScoresUser7User54 = EuclidDist.CalculateImpostorScores(s007Mean, s054);
            impostorScoresUser7User55 = EuclidDist.CalculateImpostorScores(s007Mean, s055);
            impostorScoresUser7User56 = EuclidDist.CalculateImpostorScores(s007Mean, s056);
            impostorScoresUser7User57 = EuclidDist.CalculateImpostorScores(s007Mean, s057);
            impostorScoresUser7User58 = EuclidDist.CalculateImpostorScores(s007Mean, s058);
            impostorScoresUser7User59 = EuclidDist.CalculateImpostorScores(s007Mean, s059);
            impostorScoresUser7User60 = EuclidDist.CalculateImpostorScores(s007Mean, s060);

            impostorScoresUser7User61 = EuclidDist.CalculateImpostorScores(s007Mean, s061);
            impostorScoresUser7User62 = EuclidDist.CalculateImpostorScores(s007Mean, s062);
            impostorScoresUser7User63 = EuclidDist.CalculateImpostorScores(s007Mean, s063);
            impostorScoresUser7User64 = EuclidDist.CalculateImpostorScores(s007Mean, s064);
            impostorScoresUser7User65 = EuclidDist.CalculateImpostorScores(s007Mean, s065);
            impostorScoresUser7User66 = EuclidDist.CalculateImpostorScores(s007Mean, s066);
            impostorScoresUser7User67 = EuclidDist.CalculateImpostorScores(s007Mean, s067);
            impostorScoresUser7User68 = EuclidDist.CalculateImpostorScores(s007Mean, s068);
            impostorScoresUser7User69 = EuclidDist.CalculateImpostorScores(s007Mean, s069);
            impostorScoresUser7User70 = EuclidDist.CalculateImpostorScores(s007Mean, s070);

            impostorScoresUser7User71 = EuclidDist.CalculateImpostorScores(s007Mean, s071);
            impostorScoresUser7User72 = EuclidDist.CalculateImpostorScores(s007Mean, s072);
            impostorScoresUser7User73 = EuclidDist.CalculateImpostorScores(s007Mean, s073);
            impostorScoresUser7User74 = EuclidDist.CalculateImpostorScores(s007Mean, s074);
            impostorScoresUser7User75 = EuclidDist.CalculateImpostorScores(s007Mean, s075);
            impostorScoresUser7User76 = EuclidDist.CalculateImpostorScores(s007Mean, s076);
            impostorScoresUser7User77 = EuclidDist.CalculateImpostorScores(s007Mean, s077);
            impostorScoresUser7User78 = EuclidDist.CalculateImpostorScores(s007Mean, s078);
            impostorScoresUser7User79 = EuclidDist.CalculateImpostorScores(s007Mean, s079);
            impostorScoresUser7User80 = EuclidDist.CalculateImpostorScores(s007Mean, s080);

            impostorScoresUser7User81 = EuclidDist.CalculateImpostorScores(s007Mean, s081);
            impostorScoresUser7User82 = EuclidDist.CalculateImpostorScores(s007Mean, s082);
            impostorScoresUser7User83 = EuclidDist.CalculateImpostorScores(s007Mean, s083);
            impostorScoresUser7User84 = EuclidDist.CalculateImpostorScores(s007Mean, s084);
            impostorScoresUser7User85 = EuclidDist.CalculateImpostorScores(s007Mean, s085);
            impostorScoresUser7User86 = EuclidDist.CalculateImpostorScores(s007Mean, s086);
            impostorScoresUser7User87 = EuclidDist.CalculateImpostorScores(s007Mean, s087);
            impostorScoresUser7User88 = EuclidDist.CalculateImpostorScores(s007Mean, s088);
            impostorScoresUser7User89 = EuclidDist.CalculateImpostorScores(s007Mean, s089);
            impostorScoresUser7User90 = EuclidDist.CalculateImpostorScores(s007Mean, s090);

            impostorScoresUser7User91 = EuclidDist.CalculateImpostorScores(s007Mean, s091);
            impostorScoresUser7User92 = EuclidDist.CalculateImpostorScores(s007Mean, s092);
            impostorScoresUser7User93 = EuclidDist.CalculateImpostorScores(s007Mean, s093);
            impostorScoresUser7User94 = EuclidDist.CalculateImpostorScores(s007Mean, s094);
            impostorScoresUser7User95 = EuclidDist.CalculateImpostorScores(s007Mean, s095);
            impostorScoresUser7User96 = EuclidDist.CalculateImpostorScores(s007Mean, s096);
            impostorScoresUser7User97 = EuclidDist.CalculateImpostorScores(s007Mean, s097);
            impostorScoresUser7User98 = EuclidDist.CalculateImpostorScores(s007Mean, s098);
            impostorScoresUser7User99 = EuclidDist.CalculateImpostorScores(s007Mean, s099);
            impostorScoresUser7User100 = EuclidDist.CalculateImpostorScores(s007Mean, s100);
            #endregion

            #region User 8 impostor scores
            impostorScoresUser8User1 = EuclidDist.CalculateImpostorScores(s008Mean, s001);
            impostorScoresUser8User2 = EuclidDist.CalculateImpostorScores(s008Mean, s002);
            impostorScoresUser8User3 = EuclidDist.CalculateImpostorScores(s008Mean, s003);
            impostorScoresUser8User4 = EuclidDist.CalculateImpostorScores(s008Mean, s004);
            impostorScoresUser8User5 = EuclidDist.CalculateImpostorScores(s008Mean, s005);
            impostorScoresUser8User6 = EuclidDist.CalculateImpostorScores(s008Mean, s006);
            impostorScoresUser8User7 = EuclidDist.CalculateImpostorScores(s008Mean, s007);
            impostorScoresUser8User9 = EuclidDist.CalculateImpostorScores(s008Mean, s009);
            impostorScoresUser8User10 = EuclidDist.CalculateImpostorScores(s008Mean, s010);

            impostorScoresUser8User11 = EuclidDist.CalculateImpostorScores(s008Mean, s011);
            impostorScoresUser8User12 = EuclidDist.CalculateImpostorScores(s008Mean, s012);
            impostorScoresUser8User13 = EuclidDist.CalculateImpostorScores(s008Mean, s013);
            impostorScoresUser8User14 = EuclidDist.CalculateImpostorScores(s008Mean, s014);
            impostorScoresUser8User15 = EuclidDist.CalculateImpostorScores(s008Mean, s015);
            impostorScoresUser8User16 = EuclidDist.CalculateImpostorScores(s008Mean, s016);
            impostorScoresUser8User17 = EuclidDist.CalculateImpostorScores(s008Mean, s017);
            impostorScoresUser8User18 = EuclidDist.CalculateImpostorScores(s008Mean, s018);
            impostorScoresUser8User19 = EuclidDist.CalculateImpostorScores(s008Mean, s019);
            impostorScoresUser8User20 = EuclidDist.CalculateImpostorScores(s008Mean, s020);

            impostorScoresUser8User21 = EuclidDist.CalculateImpostorScores(s008Mean, s021);
            impostorScoresUser8User22 = EuclidDist.CalculateImpostorScores(s008Mean, s022);
            impostorScoresUser8User23 = EuclidDist.CalculateImpostorScores(s008Mean, s023);
            impostorScoresUser8User24 = EuclidDist.CalculateImpostorScores(s008Mean, s024);
            impostorScoresUser8User25 = EuclidDist.CalculateImpostorScores(s008Mean, s025);
            impostorScoresUser8User26 = EuclidDist.CalculateImpostorScores(s008Mean, s026);
            impostorScoresUser8User27 = EuclidDist.CalculateImpostorScores(s008Mean, s027);
            impostorScoresUser8User28 = EuclidDist.CalculateImpostorScores(s008Mean, s028);
            impostorScoresUser8User29 = EuclidDist.CalculateImpostorScores(s008Mean, s029);
            impostorScoresUser8User30 = EuclidDist.CalculateImpostorScores(s008Mean, s030);

            impostorScoresUser8User31 = EuclidDist.CalculateImpostorScores(s008Mean, s031);
            impostorScoresUser8User32 = EuclidDist.CalculateImpostorScores(s008Mean, s032);
            impostorScoresUser8User33 = EuclidDist.CalculateImpostorScores(s008Mean, s033);
            impostorScoresUser8User34 = EuclidDist.CalculateImpostorScores(s008Mean, s034);
            impostorScoresUser8User35 = EuclidDist.CalculateImpostorScores(s008Mean, s035);
            impostorScoresUser8User36 = EuclidDist.CalculateImpostorScores(s008Mean, s036);
            impostorScoresUser8User37 = EuclidDist.CalculateImpostorScores(s008Mean, s037);
            impostorScoresUser8User38 = EuclidDist.CalculateImpostorScores(s008Mean, s038);
            impostorScoresUser8User39 = EuclidDist.CalculateImpostorScores(s008Mean, s039);
            impostorScoresUser8User40 = EuclidDist.CalculateImpostorScores(s008Mean, s040);

            impostorScoresUser8User41 = EuclidDist.CalculateImpostorScores(s008Mean, s041);
            impostorScoresUser8User42 = EuclidDist.CalculateImpostorScores(s008Mean, s042);
            impostorScoresUser8User43 = EuclidDist.CalculateImpostorScores(s008Mean, s043);
            impostorScoresUser8User44 = EuclidDist.CalculateImpostorScores(s008Mean, s044);
            impostorScoresUser8User45 = EuclidDist.CalculateImpostorScores(s008Mean, s045);
            impostorScoresUser8User46 = EuclidDist.CalculateImpostorScores(s008Mean, s046);
            impostorScoresUser8User47 = EuclidDist.CalculateImpostorScores(s008Mean, s047);
            impostorScoresUser8User48 = EuclidDist.CalculateImpostorScores(s008Mean, s048);
            impostorScoresUser8User49 = EuclidDist.CalculateImpostorScores(s008Mean, s049);
            impostorScoresUser8User50 = EuclidDist.CalculateImpostorScores(s008Mean, s050);

            impostorScoresUser8User51 = EuclidDist.CalculateImpostorScores(s008Mean, s051);
            impostorScoresUser8User52 = EuclidDist.CalculateImpostorScores(s008Mean, s052);
            impostorScoresUser8User53 = EuclidDist.CalculateImpostorScores(s008Mean, s053);
            impostorScoresUser8User54 = EuclidDist.CalculateImpostorScores(s008Mean, s054);
            impostorScoresUser8User55 = EuclidDist.CalculateImpostorScores(s008Mean, s055);
            impostorScoresUser8User56 = EuclidDist.CalculateImpostorScores(s008Mean, s056);
            impostorScoresUser8User57 = EuclidDist.CalculateImpostorScores(s008Mean, s057);
            impostorScoresUser8User58 = EuclidDist.CalculateImpostorScores(s008Mean, s058);
            impostorScoresUser8User59 = EuclidDist.CalculateImpostorScores(s008Mean, s059);
            impostorScoresUser8User60 = EuclidDist.CalculateImpostorScores(s008Mean, s060);

            impostorScoresUser8User61 = EuclidDist.CalculateImpostorScores(s008Mean, s061);
            impostorScoresUser8User62 = EuclidDist.CalculateImpostorScores(s008Mean, s062);
            impostorScoresUser8User63 = EuclidDist.CalculateImpostorScores(s008Mean, s063);
            impostorScoresUser8User64 = EuclidDist.CalculateImpostorScores(s008Mean, s064);
            impostorScoresUser8User65 = EuclidDist.CalculateImpostorScores(s008Mean, s065);
            impostorScoresUser8User66 = EuclidDist.CalculateImpostorScores(s008Mean, s066);
            impostorScoresUser8User67 = EuclidDist.CalculateImpostorScores(s008Mean, s067);
            impostorScoresUser8User68 = EuclidDist.CalculateImpostorScores(s008Mean, s068);
            impostorScoresUser8User69 = EuclidDist.CalculateImpostorScores(s008Mean, s069);
            impostorScoresUser8User70 = EuclidDist.CalculateImpostorScores(s008Mean, s070);

            impostorScoresUser8User71 = EuclidDist.CalculateImpostorScores(s008Mean, s071);
            impostorScoresUser8User72 = EuclidDist.CalculateImpostorScores(s008Mean, s072);
            impostorScoresUser8User73 = EuclidDist.CalculateImpostorScores(s008Mean, s073);
            impostorScoresUser8User74 = EuclidDist.CalculateImpostorScores(s008Mean, s074);
            impostorScoresUser8User75 = EuclidDist.CalculateImpostorScores(s008Mean, s075);
            impostorScoresUser8User76 = EuclidDist.CalculateImpostorScores(s008Mean, s076);
            impostorScoresUser8User77 = EuclidDist.CalculateImpostorScores(s008Mean, s077);
            impostorScoresUser8User78 = EuclidDist.CalculateImpostorScores(s008Mean, s078);
            impostorScoresUser8User79 = EuclidDist.CalculateImpostorScores(s008Mean, s079);
            impostorScoresUser8User80 = EuclidDist.CalculateImpostorScores(s008Mean, s080);

            impostorScoresUser8User81 = EuclidDist.CalculateImpostorScores(s008Mean, s081);
            impostorScoresUser8User82 = EuclidDist.CalculateImpostorScores(s008Mean, s082);
            impostorScoresUser8User83 = EuclidDist.CalculateImpostorScores(s008Mean, s083);
            impostorScoresUser8User84 = EuclidDist.CalculateImpostorScores(s008Mean, s084);
            impostorScoresUser8User85 = EuclidDist.CalculateImpostorScores(s008Mean, s085);
            impostorScoresUser8User86 = EuclidDist.CalculateImpostorScores(s008Mean, s086);
            impostorScoresUser8User87 = EuclidDist.CalculateImpostorScores(s008Mean, s087);
            impostorScoresUser8User88 = EuclidDist.CalculateImpostorScores(s008Mean, s088);
            impostorScoresUser8User89 = EuclidDist.CalculateImpostorScores(s008Mean, s089);
            impostorScoresUser8User90 = EuclidDist.CalculateImpostorScores(s008Mean, s090);

            impostorScoresUser8User91 = EuclidDist.CalculateImpostorScores(s008Mean, s091);
            impostorScoresUser8User92 = EuclidDist.CalculateImpostorScores(s008Mean, s092);
            impostorScoresUser8User93 = EuclidDist.CalculateImpostorScores(s008Mean, s093);
            impostorScoresUser8User94 = EuclidDist.CalculateImpostorScores(s008Mean, s094);
            impostorScoresUser8User95 = EuclidDist.CalculateImpostorScores(s008Mean, s095);
            impostorScoresUser8User96 = EuclidDist.CalculateImpostorScores(s008Mean, s096);
            impostorScoresUser8User97 = EuclidDist.CalculateImpostorScores(s008Mean, s097);
            impostorScoresUser8User98 = EuclidDist.CalculateImpostorScores(s008Mean, s098);
            impostorScoresUser8User99 = EuclidDist.CalculateImpostorScores(s008Mean, s099);
            impostorScoresUser8User100 = EuclidDist.CalculateImpostorScores(s008Mean, s100);
            #endregion

            #region User 9 impostor scores
            
            #endregion

            #region User 10 impostor scores
            
            #endregion

            #endregion
        }

        private static void UseManhattanVerifier()
        {
            ManhattanDistance ManhDist = new ManhattanDistance();

            #region Populating the mean arrays for each user
            s001Mean = ManhDist.CalculateMeanVector(s001);
            s002Mean = ManhDist.CalculateMeanVector(s002);
            s003Mean = ManhDist.CalculateMeanVector(s003);
            s004Mean = ManhDist.CalculateMeanVector(s004);
            s005Mean = ManhDist.CalculateMeanVector(s005); 
            s006Mean = ManhDist.CalculateMeanVector(s006);
            s007Mean = ManhDist.CalculateMeanVector(s007);
            s008Mean = ManhDist.CalculateMeanVector(s008);
            s009Mean = ManhDist.CalculateMeanVector(s009); 
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
 
            s021Mean = ManhDist.CalculateMeanVector(s021);
            s022Mean = ManhDist.CalculateMeanVector(s022);
            s023Mean = ManhDist.CalculateMeanVector(s023); 
            s024Mean = ManhDist.CalculateMeanVector(s024);
            s025Mean = ManhDist.CalculateMeanVector(s025);
            s026Mean = ManhDist.CalculateMeanVector(s026); 
            s027Mean = ManhDist.CalculateMeanVector(s027);
            s028Mean = ManhDist.CalculateMeanVector(s028);
            s029Mean = ManhDist.CalculateMeanVector(s029);
            s030Mean = ManhDist.CalculateMeanVector(s030); 

            s031Mean = ManhDist.CalculateMeanVector(s031);
            s032Mean = ManhDist.CalculateMeanVector(s032);
            s033Mean = ManhDist.CalculateMeanVector(s033);
            s034Mean = ManhDist.CalculateMeanVector(s034);
            s035Mean = ManhDist.CalculateMeanVector(s035);
            s036Mean = ManhDist.CalculateMeanVector(s036);
            s037Mean = ManhDist.CalculateMeanVector(s037);
            s038Mean = ManhDist.CalculateMeanVector(s038);
            s039Mean = ManhDist.CalculateMeanVector(s039);
            s040Mean = ManhDist.CalculateMeanVector(s040);

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

            s061Mean = ManhDist.CalculateMeanVector(s061);
            s062Mean = ManhDist.CalculateMeanVector(s062);
            s063Mean = ManhDist.CalculateMeanVector(s063);
            s064Mean = ManhDist.CalculateMeanVector(s064); 
            s065Mean = ManhDist.CalculateMeanVector(s065);
            s066Mean = ManhDist.CalculateMeanVector(s066);
            s067Mean = ManhDist.CalculateMeanVector(s067);
            s068Mean = ManhDist.CalculateMeanVector(s068);
            s069Mean = ManhDist.CalculateMeanVector(s069);
            s070Mean = ManhDist.CalculateMeanVector(s070);

            s071Mean = ManhDist.CalculateMeanVector(s071);
            s072Mean = ManhDist.CalculateMeanVector(s072);
            s073Mean = ManhDist.CalculateMeanVector(s073);
            s074Mean = ManhDist.CalculateMeanVector(s074);
            s075Mean = ManhDist.CalculateMeanVector(s075);
            s076Mean = ManhDist.CalculateMeanVector(s076);
            s077Mean = ManhDist.CalculateMeanVector(s077);
            s078Mean = ManhDist.CalculateMeanVector(s078);
            s079Mean = ManhDist.CalculateMeanVector(s079);
            s080Mean = ManhDist.CalculateMeanVector(s080);

            s081Mean = ManhDist.CalculateMeanVector(s081);
            s082Mean = ManhDist.CalculateMeanVector(s082);
            s083Mean = ManhDist.CalculateMeanVector(s083);
            s084Mean = ManhDist.CalculateMeanVector(s084);
            s085Mean = ManhDist.CalculateMeanVector(s085);
            s086Mean = ManhDist.CalculateMeanVector(s086);
            s087Mean = ManhDist.CalculateMeanVector(s087);
            s088Mean = ManhDist.CalculateMeanVector(s088);
            s089Mean = ManhDist.CalculateMeanVector(s089);
            s090Mean = ManhDist.CalculateMeanVector(s090);

            s091Mean = ManhDist.CalculateMeanVector(s091);
            s092Mean = ManhDist.CalculateMeanVector(s092);
            s093Mean = ManhDist.CalculateMeanVector(s093);
            s094Mean = ManhDist.CalculateMeanVector(s094);
            s095Mean = ManhDist.CalculateMeanVector(s095);
            s096Mean = ManhDist.CalculateMeanVector(s096);
            s097Mean = ManhDist.CalculateMeanVector(s097);
            s098Mean = ManhDist.CalculateMeanVector(s098);
            s099Mean = ManhDist.CalculateMeanVector(s099);
            s100Mean = ManhDist.CalculateMeanVector(s100); 
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

            s021Gen = ManhDist.CalculateGenuineScores(s021, s021Mean);
            s022Gen = ManhDist.CalculateGenuineScores(s022, s022Mean);
            s023Gen = ManhDist.CalculateGenuineScores(s023, s023Mean); 
            s024Gen = ManhDist.CalculateGenuineScores(s024, s024Mean);
            s025Gen = ManhDist.CalculateGenuineScores(s025, s025Mean);
            s026Gen = ManhDist.CalculateGenuineScores(s026, s026Mean); 
            s027Gen = ManhDist.CalculateGenuineScores(s027, s027Mean);
            s028Gen = ManhDist.CalculateGenuineScores(s028, s028Mean);
            s029Gen = ManhDist.CalculateGenuineScores(s029, s029Mean);
            s030Gen = ManhDist.CalculateGenuineScores(s030, s030Mean); 

            s031Gen = ManhDist.CalculateGenuineScores(s031, s031Mean);
            s032Gen = ManhDist.CalculateGenuineScores(s032, s032Mean);
            s033Gen = ManhDist.CalculateGenuineScores(s033, s033Mean); 
            s034Gen = ManhDist.CalculateGenuineScores(s034, s034Mean);
            s035Gen = ManhDist.CalculateGenuineScores(s035, s035Mean);
            s036Gen = ManhDist.CalculateGenuineScores(s036, s036Mean);
            s037Gen = ManhDist.CalculateGenuineScores(s037, s037Mean);
            s038Gen = ManhDist.CalculateGenuineScores(s038, s038Mean);
            s039Gen = ManhDist.CalculateGenuineScores(s039, s039Mean);
            s040Gen = ManhDist.CalculateGenuineScores(s040, s040Mean);

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

            s061Gen = ManhDist.CalculateGenuineScores(s061, s061Mean);
            s062Gen = ManhDist.CalculateGenuineScores(s062, s062Mean);
            s063Gen = ManhDist.CalculateGenuineScores(s063, s063Mean);
            s064Gen = ManhDist.CalculateGenuineScores(s064, s064Mean); 
            s065Gen = ManhDist.CalculateGenuineScores(s065, s065Mean);
            s066Gen = ManhDist.CalculateGenuineScores(s066, s066Mean);
            s067Gen = ManhDist.CalculateGenuineScores(s067, s067Mean);
            s068Gen = ManhDist.CalculateGenuineScores(s068, s068Mean);
            s069Gen = ManhDist.CalculateGenuineScores(s069, s069Mean);
            s070Gen = ManhDist.CalculateGenuineScores(s070, s070Mean);

            s071Gen = ManhDist.CalculateGenuineScores(s071, s071Mean);
            s072Gen = ManhDist.CalculateGenuineScores(s072, s072Mean);
            s073Gen = ManhDist.CalculateGenuineScores(s073, s073Mean);
            s074Gen = ManhDist.CalculateGenuineScores(s074, s074Mean);
            s075Gen = ManhDist.CalculateGenuineScores(s075, s075Mean);
            s076Gen = ManhDist.CalculateGenuineScores(s076, s076Mean);
            s077Gen = ManhDist.CalculateGenuineScores(s077, s077Mean);
            s078Gen = ManhDist.CalculateGenuineScores(s078, s078Mean);
            s079Gen = ManhDist.CalculateGenuineScores(s079, s079Mean);
            s080Gen = ManhDist.CalculateGenuineScores(s080, s080Mean);

            s081Gen = ManhDist.CalculateGenuineScores(s081, s081Mean);
            s082Gen = ManhDist.CalculateGenuineScores(s082, s082Mean);
            s083Gen = ManhDist.CalculateGenuineScores(s083, s083Mean);
            s084Gen = ManhDist.CalculateGenuineScores(s084, s084Mean);
            s085Gen = ManhDist.CalculateGenuineScores(s085, s085Mean);
            s086Gen = ManhDist.CalculateGenuineScores(s086, s086Mean);
            s087Gen = ManhDist.CalculateGenuineScores(s087, s087Mean);
            s088Gen = ManhDist.CalculateGenuineScores(s088, s088Mean);
            s089Gen = ManhDist.CalculateGenuineScores(s089, s089Mean);
            s090Gen = ManhDist.CalculateGenuineScores(s090, s090Mean);

            s091Gen = ManhDist.CalculateGenuineScores(s091, s091Mean);
            s092Gen = ManhDist.CalculateGenuineScores(s092, s092Mean);
            s093Gen = ManhDist.CalculateGenuineScores(s093, s093Mean);
            s094Gen = ManhDist.CalculateGenuineScores(s094, s094Mean);
            s095Gen = ManhDist.CalculateGenuineScores(s095, s095Mean);
            s096Gen = ManhDist.CalculateGenuineScores(s096, s096Mean);
            s097Gen = ManhDist.CalculateGenuineScores(s097, s097Mean);
            s098Gen = ManhDist.CalculateGenuineScores(s098, s098Mean);
            s099Gen = ManhDist.CalculateGenuineScores(s099, s099Mean);
            s100Gen = ManhDist.CalculateGenuineScores(s100, s100Mean); 
            #endregion

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
            impostorScoresUser1User34 = ManhDist.CalculateImpostorScores(s001Mean, s034);
            impostorScoresUser1User35 = ManhDist.CalculateImpostorScores(s001Mean, s035);
            impostorScoresUser1User36 = ManhDist.CalculateImpostorScores(s001Mean, s036);
            impostorScoresUser1User37 = ManhDist.CalculateImpostorScores(s001Mean, s037);
            impostorScoresUser1User38 = ManhDist.CalculateImpostorScores(s001Mean, s038);
            impostorScoresUser1User39 = ManhDist.CalculateImpostorScores(s001Mean, s039);
            impostorScoresUser1User40 = ManhDist.CalculateImpostorScores(s001Mean, s040);

            impostorScoresUser1User41 = ManhDist.CalculateImpostorScores(s001Mean, s041);
            impostorScoresUser1User42 = ManhDist.CalculateImpostorScores(s001Mean, s042);
            impostorScoresUser1User43 = ManhDist.CalculateImpostorScores(s001Mean, s043);
            impostorScoresUser1User44 = ManhDist.CalculateImpostorScores(s001Mean, s044);
            impostorScoresUser1User45 = ManhDist.CalculateImpostorScores(s001Mean, s045);
            impostorScoresUser1User46 = ManhDist.CalculateImpostorScores(s001Mean, s046);
            impostorScoresUser1User47 = ManhDist.CalculateImpostorScores(s001Mean, s047);
            impostorScoresUser1User48 = ManhDist.CalculateImpostorScores(s001Mean, s048);
            impostorScoresUser1User49 = ManhDist.CalculateImpostorScores(s001Mean, s049);
            impostorScoresUser1User50 = ManhDist.CalculateImpostorScores(s001Mean, s050);

            impostorScoresUser1User51 = ManhDist.CalculateImpostorScores(s001Mean, s051);
            impostorScoresUser1User52 = ManhDist.CalculateImpostorScores(s001Mean, s052);
            impostorScoresUser1User53 = ManhDist.CalculateImpostorScores(s001Mean, s053);
            impostorScoresUser1User54 = ManhDist.CalculateImpostorScores(s001Mean, s054);
            impostorScoresUser1User55 = ManhDist.CalculateImpostorScores(s001Mean, s055);
            impostorScoresUser1User56 = ManhDist.CalculateImpostorScores(s001Mean, s056);
            impostorScoresUser1User57 = ManhDist.CalculateImpostorScores(s001Mean, s057);
            impostorScoresUser1User58 = ManhDist.CalculateImpostorScores(s001Mean, s058);
            impostorScoresUser1User59 = ManhDist.CalculateImpostorScores(s001Mean, s059);
            impostorScoresUser1User60 = ManhDist.CalculateImpostorScores(s001Mean, s060);

            impostorScoresUser1User61 = ManhDist.CalculateImpostorScores(s001Mean, s061);
            impostorScoresUser1User62 = ManhDist.CalculateImpostorScores(s001Mean, s062);
            impostorScoresUser1User63 = ManhDist.CalculateImpostorScores(s001Mean, s063);
            impostorScoresUser1User64 = ManhDist.CalculateImpostorScores(s001Mean, s064);
            impostorScoresUser1User65 = ManhDist.CalculateImpostorScores(s001Mean, s065);
            impostorScoresUser1User66 = ManhDist.CalculateImpostorScores(s001Mean, s066);
            impostorScoresUser1User67 = ManhDist.CalculateImpostorScores(s001Mean, s067);
            impostorScoresUser1User68 = ManhDist.CalculateImpostorScores(s001Mean, s068);
            impostorScoresUser1User69 = ManhDist.CalculateImpostorScores(s001Mean, s069);
            impostorScoresUser1User70 = ManhDist.CalculateImpostorScores(s001Mean, s070);

            impostorScoresUser1User71 = ManhDist.CalculateImpostorScores(s001Mean, s071);
            impostorScoresUser1User72 = ManhDist.CalculateImpostorScores(s001Mean, s072);
            impostorScoresUser1User73 = ManhDist.CalculateImpostorScores(s001Mean, s073);
            impostorScoresUser1User74 = ManhDist.CalculateImpostorScores(s001Mean, s074);
            impostorScoresUser1User75 = ManhDist.CalculateImpostorScores(s001Mean, s075);
            impostorScoresUser1User76 = ManhDist.CalculateImpostorScores(s001Mean, s076);
            impostorScoresUser1User77 = ManhDist.CalculateImpostorScores(s001Mean, s077);
            impostorScoresUser1User78 = ManhDist.CalculateImpostorScores(s001Mean, s078);
            impostorScoresUser1User79 = ManhDist.CalculateImpostorScores(s001Mean, s079);
            impostorScoresUser1User80 = ManhDist.CalculateImpostorScores(s001Mean, s080);

            impostorScoresUser1User81 = ManhDist.CalculateImpostorScores(s001Mean, s081);
            impostorScoresUser1User82 = ManhDist.CalculateImpostorScores(s001Mean, s082);
            impostorScoresUser1User83 = ManhDist.CalculateImpostorScores(s001Mean, s083);
            impostorScoresUser1User84 = ManhDist.CalculateImpostorScores(s001Mean, s084);
            impostorScoresUser1User85 = ManhDist.CalculateImpostorScores(s001Mean, s085);
            impostorScoresUser1User86 = ManhDist.CalculateImpostorScores(s001Mean, s086);
            impostorScoresUser1User87 = ManhDist.CalculateImpostorScores(s001Mean, s087);
            impostorScoresUser1User88 = ManhDist.CalculateImpostorScores(s001Mean, s088);
            impostorScoresUser1User89 = ManhDist.CalculateImpostorScores(s001Mean, s089);
            impostorScoresUser1User90 = ManhDist.CalculateImpostorScores(s001Mean, s090);

            impostorScoresUser1User91 = ManhDist.CalculateImpostorScores(s001Mean, s091);
            impostorScoresUser1User92 = ManhDist.CalculateImpostorScores(s001Mean, s092);
            impostorScoresUser1User93 = ManhDist.CalculateImpostorScores(s001Mean, s093);
            impostorScoresUser1User94 = ManhDist.CalculateImpostorScores(s001Mean, s094);
            impostorScoresUser1User95 = ManhDist.CalculateImpostorScores(s001Mean, s095);
            impostorScoresUser1User96 = ManhDist.CalculateImpostorScores(s001Mean, s096);
            impostorScoresUser1User97 = ManhDist.CalculateImpostorScores(s001Mean, s097);
            impostorScoresUser1User98 = ManhDist.CalculateImpostorScores(s001Mean, s098);
            impostorScoresUser1User99 = ManhDist.CalculateImpostorScores(s001Mean, s099);
            impostorScoresUser1User100 = ManhDist.CalculateImpostorScores(s001Mean, s100); 
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
            impostorScoresUser2User34 = ManhDist.CalculateImpostorScores(s002Mean, s034);
            impostorScoresUser2User35 = ManhDist.CalculateImpostorScores(s002Mean, s035);
            impostorScoresUser2User36 = ManhDist.CalculateImpostorScores(s002Mean, s036);
            impostorScoresUser2User37 = ManhDist.CalculateImpostorScores(s002Mean, s037);
            impostorScoresUser2User38 = ManhDist.CalculateImpostorScores(s002Mean, s038);
            impostorScoresUser2User39 = ManhDist.CalculateImpostorScores(s002Mean, s039);
            impostorScoresUser2User40 = ManhDist.CalculateImpostorScores(s002Mean, s040);

            impostorScoresUser2User41 = ManhDist.CalculateImpostorScores(s002Mean, s041);
            impostorScoresUser2User42 = ManhDist.CalculateImpostorScores(s002Mean, s042);
            impostorScoresUser2User43 = ManhDist.CalculateImpostorScores(s002Mean, s043);
            impostorScoresUser2User44 = ManhDist.CalculateImpostorScores(s002Mean, s044);
            impostorScoresUser2User45 = ManhDist.CalculateImpostorScores(s002Mean, s045);
            impostorScoresUser2User46 = ManhDist.CalculateImpostorScores(s002Mean, s046);
            impostorScoresUser2User47 = ManhDist.CalculateImpostorScores(s002Mean, s047);
            impostorScoresUser2User48 = ManhDist.CalculateImpostorScores(s002Mean, s048);
            impostorScoresUser2User49 = ManhDist.CalculateImpostorScores(s002Mean, s049);
            impostorScoresUser2User50 = ManhDist.CalculateImpostorScores(s002Mean, s050);

            impostorScoresUser2User51 = ManhDist.CalculateImpostorScores(s002Mean, s051);
            impostorScoresUser2User52 = ManhDist.CalculateImpostorScores(s002Mean, s052);
            impostorScoresUser2User53 = ManhDist.CalculateImpostorScores(s002Mean, s053);
            impostorScoresUser2User54 = ManhDist.CalculateImpostorScores(s002Mean, s054);
            impostorScoresUser2User55 = ManhDist.CalculateImpostorScores(s002Mean, s055);
            impostorScoresUser2User56 = ManhDist.CalculateImpostorScores(s002Mean, s056);
            impostorScoresUser2User57 = ManhDist.CalculateImpostorScores(s002Mean, s057);
            impostorScoresUser2User58 = ManhDist.CalculateImpostorScores(s002Mean, s058);
            impostorScoresUser2User59 = ManhDist.CalculateImpostorScores(s002Mean, s059);
            impostorScoresUser2User60 = ManhDist.CalculateImpostorScores(s002Mean, s060);

            impostorScoresUser2User61 = ManhDist.CalculateImpostorScores(s002Mean, s061);
            impostorScoresUser2User62 = ManhDist.CalculateImpostorScores(s002Mean, s062);
            impostorScoresUser2User63 = ManhDist.CalculateImpostorScores(s002Mean, s063);
            impostorScoresUser2User64 = ManhDist.CalculateImpostorScores(s002Mean, s064);
            impostorScoresUser2User65 = ManhDist.CalculateImpostorScores(s002Mean, s065);
            impostorScoresUser2User66 = ManhDist.CalculateImpostorScores(s002Mean, s066);
            impostorScoresUser2User67 = ManhDist.CalculateImpostorScores(s002Mean, s067);
            impostorScoresUser2User68 = ManhDist.CalculateImpostorScores(s002Mean, s068);
            impostorScoresUser2User69 = ManhDist.CalculateImpostorScores(s002Mean, s069);
            impostorScoresUser2User70 = ManhDist.CalculateImpostorScores(s002Mean, s070);

            impostorScoresUser2User71 = ManhDist.CalculateImpostorScores(s002Mean, s071);
            impostorScoresUser2User72 = ManhDist.CalculateImpostorScores(s002Mean, s072);
            impostorScoresUser2User73 = ManhDist.CalculateImpostorScores(s002Mean, s073);
            impostorScoresUser2User74 = ManhDist.CalculateImpostorScores(s002Mean, s074);
            impostorScoresUser2User75 = ManhDist.CalculateImpostorScores(s002Mean, s075);
            impostorScoresUser2User76 = ManhDist.CalculateImpostorScores(s002Mean, s076);
            impostorScoresUser2User77 = ManhDist.CalculateImpostorScores(s002Mean, s077);
            impostorScoresUser2User78 = ManhDist.CalculateImpostorScores(s002Mean, s078);
            impostorScoresUser2User79 = ManhDist.CalculateImpostorScores(s002Mean, s079);
            impostorScoresUser2User80 = ManhDist.CalculateImpostorScores(s002Mean, s080);

            impostorScoresUser2User81 = ManhDist.CalculateImpostorScores(s002Mean, s081);
            impostorScoresUser2User82 = ManhDist.CalculateImpostorScores(s002Mean, s082);
            impostorScoresUser2User83 = ManhDist.CalculateImpostorScores(s002Mean, s083);
            impostorScoresUser2User84 = ManhDist.CalculateImpostorScores(s002Mean, s084);
            impostorScoresUser2User85 = ManhDist.CalculateImpostorScores(s002Mean, s085);
            impostorScoresUser2User86 = ManhDist.CalculateImpostorScores(s002Mean, s086);
            impostorScoresUser2User87 = ManhDist.CalculateImpostorScores(s002Mean, s087);
            impostorScoresUser2User88 = ManhDist.CalculateImpostorScores(s002Mean, s088);
            impostorScoresUser2User89 = ManhDist.CalculateImpostorScores(s002Mean, s089);
            impostorScoresUser2User90 = ManhDist.CalculateImpostorScores(s002Mean, s090);

            impostorScoresUser2User91 = ManhDist.CalculateImpostorScores(s002Mean, s091);
            impostorScoresUser2User92 = ManhDist.CalculateImpostorScores(s002Mean, s092);
            impostorScoresUser2User93 = ManhDist.CalculateImpostorScores(s002Mean, s093);
            impostorScoresUser2User94 = ManhDist.CalculateImpostorScores(s002Mean, s094);
            impostorScoresUser2User95 = ManhDist.CalculateImpostorScores(s002Mean, s095);
            impostorScoresUser2User96 = ManhDist.CalculateImpostorScores(s002Mean, s096);
            impostorScoresUser2User97 = ManhDist.CalculateImpostorScores(s002Mean, s097);
            impostorScoresUser2User98 = ManhDist.CalculateImpostorScores(s002Mean, s098);
            impostorScoresUser2User99 = ManhDist.CalculateImpostorScores(s002Mean, s099);
            impostorScoresUser2User100 = ManhDist.CalculateImpostorScores(s002Mean, s100); 
            #endregion

            #region User 3 Impostor Scores
            impostorScoresUser3User1 = ManhDist.CalculateImpostorScores(s003Mean, s001);
            impostorScoresUser3User2 = ManhDist.CalculateImpostorScores(s003Mean, s002);
            impostorScoresUser3User4 = ManhDist.CalculateImpostorScores(s003Mean, s004);
            impostorScoresUser3User5 = ManhDist.CalculateImpostorScores(s003Mean, s005);
            impostorScoresUser3User6 = ManhDist.CalculateImpostorScores(s003Mean, s006);
            impostorScoresUser3User7 = ManhDist.CalculateImpostorScores(s003Mean, s007);
            impostorScoresUser3User8 = ManhDist.CalculateImpostorScores(s003Mean, s008);
            impostorScoresUser3User9 = ManhDist.CalculateImpostorScores(s003Mean, s009);
            impostorScoresUser3User10 = ManhDist.CalculateImpostorScores(s003Mean, s010);

            impostorScoresUser3User11 = ManhDist.CalculateImpostorScores(s003Mean, s011);
            impostorScoresUser3User12 = ManhDist.CalculateImpostorScores(s003Mean, s012);
            impostorScoresUser3User13 = ManhDist.CalculateImpostorScores(s003Mean, s013);
            impostorScoresUser3User14 = ManhDist.CalculateImpostorScores(s003Mean, s014);
            impostorScoresUser3User15 = ManhDist.CalculateImpostorScores(s003Mean, s015);
            impostorScoresUser3User16 = ManhDist.CalculateImpostorScores(s003Mean, s016);
            impostorScoresUser3User17 = ManhDist.CalculateImpostorScores(s003Mean, s017);
            impostorScoresUser3User18 = ManhDist.CalculateImpostorScores(s003Mean, s018);
            impostorScoresUser3User19 = ManhDist.CalculateImpostorScores(s003Mean, s019);
            impostorScoresUser3User20 = ManhDist.CalculateImpostorScores(s003Mean, s020);

            impostorScoresUser3User21 = ManhDist.CalculateImpostorScores(s003Mean, s021);
            impostorScoresUser3User22 = ManhDist.CalculateImpostorScores(s003Mean, s022);
            impostorScoresUser3User23 = ManhDist.CalculateImpostorScores(s003Mean, s023);
            impostorScoresUser3User24 = ManhDist.CalculateImpostorScores(s003Mean, s024);
            impostorScoresUser3User25 = ManhDist.CalculateImpostorScores(s003Mean, s025);
            impostorScoresUser3User26 = ManhDist.CalculateImpostorScores(s003Mean, s026);
            impostorScoresUser3User27 = ManhDist.CalculateImpostorScores(s003Mean, s027);
            impostorScoresUser3User28 = ManhDist.CalculateImpostorScores(s003Mean, s028);
            impostorScoresUser3User29 = ManhDist.CalculateImpostorScores(s003Mean, s029);
            impostorScoresUser3User30 = ManhDist.CalculateImpostorScores(s003Mean, s030); 

            impostorScoresUser3User31 = ManhDist.CalculateImpostorScores(s003Mean, s031);
            impostorScoresUser3User32 = ManhDist.CalculateImpostorScores(s003Mean, s032);
            impostorScoresUser3User33 = ManhDist.CalculateImpostorScores(s003Mean, s033);
            impostorScoresUser3User34 = ManhDist.CalculateImpostorScores(s003Mean, s034);
            impostorScoresUser3User35 = ManhDist.CalculateImpostorScores(s003Mean, s035);
            impostorScoresUser3User36 = ManhDist.CalculateImpostorScores(s003Mean, s036);
            impostorScoresUser3User37 = ManhDist.CalculateImpostorScores(s003Mean, s037);
            impostorScoresUser3User38 = ManhDist.CalculateImpostorScores(s003Mean, s038);
            impostorScoresUser3User39 = ManhDist.CalculateImpostorScores(s003Mean, s039);
            impostorScoresUser3User40 = ManhDist.CalculateImpostorScores(s003Mean, s040);

            impostorScoresUser3User41 = ManhDist.CalculateImpostorScores(s003Mean, s041);
            impostorScoresUser3User42 = ManhDist.CalculateImpostorScores(s003Mean, s042);
            impostorScoresUser3User43 = ManhDist.CalculateImpostorScores(s003Mean, s043);
            impostorScoresUser3User44 = ManhDist.CalculateImpostorScores(s003Mean, s044);
            impostorScoresUser3User45 = ManhDist.CalculateImpostorScores(s003Mean, s045);
            impostorScoresUser3User46 = ManhDist.CalculateImpostorScores(s003Mean, s046);
            impostorScoresUser3User47 = ManhDist.CalculateImpostorScores(s003Mean, s047);
            impostorScoresUser3User48 = ManhDist.CalculateImpostorScores(s003Mean, s048);
            impostorScoresUser3User49 = ManhDist.CalculateImpostorScores(s003Mean, s049);
            impostorScoresUser3User50 = ManhDist.CalculateImpostorScores(s003Mean, s050);

            impostorScoresUser3User51 = ManhDist.CalculateImpostorScores(s003Mean, s051);
            impostorScoresUser3User52 = ManhDist.CalculateImpostorScores(s003Mean, s052);
            impostorScoresUser3User53 = ManhDist.CalculateImpostorScores(s003Mean, s053);
            impostorScoresUser3User54 = ManhDist.CalculateImpostorScores(s003Mean, s054);
            impostorScoresUser3User55 = ManhDist.CalculateImpostorScores(s003Mean, s055);
            impostorScoresUser3User56 = ManhDist.CalculateImpostorScores(s003Mean, s056);
            impostorScoresUser3User57 = ManhDist.CalculateImpostorScores(s003Mean, s057);
            impostorScoresUser3User58 = ManhDist.CalculateImpostorScores(s003Mean, s058);
            impostorScoresUser3User59 = ManhDist.CalculateImpostorScores(s003Mean, s059);
            impostorScoresUser3User60 = ManhDist.CalculateImpostorScores(s003Mean, s060);

            impostorScoresUser3User61 = ManhDist.CalculateImpostorScores(s003Mean, s061);
            impostorScoresUser3User62 = ManhDist.CalculateImpostorScores(s003Mean, s062);
            impostorScoresUser3User63 = ManhDist.CalculateImpostorScores(s003Mean, s063);
            impostorScoresUser3User64 = ManhDist.CalculateImpostorScores(s003Mean, s064);
            impostorScoresUser3User65 = ManhDist.CalculateImpostorScores(s003Mean, s065);
            impostorScoresUser3User66 = ManhDist.CalculateImpostorScores(s003Mean, s066);
            impostorScoresUser3User67 = ManhDist.CalculateImpostorScores(s003Mean, s067);
            impostorScoresUser3User68 = ManhDist.CalculateImpostorScores(s003Mean, s068);
            impostorScoresUser3User69 = ManhDist.CalculateImpostorScores(s003Mean, s069);
            impostorScoresUser3User70 = ManhDist.CalculateImpostorScores(s003Mean, s070);

            impostorScoresUser3User71 = ManhDist.CalculateImpostorScores(s003Mean, s071);
            impostorScoresUser3User72 = ManhDist.CalculateImpostorScores(s003Mean, s072);
            impostorScoresUser3User73 = ManhDist.CalculateImpostorScores(s003Mean, s073);
            impostorScoresUser3User74 = ManhDist.CalculateImpostorScores(s003Mean, s074);
            impostorScoresUser3User75 = ManhDist.CalculateImpostorScores(s003Mean, s075);
            impostorScoresUser3User76 = ManhDist.CalculateImpostorScores(s003Mean, s076);
            impostorScoresUser3User77 = ManhDist.CalculateImpostorScores(s003Mean, s077);
            impostorScoresUser3User78 = ManhDist.CalculateImpostorScores(s003Mean, s078);
            impostorScoresUser3User79 = ManhDist.CalculateImpostorScores(s003Mean, s079);
            impostorScoresUser3User80 = ManhDist.CalculateImpostorScores(s003Mean, s080);

            impostorScoresUser3User81 = ManhDist.CalculateImpostorScores(s003Mean, s081);
            impostorScoresUser3User82 = ManhDist.CalculateImpostorScores(s003Mean, s082);
            impostorScoresUser3User83 = ManhDist.CalculateImpostorScores(s003Mean, s083);
            impostorScoresUser3User84 = ManhDist.CalculateImpostorScores(s003Mean, s084);
            impostorScoresUser3User85 = ManhDist.CalculateImpostorScores(s003Mean, s085);
            impostorScoresUser3User86 = ManhDist.CalculateImpostorScores(s003Mean, s086);
            impostorScoresUser3User87 = ManhDist.CalculateImpostorScores(s003Mean, s087);
            impostorScoresUser3User88 = ManhDist.CalculateImpostorScores(s003Mean, s088);
            impostorScoresUser3User89 = ManhDist.CalculateImpostorScores(s003Mean, s089);
            impostorScoresUser3User90 = ManhDist.CalculateImpostorScores(s003Mean, s090);

            impostorScoresUser3User91 = ManhDist.CalculateImpostorScores(s003Mean, s091);
            impostorScoresUser3User92 = ManhDist.CalculateImpostorScores(s003Mean, s092);
            impostorScoresUser3User93 = ManhDist.CalculateImpostorScores(s003Mean, s093);
            impostorScoresUser3User94 = ManhDist.CalculateImpostorScores(s003Mean, s094);
            impostorScoresUser3User95 = ManhDist.CalculateImpostorScores(s003Mean, s095);
            impostorScoresUser3User96 = ManhDist.CalculateImpostorScores(s003Mean, s096);
            impostorScoresUser3User97 = ManhDist.CalculateImpostorScores(s003Mean, s097);
            impostorScoresUser3User98 = ManhDist.CalculateImpostorScores(s003Mean, s098);
            impostorScoresUser3User99 = ManhDist.CalculateImpostorScores(s003Mean, s099);
            impostorScoresUser3User100 = ManhDist.CalculateImpostorScores(s003Mean, s100);
            #endregion

            #region User 4 Impostor Scores
            impostorScoresUser4User1 = ManhDist.CalculateImpostorScores(s004Mean, s001);
            impostorScoresUser4User2 = ManhDist.CalculateImpostorScores(s004Mean, s002);
            impostorScoresUser4User3 = ManhDist.CalculateImpostorScores(s004Mean, s003);
            impostorScoresUser4User5 = ManhDist.CalculateImpostorScores(s004Mean, s005);
            impostorScoresUser4User6 = ManhDist.CalculateImpostorScores(s004Mean, s006);
            impostorScoresUser4User7 = ManhDist.CalculateImpostorScores(s004Mean, s007);
            impostorScoresUser4User8 = ManhDist.CalculateImpostorScores(s004Mean, s008);
            impostorScoresUser4User9 = ManhDist.CalculateImpostorScores(s004Mean, s009);
            impostorScoresUser4User10 = ManhDist.CalculateImpostorScores(s004Mean, s010);

            impostorScoresUser4User11 = ManhDist.CalculateImpostorScores(s004Mean, s011);
            impostorScoresUser4User12 = ManhDist.CalculateImpostorScores(s004Mean, s012);
            impostorScoresUser4User13 = ManhDist.CalculateImpostorScores(s004Mean, s013);
            impostorScoresUser4User14 = ManhDist.CalculateImpostorScores(s004Mean, s014);
            impostorScoresUser4User15 = ManhDist.CalculateImpostorScores(s004Mean, s015);
            impostorScoresUser4User16 = ManhDist.CalculateImpostorScores(s004Mean, s016);
            impostorScoresUser4User17 = ManhDist.CalculateImpostorScores(s004Mean, s017);
            impostorScoresUser4User18 = ManhDist.CalculateImpostorScores(s004Mean, s018);
            impostorScoresUser4User19 = ManhDist.CalculateImpostorScores(s004Mean, s019);
            impostorScoresUser4User20 = ManhDist.CalculateImpostorScores(s004Mean, s020);

            impostorScoresUser4User21 = ManhDist.CalculateImpostorScores(s004Mean, s021);
            impostorScoresUser4User22 = ManhDist.CalculateImpostorScores(s004Mean, s022);
            impostorScoresUser4User23 = ManhDist.CalculateImpostorScores(s004Mean, s023);
            impostorScoresUser4User24 = ManhDist.CalculateImpostorScores(s004Mean, s024);
            impostorScoresUser4User25 = ManhDist.CalculateImpostorScores(s004Mean, s025);
            impostorScoresUser4User26 = ManhDist.CalculateImpostorScores(s004Mean, s026);
            impostorScoresUser4User27 = ManhDist.CalculateImpostorScores(s004Mean, s027);
            impostorScoresUser4User28 = ManhDist.CalculateImpostorScores(s004Mean, s028);
            impostorScoresUser4User29 = ManhDist.CalculateImpostorScores(s004Mean, s029);
            impostorScoresUser4User30 = ManhDist.CalculateImpostorScores(s004Mean, s030);

            impostorScoresUser4User31 = ManhDist.CalculateImpostorScores(s004Mean, s031);
            impostorScoresUser4User32 = ManhDist.CalculateImpostorScores(s004Mean, s032);
            impostorScoresUser4User33 = ManhDist.CalculateImpostorScores(s004Mean, s033);
            impostorScoresUser4User34 = ManhDist.CalculateImpostorScores(s004Mean, s034);
            impostorScoresUser4User35 = ManhDist.CalculateImpostorScores(s004Mean, s035);
            impostorScoresUser4User36 = ManhDist.CalculateImpostorScores(s004Mean, s036);
            impostorScoresUser4User37 = ManhDist.CalculateImpostorScores(s004Mean, s037);
            impostorScoresUser4User38 = ManhDist.CalculateImpostorScores(s004Mean, s038);
            impostorScoresUser4User39 = ManhDist.CalculateImpostorScores(s004Mean, s039);
            impostorScoresUser4User40 = ManhDist.CalculateImpostorScores(s004Mean, s040);

            impostorScoresUser4User41 = ManhDist.CalculateImpostorScores(s004Mean, s041);
            impostorScoresUser4User42 = ManhDist.CalculateImpostorScores(s004Mean, s042);
            impostorScoresUser4User43 = ManhDist.CalculateImpostorScores(s004Mean, s043);
            impostorScoresUser4User44 = ManhDist.CalculateImpostorScores(s004Mean, s044);
            impostorScoresUser4User45 = ManhDist.CalculateImpostorScores(s004Mean, s045);
            impostorScoresUser4User46 = ManhDist.CalculateImpostorScores(s004Mean, s046);
            impostorScoresUser4User47 = ManhDist.CalculateImpostorScores(s004Mean, s047);
            impostorScoresUser4User48 = ManhDist.CalculateImpostorScores(s004Mean, s048);
            impostorScoresUser4User49 = ManhDist.CalculateImpostorScores(s004Mean, s049);
            impostorScoresUser4User50 = ManhDist.CalculateImpostorScores(s004Mean, s050);

            impostorScoresUser4User51 = ManhDist.CalculateImpostorScores(s004Mean, s051);
            impostorScoresUser4User52 = ManhDist.CalculateImpostorScores(s004Mean, s052);
            impostorScoresUser4User53 = ManhDist.CalculateImpostorScores(s004Mean, s053);
            impostorScoresUser4User54 = ManhDist.CalculateImpostorScores(s004Mean, s054);
            impostorScoresUser4User55 = ManhDist.CalculateImpostorScores(s004Mean, s055);
            impostorScoresUser4User56 = ManhDist.CalculateImpostorScores(s004Mean, s056);
            impostorScoresUser4User57 = ManhDist.CalculateImpostorScores(s004Mean, s057);
            impostorScoresUser4User58 = ManhDist.CalculateImpostorScores(s004Mean, s058);
            impostorScoresUser4User59 = ManhDist.CalculateImpostorScores(s004Mean, s059);
            impostorScoresUser4User60 = ManhDist.CalculateImpostorScores(s004Mean, s060);

            impostorScoresUser4User61 = ManhDist.CalculateImpostorScores(s004Mean, s061);
            impostorScoresUser4User62 = ManhDist.CalculateImpostorScores(s004Mean, s062);
            impostorScoresUser4User63 = ManhDist.CalculateImpostorScores(s004Mean, s063);
            impostorScoresUser4User64 = ManhDist.CalculateImpostorScores(s004Mean, s064);
            impostorScoresUser4User65 = ManhDist.CalculateImpostorScores(s004Mean, s065);
            impostorScoresUser4User66 = ManhDist.CalculateImpostorScores(s004Mean, s066);
            impostorScoresUser4User67 = ManhDist.CalculateImpostorScores(s004Mean, s067);
            impostorScoresUser4User68 = ManhDist.CalculateImpostorScores(s004Mean, s068);
            impostorScoresUser4User69 = ManhDist.CalculateImpostorScores(s004Mean, s069);
            impostorScoresUser4User70 = ManhDist.CalculateImpostorScores(s004Mean, s070);

            impostorScoresUser4User71 = ManhDist.CalculateImpostorScores(s004Mean, s071);
            impostorScoresUser4User72 = ManhDist.CalculateImpostorScores(s004Mean, s072);
            impostorScoresUser4User73 = ManhDist.CalculateImpostorScores(s004Mean, s073);
            impostorScoresUser4User74 = ManhDist.CalculateImpostorScores(s004Mean, s074);
            impostorScoresUser4User75 = ManhDist.CalculateImpostorScores(s004Mean, s075);
            impostorScoresUser4User76 = ManhDist.CalculateImpostorScores(s004Mean, s076);
            impostorScoresUser4User77 = ManhDist.CalculateImpostorScores(s004Mean, s077);
            impostorScoresUser4User78 = ManhDist.CalculateImpostorScores(s004Mean, s078);
            impostorScoresUser4User79 = ManhDist.CalculateImpostorScores(s004Mean, s079);
            impostorScoresUser4User80 = ManhDist.CalculateImpostorScores(s004Mean, s080);

            impostorScoresUser4User81 = ManhDist.CalculateImpostorScores(s004Mean, s081);
            impostorScoresUser4User82 = ManhDist.CalculateImpostorScores(s004Mean, s082);
            impostorScoresUser4User83 = ManhDist.CalculateImpostorScores(s004Mean, s083);
            impostorScoresUser4User84 = ManhDist.CalculateImpostorScores(s004Mean, s084);
            impostorScoresUser4User85 = ManhDist.CalculateImpostorScores(s004Mean, s085);
            impostorScoresUser4User86 = ManhDist.CalculateImpostorScores(s004Mean, s086);
            impostorScoresUser4User87 = ManhDist.CalculateImpostorScores(s004Mean, s087);
            impostorScoresUser4User88 = ManhDist.CalculateImpostorScores(s004Mean, s088);
            impostorScoresUser4User89 = ManhDist.CalculateImpostorScores(s004Mean, s089);
            impostorScoresUser4User90 = ManhDist.CalculateImpostorScores(s004Mean, s090);

            impostorScoresUser4User91 = ManhDist.CalculateImpostorScores(s004Mean, s091);
            impostorScoresUser4User92 = ManhDist.CalculateImpostorScores(s004Mean, s092);
            impostorScoresUser4User93 = ManhDist.CalculateImpostorScores(s004Mean, s093);
            impostorScoresUser4User94 = ManhDist.CalculateImpostorScores(s004Mean, s094);
            impostorScoresUser4User95 = ManhDist.CalculateImpostorScores(s004Mean, s095);
            impostorScoresUser4User96 = ManhDist.CalculateImpostorScores(s004Mean, s096);
            impostorScoresUser4User97 = ManhDist.CalculateImpostorScores(s004Mean, s097);
            impostorScoresUser4User98 = ManhDist.CalculateImpostorScores(s004Mean, s098);
            impostorScoresUser4User99 = ManhDist.CalculateImpostorScores(s004Mean, s099);
            impostorScoresUser4User100 = ManhDist.CalculateImpostorScores(s004Mean, s100);
            #endregion

            #region User 5 Impostor Scores
            impostorScoresUser5User1 = ManhDist.CalculateImpostorScores(s005Mean, s001);
            impostorScoresUser5User2 = ManhDist.CalculateImpostorScores(s005Mean, s002);
            impostorScoresUser5User3 = ManhDist.CalculateImpostorScores(s005Mean, s003);
            impostorScoresUser5User4 = ManhDist.CalculateImpostorScores(s005Mean, s004);
            impostorScoresUser5User6 = ManhDist.CalculateImpostorScores(s005Mean, s006);
            impostorScoresUser5User7 = ManhDist.CalculateImpostorScores(s005Mean, s007);
            impostorScoresUser5User8 = ManhDist.CalculateImpostorScores(s005Mean, s008);
            impostorScoresUser5User9 = ManhDist.CalculateImpostorScores(s005Mean, s009);

            impostorScoresUser5User10 = ManhDist.CalculateImpostorScores(s005Mean, s010);
            impostorScoresUser5User11 = ManhDist.CalculateImpostorScores(s005Mean, s011);
            impostorScoresUser5User12 = ManhDist.CalculateImpostorScores(s005Mean, s012);
            impostorScoresUser5User13 = ManhDist.CalculateImpostorScores(s005Mean, s013);
            impostorScoresUser5User14 = ManhDist.CalculateImpostorScores(s005Mean, s014);
            impostorScoresUser5User15 = ManhDist.CalculateImpostorScores(s005Mean, s015);
            impostorScoresUser5User16 = ManhDist.CalculateImpostorScores(s005Mean, s016);
            impostorScoresUser5User17 = ManhDist.CalculateImpostorScores(s005Mean, s017);
            impostorScoresUser5User18 = ManhDist.CalculateImpostorScores(s005Mean, s018);
            impostorScoresUser5User19 = ManhDist.CalculateImpostorScores(s005Mean, s019);
            impostorScoresUser5User20 = ManhDist.CalculateImpostorScores(s005Mean, s020);

            impostorScoresUser5User21 = ManhDist.CalculateImpostorScores(s005Mean, s021);
            impostorScoresUser5User22 = ManhDist.CalculateImpostorScores(s005Mean, s022);
            impostorScoresUser5User23 = ManhDist.CalculateImpostorScores(s005Mean, s023);
            impostorScoresUser5User24 = ManhDist.CalculateImpostorScores(s005Mean, s024);
            impostorScoresUser5User25 = ManhDist.CalculateImpostorScores(s005Mean, s025);
            impostorScoresUser5User26 = ManhDist.CalculateImpostorScores(s005Mean, s026);
            impostorScoresUser5User27 = ManhDist.CalculateImpostorScores(s005Mean, s027);
            impostorScoresUser5User28 = ManhDist.CalculateImpostorScores(s005Mean, s028);
            impostorScoresUser5User29 = ManhDist.CalculateImpostorScores(s005Mean, s029);
            impostorScoresUser5User30 = ManhDist.CalculateImpostorScores(s005Mean, s030);

            impostorScoresUser5User31 = ManhDist.CalculateImpostorScores(s005Mean, s031);
            impostorScoresUser5User32 = ManhDist.CalculateImpostorScores(s005Mean, s032);
            impostorScoresUser5User33 = ManhDist.CalculateImpostorScores(s005Mean, s033);
            impostorScoresUser5User34 = ManhDist.CalculateImpostorScores(s005Mean, s034);
            impostorScoresUser5User35 = ManhDist.CalculateImpostorScores(s005Mean, s035);
            impostorScoresUser5User36 = ManhDist.CalculateImpostorScores(s005Mean, s036);
            impostorScoresUser5User37 = ManhDist.CalculateImpostorScores(s005Mean, s037);
            impostorScoresUser5User38 = ManhDist.CalculateImpostorScores(s005Mean, s038);
            impostorScoresUser5User39 = ManhDist.CalculateImpostorScores(s005Mean, s039);
            impostorScoresUser5User40 = ManhDist.CalculateImpostorScores(s005Mean, s040);

            impostorScoresUser5User41 = ManhDist.CalculateImpostorScores(s005Mean, s041);
            impostorScoresUser5User42 = ManhDist.CalculateImpostorScores(s005Mean, s042);
            impostorScoresUser5User43 = ManhDist.CalculateImpostorScores(s005Mean, s043);
            impostorScoresUser5User44 = ManhDist.CalculateImpostorScores(s005Mean, s044);
            impostorScoresUser5User45 = ManhDist.CalculateImpostorScores(s005Mean, s045);
            impostorScoresUser5User46 = ManhDist.CalculateImpostorScores(s005Mean, s046);
            impostorScoresUser5User47 = ManhDist.CalculateImpostorScores(s005Mean, s047);
            impostorScoresUser5User48 = ManhDist.CalculateImpostorScores(s005Mean, s048);
            impostorScoresUser5User49 = ManhDist.CalculateImpostorScores(s005Mean, s049);
            impostorScoresUser5User50 = ManhDist.CalculateImpostorScores(s005Mean, s050);

            impostorScoresUser5User51 = ManhDist.CalculateImpostorScores(s005Mean, s051);
            impostorScoresUser5User52 = ManhDist.CalculateImpostorScores(s005Mean, s052);
            impostorScoresUser5User53 = ManhDist.CalculateImpostorScores(s005Mean, s053);
            impostorScoresUser5User54 = ManhDist.CalculateImpostorScores(s005Mean, s054);
            impostorScoresUser5User55 = ManhDist.CalculateImpostorScores(s005Mean, s055);
            impostorScoresUser5User56 = ManhDist.CalculateImpostorScores(s005Mean, s056);
            impostorScoresUser5User57 = ManhDist.CalculateImpostorScores(s005Mean, s057);
            impostorScoresUser5User58 = ManhDist.CalculateImpostorScores(s005Mean, s058);
            impostorScoresUser5User59 = ManhDist.CalculateImpostorScores(s005Mean, s059);
            impostorScoresUser5User60 = ManhDist.CalculateImpostorScores(s005Mean, s060);

            impostorScoresUser5User61 = ManhDist.CalculateImpostorScores(s005Mean, s061);
            impostorScoresUser5User62 = ManhDist.CalculateImpostorScores(s005Mean, s062);
            impostorScoresUser5User63 = ManhDist.CalculateImpostorScores(s005Mean, s063);
            impostorScoresUser5User64 = ManhDist.CalculateImpostorScores(s005Mean, s064);
            impostorScoresUser5User65 = ManhDist.CalculateImpostorScores(s005Mean, s065);
            impostorScoresUser5User66 = ManhDist.CalculateImpostorScores(s005Mean, s066);
            impostorScoresUser5User67 = ManhDist.CalculateImpostorScores(s005Mean, s067);
            impostorScoresUser5User68 = ManhDist.CalculateImpostorScores(s005Mean, s068);
            impostorScoresUser5User69 = ManhDist.CalculateImpostorScores(s005Mean, s069);
            impostorScoresUser5User70 = ManhDist.CalculateImpostorScores(s005Mean, s070);

            impostorScoresUser5User71 = ManhDist.CalculateImpostorScores(s005Mean, s071);
            impostorScoresUser5User72 = ManhDist.CalculateImpostorScores(s005Mean, s072);
            impostorScoresUser5User73 = ManhDist.CalculateImpostorScores(s005Mean, s073);
            impostorScoresUser5User74 = ManhDist.CalculateImpostorScores(s005Mean, s074);
            impostorScoresUser5User75 = ManhDist.CalculateImpostorScores(s005Mean, s075);
            impostorScoresUser5User76 = ManhDist.CalculateImpostorScores(s005Mean, s076);
            impostorScoresUser5User77 = ManhDist.CalculateImpostorScores(s005Mean, s077);
            impostorScoresUser5User78 = ManhDist.CalculateImpostorScores(s005Mean, s078);
            impostorScoresUser5User79 = ManhDist.CalculateImpostorScores(s005Mean, s079);
            impostorScoresUser5User80 = ManhDist.CalculateImpostorScores(s005Mean, s080);

            impostorScoresUser5User81 = ManhDist.CalculateImpostorScores(s005Mean, s081);
            impostorScoresUser5User82 = ManhDist.CalculateImpostorScores(s005Mean, s082);
            impostorScoresUser5User83 = ManhDist.CalculateImpostorScores(s005Mean, s083);
            impostorScoresUser5User84 = ManhDist.CalculateImpostorScores(s005Mean, s084);
            impostorScoresUser5User85 = ManhDist.CalculateImpostorScores(s005Mean, s085);
            impostorScoresUser5User86 = ManhDist.CalculateImpostorScores(s005Mean, s086);
            impostorScoresUser5User87 = ManhDist.CalculateImpostorScores(s005Mean, s087);
            impostorScoresUser5User88 = ManhDist.CalculateImpostorScores(s005Mean, s088);
            impostorScoresUser5User89 = ManhDist.CalculateImpostorScores(s005Mean, s089);
            impostorScoresUser5User90 = ManhDist.CalculateImpostorScores(s005Mean, s090);

            impostorScoresUser5User91 = ManhDist.CalculateImpostorScores(s005Mean, s091);
            impostorScoresUser5User92 = ManhDist.CalculateImpostorScores(s005Mean, s092);
            impostorScoresUser5User93 = ManhDist.CalculateImpostorScores(s005Mean, s093);
            impostorScoresUser5User94 = ManhDist.CalculateImpostorScores(s005Mean, s094);
            impostorScoresUser5User95 = ManhDist.CalculateImpostorScores(s005Mean, s095);
            impostorScoresUser5User96 = ManhDist.CalculateImpostorScores(s005Mean, s096);
            impostorScoresUser5User97 = ManhDist.CalculateImpostorScores(s005Mean, s097);
            impostorScoresUser5User98 = ManhDist.CalculateImpostorScores(s005Mean, s098);
            impostorScoresUser5User99 = ManhDist.CalculateImpostorScores(s005Mean, s099);
            impostorScoresUser5User100 = ManhDist.CalculateImpostorScores(s005Mean, s100); 
            #endregion

            #region User 6 Impostor Scores
            impostorScoresUser6User1 = ManhDist.CalculateImpostorScores(s006Mean, s001);
            impostorScoresUser6User2 = ManhDist.CalculateImpostorScores(s006Mean, s002);
            impostorScoresUser6User3 = ManhDist.CalculateImpostorScores(s006Mean, s003);
            impostorScoresUser6User4 = ManhDist.CalculateImpostorScores(s006Mean, s004);
            impostorScoresUser6User5 = ManhDist.CalculateImpostorScores(s006Mean, s005);
            impostorScoresUser6User7 = ManhDist.CalculateImpostorScores(s006Mean, s007);
            impostorScoresUser6User8 = ManhDist.CalculateImpostorScores(s006Mean, s008);
            impostorScoresUser6User9 = ManhDist.CalculateImpostorScores(s006Mean, s009);
            impostorScoresUser6User10 = ManhDist.CalculateImpostorScores(s006Mean, s010);

            impostorScoresUser6User11 = ManhDist.CalculateImpostorScores(s006Mean, s011);
            impostorScoresUser6User12 = ManhDist.CalculateImpostorScores(s006Mean, s012);
            impostorScoresUser6User13 = ManhDist.CalculateImpostorScores(s006Mean, s013);
            impostorScoresUser6User14 = ManhDist.CalculateImpostorScores(s006Mean, s014);
            impostorScoresUser6User15 = ManhDist.CalculateImpostorScores(s006Mean, s015);
            impostorScoresUser6User16 = ManhDist.CalculateImpostorScores(s006Mean, s016);
            impostorScoresUser6User17 = ManhDist.CalculateImpostorScores(s006Mean, s017);
            impostorScoresUser6User18 = ManhDist.CalculateImpostorScores(s006Mean, s018);
            impostorScoresUser6User19 = ManhDist.CalculateImpostorScores(s006Mean, s019);
            impostorScoresUser6User20 = ManhDist.CalculateImpostorScores(s006Mean, s020);

            impostorScoresUser6User21 = ManhDist.CalculateImpostorScores(s006Mean, s021);
            impostorScoresUser6User22 = ManhDist.CalculateImpostorScores(s006Mean, s022);
            impostorScoresUser6User23 = ManhDist.CalculateImpostorScores(s006Mean, s023);
            impostorScoresUser6User24 = ManhDist.CalculateImpostorScores(s006Mean, s024);
            impostorScoresUser6User25 = ManhDist.CalculateImpostorScores(s006Mean, s025);
            impostorScoresUser6User26 = ManhDist.CalculateImpostorScores(s006Mean, s026);
            impostorScoresUser6User27 = ManhDist.CalculateImpostorScores(s006Mean, s027);
            impostorScoresUser6User28 = ManhDist.CalculateImpostorScores(s006Mean, s028);
            impostorScoresUser6User29 = ManhDist.CalculateImpostorScores(s006Mean, s029);
            impostorScoresUser6User30 = ManhDist.CalculateImpostorScores(s006Mean, s030);

            impostorScoresUser6User31 = ManhDist.CalculateImpostorScores(s006Mean, s031);
            impostorScoresUser6User32 = ManhDist.CalculateImpostorScores(s006Mean, s032);
            impostorScoresUser6User33 = ManhDist.CalculateImpostorScores(s006Mean, s033);
            impostorScoresUser6User34 = ManhDist.CalculateImpostorScores(s006Mean, s034);
            impostorScoresUser6User35 = ManhDist.CalculateImpostorScores(s006Mean, s035);
            impostorScoresUser6User36 = ManhDist.CalculateImpostorScores(s006Mean, s036);
            impostorScoresUser6User37 = ManhDist.CalculateImpostorScores(s006Mean, s037);
            impostorScoresUser6User38 = ManhDist.CalculateImpostorScores(s006Mean, s038);
            impostorScoresUser6User39 = ManhDist.CalculateImpostorScores(s006Mean, s039);
            impostorScoresUser6User40 = ManhDist.CalculateImpostorScores(s006Mean, s040);

            impostorScoresUser6User41 = ManhDist.CalculateImpostorScores(s005Mean, s041);
            impostorScoresUser6User42 = ManhDist.CalculateImpostorScores(s005Mean, s042);
            impostorScoresUser6User43 = ManhDist.CalculateImpostorScores(s005Mean, s043);
            impostorScoresUser6User44 = ManhDist.CalculateImpostorScores(s005Mean, s044);
            impostorScoresUser6User45 = ManhDist.CalculateImpostorScores(s005Mean, s045);
            impostorScoresUser6User46 = ManhDist.CalculateImpostorScores(s005Mean, s046);
            impostorScoresUser6User47 = ManhDist.CalculateImpostorScores(s005Mean, s047);
            impostorScoresUser6User48 = ManhDist.CalculateImpostorScores(s005Mean, s048);
            impostorScoresUser6User49 = ManhDist.CalculateImpostorScores(s005Mean, s049);
            impostorScoresUser6User50 = ManhDist.CalculateImpostorScores(s005Mean, s050); 
            #endregion

            #region User 7 Impostor Scores
            impostorScoresUser7User1 = ManhDist.CalculateImpostorScores(s007Mean, s001);
            impostorScoresUser7User2 = ManhDist.CalculateImpostorScores(s007Mean, s002);
            impostorScoresUser7User3 = ManhDist.CalculateImpostorScores(s007Mean, s003);
            impostorScoresUser7User4 = ManhDist.CalculateImpostorScores(s007Mean, s004);
            impostorScoresUser7User5 = ManhDist.CalculateImpostorScores(s007Mean, s005);
            impostorScoresUser7User6 = ManhDist.CalculateImpostorScores(s007Mean, s006);
            impostorScoresUser7User8 = ManhDist.CalculateImpostorScores(s007Mean, s008);
            impostorScoresUser7User9 = ManhDist.CalculateImpostorScores(s007Mean, s009);
            impostorScoresUser7User10 = ManhDist.CalculateImpostorScores(s007Mean, s010);

            impostorScoresUser7User11 = ManhDist.CalculateImpostorScores(s007Mean, s011);
            impostorScoresUser7User12 = ManhDist.CalculateImpostorScores(s007Mean, s012);
            impostorScoresUser7User13 = ManhDist.CalculateImpostorScores(s007Mean, s013);
            impostorScoresUser7User14 = ManhDist.CalculateImpostorScores(s007Mean, s014);
            impostorScoresUser7User15 = ManhDist.CalculateImpostorScores(s007Mean, s015);
            impostorScoresUser7User16 = ManhDist.CalculateImpostorScores(s007Mean, s016);
            impostorScoresUser7User17 = ManhDist.CalculateImpostorScores(s007Mean, s017);
            impostorScoresUser7User18 = ManhDist.CalculateImpostorScores(s007Mean, s018);
            impostorScoresUser7User19 = ManhDist.CalculateImpostorScores(s007Mean, s019);
            impostorScoresUser7User20 = ManhDist.CalculateImpostorScores(s007Mean, s020);

            impostorScoresUser7User21 = ManhDist.CalculateImpostorScores(s007Mean, s021);
            impostorScoresUser7User22 = ManhDist.CalculateImpostorScores(s007Mean, s022);
            impostorScoresUser7User23 = ManhDist.CalculateImpostorScores(s007Mean, s023);
            impostorScoresUser7User24 = ManhDist.CalculateImpostorScores(s007Mean, s024);
            impostorScoresUser7User25 = ManhDist.CalculateImpostorScores(s007Mean, s025);
            impostorScoresUser7User26 = ManhDist.CalculateImpostorScores(s007Mean, s026);
            impostorScoresUser7User27 = ManhDist.CalculateImpostorScores(s007Mean, s027);
            impostorScoresUser7User28 = ManhDist.CalculateImpostorScores(s007Mean, s028);
            impostorScoresUser7User29 = ManhDist.CalculateImpostorScores(s007Mean, s029);
            impostorScoresUser7User30 = ManhDist.CalculateImpostorScores(s007Mean, s030);

            impostorScoresUser7User31 = ManhDist.CalculateImpostorScores(s007Mean, s031);
            impostorScoresUser7User32 = ManhDist.CalculateImpostorScores(s007Mean, s032);
            impostorScoresUser7User33 = ManhDist.CalculateImpostorScores(s007Mean, s033);
            impostorScoresUser7User34 = ManhDist.CalculateImpostorScores(s007Mean, s034);
            impostorScoresUser7User35 = ManhDist.CalculateImpostorScores(s007Mean, s035);
            impostorScoresUser7User36 = ManhDist.CalculateImpostorScores(s007Mean, s036);
            impostorScoresUser7User37 = ManhDist.CalculateImpostorScores(s007Mean, s037);
            impostorScoresUser7User38 = ManhDist.CalculateImpostorScores(s007Mean, s038);
            impostorScoresUser7User39 = ManhDist.CalculateImpostorScores(s007Mean, s039);
            impostorScoresUser7User40 = ManhDist.CalculateImpostorScores(s007Mean, s040);

            impostorScoresUser7User41 = ManhDist.CalculateImpostorScores(s007Mean, s041);
            impostorScoresUser7User42 = ManhDist.CalculateImpostorScores(s007Mean, s042);
            impostorScoresUser7User43 = ManhDist.CalculateImpostorScores(s007Mean, s043);
            impostorScoresUser7User44 = ManhDist.CalculateImpostorScores(s007Mean, s044);
            impostorScoresUser7User45 = ManhDist.CalculateImpostorScores(s007Mean, s045);
            impostorScoresUser7User46 = ManhDist.CalculateImpostorScores(s007Mean, s046);
            impostorScoresUser7User47 = ManhDist.CalculateImpostorScores(s007Mean, s047);
            impostorScoresUser7User48 = ManhDist.CalculateImpostorScores(s007Mean, s048);
            impostorScoresUser7User49 = ManhDist.CalculateImpostorScores(s007Mean, s049);
            impostorScoresUser7User50 = ManhDist.CalculateImpostorScores(s007Mean, s050);

            impostorScoresUser7User51 = ManhDist.CalculateImpostorScores(s007Mean, s051);
            impostorScoresUser7User52 = ManhDist.CalculateImpostorScores(s007Mean, s052);
            impostorScoresUser7User53 = ManhDist.CalculateImpostorScores(s007Mean, s053);
            impostorScoresUser7User54 = ManhDist.CalculateImpostorScores(s007Mean, s054);
            impostorScoresUser7User55 = ManhDist.CalculateImpostorScores(s007Mean, s055);
            impostorScoresUser7User56 = ManhDist.CalculateImpostorScores(s007Mean, s056);
            impostorScoresUser7User57 = ManhDist.CalculateImpostorScores(s007Mean, s057);
            impostorScoresUser7User58 = ManhDist.CalculateImpostorScores(s007Mean, s058);
            impostorScoresUser7User59 = ManhDist.CalculateImpostorScores(s007Mean, s059);
            impostorScoresUser7User60 = ManhDist.CalculateImpostorScores(s007Mean, s060);

            impostorScoresUser7User61 = ManhDist.CalculateImpostorScores(s007Mean, s061);
            impostorScoresUser7User62 = ManhDist.CalculateImpostorScores(s007Mean, s062);
            impostorScoresUser7User63 = ManhDist.CalculateImpostorScores(s007Mean, s063);
            impostorScoresUser7User64 = ManhDist.CalculateImpostorScores(s007Mean, s064);
            impostorScoresUser7User65 = ManhDist.CalculateImpostorScores(s007Mean, s065);
            impostorScoresUser7User66 = ManhDist.CalculateImpostorScores(s007Mean, s066);
            impostorScoresUser7User67 = ManhDist.CalculateImpostorScores(s007Mean, s067);
            impostorScoresUser7User68 = ManhDist.CalculateImpostorScores(s007Mean, s068);
            impostorScoresUser7User69 = ManhDist.CalculateImpostorScores(s007Mean, s069);
            impostorScoresUser7User70 = ManhDist.CalculateImpostorScores(s007Mean, s070);

            impostorScoresUser7User71 = ManhDist.CalculateImpostorScores(s007Mean, s071);
            impostorScoresUser7User72 = ManhDist.CalculateImpostorScores(s007Mean, s072);
            impostorScoresUser7User73 = ManhDist.CalculateImpostorScores(s007Mean, s073);
            impostorScoresUser7User74 = ManhDist.CalculateImpostorScores(s007Mean, s074);
            impostorScoresUser7User75 = ManhDist.CalculateImpostorScores(s007Mean, s075);
            impostorScoresUser7User76 = ManhDist.CalculateImpostorScores(s007Mean, s076);
            impostorScoresUser7User77 = ManhDist.CalculateImpostorScores(s007Mean, s077);
            impostorScoresUser7User78 = ManhDist.CalculateImpostorScores(s007Mean, s078);
            impostorScoresUser7User79 = ManhDist.CalculateImpostorScores(s007Mean, s079);
            impostorScoresUser7User80 = ManhDist.CalculateImpostorScores(s007Mean, s080);

            impostorScoresUser7User81 = ManhDist.CalculateImpostorScores(s007Mean, s081);
            impostorScoresUser7User82 = ManhDist.CalculateImpostorScores(s007Mean, s082);
            impostorScoresUser7User83 = ManhDist.CalculateImpostorScores(s007Mean, s083);
            impostorScoresUser7User84 = ManhDist.CalculateImpostorScores(s007Mean, s084);
            impostorScoresUser7User85 = ManhDist.CalculateImpostorScores(s007Mean, s085);
            impostorScoresUser7User86 = ManhDist.CalculateImpostorScores(s007Mean, s086);
            impostorScoresUser7User87 = ManhDist.CalculateImpostorScores(s007Mean, s087);
            impostorScoresUser7User88 = ManhDist.CalculateImpostorScores(s007Mean, s088);
            impostorScoresUser7User89 = ManhDist.CalculateImpostorScores(s007Mean, s089);
            impostorScoresUser7User90 = ManhDist.CalculateImpostorScores(s007Mean, s090);

            impostorScoresUser7User91 = ManhDist.CalculateImpostorScores(s007Mean, s091);
            impostorScoresUser7User92 = ManhDist.CalculateImpostorScores(s007Mean, s092);
            impostorScoresUser7User93 = ManhDist.CalculateImpostorScores(s007Mean, s093);
            impostorScoresUser7User94 = ManhDist.CalculateImpostorScores(s007Mean, s094);
            impostorScoresUser7User95 = ManhDist.CalculateImpostorScores(s007Mean, s095);
            impostorScoresUser7User96 = ManhDist.CalculateImpostorScores(s007Mean, s096);
            impostorScoresUser7User97 = ManhDist.CalculateImpostorScores(s007Mean, s097);
            impostorScoresUser7User98 = ManhDist.CalculateImpostorScores(s007Mean, s098);
            impostorScoresUser7User99 = ManhDist.CalculateImpostorScores(s007Mean, s099);
            impostorScoresUser7User100 = ManhDist.CalculateImpostorScores(s007Mean, s100); 
            #endregion

            #region User 8 Impostor Scores
            impostorScoresUser8User1 = ManhDist.CalculateImpostorScores(s008Mean, s001);
            impostorScoresUser8User2 = ManhDist.CalculateImpostorScores(s008Mean, s002);
            impostorScoresUser8User3 = ManhDist.CalculateImpostorScores(s008Mean, s003);
            impostorScoresUser8User4 = ManhDist.CalculateImpostorScores(s008Mean, s004);
            impostorScoresUser8User5 = ManhDist.CalculateImpostorScores(s008Mean, s005);
            impostorScoresUser8User6 = ManhDist.CalculateImpostorScores(s008Mean, s006);
            impostorScoresUser8User7 = ManhDist.CalculateImpostorScores(s008Mean, s007);
            impostorScoresUser8User9 = ManhDist.CalculateImpostorScores(s008Mean, s009);
            impostorScoresUser8User10 = ManhDist.CalculateImpostorScores(s008Mean, s010);

            impostorScoresUser8User11 = ManhDist.CalculateImpostorScores(s008Mean, s011);
            impostorScoresUser8User12 = ManhDist.CalculateImpostorScores(s008Mean, s012);
            impostorScoresUser8User13 = ManhDist.CalculateImpostorScores(s008Mean, s013);
            impostorScoresUser8User14 = ManhDist.CalculateImpostorScores(s008Mean, s014);
            impostorScoresUser8User15 = ManhDist.CalculateImpostorScores(s008Mean, s015);
            impostorScoresUser8User16 = ManhDist.CalculateImpostorScores(s008Mean, s016);
            impostorScoresUser8User17 = ManhDist.CalculateImpostorScores(s008Mean, s017);
            impostorScoresUser8User18 = ManhDist.CalculateImpostorScores(s008Mean, s018);
            impostorScoresUser8User19 = ManhDist.CalculateImpostorScores(s008Mean, s019);
            impostorScoresUser8User20 = ManhDist.CalculateImpostorScores(s008Mean, s020);

            impostorScoresUser8User21 = ManhDist.CalculateImpostorScores(s008Mean, s021);
            impostorScoresUser8User22 = ManhDist.CalculateImpostorScores(s008Mean, s022);
            impostorScoresUser8User23 = ManhDist.CalculateImpostorScores(s008Mean, s023);
            impostorScoresUser8User24 = ManhDist.CalculateImpostorScores(s008Mean, s024);
            impostorScoresUser8User25 = ManhDist.CalculateImpostorScores(s008Mean, s025);
            impostorScoresUser8User26 = ManhDist.CalculateImpostorScores(s008Mean, s026);
            impostorScoresUser8User27 = ManhDist.CalculateImpostorScores(s008Mean, s027);
            impostorScoresUser8User28 = ManhDist.CalculateImpostorScores(s008Mean, s028);
            impostorScoresUser8User29 = ManhDist.CalculateImpostorScores(s008Mean, s029);
            impostorScoresUser8User30 = ManhDist.CalculateImpostorScores(s008Mean, s030);

            impostorScoresUser8User31 = ManhDist.CalculateImpostorScores(s008Mean, s031);
            impostorScoresUser8User32 = ManhDist.CalculateImpostorScores(s008Mean, s032);
            impostorScoresUser8User33 = ManhDist.CalculateImpostorScores(s008Mean, s033);
            impostorScoresUser8User34 = ManhDist.CalculateImpostorScores(s008Mean, s034);
            impostorScoresUser8User35 = ManhDist.CalculateImpostorScores(s008Mean, s035);
            impostorScoresUser8User36 = ManhDist.CalculateImpostorScores(s008Mean, s036);
            impostorScoresUser8User37 = ManhDist.CalculateImpostorScores(s008Mean, s037);
            impostorScoresUser8User38 = ManhDist.CalculateImpostorScores(s008Mean, s038);
            impostorScoresUser8User39 = ManhDist.CalculateImpostorScores(s008Mean, s039);
            impostorScoresUser8User40 = ManhDist.CalculateImpostorScores(s008Mean, s040);

            impostorScoresUser8User41 = ManhDist.CalculateImpostorScores(s008Mean, s041);
            impostorScoresUser8User42 = ManhDist.CalculateImpostorScores(s008Mean, s042);
            impostorScoresUser8User43 = ManhDist.CalculateImpostorScores(s008Mean, s043);
            impostorScoresUser8User44 = ManhDist.CalculateImpostorScores(s008Mean, s044);
            impostorScoresUser8User45 = ManhDist.CalculateImpostorScores(s008Mean, s045);
            impostorScoresUser8User46 = ManhDist.CalculateImpostorScores(s008Mean, s046);
            impostorScoresUser8User47 = ManhDist.CalculateImpostorScores(s008Mean, s047);
            impostorScoresUser8User48 = ManhDist.CalculateImpostorScores(s008Mean, s048);
            impostorScoresUser8User49 = ManhDist.CalculateImpostorScores(s008Mean, s049);
            impostorScoresUser8User50 = ManhDist.CalculateImpostorScores(s008Mean, s050);

            impostorScoresUser8User51 = ManhDist.CalculateImpostorScores(s008Mean, s051);
            impostorScoresUser8User52 = ManhDist.CalculateImpostorScores(s008Mean, s052);
            impostorScoresUser8User53 = ManhDist.CalculateImpostorScores(s008Mean, s053);
            impostorScoresUser8User54 = ManhDist.CalculateImpostorScores(s008Mean, s054);
            impostorScoresUser8User55 = ManhDist.CalculateImpostorScores(s008Mean, s055);
            impostorScoresUser8User56 = ManhDist.CalculateImpostorScores(s008Mean, s056);
            impostorScoresUser8User57 = ManhDist.CalculateImpostorScores(s008Mean, s057);
            impostorScoresUser8User58 = ManhDist.CalculateImpostorScores(s008Mean, s058);
            impostorScoresUser8User59 = ManhDist.CalculateImpostorScores(s008Mean, s059);
            impostorScoresUser8User60 = ManhDist.CalculateImpostorScores(s008Mean, s060);

            impostorScoresUser8User61 = ManhDist.CalculateImpostorScores(s008Mean, s061);
            impostorScoresUser8User62 = ManhDist.CalculateImpostorScores(s008Mean, s062);
            impostorScoresUser8User63 = ManhDist.CalculateImpostorScores(s008Mean, s063);
            impostorScoresUser8User64 = ManhDist.CalculateImpostorScores(s008Mean, s064);
            impostorScoresUser8User65 = ManhDist.CalculateImpostorScores(s008Mean, s065);
            impostorScoresUser8User66 = ManhDist.CalculateImpostorScores(s008Mean, s066);
            impostorScoresUser8User67 = ManhDist.CalculateImpostorScores(s008Mean, s067);
            impostorScoresUser8User68 = ManhDist.CalculateImpostorScores(s008Mean, s068);
            impostorScoresUser8User69 = ManhDist.CalculateImpostorScores(s008Mean, s069);
            impostorScoresUser8User70 = ManhDist.CalculateImpostorScores(s008Mean, s070);

            impostorScoresUser8User71 = ManhDist.CalculateImpostorScores(s008Mean, s071);
            impostorScoresUser8User72 = ManhDist.CalculateImpostorScores(s008Mean, s072);
            impostorScoresUser8User73 = ManhDist.CalculateImpostorScores(s008Mean, s073);
            impostorScoresUser8User74 = ManhDist.CalculateImpostorScores(s008Mean, s074);
            impostorScoresUser8User75 = ManhDist.CalculateImpostorScores(s008Mean, s075);
            impostorScoresUser8User76 = ManhDist.CalculateImpostorScores(s008Mean, s076);
            impostorScoresUser8User77 = ManhDist.CalculateImpostorScores(s008Mean, s077);
            impostorScoresUser8User78 = ManhDist.CalculateImpostorScores(s008Mean, s078);
            impostorScoresUser8User79 = ManhDist.CalculateImpostorScores(s008Mean, s079);
            impostorScoresUser8User80 = ManhDist.CalculateImpostorScores(s008Mean, s080);

            impostorScoresUser8User81 = ManhDist.CalculateImpostorScores(s008Mean, s081);
            impostorScoresUser8User82 = ManhDist.CalculateImpostorScores(s008Mean, s082);
            impostorScoresUser8User83 = ManhDist.CalculateImpostorScores(s008Mean, s083);
            impostorScoresUser8User84 = ManhDist.CalculateImpostorScores(s008Mean, s084);
            impostorScoresUser8User85 = ManhDist.CalculateImpostorScores(s008Mean, s085);
            impostorScoresUser8User86 = ManhDist.CalculateImpostorScores(s008Mean, s086);
            impostorScoresUser8User87 = ManhDist.CalculateImpostorScores(s008Mean, s087);
            impostorScoresUser8User88 = ManhDist.CalculateImpostorScores(s008Mean, s088);
            impostorScoresUser8User89 = ManhDist.CalculateImpostorScores(s008Mean, s089);
            impostorScoresUser8User90 = ManhDist.CalculateImpostorScores(s008Mean, s090);

            impostorScoresUser8User91 = ManhDist.CalculateImpostorScores(s008Mean, s091);
            impostorScoresUser8User92 = ManhDist.CalculateImpostorScores(s008Mean, s092);
            impostorScoresUser8User93 = ManhDist.CalculateImpostorScores(s008Mean, s093);
            impostorScoresUser8User94 = ManhDist.CalculateImpostorScores(s008Mean, s094);
            impostorScoresUser8User95 = ManhDist.CalculateImpostorScores(s008Mean, s095);
            impostorScoresUser8User96 = ManhDist.CalculateImpostorScores(s008Mean, s096);
            impostorScoresUser8User97 = ManhDist.CalculateImpostorScores(s008Mean, s097);
            impostorScoresUser8User98 = ManhDist.CalculateImpostorScores(s008Mean, s098);
            impostorScoresUser8User99 = ManhDist.CalculateImpostorScores(s008Mean, s099);
            impostorScoresUser8User100 = ManhDist.CalculateImpostorScores(s008Mean, s100);
            #endregion

            #region User 9 Impostor Scores
            impostorScoresUser9User1 = ManhDist.CalculateImpostorScores(s009Mean, s001);
            impostorScoresUser9User2 = ManhDist.CalculateImpostorScores(s009Mean, s002);
            impostorScoresUser9User3 = ManhDist.CalculateImpostorScores(s009Mean, s003);
            impostorScoresUser9User4 = ManhDist.CalculateImpostorScores(s009Mean, s004);
            impostorScoresUser9User5 = ManhDist.CalculateImpostorScores(s009Mean, s005);
            impostorScoresUser9User6 = ManhDist.CalculateImpostorScores(s009Mean, s006);
            impostorScoresUser9User7 = ManhDist.CalculateImpostorScores(s009Mean, s007);
            impostorScoresUser9User8 = ManhDist.CalculateImpostorScores(s009Mean, s008);
            impostorScoresUser9User10 = ManhDist.CalculateImpostorScores(s009Mean, s010);

            impostorScoresUser9User11 = ManhDist.CalculateImpostorScores(s009Mean, s011);
            impostorScoresUser9User12 = ManhDist.CalculateImpostorScores(s009Mean, s012);
            impostorScoresUser9User13 = ManhDist.CalculateImpostorScores(s009Mean, s013);
            impostorScoresUser9User14 = ManhDist.CalculateImpostorScores(s009Mean, s014);
            impostorScoresUser9User15 = ManhDist.CalculateImpostorScores(s009Mean, s015);
            impostorScoresUser9User16 = ManhDist.CalculateImpostorScores(s009Mean, s016);
            impostorScoresUser9User17 = ManhDist.CalculateImpostorScores(s009Mean, s017);
            impostorScoresUser9User18 = ManhDist.CalculateImpostorScores(s009Mean, s018);
            impostorScoresUser9User19 = ManhDist.CalculateImpostorScores(s009Mean, s019);
            impostorScoresUser9User20 = ManhDist.CalculateImpostorScores(s009Mean, s020);

            impostorScoresUser9User21 = ManhDist.CalculateImpostorScores(s009Mean, s021);
            impostorScoresUser9User22 = ManhDist.CalculateImpostorScores(s009Mean, s022);
            impostorScoresUser9User23 = ManhDist.CalculateImpostorScores(s009Mean, s023);
            impostorScoresUser9User24 = ManhDist.CalculateImpostorScores(s009Mean, s024);
            impostorScoresUser9User25 = ManhDist.CalculateImpostorScores(s009Mean, s025);
            impostorScoresUser9User26 = ManhDist.CalculateImpostorScores(s009Mean, s026);
            impostorScoresUser9User27 = ManhDist.CalculateImpostorScores(s009Mean, s027);
            impostorScoresUser9User28 = ManhDist.CalculateImpostorScores(s009Mean, s028);
            impostorScoresUser9User29 = ManhDist.CalculateImpostorScores(s009Mean, s029);
            impostorScoresUser9User30 = ManhDist.CalculateImpostorScores(s009Mean, s030);

            impostorScoresUser9User31 = ManhDist.CalculateImpostorScores(s009Mean, s031);
            impostorScoresUser9User32 = ManhDist.CalculateImpostorScores(s009Mean, s032);
            impostorScoresUser9User33 = ManhDist.CalculateImpostorScores(s009Mean, s033);
            impostorScoresUser9User34 = ManhDist.CalculateImpostorScores(s009Mean, s034);
            impostorScoresUser9User35 = ManhDist.CalculateImpostorScores(s009Mean, s035);
            impostorScoresUser9User36 = ManhDist.CalculateImpostorScores(s009Mean, s036);
            impostorScoresUser9User37 = ManhDist.CalculateImpostorScores(s009Mean, s037);
            impostorScoresUser9User38 = ManhDist.CalculateImpostorScores(s009Mean, s038);
            impostorScoresUser9User39 = ManhDist.CalculateImpostorScores(s009Mean, s039);
            impostorScoresUser9User40 = ManhDist.CalculateImpostorScores(s009Mean, s040);

            impostorScoresUser9User41 = ManhDist.CalculateImpostorScores(s009Mean, s041);
            impostorScoresUser9User42 = ManhDist.CalculateImpostorScores(s009Mean, s042);
            impostorScoresUser9User43 = ManhDist.CalculateImpostorScores(s009Mean, s043);
            impostorScoresUser9User44 = ManhDist.CalculateImpostorScores(s009Mean, s044);
            impostorScoresUser9User45 = ManhDist.CalculateImpostorScores(s009Mean, s045);
            impostorScoresUser9User46 = ManhDist.CalculateImpostorScores(s009Mean, s046);
            impostorScoresUser9User47 = ManhDist.CalculateImpostorScores(s009Mean, s047);
            impostorScoresUser9User48 = ManhDist.CalculateImpostorScores(s009Mean, s048);
            impostorScoresUser9User49 = ManhDist.CalculateImpostorScores(s009Mean, s049);
            impostorScoresUser9User50 = ManhDist.CalculateImpostorScores(s009Mean, s050); 
            #endregion

            #region User 10 Impostor Scores
            impostorScoresUser10User1 = ManhDist.CalculateImpostorScores(s010Mean, s001);
            impostorScoresUser10User2 = ManhDist.CalculateImpostorScores(s010Mean, s002);
            impostorScoresUser10User3 = ManhDist.CalculateImpostorScores(s010Mean, s003);
            impostorScoresUser10User4 = ManhDist.CalculateImpostorScores(s010Mean, s004);
            impostorScoresUser10User5 = ManhDist.CalculateImpostorScores(s010Mean, s005);
            impostorScoresUser10User6 = ManhDist.CalculateImpostorScores(s010Mean, s006);
            impostorScoresUser10User7 = ManhDist.CalculateImpostorScores(s010Mean, s007);
            impostorScoresUser10User8 = ManhDist.CalculateImpostorScores(s010Mean, s008);
            impostorScoresUser10User9 = ManhDist.CalculateImpostorScores(s010Mean, s009);
            impostorScoresUser10User11 = ManhDist.CalculateImpostorScores(s010Mean, s011);

            impostorScoresUser10User12 = ManhDist.CalculateImpostorScores(s010Mean, s012);
            impostorScoresUser10User13 = ManhDist.CalculateImpostorScores(s010Mean, s013);
            impostorScoresUser10User14 = ManhDist.CalculateImpostorScores(s010Mean, s014);
            impostorScoresUser10User15 = ManhDist.CalculateImpostorScores(s010Mean, s015);
            impostorScoresUser10User16 = ManhDist.CalculateImpostorScores(s010Mean, s016);
            impostorScoresUser10User17 = ManhDist.CalculateImpostorScores(s010Mean, s017);
            impostorScoresUser10User18 = ManhDist.CalculateImpostorScores(s010Mean, s018);
            impostorScoresUser10User19 = ManhDist.CalculateImpostorScores(s010Mean, s019);
            impostorScoresUser10User20 = ManhDist.CalculateImpostorScores(s010Mean, s020);
            impostorScoresUser10User21 = ManhDist.CalculateImpostorScores(s010Mean, s021);

            impostorScoresUser10User22 = ManhDist.CalculateImpostorScores(s010Mean, s022);
            impostorScoresUser10User23 = ManhDist.CalculateImpostorScores(s010Mean, s023);
            impostorScoresUser10User24 = ManhDist.CalculateImpostorScores(s010Mean, s024);
            impostorScoresUser10User25 = ManhDist.CalculateImpostorScores(s010Mean, s025);
            impostorScoresUser10User26 = ManhDist.CalculateImpostorScores(s010Mean, s026);
            impostorScoresUser10User27 = ManhDist.CalculateImpostorScores(s010Mean, s027);
            impostorScoresUser10User28 = ManhDist.CalculateImpostorScores(s010Mean, s028);
            impostorScoresUser10User29 = ManhDist.CalculateImpostorScores(s010Mean, s029);
            impostorScoresUser10User30 = ManhDist.CalculateImpostorScores(s010Mean, s030);
            impostorScoresUser10User31 = ManhDist.CalculateImpostorScores(s010Mean, s031);

            impostorScoresUser10User32 = ManhDist.CalculateImpostorScores(s010Mean, s032);
            impostorScoresUser10User33 = ManhDist.CalculateImpostorScores(s010Mean, s033);
            impostorScoresUser10User34 = ManhDist.CalculateImpostorScores(s010Mean, s034);
            impostorScoresUser10User35 = ManhDist.CalculateImpostorScores(s010Mean, s035);
            impostorScoresUser10User36 = ManhDist.CalculateImpostorScores(s010Mean, s036);
            impostorScoresUser10User37 = ManhDist.CalculateImpostorScores(s010Mean, s037);
            impostorScoresUser10User38 = ManhDist.CalculateImpostorScores(s010Mean, s038);
            impostorScoresUser10User39 = ManhDist.CalculateImpostorScores(s010Mean, s039);
            impostorScoresUser10User40 = ManhDist.CalculateImpostorScores(s010Mean, s040);

            impostorScoresUser10User41 = ManhDist.CalculateImpostorScores(s010Mean, s041);
            impostorScoresUser10User42 = ManhDist.CalculateImpostorScores(s010Mean, s042);
            impostorScoresUser10User43 = ManhDist.CalculateImpostorScores(s010Mean, s043);
            impostorScoresUser10User44 = ManhDist.CalculateImpostorScores(s010Mean, s044);
            impostorScoresUser10User45 = ManhDist.CalculateImpostorScores(s010Mean, s045);
            impostorScoresUser10User46 = ManhDist.CalculateImpostorScores(s010Mean, s046);
            impostorScoresUser10User47 = ManhDist.CalculateImpostorScores(s010Mean, s047);
            impostorScoresUser10User48 = ManhDist.CalculateImpostorScores(s010Mean, s048);
            impostorScoresUser10User49 = ManhDist.CalculateImpostorScores(s010Mean, s049);
            impostorScoresUser10User50 = ManhDist.CalculateImpostorScores(s010Mean, s050); 
            #endregion
            #endregion
        }
        #endregion
    }
}