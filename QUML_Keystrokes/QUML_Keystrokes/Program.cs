/* 
 * Author: Pranav S. Krishnamurthy
 * 
 * File Name: Program.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- -------------- 
 * 1.9.16   29/08/2015  PKR     Bulk changes - populating scores for user 19
 * 1.10     30/08/2015  PKR     Going to be making overall code changes (adding more code, etc...)
 * 1.11     01/09/2015  PKR     Bulk code changes - ScaledManhDist scores for user 2
 * 1.12     08/09/2015  PKR     More bulk code changes are being made
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

// Making use of the new 
using OperationsLib; 

///<summary>
/// Source of the Data: http://www.eecs.qmul.ac.uk/~ccloy/downloads_keystroke100.html
///</summary>

namespace QUML_Keystrokes
{
    class Program
    {
        #region Static 2D double arrays that will be initialized and used

        #region Static 2D Double arrays for all of the users
        static double[,] s001; static double[,] s002; static double[,] s003; 
        static double[,] s004; static double[,] s005; static double[,] s006; 
        static double[,] s007; static double[,] s008; static double[,] s009;

        static double[,] s010;  static double[,] s011; static double[,] s012;
        static double[,] s013; static double[,] s014;  static double[,] s015;
        static double[,] s016; static double[,] s017;  static double[,] s018;
        static double[,] s019; static double[,] s020;  static double[,] s021; 
        
        static double[,] s022; static double[,] s023; static double[,] s024; 
        static double[,] s025; static double[,] s026; static double[,] s027; 
        static double[,] s028; static double[,] s029; static double[,] s030;

        static double[,] s031; static double[,] s032; static double[,] s033;
        static double[,] s034; static double[,] s035; static double[,] s036;
        static double[,] s037; static double[,] s038; static double[,] s039;

        static double[,] s040; static double[,] s041; static double[,] s042; 
        static double[,] s043; static double[,] s044; static double[,] s045; 
        static double[,] s046; static double[,] s047; static double[,] s048; 
        
        static double[,] s049; static double[,] s050; static double[,] s051; 
        static double[,] s052; static double[,] s053; static double[,] s054; 
        static double[,] s055; static double[,] s056; static double[,] s057; 
        
        static double[,] s058; static double[,] s059; static double[,] s060;
        static double[,] s061; static double[,] s062; static double[,] s063;
        static double[,] s064; static double[,] s065; static double[,] s066; 
        
        static double[,] s067; static double[,] s068; static double[,] s069; 
        static double[,] s070; static double[,] s071; static double[,] s072; 
        static double[,] s073; static double[,] s074; static double[,] s075;

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
        static double[,] s019Gen; static double[,] s020Gen; static double[,] s021Gen; 
        static double[,] s022Gen; static double[,] s023Gen; static double[,] s024Gen;
 
        static double[,] s025Gen; static double[,] s026Gen; static double[,] s027Gen; 
        static double[,] s028Gen; static double[,] s029Gen; static double[,] s030Gen;
        static double[,] s031Gen; static double[,] s032Gen; static double[,] s033Gen;
        static double[,] s034Gen; static double[,] s035Gen; static double[,] s036Gen;

        static double[,] s037Gen; static double[,] s038Gen; static double[,] s039Gen;
        static double[,] s040Gen; static double[,] s041Gen; static double[,] s042Gen; 
        static double[,] s043Gen; static double[,] s044Gen; static double[,] s045Gen; 
        static double[,] s046Gen; static double[,] s047Gen; static double[,] s048Gen; 
        
        static double[,] s049Gen; static double[,] s050Gen; static double[,] s051Gen; 
        static double[,] s052Gen; static double[,] s053Gen; static double[,] s054Gen; 
        static double[,] s055Gen; static double[,] s056Gen; static double[,] s057Gen; 
        static double[,] s058Gen; static double[,] s059Gen; static double[,] s060Gen;

        static double[,] s061Gen; static double[,] s062Gen; static double[,] s063Gen;
        static double[,] s064Gen; static double[,] s065Gen; static double[,] s066Gen; 
        static double[,] s067Gen; static double[,] s068Gen; static double[,] s069Gen; 
        static double[,] s070Gen; static double[,] s071Gen; static double[,] s072Gen; 

        static double[,] s073Gen; static double[,] s074Gen; static double[,] s075Gen;
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

        #region The standard deviation of each user - declared as double arrays (one dimensional arrays)
        static double[] stdDevUser1;  static double[] stdDevUser2;  
        static double[] stdDevUser3;  static double[] stdDevUser4;
        static double[] stdDevUser5;  static double[] stdDevUser6;  
        static double[] stdDevUser7;  static double[] stdDevUser8;
        static double[] stdDevUser9;  static double[] stdDevUser10; 
        
        static double[] stdDevUser11; static double[] stdDevUser12;
        static double[] stdDevUser13; static double[] stdDevUser14; 
        static double[] stdDevUser15; static double[] stdDevUser16;
        static double[] stdDevUser17; static double[] stdDevUser18; 
        static double[] stdDevUser19; static double[] stdDevUser20;

        static double[] stdDevUser21; static double[] stdDevUser22;
        static double[] stdDevUser23; static double[] stdDevUser24;
        static double[] stdDevUser25; static double[] stdDevUser26;
        static double[] stdDevUser27; static double[] stdDevUser28;
        static double[] stdDevUser29; static double[] stdDevUser30;

        static double[] stdDevUser31; static double[] stdDevUser32;
        static double[] stdDevUser33; static double[] stdDevUser34;
        static double[] stdDevUser35; static double[] stdDevUser36;
        static double[] stdDevUser37; static double[] stdDevUser38;
        static double[] stdDevUser39; static double[] stdDevUser40;

        static double[] stdDevUser41; static double[] stdDevUser42;
        static double[] stdDevUser43; static double[] stdDevUser44;
        static double[] stdDevUser45; static double[] stdDevUser46;
        static double[] stdDevUser47; static double[] stdDevUser48;
        static double[] stdDevUser49; static double[] stdDevUser50;

        static double[] stdDevUser51; static double[] stdDevUser52;
        static double[] stdDevUser53; static double[] stdDevUser54;
        static double[] stdDevUser55; static double[] stdDevUser56;
        static double[] stdDevUser57; static double[] stdDevUser58;
        static double[] stdDevUser59; static double[] stdDevUser60;

        static double[] stdDevUser61; static double[] stdDevUser62;
        static double[] stdDevUser63; static double[] stdDevUser64;
        static double[] stdDevUser65; static double[] stdDevUser66;
        static double[] stdDevUser67; static double[] stdDevUser68;
        static double[] stdDevUser69; static double[] stdDevUser70;

        static double[] stdDevUser71; static double[] stdDevUser72;
        static double[] stdDevUser73; static double[] stdDevUser74;
        static double[] stdDevUser75; static double[] stdDevUser76;
        static double[] stdDevUser77; static double[] stdDevUser78;
        static double[] stdDevUser79; static double[] stdDevUser80;

        static double[] stdDevUser81; static double[] stdDevUser82;
        static double[] stdDevUser83; static double[] stdDevUser84;
        static double[] stdDevUser85; static double[] stdDevUser86;
        static double[] stdDevUser87; static double[] stdDevUser88;
        static double[] stdDevUser89; static double[] stdDevUser90;

        static double[] stdDevUser91; static double[] stdDevUser92;
        static double[] stdDevUser93; static double[] stdDevUser94;
        static double[] stdDevUser95; static double[] stdDevUser96;
        static double[] stdDevUser97; static double[] stdDevUser98;
        static double[] stdDevUser99; static double[] stdDevUser100; 
        #endregion

        #region These are the impostor scores for each user

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

        static double[,] impostorScoresUser10User51;
        static double[,] impostorScoresUser10User52;
        static double[,] impostorScoresUser10User53;
        static double[,] impostorScoresUser10User54;
        static double[,] impostorScoresUser10User55;
        static double[,] impostorScoresUser10User56;
        static double[,] impostorScoresUser10User57;
        static double[,] impostorScoresUser10User58;
        static double[,] impostorScoresUser10User59;
        static double[,] impostorScoresUser10User60;

        static double[,] impostorScoresUser10User61;
        static double[,] impostorScoresUser10User62;
        static double[,] impostorScoresUser10User63;
        static double[,] impostorScoresUser10User64;
        static double[,] impostorScoresUser10User65;
        static double[,] impostorScoresUser10User66;
        static double[,] impostorScoresUser10User67;
        static double[,] impostorScoresUser10User68;
        static double[,] impostorScoresUser10User69;
        static double[,] impostorScoresUser10User70;

        static double[,] impostorScoresUser10User71;
        static double[,] impostorScoresUser10User72;
        static double[,] impostorScoresUser10User73;
        static double[,] impostorScoresUser10User74;
        static double[,] impostorScoresUser10User75;
        static double[,] impostorScoresUser10User76;
        static double[,] impostorScoresUser10User77;
        static double[,] impostorScoresUser10User78;
        static double[,] impostorScoresUser10User79;
        static double[,] impostorScoresUser10User80;

        static double[,] impostorScoresUser10User81;
        static double[,] impostorScoresUser10User82;
        static double[,] impostorScoresUser10User83;
        static double[,] impostorScoresUser10User84;
        static double[,] impostorScoresUser10User85;
        static double[,] impostorScoresUser10User86;
        static double[,] impostorScoresUser10User87;
        static double[,] impostorScoresUser10User88;
        static double[,] impostorScoresUser10User89;
        static double[,] impostorScoresUser10User90;

        static double[,] impostorScoresUser10User91;
        static double[,] impostorScoresUser10User92;
        static double[,] impostorScoresUser10User93;
        static double[,] impostorScoresUser10User94;
        static double[,] impostorScoresUser10User95;
        static double[,] impostorScoresUser10User96;
        static double[,] impostorScoresUser10User97;
        static double[,] impostorScoresUser10User98;
        static double[,] impostorScoresUser10User99;
        static double[,] impostorScoresUser10User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 11 as the training (using the mean vector for user 11 in calculating the impostor scores)
        static double[,] impostorScoresUser11User1;
        static double[,] impostorScoresUser11User2;
        static double[,] impostorScoresUser11User3;
        static double[,] impostorScoresUser11User4;
        static double[,] impostorScoresUser11User5;
        static double[,] impostorScoresUser11User6;
        static double[,] impostorScoresUser11User7;
        static double[,] impostorScoresUser11User8;
        static double[,] impostorScoresUser11User9;
        static double[,] impostorScoresUser11User10;

        static double[,] impostorScoresUser11User12;
        static double[,] impostorScoresUser11User13;
        static double[,] impostorScoresUser11User14;
        static double[,] impostorScoresUser11User15;
        static double[,] impostorScoresUser11User16;
        static double[,] impostorScoresUser11User17;
        static double[,] impostorScoresUser11User18;
        static double[,] impostorScoresUser11User19;
        static double[,] impostorScoresUser11User20;

        static double[,] impostorScoresUser11User21;
        static double[,] impostorScoresUser11User22;
        static double[,] impostorScoresUser11User23;
        static double[,] impostorScoresUser11User24;
        static double[,] impostorScoresUser11User25;
        static double[,] impostorScoresUser11User26;
        static double[,] impostorScoresUser11User27;
        static double[,] impostorScoresUser11User28;
        static double[,] impostorScoresUser11User29;
        static double[,] impostorScoresUser11User30;

        static double[,] impostorScoresUser11User31;
        static double[,] impostorScoresUser11User32;
        static double[,] impostorScoresUser11User33;
        static double[,] impostorScoresUser11User34;
        static double[,] impostorScoresUser11User35;
        static double[,] impostorScoresUser11User36;
        static double[,] impostorScoresUser11User37;
        static double[,] impostorScoresUser11User38;
        static double[,] impostorScoresUser11User39;
        static double[,] impostorScoresUser11User40;

        static double[,] impostorScoresUser11User41;
        static double[,] impostorScoresUser11User42;
        static double[,] impostorScoresUser11User43;
        static double[,] impostorScoresUser11User44;
        static double[,] impostorScoresUser11User45;
        static double[,] impostorScoresUser11User46;
        static double[,] impostorScoresUser11User47;
        static double[,] impostorScoresUser11User48;
        static double[,] impostorScoresUser11User49;
        static double[,] impostorScoresUser11User50;

        static double[,] impostorScoresUser11User51;
        static double[,] impostorScoresUser11User52;
        static double[,] impostorScoresUser11User53;
        static double[,] impostorScoresUser11User54;
        static double[,] impostorScoresUser11User55;
        static double[,] impostorScoresUser11User56;
        static double[,] impostorScoresUser11User57;
        static double[,] impostorScoresUser11User58;
        static double[,] impostorScoresUser11User59;
        static double[,] impostorScoresUser11User60;

        static double[,] impostorScoresUser11User61;
        static double[,] impostorScoresUser11User62;
        static double[,] impostorScoresUser11User63;
        static double[,] impostorScoresUser11User64;
        static double[,] impostorScoresUser11User65;
        static double[,] impostorScoresUser11User66;
        static double[,] impostorScoresUser11User67;
        static double[,] impostorScoresUser11User68;
        static double[,] impostorScoresUser11User69;
        static double[,] impostorScoresUser11User70;

        static double[,] impostorScoresUser11User71;
        static double[,] impostorScoresUser11User72;
        static double[,] impostorScoresUser11User73;
        static double[,] impostorScoresUser11User74;
        static double[,] impostorScoresUser11User75;
        static double[,] impostorScoresUser11User76;
        static double[,] impostorScoresUser11User77;
        static double[,] impostorScoresUser11User78;
        static double[,] impostorScoresUser11User79;
        static double[,] impostorScoresUser11User80;

        static double[,] impostorScoresUser11User81;
        static double[,] impostorScoresUser11User82;
        static double[,] impostorScoresUser11User83;
        static double[,] impostorScoresUser11User84;
        static double[,] impostorScoresUser11User85;
        static double[,] impostorScoresUser11User86;
        static double[,] impostorScoresUser11User87;
        static double[,] impostorScoresUser11User88;
        static double[,] impostorScoresUser11User89;
        static double[,] impostorScoresUser11User90;

        static double[,] impostorScoresUser11User91;
        static double[,] impostorScoresUser11User92;
        static double[,] impostorScoresUser11User93;
        static double[,] impostorScoresUser11User94;
        static double[,] impostorScoresUser11User95;
        static double[,] impostorScoresUser11User96;
        static double[,] impostorScoresUser11User97;
        static double[,] impostorScoresUser11User98;
        static double[,] impostorScoresUser11User99;
        static double[,] impostorScoresUser11User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 12 as the training (using the mean vector for user 12 in calculating the impostor scores)
        static double[,] impostorScoresUser12User1;
        static double[,] impostorScoresUser12User2;
        static double[,] impostorScoresUser12User3;
        static double[,] impostorScoresUser12User4;
        static double[,] impostorScoresUser12User5;
        static double[,] impostorScoresUser12User6;
        static double[,] impostorScoresUser12User7;
        static double[,] impostorScoresUser12User8;
        static double[,] impostorScoresUser12User9;
        static double[,] impostorScoresUser12User10;

        static double[,] impostorScoresUser12User11;
        static double[,] impostorScoresUser12User13;
        static double[,] impostorScoresUser12User14;
        static double[,] impostorScoresUser12User15;
        static double[,] impostorScoresUser12User16;
        static double[,] impostorScoresUser12User17;
        static double[,] impostorScoresUser12User18;
        static double[,] impostorScoresUser12User19;
        static double[,] impostorScoresUser12User20;

        static double[,] impostorScoresUser12User21;
        static double[,] impostorScoresUser12User22;
        static double[,] impostorScoresUser12User23;
        static double[,] impostorScoresUser12User24;
        static double[,] impostorScoresUser12User25;
        static double[,] impostorScoresUser12User26;
        static double[,] impostorScoresUser12User27;
        static double[,] impostorScoresUser12User28;
        static double[,] impostorScoresUser12User29;
        static double[,] impostorScoresUser12User30;

        static double[,] impostorScoresUser12User31;
        static double[,] impostorScoresUser12User32;
        static double[,] impostorScoresUser12User33;
        static double[,] impostorScoresUser12User34;
        static double[,] impostorScoresUser12User35;
        static double[,] impostorScoresUser12User36;
        static double[,] impostorScoresUser12User37;
        static double[,] impostorScoresUser12User38;
        static double[,] impostorScoresUser12User39;
        static double[,] impostorScoresUser12User40;

        static double[,] impostorScoresUser12User41;
        static double[,] impostorScoresUser12User42;
        static double[,] impostorScoresUser12User43;
        static double[,] impostorScoresUser12User44;
        static double[,] impostorScoresUser12User45;
        static double[,] impostorScoresUser12User46;
        static double[,] impostorScoresUser12User47;
        static double[,] impostorScoresUser12User48;
        static double[,] impostorScoresUser12User49;
        static double[,] impostorScoresUser12User50;

        static double[,] impostorScoresUser12User51;
        static double[,] impostorScoresUser12User52;
        static double[,] impostorScoresUser12User53;
        static double[,] impostorScoresUser12User54;
        static double[,] impostorScoresUser12User55;
        static double[,] impostorScoresUser12User56;
        static double[,] impostorScoresUser12User57;
        static double[,] impostorScoresUser12User58;
        static double[,] impostorScoresUser12User59;
        static double[,] impostorScoresUser12User60;

        static double[,] impostorScoresUser12User61;
        static double[,] impostorScoresUser12User62;
        static double[,] impostorScoresUser12User63;
        static double[,] impostorScoresUser12User64;
        static double[,] impostorScoresUser12User65;
        static double[,] impostorScoresUser12User66;
        static double[,] impostorScoresUser12User67;
        static double[,] impostorScoresUser12User68;
        static double[,] impostorScoresUser12User69;
        static double[,] impostorScoresUser12User70;

        static double[,] impostorScoresUser12User71;
        static double[,] impostorScoresUser12User72;
        static double[,] impostorScoresUser12User73;
        static double[,] impostorScoresUser12User74;
        static double[,] impostorScoresUser12User75;
        static double[,] impostorScoresUser12User76;
        static double[,] impostorScoresUser12User77;
        static double[,] impostorScoresUser12User78;
        static double[,] impostorScoresUser12User79;
        static double[,] impostorScoresUser12User80;

        static double[,] impostorScoresUser12User81;
        static double[,] impostorScoresUser12User82;
        static double[,] impostorScoresUser12User83;
        static double[,] impostorScoresUser12User84;
        static double[,] impostorScoresUser12User85;
        static double[,] impostorScoresUser12User86;
        static double[,] impostorScoresUser12User87;
        static double[,] impostorScoresUser12User88;
        static double[,] impostorScoresUser12User89;
        static double[,] impostorScoresUser12User90;

        static double[,] impostorScoresUser12User91;
        static double[,] impostorScoresUser12User92;
        static double[,] impostorScoresUser12User93;
        static double[,] impostorScoresUser12User94;
        static double[,] impostorScoresUser12User95;
        static double[,] impostorScoresUser12User96;
        static double[,] impostorScoresUser12User97;
        static double[,] impostorScoresUser12User98;
        static double[,] impostorScoresUser12User99;
        static double[,] impostorScoresUser12User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 13 as the training (using the mean vector for user 13 in calculating the impostor scores)
        static double[,] impostorScoresUser13User1;
        static double[,] impostorScoresUser13User2;
        static double[,] impostorScoresUser13User3;
        static double[,] impostorScoresUser13User4;
        static double[,] impostorScoresUser13User5;
        static double[,] impostorScoresUser13User6;
        static double[,] impostorScoresUser13User7;
        static double[,] impostorScoresUser13User8;
        static double[,] impostorScoresUser13User9;
        static double[,] impostorScoresUser13User10;

        static double[,] impostorScoresUser13User11;
        static double[,] impostorScoresUser13User12;
        static double[,] impostorScoresUser13User14;
        static double[,] impostorScoresUser13User15;
        static double[,] impostorScoresUser13User16;
        static double[,] impostorScoresUser13User17;
        static double[,] impostorScoresUser13User18;
        static double[,] impostorScoresUser13User19;
        static double[,] impostorScoresUser13User20;

        static double[,] impostorScoresUser13User21;
        static double[,] impostorScoresUser13User22;
        static double[,] impostorScoresUser13User23;
        static double[,] impostorScoresUser13User24;
        static double[,] impostorScoresUser13User25;
        static double[,] impostorScoresUser13User26;
        static double[,] impostorScoresUser13User27;
        static double[,] impostorScoresUser13User28;
        static double[,] impostorScoresUser13User29;
        static double[,] impostorScoresUser13User30;

        static double[,] impostorScoresUser13User31;
        static double[,] impostorScoresUser13User32;
        static double[,] impostorScoresUser13User33;
        static double[,] impostorScoresUser13User34;
        static double[,] impostorScoresUser13User35;
        static double[,] impostorScoresUser13User36;
        static double[,] impostorScoresUser13User37;
        static double[,] impostorScoresUser13User38;
        static double[,] impostorScoresUser13User39;
        static double[,] impostorScoresUser13User40;

        static double[,] impostorScoresUser13User41;
        static double[,] impostorScoresUser13User42;
        static double[,] impostorScoresUser13User43;
        static double[,] impostorScoresUser13User44;
        static double[,] impostorScoresUser13User45;
        static double[,] impostorScoresUser13User46;
        static double[,] impostorScoresUser13User47;
        static double[,] impostorScoresUser13User48;
        static double[,] impostorScoresUser13User49;
        static double[,] impostorScoresUser13User50;

        static double[,] impostorScoresUser13User51;
        static double[,] impostorScoresUser13User52;
        static double[,] impostorScoresUser13User53;
        static double[,] impostorScoresUser13User54;
        static double[,] impostorScoresUser13User55;
        static double[,] impostorScoresUser13User56;
        static double[,] impostorScoresUser13User57;
        static double[,] impostorScoresUser13User58;
        static double[,] impostorScoresUser13User59;
        static double[,] impostorScoresUser13User60;

        static double[,] impostorScoresUser13User61;
        static double[,] impostorScoresUser13User62;
        static double[,] impostorScoresUser13User63;
        static double[,] impostorScoresUser13User64;
        static double[,] impostorScoresUser13User65;
        static double[,] impostorScoresUser13User66;
        static double[,] impostorScoresUser13User67;
        static double[,] impostorScoresUser13User68;
        static double[,] impostorScoresUser13User69;
        static double[,] impostorScoresUser13User70;

        static double[,] impostorScoresUser13User71;
        static double[,] impostorScoresUser13User72;
        static double[,] impostorScoresUser13User73;
        static double[,] impostorScoresUser13User74;
        static double[,] impostorScoresUser13User75;
        static double[,] impostorScoresUser13User76;
        static double[,] impostorScoresUser13User77;
        static double[,] impostorScoresUser13User78;
        static double[,] impostorScoresUser13User79;
        static double[,] impostorScoresUser13User80;

        static double[,] impostorScoresUser13User81;
        static double[,] impostorScoresuser13User82;
        static double[,] impostorScoresUser13User83;
        static double[,] impostorScoresUser13User84;
        static double[,] impostorScoresUser13User85;
        static double[,] impostorScoresUser13User86;
        static double[,] impostorScoresUser13User87;
        static double[,] impostorScoresUser13User88;
        static double[,] impostorScoresUser13User89;
        static double[,] impostorScoresUser13User90;

        static double[,] impostorScoresUser13User91;
        static double[,] impostorScoresUser13User92;
        static double[,] impostorScoresUser13User93;
        static double[,] impostorScoresUser13User94;
        static double[,] impostorScoresUser13User95;
        static double[,] impostorScoresUser13User96;
        static double[,] impostorScoresUser13User97;
        static double[,] impostorScoresUser13User98;
        static double[,] impostorScoresUser13User99;
        static double[,] impostorScoresUser13User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 14 as the training (using the mean vector for user 14 in calculating the impostor scores)
        static double[,] impostorScoresUser14User1;
        static double[,] impostorScoresUser14User2;
        static double[,] impostorScoresUser14User3;
        static double[,] impostorScoresUser14User4;
        static double[,] impostorScoresUser14User5;
        static double[,] impostorScoresUser14User6;
        static double[,] impostorScoresUser14User7;
        static double[,] impostorScoresUser14User8;
        static double[,] impostorScoresUser14User9;
        static double[,] impostorScoresUser14User10;

        static double[,] impostorScoresUser14User11;
        static double[,] impostorScoresUser14User12;
        static double[,] impostorScoresUser14User13;
        static double[,] impostorScoresUser14User15;
        static double[,] impostorScoresUser14User16;
        static double[,] impostorScoresUser14User17;
        static double[,] impostorScoresUser14User18;
        static double[,] impostorScoresUser14User19;
        static double[,] impostorScoresUser14User20;

        static double[,] impostorScoresUser14User21;
        static double[,] impostorScoresUser14User22;
        static double[,] impostorScoresUser14User23;
        static double[,] impostorScoresUser14User24;
        static double[,] impostorScoresUser14User25;
        static double[,] impostorScoresUser14User26;
        static double[,] impostorScoresUser14User27;
        static double[,] impostorScoresUser14User28;
        static double[,] impostorScoresUser14User29;
        static double[,] impostorScoresUser14User30;

        static double[,] impostorScoresUser14User31;
        static double[,] impostorScoresUser14User32;
        static double[,] impostorScoresUser14User33;
        static double[,] impostorScoresUser14User34;
        static double[,] impostorScoresUser14User35;
        static double[,] impostorScoresUser14User36;
        static double[,] impostorScoresUser14User37;
        static double[,] impostorScoresUser14User38;
        static double[,] impostorScoresUser14User39;
        static double[,] impostorScoresUser14User40;

        static double[,] impostorScoresUser14User41;
        static double[,] impostorScoresUser14User42;
        static double[,] impostorScoresUser14User43;
        static double[,] impostorScoresUser14User44;
        static double[,] impostorScoresUser14User45;
        static double[,] impostorScoresUser14User46;
        static double[,] impostorScoresUser14User47;
        static double[,] impostorScoresUser14User48;
        static double[,] impostorScoresUser14User49;
        static double[,] impostorScoresUser14User50;

        static double[,] impostorScoresUser14User51;
        static double[,] impostorScoresUser14User52;
        static double[,] impostorScoresUser14User53;
        static double[,] impostorScoresUser14User54;
        static double[,] impostorScoresUser14User55;
        static double[,] impostorScoresUser14User56;
        static double[,] impostorScoresUser14User57;
        static double[,] impostorScoresUser14User58;
        static double[,] impostorScoresUser14User59;
        static double[,] impostorScoresUser14User60;

        static double[,] impostorScoresUser14User61;
        static double[,] impostorScoresUser14User62;
        static double[,] impostorScoresUser14User63;
        static double[,] impostorScoresUser14User64;
        static double[,] impostorScoresUser14User65;
        static double[,] impostorScoresUser14User66;
        static double[,] impostorScoresUser14User67;
        static double[,] impostorScoresUser14User68;
        static double[,] impostorScoresUser14User69;
        static double[,] impostorScoresUser14User70;

        static double[,] impostorScoresUser14User71;
        static double[,] impostorScoresUser14User72;
        static double[,] impostorScoresUser14User73;
        static double[,] impostorScoresUser14User74;
        static double[,] impostorScoresUser14User75;
        static double[,] impostorScoresUser14User76;
        static double[,] impostorScoresUser14User77;
        static double[,] impostorScoresUser14User78;
        static double[,] impostorScoresUser14User79;
        static double[,] impostorScoresUser14User80;

        static double[,] impostorScoresUser14User81;
        static double[,] impostorScoresUser14User82;
        static double[,] impostorScoresUser14User83;
        static double[,] impostorScoresUser14User84;
        static double[,] impostorScoresUser14User85;
        static double[,] impostorScoresUser14User86;
        static double[,] impostorScoresUser14User87;
        static double[,] impostorScoresUser14User88;
        static double[,] impostorScoresUser14User89;
        static double[,] impostorScoresUser14User90;

        static double[,] impostorScoresUser14User91;
        static double[,] impostorScoresUser14User92;
        static double[,] impostorScoresUser14User93;
        static double[,] impostorScoresUser14User94;
        static double[,] impostorScoresUser14User95;
        static double[,] impostorScoresUser14User96;
        static double[,] impostorScoresUser14User97;
        static double[,] impostorScoresUser14User98;
        static double[,] impostorScoresUser14User99;
        static double[,] impostorScoresUser14User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 15 as the training (using the mean vector for user 15 in calculating the impostor scores)
        static double[,] impostorScoresUser15User1;
        static double[,] impostorScoresUser15User2;
        static double[,] impostorScoresUser15User3;
        static double[,] impostorScoresUser15User4;
        static double[,] impostorScoresUser15User5;
        static double[,] impostorScoresUser15User6;
        static double[,] impostorScoresUser15User7;
        static double[,] impostorScoresUser15User8;
        static double[,] impostorScoresUser15User9;
        static double[,] impostorScoresUser15User10;

        static double[,] impostorScoresUser15User11;
        static double[,] impostorScoresUser15User12;
        static double[,] impostorScoresUser15User13;
        static double[,] impostorScoresUser15User14;
        static double[,] impostorScoresUser15User16;
        static double[,] impostorScoresUser15User17;
        static double[,] impostorScoresUser15User18;
        static double[,] impostorScoresUser15User19;
        static double[,] impostorScoresUser15User20;

        static double[,] impostorScoresUser15User21;
        static double[,] impostorScoresUser15User22;
        static double[,] impostorScoresUser15User23;
        static double[,] impostorScoresUser15User24;
        static double[,] impostorScoresUser15User25;
        static double[,] impostorScoresUser15User26;
        static double[,] impostorScoresUser15User27;
        static double[,] impostorScoresUser15User28;
        static double[,] impostorScoresUser15User29;
        static double[,] impostorScoresUser15User30;

        static double[,] impostorScoresUser15User31;
        static double[,] impostorScoresUser15User32;
        static double[,] impostorScoresUser15User33;
        static double[,] impostorScoresUser15User34;
        static double[,] impostorScoresUser15User35;
        static double[,] impostorScoresUser15User36;
        static double[,] impostorScoresUser15User37;
        static double[,] impostorScoresUser15User38;
        static double[,] impostorScoresUser15User39;
        static double[,] impostorScoresUser15User40;

        static double[,] impostorScoresUser15User41;
        static double[,] impostorScoresUser15User42;
        static double[,] impostorScoresUser15User43;
        static double[,] impostorScoresUser15User44;
        static double[,] impostorScoresUser15User45;
        static double[,] impostorScoresUser15User46;
        static double[,] impostorScoresUser15User47;
        static double[,] impostorScoresUser15User48;
        static double[,] impostorScoresUser15User49;
        static double[,] impostorScoresUser15User50;

        static double[,] impostorScoresUser15User51;
        static double[,] impostorScoresUser15User52;
        static double[,] impostorScoresUser15User53;
        static double[,] impostorScoresUser15User54;
        static double[,] impostorScoresUser15User55;
        static double[,] impostorScoresUser15User56;
        static double[,] impostorScoresUser15User57;
        static double[,] impostorScoresUser15User58;
        static double[,] impostorScoresUser15User59;
        static double[,] impostorScoresUser15User60;

        static double[,] impostorScoresUser15User61;
        static double[,] impostorScoresUser15User62;
        static double[,] impostorScoresUser15User63;
        static double[,] impostorScoresUser15User64;
        static double[,] impostorScoresUser15User65;
        static double[,] impostorScoresUser15User66;
        static double[,] impostorScoresUser15User67;
        static double[,] impostorScoresUser15User68;
        static double[,] impostorScoresUser15User69;
        static double[,] impostorScoresUser15User70;

        static double[,] impostorScoresUser15User71;
        static double[,] impostorScoresUser15User72;
        static double[,] impostorScoresUser15User73;
        static double[,] impostorScoresUser15User74;
        static double[,] impostorScoresUser15User75;
        static double[,] impostorScoresUser15User76;
        static double[,] impostorScoresUser15User77;
        static double[,] impostorScoresUser15User78;
        static double[,] impostorScoresUser15User79;
        static double[,] impostorScoresUser15User80;

        static double[,] impostorScoresUser15User81;
        static double[,] impostorScoresUser15User82;
        static double[,] impostorScoresUser15User83;
        static double[,] impostorScoresUser15User84;
        static double[,] impostorScoresUser15User85;
        static double[,] impostorScoresUser15User86;
        static double[,] impostorScoresUser15User87;
        static double[,] impostorScoresUser15User88;
        static double[,] impostorScoresUser15User89;
        static double[,] impostorScoresUser15User90;

        static double[,] impostorScoresUser15User91;
        static double[,] impostorScoresUser15User92;
        static double[,] impostorScoresUser15User93;
        static double[,] impostorScoresUser15User94;
        static double[,] impostorScoresUser15User95;
        static double[,] impostorScoresUser15User96;
        static double[,] impostorScoresUser15User97;
        static double[,] impostorScoresUser15User98;
        static double[,] impostorScoresUser15User99;
        static double[,] impostorScoresUser15User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 16 as the training (using the mean vector for user 16 in calculating the impostor scores)
        static double[,] impostorScoresUser16User1;
        static double[,] impostorScoresUser16User2;
        static double[,] impostorScoresUser16User3;
        static double[,] impostorScoresUser16User4;
        static double[,] impostorScoresUser16User5;
        static double[,] impostorScoresUser16User6;
        static double[,] impostorScoresUser16User7;
        static double[,] impostorScoresUser16User8;
        static double[,] impostorScoresUser16User9;
        static double[,] impostorScoresUser16User10;

        static double[,] impostorScoresUser16User11;
        static double[,] impostorScoresUser16User12;
        static double[,] impostorScoresUser16User13;
        static double[,] impostorScoresUser16User14;
        static double[,] impostorScoresUser16User15;
        static double[,] impostorScoresUser16User17;
        static double[,] impostorScoresUser16User18;
        static double[,] impostorScoresUser16User19;
        static double[,] impostorScoresUser16User20;

        static double[,] impostorScoresUser16User21;
        static double[,] impostorScoresUser16User22;
        static double[,] impostorScoresUser16User23;
        static double[,] impostorScoresUser16User24;
        static double[,] impostorScoresUser16User25;
        static double[,] impostorScoresUser16User26;
        static double[,] impostorScoresUser16User27;
        static double[,] impostorScoresUser16User28;
        static double[,] impostorScoresUser16User29;
        static double[,] impostorScoresUser16User30;

        static double[,] impostorScoresUser16User31;
        static double[,] impostorScoresUser16User32;
        static double[,] impostorScoresUser16User33;
        static double[,] impostorScoresUser16User34;
        static double[,] impostorScoresUser16User35;
        static double[,] impostorScoresUser16User36;
        static double[,] impostorScoresUser16User37;
        static double[,] impostorScoresUser16User38;
        static double[,] impostorScoresUser16User39;
        static double[,] impostorScoresUser16User40;

        static double[,] impostorScoresUser16User41;
        static double[,] impostorScoresUser16User42;
        static double[,] impostorScoresUser16User43;
        static double[,] impostorScoresUser16User44;
        static double[,] impostorScoresUser16User45;
        static double[,] impostorScoresUser16User46;
        static double[,] impostorScoresUser16User47;
        static double[,] impostorScoresUser16User48;
        static double[,] impostorScoresUser16User49;
        static double[,] impostorScoresUser16User50;

        static double[,] impostorScoresUser16User51;
        static double[,] impostorScoresUser16User52;
        static double[,] impostorScoresUser16User53;
        static double[,] impostorScoresUser16User54;
        static double[,] impostorScoresUser16User55;
        static double[,] impostorScoresUser16User56;
        static double[,] impostorScoresUser16User57;
        static double[,] impostorScoresUser16User58;
        static double[,] impostorScoresUser16User59;
        static double[,] impostorScoresUser16User60;

        static double[,] impostorScoresUser16User61;
        static double[,] impostorScoresUser16User62;
        static double[,] impostorScoresUser16User63;
        static double[,] impostorScoresUser16User64;
        static double[,] impostorScoresUser16User65;
        static double[,] impostorScoresUser16User66;
        static double[,] impostorScoresUser16User67;
        static double[,] impostorScoresUser16User68;
        static double[,] impostorScoresUser16User69;
        static double[,] impostorScoresUser16User70;

        static double[,] impostorScoresUser16User71;
        static double[,] impostorScoresUser16User72;
        static double[,] impostorScoresUser16User73;
        static double[,] impostorScoresUser16User74;
        static double[,] impostorScoresUser16User75;
        static double[,] impostorScoresUser16User76;
        static double[,] impostorScoresUser16User77;
        static double[,] impostorScoresUser16User78;
        static double[,] impostorScoresUser16User79;
        static double[,] impostorScoresUser16User80;

        static double[,] impostorScoresUser16User81;
        static double[,] impostorScoresUser16User82;
        static double[,] impostorScoresUser16User83;
        static double[,] impostorScoresUser16User84;
        static double[,] impostorScoresUser16User85;
        static double[,] impostorScoresUser16User86;
        static double[,] impostorScoresUser16User87;
        static double[,] impostorScoresUser16User88;
        static double[,] impostorScoresUser16User89;
        static double[,] impostorScoresUser16User90;

        static double[,] impostorScoresUser16User91;
        static double[,] impostorScoresUser16User92;
        static double[,] impostorScoresUser16User93;
        static double[,] impostorScoresUser16User94;
        static double[,] impostorScoresUser16User95;
        static double[,] impostorScoresUser16User96;
        static double[,] impostorScoresUser16User97;
        static double[,] impostorScoresUser16User98;
        static double[,] impostorScoresUser16User99;
        static double[,] impostorScoresUser16User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 17 as the training (using the mean vector for user 17 in calculating the impostor scores)
        static double[,] impostorScoresUser17User1;
        static double[,] impostorScoresUser17User2;
        static double[,] impostorScoresUser17User3;
        static double[,] impostorScoresUser17User4;
        static double[,] impostorScoresUser17User5;
        static double[,] impostorScoresUser17User6;
        static double[,] impostorScoresUser17User7;
        static double[,] impostorScoresUser17User8;
        static double[,] impostorScoresUser17User9;
        static double[,] impostorScoresUser17User10;

        static double[,] impostorScoresUser17User11;
        static double[,] impostorScoresUser17User12;
        static double[,] impostorScoresUser17User13;
        static double[,] impostorScoresUser17User14;
        static double[,] impostorScoresUser17User15;
        static double[,] impostorScoresUser17User16;
        static double[,] impostorScoresUser17User18;
        static double[,] impostorScoresUser17User19;
        static double[,] impostorScoresUser17User20;

        static double[,] impostorScoresUser17User21;
        static double[,] impostorScoresUser17User22;
        static double[,] impostorScoresUser17User23;
        static double[,] impostorScoresUser17User24;
        static double[,] impostorScoresUser17User25;
        static double[,] impostorScoresUser17User26;
        static double[,] impostorScoresUser17User27;
        static double[,] impostorScoresUser17User28;
        static double[,] impostorScoresUser17User29;
        static double[,] impostorScoresUser17User30;

        static double[,] impostorScoresUser17User31;
        static double[,] impostorScoresUser17User32;
        static double[,] impostorScoresUser17User33;
        static double[,] impostorScoresUser17User34;
        static double[,] impostorScoresUser17User35;
        static double[,] impostorScoresUser17User36;
        static double[,] impostorScoresUser17User37;
        static double[,] impostorScoresUser17User38;
        static double[,] impostorScoresUser17User39;
        static double[,] impostorScoresUser17User40;

        static double[,] impostorScoresUser17User41;
        static double[,] impostorScoresUser17User42;
        static double[,] impostorScoresUser17User43;
        static double[,] impostorScoresUser17User44;
        static double[,] impostorScoresUser17User45;
        static double[,] impostorScoresUser17User46;
        static double[,] impostorScoresUser17User47;
        static double[,] impostorScoresUser17User48;
        static double[,] impostorScoresUser17User49;
        static double[,] impostorScoresUser17User50;

        static double[,] impostorScoresUser17User51;
        static double[,] impostorScoresUser17User52;
        static double[,] impostorScoresUser17User53;
        static double[,] impostorScoresUser17User54;
        static double[,] impostorScoresUser17User55;
        static double[,] impostorScoresUser17User56;
        static double[,] impostorScoresUser17User57;
        static double[,] impostorScoresUser17User58;
        static double[,] impostorScoresUser17User59;
        static double[,] impostorScoresUser17User60;

        static double[,] impostorScoresUser17User61;
        static double[,] impostorScoresUser17User62;
        static double[,] impostorScoresUser17User63;
        static double[,] impostorScoresUser17User64;
        static double[,] impostorScoresUser17User65;
        static double[,] impostorScoresUser17User66;
        static double[,] impostorScoresUser17User67;
        static double[,] impostorScoresUser17User68;
        static double[,] impostorScoresUser17User69;
        static double[,] impostorScoresUser17User70;

        static double[,] impostorScoresUser17User71;
        static double[,] impostorScoresUser17User72;
        static double[,] impostorScoresUser17User73;
        static double[,] impostorScoresUser17User74;
        static double[,] impostorScoresUser17User75;
        static double[,] impostorScoresUser17User76;
        static double[,] impostorScoresUser17User77;
        static double[,] impostorScoresUser17User78;
        static double[,] impostorScoresUser17User79;
        static double[,] impostorScoresUser17User80;

        static double[,] impostorScoresUser17User81;
        static double[,] impostorScoresUser17User82;
        static double[,] impostorScoresUser17User83;
        static double[,] impostorScoresUser17User84;
        static double[,] impostorScoresUser17User85;
        static double[,] impostorScoresUser17User86;
        static double[,] impostorScoresUser17User87;
        static double[,] impostorScoresUser17User88;
        static double[,] impostorScoresUser17User89;
        static double[,] impostorScoresUser17User90;

        static double[,] impostorScoresUser17User91;
        static double[,] impostorScoresUser17User92;
        static double[,] impostorScoresUser17User93;
        static double[,] impostorScoresUser17User94;
        static double[,] impostorScoresUser17User95;
        static double[,] impostorScoresUser17User96;
        static double[,] impostorScoresUser17User97;
        static double[,] impostorScoresUser17User98;
        static double[,] impostorScoresUser17User99;
        static double[,] impostorScoresUser17User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 18 as the training (using the mean vector for user 18 in calculating the impostor scores)
        static double[,] impostorScoresUser18User1;
        static double[,] impostorScoresUser18User2;
        static double[,] impostorScoresUser18User3;
        static double[,] impostorScoresUser18User4;
        static double[,] impostorScoresUser18User5;
        static double[,] impostorScoresUser18User6;
        static double[,] impostorScoresUser18User7;
        static double[,] impostorScoresUser18User8;
        static double[,] impostorScoresUser18User9;
        static double[,] impostorScoresUser18User10;

        static double[,] impostorScoresUser18User11;
        static double[,] impostorScoresUser18User12;
        static double[,] impostorScoresUser18User13;
        static double[,] impostorScoresUser18User14;
        static double[,] impostorScoresUser18User15;
        static double[,] impostorScoresUser18User16;
        static double[,] impostorScoresUser18User17;
        static double[,] impostorScoresUser18User19;
        static double[,] impostorScoresUser18User20;

        static double[,] impostorScoresUser18User21;
        static double[,] impostorScoresUser18User22;
        static double[,] impostorScoresUser18User23;
        static double[,] impostorScoresUser18User24;
        static double[,] impostorScoresUser18User25;
        static double[,] impostorScoresUser18User26;
        static double[,] impostorScoresUser18User27;
        static double[,] impostorScoresUser18User28;
        static double[,] impostorScoresUser18User29;
        static double[,] impostorScoresUser18User30;

        static double[,] impostorScoresUser18User31;
        static double[,] impostorScoresUser18User32;
        static double[,] impostorScoresUser18User33;
        static double[,] impostorScoresUser18User34;
        static double[,] impostorScoresUser18User35;
        static double[,] impostorScoresUser18User36;
        static double[,] impostorScoresUser18User37;
        static double[,] impostorScoresUser18User38;
        static double[,] impostorScoresUser18User39;
        static double[,] impostorScoresUser18User40;

        static double[,] impostorScoresUser18User41;
        static double[,] impostorScoresUser18User42;
        static double[,] impostorScoresUser18User43;
        static double[,] impostorScoresUser18User44;
        static double[,] impostorScoresUser18User45;
        static double[,] impostorScoresUser18User46;
        static double[,] impostorScoresUser18User47;
        static double[,] impostorScoresUser18User48;
        static double[,] impostorScoresUser18User49;
        static double[,] impostorScoresUser18User50;

        static double[,] impostorScoresUser18User51;
        static double[,] impostorScoresUser18User52;
        static double[,] impostorScoresUser18User53;
        static double[,] impostorScoresUser18User54;
        static double[,] impostorScoresUser18User55;
        static double[,] impostorScoresUser18User56;
        static double[,] impostorScoresUser18User57;
        static double[,] impostorScoresUser18User58;
        static double[,] impostorScoresUser18User59;
        static double[,] impostorScoresUser18User60;

        static double[,] impostorScoresUser18User61;
        static double[,] impostorScoresUser18User62;
        static double[,] impostorScoresUser18User63;
        static double[,] impostorScoresUser18User64;
        static double[,] impostorScoresUser18User65;
        static double[,] impostorScoresUser18User66;
        static double[,] impostorScoresUser18User67;
        static double[,] impostorScoresUser18User68;
        static double[,] impostorScoresUser18User69;
        static double[,] impostorScoresUser18User70;

        static double[,] impostorScoresUser18User71;
        static double[,] impostorScoresUser18User72;
        static double[,] impostorScoresUser18User73;
        static double[,] impostorScoresUser18User74;
        static double[,] impostorScoresUser18User75;
        static double[,] impostorScoresUser18User76;
        static double[,] impostorScoresUser18User77;
        static double[,] impostorScoresUser18User78;
        static double[,] impostorScoresUser18User79;
        static double[,] impostorScoresUser18User80;

        static double[,] impostorScoresUser18User81;
        static double[,] impostorScoresUser18User82;
        static double[,] impostorScoresUser18User83;
        static double[,] impostorScoresUser18User84;
        static double[,] impostorScoresUser18User85;
        static double[,] impostorScoresUser18User86;
        static double[,] impostorScoresUser18User87;
        static double[,] impostorScoresUser18User88;
        static double[,] impostorScoresUser18User89;
        static double[,] impostorScoresUser18User90;

        static double[,] impostorScoresUser18User91;
        static double[,] impostorScoresUser18User92;
        static double[,] impostorScoresUser18User93;
        static double[,] impostorScoresUser18User94;
        static double[,] impostorScoresUser18User95;
        static double[,] impostorScoresUser18User96;
        static double[,] impostorScoresUser18User97;
        static double[,] impostorScoresUser18User98;
        static double[,] impostorScoresUser18User99;
        static double[,] impostorScoresUser18User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 19 as the training (using the mean vector for user 19 in calculating the impostor scores)
        static double[,] impostorScoresUser19User1;
        static double[,] impostorScoresUser19User2;
        static double[,] impostorScoresUser19User3;
        static double[,] impostorScoresUser19User4;
        static double[,] impostorScoresUser19User5;
        static double[,] impostorScoresUser19User6;
        static double[,] impostorScoresUser19User7;
        static double[,] impostorScoresUser19User8;
        static double[,] impostorScoresUser19User9;
        static double[,] impostorScoresUser19User10;

        static double[,] impostorScoresUser19User11;
        static double[,] impostorScoresUser19User12;
        static double[,] impostorScoresUser19User13;
        static double[,] impostorScoresUser19User14;
        static double[,] impostorScoresUser19User15;
        static double[,] impostorScoresUser19User16;
        static double[,] impostorScoresUser19User17;
        static double[,] impostorScoresUser19User18;
        static double[,] impostorScoresUser19User20;

        static double[,] impostorScoresUser19User21;
        static double[,] impostorScoresUser19User22;
        static double[,] impostorScoresUser19User23;
        static double[,] impostorScoresUser19User24;
        static double[,] impostorScoresUser19User25;
        static double[,] impostorScoresUser19User26;
        static double[,] impostorScoresUser19User27;
        static double[,] impostorScoresUser19User28;
        static double[,] impostorScoresUser19User29;
        static double[,] impostorScoresUser19User30;

        static double[,] impostorScoresUser19User31;
        static double[,] impostorScoresUser19User32;
        static double[,] impostorScoresUser19User33;
        static double[,] impostorScoresUser19User34;
        static double[,] impostorScoresUser19User35;
        static double[,] impostorScoresUser19User36;
        static double[,] impostorScoresUser19User37;
        static double[,] impostorScoresUser19User38;
        static double[,] impostorScoresUser19User39;
        static double[,] impostorScoresUser19User40;

        static double[,] impostorScoresUser19User41;
        static double[,] impostorScoresUser19User42;
        static double[,] impostorScoresUser19User43;
        static double[,] impostorScoresUser19User44;
        static double[,] impostorScoresUser19User45;
        static double[,] impostorScoresUser19User46;
        static double[,] impostorScoresUser19User47;
        static double[,] impostorScoresUser19User48;
        static double[,] impostorScoresUser19User49;
        static double[,] impostorScoresUser19User50;

        static double[,] impostorScoresUser19User51;
        static double[,] impostorScoresUser19User52;
        static double[,] impostorScoresUser19User53;
        static double[,] impostorScoresUser19User54;
        static double[,] impostorScoresUser19User55;
        static double[,] impostorScoresUser19User56;
        static double[,] impostorScoresUser19User57;
        static double[,] impostorScoresUser19User58;
        static double[,] impostorScoresUser19User59;
        static double[,] impostorScoresUser19User60;

        static double[,] impostorScoresUser19User61;
        static double[,] impostorScoresUser19User62;
        static double[,] impostorScoresUser19User63;
        static double[,] impostorScoresUser19User64;
        static double[,] impostorScoresUser19User65;
        static double[,] impostorScoresUser19User66;
        static double[,] impostorScoresUser19User67;
        static double[,] impostorScoresUser19User68;
        static double[,] impostorScoresUser19User69;
        static double[,] impostorScoresUser19User70;

        static double[,] impostorScoresUser19User71;
        static double[,] impostorScoresUser19User72;
        static double[,] impostorScoresUser19User73;
        static double[,] impostorScoresUser19User74;
        static double[,] impostorScoresUser19User75;
        static double[,] impostorScoresUser19User76;
        static double[,] impostorScoresUser19User77;
        static double[,] impostorScoresUser19User78;
        static double[,] impostorScoresUser19User79;
        static double[,] impostorScoresUser19User80;

        static double[,] impostorScoresUser19User81;
        static double[,] impostorScoresUser19User82;
        static double[,] impostorScoresUser19User83;
        static double[,] impostorScoresUser19User84;
        static double[,] impostorScoresUser19User85;
        static double[,] impostorScoresUser19User86;
        static double[,] impostorScoresUser19User87;
        static double[,] impostorScoresUser19User88;
        static double[,] impostorScoresUser19User89;
        static double[,] impostorScoresUser19User90;

        static double[,] impostorScoresUser19User91;
        static double[,] impostorScoresUser19User92;
        static double[,] impostorScoresUser19User93;
        static double[,] impostorScoresUser19User94;
        static double[,] impostorScoresUser19User95;
        static double[,] impostorScoresUser19User96;
        static double[,] impostorScoresUser19User97;
        static double[,] impostorScoresUser19User98;
        static double[,] impostorScoresUser19User99;
        static double[,] impostorScoresUser19User100;
        #endregion

        #region Having static 2D double arrays for the impostor scores with user 20 as the training (using the mean vector for user 20 in calculating the impostor scores)
        static double[,] impostorScoresUser20User1; static double[,] impostorScoresUser20User2; static double[,] impostorScoresUser20User3;
        static double[,] impostorScoresUser20User4; static double[,] impostorScoresUser20User5; static double[,] impostorScoresUser20User6;
        static double[,] impostorScoresUser20User7; static double[,] impostorScoresUser20User8; static double[,] impostorScoresUser20User9;

        static double[,] impostorScoresUser20User10; static double[,] impostorScoresUser20User11; static double[,] impostorScoresUser20User12;
        static double[,] impostorScoresUser20User13; static double[,] impostorScoresUser20User14; static double[,] impostorScoresUser20User15;
        static double[,] impostorScoresUser20User16; static double[,] impostorScoresUser20User17; static double[,] impostorScoresUser20User18;

        static double[,] impostorScoresUser20User19; static double[,] impostorScoresUser20User21; static double[,] impostorScoresUser20User22;
        static double[,] impostorScoresUser20User23; static double[,] impostorScoresUser20User24; static double[,] impostorScoresUser20User25;
        static double[,] impostorScoresUser20User26; static double[,] impostorScoresUser20User27; static double[,] impostorScoresUser20User28;

        static double[,] impostorScoresUser20User29; static double[,] impostorScoresUser20User30; static double[,] impostorScoresUser20User31;
        static double[,] impostorScoresUser20User32; static double[,] impostorScoresUser20User33; static double[,] impostorScoresUser20User34;
        static double[,] impostorScoresUser20User35; static double[,] impostorScoresUser20User36; static double[,] impostorScoresUser20User37;

        static double[,] impostorScoresUser20User38; static double[,] impostorScoresUser20User39; static double[,] impostorScoresUser20User40;
        static double[,] impostorScoresUser20User41; static double[,] impostorScoresUser20User42; static double[,] impostorScoresUser20User43;
        static double[,] impostorScoresUser20User44; static double[,] impostorScoresUser20User45; static double[,] impostorScoresUser20User46;

        static double[,] impostorScoresUser20User47; static double[,] impostorScoresUser20User48; static double[,] impostorScoresUser20User49;
        static double[,] impostorScoresUser20User50; static double[,] impostorScoresUser20User51; static double[,] impostorScoresUser20User52;
        static double[,] impostorScoresUser20User53; static double[,] impostorScoresUser20User54; static double[,] impostorScoresUser20User55;

        static double[,] impostorScoresUser20User56; static double[,] impostorScoresUser20User57; static double[,] impostorScoresUser20User58;
        static double[,] impostorScoresUser20User59; static double[,] impostorScoresUser20User60; static double[,] impostorScoresUser20User61;
        static double[,] impostorScoresUser20User62; static double[,] impostorScoresUser20User63; static double[,] impostorScoresUser20User64;

        static double[,] impostorScoresUser20User65; static double[,] impostorScoresUser20User66; static double[,] impostorScoresUser20User67;
        static double[,] impostorScoresUser20User68; static double[,] impostorScoresUser20User69; static double[,] impostorScoresUser20User70;
        static double[,] impostorScoresUser20User71; static double[,] impostorScoresUser20User72; static double[,] impostorScoresUser20User73;

        static double[,] impostorScoresUser20User74; static double[,] impostorScoresUser20User75; static double[,] impostorScoresUser20User76;
        static double[,] impostorScoresUser20User77; static double[,] impostorScoresUser20User78; static double[,] impostorScoresUser20User79;
        static double[,] impostorScoresUser20User80; static double[,] impostorScoresUser20User81; static double[,] impostorScoresUser20User82;

        static double[,] impostorScoresUser20User83; static double[,] impostorScoresUser20User84; static double[,] impostorScoresUser20User85;
        static double[,] impostorScoresUser20User86; static double[,] impostorScoresUser20User87; static double[,] impostorScoresUser20User88;
        static double[,] impostorScoresUser20User89; static double[,] impostorScoresUser20User90; static double[,] impostorScoresUser20User91;

        static double[,] impostorScoresUser20User92; static double[,] impostorScoresUser20User93; static double[,] impostorScoresUser20User94;
        static double[,] impostorScoresUser20User95; static double[,] impostorScoresUser20User96; static double[,] impostorScoresUser20User97;
        static double[,] impostorScoresUser20User98; static double[,] impostorScoresUser20User99; static double[,] impostorScoresUser20User100;
        #endregion

        #endregion

        #endregion

        static void Main(string[] args)
        {
            // The dataFiltering class will be referred to 
            DataFiltering dataFiltr = new DataFiltering();

            // Greeting of the Console
            Console.WriteLine("Welcome to the QUML Analyzer!" + Environment.NewLine);

            #region Data Extraction - This will be done before jumping into the use of any verifier
            s001 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user1.csv");
            s002 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user2.csv");
            s003 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user3.csv");
            s004 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user4.csv");
            s005 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user5.csv");
            s006 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user6.csv"); 
            s007 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user7.csv");
            s008 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user8.csv");
            s009 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user9.csv");
            s010 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user10.csv");
            
            s011 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user11.csv");
            s012 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user12.csv"); 
            s013 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user13.csv");
            s014 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user14.csv");
            s015 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user15.csv");
            s016 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user16.csv");
            s017 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user17.csv");
            s018 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user18.csv");
            s019 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user19.csv");
            s020 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user20.csv"); 

            s021 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user21.csv");
            s022 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user22.csv");
            s023 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user23.csv");
            s024 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user24.csv");
            s025 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user25.csv");
            s026 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user26.csv");
            s027 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user27.csv");
            s028 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user28.csv");
            s029 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user29.csv");
            s030 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user30.csv");

            s031 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user31.csv");
            s032 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user32.csv");
            s033 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user33.csv");
            s034 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user34.csv");
            s035 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user35.csv");
            s036 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user36.csv");
            s037 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user37.csv");
            s038 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user38.csv");
            s039 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user39.csv");
            s040 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user40.csv");

            s041 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user41.csv");
            s042 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user42.csv");
            s043 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user43.csv");
            s044 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user44.csv");
            s045 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user45.csv");
            s046 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user46.csv");
            s047 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user47.csv");
            s048 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user48.csv");
            s049 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user49.csv");
            s050 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user50.csv"); 

            s051 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user51.csv");
            s052 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user52.csv");
            s053 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user53.csv");
            s054 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user54.csv");
            s055 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user55.csv");
            s056 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user56.csv");
            s057 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user57.csv");
            s058 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user58.csv");
            s059 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user59.csv");
            s060 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user60.csv"); 

            s061 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user61.csv");
            s062 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user62.csv");
            s063 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user63.csv");
            s064 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user64.csv");
            s065 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user65.csv");
            s066 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user66.csv");
            s067 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user67.csv");
            s068 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user68.csv");
            s069 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user69.csv");
            s070 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user70.csv");

            s071 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user71.csv");
            s072 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user72.csv");
            s073 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user73.csv");
            s074 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user74.csv");
            s075 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user75.csv");
            s076 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user76.csv");
            s077 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user77.csv");
            s078 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user78.csv");
            s079 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user79.csv");
            s080 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user80.csv");

            s081 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user81.csv");
            s082 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user82.csv");
            s083 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user83.csv");
            s084 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user84.csv");
            s085 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user85.csv");
            s086 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user86.csv");
            s087 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user87.csv");
            s088 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user88.csv");
            s089 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user89.csv");
            s090 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user90.csv");

            s091 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user91.csv");
            s092 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user92.csv");
            s093 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user93.csv");
            s094 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user94.csv");
            s095 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user95.csv");
            s096 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user96.csv");
            s097 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user97.csv");
            s098 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user98.csv");
            s099 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user99.csv");
            s100 = dataFiltr.ParseData(@"C:\Users\Pranav\Documents\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user100.csv"); 
            #endregion

            Console.WriteLine("Now choose your verifier: " + Environment.NewLine + "0 for Manhattan" + Environment.NewLine + "1 for Euclidean" + Environment.NewLine + "2 for Scaled Manhattan" + Environment.NewLine + "3 for Scaled Euclidean, or" + Environment.NewLine + "4 to Quit.");

            string input = Console.ReadLine();

            // The user option determines which methods are executed
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
            // Making reference to the ScaledManhattanDistance class
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

            #region Calculating the standard deviation vectors for all 100 subjects
            stdDevUser1 = ScaledManhDist.CalculateStandardDeviation(s001Mean, s001);
            stdDevUser2 = ScaledManhDist.CalculateStandardDeviation(s002Mean, s002);
            stdDevUser3 = ScaledManhDist.CalculateStandardDeviation(s003Mean, s003);
            stdDevUser4 = ScaledManhDist.CalculateStandardDeviation(s004Mean, s004);
            stdDevUser5 = ScaledManhDist.CalculateStandardDeviation(s005Mean, s005);
            stdDevUser6 = ScaledManhDist.CalculateStandardDeviation(s006Mean, s006);
            stdDevUser7 = ScaledManhDist.CalculateStandardDeviation(s007Mean, s007);
            stdDevUser8 = ScaledManhDist.CalculateStandardDeviation(s008Mean, s008);
            stdDevUser9 = ScaledManhDist.CalculateStandardDeviation(s009Mean, s009);
            stdDevUser10 = ScaledManhDist.CalculateStandardDeviation(s010Mean, s010);

            stdDevUser11 = ScaledManhDist.CalculateStandardDeviation(s011Mean, s011);
            stdDevUser12 = ScaledManhDist.CalculateStandardDeviation(s012Mean, s012);
            stdDevUser13 = ScaledManhDist.CalculateStandardDeviation(s013Mean, s013);
            stdDevUser14 = ScaledManhDist.CalculateStandardDeviation(s014Mean, s014);
            stdDevUser15 = ScaledManhDist.CalculateStandardDeviation(s015Mean, s015);
            stdDevUser16 = ScaledManhDist.CalculateStandardDeviation(s016Mean, s016);
            stdDevUser17 = ScaledManhDist.CalculateStandardDeviation(s017Mean, s017);
            stdDevUser18 = ScaledManhDist.CalculateStandardDeviation(s018Mean, s018);
            stdDevUser19 = ScaledManhDist.CalculateStandardDeviation(s019Mean, s019);
            stdDevUser20 = ScaledManhDist.CalculateStandardDeviation(s020Mean, s020);

            stdDevUser21 = ScaledManhDist.CalculateStandardDeviation(s021Mean, s021);
            stdDevUser22 = ScaledManhDist.CalculateStandardDeviation(s022Mean, s022);
            stdDevUser23 = ScaledManhDist.CalculateStandardDeviation(s023Mean, s023);
            stdDevUser24 = ScaledManhDist.CalculateStandardDeviation(s024Mean, s024);
            stdDevUser25 = ScaledManhDist.CalculateStandardDeviation(s025Mean, s025);
            stdDevUser26 = ScaledManhDist.CalculateStandardDeviation(s026Mean, s026);
            stdDevUser27 = ScaledManhDist.CalculateStandardDeviation(s027Mean, s027);
            stdDevUser28 = ScaledManhDist.CalculateStandardDeviation(s028Mean, s028);
            stdDevUser29 = ScaledManhDist.CalculateStandardDeviation(s029Mean, s029);
            stdDevUser30 = ScaledManhDist.CalculateStandardDeviation(s030Mean, s030);

            stdDevUser31 = ScaledManhDist.CalculateStandardDeviation(s031Mean, s031);
            stdDevUser32 = ScaledManhDist.CalculateStandardDeviation(s032Mean, s032);
            stdDevUser33 = ScaledManhDist.CalculateStandardDeviation(s033Mean, s033);
            stdDevUser34 = ScaledManhDist.CalculateStandardDeviation(s034Mean, s034);
            stdDevUser35 = ScaledManhDist.CalculateStandardDeviation(s035Mean, s035);
            stdDevUser36 = ScaledManhDist.CalculateStandardDeviation(s036Mean, s036);
            stdDevUser37 = ScaledManhDist.CalculateStandardDeviation(s037Mean, s037);
            stdDevUser38 = ScaledManhDist.CalculateStandardDeviation(s038Mean, s038);
            stdDevUser39 = ScaledManhDist.CalculateStandardDeviation(s039Mean, s039);
            stdDevUser40 = ScaledManhDist.CalculateStandardDeviation(s040Mean, s040);

            stdDevUser41 = ScaledManhDist.CalculateStandardDeviation(s041Mean, s041);
            stdDevUser42 = ScaledManhDist.CalculateStandardDeviation(s042Mean, s042);
            stdDevUser43 = ScaledManhDist.CalculateStandardDeviation(s043Mean, s043);
            stdDevUser44 = ScaledManhDist.CalculateStandardDeviation(s044Mean, s044);
            stdDevUser45 = ScaledManhDist.CalculateStandardDeviation(s045Mean, s045);
            stdDevUser46 = ScaledManhDist.CalculateStandardDeviation(s046Mean, s046);
            stdDevUser47 = ScaledManhDist.CalculateStandardDeviation(s047Mean, s047);
            stdDevUser48 = ScaledManhDist.CalculateStandardDeviation(s048Mean, s048);
            stdDevUser49 = ScaledManhDist.CalculateStandardDeviation(s049Mean, s049);
            stdDevUser50 = ScaledManhDist.CalculateStandardDeviation(s050Mean, s050);

            stdDevUser51 = ScaledManhDist.CalculateStandardDeviation(s051Mean, s051);
            stdDevUser52 = ScaledManhDist.CalculateStandardDeviation(s052Mean, s052);
            stdDevUser53 = ScaledManhDist.CalculateStandardDeviation(s053Mean, s053);
            stdDevUser54 = ScaledManhDist.CalculateStandardDeviation(s054Mean, s054);
            stdDevUser55 = ScaledManhDist.CalculateStandardDeviation(s055Mean, s055);
            stdDevUser56 = ScaledManhDist.CalculateStandardDeviation(s056Mean, s056);
            stdDevUser57 = ScaledManhDist.CalculateStandardDeviation(s057Mean, s057);
            stdDevUser58 = ScaledManhDist.CalculateStandardDeviation(s058Mean, s058);
            stdDevUser59 = ScaledManhDist.CalculateStandardDeviation(s059Mean, s059);
            stdDevUser60 = ScaledManhDist.CalculateStandardDeviation(s060Mean, s060);

            stdDevUser61 = ScaledManhDist.CalculateStandardDeviation(s061Mean, s061);
            stdDevUser62 = ScaledManhDist.CalculateStandardDeviation(s062Mean, s062);
            stdDevUser63 = ScaledManhDist.CalculateStandardDeviation(s063Mean, s063);
            stdDevUser64 = ScaledManhDist.CalculateStandardDeviation(s064Mean, s064);
            stdDevUser65 = ScaledManhDist.CalculateStandardDeviation(s065Mean, s065);
            stdDevUser66 = ScaledManhDist.CalculateStandardDeviation(s066Mean, s066);
            stdDevUser67 = ScaledManhDist.CalculateStandardDeviation(s067Mean, s067);
            stdDevUser68 = ScaledManhDist.CalculateStandardDeviation(s068Mean, s068);
            stdDevUser69 = ScaledManhDist.CalculateStandardDeviation(s069Mean, s069);
            stdDevUser70 = ScaledManhDist.CalculateStandardDeviation(s070Mean, s070);

            stdDevUser71 = ScaledManhDist.CalculateStandardDeviation(s071Mean, s071);
            stdDevUser72 = ScaledManhDist.CalculateStandardDeviation(s072Mean, s072);
            stdDevUser73 = ScaledManhDist.CalculateStandardDeviation(s073Mean, s073);
            stdDevUser74 = ScaledManhDist.CalculateStandardDeviation(s074Mean, s074);
            stdDevUser75 = ScaledManhDist.CalculateStandardDeviation(s075Mean, s075);
            stdDevUser76 = ScaledManhDist.CalculateStandardDeviation(s076Mean, s076);
            stdDevUser77 = ScaledManhDist.CalculateStandardDeviation(s077Mean, s077);
            stdDevUser78 = ScaledManhDist.CalculateStandardDeviation(s078Mean, s078);
            stdDevUser79 = ScaledManhDist.CalculateStandardDeviation(s079Mean, s079);
            stdDevUser80 = ScaledManhDist.CalculateStandardDeviation(s080Mean, s080);

            stdDevUser81 = ScaledManhDist.CalculateStandardDeviation(s081Mean, s081);
            stdDevUser82 = ScaledManhDist.CalculateStandardDeviation(s082Mean, s082);
            stdDevUser83 = ScaledManhDist.CalculateStandardDeviation(s083Mean, s083);
            stdDevUser84 = ScaledManhDist.CalculateStandardDeviation(s084Mean, s084);
            stdDevUser85 = ScaledManhDist.CalculateStandardDeviation(s085Mean, s085);
            stdDevUser86 = ScaledManhDist.CalculateStandardDeviation(s086Mean, s086);
            stdDevUser87 = ScaledManhDist.CalculateStandardDeviation(s087Mean, s087);
            stdDevUser88 = ScaledManhDist.CalculateStandardDeviation(s088Mean, s088);
            stdDevUser89 = ScaledManhDist.CalculateStandardDeviation(s089Mean, s089);
            stdDevUser90 = ScaledManhDist.CalculateStandardDeviation(s090Mean, s090);

            stdDevUser91 = ScaledManhDist.CalculateStandardDeviation(s091Mean, s091);
            stdDevUser92 = ScaledManhDist.CalculateStandardDeviation(s092Mean, s092);
            stdDevUser93 = ScaledManhDist.CalculateStandardDeviation(s093Mean, s093);
            stdDevUser94 = ScaledManhDist.CalculateStandardDeviation(s094Mean, s094);
            stdDevUser95 = ScaledManhDist.CalculateStandardDeviation(s095Mean, s095);
            stdDevUser96 = ScaledManhDist.CalculateStandardDeviation(s096Mean, s096);
            stdDevUser97 = ScaledManhDist.CalculateStandardDeviation(s097Mean, s097);
            stdDevUser98 = ScaledManhDist.CalculateStandardDeviation(s098Mean, s098);
            stdDevUser99 = ScaledManhDist.CalculateStandardDeviation(s099Mean, s099);
            stdDevUser100 = ScaledManhDist.CalculateStandardDeviation(s100Mean, s100);
            #endregion

            #region Populating the genuine score variables for the 100 subjects
            s001Gen = ScaledManhDist.CalculateGenuineScores(s001Mean, stdDevUser1, s001);
            s002Gen = ScaledManhDist.CalculateGenuineScores(s002Mean, stdDevUser2, s002);
            s003Gen = ScaledManhDist.CalculateGenuineScores(s003Mean, stdDevUser3, s003);
            s004Gen = ScaledManhDist.CalculateGenuineScores(s004Mean, stdDevUser4, s004);
            s005Gen = ScaledManhDist.CalculateGenuineScores(s005Mean, stdDevUser5, s005);
            s006Gen = ScaledManhDist.CalculateGenuineScores(s006Mean, stdDevUser6, s006);
            s007Gen = ScaledManhDist.CalculateGenuineScores(s007Mean, stdDevUser7, s007);
            s008Gen = ScaledManhDist.CalculateGenuineScores(s008Mean, stdDevUser8, s008);
            s009Gen = ScaledManhDist.CalculateGenuineScores(s009Mean, stdDevUser9, s009);
            s010Gen = ScaledManhDist.CalculateGenuineScores(s010Mean, stdDevUser10, s010);

            s011Gen = ScaledManhDist.CalculateGenuineScores(s011Mean, stdDevUser11, s011);
            s012Gen = ScaledManhDist.CalculateGenuineScores(s012Mean, stdDevUser12, s012);
            s013Gen = ScaledManhDist.CalculateGenuineScores(s013Mean, stdDevUser13, s013);
            s014Gen = ScaledManhDist.CalculateGenuineScores(s014Mean, stdDevUser14, s014);
            s015Gen = ScaledManhDist.CalculateGenuineScores(s015Mean, stdDevUser15, s015);
            s016Gen = ScaledManhDist.CalculateGenuineScores(s016Mean, stdDevUser16, s016);
            s017Gen = ScaledManhDist.CalculateGenuineScores(s017Mean, stdDevUser17, s017);
            s018Gen = ScaledManhDist.CalculateGenuineScores(s018Mean, stdDevUser18, s018);
            s019Gen = ScaledManhDist.CalculateGenuineScores(s019Mean, stdDevUser19, s019);
            s020Gen = ScaledManhDist.CalculateGenuineScores(s020Mean, stdDevUser20, s020);

            s012Gen = ScaledManhDist.CalculateGenuineScores(s021Mean, stdDevUser21, s021);
            s022Gen = ScaledManhDist.CalculateGenuineScores(s022Mean, stdDevUser22, s022);
            s023Gen = ScaledManhDist.CalculateGenuineScores(s023Mean, stdDevUser23, s023);
            s024Gen = ScaledManhDist.CalculateGenuineScores(s024Mean, stdDevUser24, s024);
            s025Gen = ScaledManhDist.CalculateGenuineScores(s025Mean, stdDevUser25, s025);
            s026Gen = ScaledManhDist.CalculateGenuineScores(s026Mean, stdDevUser26, s026);
            s027Gen = ScaledManhDist.CalculateGenuineScores(s027Mean, stdDevUser27, s027);
            s028Gen = ScaledManhDist.CalculateGenuineScores(s028Mean, stdDevUser28, s028);
            s029Gen = ScaledManhDist.CalculateGenuineScores(s029Mean, stdDevUser29, s029);
            s030Gen = ScaledManhDist.CalculateGenuineScores(s030Mean, stdDevUser30, s030);

            s031Gen = ScaledManhDist.CalculateGenuineScores(s031Mean, stdDevUser31, s031);
            s032Gen = ScaledManhDist.CalculateGenuineScores(s032Mean, stdDevUser32, s032);
            s033Gen = ScaledManhDist.CalculateGenuineScores(s033Mean, stdDevUser33, s033);
            s034Gen = ScaledManhDist.CalculateGenuineScores(s034Mean, stdDevUser34, s034);
            s035Gen = ScaledManhDist.CalculateGenuineScores(s035Mean, stdDevUser35, s035);
            s036Gen = ScaledManhDist.CalculateGenuineScores(s036Mean, stdDevUser36, s036);
            s037Gen = ScaledManhDist.CalculateGenuineScores(s037Mean, stdDevUser37, s037);
            s038Gen = ScaledManhDist.CalculateGenuineScores(s038Mean, stdDevUser38, s038);
            s039Gen = ScaledManhDist.CalculateGenuineScores(s039Mean, stdDevUser39, s039);
            s040Gen = ScaledManhDist.CalculateGenuineScores(s040Mean, stdDevUser40, s040);

            s041Gen = ScaledManhDist.CalculateGenuineScores(s041Mean, stdDevUser41, s041);
            s042Gen = ScaledManhDist.CalculateGenuineScores(s042Mean, stdDevUser42, s042);
            s043Gen = ScaledManhDist.CalculateGenuineScores(s043Mean, stdDevUser43, s043);
            s044Gen = ScaledManhDist.CalculateGenuineScores(s044Mean, stdDevUser44, s044);
            s045Gen = ScaledManhDist.CalculateGenuineScores(s045Mean, stdDevUser45, s045);
            s046Gen = ScaledManhDist.CalculateGenuineScores(s046Mean, stdDevUser46, s046);
            s047Gen = ScaledManhDist.CalculateGenuineScores(s047Mean, stdDevUser47, s047);
            s048Gen = ScaledManhDist.CalculateGenuineScores(s048Mean, stdDevUser48, s048);
            s049Gen = ScaledManhDist.CalculateGenuineScores(s049Mean, stdDevUser49, s049);
            s050Gen = ScaledManhDist.CalculateGenuineScores(s050Mean, stdDevUser50, s050);

            s051Gen = ScaledManhDist.CalculateGenuineScores(s051Mean, stdDevUser51, s051);
            s052Gen = ScaledManhDist.CalculateGenuineScores(s052Mean, stdDevUser52, s052);
            s053Gen = ScaledManhDist.CalculateGenuineScores(s053Mean, stdDevUser53, s053);
            s054Gen = ScaledManhDist.CalculateGenuineScores(s054Mean, stdDevUser54, s054);
            s055Gen = ScaledManhDist.CalculateGenuineScores(s055Mean, stdDevUser55, s055);
            s056Gen = ScaledManhDist.CalculateGenuineScores(s056Mean, stdDevUser56, s056);
            s057Gen = ScaledManhDist.CalculateGenuineScores(s057Mean, stdDevUser57, s057);
            s058Gen = ScaledManhDist.CalculateGenuineScores(s058Mean, stdDevUser58, s058);
            s059Gen = ScaledManhDist.CalculateGenuineScores(s059Mean, stdDevUser59, s059);
            s060Gen = ScaledManhDist.CalculateGenuineScores(s060Mean, stdDevUser60, s060);

            s061Gen = ScaledManhDist.CalculateGenuineScores(s061Mean, stdDevUser61, s061);
            s062Gen = ScaledManhDist.CalculateGenuineScores(s062Mean, stdDevUser62, s062);
            s063Gen = ScaledManhDist.CalculateGenuineScores(s063Mean, stdDevUser63, s063);
            s064Gen = ScaledManhDist.CalculateGenuineScores(s064Mean, stdDevUser64, s064);
            s065Gen = ScaledManhDist.CalculateGenuineScores(s065Mean, stdDevUser65, s065);
            s066Gen = ScaledManhDist.CalculateGenuineScores(s066Mean, stdDevUser66, s066);
            s067Gen = ScaledManhDist.CalculateGenuineScores(s067Mean, stdDevUser67, s067);
            s068Gen = ScaledManhDist.CalculateGenuineScores(s068Mean, stdDevUser68, s068);
            s069Gen = ScaledManhDist.CalculateGenuineScores(s069Mean, stdDevUser69, s069);
            s070Gen = ScaledManhDist.CalculateGenuineScores(s070Mean, stdDevUser70, s070);

            s071Gen = ScaledManhDist.CalculateGenuineScores(s071Mean, stdDevUser71, s071);
            s072Gen = ScaledManhDist.CalculateGenuineScores(s072Mean, stdDevUser72, s072);
            s073Gen = ScaledManhDist.CalculateGenuineScores(s073Mean, stdDevUser73, s073);
            s074Gen = ScaledManhDist.CalculateGenuineScores(s074Mean, stdDevUser74, s074);
            s075Gen = ScaledManhDist.CalculateGenuineScores(s075Mean, stdDevUser75, s075);
            s076Gen = ScaledManhDist.CalculateGenuineScores(s076Mean, stdDevUser76, s076);
            s077Gen = ScaledManhDist.CalculateGenuineScores(s077Mean, stdDevUser77, s077);
            s078Gen = ScaledManhDist.CalculateGenuineScores(s078Mean, stdDevUser78, s078);
            s079Gen = ScaledManhDist.CalculateGenuineScores(s079Mean, stdDevUser79, s079);
            s080Gen = ScaledManhDist.CalculateGenuineScores(s080Mean, stdDevUser80, s080);

            s081Gen = ScaledManhDist.CalculateGenuineScores(s081Mean, stdDevUser81, s081);
            s082Gen = ScaledManhDist.CalculateGenuineScores(s082Mean, stdDevUser82, s082);
            s083Gen = ScaledManhDist.CalculateGenuineScores(s083Mean, stdDevUser83, s083);
            s084Gen = ScaledManhDist.CalculateGenuineScores(s084Mean, stdDevUser84, s084);
            s085Gen = ScaledManhDist.CalculateGenuineScores(s085Mean, stdDevUser85, s085);
            s086Gen = ScaledManhDist.CalculateGenuineScores(s086Mean, stdDevUser86, s086);
            s087Gen = ScaledManhDist.CalculateGenuineScores(s087Mean, stdDevUser87, s087);
            s088Gen = ScaledManhDist.CalculateGenuineScores(s088Mean, stdDevUser88, s088);
            s089Gen = ScaledManhDist.CalculateGenuineScores(s089Mean, stdDevUser89, s089);
            s090Gen = ScaledManhDist.CalculateGenuineScores(s090Mean, stdDevUser90, s090);

            s091Gen = ScaledManhDist.CalculateGenuineScores(s091Mean, stdDevUser91, s091);
            s092Gen = ScaledManhDist.CalculateGenuineScores(s092Mean, stdDevUser92, s092);
            s093Gen = ScaledManhDist.CalculateGenuineScores(s093Mean, stdDevUser93, s093);
            s094Gen = ScaledManhDist.CalculateGenuineScores(s094Mean, stdDevUser94, s094);
            s095Gen = ScaledManhDist.CalculateGenuineScores(s095Mean, stdDevUser95, s095);
            s096Gen = ScaledManhDist.CalculateGenuineScores(s096Mean, stdDevUser96, s096);
            s097Gen = ScaledManhDist.CalculateGenuineScores(s097Mean, stdDevUser97, s097);
            s098Gen = ScaledManhDist.CalculateGenuineScores(s098Mean, stdDevUser98, s098);
            s099Gen = ScaledManhDist.CalculateGenuineScores(s099Mean, stdDevUser99, s099);
            s100Gen = ScaledManhDist.CalculateGenuineScores(s100Mean, stdDevUser100, s100);
            #endregion

            #region Populating the impostor scores for each user in the following users

            #region User 1 Impostor scores
            impostorScoresUser1User2 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s002);
            impostorScoresUser1User3 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s003);
            impostorScoresUser1User4 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s004);
            impostorScoresUser1User5 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s005);
            impostorScoresUser1User6 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s006);
            impostorScoresUser1User7 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s007);
            impostorScoresUser1User8 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s008);
            impostorScoresUser1User9 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s009);
            impostorScoresUser1User10 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s010);

            impostorScoresUser1User11 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s011);
            impostorScoresUser1User12 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s012);
            impostorScoresUser1User13 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s013);
            impostorScoresUser1User14 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s014);
            impostorScoresUser1User15 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s015);
            impostorScoresUser1User16 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s016);
            impostorScoresUser1User17 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s017);
            impostorScoresUser1User18 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s018);
            impostorScoresUser1User19 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s019);
            impostorScoresUser1User20 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s020);

            impostorScoresUser1User21 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s021);
            impostorScoresUser1User22 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s022);
            impostorScoresUser1User23 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s023);
            impostorScoresUser1User24 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s024);
            impostorScoresUser1User25 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s025);
            impostorScoresUser1User26 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s026);
            impostorScoresUser1User27 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s027);
            impostorScoresUser1User28 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s028);
            impostorScoresUser1User29 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s029);
            impostorScoresUser1User30 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s030);

            impostorScoresUser1User31 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s031);
            impostorScoresUser1User32 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s032);
            impostorScoresUser1User33 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s033);
            impostorScoresUser1User34 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s034);
            impostorScoresUser1User35 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s035);
            impostorScoresUser1User36 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s036);
            impostorScoresUser1User37 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s037);
            impostorScoresUser1User38 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s038);
            impostorScoresUser1User39 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s039);
            impostorScoresUser1User40 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s040);

            impostorScoresUser1User41 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s041);
            impostorScoresUser1User42 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s042);
            impostorScoresUser1User43 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s043);
            impostorScoresUser1User44 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s044);
            impostorScoresUser1User45 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s045);
            impostorScoresUser1User46 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s046);
            impostorScoresUser1User47 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s047);
            impostorScoresUser1User48 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s048);
            impostorScoresUser1User49 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s049);
            impostorScoresUser1User50 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s050);

            impostorScoresUser1User51 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s051);
            impostorScoresUser1User52 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s052);
            impostorScoresUser1User53 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s053);
            impostorScoresUser1User54 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s054);
            impostorScoresUser1User55 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s055);
            impostorScoresUser1User56 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s056);
            impostorScoresUser1User57 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s057);
            impostorScoresUser1User58 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s058);
            impostorScoresUser1User59 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s059);
            impostorScoresUser1User60 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s060);

            impostorScoresUser1User61 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s061);
            impostorScoresUser1User62 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s062);
            impostorScoresUser1User63 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s063);
            impostorScoresUser1User64 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s064);
            impostorScoresUser1User65 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s065);
            impostorScoresUser1User66 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s066);
            impostorScoresUser1User67 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s067);
            impostorScoresUser1User68 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s068);
            impostorScoresUser1User69 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s069);
            impostorScoresUser1User70 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s070);

            impostorScoresUser1User71 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s071);
            impostorScoresUser1User72 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s072);
            impostorScoresUser1User73 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s073);
            impostorScoresUser1User74 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s074);
            impostorScoresUser1User75 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s075);
            impostorScoresUser1User76 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s076);
            impostorScoresUser1User77 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s077);
            impostorScoresUser1User78 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s078);
            impostorScoresUser1User79 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s079);
            impostorScoresUser1User80 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s080);

            impostorScoresUser1User81 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s081);
            impostorScoresUser1User82 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s082);
            impostorScoresUser1User83 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s083);
            impostorScoresUser1User84 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s084);
            impostorScoresUser1User85 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s085);
            impostorScoresUser1User86 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s086);
            impostorScoresUser1User87 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s087);
            impostorScoresUser1User88 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s088);
            impostorScoresUser1User89 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s089);
            impostorScoresUser1User90 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s090);

            impostorScoresUser1User91 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s091);
            impostorScoresUser1User92 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s092);
            impostorScoresUser1User93 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s093);
            impostorScoresUser1User94 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s094);
            impostorScoresUser1User95 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s095);
            impostorScoresUser1User96 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s096);
            impostorScoresUser1User97 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s097);
            impostorScoresUser1User98 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s098);
            impostorScoresUser1User99 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s099);
            impostorScoresUser1User100 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s100);
            #endregion

            #region User 2 Impostor scores
            impostorScoresUser2User1 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s001);
            impostorScoresUser2User3 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s003);
            impostorScoresUser2User4 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s004);
            impostorScoresUser2User5 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s005);
            impostorScoresUser2User6 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s006);
            impostorScoresUser2User7 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s007);
            impostorScoresUser2User8 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s008);
            impostorScoresUser2User9 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s009);
            impostorScoresUser2User10 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s010);

            impostorScoresUser2User11 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s011);
            impostorScoresUser2User12 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s012);
            impostorScoresUser2User13 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s013);
            impostorScoresUser2User14 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s014);
            impostorScoresUser2User15 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s015);
            impostorScoresUser2User16 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s016);
            impostorScoresUser2User17 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s017);
            impostorScoresUser2User18 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s018);
            impostorScoresUser2User19 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s019);
            impostorScoresUser2User20 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s020);

            impostorScoresUser2User21 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s021);
            impostorScoresUser2User22 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s022);
            impostorScoresUser2User23 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s023);
            impostorScoresUser2User24 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s024);
            impostorScoresUser2User25 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s025);
            impostorScoresUser2User26 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s026);
            impostorScoresUser2User27 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s027);
            impostorScoresUser2User28 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s028);
            impostorScoresUser2User29 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s029);
            impostorScoresUser2User30 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s030);

            impostorScoresUser2User31 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s031);
            impostorScoresUser2User32 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s032);
            impostorScoresUser2User33 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s033);
            #endregion

            #region User 3 Impostor scores
            
            #endregion

            #region User 4 Impostor scores 
            
            #endregion

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

            #region User 1 Impostor scores
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

            #region User 2 Impostor scores
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

            #region User 3 Impostor scores
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

            #region User 4 Impostor scores
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

            #region User 5 Impostor scores
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

            #region User 6 Impostor scores
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

            #region User 7 Impostor scores
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

            #region User 8 Impostor scores
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

            #region User 9 Impostor scores
            impostorScoresUser9User1 = EuclidDist.CalculateImpostorScores(s009Mean, s001);
            impostorScoresUser9User2 = EuclidDist.CalculateImpostorScores(s009Mean, s002);
            impostorScoresUser9User3 = EuclidDist.CalculateImpostorScores(s009Mean, s003);
            impostorScoresUser9User4 = EuclidDist.CalculateImpostorScores(s009Mean, s004);
            impostorScoresUser9User5 = EuclidDist.CalculateImpostorScores(s009Mean, s005);
            impostorScoresUser9User6 = EuclidDist.CalculateImpostorScores(s009Mean, s006);
            impostorScoresUser9User7 = EuclidDist.CalculateImpostorScores(s009Mean, s007);
            impostorScoresUser9User8 = EuclidDist.CalculateImpostorScores(s009Mean, s008);
            impostorScoresUser9User10 = EuclidDist.CalculateImpostorScores(s009Mean, s010);

            impostorScoresUser9User11 = EuclidDist.CalculateImpostorScores(s009Mean, s011);
            impostorScoresUser9User12 = EuclidDist.CalculateImpostorScores(s009Mean, s012);
            impostorScoresUser9User13 = EuclidDist.CalculateImpostorScores(s009Mean, s013);
            impostorScoresUser9User14 = EuclidDist.CalculateImpostorScores(s009Mean, s014);
            impostorScoresUser9User15 = EuclidDist.CalculateImpostorScores(s009Mean, s015);
            impostorScoresUser9User16 = EuclidDist.CalculateImpostorScores(s009Mean, s016);
            impostorScoresUser9User17 = EuclidDist.CalculateImpostorScores(s009Mean, s017);
            impostorScoresUser9User18 = EuclidDist.CalculateImpostorScores(s009Mean, s018);
            impostorScoresUser9User19 = EuclidDist.CalculateImpostorScores(s009Mean, s019);
            impostorScoresUser9User20 = EuclidDist.CalculateImpostorScores(s009Mean, s020);

            impostorScoresUser9User21 = EuclidDist.CalculateImpostorScores(s009Mean, s021);
            impostorScoresUser9User22 = EuclidDist.CalculateImpostorScores(s009Mean, s022);
            impostorScoresUser9User23 = EuclidDist.CalculateImpostorScores(s009Mean, s023);
            impostorScoresUser9User24 = EuclidDist.CalculateImpostorScores(s009Mean, s024);
            impostorScoresUser9User25 = EuclidDist.CalculateImpostorScores(s009Mean, s025);
            impostorScoresUser9User26 = EuclidDist.CalculateImpostorScores(s009Mean, s026);
            impostorScoresUser9User27 = EuclidDist.CalculateImpostorScores(s009Mean, s027);
            impostorScoresUser9User28 = EuclidDist.CalculateImpostorScores(s009Mean, s028);
            impostorScoresUser9User29 = EuclidDist.CalculateImpostorScores(s009Mean, s029);
            impostorScoresUser9User30 = EuclidDist.CalculateImpostorScores(s009Mean, s030);

            impostorScoresUser9User31 = EuclidDist.CalculateImpostorScores(s009Mean, s031);
            impostorScoresUser9User32 = EuclidDist.CalculateImpostorScores(s009Mean, s032);
            impostorScoresUser9User33 = EuclidDist.CalculateImpostorScores(s009Mean, s033);
            impostorScoresUser9User34 = EuclidDist.CalculateImpostorScores(s009Mean, s034);
            impostorScoresUser9User35 = EuclidDist.CalculateImpostorScores(s009Mean, s035);
            impostorScoresUser9User36 = EuclidDist.CalculateImpostorScores(s009Mean, s036);
            impostorScoresUser9User37 = EuclidDist.CalculateImpostorScores(s009Mean, s037);
            impostorScoresUser9User38 = EuclidDist.CalculateImpostorScores(s009Mean, s038);
            impostorScoresUser9User39 = EuclidDist.CalculateImpostorScores(s009Mean, s039);
            impostorScoresUser9User40 = EuclidDist.CalculateImpostorScores(s009Mean, s040);

            impostorScoresUser9User41 = EuclidDist.CalculateImpostorScores(s009Mean, s041);
            impostorScoresUser9User42 = EuclidDist.CalculateImpostorScores(s009Mean, s042);
            impostorScoresUser9User43 = EuclidDist.CalculateImpostorScores(s009Mean, s043);
            impostorScoresUser9User44 = EuclidDist.CalculateImpostorScores(s009Mean, s044);
            impostorScoresUser9User45 = EuclidDist.CalculateImpostorScores(s009Mean, s045);
            impostorScoresUser9User46 = EuclidDist.CalculateImpostorScores(s009Mean, s046);
            impostorScoresUser9User47 = EuclidDist.CalculateImpostorScores(s009Mean, s047);
            impostorScoresUser9User48 = EuclidDist.CalculateImpostorScores(s009Mean, s048);
            impostorScoresUser9User49 = EuclidDist.CalculateImpostorScores(s009Mean, s049);
            impostorScoresUser9User50 = EuclidDist.CalculateImpostorScores(s009Mean, s050);

            impostorScoresUser9User51 = EuclidDist.CalculateImpostorScores(s009Mean, s051);
            impostorScoresUser9User52 = EuclidDist.CalculateImpostorScores(s009Mean, s052);
            impostorScoresUser9User53 = EuclidDist.CalculateImpostorScores(s009Mean, s053);
            impostorScoresUser9User54 = EuclidDist.CalculateImpostorScores(s009Mean, s054);
            impostorScoresUser9User55 = EuclidDist.CalculateImpostorScores(s009Mean, s055);
            impostorScoresUser9User56 = EuclidDist.CalculateImpostorScores(s009Mean, s056);
            impostorScoresUser9User57 = EuclidDist.CalculateImpostorScores(s009Mean, s057);
            impostorScoresUser9User58 = EuclidDist.CalculateImpostorScores(s009Mean, s058);
            impostorScoresUser9User59 = EuclidDist.CalculateImpostorScores(s009Mean, s059);
            impostorScoresUser9User60 = EuclidDist.CalculateImpostorScores(s009Mean, s060);

            impostorScoresUser9User61 = EuclidDist.CalculateImpostorScores(s009Mean, s061);
            impostorScoresUser9User62 = EuclidDist.CalculateImpostorScores(s009Mean, s062);
            impostorScoresUser9User63 = EuclidDist.CalculateImpostorScores(s009Mean, s063);
            impostorScoresUser9User64 = EuclidDist.CalculateImpostorScores(s009Mean, s064);
            impostorScoresUser9User65 = EuclidDist.CalculateImpostorScores(s009Mean, s065);
            impostorScoresUser9User66 = EuclidDist.CalculateImpostorScores(s009Mean, s066);
            impostorScoresUser9User67 = EuclidDist.CalculateImpostorScores(s009Mean, s067);
            impostorScoresUser9User68 = EuclidDist.CalculateImpostorScores(s009Mean, s068);
            impostorScoresUser9User69 = EuclidDist.CalculateImpostorScores(s009Mean, s069);
            impostorScoresUser9User70 = EuclidDist.CalculateImpostorScores(s009Mean, s070);

            impostorScoresUser9User71 = EuclidDist.CalculateImpostorScores(s009Mean, s071);
            impostorScoresUser9User72 = EuclidDist.CalculateImpostorScores(s009Mean, s072);
            impostorScoresUser9User73 = EuclidDist.CalculateImpostorScores(s009Mean, s073);
            impostorScoresUser9User74 = EuclidDist.CalculateImpostorScores(s009Mean, s074);
            impostorScoresUser9User75 = EuclidDist.CalculateImpostorScores(s009Mean, s075);
            impostorScoresUser9User76 = EuclidDist.CalculateImpostorScores(s009Mean, s076);
            impostorScoresUser9User77 = EuclidDist.CalculateImpostorScores(s009Mean, s077);
            impostorScoresUser9User78 = EuclidDist.CalculateImpostorScores(s009Mean, s078);
            impostorScoresUser9User79 = EuclidDist.CalculateImpostorScores(s009Mean, s079);
            impostorScoresUser9User80 = EuclidDist.CalculateImpostorScores(s009Mean, s080);

            impostorScoresUser9User81 = EuclidDist.CalculateImpostorScores(s009Mean, s081);
            impostorScoresUser9User82 = EuclidDist.CalculateImpostorScores(s009Mean, s082);
            impostorScoresUser9User83 = EuclidDist.CalculateImpostorScores(s009Mean, s083);
            impostorScoresUser9User84 = EuclidDist.CalculateImpostorScores(s009Mean, s084);
            impostorScoresUser9User85 = EuclidDist.CalculateImpostorScores(s009Mean, s085);
            impostorScoresUser9User86 = EuclidDist.CalculateImpostorScores(s009Mean, s086);
            impostorScoresUser9User87 = EuclidDist.CalculateImpostorScores(s009Mean, s087);
            impostorScoresUser9User88 = EuclidDist.CalculateImpostorScores(s009Mean, s088);
            impostorScoresUser9User89 = EuclidDist.CalculateImpostorScores(s009Mean, s089);
            impostorScoresUser9User90 = EuclidDist.CalculateImpostorScores(s009Mean, s090);

            impostorScoresUser9User91 = EuclidDist.CalculateImpostorScores(s009Mean, s091);
            impostorScoresUser9User92 = EuclidDist.CalculateImpostorScores(s009Mean, s092);
            impostorScoresUser9User93 = EuclidDist.CalculateImpostorScores(s009Mean, s093);
            impostorScoresUser9User94 = EuclidDist.CalculateImpostorScores(s009Mean, s094);
            impostorScoresUser9User95 = EuclidDist.CalculateImpostorScores(s009Mean, s095);
            impostorScoresUser9User96 = EuclidDist.CalculateImpostorScores(s009Mean, s096);
            impostorScoresUser9User97 = EuclidDist.CalculateImpostorScores(s009Mean, s097);
            impostorScoresUser9User98 = EuclidDist.CalculateImpostorScores(s009Mean, s098);
            impostorScoresUser9User99 = EuclidDist.CalculateImpostorScores(s009Mean, s099);
            impostorScoresUser9User100 = EuclidDist.CalculateImpostorScores(s009Mean, s100);
            #endregion

            #region User 10 Impostor scores
            impostorScoresUser10User1 = EuclidDist.CalculateImpostorScores(s010Mean, s001);
            impostorScoresUser10User2 = EuclidDist.CalculateImpostorScores(s010Mean, s002);
            impostorScoresUser10User3 = EuclidDist.CalculateImpostorScores(s010Mean, s003);
            impostorScoresUser10User4 = EuclidDist.CalculateImpostorScores(s010Mean, s004);
            impostorScoresUser10User5 = EuclidDist.CalculateImpostorScores(s010Mean, s005);
            impostorScoresUser10User6 = EuclidDist.CalculateImpostorScores(s010Mean, s006);
            impostorScoresUser10User7 = EuclidDist.CalculateImpostorScores(s010Mean, s007);
            impostorScoresUser10User8 = EuclidDist.CalculateImpostorScores(s010Mean, s008);
            impostorScoresUser10User9 = EuclidDist.CalculateImpostorScores(s010Mean, s009);
            impostorScoresUser10User11 = EuclidDist.CalculateImpostorScores(s010Mean, s011);

            impostorScoresUser10User12 = EuclidDist.CalculateImpostorScores(s010Mean, s012);
            impostorScoresUser10User13 = EuclidDist.CalculateImpostorScores(s010Mean, s013);
            impostorScoresUser10User14 = EuclidDist.CalculateImpostorScores(s010Mean, s014);
            impostorScoresUser10User15 = EuclidDist.CalculateImpostorScores(s010Mean, s015);
            impostorScoresUser10User16 = EuclidDist.CalculateImpostorScores(s010Mean, s016);
            impostorScoresUser10User17 = EuclidDist.CalculateImpostorScores(s010Mean, s017);
            impostorScoresUser10User18 = EuclidDist.CalculateImpostorScores(s010Mean, s018);
            impostorScoresUser10User19 = EuclidDist.CalculateImpostorScores(s010Mean, s019);
            impostorScoresUser10User20 = EuclidDist.CalculateImpostorScores(s010Mean, s020);

            impostorScoresUser10User21 = EuclidDist.CalculateImpostorScores(s010Mean, s021);
            impostorScoresUser10User22 = EuclidDist.CalculateImpostorScores(s010Mean, s022);
            impostorScoresUser10User23 = EuclidDist.CalculateImpostorScores(s010Mean, s023);
            impostorScoresUser10User24 = EuclidDist.CalculateImpostorScores(s010Mean, s024);
            impostorScoresUser10User25 = EuclidDist.CalculateImpostorScores(s010Mean, s025);
            impostorScoresUser10User26 = EuclidDist.CalculateImpostorScores(s010Mean, s026);
            impostorScoresUser10User27 = EuclidDist.CalculateImpostorScores(s010Mean, s027);
            impostorScoresUser10User28 = EuclidDist.CalculateImpostorScores(s010Mean, s028);
            impostorScoresUser10User29 = EuclidDist.CalculateImpostorScores(s010Mean, s029);
            impostorScoresUser10User30 = EuclidDist.CalculateImpostorScores(s010Mean, s030);

            impostorScoresUser10User31 = EuclidDist.CalculateImpostorScores(s010Mean, s031);
            impostorScoresUser10User32 = EuclidDist.CalculateImpostorScores(s010Mean, s032);
            impostorScoresUser10User33 = EuclidDist.CalculateImpostorScores(s010Mean, s033);
            impostorScoresUser10User34 = EuclidDist.CalculateImpostorScores(s010Mean, s034);
            impostorScoresUser10User35 = EuclidDist.CalculateImpostorScores(s010Mean, s035);
            impostorScoresUser10User36 = EuclidDist.CalculateImpostorScores(s010Mean, s036);
            impostorScoresUser10User37 = EuclidDist.CalculateImpostorScores(s010Mean, s037);
            impostorScoresUser10User38 = EuclidDist.CalculateImpostorScores(s010Mean, s038);
            impostorScoresUser10User39 = EuclidDist.CalculateImpostorScores(s010Mean, s039);
            impostorScoresUser10User40 = EuclidDist.CalculateImpostorScores(s010Mean, s040);

            impostorScoresUser10User41 = EuclidDist.CalculateImpostorScores(s010Mean, s041);
            impostorScoresUser10User42 = EuclidDist.CalculateImpostorScores(s010Mean, s042);
            impostorScoresUser10User43 = EuclidDist.CalculateImpostorScores(s010Mean, s043);
            impostorScoresUser10User44 = EuclidDist.CalculateImpostorScores(s010Mean, s044);
            impostorScoresUser10User45 = EuclidDist.CalculateImpostorScores(s010Mean, s045);
            impostorScoresUser10User46 = EuclidDist.CalculateImpostorScores(s010Mean, s046);
            impostorScoresUser10User47 = EuclidDist.CalculateImpostorScores(s010Mean, s047);
            impostorScoresUser10User48 = EuclidDist.CalculateImpostorScores(s010Mean, s048);
            impostorScoresUser10User49 = EuclidDist.CalculateImpostorScores(s010Mean, s049);
            impostorScoresUser10User50 = EuclidDist.CalculateImpostorScores(s010Mean, s050);

            impostorScoresUser10User51 = EuclidDist.CalculateImpostorScores(s010Mean, s051);
            impostorScoresUser10User52 = EuclidDist.CalculateImpostorScores(s010Mean, s052);
            impostorScoresUser10User53 = EuclidDist.CalculateImpostorScores(s010Mean, s053);
            impostorScoresUser10User54 = EuclidDist.CalculateImpostorScores(s010Mean, s054);
            impostorScoresUser10User55 = EuclidDist.CalculateImpostorScores(s010Mean, s055);
            impostorScoresUser10User56 = EuclidDist.CalculateImpostorScores(s010Mean, s056);
            impostorScoresUser10User57 = EuclidDist.CalculateImpostorScores(s010Mean, s057);
            impostorScoresUser10User58 = EuclidDist.CalculateImpostorScores(s010Mean, s058);
            impostorScoresUser10User59 = EuclidDist.CalculateImpostorScores(s010Mean, s059);
            impostorScoresUser10User60 = EuclidDist.CalculateImpostorScores(s010Mean, s060);

            impostorScoresUser10User61 = EuclidDist.CalculateImpostorScores(s010Mean, s061);
            impostorScoresUser10User62 = EuclidDist.CalculateImpostorScores(s010Mean, s062);
            impostorScoresUser10User63 = EuclidDist.CalculateImpostorScores(s010Mean, s063);
            impostorScoresUser10User64 = EuclidDist.CalculateImpostorScores(s010Mean, s064);
            impostorScoresUser10User65 = EuclidDist.CalculateImpostorScores(s010Mean, s065);
            impostorScoresUser10User66 = EuclidDist.CalculateImpostorScores(s010Mean, s066);
            impostorScoresUser10User67 = EuclidDist.CalculateImpostorScores(s010Mean, s067);
            impostorScoresUser10User68 = EuclidDist.CalculateImpostorScores(s010Mean, s068);
            impostorScoresUser10User69 = EuclidDist.CalculateImpostorScores(s010Mean, s069);
            impostorScoresUser10User70 = EuclidDist.CalculateImpostorScores(s010Mean, s070);

            impostorScoresUser10User71 = EuclidDist.CalculateImpostorScores(s010Mean, s071);
            impostorScoresUser10User72 = EuclidDist.CalculateImpostorScores(s010Mean, s072);
            impostorScoresUser10User73 = EuclidDist.CalculateImpostorScores(s010Mean, s073);
            impostorScoresUser10User74 = EuclidDist.CalculateImpostorScores(s010Mean, s074);
            impostorScoresUser10User75 = EuclidDist.CalculateImpostorScores(s010Mean, s075);
            impostorScoresUser10User76 = EuclidDist.CalculateImpostorScores(s010Mean, s076);
            impostorScoresUser10User77 = EuclidDist.CalculateImpostorScores(s010Mean, s077);
            impostorScoresUser10User78 = EuclidDist.CalculateImpostorScores(s010Mean, s078);
            impostorScoresUser10User79 = EuclidDist.CalculateImpostorScores(s010Mean, s079);
            impostorScoresUser10User80 = EuclidDist.CalculateImpostorScores(s010Mean, s080);

            impostorScoresUser10User81 = EuclidDist.CalculateImpostorScores(s010Mean, s081);
            impostorScoresUser10User82 = EuclidDist.CalculateImpostorScores(s010Mean, s082);
            impostorScoresUser10User83 = EuclidDist.CalculateImpostorScores(s010Mean, s083);
            impostorScoresUser10User84 = EuclidDist.CalculateImpostorScores(s010Mean, s084);
            impostorScoresUser10User85 = EuclidDist.CalculateImpostorScores(s010Mean, s085);
            impostorScoresUser10User86 = EuclidDist.CalculateImpostorScores(s010Mean, s086);
            impostorScoresUser10User87 = EuclidDist.CalculateImpostorScores(s010Mean, s087);
            impostorScoresUser10User88 = EuclidDist.CalculateImpostorScores(s010Mean, s088);
            impostorScoresUser10User89 = EuclidDist.CalculateImpostorScores(s010Mean, s089);
            impostorScoresUser10User90 = EuclidDist.CalculateImpostorScores(s010Mean, s090);

            impostorScoresUser10User91 = EuclidDist.CalculateImpostorScores(s010Mean, s091);
            impostorScoresUser10User92 = EuclidDist.CalculateImpostorScores(s010Mean, s092);
            impostorScoresUser10User93 = EuclidDist.CalculateImpostorScores(s010Mean, s093);
            impostorScoresUser10User94 = EuclidDist.CalculateImpostorScores(s010Mean, s094);
            impostorScoresUser10User95 = EuclidDist.CalculateImpostorScores(s010Mean, s095);
            impostorScoresUser10User96 = EuclidDist.CalculateImpostorScores(s010Mean, s096);
            impostorScoresUser10User97 = EuclidDist.CalculateImpostorScores(s010Mean, s097);
            impostorScoresUser10User98 = EuclidDist.CalculateImpostorScores(s010Mean, s098);
            impostorScoresUser10User99 = EuclidDist.CalculateImpostorScores(s010Mean, s099);
            impostorScoresUser10User100 = EuclidDist.CalculateImpostorScores(s010Mean, s100); 
            #endregion

            #region User 11 Impostor scores
            impostorScoresUser11User1 = EuclidDist.CalculateImpostorScores(s011Mean, s001);
            impostorScoresUser11User2 = EuclidDist.CalculateImpostorScores(s011Mean, s002);
            impostorScoresUser11User3 = EuclidDist.CalculateImpostorScores(s011Mean, s003);
            impostorScoresUser11User4 = EuclidDist.CalculateImpostorScores(s011Mean, s004);
            impostorScoresUser11User5 = EuclidDist.CalculateImpostorScores(s011Mean, s005);
            impostorScoresUser11User6 = EuclidDist.CalculateImpostorScores(s011Mean, s006);
            impostorScoresUser11User7 = EuclidDist.CalculateImpostorScores(s011Mean, s007);
            impostorScoresUser11User8 = EuclidDist.CalculateImpostorScores(s011Mean, s008);
            impostorScoresUser11User9 = EuclidDist.CalculateImpostorScores(s011Mean, s009);
            impostorScoresUser11User10 = EuclidDist.CalculateImpostorScores(s011Mean, s010);

            impostorScoresUser11User12 = EuclidDist.CalculateImpostorScores(s011Mean, s012);
            impostorScoresUser11User13 = EuclidDist.CalculateImpostorScores(s011Mean, s013);
            impostorScoresUser11User14 = EuclidDist.CalculateImpostorScores(s011Mean, s014);
            impostorScoresUser11User15 = EuclidDist.CalculateImpostorScores(s011Mean, s015);
            impostorScoresUser11User16 = EuclidDist.CalculateImpostorScores(s011Mean, s016);
            impostorScoresUser11User17 = EuclidDist.CalculateImpostorScores(s011Mean, s017);
            impostorScoresUser11User18 = EuclidDist.CalculateImpostorScores(s011Mean, s018);
            impostorScoresUser11User19 = EuclidDist.CalculateImpostorScores(s011Mean, s019);
            impostorScoresUser11User20 = EuclidDist.CalculateImpostorScores(s011Mean, s020);

            impostorScoresUser11User21 = EuclidDist.CalculateImpostorScores(s011Mean, s021);
            impostorScoresUser11User22 = EuclidDist.CalculateImpostorScores(s011Mean, s022);
            impostorScoresUser11User23 = EuclidDist.CalculateImpostorScores(s011Mean, s023);
            impostorScoresUser11User24 = EuclidDist.CalculateImpostorScores(s011Mean, s024);
            impostorScoresUser11User25 = EuclidDist.CalculateImpostorScores(s011Mean, s025);
            impostorScoresUser11User26 = EuclidDist.CalculateImpostorScores(s011Mean, s026);
            impostorScoresUser11User27 = EuclidDist.CalculateImpostorScores(s011Mean, s027);
            impostorScoresUser11User28 = EuclidDist.CalculateImpostorScores(s011Mean, s028);
            impostorScoresUser11User29 = EuclidDist.CalculateImpostorScores(s011Mean, s029);
            impostorScoresUser11User30 = EuclidDist.CalculateImpostorScores(s011Mean, s030);

            impostorScoresUser11User31 = EuclidDist.CalculateImpostorScores(s011Mean, s031);
            impostorScoresUser11User32 = EuclidDist.CalculateImpostorScores(s011Mean, s032);
            impostorScoresUser11User33 = EuclidDist.CalculateImpostorScores(s011Mean, s033);
            impostorScoresUser11User34 = EuclidDist.CalculateImpostorScores(s011Mean, s034);
            impostorScoresUser11User35 = EuclidDist.CalculateImpostorScores(s011Mean, s035);
            impostorScoresUser11User36 = EuclidDist.CalculateImpostorScores(s011Mean, s036);
            impostorScoresUser11User37 = EuclidDist.CalculateImpostorScores(s011Mean, s037);
            impostorScoresUser11User38 = EuclidDist.CalculateImpostorScores(s011Mean, s038);
            impostorScoresUser11User39 = EuclidDist.CalculateImpostorScores(s011Mean, s039);
            impostorScoresUser11User40 = EuclidDist.CalculateImpostorScores(s011Mean, s040);

            impostorScoresUser11User41 = EuclidDist.CalculateImpostorScores(s011Mean, s041);
            impostorScoresUser11User42 = EuclidDist.CalculateImpostorScores(s011Mean, s042);
            impostorScoresUser11User43 = EuclidDist.CalculateImpostorScores(s011Mean, s043);
            impostorScoresUser11User44 = EuclidDist.CalculateImpostorScores(s011Mean, s044);
            impostorScoresUser11User45 = EuclidDist.CalculateImpostorScores(s011Mean, s045);
            impostorScoresUser11User46 = EuclidDist.CalculateImpostorScores(s011Mean, s046);
            impostorScoresUser11User47 = EuclidDist.CalculateImpostorScores(s011Mean, s047);
            impostorScoresUser11User48 = EuclidDist.CalculateImpostorScores(s011Mean, s048);
            impostorScoresUser11User49 = EuclidDist.CalculateImpostorScores(s011Mean, s049);
            impostorScoresUser11User50 = EuclidDist.CalculateImpostorScores(s011Mean, s050);

            impostorScoresUser11User51 = EuclidDist.CalculateImpostorScores(s011Mean, s051);
            impostorScoresUser11User52 = EuclidDist.CalculateImpostorScores(s011Mean, s052);
            impostorScoresUser11User53 = EuclidDist.CalculateImpostorScores(s011Mean, s053);
            impostorScoresUser11User54 = EuclidDist.CalculateImpostorScores(s011Mean, s054);
            impostorScoresUser11User55 = EuclidDist.CalculateImpostorScores(s011Mean, s055);
            impostorScoresUser11User56 = EuclidDist.CalculateImpostorScores(s011Mean, s056);
            impostorScoresUser11User57 = EuclidDist.CalculateImpostorScores(s011Mean, s057);
            impostorScoresUser11User58 = EuclidDist.CalculateImpostorScores(s011Mean, s058);
            impostorScoresUser11User59 = EuclidDist.CalculateImpostorScores(s011Mean, s059);
            impostorScoresUser11User60 = EuclidDist.CalculateImpostorScores(s011Mean, s060);

            impostorScoresUser11User61 = EuclidDist.CalculateImpostorScores(s011Mean, s061);
            impostorScoresUser11User62 = EuclidDist.CalculateImpostorScores(s011Mean, s062);
            impostorScoresUser11User63 = EuclidDist.CalculateImpostorScores(s011Mean, s063);
            impostorScoresUser11User64 = EuclidDist.CalculateImpostorScores(s011Mean, s064);
            impostorScoresUser11User65 = EuclidDist.CalculateImpostorScores(s011Mean, s065);
            impostorScoresUser11User66 = EuclidDist.CalculateImpostorScores(s011Mean, s066);
            impostorScoresUser11User67 = EuclidDist.CalculateImpostorScores(s011Mean, s067);
            impostorScoresUser11User68 = EuclidDist.CalculateImpostorScores(s011Mean, s068);
            impostorScoresUser11User69 = EuclidDist.CalculateImpostorScores(s011Mean, s069);
            impostorScoresUser11User70 = EuclidDist.CalculateImpostorScores(s011Mean, s070);

            impostorScoresUser11User71 = EuclidDist.CalculateImpostorScores(s011Mean, s071);
            impostorScoresUser11User72 = EuclidDist.CalculateImpostorScores(s011Mean, s072);
            impostorScoresUser11User73 = EuclidDist.CalculateImpostorScores(s011Mean, s073);
            impostorScoresUser11User74 = EuclidDist.CalculateImpostorScores(s011Mean, s074);
            impostorScoresUser11User75 = EuclidDist.CalculateImpostorScores(s011Mean, s075);
            impostorScoresUser11User76 = EuclidDist.CalculateImpostorScores(s011Mean, s076);
            impostorScoresUser11User77 = EuclidDist.CalculateImpostorScores(s011Mean, s077);
            impostorScoresUser11User78 = EuclidDist.CalculateImpostorScores(s011Mean, s078);
            impostorScoresUser11User79 = EuclidDist.CalculateImpostorScores(s011Mean, s079);
            impostorScoresUser11User80 = EuclidDist.CalculateImpostorScores(s011Mean, s080);

            impostorScoresUser11User81 = EuclidDist.CalculateImpostorScores(s011Mean, s081);
            impostorScoresUser11User82 = EuclidDist.CalculateImpostorScores(s011Mean, s082);
            impostorScoresUser11User83 = EuclidDist.CalculateImpostorScores(s011Mean, s083);
            impostorScoresUser11User84 = EuclidDist.CalculateImpostorScores(s011Mean, s084);
            impostorScoresUser11User85 = EuclidDist.CalculateImpostorScores(s011Mean, s085);
            impostorScoresUser11User86 = EuclidDist.CalculateImpostorScores(s011Mean, s086);
            impostorScoresUser11User87 = EuclidDist.CalculateImpostorScores(s011Mean, s087);
            impostorScoresUser11User88 = EuclidDist.CalculateImpostorScores(s011Mean, s088);
            impostorScoresUser11User89 = EuclidDist.CalculateImpostorScores(s011Mean, s089);
            impostorScoresUser11User90 = EuclidDist.CalculateImpostorScores(s011Mean, s090);

            impostorScoresUser11User91 = EuclidDist.CalculateImpostorScores(s011Mean, s091);
            impostorScoresUser11User92 = EuclidDist.CalculateImpostorScores(s011Mean, s092);
            impostorScoresUser11User93 = EuclidDist.CalculateImpostorScores(s011Mean, s093);
            impostorScoresUser11User94 = EuclidDist.CalculateImpostorScores(s011Mean, s094);
            impostorScoresUser11User95 = EuclidDist.CalculateImpostorScores(s011Mean, s095);
            impostorScoresUser11User96 = EuclidDist.CalculateImpostorScores(s011Mean, s096);
            impostorScoresUser11User97 = EuclidDist.CalculateImpostorScores(s011Mean, s097);
            impostorScoresUser11User98 = EuclidDist.CalculateImpostorScores(s011Mean, s098);
            impostorScoresUser11User99 = EuclidDist.CalculateImpostorScores(s011Mean, s099);
            impostorScoresUser11User100 = EuclidDist.CalculateImpostorScores(s011Mean, s100);
            #endregion

            #region User 12 Impostor scores
            impostorScoresUser12User1 = EuclidDist.CalculateImpostorScores(s012Mean, s001);
            impostorScoresUser12User2 = EuclidDist.CalculateImpostorScores(s012Mean, s002);
            impostorScoresUser12User3 = EuclidDist.CalculateImpostorScores(s012Mean, s003);
            impostorScoresUser12User4 = EuclidDist.CalculateImpostorScores(s012Mean, s004);
            impostorScoresUser12User5 = EuclidDist.CalculateImpostorScores(s012Mean, s005);
            impostorScoresUser12User6 = EuclidDist.CalculateImpostorScores(s012Mean, s006);
            impostorScoresUser12User7 = EuclidDist.CalculateImpostorScores(s012Mean, s007);
            impostorScoresUser12User8 = EuclidDist.CalculateImpostorScores(s012Mean, s008);
            impostorScoresUser12User9 = EuclidDist.CalculateImpostorScores(s012Mean, s009);
            impostorScoresUser12User10 = EuclidDist.CalculateImpostorScores(s012Mean, s010);

            impostorScoresUser12User11 = EuclidDist.CalculateImpostorScores(s012Mean, s011);
            impostorScoresUser12User13 = EuclidDist.CalculateImpostorScores(s012Mean, s013);
            impostorScoresUser12User14 = EuclidDist.CalculateImpostorScores(s012Mean, s014);
            impostorScoresUser12User15 = EuclidDist.CalculateImpostorScores(s012Mean, s015);
            impostorScoresUser12User16 = EuclidDist.CalculateImpostorScores(s012Mean, s016);
            impostorScoresUser12User17 = EuclidDist.CalculateImpostorScores(s012Mean, s017);
            impostorScoresUser12User18 = EuclidDist.CalculateImpostorScores(s012Mean, s018);
            impostorScoresUser12User19 = EuclidDist.CalculateImpostorScores(s012Mean, s019);
            impostorScoresUser12User20 = EuclidDist.CalculateImpostorScores(s012Mean, s020);

            impostorScoresUser12User21 = EuclidDist.CalculateImpostorScores(s012Mean, s021);
            impostorScoresUser12User22 = EuclidDist.CalculateImpostorScores(s012Mean, s022);
            impostorScoresUser12User23 = EuclidDist.CalculateImpostorScores(s012Mean, s023);
            impostorScoresUser12User24 = EuclidDist.CalculateImpostorScores(s012Mean, s024);
            impostorScoresUser12User25 = EuclidDist.CalculateImpostorScores(s012Mean, s025);
            impostorScoresUser12User26 = EuclidDist.CalculateImpostorScores(s012Mean, s026);
            impostorScoresUser12User27 = EuclidDist.CalculateImpostorScores(s012Mean, s027);
            impostorScoresUser12User28 = EuclidDist.CalculateImpostorScores(s012Mean, s028);
            impostorScoresUser12User29 = EuclidDist.CalculateImpostorScores(s012Mean, s029);
            impostorScoresUser12User30 = EuclidDist.CalculateImpostorScores(s012Mean, s030);

            impostorScoresUser12User31 = EuclidDist.CalculateImpostorScores(s012Mean, s031);
            impostorScoresUser12User32 = EuclidDist.CalculateImpostorScores(s012Mean, s032);
            impostorScoresUser12User33 = EuclidDist.CalculateImpostorScores(s012Mean, s033);
            impostorScoresUser12User34 = EuclidDist.CalculateImpostorScores(s012Mean, s034);
            impostorScoresUser12User35 = EuclidDist.CalculateImpostorScores(s012Mean, s035);
            impostorScoresUser12User36 = EuclidDist.CalculateImpostorScores(s012Mean, s036);
            impostorScoresUser12User37 = EuclidDist.CalculateImpostorScores(s012Mean, s037);
            impostorScoresUser12User38 = EuclidDist.CalculateImpostorScores(s012Mean, s038);
            impostorScoresUser12User39 = EuclidDist.CalculateImpostorScores(s012Mean, s039);
            impostorScoresUser12User40 = EuclidDist.CalculateImpostorScores(s012Mean, s040);

            impostorScoresUser12User41 = EuclidDist.CalculateImpostorScores(s012Mean, s041);
            impostorScoresUser12User42 = EuclidDist.CalculateImpostorScores(s012Mean, s042);
            impostorScoresUser12User43 = EuclidDist.CalculateImpostorScores(s012Mean, s043);
            impostorScoresUser12User44 = EuclidDist.CalculateImpostorScores(s012Mean, s044);
            impostorScoresUser12User45 = EuclidDist.CalculateImpostorScores(s012Mean, s045);
            impostorScoresUser12User46 = EuclidDist.CalculateImpostorScores(s012Mean, s046);
            impostorScoresUser12User47 = EuclidDist.CalculateImpostorScores(s012Mean, s047);
            impostorScoresUser12User48 = EuclidDist.CalculateImpostorScores(s012Mean, s048);
            impostorScoresUser12User49 = EuclidDist.CalculateImpostorScores(s012Mean, s049);
            impostorScoresUser12User50 = EuclidDist.CalculateImpostorScores(s012Mean, s050);

            impostorScoresUser12User51 = EuclidDist.CalculateImpostorScores(s012Mean, s051);
            impostorScoresUser12User52 = EuclidDist.CalculateImpostorScores(s012Mean, s052);
            impostorScoresUser12User53 = EuclidDist.CalculateImpostorScores(s012Mean, s053);
            impostorScoresUser12User54 = EuclidDist.CalculateImpostorScores(s012Mean, s054);
            impostorScoresUser12User55 = EuclidDist.CalculateImpostorScores(s012Mean, s055);
            impostorScoresUser12User56 = EuclidDist.CalculateImpostorScores(s012Mean, s056);
            impostorScoresUser12User57 = EuclidDist.CalculateImpostorScores(s012Mean, s057);
            impostorScoresUser12User58 = EuclidDist.CalculateImpostorScores(s012Mean, s058);
            impostorScoresUser12User59 = EuclidDist.CalculateImpostorScores(s012Mean, s059);
            impostorScoresUser12User60 = EuclidDist.CalculateImpostorScores(s012Mean, s060);

            impostorScoresUser12User61 = EuclidDist.CalculateImpostorScores(s012Mean, s061);
            impostorScoresUser12User62 = EuclidDist.CalculateImpostorScores(s012Mean, s062);
            impostorScoresUser12User63 = EuclidDist.CalculateImpostorScores(s012Mean, s063);
            impostorScoresUser12User64 = EuclidDist.CalculateImpostorScores(s012Mean, s064);
            impostorScoresUser12User65 = EuclidDist.CalculateImpostorScores(s012Mean, s065);
            impostorScoresUser12User66 = EuclidDist.CalculateImpostorScores(s012Mean, s066);
            impostorScoresUser12User67 = EuclidDist.CalculateImpostorScores(s012Mean, s067);
            impostorScoresUser12User68 = EuclidDist.CalculateImpostorScores(s012Mean, s068);
            impostorScoresUser12User69 = EuclidDist.CalculateImpostorScores(s012Mean, s069);
            impostorScoresUser12User70 = EuclidDist.CalculateImpostorScores(s012Mean, s070);

            impostorScoresUser12User71 = EuclidDist.CalculateImpostorScores(s012Mean, s071);
            impostorScoresUser12User72 = EuclidDist.CalculateImpostorScores(s012Mean, s072);
            impostorScoresUser12User73 = EuclidDist.CalculateImpostorScores(s012Mean, s073);
            impostorScoresUser12User74 = EuclidDist.CalculateImpostorScores(s012Mean, s074);
            impostorScoresUser12User75 = EuclidDist.CalculateImpostorScores(s012Mean, s075);
            impostorScoresUser12User76 = EuclidDist.CalculateImpostorScores(s012Mean, s076);
            impostorScoresUser12User77 = EuclidDist.CalculateImpostorScores(s012Mean, s077);
            impostorScoresUser12User78 = EuclidDist.CalculateImpostorScores(s012Mean, s078);
            impostorScoresUser12User79 = EuclidDist.CalculateImpostorScores(s012Mean, s079);
            impostorScoresUser12User80 = EuclidDist.CalculateImpostorScores(s012Mean, s080);

            impostorScoresUser12User81 = EuclidDist.CalculateImpostorScores(s012Mean, s081);
            impostorScoresUser12User82 = EuclidDist.CalculateImpostorScores(s012Mean, s082);
            impostorScoresUser12User83 = EuclidDist.CalculateImpostorScores(s012Mean, s083);
            impostorScoresUser12User84 = EuclidDist.CalculateImpostorScores(s012Mean, s084);
            impostorScoresUser12User85 = EuclidDist.CalculateImpostorScores(s012Mean, s085);
            impostorScoresUser12User86 = EuclidDist.CalculateImpostorScores(s012Mean, s086);
            impostorScoresUser12User87 = EuclidDist.CalculateImpostorScores(s012Mean, s087);
            impostorScoresUser12User88 = EuclidDist.CalculateImpostorScores(s012Mean, s088);
            impostorScoresUser12User89 = EuclidDist.CalculateImpostorScores(s012Mean, s089);
            impostorScoresUser12User90 = EuclidDist.CalculateImpostorScores(s012Mean, s090);

            impostorScoresUser12User91 = EuclidDist.CalculateImpostorScores(s012Mean, s091);
            impostorScoresUser12User92 = EuclidDist.CalculateImpostorScores(s012Mean, s092);
            impostorScoresUser12User93 = EuclidDist.CalculateImpostorScores(s012Mean, s093);
            impostorScoresUser12User94 = EuclidDist.CalculateImpostorScores(s012Mean, s094);
            impostorScoresUser12User95 = EuclidDist.CalculateImpostorScores(s012Mean, s095);
            impostorScoresUser12User96 = EuclidDist.CalculateImpostorScores(s012Mean, s096);
            impostorScoresUser12User97 = EuclidDist.CalculateImpostorScores(s012Mean, s097);
            impostorScoresUser12User98 = EuclidDist.CalculateImpostorScores(s012Mean, s098);
            impostorScoresUser12User99 = EuclidDist.CalculateImpostorScores(s012Mean, s099);
            impostorScoresUser12User100 = EuclidDist.CalculateImpostorScores(s012Mean, s100);
            #endregion

            #region User 13 Impostor scores
            impostorScoresUser13User1 = EuclidDist.CalculateImpostorScores(s013Mean, s001);
            impostorScoresUser13User2 = EuclidDist.CalculateImpostorScores(s013Mean, s002);
            impostorScoresUser13User3 = EuclidDist.CalculateImpostorScores(s013Mean, s003);
            impostorScoresUser13User4 = EuclidDist.CalculateImpostorScores(s013Mean, s004);
            impostorScoresUser13User5 = EuclidDist.CalculateImpostorScores(s013Mean, s005);
            impostorScoresUser13User6 = EuclidDist.CalculateImpostorScores(s013Mean, s006);
            impostorScoresUser13User7 = EuclidDist.CalculateImpostorScores(s013Mean, s007);
            impostorScoresUser13User8 = EuclidDist.CalculateImpostorScores(s013Mean, s008);
            impostorScoresUser13User9 = EuclidDist.CalculateImpostorScores(s013Mean, s009);
            impostorScoresUser13User10 = EuclidDist.CalculateImpostorScores(s013Mean, s010);

            impostorScoresUser13User11 = EuclidDist.CalculateImpostorScores(s013Mean, s011);
            impostorScoresUser13User12 = EuclidDist.CalculateImpostorScores(s013Mean, s012);
            impostorScoresUser13User14 = EuclidDist.CalculateImpostorScores(s013Mean, s014);
            impostorScoresUser13User15 = EuclidDist.CalculateImpostorScores(s013Mean, s015);
            impostorScoresUser13User16 = EuclidDist.CalculateImpostorScores(s013Mean, s016);
            impostorScoresUser13User17 = EuclidDist.CalculateImpostorScores(s013Mean, s017);
            impostorScoresUser13User18 = EuclidDist.CalculateImpostorScores(s013Mean, s018);
            impostorScoresUser13User19 = EuclidDist.CalculateImpostorScores(s013Mean, s019);
            impostorScoresUser13User20 = EuclidDist.CalculateImpostorScores(s013Mean, s020);

            impostorScoresUser13User21 = EuclidDist.CalculateImpostorScores(s013Mean, s021);
            impostorScoresUser13User22 = EuclidDist.CalculateImpostorScores(s013Mean, s022);
            impostorScoresUser13User23 = EuclidDist.CalculateImpostorScores(s013Mean, s023);
            impostorScoresUser13User24 = EuclidDist.CalculateImpostorScores(s013Mean, s024);
            impostorScoresUser13User25 = EuclidDist.CalculateImpostorScores(s013Mean, s025);
            impostorScoresUser13User26 = EuclidDist.CalculateImpostorScores(s013Mean, s026);
            impostorScoresUser13User27 = EuclidDist.CalculateImpostorScores(s013Mean, s027);
            impostorScoresUser13User28 = EuclidDist.CalculateImpostorScores(s013Mean, s028);
            impostorScoresUser13User29 = EuclidDist.CalculateImpostorScores(s013Mean, s029);
            impostorScoresUser13User30 = EuclidDist.CalculateImpostorScores(s013Mean, s030);

            impostorScoresUser13User31 = EuclidDist.CalculateImpostorScores(s013Mean, s031);
            impostorScoresUser13User32 = EuclidDist.CalculateImpostorScores(s013Mean, s032);
            impostorScoresUser13User33 = EuclidDist.CalculateImpostorScores(s013Mean, s033);
            impostorScoresUser13User34 = EuclidDist.CalculateImpostorScores(s013Mean, s034);
            impostorScoresUser13User35 = EuclidDist.CalculateImpostorScores(s013Mean, s035);
            impostorScoresUser13User36 = EuclidDist.CalculateImpostorScores(s013Mean, s036);
            impostorScoresUser13User37 = EuclidDist.CalculateImpostorScores(s013Mean, s037);
            impostorScoresUser13User38 = EuclidDist.CalculateImpostorScores(s013Mean, s038);
            impostorScoresUser13User39 = EuclidDist.CalculateImpostorScores(s013Mean, s039);
            impostorScoresUser13User40 = EuclidDist.CalculateImpostorScores(s013Mean, s040);

            impostorScoresUser13User41 = EuclidDist.CalculateImpostorScores(s013Mean, s041);
            impostorScoresUser13User42 = EuclidDist.CalculateImpostorScores(s013Mean, s042);
            impostorScoresUser13User43 = EuclidDist.CalculateImpostorScores(s013Mean, s043);
            impostorScoresUser13User44 = EuclidDist.CalculateImpostorScores(s013Mean, s044);
            impostorScoresUser13User45 = EuclidDist.CalculateImpostorScores(s013Mean, s045);
            impostorScoresUser13User46 = EuclidDist.CalculateImpostorScores(s013Mean, s046);
            impostorScoresUser13User47 = EuclidDist.CalculateImpostorScores(s013Mean, s047);
            impostorScoresUser13User48 = EuclidDist.CalculateImpostorScores(s013Mean, s048);
            impostorScoresUser13User49 = EuclidDist.CalculateImpostorScores(s013Mean, s049);
            impostorScoresUser13User50 = EuclidDist.CalculateImpostorScores(s013Mean, s050);

            impostorScoresUser13User51 = EuclidDist.CalculateImpostorScores(s013Mean, s051);
            impostorScoresUser13User52 = EuclidDist.CalculateImpostorScores(s013Mean, s052);
            impostorScoresUser13User53 = EuclidDist.CalculateImpostorScores(s013Mean, s053);
            impostorScoresUser13User54 = EuclidDist.CalculateImpostorScores(s013Mean, s054);
            impostorScoresUser13User55 = EuclidDist.CalculateImpostorScores(s013Mean, s055);
            impostorScoresUser13User56 = EuclidDist.CalculateImpostorScores(s013Mean, s056);
            impostorScoresUser13User57 = EuclidDist.CalculateImpostorScores(s013Mean, s057);
            impostorScoresUser13User58 = EuclidDist.CalculateImpostorScores(s013Mean, s058);
            impostorScoresUser13User59 = EuclidDist.CalculateImpostorScores(s013Mean, s059);
            impostorScoresUser13User60 = EuclidDist.CalculateImpostorScores(s013Mean, s060);

            impostorScoresUser13User61 = EuclidDist.CalculateImpostorScores(s013Mean, s061);
            impostorScoresUser13User62 = EuclidDist.CalculateImpostorScores(s013Mean, s062);
            impostorScoresUser13User63 = EuclidDist.CalculateImpostorScores(s013Mean, s063);
            impostorScoresUser13User64 = EuclidDist.CalculateImpostorScores(s013Mean, s064);
            impostorScoresUser13User65 = EuclidDist.CalculateImpostorScores(s013Mean, s065);
            impostorScoresUser13User66 = EuclidDist.CalculateImpostorScores(s013Mean, s066);
            impostorScoresUser13User67 = EuclidDist.CalculateImpostorScores(s013Mean, s067);
            impostorScoresUser13User68 = EuclidDist.CalculateImpostorScores(s013Mean, s068);
            impostorScoresUser13User69 = EuclidDist.CalculateImpostorScores(s013Mean, s069);
            impostorScoresUser13User70 = EuclidDist.CalculateImpostorScores(s013Mean, s070);

            impostorScoresUser13User71 = EuclidDist.CalculateImpostorScores(s013Mean, s071);
            impostorScoresUser13User72 = EuclidDist.CalculateImpostorScores(s013Mean, s072);
            impostorScoresUser13User73 = EuclidDist.CalculateImpostorScores(s013Mean, s073);
            impostorScoresUser13User74 = EuclidDist.CalculateImpostorScores(s013Mean, s074);
            impostorScoresUser13User75 = EuclidDist.CalculateImpostorScores(s013Mean, s075);
            impostorScoresUser13User76 = EuclidDist.CalculateImpostorScores(s013Mean, s076);
            impostorScoresUser13User77 = EuclidDist.CalculateImpostorScores(s013Mean, s077);
            impostorScoresUser13User78 = EuclidDist.CalculateImpostorScores(s013Mean, s078);
            impostorScoresUser13User79 = EuclidDist.CalculateImpostorScores(s013Mean, s079);
            impostorScoresUser13User80 = EuclidDist.CalculateImpostorScores(s013Mean, s080);

            impostorScoresUser13User81 = EuclidDist.CalculateImpostorScores(s013Mean, s081);
            impostorScoresuser13User82 = EuclidDist.CalculateImpostorScores(s013Mean, s082);
            impostorScoresUser13User83 = EuclidDist.CalculateImpostorScores(s013Mean, s083);
            impostorScoresUser13User84 = EuclidDist.CalculateImpostorScores(s013Mean, s084);
            impostorScoresUser13User85 = EuclidDist.CalculateImpostorScores(s013Mean, s085);
            impostorScoresUser13User86 = EuclidDist.CalculateImpostorScores(s013Mean, s086);
            impostorScoresUser13User87 = EuclidDist.CalculateImpostorScores(s013Mean, s087);
            impostorScoresUser13User88 = EuclidDist.CalculateImpostorScores(s013Mean, s088);
            impostorScoresUser13User89 = EuclidDist.CalculateImpostorScores(s013Mean, s089);
            impostorScoresUser13User90 = EuclidDist.CalculateImpostorScores(s013Mean, s090);

            impostorScoresUser13User91 = EuclidDist.CalculateImpostorScores(s013Mean, s091);
            impostorScoresUser13User92 = EuclidDist.CalculateImpostorScores(s013Mean, s092);
            impostorScoresUser13User93 = EuclidDist.CalculateImpostorScores(s013Mean, s093);
            impostorScoresUser13User94 = EuclidDist.CalculateImpostorScores(s013Mean, s094);
            impostorScoresUser13User95 = EuclidDist.CalculateImpostorScores(s013Mean, s095);
            impostorScoresUser13User96 = EuclidDist.CalculateImpostorScores(s013Mean, s096);
            impostorScoresUser13User97 = EuclidDist.CalculateImpostorScores(s013Mean, s097);
            impostorScoresUser13User98 = EuclidDist.CalculateImpostorScores(s013Mean, s098);
            impostorScoresUser13User99 = EuclidDist.CalculateImpostorScores(s013Mean, s099);
            impostorScoresUser13User100 = EuclidDist.CalculateImpostorScores(s013Mean, s100);
            #endregion

            #region User 14 Impostor scores
            impostorScoresUser14User1 = EuclidDist.CalculateImpostorScores(s014Mean, s001);
            impostorScoresUser14User2 = EuclidDist.CalculateImpostorScores(s014Mean, s002);
            impostorScoresUser14User3 = EuclidDist.CalculateImpostorScores(s014Mean, s003);
            impostorScoresUser14User4 = EuclidDist.CalculateImpostorScores(s014Mean, s004);
            impostorScoresUser14User5 = EuclidDist.CalculateImpostorScores(s014Mean, s005);
            impostorScoresUser14User6 = EuclidDist.CalculateImpostorScores(s014Mean, s006);
            impostorScoresUser14User7 = EuclidDist.CalculateImpostorScores(s014Mean, s007);
            impostorScoresUser14User8 = EuclidDist.CalculateImpostorScores(s014Mean, s008);
            impostorScoresUser14User9 = EuclidDist.CalculateImpostorScores(s014Mean, s009);
            impostorScoresUser14User10 = EuclidDist.CalculateImpostorScores(s014Mean, s010);

            impostorScoresUser14User11 = EuclidDist.CalculateImpostorScores(s014Mean, s011);
            impostorScoresUser14User12 = EuclidDist.CalculateImpostorScores(s014Mean, s012);
            impostorScoresUser14User13 = EuclidDist.CalculateImpostorScores(s014Mean, s013);
            impostorScoresUser14User15 = EuclidDist.CalculateImpostorScores(s014Mean, s015);
            impostorScoresUser14User16 = EuclidDist.CalculateImpostorScores(s014Mean, s016);
            impostorScoresUser14User17 = EuclidDist.CalculateImpostorScores(s014Mean, s017);
            impostorScoresUser14User18 = EuclidDist.CalculateImpostorScores(s014Mean, s018);
            impostorScoresUser14User19 = EuclidDist.CalculateImpostorScores(s014Mean, s019);
            impostorScoresUser14User20 = EuclidDist.CalculateImpostorScores(s014Mean, s020);

            impostorScoresUser14User21 = EuclidDist.CalculateImpostorScores(s014Mean, s021);
            impostorScoresUser14User22 = EuclidDist.CalculateImpostorScores(s014Mean, s022);
            impostorScoresUser14User23 = EuclidDist.CalculateImpostorScores(s014Mean, s023);
            impostorScoresUser14User24 = EuclidDist.CalculateImpostorScores(s014Mean, s024);
            impostorScoresUser14User25 = EuclidDist.CalculateImpostorScores(s014Mean, s025);
            impostorScoresUser14User26 = EuclidDist.CalculateImpostorScores(s014Mean, s026);
            impostorScoresUser14User27 = EuclidDist.CalculateImpostorScores(s014Mean, s027);
            impostorScoresUser14User28 = EuclidDist.CalculateImpostorScores(s014Mean, s028);
            impostorScoresUser14User29 = EuclidDist.CalculateImpostorScores(s014Mean, s029);
            impostorScoresUser14User30 = EuclidDist.CalculateImpostorScores(s014Mean, s030);

            impostorScoresUser14User31 = EuclidDist.CalculateImpostorScores(s014Mean, s031);
            impostorScoresUser14User32 = EuclidDist.CalculateImpostorScores(s014Mean, s032);
            impostorScoresUser14User33 = EuclidDist.CalculateImpostorScores(s014Mean, s033);
            impostorScoresUser14User34 = EuclidDist.CalculateImpostorScores(s014Mean, s034);
            impostorScoresUser14User35 = EuclidDist.CalculateImpostorScores(s014Mean, s035);
            impostorScoresUser14User36 = EuclidDist.CalculateImpostorScores(s014Mean, s036);
            impostorScoresUser14User37 = EuclidDist.CalculateImpostorScores(s014Mean, s037);
            impostorScoresUser14User38 = EuclidDist.CalculateImpostorScores(s014Mean, s038);
            impostorScoresUser14User39 = EuclidDist.CalculateImpostorScores(s014Mean, s039);
            impostorScoresUser14User40 = EuclidDist.CalculateImpostorScores(s014Mean, s040);

            impostorScoresUser14User41 = EuclidDist.CalculateImpostorScores(s014Mean, s041);
            impostorScoresUser14User42 = EuclidDist.CalculateImpostorScores(s014Mean, s042);
            impostorScoresUser14User43 = EuclidDist.CalculateImpostorScores(s014Mean, s043);
            impostorScoresUser14User44 = EuclidDist.CalculateImpostorScores(s014Mean, s044);
            impostorScoresUser14User45 = EuclidDist.CalculateImpostorScores(s014Mean, s045);
            impostorScoresUser14User46 = EuclidDist.CalculateImpostorScores(s014Mean, s046);
            impostorScoresUser14User47 = EuclidDist.CalculateImpostorScores(s014Mean, s047);
            impostorScoresUser14User48 = EuclidDist.CalculateImpostorScores(s014Mean, s048);
            impostorScoresUser14User49 = EuclidDist.CalculateImpostorScores(s014Mean, s049);
            impostorScoresUser14User50 = EuclidDist.CalculateImpostorScores(s014Mean, s050);

            impostorScoresUser14User51 = EuclidDist.CalculateImpostorScores(s014Mean, s051);
            impostorScoresUser14User52 = EuclidDist.CalculateImpostorScores(s014Mean, s052);
            impostorScoresUser14User53 = EuclidDist.CalculateImpostorScores(s014Mean, s053);
            impostorScoresUser14User54 = EuclidDist.CalculateImpostorScores(s014Mean, s054);
            impostorScoresUser14User55 = EuclidDist.CalculateImpostorScores(s014Mean, s055);
            impostorScoresUser14User56 = EuclidDist.CalculateImpostorScores(s014Mean, s056);
            impostorScoresUser14User57 = EuclidDist.CalculateImpostorScores(s014Mean, s057);
            impostorScoresUser14User58 = EuclidDist.CalculateImpostorScores(s014Mean, s058);
            impostorScoresUser14User59 = EuclidDist.CalculateImpostorScores(s014Mean, s059);
            impostorScoresUser14User60 = EuclidDist.CalculateImpostorScores(s014Mean, s060);

            impostorScoresUser14User61 = EuclidDist.CalculateImpostorScores(s014Mean, s061);
            impostorScoresUser14User62 = EuclidDist.CalculateImpostorScores(s014Mean, s062);
            impostorScoresUser14User63 = EuclidDist.CalculateImpostorScores(s014Mean, s063);
            impostorScoresUser14User64 = EuclidDist.CalculateImpostorScores(s014Mean, s064);
            impostorScoresUser14User65 = EuclidDist.CalculateImpostorScores(s014Mean, s065);
            impostorScoresUser14User66 = EuclidDist.CalculateImpostorScores(s014Mean, s066);
            impostorScoresUser14User67 = EuclidDist.CalculateImpostorScores(s014Mean, s067);
            impostorScoresUser14User68 = EuclidDist.CalculateImpostorScores(s014Mean, s068);
            impostorScoresUser14User69 = EuclidDist.CalculateImpostorScores(s014Mean, s069);
            impostorScoresUser14User70 = EuclidDist.CalculateImpostorScores(s014Mean, s070);

            impostorScoresUser14User71 = EuclidDist.CalculateImpostorScores(s014Mean, s071);
            impostorScoresUser14User72 = EuclidDist.CalculateImpostorScores(s014Mean, s072);
            impostorScoresUser14User73 = EuclidDist.CalculateImpostorScores(s014Mean, s073);
            impostorScoresUser14User74 = EuclidDist.CalculateImpostorScores(s014Mean, s074);
            impostorScoresUser14User75 = EuclidDist.CalculateImpostorScores(s014Mean, s075);
            impostorScoresUser14User76 = EuclidDist.CalculateImpostorScores(s014Mean, s076);
            impostorScoresUser14User77 = EuclidDist.CalculateImpostorScores(s014Mean, s077);
            impostorScoresUser14User78 = EuclidDist.CalculateImpostorScores(s014Mean, s078);
            impostorScoresUser14User79 = EuclidDist.CalculateImpostorScores(s014Mean, s079);
            impostorScoresUser14User80 = EuclidDist.CalculateImpostorScores(s014Mean, s080);

            impostorScoresUser14User81 = EuclidDist.CalculateImpostorScores(s014Mean, s081);
            impostorScoresUser14User82 = EuclidDist.CalculateImpostorScores(s014Mean, s082);
            impostorScoresUser14User83 = EuclidDist.CalculateImpostorScores(s014Mean, s083);
            impostorScoresUser14User84 = EuclidDist.CalculateImpostorScores(s014Mean, s084);
            impostorScoresUser14User85 = EuclidDist.CalculateImpostorScores(s014Mean, s085);
            impostorScoresUser14User86 = EuclidDist.CalculateImpostorScores(s014Mean, s086);
            impostorScoresUser14User87 = EuclidDist.CalculateImpostorScores(s014Mean, s087);
            impostorScoresUser14User88 = EuclidDist.CalculateImpostorScores(s014Mean, s088);
            impostorScoresUser14User89 = EuclidDist.CalculateImpostorScores(s014Mean, s089);
            impostorScoresUser14User90 = EuclidDist.CalculateImpostorScores(s014Mean, s090);

            impostorScoresUser14User91 = EuclidDist.CalculateImpostorScores(s014Mean, s091);
            impostorScoresUser14User92 = EuclidDist.CalculateImpostorScores(s014Mean, s092);
            impostorScoresUser14User93 = EuclidDist.CalculateImpostorScores(s014Mean, s093);
            impostorScoresUser14User94 = EuclidDist.CalculateImpostorScores(s014Mean, s094);
            impostorScoresUser14User95 = EuclidDist.CalculateImpostorScores(s014Mean, s095);
            impostorScoresUser14User96 = EuclidDist.CalculateImpostorScores(s014Mean, s096);
            impostorScoresUser14User97 = EuclidDist.CalculateImpostorScores(s014Mean, s097);
            impostorScoresUser14User98 = EuclidDist.CalculateImpostorScores(s014Mean, s098);
            impostorScoresUser14User99 = EuclidDist.CalculateImpostorScores(s014Mean, s099);
            impostorScoresUser14User100 = EuclidDist.CalculateImpostorScores(s014Mean, s100);
            #endregion

            #region User 15 Impostor scores
            impostorScoresUser15User1 = EuclidDist.CalculateImpostorScores(s015Mean, s001);
            impostorScoresUser15User2 = EuclidDist.CalculateImpostorScores(s015Mean, s002);
            impostorScoresUser15User3 = EuclidDist.CalculateImpostorScores(s015Mean, s003);
            impostorScoresUser15User4 = EuclidDist.CalculateImpostorScores(s015Mean, s004);
            impostorScoresUser15User5 = EuclidDist.CalculateImpostorScores(s015Mean, s005);
            impostorScoresUser15User6 = EuclidDist.CalculateImpostorScores(s015Mean, s006);
            impostorScoresUser15User7 = EuclidDist.CalculateImpostorScores(s015Mean, s007);
            impostorScoresUser15User8 = EuclidDist.CalculateImpostorScores(s015Mean, s008);
            impostorScoresUser15User9 = EuclidDist.CalculateImpostorScores(s015Mean, s009);
            impostorScoresUser15User10 = EuclidDist.CalculateImpostorScores(s015Mean, s010);

            impostorScoresUser15User11 = EuclidDist.CalculateImpostorScores(s015Mean, s011);
            impostorScoresUser15User12 = EuclidDist.CalculateImpostorScores(s015Mean, s012);
            impostorScoresUser15User13 = EuclidDist.CalculateImpostorScores(s015Mean, s013);
            impostorScoresUser15User14 = EuclidDist.CalculateImpostorScores(s015Mean, s014);
            impostorScoresUser15User16 = EuclidDist.CalculateImpostorScores(s015Mean, s016);
            impostorScoresUser15User17 = EuclidDist.CalculateImpostorScores(s015Mean, s017);
            impostorScoresUser15User18 = EuclidDist.CalculateImpostorScores(s015Mean, s018);
            impostorScoresUser15User19 = EuclidDist.CalculateImpostorScores(s015Mean, s019);
            impostorScoresUser15User20 = EuclidDist.CalculateImpostorScores(s015Mean, s020);

            impostorScoresUser15User21 = EuclidDist.CalculateImpostorScores(s015Mean, s021);
            impostorScoresUser15User22 = EuclidDist.CalculateImpostorScores(s015Mean, s022);
            impostorScoresUser15User23 = EuclidDist.CalculateImpostorScores(s015Mean, s023);
            impostorScoresUser15User24 = EuclidDist.CalculateImpostorScores(s015Mean, s024);
            impostorScoresUser15User25 = EuclidDist.CalculateImpostorScores(s015Mean, s025);
            impostorScoresUser15User26 = EuclidDist.CalculateImpostorScores(s015Mean, s026);
            impostorScoresUser15User27 = EuclidDist.CalculateImpostorScores(s015Mean, s027);
            impostorScoresUser15User28 = EuclidDist.CalculateImpostorScores(s015Mean, s028);
            impostorScoresUser15User29 = EuclidDist.CalculateImpostorScores(s015Mean, s029);
            impostorScoresUser15User30 = EuclidDist.CalculateImpostorScores(s015Mean, s030);

            impostorScoresUser15User31 = EuclidDist.CalculateImpostorScores(s015Mean, s031);
            impostorScoresUser15User32 = EuclidDist.CalculateImpostorScores(s015Mean, s032);
            impostorScoresUser15User33 = EuclidDist.CalculateImpostorScores(s015Mean, s033);
            impostorScoresUser15User34 = EuclidDist.CalculateImpostorScores(s015Mean, s034);
            impostorScoresUser15User35 = EuclidDist.CalculateImpostorScores(s015Mean, s035);
            impostorScoresUser15User36 = EuclidDist.CalculateImpostorScores(s015Mean, s036);
            impostorScoresUser15User37 = EuclidDist.CalculateImpostorScores(s015Mean, s037);
            impostorScoresUser15User38 = EuclidDist.CalculateImpostorScores(s015Mean, s038);
            impostorScoresUser15User39 = EuclidDist.CalculateImpostorScores(s015Mean, s039);
            impostorScoresUser15User40 = EuclidDist.CalculateImpostorScores(s015Mean, s040);

            impostorScoresUser15User41 = EuclidDist.CalculateImpostorScores(s015Mean, s041);
            impostorScoresUser15User42 = EuclidDist.CalculateImpostorScores(s015Mean, s042);
            impostorScoresUser15User43 = EuclidDist.CalculateImpostorScores(s015Mean, s043);
            impostorScoresUser15User44 = EuclidDist.CalculateImpostorScores(s015Mean, s044);
            impostorScoresUser15User45 = EuclidDist.CalculateImpostorScores(s015Mean, s045);
            impostorScoresUser15User46 = EuclidDist.CalculateImpostorScores(s015Mean, s046);
            impostorScoresUser15User47 = EuclidDist.CalculateImpostorScores(s015Mean, s047);
            impostorScoresUser15User48 = EuclidDist.CalculateImpostorScores(s015Mean, s048);
            impostorScoresUser15User49 = EuclidDist.CalculateImpostorScores(s015Mean, s049);
            impostorScoresUser15User50 = EuclidDist.CalculateImpostorScores(s015Mean, s050);

            impostorScoresUser15User51 = EuclidDist.CalculateImpostorScores(s015Mean, s051);
            impostorScoresUser15User52 = EuclidDist.CalculateImpostorScores(s015Mean, s052);
            impostorScoresUser15User53 = EuclidDist.CalculateImpostorScores(s015Mean, s053);
            impostorScoresUser15User54 = EuclidDist.CalculateImpostorScores(s015Mean, s054);
            impostorScoresUser15User55 = EuclidDist.CalculateImpostorScores(s015Mean, s055);
            impostorScoresUser15User56 = EuclidDist.CalculateImpostorScores(s015Mean, s056);
            impostorScoresUser15User57 = EuclidDist.CalculateImpostorScores(s015Mean, s057);
            impostorScoresUser15User58 = EuclidDist.CalculateImpostorScores(s015Mean, s058);
            impostorScoresUser15User59 = EuclidDist.CalculateImpostorScores(s015Mean, s059);
            impostorScoresUser15User60 = EuclidDist.CalculateImpostorScores(s015Mean, s060);

            impostorScoresUser15User61 = EuclidDist.CalculateImpostorScores(s015Mean, s061);
            impostorScoresUser15User62 = EuclidDist.CalculateImpostorScores(s015Mean, s062);
            impostorScoresUser15User63 = EuclidDist.CalculateImpostorScores(s015Mean, s063);
            impostorScoresUser15User64 = EuclidDist.CalculateImpostorScores(s015Mean, s064);
            impostorScoresUser15User65 = EuclidDist.CalculateImpostorScores(s015Mean, s065);
            impostorScoresUser15User66 = EuclidDist.CalculateImpostorScores(s015Mean, s066);
            impostorScoresUser15User67 = EuclidDist.CalculateImpostorScores(s015Mean, s067);
            impostorScoresUser15User68 = EuclidDist.CalculateImpostorScores(s015Mean, s068);
            impostorScoresUser15User69 = EuclidDist.CalculateImpostorScores(s015Mean, s069);
            impostorScoresUser15User70 = EuclidDist.CalculateImpostorScores(s015Mean, s070);

            impostorScoresUser15User71 = EuclidDist.CalculateImpostorScores(s015Mean, s071);
            impostorScoresUser15User72 = EuclidDist.CalculateImpostorScores(s015Mean, s072);
            impostorScoresUser15User73 = EuclidDist.CalculateImpostorScores(s015Mean, s073);
            impostorScoresUser15User74 = EuclidDist.CalculateImpostorScores(s015Mean, s074);
            impostorScoresUser15User75 = EuclidDist.CalculateImpostorScores(s015Mean, s075);
            impostorScoresUser15User76 = EuclidDist.CalculateImpostorScores(s015Mean, s076);
            impostorScoresUser15User77 = EuclidDist.CalculateImpostorScores(s015Mean, s077);
            impostorScoresUser15User78 = EuclidDist.CalculateImpostorScores(s015Mean, s078);
            impostorScoresUser15User79 = EuclidDist.CalculateImpostorScores(s015Mean, s079);
            impostorScoresUser15User80 = EuclidDist.CalculateImpostorScores(s015Mean, s080);

            impostorScoresUser15User81 = EuclidDist.CalculateImpostorScores(s015Mean, s081);
            impostorScoresUser15User82 = EuclidDist.CalculateImpostorScores(s015Mean, s082);
            impostorScoresUser15User83 = EuclidDist.CalculateImpostorScores(s015Mean, s083);
            impostorScoresUser15User84 = EuclidDist.CalculateImpostorScores(s015Mean, s084);
            impostorScoresUser15User85 = EuclidDist.CalculateImpostorScores(s015Mean, s085);
            impostorScoresUser15User86 = EuclidDist.CalculateImpostorScores(s015Mean, s086);
            impostorScoresUser15User87 = EuclidDist.CalculateImpostorScores(s015Mean, s087);
            impostorScoresUser15User88 = EuclidDist.CalculateImpostorScores(s015Mean, s088);
            impostorScoresUser15User89 = EuclidDist.CalculateImpostorScores(s015Mean, s089);
            impostorScoresUser15User90 = EuclidDist.CalculateImpostorScores(s015Mean, s090);

            impostorScoresUser15User91 = EuclidDist.CalculateImpostorScores(s015Mean, s091);
            impostorScoresUser15User92 = EuclidDist.CalculateImpostorScores(s015Mean, s092);
            impostorScoresUser15User93 = EuclidDist.CalculateImpostorScores(s015Mean, s093);
            impostorScoresUser15User94 = EuclidDist.CalculateImpostorScores(s015Mean, s094);
            impostorScoresUser15User95 = EuclidDist.CalculateImpostorScores(s015Mean, s095);
            impostorScoresUser15User96 = EuclidDist.CalculateImpostorScores(s015Mean, s096);
            impostorScoresUser15User97 = EuclidDist.CalculateImpostorScores(s015Mean, s097);
            impostorScoresUser15User98 = EuclidDist.CalculateImpostorScores(s015Mean, s098);
            impostorScoresUser15User99 = EuclidDist.CalculateImpostorScores(s015Mean, s099);
            impostorScoresUser15User100 = EuclidDist.CalculateImpostorScores(s015Mean, s100); 
            #endregion

            #region User 16 Impostor scores
            impostorScoresUser16User1 = EuclidDist.CalculateImpostorScores(s016Mean, s001);
            impostorScoresUser16User2 = EuclidDist.CalculateImpostorScores(s016Mean, s002);
            impostorScoresUser16User3 = EuclidDist.CalculateImpostorScores(s016Mean, s003);
            impostorScoresUser16User4 = EuclidDist.CalculateImpostorScores(s016Mean, s004);
            impostorScoresUser16User5 = EuclidDist.CalculateImpostorScores(s016Mean, s005);
            impostorScoresUser16User6 = EuclidDist.CalculateImpostorScores(s016Mean, s006);
            impostorScoresUser16User7 = EuclidDist.CalculateImpostorScores(s016Mean, s007);
            impostorScoresUser16User8 = EuclidDist.CalculateImpostorScores(s016Mean, s008);
            impostorScoresUser16User9 = EuclidDist.CalculateImpostorScores(s016Mean, s009);
            impostorScoresUser16User10 = EuclidDist.CalculateImpostorScores(s016Mean, s010);

            impostorScoresUser16User11 = EuclidDist.CalculateImpostorScores(s016Mean, s011);
            impostorScoresUser16User12 = EuclidDist.CalculateImpostorScores(s016Mean, s012);
            impostorScoresUser16User13 = EuclidDist.CalculateImpostorScores(s016Mean, s013);
            impostorScoresUser16User14 = EuclidDist.CalculateImpostorScores(s016Mean, s014);
            impostorScoresUser16User15 = EuclidDist.CalculateImpostorScores(s016Mean, s015);
            impostorScoresUser16User17 = EuclidDist.CalculateImpostorScores(s016Mean, s017);
            impostorScoresUser16User18 = EuclidDist.CalculateImpostorScores(s016Mean, s018);
            impostorScoresUser16User19 = EuclidDist.CalculateImpostorScores(s016Mean, s019);
            impostorScoresUser16User20 = EuclidDist.CalculateImpostorScores(s016Mean, s020);

            impostorScoresUser16User21 = EuclidDist.CalculateImpostorScores(s016Mean, s021);
            impostorScoresUser16User22 = EuclidDist.CalculateImpostorScores(s016Mean, s022);
            impostorScoresUser16User23 = EuclidDist.CalculateImpostorScores(s016Mean, s023);
            impostorScoresUser16User24 = EuclidDist.CalculateImpostorScores(s016Mean, s024);
            impostorScoresUser16User25 = EuclidDist.CalculateImpostorScores(s016Mean, s025);
            impostorScoresUser16User26 = EuclidDist.CalculateImpostorScores(s016Mean, s026);
            impostorScoresUser16User27 = EuclidDist.CalculateImpostorScores(s016Mean, s027);
            impostorScoresUser16User28 = EuclidDist.CalculateImpostorScores(s016Mean, s028);
            impostorScoresUser16User29 = EuclidDist.CalculateImpostorScores(s016Mean, s029);
            impostorScoresUser16User30 = EuclidDist.CalculateImpostorScores(s016Mean, s030);

            impostorScoresUser16User31 = EuclidDist.CalculateImpostorScores(s016Mean, s031);
            impostorScoresUser16User32 = EuclidDist.CalculateImpostorScores(s016Mean, s032);
            impostorScoresUser16User33 = EuclidDist.CalculateImpostorScores(s016Mean, s033);
            impostorScoresUser16User34 = EuclidDist.CalculateImpostorScores(s016Mean, s034);
            impostorScoresUser16User35 = EuclidDist.CalculateImpostorScores(s016Mean, s035);
            impostorScoresUser16User36 = EuclidDist.CalculateImpostorScores(s016Mean, s036);
            impostorScoresUser16User37 = EuclidDist.CalculateImpostorScores(s016Mean, s037);
            impostorScoresUser16User38 = EuclidDist.CalculateImpostorScores(s016Mean, s038);
            impostorScoresUser16User39 = EuclidDist.CalculateImpostorScores(s016Mean, s039);
            impostorScoresUser16User40 = EuclidDist.CalculateImpostorScores(s016Mean, s040);

            impostorScoresUser16User41 = EuclidDist.CalculateImpostorScores(s016Mean, s041);
            impostorScoresUser16User42 = EuclidDist.CalculateImpostorScores(s016Mean, s042);
            impostorScoresUser16User43 = EuclidDist.CalculateImpostorScores(s016Mean, s043);
            impostorScoresUser16User44 = EuclidDist.CalculateImpostorScores(s016Mean, s044);
            impostorScoresUser16User45 = EuclidDist.CalculateImpostorScores(s016Mean, s045);
            impostorScoresUser16User46 = EuclidDist.CalculateImpostorScores(s016Mean, s046);
            impostorScoresUser16User47 = EuclidDist.CalculateImpostorScores(s016Mean, s047);
            impostorScoresUser16User48 = EuclidDist.CalculateImpostorScores(s016Mean, s048);
            impostorScoresUser16User49 = EuclidDist.CalculateImpostorScores(s016Mean, s049);
            impostorScoresUser16User50 = EuclidDist.CalculateImpostorScores(s016Mean, s050);

            impostorScoresUser16User51 = EuclidDist.CalculateImpostorScores(s016Mean, s051);
            impostorScoresUser16User52 = EuclidDist.CalculateImpostorScores(s016Mean, s052);
            impostorScoresUser16User53 = EuclidDist.CalculateImpostorScores(s016Mean, s053);
            impostorScoresUser16User54 = EuclidDist.CalculateImpostorScores(s016Mean, s054);
            impostorScoresUser16User55 = EuclidDist.CalculateImpostorScores(s016Mean, s055);
            impostorScoresUser16User56 = EuclidDist.CalculateImpostorScores(s016Mean, s056);
            impostorScoresUser16User57 = EuclidDist.CalculateImpostorScores(s016Mean, s057);
            impostorScoresUser16User58 = EuclidDist.CalculateImpostorScores(s016Mean, s058);
            impostorScoresUser16User59 = EuclidDist.CalculateImpostorScores(s016Mean, s059);
            impostorScoresUser16User60 = EuclidDist.CalculateImpostorScores(s016Mean, s060);

            impostorScoresUser16User61 = EuclidDist.CalculateImpostorScores(s016Mean, s061);
            impostorScoresUser16User62 = EuclidDist.CalculateImpostorScores(s016Mean, s062);
            impostorScoresUser16User63 = EuclidDist.CalculateImpostorScores(s016Mean, s063);
            impostorScoresUser16User64 = EuclidDist.CalculateImpostorScores(s016Mean, s064);
            impostorScoresUser16User65 = EuclidDist.CalculateImpostorScores(s016Mean, s065);
            impostorScoresUser16User66 = EuclidDist.CalculateImpostorScores(s016Mean, s066);
            impostorScoresUser16User67 = EuclidDist.CalculateImpostorScores(s016Mean, s067);
            impostorScoresUser16User68 = EuclidDist.CalculateImpostorScores(s016Mean, s068);
            impostorScoresUser16User69 = EuclidDist.CalculateImpostorScores(s016Mean, s069);
            impostorScoresUser16User70 = EuclidDist.CalculateImpostorScores(s016Mean, s070);

            impostorScoresUser16User71 = EuclidDist.CalculateImpostorScores(s016Mean, s071);
            impostorScoresUser16User72 = EuclidDist.CalculateImpostorScores(s016Mean, s072);
            impostorScoresUser16User73 = EuclidDist.CalculateImpostorScores(s016Mean, s073);
            impostorScoresUser16User74 = EuclidDist.CalculateImpostorScores(s016Mean, s074);
            impostorScoresUser16User75 = EuclidDist.CalculateImpostorScores(s016Mean, s075);
            impostorScoresUser16User76 = EuclidDist.CalculateImpostorScores(s016Mean, s076);
            impostorScoresUser16User77 = EuclidDist.CalculateImpostorScores(s016Mean, s077);
            impostorScoresUser16User78 = EuclidDist.CalculateImpostorScores(s016Mean, s078);
            impostorScoresUser16User79 = EuclidDist.CalculateImpostorScores(s016Mean, s079);
            impostorScoresUser16User80 = EuclidDist.CalculateImpostorScores(s016Mean, s080);

            impostorScoresUser16User81 = EuclidDist.CalculateImpostorScores(s016Mean, s081);
            impostorScoresUser16User82 = EuclidDist.CalculateImpostorScores(s016Mean, s082);
            impostorScoresUser16User83 = EuclidDist.CalculateImpostorScores(s016Mean, s083);
            impostorScoresUser16User84 = EuclidDist.CalculateImpostorScores(s016Mean, s084);
            impostorScoresUser16User85 = EuclidDist.CalculateImpostorScores(s016Mean, s085);
            impostorScoresUser16User86 = EuclidDist.CalculateImpostorScores(s016Mean, s086);
            impostorScoresUser16User87 = EuclidDist.CalculateImpostorScores(s016Mean, s087);
            impostorScoresUser16User88 = EuclidDist.CalculateImpostorScores(s016Mean, s088);
            impostorScoresUser16User89 = EuclidDist.CalculateImpostorScores(s016Mean, s089);
            impostorScoresUser16User90 = EuclidDist.CalculateImpostorScores(s016Mean, s090);

            impostorScoresUser16User91 = EuclidDist.CalculateImpostorScores(s016Mean, s091);
            impostorScoresUser16User92 = EuclidDist.CalculateImpostorScores(s016Mean, s092);
            impostorScoresUser16User93 = EuclidDist.CalculateImpostorScores(s016Mean, s093);
            impostorScoresUser16User94 = EuclidDist.CalculateImpostorScores(s016Mean, s094);
            impostorScoresUser16User95 = EuclidDist.CalculateImpostorScores(s016Mean, s095);
            impostorScoresUser16User96 = EuclidDist.CalculateImpostorScores(s016Mean, s096);
            impostorScoresUser16User97 = EuclidDist.CalculateImpostorScores(s016Mean, s097);
            impostorScoresUser16User98 = EuclidDist.CalculateImpostorScores(s016Mean, s098);
            impostorScoresUser16User99 = EuclidDist.CalculateImpostorScores(s016Mean, s099);
            impostorScoresUser16User100 = EuclidDist.CalculateImpostorScores(s016Mean, s100);
            #endregion

            #region User 17 Impostor scores
            impostorScoresUser17User1 = EuclidDist.CalculateImpostorScores(s017Mean, s001);
            impostorScoresUser17User2 = EuclidDist.CalculateImpostorScores(s017Mean, s002);
            impostorScoresUser17User3 = EuclidDist.CalculateImpostorScores(s017Mean, s003);
            impostorScoresUser17User4 = EuclidDist.CalculateImpostorScores(s017Mean, s004);
            impostorScoresUser17User5 = EuclidDist.CalculateImpostorScores(s017Mean, s005);
            impostorScoresUser17User6 = EuclidDist.CalculateImpostorScores(s017Mean, s006);
            impostorScoresUser17User7 = EuclidDist.CalculateImpostorScores(s017Mean, s007);
            impostorScoresUser17User8 = EuclidDist.CalculateImpostorScores(s017Mean, s008);
            impostorScoresUser17User9 = EuclidDist.CalculateImpostorScores(s017Mean, s009);
            impostorScoresUser17User10 = EuclidDist.CalculateImpostorScores(s017Mean, s010);

            impostorScoresUser17User11 = EuclidDist.CalculateImpostorScores(s017Mean, s011);
            impostorScoresUser17User12 = EuclidDist.CalculateImpostorScores(s017Mean, s012);
            impostorScoresUser17User13 = EuclidDist.CalculateImpostorScores(s017Mean, s013);
            impostorScoresUser17User14 = EuclidDist.CalculateImpostorScores(s017Mean, s014);
            impostorScoresUser17User15 = EuclidDist.CalculateImpostorScores(s017Mean, s015);
            impostorScoresUser17User16 = EuclidDist.CalculateImpostorScores(s017Mean, s016);
            impostorScoresUser17User18 = EuclidDist.CalculateImpostorScores(s017Mean, s018);
            impostorScoresUser17User19 = EuclidDist.CalculateImpostorScores(s017Mean, s019);
            impostorScoresUser17User20 = EuclidDist.CalculateImpostorScores(s017Mean, s020);

            impostorScoresUser17User21 = EuclidDist.CalculateImpostorScores(s017Mean, s021);
            impostorScoresUser17User22 = EuclidDist.CalculateImpostorScores(s017Mean, s022);
            impostorScoresUser17User23 = EuclidDist.CalculateImpostorScores(s017Mean, s023);
            impostorScoresUser17User24 = EuclidDist.CalculateImpostorScores(s017Mean, s024);
            impostorScoresUser17User25 = EuclidDist.CalculateImpostorScores(s017Mean, s025);
            impostorScoresUser17User26 = EuclidDist.CalculateImpostorScores(s017Mean, s026);
            impostorScoresUser17User27 = EuclidDist.CalculateImpostorScores(s017Mean, s027);
            impostorScoresUser17User28 = EuclidDist.CalculateImpostorScores(s017Mean, s028);
            impostorScoresUser17User29 = EuclidDist.CalculateImpostorScores(s017Mean, s029);
            impostorScoresUser17User30 = EuclidDist.CalculateImpostorScores(s017Mean, s030);

            impostorScoresUser17User31 = EuclidDist.CalculateImpostorScores(s017Mean, s031);
            impostorScoresUser17User32 = EuclidDist.CalculateImpostorScores(s017Mean, s032);
            impostorScoresUser17User33 = EuclidDist.CalculateImpostorScores(s017Mean, s033);
            impostorScoresUser17User34 = EuclidDist.CalculateImpostorScores(s017Mean, s034);
            impostorScoresUser17User35 = EuclidDist.CalculateImpostorScores(s017Mean, s035);
            impostorScoresUser17User36 = EuclidDist.CalculateImpostorScores(s017Mean, s036);
            impostorScoresUser17User37 = EuclidDist.CalculateImpostorScores(s017Mean, s037);
            impostorScoresUser17User38 = EuclidDist.CalculateImpostorScores(s017Mean, s038);
            impostorScoresUser17User39 = EuclidDist.CalculateImpostorScores(s017Mean, s039);
            impostorScoresUser17User40 = EuclidDist.CalculateImpostorScores(s017Mean, s040);

            impostorScoresUser17User41 = EuclidDist.CalculateImpostorScores(s017Mean, s041);
            impostorScoresUser17User42 = EuclidDist.CalculateImpostorScores(s017Mean, s042);
            impostorScoresUser17User43 = EuclidDist.CalculateImpostorScores(s017Mean, s043);
            impostorScoresUser17User44 = EuclidDist.CalculateImpostorScores(s017Mean, s044);
            impostorScoresUser17User45 = EuclidDist.CalculateImpostorScores(s017Mean, s045);
            impostorScoresUser17User46 = EuclidDist.CalculateImpostorScores(s017Mean, s046);
            impostorScoresUser17User47 = EuclidDist.CalculateImpostorScores(s017Mean, s047);
            impostorScoresUser17User48 = EuclidDist.CalculateImpostorScores(s017Mean, s048);
            impostorScoresUser17User49 = EuclidDist.CalculateImpostorScores(s017Mean, s049);
            impostorScoresUser17User50 = EuclidDist.CalculateImpostorScores(s017Mean, s050);

            impostorScoresUser17User51 = EuclidDist.CalculateImpostorScores(s017Mean, s051);
            impostorScoresUser17User52 = EuclidDist.CalculateImpostorScores(s017Mean, s052);
            impostorScoresUser17User53 = EuclidDist.CalculateImpostorScores(s017Mean, s053);
            impostorScoresUser17User54 = EuclidDist.CalculateImpostorScores(s017Mean, s054);
            impostorScoresUser17User55 = EuclidDist.CalculateImpostorScores(s017Mean, s055);
            impostorScoresUser17User56 = EuclidDist.CalculateImpostorScores(s017Mean, s056);
            impostorScoresUser17User57 = EuclidDist.CalculateImpostorScores(s017Mean, s057);
            impostorScoresUser17User58 = EuclidDist.CalculateImpostorScores(s017Mean, s058);
            impostorScoresUser17User59 = EuclidDist.CalculateImpostorScores(s017Mean, s059);
            impostorScoresUser17User60 = EuclidDist.CalculateImpostorScores(s017Mean, s060);

            impostorScoresUser17User61 = EuclidDist.CalculateImpostorScores(s017Mean, s061);
            impostorScoresUser17User62 = EuclidDist.CalculateImpostorScores(s017Mean, s062);
            impostorScoresUser17User63 = EuclidDist.CalculateImpostorScores(s017Mean, s063);
            impostorScoresUser17User64 = EuclidDist.CalculateImpostorScores(s017Mean, s064);
            impostorScoresUser17User65 = EuclidDist.CalculateImpostorScores(s017Mean, s065);
            impostorScoresUser17User66 = EuclidDist.CalculateImpostorScores(s017Mean, s066);
            impostorScoresUser17User67 = EuclidDist.CalculateImpostorScores(s017Mean, s067);
            impostorScoresUser17User68 = EuclidDist.CalculateImpostorScores(s017Mean, s068);
            impostorScoresUser17User69 = EuclidDist.CalculateImpostorScores(s017Mean, s069);
            impostorScoresUser17User70 = EuclidDist.CalculateImpostorScores(s017Mean, s070);

            impostorScoresUser17User71 = EuclidDist.CalculateImpostorScores(s017Mean, s071);
            impostorScoresUser17User72 = EuclidDist.CalculateImpostorScores(s017Mean, s072);
            impostorScoresUser17User73 = EuclidDist.CalculateImpostorScores(s017Mean, s073);
            impostorScoresUser17User74 = EuclidDist.CalculateImpostorScores(s017Mean, s074);
            impostorScoresUser17User75 = EuclidDist.CalculateImpostorScores(s017Mean, s075);
            impostorScoresUser17User76 = EuclidDist.CalculateImpostorScores(s017Mean, s076);
            impostorScoresUser17User77 = EuclidDist.CalculateImpostorScores(s017Mean, s077);
            impostorScoresUser17User78 = EuclidDist.CalculateImpostorScores(s017Mean, s078);
            impostorScoresUser17User79 = EuclidDist.CalculateImpostorScores(s017Mean, s079);
            impostorScoresUser17User80 = EuclidDist.CalculateImpostorScores(s017Mean, s080);

            impostorScoresUser17User81 = EuclidDist.CalculateImpostorScores(s017Mean, s081);
            impostorScoresUser17User82 = EuclidDist.CalculateImpostorScores(s017Mean, s082);
            impostorScoresUser17User83 = EuclidDist.CalculateImpostorScores(s017Mean, s083);
            impostorScoresUser17User84 = EuclidDist.CalculateImpostorScores(s017Mean, s084);
            impostorScoresUser17User85 = EuclidDist.CalculateImpostorScores(s017Mean, s085);
            impostorScoresUser17User86 = EuclidDist.CalculateImpostorScores(s017Mean, s086);
            impostorScoresUser17User87 = EuclidDist.CalculateImpostorScores(s017Mean, s087);
            impostorScoresUser17User88 = EuclidDist.CalculateImpostorScores(s017Mean, s088);
            impostorScoresUser17User89 = EuclidDist.CalculateImpostorScores(s017Mean, s089);
            impostorScoresUser17User90 = EuclidDist.CalculateImpostorScores(s017Mean, s090);

            impostorScoresUser17User91 = EuclidDist.CalculateImpostorScores(s017Mean, s091);
            impostorScoresUser17User92 = EuclidDist.CalculateImpostorScores(s017Mean, s092);
            impostorScoresUser17User93 = EuclidDist.CalculateImpostorScores(s017Mean, s093);
            impostorScoresUser17User94 = EuclidDist.CalculateImpostorScores(s017Mean, s094);
            impostorScoresUser17User95 = EuclidDist.CalculateImpostorScores(s017Mean, s095);
            impostorScoresUser17User96 = EuclidDist.CalculateImpostorScores(s017Mean, s096);
            impostorScoresUser17User97 = EuclidDist.CalculateImpostorScores(s017Mean, s097);
            impostorScoresUser17User98 = EuclidDist.CalculateImpostorScores(s017Mean, s098);
            impostorScoresUser17User99 = EuclidDist.CalculateImpostorScores(s017Mean, s099);
            impostorScoresUser17User100 = EuclidDist.CalculateImpostorScores(s017Mean, s100);
            #endregion

            #region User 18 Impostor scores
            impostorScoresUser18User1 = EuclidDist.CalculateImpostorScores(s018Mean, s001);
            impostorScoresUser18User2 = EuclidDist.CalculateImpostorScores(s018Mean, s002);
            impostorScoresUser18User3 = EuclidDist.CalculateImpostorScores(s018Mean, s003);
            impostorScoresUser18User4 = EuclidDist.CalculateImpostorScores(s018Mean, s004);
            impostorScoresUser18User5 = EuclidDist.CalculateImpostorScores(s018Mean, s005);
            impostorScoresUser18User6 = EuclidDist.CalculateImpostorScores(s018Mean, s006);
            impostorScoresUser18User7 = EuclidDist.CalculateImpostorScores(s018Mean, s007);
            impostorScoresUser18User8 = EuclidDist.CalculateImpostorScores(s018Mean, s008);
            impostorScoresUser18User9 = EuclidDist.CalculateImpostorScores(s018Mean, s009);
            impostorScoresUser18User10 = EuclidDist.CalculateImpostorScores(s018Mean, s010);

            impostorScoresUser18User11 = EuclidDist.CalculateImpostorScores(s018Mean, s011);
            impostorScoresUser18User12 = EuclidDist.CalculateImpostorScores(s018Mean, s012);
            impostorScoresUser18User13 = EuclidDist.CalculateImpostorScores(s018Mean, s013);
            impostorScoresUser18User14 = EuclidDist.CalculateImpostorScores(s018Mean, s014);
            impostorScoresUser18User15 = EuclidDist.CalculateImpostorScores(s018Mean, s015);
            impostorScoresUser18User16 = EuclidDist.CalculateImpostorScores(s018Mean, s016);
            impostorScoresUser18User17 = EuclidDist.CalculateImpostorScores(s018Mean, s017);
            impostorScoresUser18User19 = EuclidDist.CalculateImpostorScores(s018Mean, s019);
            impostorScoresUser18User20 = EuclidDist.CalculateImpostorScores(s018Mean, s020);

            impostorScoresUser18User21 = EuclidDist.CalculateImpostorScores(s018Mean, s021);
            impostorScoresUser18User22 = EuclidDist.CalculateImpostorScores(s018Mean, s022);
            impostorScoresUser18User23 = EuclidDist.CalculateImpostorScores(s018Mean, s023);
            impostorScoresUser18User24 = EuclidDist.CalculateImpostorScores(s018Mean, s024);
            impostorScoresUser18User25 = EuclidDist.CalculateImpostorScores(s018Mean, s025);
            impostorScoresUser18User26 = EuclidDist.CalculateImpostorScores(s018Mean, s026);
            impostorScoresUser18User27 = EuclidDist.CalculateImpostorScores(s018Mean, s027);
            impostorScoresUser18User28 = EuclidDist.CalculateImpostorScores(s018Mean, s028);
            impostorScoresUser18User29 = EuclidDist.CalculateImpostorScores(s018Mean, s029);
            impostorScoresUser18User30 = EuclidDist.CalculateImpostorScores(s018Mean, s030);

            impostorScoresUser18User31 = EuclidDist.CalculateImpostorScores(s018Mean, s031);
            impostorScoresUser18User32 = EuclidDist.CalculateImpostorScores(s018Mean, s032);
            impostorScoresUser18User33 = EuclidDist.CalculateImpostorScores(s018Mean, s033);
            impostorScoresUser18User34 = EuclidDist.CalculateImpostorScores(s018Mean, s034);
            impostorScoresUser18User35 = EuclidDist.CalculateImpostorScores(s018Mean, s035);
            impostorScoresUser18User36 = EuclidDist.CalculateImpostorScores(s018Mean, s036);
            impostorScoresUser18User37 = EuclidDist.CalculateImpostorScores(s018Mean, s037);
            impostorScoresUser18User38 = EuclidDist.CalculateImpostorScores(s018Mean, s038);
            impostorScoresUser18User39 = EuclidDist.CalculateImpostorScores(s018Mean, s039);
            impostorScoresUser18User40 = EuclidDist.CalculateImpostorScores(s018Mean, s040);

            impostorScoresUser18User41 = EuclidDist.CalculateImpostorScores(s018Mean, s041);
            impostorScoresUser18User42 = EuclidDist.CalculateImpostorScores(s018Mean, s042);
            impostorScoresUser18User43 = EuclidDist.CalculateImpostorScores(s018Mean, s043);
            impostorScoresUser18User44 = EuclidDist.CalculateImpostorScores(s018Mean, s044);
            impostorScoresUser18User45 = EuclidDist.CalculateImpostorScores(s018Mean, s045);
            impostorScoresUser18User46 = EuclidDist.CalculateImpostorScores(s018Mean, s046);
            impostorScoresUser18User47 = EuclidDist.CalculateImpostorScores(s018Mean, s047);
            impostorScoresUser18User48 = EuclidDist.CalculateImpostorScores(s018Mean, s048);
            impostorScoresUser18User49 = EuclidDist.CalculateImpostorScores(s018Mean, s049);
            impostorScoresUser18User50 = EuclidDist.CalculateImpostorScores(s018Mean, s050);

            impostorScoresUser18User51 = EuclidDist.CalculateImpostorScores(s018Mean, s051);
            impostorScoresUser18User52 = EuclidDist.CalculateImpostorScores(s018Mean, s052);
            impostorScoresUser18User53 = EuclidDist.CalculateImpostorScores(s018Mean, s053);
            impostorScoresUser18User54 = EuclidDist.CalculateImpostorScores(s018Mean, s054);
            impostorScoresUser18User55 = EuclidDist.CalculateImpostorScores(s018Mean, s055);
            impostorScoresUser18User56 = EuclidDist.CalculateImpostorScores(s018Mean, s056);
            impostorScoresUser18User57 = EuclidDist.CalculateImpostorScores(s018Mean, s057);
            impostorScoresUser18User58 = EuclidDist.CalculateImpostorScores(s018Mean, s058);
            impostorScoresUser18User59 = EuclidDist.CalculateImpostorScores(s018Mean, s059);
            impostorScoresUser18User60 = EuclidDist.CalculateImpostorScores(s018Mean, s060);

            impostorScoresUser18User61 = EuclidDist.CalculateImpostorScores(s018Mean, s061);
            impostorScoresUser18User62 = EuclidDist.CalculateImpostorScores(s018Mean, s062);
            impostorScoresUser18User63 = EuclidDist.CalculateImpostorScores(s018Mean, s063);
            impostorScoresUser18User64 = EuclidDist.CalculateImpostorScores(s018Mean, s064);
            impostorScoresUser18User65 = EuclidDist.CalculateImpostorScores(s018Mean, s065);
            impostorScoresUser18User66 = EuclidDist.CalculateImpostorScores(s018Mean, s066);
            impostorScoresUser18User67 = EuclidDist.CalculateImpostorScores(s018Mean, s067);
            impostorScoresUser18User68 = EuclidDist.CalculateImpostorScores(s018Mean, s068);
            impostorScoresUser18User69 = EuclidDist.CalculateImpostorScores(s018Mean, s069);
            impostorScoresUser18User70 = EuclidDist.CalculateImpostorScores(s018Mean, s070);

            impostorScoresUser18User71 = EuclidDist.CalculateImpostorScores(s018Mean, s071);
            impostorScoresUser18User72 = EuclidDist.CalculateImpostorScores(s018Mean, s072);
            impostorScoresUser18User73 = EuclidDist.CalculateImpostorScores(s018Mean, s073);
            impostorScoresUser18User74 = EuclidDist.CalculateImpostorScores(s018Mean, s074);
            impostorScoresUser18User75 = EuclidDist.CalculateImpostorScores(s018Mean, s075);
            impostorScoresUser18User76 = EuclidDist.CalculateImpostorScores(s018Mean, s076);
            impostorScoresUser18User77 = EuclidDist.CalculateImpostorScores(s018Mean, s077);
            impostorScoresUser18User78 = EuclidDist.CalculateImpostorScores(s018Mean, s078);
            impostorScoresUser18User79 = EuclidDist.CalculateImpostorScores(s018Mean, s079);
            impostorScoresUser18User80 = EuclidDist.CalculateImpostorScores(s018Mean, s080);

            impostorScoresUser18User81 = EuclidDist.CalculateImpostorScores(s018Mean, s081);
            impostorScoresUser18User82 = EuclidDist.CalculateImpostorScores(s018Mean, s082);
            impostorScoresUser18User83 = EuclidDist.CalculateImpostorScores(s018Mean, s083);
            impostorScoresUser18User84 = EuclidDist.CalculateImpostorScores(s018Mean, s084);
            impostorScoresUser18User85 = EuclidDist.CalculateImpostorScores(s018Mean, s085);
            impostorScoresUser18User86 = EuclidDist.CalculateImpostorScores(s018Mean, s086);
            impostorScoresUser18User87 = EuclidDist.CalculateImpostorScores(s018Mean, s087);
            impostorScoresUser18User88 = EuclidDist.CalculateImpostorScores(s018Mean, s088);
            impostorScoresUser18User89 = EuclidDist.CalculateImpostorScores(s018Mean, s089);
            impostorScoresUser18User90 = EuclidDist.CalculateImpostorScores(s018Mean, s090);

            impostorScoresUser18User91 = EuclidDist.CalculateImpostorScores(s018Mean, s091);
            impostorScoresUser18User92 = EuclidDist.CalculateImpostorScores(s018Mean, s092);
            impostorScoresUser18User93 = EuclidDist.CalculateImpostorScores(s018Mean, s093);
            impostorScoresUser18User94 = EuclidDist.CalculateImpostorScores(s018Mean, s094);
            impostorScoresUser18User95 = EuclidDist.CalculateImpostorScores(s018Mean, s095);
            impostorScoresUser18User96 = EuclidDist.CalculateImpostorScores(s018Mean, s096);
            impostorScoresUser18User97 = EuclidDist.CalculateImpostorScores(s018Mean, s097);
            impostorScoresUser18User98 = EuclidDist.CalculateImpostorScores(s018Mean, s098);
            impostorScoresUser18User99 = EuclidDist.CalculateImpostorScores(s018Mean, s099);
            impostorScoresUser18User100 = EuclidDist.CalculateImpostorScores(s018Mean, s100);
            #endregion

            #region User 19 Impostor scores
            impostorScoresUser19User1 = EuclidDist.CalculateImpostorScores(s019Mean, s001);
            impostorScoresUser19User2 = EuclidDist.CalculateImpostorScores(s019Mean, s002);
            impostorScoresUser19User3 = EuclidDist.CalculateImpostorScores(s019Mean, s003);
            impostorScoresUser19User4 = EuclidDist.CalculateImpostorScores(s019Mean, s004);
            impostorScoresUser19User5 = EuclidDist.CalculateImpostorScores(s019Mean, s005);
            impostorScoresUser19User6 = EuclidDist.CalculateImpostorScores(s019Mean, s006);
            impostorScoresUser19User7 = EuclidDist.CalculateImpostorScores(s019Mean, s007);
            impostorScoresUser19User8 = EuclidDist.CalculateImpostorScores(s019Mean, s008);
            impostorScoresUser19User9 = EuclidDist.CalculateImpostorScores(s019Mean, s009);
            impostorScoresUser19User10 = EuclidDist.CalculateImpostorScores(s019Mean, s010);

            impostorScoresUser19User11 = EuclidDist.CalculateImpostorScores(s019Mean, s011);
            impostorScoresUser19User12 = EuclidDist.CalculateImpostorScores(s019Mean, s012);
            impostorScoresUser19User13 = EuclidDist.CalculateImpostorScores(s019Mean, s013);
            impostorScoresUser19User14 = EuclidDist.CalculateImpostorScores(s019Mean, s014);
            impostorScoresUser19User15 = EuclidDist.CalculateImpostorScores(s019Mean, s015);
            impostorScoresUser19User16 = EuclidDist.CalculateImpostorScores(s019Mean, s016);
            impostorScoresUser19User17 = EuclidDist.CalculateImpostorScores(s019Mean, s017);
            impostorScoresUser19User18 = EuclidDist.CalculateImpostorScores(s019Mean, s018);
            impostorScoresUser19User20 = EuclidDist.CalculateImpostorScores(s019Mean, s020);

            impostorScoresUser19User21 = EuclidDist.CalculateImpostorScores(s019Mean, s021);
            impostorScoresUser19User22 = EuclidDist.CalculateImpostorScores(s019Mean, s022);
            impostorScoresUser19User23 = EuclidDist.CalculateImpostorScores(s019Mean, s023);
            impostorScoresUser19User24 = EuclidDist.CalculateImpostorScores(s019Mean, s024);
            impostorScoresUser19User25 = EuclidDist.CalculateImpostorScores(s019Mean, s025);
            impostorScoresUser19User26 = EuclidDist.CalculateImpostorScores(s019Mean, s026);
            impostorScoresUser19User27 = EuclidDist.CalculateImpostorScores(s019Mean, s027);
            impostorScoresUser19User28 = EuclidDist.CalculateImpostorScores(s019Mean, s028);
            impostorScoresUser19User29 = EuclidDist.CalculateImpostorScores(s019Mean, s029);
            impostorScoresUser19User30 = EuclidDist.CalculateImpostorScores(s019Mean, s030);

            impostorScoresUser19User31 = EuclidDist.CalculateImpostorScores(s019Mean, s031);
            impostorScoresUser19User32 = EuclidDist.CalculateImpostorScores(s019Mean, s032);
            impostorScoresUser19User33 = EuclidDist.CalculateImpostorScores(s019Mean, s033);
            impostorScoresUser19User34 = EuclidDist.CalculateImpostorScores(s019Mean, s034);
            impostorScoresUser19User35 = EuclidDist.CalculateImpostorScores(s019Mean, s035);
            impostorScoresUser19User36 = EuclidDist.CalculateImpostorScores(s019Mean, s036);
            impostorScoresUser19User37 = EuclidDist.CalculateImpostorScores(s019Mean, s037);
            impostorScoresUser19User38 = EuclidDist.CalculateImpostorScores(s019Mean, s038);
            impostorScoresUser19User39 = EuclidDist.CalculateImpostorScores(s019Mean, s039);
            impostorScoresUser19User40 = EuclidDist.CalculateImpostorScores(s019Mean, s040);

            impostorScoresUser19User41 = EuclidDist.CalculateImpostorScores(s019Mean, s041);
            impostorScoresUser19User42 = EuclidDist.CalculateImpostorScores(s019Mean, s042);
            impostorScoresUser19User43 = EuclidDist.CalculateImpostorScores(s019Mean, s043);
            impostorScoresUser19User44 = EuclidDist.CalculateImpostorScores(s019Mean, s044);
            impostorScoresUser19User45 = EuclidDist.CalculateImpostorScores(s019Mean, s045);
            impostorScoresUser19User46 = EuclidDist.CalculateImpostorScores(s019Mean, s046);
            impostorScoresUser19User47 = EuclidDist.CalculateImpostorScores(s019Mean, s047);
            impostorScoresUser19User48 = EuclidDist.CalculateImpostorScores(s019Mean, s048);
            impostorScoresUser19User49 = EuclidDist.CalculateImpostorScores(s019Mean, s049);
            impostorScoresUser19User50 = EuclidDist.CalculateImpostorScores(s019Mean, s050);

            impostorScoresUser19User51 = EuclidDist.CalculateImpostorScores(s019Mean, s051);
            impostorScoresUser19User52 = EuclidDist.CalculateImpostorScores(s019Mean, s052);
            impostorScoresUser19User53 = EuclidDist.CalculateImpostorScores(s019Mean, s053);
            impostorScoresUser19User54 = EuclidDist.CalculateImpostorScores(s019Mean, s054);
            impostorScoresUser19User55 = EuclidDist.CalculateImpostorScores(s019Mean, s055);
            impostorScoresUser19User56 = EuclidDist.CalculateImpostorScores(s019Mean, s056);
            impostorScoresUser19User57 = EuclidDist.CalculateImpostorScores(s019Mean, s057);
            impostorScoresUser19User58 = EuclidDist.CalculateImpostorScores(s019Mean, s058);
            impostorScoresUser19User59 = EuclidDist.CalculateImpostorScores(s019Mean, s059);
            impostorScoresUser19User60 = EuclidDist.CalculateImpostorScores(s019Mean, s060);

            impostorScoresUser19User61 = EuclidDist.CalculateImpostorScores(s019Mean, s061);
            impostorScoresUser19User61 = EuclidDist.CalculateImpostorScores(s019Mean, s062);
            impostorScoresUser19User63 = EuclidDist.CalculateImpostorScores(s019Mean, s063);
            impostorScoresUser19User64 = EuclidDist.CalculateImpostorScores(s019Mean, s064);
            impostorScoresUser19User65 = EuclidDist.CalculateImpostorScores(s019Mean, s065);
            impostorScoresUser19User66 = EuclidDist.CalculateImpostorScores(s019Mean, s066);
            impostorScoresUser19User67 = EuclidDist.CalculateImpostorScores(s019Mean, s067);
            impostorScoresUser19User68 = EuclidDist.CalculateImpostorScores(s019Mean, s068);
            impostorScoresUser19User69 = EuclidDist.CalculateImpostorScores(s019Mean, s069);
            impostorScoresUser19User70 = EuclidDist.CalculateImpostorScores(s019Mean, s070);

            impostorScoresUser19User71 = EuclidDist.CalculateImpostorScores(s019Mean, s071);
            impostorScoresUser19User72 = EuclidDist.CalculateImpostorScores(s019Mean, s072);
            impostorScoresUser19User73 = EuclidDist.CalculateImpostorScores(s019Mean, s073);
            impostorScoresUser19User74 = EuclidDist.CalculateImpostorScores(s019Mean, s074);
            impostorScoresUser19User75 = EuclidDist.CalculateImpostorScores(s019Mean, s075);
            impostorScoresUser19User76 = EuclidDist.CalculateImpostorScores(s019Mean, s076);
            impostorScoresUser19User77 = EuclidDist.CalculateImpostorScores(s019Mean, s077);
            impostorScoresUser19User78 = EuclidDist.CalculateImpostorScores(s019Mean, s078);
            impostorScoresUser19User79 = EuclidDist.CalculateImpostorScores(s019Mean, s079);
            impostorScoresUser19User80 = EuclidDist.CalculateImpostorScores(s019Mean, s080);

            impostorScoresUser19User81 = EuclidDist.CalculateImpostorScores(s019Mean, s081);
            impostorScoresUser19User82 = EuclidDist.CalculateImpostorScores(s019Mean, s082);
            impostorScoresUser19User83 = EuclidDist.CalculateImpostorScores(s019Mean, s083);
            impostorScoresUser19User84 = EuclidDist.CalculateImpostorScores(s019Mean, s084);
            impostorScoresUser19User85 = EuclidDist.CalculateImpostorScores(s019Mean, s085);
            impostorScoresUser19User86 = EuclidDist.CalculateImpostorScores(s019Mean, s086);
            impostorScoresUser19User87 = EuclidDist.CalculateImpostorScores(s019Mean, s087);
            impostorScoresUser19User88 = EuclidDist.CalculateImpostorScores(s019Mean, s088);
            impostorScoresUser19User89 = EuclidDist.CalculateImpostorScores(s019Mean, s089);
            impostorScoresUser19User90 = EuclidDist.CalculateImpostorScores(s019Mean, s090);

            impostorScoresUser19User91 = EuclidDist.CalculateImpostorScores(s019Mean, s091);
            impostorScoresUser19User92 = EuclidDist.CalculateImpostorScores(s019Mean, s092);
            impostorScoresUser19User93 = EuclidDist.CalculateImpostorScores(s019Mean, s093);
            impostorScoresUser19User94 = EuclidDist.CalculateImpostorScores(s019Mean, s094);
            impostorScoresUser19User95 = EuclidDist.CalculateImpostorScores(s019Mean, s095);
            impostorScoresUser19User96 = EuclidDist.CalculateImpostorScores(s019Mean, s096);
            impostorScoresUser19User97 = EuclidDist.CalculateImpostorScores(s019Mean, s097);
            impostorScoresUser19User98 = EuclidDist.CalculateImpostorScores(s019Mean, s099);
            impostorScoresUser19User99 = EuclidDist.CalculateImpostorScores(s019Mean, s099);
            impostorScoresUser19User100 = EuclidDist.CalculateImpostorScores(s019Mean, s100);
            #endregion

            #region User 20 Impostor scores
            impostorScoresUser20User1 = EuclidDist.CalculateImpostorScores(s020Mean, s001);
            impostorScoresUser20User2 = EuclidDist.CalculateImpostorScores(s020Mean, s002);
            impostorScoresUser20User3 = EuclidDist.CalculateImpostorScores(s020Mean, s003);
            impostorScoresUser20User4 = EuclidDist.CalculateImpostorScores(s020Mean, s004);
            impostorScoresUser20User5 = EuclidDist.CalculateImpostorScores(s020Mean, s005);
            impostorScoresUser20User6 = EuclidDist.CalculateImpostorScores(s020Mean, s006);
            impostorScoresUser20User7 = EuclidDist.CalculateImpostorScores(s020Mean, s007);
            impostorScoresUser20User8 = EuclidDist.CalculateImpostorScores(s020Mean, s008);
            impostorScoresUser20User9 = EuclidDist.CalculateImpostorScores(s020Mean, s009);
            impostorScoresUser20User10 = EuclidDist.CalculateImpostorScores(s020Mean, s010);

            impostorScoresUser20User11 = EuclidDist.CalculateImpostorScores(s020Mean, s011);
            impostorScoresUser20User12 = EuclidDist.CalculateImpostorScores(s020Mean, s012);
            impostorScoresUser20User13 = EuclidDist.CalculateImpostorScores(s020Mean, s013);
            impostorScoresUser20User14 = EuclidDist.CalculateImpostorScores(s020Mean, s014);
            impostorScoresUser20User15 = EuclidDist.CalculateImpostorScores(s020Mean, s015);
            impostorScoresUser20User16 = EuclidDist.CalculateImpostorScores(s020Mean, s016);
            impostorScoresUser20User17 = EuclidDist.CalculateImpostorScores(s020Mean, s017);
            impostorScoresUser20User18 = EuclidDist.CalculateImpostorScores(s020Mean, s018);
            impostorScoresUser20User19 = EuclidDist.CalculateImpostorScores(s020Mean, s019);

            impostorScoresUser20User21 = EuclidDist.CalculateImpostorScores(s020Mean, s021);
            impostorScoresUser20User22 = EuclidDist.CalculateImpostorScores(s020Mean, s022);
            impostorScoresUser20User23 = EuclidDist.CalculateImpostorScores(s020Mean, s023);
            impostorScoresUser20User24 = EuclidDist.CalculateImpostorScores(s020Mean, s024);
            impostorScoresUser20User25 = EuclidDist.CalculateImpostorScores(s020Mean, s025);
            impostorScoresUser20User26 = EuclidDist.CalculateImpostorScores(s020Mean, s026);
            impostorScoresUser20User27 = EuclidDist.CalculateImpostorScores(s020Mean, s027);
            impostorScoresUser20User28 = EuclidDist.CalculateImpostorScores(s020Mean, s028);
            impostorScoresUser20User29 = EuclidDist.CalculateImpostorScores(s020Mean, s029);
            impostorScoresUser20User30 = EuclidDist.CalculateImpostorScores(s020Mean, s030);

            impostorScoresUser20User31 = EuclidDist.CalculateImpostorScores(s020Mean, s031);
            impostorScoresUser20User32 = EuclidDist.CalculateImpostorScores(s020Mean, s032);
            impostorScoresUser20User33 = EuclidDist.CalculateImpostorScores(s020Mean, s033);
            impostorScoresUser20User34 = EuclidDist.CalculateImpostorScores(s020Mean, s034);
            impostorScoresUser20User35 = EuclidDist.CalculateImpostorScores(s020Mean, s035);
            impostorScoresUser20User36 = EuclidDist.CalculateImpostorScores(s020Mean, s036);
            impostorScoresUser20User37 = EuclidDist.CalculateImpostorScores(s020Mean, s037);
            impostorScoresUser20User38 = EuclidDist.CalculateImpostorScores(s020Mean, s038);
            impostorScoresUser20User39 = EuclidDist.CalculateImpostorScores(s020Mean, s039);
            impostorScoresUser20User40 = EuclidDist.CalculateImpostorScores(s020Mean, s040);

            impostorScoresUser20User41 = EuclidDist.CalculateImpostorScores(s020Mean, s041);
            impostorScoresUser20User42 = EuclidDist.CalculateImpostorScores(s020Mean, s042);
            impostorScoresUser20User43 = EuclidDist.CalculateImpostorScores(s020Mean, s043);
            impostorScoresUser20User44 = EuclidDist.CalculateImpostorScores(s020Mean, s044);
            impostorScoresUser20User45 = EuclidDist.CalculateImpostorScores(s020Mean, s045);
            impostorScoresUser20User46 = EuclidDist.CalculateImpostorScores(s020Mean, s046);
            impostorScoresUser20User47 = EuclidDist.CalculateImpostorScores(s020Mean, s047);
            impostorScoresUser20User48 = EuclidDist.CalculateImpostorScores(s020Mean, s048);
            impostorScoresUser20User49 = EuclidDist.CalculateImpostorScores(s020Mean, s049);
            impostorScoresUser20User50 = EuclidDist.CalculateImpostorScores(s020Mean, s050);

            impostorScoresUser20User51 = EuclidDist.CalculateImpostorScores(s020Mean, s051);
            impostorScoresUser20User52 = EuclidDist.CalculateImpostorScores(s020Mean, s052);
            impostorScoresUser20User53 = EuclidDist.CalculateImpostorScores(s020Mean, s053);
            impostorScoresUser20User54 = EuclidDist.CalculateImpostorScores(s020Mean, s054);
            impostorScoresUser20User55 = EuclidDist.CalculateImpostorScores(s020Mean, s055);
            impostorScoresUser20User56 = EuclidDist.CalculateImpostorScores(s020Mean, s056);
            impostorScoresUser20User57 = EuclidDist.CalculateImpostorScores(s020Mean, s057);
            impostorScoresUser20User58 = EuclidDist.CalculateImpostorScores(s020Mean, s058);
            impostorScoresUser20User59 = EuclidDist.CalculateImpostorScores(s020Mean, s059);
            impostorScoresUser20User60 = EuclidDist.CalculateImpostorScores(s020Mean, s060);

            impostorScoresUser20User61 = EuclidDist.CalculateImpostorScores(s020Mean, s061);
            impostorScoresUser20User62 = EuclidDist.CalculateImpostorScores(s020Mean, s062);
            impostorScoresUser20User63 = EuclidDist.CalculateImpostorScores(s020Mean, s063);
            impostorScoresUser20User64 = EuclidDist.CalculateImpostorScores(s020Mean, s064);
            impostorScoresUser20User65 = EuclidDist.CalculateImpostorScores(s020Mean, s065);
            impostorScoresUser20User66 = EuclidDist.CalculateImpostorScores(s020Mean, s066);
            impostorScoresUser20User67 = EuclidDist.CalculateImpostorScores(s020Mean, s067);
            impostorScoresUser20User68 = EuclidDist.CalculateImpostorScores(s020Mean, s068);
            impostorScoresUser20User69 = EuclidDist.CalculateImpostorScores(s020Mean, s069);
            impostorScoresUser20User70 = EuclidDist.CalculateImpostorScores(s020Mean, s070);

            impostorScoresUser20User71 = EuclidDist.CalculateImpostorScores(s020Mean, s071);
            impostorScoresUser20User72 = EuclidDist.CalculateImpostorScores(s020Mean, s072);
            impostorScoresUser20User73 = EuclidDist.CalculateImpostorScores(s020Mean, s073);
            impostorScoresUser20User74 = EuclidDist.CalculateImpostorScores(s020Mean, s074);
            impostorScoresUser20User75 = EuclidDist.CalculateImpostorScores(s020Mean, s075);
            impostorScoresUser20User76 = EuclidDist.CalculateImpostorScores(s020Mean, s076);
            impostorScoresUser20User77 = EuclidDist.CalculateImpostorScores(s020Mean, s077);
            impostorScoresUser20User78 = EuclidDist.CalculateImpostorScores(s020Mean, s078);
            impostorScoresUser20User79 = EuclidDist.CalculateImpostorScores(s020Mean, s079);
            impostorScoresUser20User80 = EuclidDist.CalculateImpostorScores(s020Mean, s080);

            impostorScoresUser20User81 = EuclidDist.CalculateImpostorScores(s020Mean, s081);
            impostorScoresUser20User82 = EuclidDist.CalculateImpostorScores(s020Mean, s082);
            impostorScoresUser20User83 = EuclidDist.CalculateImpostorScores(s020Mean, s083);
            impostorScoresUser20User84 = EuclidDist.CalculateImpostorScores(s020Mean, s084);
            impostorScoresUser20User85 = EuclidDist.CalculateImpostorScores(s020Mean, s085);
            impostorScoresUser20User86 = EuclidDist.CalculateImpostorScores(s020Mean, s086);
            impostorScoresUser20User87 = EuclidDist.CalculateImpostorScores(s020Mean, s087);
            impostorScoresUser20User88 = EuclidDist.CalculateImpostorScores(s020Mean, s088);
            impostorScoresUser20User89 = EuclidDist.CalculateImpostorScores(s020Mean, s089);
            impostorScoresUser20User90 = EuclidDist.CalculateImpostorScores(s020Mean, s090);

            impostorScoresUser20User91 = EuclidDist.CalculateImpostorScores(s020Mean, s091);
            impostorScoresUser20User92 = EuclidDist.CalculateImpostorScores(s020Mean, s092);
            impostorScoresUser20User93 = EuclidDist.CalculateImpostorScores(s020Mean, s093);
            impostorScoresUser20User94 = EuclidDist.CalculateImpostorScores(s020Mean, s094);
            impostorScoresUser20User95 = EuclidDist.CalculateImpostorScores(s020Mean, s095);
            impostorScoresUser20User96 = EuclidDist.CalculateImpostorScores(s020Mean, s096);
            impostorScoresUser20User97 = EuclidDist.CalculateImpostorScores(s020Mean, s097);
            impostorScoresUser20User98 = EuclidDist.CalculateImpostorScores(s020Mean, s098);
            impostorScoresUser20User99 = EuclidDist.CalculateImpostorScores(s020Mean, s099);
            impostorScoresUser20User100 = EuclidDist.CalculateImpostorScores(s020Mean, s100);
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

            #region User 1 Impostor scores
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

            #region User 2 Impostor scores
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

            #region User 3 Impostor scores
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

            #region User 4 Impostor scores
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

            #region User 5 Impostor scores
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

            #region User 6 Impostor scores
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

            #region User 7 Impostor scores
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

            #region User 8 Impostor scores
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

            #region User 9 Impostor scores
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

            impostorScoresUser9User51 = ManhDist.CalculateImpostorScores(s009Mean, s051);
            impostorScoresUser9User52 = ManhDist.CalculateImpostorScores(s009Mean, s052);
            impostorScoresUser9User53 = ManhDist.CalculateImpostorScores(s009Mean, s053);
            impostorScoresUser9User54 = ManhDist.CalculateImpostorScores(s009Mean, s054);
            impostorScoresUser9User55 = ManhDist.CalculateImpostorScores(s009Mean, s055);
            impostorScoresUser9User56 = ManhDist.CalculateImpostorScores(s009Mean, s056);
            impostorScoresUser9User57 = ManhDist.CalculateImpostorScores(s009Mean, s057);
            impostorScoresUser9User58 = ManhDist.CalculateImpostorScores(s009Mean, s058);
            impostorScoresUser9User59 = ManhDist.CalculateImpostorScores(s009Mean, s059);
            impostorScoresUser9User60 = ManhDist.CalculateImpostorScores(s009Mean, s060);

            impostorScoresUser9User61 = ManhDist.CalculateImpostorScores(s009Mean, s061);
            impostorScoresUser9User62 = ManhDist.CalculateImpostorScores(s009Mean, s062);
            impostorScoresUser9User63 = ManhDist.CalculateImpostorScores(s009Mean, s063);
            impostorScoresUser9User64 = ManhDist.CalculateImpostorScores(s009Mean, s064);
            impostorScoresUser9User65 = ManhDist.CalculateImpostorScores(s009Mean, s065);
            impostorScoresUser9User66 = ManhDist.CalculateImpostorScores(s009Mean, s066);
            impostorScoresUser9User67 = ManhDist.CalculateImpostorScores(s009Mean, s067);
            impostorScoresUser9User68 = ManhDist.CalculateImpostorScores(s009Mean, s068);
            impostorScoresUser9User69 = ManhDist.CalculateImpostorScores(s009Mean, s069);
            impostorScoresUser9User70 = ManhDist.CalculateImpostorScores(s009Mean, s070);

            impostorScoresUser9User71 = ManhDist.CalculateImpostorScores(s009Mean, s071);
            impostorScoresUser9User72 = ManhDist.CalculateImpostorScores(s009Mean, s072);
            impostorScoresUser9User73 = ManhDist.CalculateImpostorScores(s009Mean, s073);
            impostorScoresUser9User74 = ManhDist.CalculateImpostorScores(s009Mean, s074);
            impostorScoresUser9User75 = ManhDist.CalculateImpostorScores(s009Mean, s075);
            impostorScoresUser9User76 = ManhDist.CalculateImpostorScores(s009Mean, s076);
            impostorScoresUser9User77 = ManhDist.CalculateImpostorScores(s009Mean, s077);
            impostorScoresUser9User78 = ManhDist.CalculateImpostorScores(s009Mean, s078);
            impostorScoresUser9User79 = ManhDist.CalculateImpostorScores(s009Mean, s079);
            impostorScoresUser9User80 = ManhDist.CalculateImpostorScores(s009Mean, s080);

            impostorScoresUser9User81 = ManhDist.CalculateImpostorScores(s009Mean, s081);
            impostorScoresUser9User82 = ManhDist.CalculateImpostorScores(s009Mean, s082);
            impostorScoresUser9User83 = ManhDist.CalculateImpostorScores(s009Mean, s083);
            impostorScoresUser9User84 = ManhDist.CalculateImpostorScores(s009Mean, s084);
            impostorScoresUser9User85 = ManhDist.CalculateImpostorScores(s009Mean, s085);
            impostorScoresUser9User86 = ManhDist.CalculateImpostorScores(s009Mean, s086);
            impostorScoresUser9User87 = ManhDist.CalculateImpostorScores(s009Mean, s087);
            impostorScoresUser9User88 = ManhDist.CalculateImpostorScores(s009Mean, s088);
            impostorScoresUser9User89 = ManhDist.CalculateImpostorScores(s009Mean, s089);
            impostorScoresUser9User90 = ManhDist.CalculateImpostorScores(s009Mean, s090);

            impostorScoresUser9User91 = ManhDist.CalculateImpostorScores(s009Mean, s091);
            impostorScoresUser9User92 = ManhDist.CalculateImpostorScores(s009Mean, s092);
            impostorScoresUser9User93 = ManhDist.CalculateImpostorScores(s009Mean, s093);
            impostorScoresUser9User94 = ManhDist.CalculateImpostorScores(s009Mean, s094);
            impostorScoresUser9User95 = ManhDist.CalculateImpostorScores(s009Mean, s095);
            impostorScoresUser9User96 = ManhDist.CalculateImpostorScores(s009Mean, s096);
            impostorScoresUser9User97 = ManhDist.CalculateImpostorScores(s009Mean, s097);
            impostorScoresUser9User98 = ManhDist.CalculateImpostorScores(s009Mean, s098);
            impostorScoresUser9User99 = ManhDist.CalculateImpostorScores(s009Mean, s099);
            impostorScoresUser9User100 = ManhDist.CalculateImpostorScores(s009Mean, s100);
            #endregion

            #region User 10 Impostor scores
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

            impostorScoresUser10User51 = ManhDist.CalculateImpostorScores(s010Mean, s051);
            impostorScoresUser10User52 = ManhDist.CalculateImpostorScores(s010Mean, s052);
            impostorScoresUser10User53 = ManhDist.CalculateImpostorScores(s010Mean, s053);
            impostorScoresUser10User54 = ManhDist.CalculateImpostorScores(s010Mean, s054);
            impostorScoresUser10User55 = ManhDist.CalculateImpostorScores(s010Mean, s055);
            impostorScoresUser10User56 = ManhDist.CalculateImpostorScores(s010Mean, s056);
            impostorScoresUser10User57 = ManhDist.CalculateImpostorScores(s010Mean, s057);
            impostorScoresUser10User58 = ManhDist.CalculateImpostorScores(s010Mean, s058);
            impostorScoresUser10User59 = ManhDist.CalculateImpostorScores(s010Mean, s059);
            impostorScoresUser10User60 = ManhDist.CalculateImpostorScores(s010Mean, s060);

            impostorScoresUser10User61 = ManhDist.CalculateImpostorScores(s010Mean, s061);
            impostorScoresUser10User62 = ManhDist.CalculateImpostorScores(s010Mean, s062);
            impostorScoresUser10User63 = ManhDist.CalculateImpostorScores(s010Mean, s063);
            impostorScoresUser10User64 = ManhDist.CalculateImpostorScores(s010Mean, s064);
            impostorScoresUser10User65 = ManhDist.CalculateImpostorScores(s010Mean, s065);
            impostorScoresUser10User66 = ManhDist.CalculateImpostorScores(s010Mean, s066);
            impostorScoresUser10User67 = ManhDist.CalculateImpostorScores(s010Mean, s067);
            impostorScoresUser10User68 = ManhDist.CalculateImpostorScores(s010Mean, s068);
            impostorScoresUser10User69 = ManhDist.CalculateImpostorScores(s010Mean, s069);
            impostorScoresUser10User70 = ManhDist.CalculateImpostorScores(s010Mean, s070);

            impostorScoresUser10User71 = ManhDist.CalculateImpostorScores(s010Mean, s071);
            impostorScoresUser10User72 = ManhDist.CalculateImpostorScores(s010Mean, s072);
            impostorScoresUser10User73 = ManhDist.CalculateImpostorScores(s010Mean, s073);
            impostorScoresUser10User74 = ManhDist.CalculateImpostorScores(s010Mean, s074);
            impostorScoresUser10User75 = ManhDist.CalculateImpostorScores(s010Mean, s075);
            impostorScoresUser10User76 = ManhDist.CalculateImpostorScores(s010Mean, s076);
            impostorScoresUser10User77 = ManhDist.CalculateImpostorScores(s010Mean, s077);
            impostorScoresUser10User78 = ManhDist.CalculateImpostorScores(s010Mean, s078);
            impostorScoresUser10User79 = ManhDist.CalculateImpostorScores(s010Mean, s079);
            impostorScoresUser10User80 = ManhDist.CalculateImpostorScores(s010Mean, s080);

            impostorScoresUser10User81 = ManhDist.CalculateImpostorScores(s010Mean, s081);
            impostorScoresUser10User82 = ManhDist.CalculateImpostorScores(s010Mean, s082);
            impostorScoresUser10User83 = ManhDist.CalculateImpostorScores(s010Mean, s083);
            impostorScoresUser10User84 = ManhDist.CalculateImpostorScores(s010Mean, s084);
            impostorScoresUser10User85 = ManhDist.CalculateImpostorScores(s010Mean, s085);
            impostorScoresUser10User86 = ManhDist.CalculateImpostorScores(s010Mean, s086);
            impostorScoresUser10User87 = ManhDist.CalculateImpostorScores(s010Mean, s087);
            impostorScoresUser10User88 = ManhDist.CalculateImpostorScores(s010Mean, s088);
            impostorScoresUser10User89 = ManhDist.CalculateImpostorScores(s010Mean, s089);
            impostorScoresUser10User90 = ManhDist.CalculateImpostorScores(s010Mean, s090);

            impostorScoresUser10User91 = ManhDist.CalculateImpostorScores(s010Mean, s091);
            impostorScoresUser10User92 = ManhDist.CalculateImpostorScores(s010Mean, s092);
            impostorScoresUser10User93 = ManhDist.CalculateImpostorScores(s010Mean, s093);
            impostorScoresUser10User94 = ManhDist.CalculateImpostorScores(s010Mean, s094);
            impostorScoresUser10User95 = ManhDist.CalculateImpostorScores(s010Mean, s095);
            impostorScoresUser10User96 = ManhDist.CalculateImpostorScores(s010Mean, s096);
            impostorScoresUser10User97 = ManhDist.CalculateImpostorScores(s010Mean, s097);
            impostorScoresUser10User98 = ManhDist.CalculateImpostorScores(s010Mean, s098);
            impostorScoresUser10User99 = ManhDist.CalculateImpostorScores(s010Mean, s099);
            impostorScoresUser10User100 = ManhDist.CalculateImpostorScores(s010Mean, s100);
            #endregion

            #region User 11 Impostor scores
            impostorScoresUser11User1 = ManhDist.CalculateImpostorScores(s011Mean, s001);
            impostorScoresUser11User2 = ManhDist.CalculateImpostorScores(s011Mean, s002);
            impostorScoresUser11User3 = ManhDist.CalculateImpostorScores(s011Mean, s003);
            impostorScoresUser11User4 = ManhDist.CalculateImpostorScores(s011Mean, s004);
            impostorScoresUser11User5 = ManhDist.CalculateImpostorScores(s011Mean, s005);
            impostorScoresUser11User6 = ManhDist.CalculateImpostorScores(s011Mean, s006);
            impostorScoresUser11User7 = ManhDist.CalculateImpostorScores(s011Mean, s007);
            impostorScoresUser11User8 = ManhDist.CalculateImpostorScores(s011Mean, s008);
            impostorScoresUser11User9 = ManhDist.CalculateImpostorScores(s011Mean, s009);
            impostorScoresUser11User10 = ManhDist.CalculateImpostorScores(s011Mean, s010);

            impostorScoresUser11User12 = ManhDist.CalculateImpostorScores(s011Mean, s012);
            impostorScoresUser11User13 = ManhDist.CalculateImpostorScores(s011Mean, s013);
            impostorScoresUser11User14 = ManhDist.CalculateImpostorScores(s011Mean, s014);
            impostorScoresUser11User15 = ManhDist.CalculateImpostorScores(s011Mean, s015);
            impostorScoresUser11User16 = ManhDist.CalculateImpostorScores(s011Mean, s016);
            impostorScoresUser11User17 = ManhDist.CalculateImpostorScores(s011Mean, s017);
            impostorScoresUser11User18 = ManhDist.CalculateImpostorScores(s011Mean, s018);
            impostorScoresUser11User19 = ManhDist.CalculateImpostorScores(s011Mean, s019);
            impostorScoresUser11User20 = ManhDist.CalculateImpostorScores(s011Mean, s020);

            impostorScoresUser11User21 = ManhDist.CalculateImpostorScores(s011Mean, s021);
            impostorScoresUser11User22 = ManhDist.CalculateImpostorScores(s011Mean, s022);
            impostorScoresUser11User23 = ManhDist.CalculateImpostorScores(s011Mean, s023);
            impostorScoresUser11User24 = ManhDist.CalculateImpostorScores(s011Mean, s024);
            impostorScoresUser11User25 = ManhDist.CalculateImpostorScores(s011Mean, s025);
            impostorScoresUser11User26 = ManhDist.CalculateImpostorScores(s011Mean, s026);
            impostorScoresUser11User27 = ManhDist.CalculateImpostorScores(s011Mean, s027);
            impostorScoresUser11User28 = ManhDist.CalculateImpostorScores(s011Mean, s028);
            impostorScoresUser11User29 = ManhDist.CalculateImpostorScores(s011Mean, s029);
            impostorScoresUser11User30 = ManhDist.CalculateImpostorScores(s011Mean, s030);

            impostorScoresUser11User31 = ManhDist.CalculateImpostorScores(s011Mean, s031);
            impostorScoresUser11User32 = ManhDist.CalculateImpostorScores(s011Mean, s032);
            impostorScoresUser11User33 = ManhDist.CalculateImpostorScores(s011Mean, s033);
            impostorScoresUser11User34 = ManhDist.CalculateImpostorScores(s011Mean, s034);
            impostorScoresUser11User35 = ManhDist.CalculateImpostorScores(s011Mean, s035);
            impostorScoresUser11User36 = ManhDist.CalculateImpostorScores(s011Mean, s036);
            impostorScoresUser11User37 = ManhDist.CalculateImpostorScores(s011Mean, s037);
            impostorScoresUser11User38 = ManhDist.CalculateImpostorScores(s011Mean, s038);
            impostorScoresUser11User39 = ManhDist.CalculateImpostorScores(s011Mean, s039);
            impostorScoresUser11User40 = ManhDist.CalculateImpostorScores(s011Mean, s040);

            impostorScoresUser11User41 = ManhDist.CalculateImpostorScores(s011Mean, s041);
            impostorScoresUser11User42 = ManhDist.CalculateImpostorScores(s011Mean, s042);
            impostorScoresUser11User43 = ManhDist.CalculateImpostorScores(s011Mean, s043);
            impostorScoresUser11User44 = ManhDist.CalculateImpostorScores(s011Mean, s044);
            impostorScoresUser11User45 = ManhDist.CalculateImpostorScores(s011Mean, s045);
            impostorScoresUser11User46 = ManhDist.CalculateImpostorScores(s011Mean, s046);
            impostorScoresUser11User47 = ManhDist.CalculateImpostorScores(s011Mean, s047);
            impostorScoresUser11User48 = ManhDist.CalculateImpostorScores(s011Mean, s048);
            impostorScoresUser11User49 = ManhDist.CalculateImpostorScores(s011Mean, s049);
            impostorScoresUser11User50 = ManhDist.CalculateImpostorScores(s011Mean, s050);

            impostorScoresUser11User51 = ManhDist.CalculateImpostorScores(s011Mean, s051);
            impostorScoresUser11User52 = ManhDist.CalculateImpostorScores(s011Mean, s052);
            impostorScoresUser11User53 = ManhDist.CalculateImpostorScores(s011Mean, s053);
            impostorScoresUser11User54 = ManhDist.CalculateImpostorScores(s011Mean, s054);
            impostorScoresUser11User55 = ManhDist.CalculateImpostorScores(s011Mean, s055);
            impostorScoresUser11User56 = ManhDist.CalculateImpostorScores(s011Mean, s056);
            impostorScoresUser11User57 = ManhDist.CalculateImpostorScores(s011Mean, s057);
            impostorScoresUser11User58 = ManhDist.CalculateImpostorScores(s011Mean, s058);
            impostorScoresUser11User59 = ManhDist.CalculateImpostorScores(s011Mean, s059);
            impostorScoresUser11User60 = ManhDist.CalculateImpostorScores(s011Mean, s060);

            impostorScoresUser11User61 = ManhDist.CalculateImpostorScores(s011Mean, s061);
            impostorScoresUser11User62 = ManhDist.CalculateImpostorScores(s011Mean, s062);
            impostorScoresUser11User63 = ManhDist.CalculateImpostorScores(s011Mean, s063);
            impostorScoresUser11User64 = ManhDist.CalculateImpostorScores(s011Mean, s064);
            impostorScoresUser11User65 = ManhDist.CalculateImpostorScores(s011Mean, s065);
            impostorScoresUser11User66 = ManhDist.CalculateImpostorScores(s011Mean, s066);
            impostorScoresUser11User67 = ManhDist.CalculateImpostorScores(s011Mean, s067);
            impostorScoresUser11User68 = ManhDist.CalculateImpostorScores(s011Mean, s068);
            impostorScoresUser11User69 = ManhDist.CalculateImpostorScores(s011Mean, s069);
            impostorScoresUser11User70 = ManhDist.CalculateImpostorScores(s011Mean, s070);

            impostorScoresUser11User71 = ManhDist.CalculateImpostorScores(s011Mean, s071);
            impostorScoresUser11User72 = ManhDist.CalculateImpostorScores(s011Mean, s072);
            impostorScoresUser11User73 = ManhDist.CalculateImpostorScores(s011Mean, s073);
            impostorScoresUser11User74 = ManhDist.CalculateImpostorScores(s011Mean, s074);
            impostorScoresUser11User75 = ManhDist.CalculateImpostorScores(s011Mean, s075);
            impostorScoresUser11User76 = ManhDist.CalculateImpostorScores(s011Mean, s076);
            impostorScoresUser11User77 = ManhDist.CalculateImpostorScores(s011Mean, s077);
            impostorScoresUser11User78 = ManhDist.CalculateImpostorScores(s011Mean, s078);
            impostorScoresUser11User79 = ManhDist.CalculateImpostorScores(s011Mean, s079);
            impostorScoresUser11User80 = ManhDist.CalculateImpostorScores(s011Mean, s080);

            impostorScoresUser11User81 = ManhDist.CalculateImpostorScores(s011Mean, s081);
            impostorScoresUser11User82 = ManhDist.CalculateImpostorScores(s011Mean, s082);
            impostorScoresUser11User83 = ManhDist.CalculateImpostorScores(s011Mean, s083);
            impostorScoresUser11User84 = ManhDist.CalculateImpostorScores(s011Mean, s084);
            impostorScoresUser11User85 = ManhDist.CalculateImpostorScores(s011Mean, s085);
            impostorScoresUser11User86 = ManhDist.CalculateImpostorScores(s011Mean, s086);
            impostorScoresUser11User87 = ManhDist.CalculateImpostorScores(s011Mean, s087);
            impostorScoresUser11User88 = ManhDist.CalculateImpostorScores(s011Mean, s088);
            impostorScoresUser11User89 = ManhDist.CalculateImpostorScores(s011Mean, s089);
            impostorScoresUser11User90 = ManhDist.CalculateImpostorScores(s011Mean, s090);

            impostorScoresUser11User91 = ManhDist.CalculateImpostorScores(s011Mean, s091);
            impostorScoresUser11User92 = ManhDist.CalculateImpostorScores(s011Mean, s092);
            impostorScoresUser11User93 = ManhDist.CalculateImpostorScores(s011Mean, s093);
            impostorScoresUser11User94 = ManhDist.CalculateImpostorScores(s011Mean, s094);
            impostorScoresUser11User95 = ManhDist.CalculateImpostorScores(s011Mean, s095);
            impostorScoresUser11User96 = ManhDist.CalculateImpostorScores(s011Mean, s096);
            impostorScoresUser11User97 = ManhDist.CalculateImpostorScores(s011Mean, s097);
            impostorScoresUser11User98 = ManhDist.CalculateImpostorScores(s011Mean, s098);
            impostorScoresUser11User99 = ManhDist.CalculateImpostorScores(s011Mean, s099);
            impostorScoresUser11User100 = ManhDist.CalculateImpostorScores(s011Mean, s100);
            #endregion

            #region User 12 Impostor scores
            impostorScoresUser12User1 = ManhDist.CalculateImpostorScores(s012Mean, s001);
            impostorScoresUser12User2 = ManhDist.CalculateImpostorScores(s012Mean, s002);
            impostorScoresUser12User3 = ManhDist.CalculateImpostorScores(s012Mean, s003);
            impostorScoresUser12User4 = ManhDist.CalculateImpostorScores(s012Mean, s004);
            impostorScoresUser12User5 = ManhDist.CalculateImpostorScores(s012Mean, s005);
            impostorScoresUser12User6 = ManhDist.CalculateImpostorScores(s012Mean, s006);
            impostorScoresUser12User7 = ManhDist.CalculateImpostorScores(s012Mean, s007);
            impostorScoresUser12User8 = ManhDist.CalculateImpostorScores(s012Mean, s008);
            impostorScoresUser12User9 = ManhDist.CalculateImpostorScores(s012Mean, s009);
            impostorScoresUser12User10 = ManhDist.CalculateImpostorScores(s012Mean, s010);

            impostorScoresUser12User11 = ManhDist.CalculateImpostorScores(s012Mean, s011);
            impostorScoresUser12User13 = ManhDist.CalculateImpostorScores(s012Mean, s013);
            impostorScoresUser12User14 = ManhDist.CalculateImpostorScores(s012Mean, s014);
            impostorScoresUser12User15 = ManhDist.CalculateImpostorScores(s012Mean, s015);
            impostorScoresUser12User16 = ManhDist.CalculateImpostorScores(s012Mean, s016);
            impostorScoresUser12User17 = ManhDist.CalculateImpostorScores(s012Mean, s017);
            impostorScoresUser12User18 = ManhDist.CalculateImpostorScores(s012Mean, s018);
            impostorScoresUser12User19 = ManhDist.CalculateImpostorScores(s012Mean, s019);
            impostorScoresUser12User20 = ManhDist.CalculateImpostorScores(s012Mean, s020);

            impostorScoresUser12User21 = ManhDist.CalculateImpostorScores(s012Mean, s021);
            impostorScoresUser12User22 = ManhDist.CalculateImpostorScores(s012Mean, s022);
            impostorScoresUser12User23 = ManhDist.CalculateImpostorScores(s012Mean, s023);
            impostorScoresUser12User24 = ManhDist.CalculateImpostorScores(s012Mean, s024);
            impostorScoresUser12User25 = ManhDist.CalculateImpostorScores(s012Mean, s025);
            impostorScoresUser12User26 = ManhDist.CalculateImpostorScores(s012Mean, s026);
            impostorScoresUser12User27 = ManhDist.CalculateImpostorScores(s012Mean, s027);
            impostorScoresUser12User28 = ManhDist.CalculateImpostorScores(s012Mean, s028);
            impostorScoresUser12User29 = ManhDist.CalculateImpostorScores(s012Mean, s029);
            impostorScoresUser12User30 = ManhDist.CalculateImpostorScores(s012Mean, s030);

            impostorScoresUser12User31 = ManhDist.CalculateImpostorScores(s012Mean, s031);
            impostorScoresUser12User32 = ManhDist.CalculateImpostorScores(s012Mean, s032);
            impostorScoresUser12User33 = ManhDist.CalculateImpostorScores(s012Mean, s033);
            impostorScoresUser12User34 = ManhDist.CalculateImpostorScores(s012Mean, s034);
            impostorScoresUser12User35 = ManhDist.CalculateImpostorScores(s012Mean, s035);
            impostorScoresUser12User36 = ManhDist.CalculateImpostorScores(s012Mean, s036);
            impostorScoresUser12User37 = ManhDist.CalculateImpostorScores(s012Mean, s037);
            impostorScoresUser12User38 = ManhDist.CalculateImpostorScores(s012Mean, s038);
            impostorScoresUser12User39 = ManhDist.CalculateImpostorScores(s012Mean, s039);
            impostorScoresUser12User40 = ManhDist.CalculateImpostorScores(s012Mean, s040);

            impostorScoresUser12User41 = ManhDist.CalculateImpostorScores(s012Mean, s041);
            impostorScoresUser12User42 = ManhDist.CalculateImpostorScores(s012Mean, s042);
            impostorScoresUser12User43 = ManhDist.CalculateImpostorScores(s012Mean, s043);
            impostorScoresUser12User44 = ManhDist.CalculateImpostorScores(s012Mean, s044);
            impostorScoresUser12User45 = ManhDist.CalculateImpostorScores(s012Mean, s045);
            impostorScoresUser12User46 = ManhDist.CalculateImpostorScores(s012Mean, s046);
            impostorScoresUser12User47 = ManhDist.CalculateImpostorScores(s012Mean, s047);
            impostorScoresUser12User48 = ManhDist.CalculateImpostorScores(s012Mean, s048);
            impostorScoresUser12User49 = ManhDist.CalculateImpostorScores(s012Mean, s049);
            impostorScoresUser12User50 = ManhDist.CalculateImpostorScores(s012Mean, s050);

            impostorScoresUser12User51 = ManhDist.CalculateImpostorScores(s012Mean, s051);
            impostorScoresUser12User52 = ManhDist.CalculateImpostorScores(s012Mean, s052);
            impostorScoresUser12User53 = ManhDist.CalculateImpostorScores(s012Mean, s053);
            impostorScoresUser12User54 = ManhDist.CalculateImpostorScores(s012Mean, s054);
            impostorScoresUser12User55 = ManhDist.CalculateImpostorScores(s012Mean, s055);
            impostorScoresUser12User56 = ManhDist.CalculateImpostorScores(s012Mean, s056);
            impostorScoresUser12User57 = ManhDist.CalculateImpostorScores(s012Mean, s057);
            impostorScoresUser12User58 = ManhDist.CalculateImpostorScores(s012Mean, s058);
            impostorScoresUser12User59 = ManhDist.CalculateImpostorScores(s012Mean, s059);
            impostorScoresUser12User60 = ManhDist.CalculateImpostorScores(s012Mean, s060);

            impostorScoresUser12User61 = ManhDist.CalculateImpostorScores(s012Mean, s061);
            impostorScoresUser12User62 = ManhDist.CalculateImpostorScores(s012Mean, s062);
            impostorScoresUser12User63 = ManhDist.CalculateImpostorScores(s012Mean, s063);
            impostorScoresUser12User64 = ManhDist.CalculateImpostorScores(s012Mean, s064);
            impostorScoresUser12User65 = ManhDist.CalculateImpostorScores(s012Mean, s065);
            impostorScoresUser12User66 = ManhDist.CalculateImpostorScores(s012Mean, s066);
            impostorScoresUser12User67 = ManhDist.CalculateImpostorScores(s012Mean, s067);
            impostorScoresUser12User68 = ManhDist.CalculateImpostorScores(s012Mean, s068);
            impostorScoresUser12User69 = ManhDist.CalculateImpostorScores(s012Mean, s069);
            impostorScoresUser12User70 = ManhDist.CalculateImpostorScores(s012Mean, s070);

            impostorScoresUser12User71 = ManhDist.CalculateImpostorScores(s012Mean, s071);
            impostorScoresUser12User72 = ManhDist.CalculateImpostorScores(s012Mean, s072);
            impostorScoresUser12User73 = ManhDist.CalculateImpostorScores(s012Mean, s073);
            impostorScoresUser12User74 = ManhDist.CalculateImpostorScores(s012Mean, s074);
            impostorScoresUser12User75 = ManhDist.CalculateImpostorScores(s012Mean, s075);
            impostorScoresUser12User76 = ManhDist.CalculateImpostorScores(s012Mean, s076);
            impostorScoresUser12User77 = ManhDist.CalculateImpostorScores(s012Mean, s077);
            impostorScoresUser12User78 = ManhDist.CalculateImpostorScores(s012Mean, s078);
            impostorScoresUser12User79 = ManhDist.CalculateImpostorScores(s012Mean, s079);
            impostorScoresUser12User80 = ManhDist.CalculateImpostorScores(s012Mean, s080);

            impostorScoresUser12User81 = ManhDist.CalculateImpostorScores(s012Mean, s081);
            impostorScoresUser12User82 = ManhDist.CalculateImpostorScores(s012Mean, s082);
            impostorScoresUser12User83 = ManhDist.CalculateImpostorScores(s012Mean, s083);
            impostorScoresUser12User84 = ManhDist.CalculateImpostorScores(s012Mean, s084);
            impostorScoresUser12User85 = ManhDist.CalculateImpostorScores(s012Mean, s085);
            impostorScoresUser12User86 = ManhDist.CalculateImpostorScores(s012Mean, s086);
            impostorScoresUser12User87 = ManhDist.CalculateImpostorScores(s012Mean, s087);
            impostorScoresUser12User88 = ManhDist.CalculateImpostorScores(s012Mean, s088);
            impostorScoresUser12User89 = ManhDist.CalculateImpostorScores(s012Mean, s089);
            impostorScoresUser12User90 = ManhDist.CalculateImpostorScores(s012Mean, s090);

            impostorScoresUser12User91 = ManhDist.CalculateImpostorScores(s012Mean, s091);
            impostorScoresUser12User92 = ManhDist.CalculateImpostorScores(s012Mean, s092);
            impostorScoresUser12User93 = ManhDist.CalculateImpostorScores(s012Mean, s093);
            impostorScoresUser12User94 = ManhDist.CalculateImpostorScores(s012Mean, s094);
            impostorScoresUser12User95 = ManhDist.CalculateImpostorScores(s012Mean, s095);
            impostorScoresUser12User96 = ManhDist.CalculateImpostorScores(s012Mean, s096);
            impostorScoresUser12User97 = ManhDist.CalculateImpostorScores(s012Mean, s097);
            impostorScoresUser12User98 = ManhDist.CalculateImpostorScores(s012Mean, s098);
            impostorScoresUser12User99 = ManhDist.CalculateImpostorScores(s012Mean, s099);
            impostorScoresUser12User100 = ManhDist.CalculateImpostorScores(s012Mean, s100);
            #endregion

            #region User 13 Impostor scores
            impostorScoresUser13User1 = ManhDist.CalculateImpostorScores(s013Mean, s001);
            impostorScoresUser13User2 = ManhDist.CalculateImpostorScores(s013Mean, s002);
            impostorScoresUser13User3 = ManhDist.CalculateImpostorScores(s013Mean, s003);
            impostorScoresUser13User4 = ManhDist.CalculateImpostorScores(s013Mean, s004);
            impostorScoresUser13User5 = ManhDist.CalculateImpostorScores(s013Mean, s005);
            impostorScoresUser13User6 = ManhDist.CalculateImpostorScores(s013Mean, s006);
            impostorScoresUser13User7 = ManhDist.CalculateImpostorScores(s013Mean, s007);
            impostorScoresUser13User8 = ManhDist.CalculateImpostorScores(s013Mean, s008);
            impostorScoresUser13User9 = ManhDist.CalculateImpostorScores(s013Mean, s009);
            impostorScoresUser13User10 = ManhDist.CalculateImpostorScores(s013Mean, s010);

            impostorScoresUser13User11 = ManhDist.CalculateImpostorScores(s013Mean, s011);
            impostorScoresUser13User12 = ManhDist.CalculateImpostorScores(s013Mean, s012);
            impostorScoresUser13User14 = ManhDist.CalculateImpostorScores(s013Mean, s014);
            impostorScoresUser13User15 = ManhDist.CalculateImpostorScores(s013Mean, s015);
            impostorScoresUser13User16 = ManhDist.CalculateImpostorScores(s013Mean, s016);
            impostorScoresUser13User17 = ManhDist.CalculateImpostorScores(s013Mean, s017);
            impostorScoresUser13User18 = ManhDist.CalculateImpostorScores(s013Mean, s018);
            impostorScoresUser13User19 = ManhDist.CalculateImpostorScores(s013Mean, s019);
            impostorScoresUser13User20 = ManhDist.CalculateImpostorScores(s013Mean, s020);

            impostorScoresUser13User21 = ManhDist.CalculateImpostorScores(s013Mean, s021);
            impostorScoresUser13User22 = ManhDist.CalculateImpostorScores(s013Mean, s022);
            impostorScoresUser13User23 = ManhDist.CalculateImpostorScores(s013Mean, s023);
            impostorScoresUser13User24 = ManhDist.CalculateImpostorScores(s013Mean, s024);
            impostorScoresUser13User25 = ManhDist.CalculateImpostorScores(s013Mean, s025);
            impostorScoresUser13User26 = ManhDist.CalculateImpostorScores(s013Mean, s026);
            impostorScoresUser13User27 = ManhDist.CalculateImpostorScores(s013Mean, s027);
            impostorScoresUser13User28 = ManhDist.CalculateImpostorScores(s013Mean, s028);
            impostorScoresUser13User29 = ManhDist.CalculateImpostorScores(s013Mean, s029);
            impostorScoresUser13User30 = ManhDist.CalculateImpostorScores(s013Mean, s030);

            impostorScoresUser13User31 = ManhDist.CalculateImpostorScores(s013Mean, s031);
            impostorScoresUser13User32 = ManhDist.CalculateImpostorScores(s013Mean, s032);
            impostorScoresUser13User33 = ManhDist.CalculateImpostorScores(s013Mean, s033);
            impostorScoresUser13User34 = ManhDist.CalculateImpostorScores(s013Mean, s034);
            impostorScoresUser13User35 = ManhDist.CalculateImpostorScores(s013Mean, s035);
            impostorScoresUser13User36 = ManhDist.CalculateImpostorScores(s013Mean, s036);
            impostorScoresUser13User37 = ManhDist.CalculateImpostorScores(s013Mean, s037);
            impostorScoresUser13User38 = ManhDist.CalculateImpostorScores(s013Mean, s038);
            impostorScoresUser13User39 = ManhDist.CalculateImpostorScores(s013Mean, s039);
            impostorScoresUser13User40 = ManhDist.CalculateImpostorScores(s013Mean, s040);

            impostorScoresUser13User41 = ManhDist.CalculateImpostorScores(s013Mean, s041);
            impostorScoresUser13User42 = ManhDist.CalculateImpostorScores(s013Mean, s042);
            impostorScoresUser13User43 = ManhDist.CalculateImpostorScores(s013Mean, s043);
            impostorScoresUser13User44 = ManhDist.CalculateImpostorScores(s013Mean, s044);
            impostorScoresUser13User45 = ManhDist.CalculateImpostorScores(s013Mean, s045);
            impostorScoresUser13User46 = ManhDist.CalculateImpostorScores(s013Mean, s046);
            impostorScoresUser13User47 = ManhDist.CalculateImpostorScores(s013Mean, s047);
            impostorScoresUser13User48 = ManhDist.CalculateImpostorScores(s013Mean, s048);
            impostorScoresUser13User49 = ManhDist.CalculateImpostorScores(s013Mean, s049);
            impostorScoresUser13User50 = ManhDist.CalculateImpostorScores(s013Mean, s050);

            impostorScoresUser13User51 = ManhDist.CalculateImpostorScores(s013Mean, s051);
            impostorScoresUser13User52 = ManhDist.CalculateImpostorScores(s013Mean, s052);
            impostorScoresUser13User53 = ManhDist.CalculateImpostorScores(s013Mean, s053);
            impostorScoresUser13User54 = ManhDist.CalculateImpostorScores(s013Mean, s054);
            impostorScoresUser13User55 = ManhDist.CalculateImpostorScores(s013Mean, s055);
            impostorScoresUser13User56 = ManhDist.CalculateImpostorScores(s013Mean, s056);
            impostorScoresUser13User57 = ManhDist.CalculateImpostorScores(s013Mean, s057);
            impostorScoresUser13User58 = ManhDist.CalculateImpostorScores(s013Mean, s058);
            impostorScoresUser13User59 = ManhDist.CalculateImpostorScores(s013Mean, s059);
            impostorScoresUser13User60 = ManhDist.CalculateImpostorScores(s013Mean, s060);

            impostorScoresUser13User61 = ManhDist.CalculateImpostorScores(s013Mean, s061);
            impostorScoresUser13User62 = ManhDist.CalculateImpostorScores(s013Mean, s062);
            impostorScoresUser13User63 = ManhDist.CalculateImpostorScores(s013Mean, s063);
            impostorScoresUser13User64 = ManhDist.CalculateImpostorScores(s013Mean, s064);
            impostorScoresUser13User65 = ManhDist.CalculateImpostorScores(s013Mean, s065);
            impostorScoresUser13User66 = ManhDist.CalculateImpostorScores(s013Mean, s066);
            impostorScoresUser13User67 = ManhDist.CalculateImpostorScores(s013Mean, s067);
            impostorScoresUser13User68 = ManhDist.CalculateImpostorScores(s013Mean, s068);
            impostorScoresUser13User69 = ManhDist.CalculateImpostorScores(s013Mean, s069);
            impostorScoresUser13User70 = ManhDist.CalculateImpostorScores(s013Mean, s070);

            impostorScoresUser13User71 = ManhDist.CalculateImpostorScores(s013Mean, s071);
            impostorScoresUser13User72 = ManhDist.CalculateImpostorScores(s013Mean, s072);
            impostorScoresUser13User73 = ManhDist.CalculateImpostorScores(s013Mean, s073);
            impostorScoresUser13User74 = ManhDist.CalculateImpostorScores(s013Mean, s074);
            impostorScoresUser13User75 = ManhDist.CalculateImpostorScores(s013Mean, s075);
            impostorScoresUser13User76 = ManhDist.CalculateImpostorScores(s013Mean, s076);
            impostorScoresUser13User77 = ManhDist.CalculateImpostorScores(s013Mean, s077);
            impostorScoresUser13User78 = ManhDist.CalculateImpostorScores(s013Mean, s078);
            impostorScoresUser13User79 = ManhDist.CalculateImpostorScores(s013Mean, s079);
            impostorScoresUser13User80 = ManhDist.CalculateImpostorScores(s013Mean, s080);

            impostorScoresUser13User81 = ManhDist.CalculateImpostorScores(s013Mean, s081);
            impostorScoresuser13User82 = ManhDist.CalculateImpostorScores(s013Mean, s082);
            impostorScoresUser13User83 = ManhDist.CalculateImpostorScores(s013Mean, s083);
            impostorScoresUser13User84 = ManhDist.CalculateImpostorScores(s013Mean, s084);
            impostorScoresUser13User85 = ManhDist.CalculateImpostorScores(s013Mean, s085);
            impostorScoresUser13User86 = ManhDist.CalculateImpostorScores(s013Mean, s086);
            impostorScoresUser13User87 = ManhDist.CalculateImpostorScores(s013Mean, s087);
            impostorScoresUser13User88 = ManhDist.CalculateImpostorScores(s013Mean, s088);
            impostorScoresUser13User89 = ManhDist.CalculateImpostorScores(s013Mean, s089);
            impostorScoresUser13User90 = ManhDist.CalculateImpostorScores(s013Mean, s090);

            impostorScoresUser13User91 = ManhDist.CalculateImpostorScores(s013Mean, s091);
            impostorScoresUser13User92 = ManhDist.CalculateImpostorScores(s013Mean, s092);
            impostorScoresUser13User93 = ManhDist.CalculateImpostorScores(s013Mean, s093);
            impostorScoresUser13User94 = ManhDist.CalculateImpostorScores(s013Mean, s094);
            impostorScoresUser13User95 = ManhDist.CalculateImpostorScores(s013Mean, s095);
            impostorScoresUser13User96 = ManhDist.CalculateImpostorScores(s013Mean, s096);
            impostorScoresUser13User97 = ManhDist.CalculateImpostorScores(s013Mean, s097);
            impostorScoresUser13User98 = ManhDist.CalculateImpostorScores(s013Mean, s098);
            impostorScoresUser13User99 = ManhDist.CalculateImpostorScores(s013Mean, s099);
            impostorScoresUser13User100 = ManhDist.CalculateImpostorScores(s013Mean, s100);
            #endregion

            #region User 14 Impostor scores
            impostorScoresUser14User1 = ManhDist.CalculateImpostorScores(s014Mean, s001);
            impostorScoresUser14User2 = ManhDist.CalculateImpostorScores(s014Mean, s002);
            impostorScoresUser14User3 = ManhDist.CalculateImpostorScores(s014Mean, s003);
            impostorScoresUser14User4 = ManhDist.CalculateImpostorScores(s014Mean, s004);
            impostorScoresUser14User5 = ManhDist.CalculateImpostorScores(s014Mean, s005);
            impostorScoresUser14User6 = ManhDist.CalculateImpostorScores(s014Mean, s006);
            impostorScoresUser14User7 = ManhDist.CalculateImpostorScores(s014Mean, s007);
            impostorScoresUser14User8 = ManhDist.CalculateImpostorScores(s014Mean, s008);
            impostorScoresUser14User9 = ManhDist.CalculateImpostorScores(s014Mean, s009);
            impostorScoresUser14User10 = ManhDist.CalculateImpostorScores(s014Mean, s010);

            impostorScoresUser14User11 = ManhDist.CalculateImpostorScores(s014Mean, s011);
            impostorScoresUser14User12 = ManhDist.CalculateImpostorScores(s014Mean, s012);
            impostorScoresUser14User13 = ManhDist.CalculateImpostorScores(s014Mean, s013);
            impostorScoresUser14User15 = ManhDist.CalculateImpostorScores(s014Mean, s015);
            impostorScoresUser14User16 = ManhDist.CalculateImpostorScores(s014Mean, s016);
            impostorScoresUser14User17 = ManhDist.CalculateImpostorScores(s014Mean, s017);
            impostorScoresUser14User18 = ManhDist.CalculateImpostorScores(s014Mean, s018);
            impostorScoresUser14User19 = ManhDist.CalculateImpostorScores(s014Mean, s019);
            impostorScoresUser14User20 = ManhDist.CalculateImpostorScores(s014Mean, s020);

            impostorScoresUser14User21 = ManhDist.CalculateImpostorScores(s014Mean, s021);
            impostorScoresUser14User22 = ManhDist.CalculateImpostorScores(s014Mean, s022);
            impostorScoresUser14User23 = ManhDist.CalculateImpostorScores(s014Mean, s023);
            impostorScoresUser14User24 = ManhDist.CalculateImpostorScores(s014Mean, s024);
            impostorScoresUser14User25 = ManhDist.CalculateImpostorScores(s014Mean, s025);
            impostorScoresUser14User26 = ManhDist.CalculateImpostorScores(s014Mean, s026);
            impostorScoresUser14User27 = ManhDist.CalculateImpostorScores(s014Mean, s027);
            impostorScoresUser14User28 = ManhDist.CalculateImpostorScores(s014Mean, s028);
            impostorScoresUser14User29 = ManhDist.CalculateImpostorScores(s014Mean, s029);
            impostorScoresUser14User30 = ManhDist.CalculateImpostorScores(s014Mean, s030);

            impostorScoresUser14User31 = ManhDist.CalculateImpostorScores(s014Mean, s031);
            impostorScoresUser14User32 = ManhDist.CalculateImpostorScores(s014Mean, s032);
            impostorScoresUser14User33 = ManhDist.CalculateImpostorScores(s014Mean, s033);
            impostorScoresUser14User34 = ManhDist.CalculateImpostorScores(s014Mean, s034);
            impostorScoresUser14User35 = ManhDist.CalculateImpostorScores(s014Mean, s035);
            impostorScoresUser14User36 = ManhDist.CalculateImpostorScores(s014Mean, s036);
            impostorScoresUser14User37 = ManhDist.CalculateImpostorScores(s014Mean, s037);
            impostorScoresUser14User38 = ManhDist.CalculateImpostorScores(s014Mean, s038);
            impostorScoresUser14User39 = ManhDist.CalculateImpostorScores(s014Mean, s039);
            impostorScoresUser14User40 = ManhDist.CalculateImpostorScores(s014Mean, s040);

            impostorScoresUser14User41 = ManhDist.CalculateImpostorScores(s014Mean, s041);
            impostorScoresUser14User42 = ManhDist.CalculateImpostorScores(s014Mean, s042);
            impostorScoresUser14User43 = ManhDist.CalculateImpostorScores(s014Mean, s043);
            impostorScoresUser14User44 = ManhDist.CalculateImpostorScores(s014Mean, s044);
            impostorScoresUser14User45 = ManhDist.CalculateImpostorScores(s014Mean, s045);
            impostorScoresUser14User46 = ManhDist.CalculateImpostorScores(s014Mean, s046);
            impostorScoresUser14User47 = ManhDist.CalculateImpostorScores(s014Mean, s047);
            impostorScoresUser14User48 = ManhDist.CalculateImpostorScores(s014Mean, s048);
            impostorScoresUser14User49 = ManhDist.CalculateImpostorScores(s014Mean, s049);
            impostorScoresUser14User50 = ManhDist.CalculateImpostorScores(s014Mean, s050);

            impostorScoresUser14User51 = ManhDist.CalculateImpostorScores(s014Mean, s051);
            impostorScoresUser14User52 = ManhDist.CalculateImpostorScores(s014Mean, s052);
            impostorScoresUser14User53 = ManhDist.CalculateImpostorScores(s014Mean, s053);
            impostorScoresUser14User54 = ManhDist.CalculateImpostorScores(s014Mean, s054);
            impostorScoresUser14User55 = ManhDist.CalculateImpostorScores(s014Mean, s055);
            impostorScoresUser14User56 = ManhDist.CalculateImpostorScores(s014Mean, s056);
            impostorScoresUser14User57 = ManhDist.CalculateImpostorScores(s014Mean, s057);
            impostorScoresUser14User58 = ManhDist.CalculateImpostorScores(s014Mean, s058);
            impostorScoresUser14User59 = ManhDist.CalculateImpostorScores(s014Mean, s059);
            impostorScoresUser14User60 = ManhDist.CalculateImpostorScores(s014Mean, s060);

            impostorScoresUser14User61 = ManhDist.CalculateImpostorScores(s014Mean, s061);
            impostorScoresUser14User62 = ManhDist.CalculateImpostorScores(s014Mean, s062);
            impostorScoresUser14User63 = ManhDist.CalculateImpostorScores(s014Mean, s063);
            impostorScoresUser14User64 = ManhDist.CalculateImpostorScores(s014Mean, s064);
            impostorScoresUser14User65 = ManhDist.CalculateImpostorScores(s014Mean, s065);
            impostorScoresUser14User66 = ManhDist.CalculateImpostorScores(s014Mean, s066);
            impostorScoresUser14User67 = ManhDist.CalculateImpostorScores(s014Mean, s067);
            impostorScoresUser14User68 = ManhDist.CalculateImpostorScores(s014Mean, s068);
            impostorScoresUser14User69 = ManhDist.CalculateImpostorScores(s014Mean, s069);
            impostorScoresUser14User70 = ManhDist.CalculateImpostorScores(s014Mean, s070);

            impostorScoresUser14User71 = ManhDist.CalculateImpostorScores(s014Mean, s071);
            impostorScoresUser14User72 = ManhDist.CalculateImpostorScores(s014Mean, s072);
            impostorScoresUser14User73 = ManhDist.CalculateImpostorScores(s014Mean, s073);
            impostorScoresUser14User74 = ManhDist.CalculateImpostorScores(s014Mean, s074);
            impostorScoresUser14User75 = ManhDist.CalculateImpostorScores(s014Mean, s075);
            impostorScoresUser14User76 = ManhDist.CalculateImpostorScores(s014Mean, s076);
            impostorScoresUser14User77 = ManhDist.CalculateImpostorScores(s014Mean, s077);
            impostorScoresUser14User78 = ManhDist.CalculateImpostorScores(s014Mean, s078);
            impostorScoresUser14User79 = ManhDist.CalculateImpostorScores(s014Mean, s079);
            impostorScoresUser14User80 = ManhDist.CalculateImpostorScores(s014Mean, s080);

            impostorScoresUser14User81 = ManhDist.CalculateImpostorScores(s014Mean, s081);
            impostorScoresUser14User82 = ManhDist.CalculateImpostorScores(s014Mean, s082);
            impostorScoresUser14User83 = ManhDist.CalculateImpostorScores(s014Mean, s083);
            impostorScoresUser14User84 = ManhDist.CalculateImpostorScores(s014Mean, s084);
            impostorScoresUser14User85 = ManhDist.CalculateImpostorScores(s014Mean, s085);
            impostorScoresUser14User86 = ManhDist.CalculateImpostorScores(s014Mean, s086);
            impostorScoresUser14User87 = ManhDist.CalculateImpostorScores(s014Mean, s087);
            impostorScoresUser14User88 = ManhDist.CalculateImpostorScores(s014Mean, s088);
            impostorScoresUser14User89 = ManhDist.CalculateImpostorScores(s014Mean, s089);
            impostorScoresUser14User90 = ManhDist.CalculateImpostorScores(s014Mean, s090);

            impostorScoresUser14User91 = ManhDist.CalculateImpostorScores(s014Mean, s091);
            impostorScoresUser14User92 = ManhDist.CalculateImpostorScores(s014Mean, s092);
            impostorScoresUser14User93 = ManhDist.CalculateImpostorScores(s014Mean, s093);
            impostorScoresUser14User94 = ManhDist.CalculateImpostorScores(s014Mean, s094);
            impostorScoresUser14User95 = ManhDist.CalculateImpostorScores(s014Mean, s095);
            impostorScoresUser14User96 = ManhDist.CalculateImpostorScores(s014Mean, s096);
            impostorScoresUser14User97 = ManhDist.CalculateImpostorScores(s014Mean, s097);
            impostorScoresUser14User98 = ManhDist.CalculateImpostorScores(s014Mean, s098);
            impostorScoresUser14User99 = ManhDist.CalculateImpostorScores(s014Mean, s099);
            impostorScoresUser14User100 = ManhDist.CalculateImpostorScores(s014Mean, s100);
            #endregion

            #region User 15 Impostor scores
            impostorScoresUser15User1 = ManhDist.CalculateImpostorScores(s015Mean, s001);
            impostorScoresUser15User2 = ManhDist.CalculateImpostorScores(s015Mean, s002);
            impostorScoresUser15User3 = ManhDist.CalculateImpostorScores(s015Mean, s003);
            impostorScoresUser15User4 = ManhDist.CalculateImpostorScores(s015Mean, s004);
            impostorScoresUser15User5 = ManhDist.CalculateImpostorScores(s015Mean, s005);
            impostorScoresUser15User6 = ManhDist.CalculateImpostorScores(s015Mean, s006);
            impostorScoresUser15User7 = ManhDist.CalculateImpostorScores(s015Mean, s007);
            impostorScoresUser15User8 = ManhDist.CalculateImpostorScores(s015Mean, s008);
            impostorScoresUser15User9 = ManhDist.CalculateImpostorScores(s015Mean, s009);
            impostorScoresUser15User10 = ManhDist.CalculateImpostorScores(s015Mean, s010);

            impostorScoresUser15User11 = ManhDist.CalculateImpostorScores(s015Mean, s011);
            impostorScoresUser15User12 = ManhDist.CalculateImpostorScores(s015Mean, s012);
            impostorScoresUser15User13 = ManhDist.CalculateImpostorScores(s015Mean, s013);
            impostorScoresUser15User14 = ManhDist.CalculateImpostorScores(s015Mean, s014);
            impostorScoresUser15User16 = ManhDist.CalculateImpostorScores(s015Mean, s016);
            impostorScoresUser15User17 = ManhDist.CalculateImpostorScores(s015Mean, s017);
            impostorScoresUser15User18 = ManhDist.CalculateImpostorScores(s015Mean, s018);
            impostorScoresUser15User19 = ManhDist.CalculateImpostorScores(s015Mean, s019);
            impostorScoresUser15User20 = ManhDist.CalculateImpostorScores(s015Mean, s020);

            impostorScoresUser15User21 = ManhDist.CalculateImpostorScores(s015Mean, s021);
            impostorScoresUser15User22 = ManhDist.CalculateImpostorScores(s015Mean, s022);
            impostorScoresUser15User23 = ManhDist.CalculateImpostorScores(s015Mean, s023);
            impostorScoresUser15User24 = ManhDist.CalculateImpostorScores(s015Mean, s024);
            impostorScoresUser15User25 = ManhDist.CalculateImpostorScores(s015Mean, s025);
            impostorScoresUser15User26 = ManhDist.CalculateImpostorScores(s015Mean, s026);
            impostorScoresUser15User27 = ManhDist.CalculateImpostorScores(s015Mean, s027);
            impostorScoresUser15User28 = ManhDist.CalculateImpostorScores(s015Mean, s028);
            impostorScoresUser15User29 = ManhDist.CalculateImpostorScores(s015Mean, s029);
            impostorScoresUser15User30 = ManhDist.CalculateImpostorScores(s015Mean, s030);

            impostorScoresUser15User31 = ManhDist.CalculateImpostorScores(s015Mean, s031);
            impostorScoresUser15User32 = ManhDist.CalculateImpostorScores(s015Mean, s032);
            impostorScoresUser15User33 = ManhDist.CalculateImpostorScores(s015Mean, s033);
            impostorScoresUser15User34 = ManhDist.CalculateImpostorScores(s015Mean, s034);
            impostorScoresUser15User35 = ManhDist.CalculateImpostorScores(s015Mean, s035);
            impostorScoresUser15User36 = ManhDist.CalculateImpostorScores(s015Mean, s036);
            impostorScoresUser15User37 = ManhDist.CalculateImpostorScores(s015Mean, s037);
            impostorScoresUser15User38 = ManhDist.CalculateImpostorScores(s015Mean, s038);
            impostorScoresUser15User39 = ManhDist.CalculateImpostorScores(s015Mean, s039);
            impostorScoresUser15User40 = ManhDist.CalculateImpostorScores(s015Mean, s040);

            impostorScoresUser15User41 = ManhDist.CalculateImpostorScores(s015Mean, s041);
            impostorScoresUser15User42 = ManhDist.CalculateImpostorScores(s015Mean, s042);
            impostorScoresUser15User43 = ManhDist.CalculateImpostorScores(s015Mean, s043);
            impostorScoresUser15User44 = ManhDist.CalculateImpostorScores(s015Mean, s044);
            impostorScoresUser15User45 = ManhDist.CalculateImpostorScores(s015Mean, s045);
            impostorScoresUser15User46 = ManhDist.CalculateImpostorScores(s015Mean, s046);
            impostorScoresUser15User47 = ManhDist.CalculateImpostorScores(s015Mean, s047);
            impostorScoresUser15User48 = ManhDist.CalculateImpostorScores(s015Mean, s048);
            impostorScoresUser15User49 = ManhDist.CalculateImpostorScores(s015Mean, s049);
            impostorScoresUser15User50 = ManhDist.CalculateImpostorScores(s015Mean, s050);

            impostorScoresUser15User51 = ManhDist.CalculateImpostorScores(s015Mean, s051);
            impostorScoresUser15User52 = ManhDist.CalculateImpostorScores(s015Mean, s052);
            impostorScoresUser15User53 = ManhDist.CalculateImpostorScores(s015Mean, s053);
            impostorScoresUser15User54 = ManhDist.CalculateImpostorScores(s015Mean, s054);
            impostorScoresUser15User55 = ManhDist.CalculateImpostorScores(s015Mean, s055);
            impostorScoresUser15User56 = ManhDist.CalculateImpostorScores(s015Mean, s056);
            impostorScoresUser15User57 = ManhDist.CalculateImpostorScores(s015Mean, s057);
            impostorScoresUser15User58 = ManhDist.CalculateImpostorScores(s015Mean, s058);
            impostorScoresUser15User59 = ManhDist.CalculateImpostorScores(s015Mean, s059);
            impostorScoresUser15User60 = ManhDist.CalculateImpostorScores(s015Mean, s060);

            impostorScoresUser15User61 = ManhDist.CalculateImpostorScores(s015Mean, s061);
            impostorScoresUser15User62 = ManhDist.CalculateImpostorScores(s015Mean, s062);
            impostorScoresUser15User63 = ManhDist.CalculateImpostorScores(s015Mean, s063);
            impostorScoresUser15User64 = ManhDist.CalculateImpostorScores(s015Mean, s064);
            impostorScoresUser15User65 = ManhDist.CalculateImpostorScores(s015Mean, s065);
            impostorScoresUser15User66 = ManhDist.CalculateImpostorScores(s015Mean, s066);
            impostorScoresUser15User67 = ManhDist.CalculateImpostorScores(s015Mean, s067);
            impostorScoresUser15User68 = ManhDist.CalculateImpostorScores(s015Mean, s068);
            impostorScoresUser15User69 = ManhDist.CalculateImpostorScores(s015Mean, s069);
            impostorScoresUser15User70 = ManhDist.CalculateImpostorScores(s015Mean, s070);

            impostorScoresUser15User71 = ManhDist.CalculateImpostorScores(s015Mean, s071);
            impostorScoresUser15User72 = ManhDist.CalculateImpostorScores(s015Mean, s072);
            impostorScoresUser15User73 = ManhDist.CalculateImpostorScores(s015Mean, s073);
            impostorScoresUser15User74 = ManhDist.CalculateImpostorScores(s015Mean, s074);
            impostorScoresUser15User75 = ManhDist.CalculateImpostorScores(s015Mean, s075);
            impostorScoresUser15User76 = ManhDist.CalculateImpostorScores(s015Mean, s076);
            impostorScoresUser15User77 = ManhDist.CalculateImpostorScores(s015Mean, s077);
            impostorScoresUser15User78 = ManhDist.CalculateImpostorScores(s015Mean, s078);
            impostorScoresUser15User79 = ManhDist.CalculateImpostorScores(s015Mean, s079);
            impostorScoresUser15User80 = ManhDist.CalculateImpostorScores(s015Mean, s080);

            impostorScoresUser15User81 = ManhDist.CalculateImpostorScores(s015Mean, s081);
            impostorScoresUser15User82 = ManhDist.CalculateImpostorScores(s015Mean, s082);
            impostorScoresUser15User83 = ManhDist.CalculateImpostorScores(s015Mean, s083);
            impostorScoresUser15User84 = ManhDist.CalculateImpostorScores(s015Mean, s084);
            impostorScoresUser15User85 = ManhDist.CalculateImpostorScores(s015Mean, s085);
            impostorScoresUser15User86 = ManhDist.CalculateImpostorScores(s015Mean, s086);
            impostorScoresUser15User87 = ManhDist.CalculateImpostorScores(s015Mean, s087);
            impostorScoresUser15User88 = ManhDist.CalculateImpostorScores(s015Mean, s088);
            impostorScoresUser15User89 = ManhDist.CalculateImpostorScores(s015Mean, s089);
            impostorScoresUser15User90 = ManhDist.CalculateImpostorScores(s015Mean, s090);

            impostorScoresUser15User91 = ManhDist.CalculateImpostorScores(s015Mean, s091);
            impostorScoresUser15User92 = ManhDist.CalculateImpostorScores(s015Mean, s092);
            impostorScoresUser15User93 = ManhDist.CalculateImpostorScores(s015Mean, s093);
            impostorScoresUser15User94 = ManhDist.CalculateImpostorScores(s015Mean, s094);
            impostorScoresUser15User95 = ManhDist.CalculateImpostorScores(s015Mean, s095);
            impostorScoresUser15User96 = ManhDist.CalculateImpostorScores(s015Mean, s096);
            impostorScoresUser15User97 = ManhDist.CalculateImpostorScores(s015Mean, s097);
            impostorScoresUser15User98 = ManhDist.CalculateImpostorScores(s015Mean, s098);
            impostorScoresUser15User99 = ManhDist.CalculateImpostorScores(s015Mean, s099);
            impostorScoresUser15User100 = ManhDist.CalculateImpostorScores(s015Mean, s100); 
            #endregion

            #region User 16 Impostor scores
            impostorScoresUser16User1 = ManhDist.CalculateImpostorScores(s016Mean, s001);
            impostorScoresUser16User2 = ManhDist.CalculateImpostorScores(s016Mean, s002);
            impostorScoresUser16User3 = ManhDist.CalculateImpostorScores(s016Mean, s003);
            impostorScoresUser16User4 = ManhDist.CalculateImpostorScores(s016Mean, s004);
            impostorScoresUser16User5 = ManhDist.CalculateImpostorScores(s016Mean, s005);
            impostorScoresUser16User6 = ManhDist.CalculateImpostorScores(s016Mean, s006);
            impostorScoresUser16User7 = ManhDist.CalculateImpostorScores(s016Mean, s007);
            impostorScoresUser16User8 = ManhDist.CalculateImpostorScores(s016Mean, s008);
            impostorScoresUser16User9 = ManhDist.CalculateImpostorScores(s016Mean, s009);
            impostorScoresUser16User10 = ManhDist.CalculateImpostorScores(s016Mean, s010);

            impostorScoresUser16User11 = ManhDist.CalculateImpostorScores(s016Mean, s011);
            impostorScoresUser16User12 = ManhDist.CalculateImpostorScores(s016Mean, s012);
            impostorScoresUser16User13 = ManhDist.CalculateImpostorScores(s016Mean, s013);
            impostorScoresUser16User14 = ManhDist.CalculateImpostorScores(s016Mean, s014);
            impostorScoresUser16User15 = ManhDist.CalculateImpostorScores(s016Mean, s015);
            impostorScoresUser16User17 = ManhDist.CalculateImpostorScores(s016Mean, s017);
            impostorScoresUser16User18 = ManhDist.CalculateImpostorScores(s016Mean, s018);
            impostorScoresUser16User19 = ManhDist.CalculateImpostorScores(s016Mean, s019);
            impostorScoresUser16User20 = ManhDist.CalculateImpostorScores(s016Mean, s020);

            impostorScoresUser16User21 = ManhDist.CalculateImpostorScores(s016Mean, s021);
            impostorScoresUser16User22 = ManhDist.CalculateImpostorScores(s016Mean, s022);
            impostorScoresUser16User23 = ManhDist.CalculateImpostorScores(s016Mean, s023);
            impostorScoresUser16User24 = ManhDist.CalculateImpostorScores(s016Mean, s024);
            impostorScoresUser16User25 = ManhDist.CalculateImpostorScores(s016Mean, s025);
            impostorScoresUser16User26 = ManhDist.CalculateImpostorScores(s016Mean, s026);
            impostorScoresUser16User27 = ManhDist.CalculateImpostorScores(s016Mean, s027);
            impostorScoresUser16User28 = ManhDist.CalculateImpostorScores(s016Mean, s028);
            impostorScoresUser16User29 = ManhDist.CalculateImpostorScores(s016Mean, s029);
            impostorScoresUser16User30 = ManhDist.CalculateImpostorScores(s016Mean, s030);

            impostorScoresUser16User31 = ManhDist.CalculateImpostorScores(s016Mean, s031);
            impostorScoresUser16User32 = ManhDist.CalculateImpostorScores(s016Mean, s032);
            impostorScoresUser16User33 = ManhDist.CalculateImpostorScores(s016Mean, s033);
            impostorScoresUser16User34 = ManhDist.CalculateImpostorScores(s016Mean, s034);
            impostorScoresUser16User35 = ManhDist.CalculateImpostorScores(s016Mean, s035);
            impostorScoresUser16User36 = ManhDist.CalculateImpostorScores(s016Mean, s036);
            impostorScoresUser16User37 = ManhDist.CalculateImpostorScores(s016Mean, s037);
            impostorScoresUser16User38 = ManhDist.CalculateImpostorScores(s016Mean, s038);
            impostorScoresUser16User39 = ManhDist.CalculateImpostorScores(s016Mean, s039);
            impostorScoresUser16User40 = ManhDist.CalculateImpostorScores(s016Mean, s040);

            impostorScoresUser16User41 = ManhDist.CalculateImpostorScores(s016Mean, s041);
            impostorScoresUser16User42 = ManhDist.CalculateImpostorScores(s016Mean, s042);
            impostorScoresUser16User43 = ManhDist.CalculateImpostorScores(s016Mean, s043);
            impostorScoresUser16User44 = ManhDist.CalculateImpostorScores(s016Mean, s044);
            impostorScoresUser16User45 = ManhDist.CalculateImpostorScores(s016Mean, s045);
            impostorScoresUser16User46 = ManhDist.CalculateImpostorScores(s016Mean, s046);
            impostorScoresUser16User47 = ManhDist.CalculateImpostorScores(s016Mean, s047);
            impostorScoresUser16User48 = ManhDist.CalculateImpostorScores(s016Mean, s048);
            impostorScoresUser16User49 = ManhDist.CalculateImpostorScores(s016Mean, s049);
            impostorScoresUser16User50 = ManhDist.CalculateImpostorScores(s016Mean, s050);

            impostorScoresUser16User51 = ManhDist.CalculateImpostorScores(s016Mean, s051);
            impostorScoresUser16User52 = ManhDist.CalculateImpostorScores(s016Mean, s052);
            impostorScoresUser16User53 = ManhDist.CalculateImpostorScores(s016Mean, s053);
            impostorScoresUser16User54 = ManhDist.CalculateImpostorScores(s016Mean, s054);
            impostorScoresUser16User55 = ManhDist.CalculateImpostorScores(s016Mean, s055);
            impostorScoresUser16User56 = ManhDist.CalculateImpostorScores(s016Mean, s056);
            impostorScoresUser16User57 = ManhDist.CalculateImpostorScores(s016Mean, s057);
            impostorScoresUser16User58 = ManhDist.CalculateImpostorScores(s016Mean, s058);
            impostorScoresUser16User59 = ManhDist.CalculateImpostorScores(s016Mean, s059);
            impostorScoresUser16User60 = ManhDist.CalculateImpostorScores(s016Mean, s060);

            impostorScoresUser16User61 = ManhDist.CalculateImpostorScores(s016Mean, s061);
            impostorScoresUser16User62 = ManhDist.CalculateImpostorScores(s016Mean, s062);
            impostorScoresUser16User63 = ManhDist.CalculateImpostorScores(s016Mean, s063);
            impostorScoresUser16User64 = ManhDist.CalculateImpostorScores(s016Mean, s064);
            impostorScoresUser16User65 = ManhDist.CalculateImpostorScores(s016Mean, s065);
            impostorScoresUser16User66 = ManhDist.CalculateImpostorScores(s016Mean, s066);
            impostorScoresUser16User67 = ManhDist.CalculateImpostorScores(s016Mean, s067);
            impostorScoresUser16User68 = ManhDist.CalculateImpostorScores(s016Mean, s068);
            impostorScoresUser16User69 = ManhDist.CalculateImpostorScores(s016Mean, s069);
            impostorScoresUser16User70 = ManhDist.CalculateImpostorScores(s016Mean, s070);

            impostorScoresUser16User71 = ManhDist.CalculateImpostorScores(s016Mean, s071);
            impostorScoresUser16User72 = ManhDist.CalculateImpostorScores(s016Mean, s072);
            impostorScoresUser16User73 = ManhDist.CalculateImpostorScores(s016Mean, s073);
            impostorScoresUser16User74 = ManhDist.CalculateImpostorScores(s016Mean, s074);
            impostorScoresUser16User75 = ManhDist.CalculateImpostorScores(s016Mean, s075);
            impostorScoresUser16User76 = ManhDist.CalculateImpostorScores(s016Mean, s076);
            impostorScoresUser16User77 = ManhDist.CalculateImpostorScores(s016Mean, s077);
            impostorScoresUser16User78 = ManhDist.CalculateImpostorScores(s016Mean, s078);
            impostorScoresUser16User79 = ManhDist.CalculateImpostorScores(s016Mean, s079);
            impostorScoresUser16User80 = ManhDist.CalculateImpostorScores(s016Mean, s080);

            impostorScoresUser16User81 = ManhDist.CalculateImpostorScores(s016Mean, s081);
            impostorScoresUser16User82 = ManhDist.CalculateImpostorScores(s016Mean, s082);
            impostorScoresUser16User83 = ManhDist.CalculateImpostorScores(s016Mean, s083);
            impostorScoresUser16User84 = ManhDist.CalculateImpostorScores(s016Mean, s084);
            impostorScoresUser16User85 = ManhDist.CalculateImpostorScores(s016Mean, s085);
            impostorScoresUser16User86 = ManhDist.CalculateImpostorScores(s016Mean, s086);
            impostorScoresUser16User87 = ManhDist.CalculateImpostorScores(s016Mean, s087);
            impostorScoresUser16User88 = ManhDist.CalculateImpostorScores(s016Mean, s088);
            impostorScoresUser16User89 = ManhDist.CalculateImpostorScores(s016Mean, s089);
            impostorScoresUser16User90 = ManhDist.CalculateImpostorScores(s016Mean, s090);

            impostorScoresUser16User91 = ManhDist.CalculateImpostorScores(s016Mean, s091);
            impostorScoresUser16User92 = ManhDist.CalculateImpostorScores(s016Mean, s092);
            impostorScoresUser16User93 = ManhDist.CalculateImpostorScores(s016Mean, s093);
            impostorScoresUser16User94 = ManhDist.CalculateImpostorScores(s016Mean, s094);
            impostorScoresUser16User95 = ManhDist.CalculateImpostorScores(s016Mean, s095);
            impostorScoresUser16User96 = ManhDist.CalculateImpostorScores(s016Mean, s096);
            impostorScoresUser16User97 = ManhDist.CalculateImpostorScores(s016Mean, s097);
            impostorScoresUser16User98 = ManhDist.CalculateImpostorScores(s016Mean, s098);
            impostorScoresUser16User99 = ManhDist.CalculateImpostorScores(s016Mean, s099);
            impostorScoresUser16User100 = ManhDist.CalculateImpostorScores(s016Mean, s100);
            #endregion

            #region User 17 Impostor scores
            impostorScoresUser17User1 = ManhDist.CalculateImpostorScores(s017Mean, s001);
            impostorScoresUser17User2 = ManhDist.CalculateImpostorScores(s017Mean, s002);
            impostorScoresUser17User3 = ManhDist.CalculateImpostorScores(s017Mean, s003);
            impostorScoresUser17User4 = ManhDist.CalculateImpostorScores(s017Mean, s004);
            impostorScoresUser17User5 = ManhDist.CalculateImpostorScores(s017Mean, s005);
            impostorScoresUser17User6 = ManhDist.CalculateImpostorScores(s017Mean, s006);
            impostorScoresUser17User7 = ManhDist.CalculateImpostorScores(s017Mean, s007);
            impostorScoresUser17User8 = ManhDist.CalculateImpostorScores(s017Mean, s008);
            impostorScoresUser17User9 = ManhDist.CalculateImpostorScores(s017Mean, s009);
            impostorScoresUser17User10 = ManhDist.CalculateImpostorScores(s017Mean, s010);

            impostorScoresUser17User11 = ManhDist.CalculateImpostorScores(s017Mean, s011);
            impostorScoresUser17User12 = ManhDist.CalculateImpostorScores(s017Mean, s012);
            impostorScoresUser17User13 = ManhDist.CalculateImpostorScores(s017Mean, s013);
            impostorScoresUser17User14 = ManhDist.CalculateImpostorScores(s017Mean, s014);
            impostorScoresUser17User15 = ManhDist.CalculateImpostorScores(s017Mean, s015);
            impostorScoresUser17User16 = ManhDist.CalculateImpostorScores(s017Mean, s016);
            impostorScoresUser17User18 = ManhDist.CalculateImpostorScores(s017Mean, s018);
            impostorScoresUser17User19 = ManhDist.CalculateImpostorScores(s017Mean, s019);
            impostorScoresUser17User20 = ManhDist.CalculateImpostorScores(s017Mean, s020);

            impostorScoresUser17User21 = ManhDist.CalculateImpostorScores(s017Mean, s021);
            impostorScoresUser17User22 = ManhDist.CalculateImpostorScores(s017Mean, s022);
            impostorScoresUser17User23 = ManhDist.CalculateImpostorScores(s017Mean, s023);
            impostorScoresUser17User24 = ManhDist.CalculateImpostorScores(s017Mean, s024);
            impostorScoresUser17User25 = ManhDist.CalculateImpostorScores(s017Mean, s025);
            impostorScoresUser17User26 = ManhDist.CalculateImpostorScores(s017Mean, s026);
            impostorScoresUser17User27 = ManhDist.CalculateImpostorScores(s017Mean, s027);
            impostorScoresUser17User28 = ManhDist.CalculateImpostorScores(s017Mean, s028);
            impostorScoresUser17User29 = ManhDist.CalculateImpostorScores(s017Mean, s029);
            impostorScoresUser17User30 = ManhDist.CalculateImpostorScores(s017Mean, s030);

            impostorScoresUser17User31 = ManhDist.CalculateImpostorScores(s017Mean, s031);
            impostorScoresUser17User32 = ManhDist.CalculateImpostorScores(s017Mean, s032);
            impostorScoresUser17User33 = ManhDist.CalculateImpostorScores(s017Mean, s033);
            impostorScoresUser17User34 = ManhDist.CalculateImpostorScores(s017Mean, s034);
            impostorScoresUser17User35 = ManhDist.CalculateImpostorScores(s017Mean, s035);
            impostorScoresUser17User36 = ManhDist.CalculateImpostorScores(s017Mean, s036);
            impostorScoresUser17User37 = ManhDist.CalculateImpostorScores(s017Mean, s037);
            impostorScoresUser17User38 = ManhDist.CalculateImpostorScores(s017Mean, s038);
            impostorScoresUser17User39 = ManhDist.CalculateImpostorScores(s017Mean, s039);
            impostorScoresUser17User40 = ManhDist.CalculateImpostorScores(s017Mean, s040);

            impostorScoresUser17User41 = ManhDist.CalculateImpostorScores(s017Mean, s041);
            impostorScoresUser17User42 = ManhDist.CalculateImpostorScores(s017Mean, s042);
            impostorScoresUser17User43 = ManhDist.CalculateImpostorScores(s017Mean, s043);
            impostorScoresUser17User44 = ManhDist.CalculateImpostorScores(s017Mean, s044);
            impostorScoresUser17User45 = ManhDist.CalculateImpostorScores(s017Mean, s045);
            impostorScoresUser17User46 = ManhDist.CalculateImpostorScores(s017Mean, s046);
            impostorScoresUser17User47 = ManhDist.CalculateImpostorScores(s017Mean, s047);
            impostorScoresUser17User48 = ManhDist.CalculateImpostorScores(s017Mean, s048);
            impostorScoresUser17User49 = ManhDist.CalculateImpostorScores(s017Mean, s049);
            impostorScoresUser17User50 = ManhDist.CalculateImpostorScores(s017Mean, s050);

            impostorScoresUser17User51 = ManhDist.CalculateImpostorScores(s017Mean, s051);
            impostorScoresUser17User52 = ManhDist.CalculateImpostorScores(s017Mean, s052);
            impostorScoresUser17User53 = ManhDist.CalculateImpostorScores(s017Mean, s053);
            impostorScoresUser17User54 = ManhDist.CalculateImpostorScores(s017Mean, s054);
            impostorScoresUser17User55 = ManhDist.CalculateImpostorScores(s017Mean, s055);
            impostorScoresUser17User56 = ManhDist.CalculateImpostorScores(s017Mean, s056);
            impostorScoresUser17User57 = ManhDist.CalculateImpostorScores(s017Mean, s057);
            impostorScoresUser17User58 = ManhDist.CalculateImpostorScores(s017Mean, s058);
            impostorScoresUser17User59 = ManhDist.CalculateImpostorScores(s017Mean, s059);
            impostorScoresUser17User60 = ManhDist.CalculateImpostorScores(s017Mean, s060);

            impostorScoresUser17User61 = ManhDist.CalculateImpostorScores(s017Mean, s061);
            impostorScoresUser17User62 = ManhDist.CalculateImpostorScores(s017Mean, s062);
            impostorScoresUser17User63 = ManhDist.CalculateImpostorScores(s017Mean, s063);
            impostorScoresUser17User64 = ManhDist.CalculateImpostorScores(s017Mean, s064);
            impostorScoresUser17User65 = ManhDist.CalculateImpostorScores(s017Mean, s065);
            impostorScoresUser17User66 = ManhDist.CalculateImpostorScores(s017Mean, s066);
            impostorScoresUser17User67 = ManhDist.CalculateImpostorScores(s017Mean, s067);
            impostorScoresUser17User68 = ManhDist.CalculateImpostorScores(s017Mean, s068);
            impostorScoresUser17User69 = ManhDist.CalculateImpostorScores(s017Mean, s069);
            impostorScoresUser17User70 = ManhDist.CalculateImpostorScores(s017Mean, s070);

            impostorScoresUser17User71 = ManhDist.CalculateImpostorScores(s017Mean, s071);
            impostorScoresUser17User72 = ManhDist.CalculateImpostorScores(s017Mean, s072);
            impostorScoresUser17User73 = ManhDist.CalculateImpostorScores(s017Mean, s073);
            impostorScoresUser17User74 = ManhDist.CalculateImpostorScores(s017Mean, s074);
            impostorScoresUser17User75 = ManhDist.CalculateImpostorScores(s017Mean, s075);
            impostorScoresUser17User76 = ManhDist.CalculateImpostorScores(s017Mean, s076);
            impostorScoresUser17User77 = ManhDist.CalculateImpostorScores(s017Mean, s077);
            impostorScoresUser17User78 = ManhDist.CalculateImpostorScores(s017Mean, s078);
            impostorScoresUser17User79 = ManhDist.CalculateImpostorScores(s017Mean, s079);
            impostorScoresUser17User80 = ManhDist.CalculateImpostorScores(s017Mean, s080);

            impostorScoresUser17User81 = ManhDist.CalculateImpostorScores(s017Mean, s081);
            impostorScoresUser17User82 = ManhDist.CalculateImpostorScores(s017Mean, s082);
            impostorScoresUser17User83 = ManhDist.CalculateImpostorScores(s017Mean, s083);
            impostorScoresUser17User84 = ManhDist.CalculateImpostorScores(s017Mean, s084);
            impostorScoresUser17User85 = ManhDist.CalculateImpostorScores(s017Mean, s085);
            impostorScoresUser17User86 = ManhDist.CalculateImpostorScores(s017Mean, s086);
            impostorScoresUser17User87 = ManhDist.CalculateImpostorScores(s017Mean, s087);
            impostorScoresUser17User88 = ManhDist.CalculateImpostorScores(s017Mean, s088);
            impostorScoresUser17User89 = ManhDist.CalculateImpostorScores(s017Mean, s089);
            impostorScoresUser17User90 = ManhDist.CalculateImpostorScores(s017Mean, s090);

            impostorScoresUser17User91 = ManhDist.CalculateImpostorScores(s017Mean, s091);
            impostorScoresUser17User92 = ManhDist.CalculateImpostorScores(s017Mean, s092);
            impostorScoresUser17User93 = ManhDist.CalculateImpostorScores(s017Mean, s093);
            impostorScoresUser17User94 = ManhDist.CalculateImpostorScores(s017Mean, s094);
            impostorScoresUser17User95 = ManhDist.CalculateImpostorScores(s017Mean, s095);
            impostorScoresUser17User96 = ManhDist.CalculateImpostorScores(s017Mean, s096);
            impostorScoresUser17User97 = ManhDist.CalculateImpostorScores(s017Mean, s097);
            impostorScoresUser17User98 = ManhDist.CalculateImpostorScores(s017Mean, s098);
            impostorScoresUser17User99 = ManhDist.CalculateImpostorScores(s017Mean, s099);
            impostorScoresUser17User100 = ManhDist.CalculateImpostorScores(s017Mean, s100);
            #endregion

            #region User 18 Impostor scores
            impostorScoresUser18User1 = ManhDist.CalculateImpostorScores(s018Mean, s001);
            impostorScoresUser18User2 = ManhDist.CalculateImpostorScores(s018Mean, s002);
            impostorScoresUser18User3 = ManhDist.CalculateImpostorScores(s018Mean, s003);
            impostorScoresUser18User4 = ManhDist.CalculateImpostorScores(s018Mean, s004);
            impostorScoresUser18User5 = ManhDist.CalculateImpostorScores(s018Mean, s005);
            impostorScoresUser18User6 = ManhDist.CalculateImpostorScores(s018Mean, s006);
            impostorScoresUser18User7 = ManhDist.CalculateImpostorScores(s018Mean, s007);
            impostorScoresUser18User8 = ManhDist.CalculateImpostorScores(s018Mean, s008);
            impostorScoresUser18User9 = ManhDist.CalculateImpostorScores(s018Mean, s009);
            impostorScoresUser18User10 = ManhDist.CalculateImpostorScores(s018Mean, s010);

            impostorScoresUser18User11 = ManhDist.CalculateImpostorScores(s018Mean, s011);
            impostorScoresUser18User12 = ManhDist.CalculateImpostorScores(s018Mean, s012);
            impostorScoresUser18User13 = ManhDist.CalculateImpostorScores(s018Mean, s013);
            impostorScoresUser18User14 = ManhDist.CalculateImpostorScores(s018Mean, s014);
            impostorScoresUser18User15 = ManhDist.CalculateImpostorScores(s018Mean, s015);
            impostorScoresUser18User16 = ManhDist.CalculateImpostorScores(s018Mean, s016);
            impostorScoresUser18User17 = ManhDist.CalculateImpostorScores(s018Mean, s017);
            impostorScoresUser18User19 = ManhDist.CalculateImpostorScores(s018Mean, s019);
            impostorScoresUser18User20 = ManhDist.CalculateImpostorScores(s018Mean, s020);

            impostorScoresUser18User21 = ManhDist.CalculateImpostorScores(s018Mean, s021);
            impostorScoresUser18User22 = ManhDist.CalculateImpostorScores(s018Mean, s022);
            impostorScoresUser18User23 = ManhDist.CalculateImpostorScores(s018Mean, s023);
            impostorScoresUser18User24 = ManhDist.CalculateImpostorScores(s018Mean, s024);
            impostorScoresUser18User25 = ManhDist.CalculateImpostorScores(s018Mean, s025);
            impostorScoresUser18User26 = ManhDist.CalculateImpostorScores(s018Mean, s026);
            impostorScoresUser18User27 = ManhDist.CalculateImpostorScores(s018Mean, s027);
            impostorScoresUser18User28 = ManhDist.CalculateImpostorScores(s018Mean, s028);
            impostorScoresUser18User29 = ManhDist.CalculateImpostorScores(s018Mean, s029);
            impostorScoresUser18User30 = ManhDist.CalculateImpostorScores(s018Mean, s030);

            impostorScoresUser18User31 = ManhDist.CalculateImpostorScores(s018Mean, s031);
            impostorScoresUser18User32 = ManhDist.CalculateImpostorScores(s018Mean, s032);
            impostorScoresUser18User33 = ManhDist.CalculateImpostorScores(s018Mean, s033);
            impostorScoresUser18User34 = ManhDist.CalculateImpostorScores(s018Mean, s034);
            impostorScoresUser18User35 = ManhDist.CalculateImpostorScores(s018Mean, s035);
            impostorScoresUser18User36 = ManhDist.CalculateImpostorScores(s018Mean, s036);
            impostorScoresUser18User37 = ManhDist.CalculateImpostorScores(s018Mean, s037);
            impostorScoresUser18User38 = ManhDist.CalculateImpostorScores(s018Mean, s038);
            impostorScoresUser18User39 = ManhDist.CalculateImpostorScores(s018Mean, s039);
            impostorScoresUser18User40 = ManhDist.CalculateImpostorScores(s018Mean, s040);

            impostorScoresUser18User41 = ManhDist.CalculateImpostorScores(s018Mean, s041);
            impostorScoresUser18User42 = ManhDist.CalculateImpostorScores(s018Mean, s042);
            impostorScoresUser18User43 = ManhDist.CalculateImpostorScores(s018Mean, s043);
            impostorScoresUser18User44 = ManhDist.CalculateImpostorScores(s018Mean, s044);
            impostorScoresUser18User45 = ManhDist.CalculateImpostorScores(s018Mean, s045);
            impostorScoresUser18User46 = ManhDist.CalculateImpostorScores(s018Mean, s046);
            impostorScoresUser18User47 = ManhDist.CalculateImpostorScores(s018Mean, s047);
            impostorScoresUser18User48 = ManhDist.CalculateImpostorScores(s018Mean, s048);
            impostorScoresUser18User49 = ManhDist.CalculateImpostorScores(s018Mean, s049);
            impostorScoresUser18User50 = ManhDist.CalculateImpostorScores(s018Mean, s050);

            impostorScoresUser18User51 = ManhDist.CalculateImpostorScores(s018Mean, s051);
            impostorScoresUser18User52 = ManhDist.CalculateImpostorScores(s018Mean, s052);
            impostorScoresUser18User53 = ManhDist.CalculateImpostorScores(s018Mean, s053);
            impostorScoresUser18User54 = ManhDist.CalculateImpostorScores(s018Mean, s054);
            impostorScoresUser18User55 = ManhDist.CalculateImpostorScores(s018Mean, s055);
            impostorScoresUser18User56 = ManhDist.CalculateImpostorScores(s018Mean, s056);
            impostorScoresUser18User57 = ManhDist.CalculateImpostorScores(s018Mean, s057);
            impostorScoresUser18User58 = ManhDist.CalculateImpostorScores(s018Mean, s058);
            impostorScoresUser18User59 = ManhDist.CalculateImpostorScores(s018Mean, s059);
            impostorScoresUser18User60 = ManhDist.CalculateImpostorScores(s018Mean, s060);

            impostorScoresUser18User61 = ManhDist.CalculateImpostorScores(s018Mean, s061);
            impostorScoresUser18User62 = ManhDist.CalculateImpostorScores(s018Mean, s062);
            impostorScoresUser18User63 = ManhDist.CalculateImpostorScores(s018Mean, s063);
            impostorScoresUser18User64 = ManhDist.CalculateImpostorScores(s018Mean, s064);
            impostorScoresUser18User65 = ManhDist.CalculateImpostorScores(s018Mean, s065);
            impostorScoresUser18User66 = ManhDist.CalculateImpostorScores(s018Mean, s066);
            impostorScoresUser18User67 = ManhDist.CalculateImpostorScores(s018Mean, s067);
            impostorScoresUser18User68 = ManhDist.CalculateImpostorScores(s018Mean, s068);
            impostorScoresUser18User69 = ManhDist.CalculateImpostorScores(s018Mean, s069);
            impostorScoresUser18User70 = ManhDist.CalculateImpostorScores(s018Mean, s070);

            impostorScoresUser18User71 = ManhDist.CalculateImpostorScores(s018Mean, s071);
            impostorScoresUser18User72 = ManhDist.CalculateImpostorScores(s018Mean, s072);
            impostorScoresUser18User73 = ManhDist.CalculateImpostorScores(s018Mean, s073);
            impostorScoresUser18User74 = ManhDist.CalculateImpostorScores(s018Mean, s074);
            impostorScoresUser18User75 = ManhDist.CalculateImpostorScores(s018Mean, s075);
            impostorScoresUser18User76 = ManhDist.CalculateImpostorScores(s018Mean, s076);
            impostorScoresUser18User77 = ManhDist.CalculateImpostorScores(s018Mean, s077);
            impostorScoresUser18User78 = ManhDist.CalculateImpostorScores(s018Mean, s078);
            impostorScoresUser18User79 = ManhDist.CalculateImpostorScores(s018Mean, s079);
            impostorScoresUser18User80 = ManhDist.CalculateImpostorScores(s018Mean, s080);

            impostorScoresUser18User81 = ManhDist.CalculateImpostorScores(s018Mean, s081);
            impostorScoresUser18User82 = ManhDist.CalculateImpostorScores(s018Mean, s082);
            impostorScoresUser18User83 = ManhDist.CalculateImpostorScores(s018Mean, s083);
            impostorScoresUser18User84 = ManhDist.CalculateImpostorScores(s018Mean, s084);
            impostorScoresUser18User85 = ManhDist.CalculateImpostorScores(s018Mean, s085);
            impostorScoresUser18User86 = ManhDist.CalculateImpostorScores(s018Mean, s086);
            impostorScoresUser18User87 = ManhDist.CalculateImpostorScores(s018Mean, s087);
            impostorScoresUser18User88 = ManhDist.CalculateImpostorScores(s018Mean, s088);
            impostorScoresUser18User89 = ManhDist.CalculateImpostorScores(s018Mean, s089);
            impostorScoresUser18User90 = ManhDist.CalculateImpostorScores(s018Mean, s090);

            impostorScoresUser18User91 = ManhDist.CalculateImpostorScores(s018Mean, s091);
            impostorScoresUser18User92 = ManhDist.CalculateImpostorScores(s018Mean, s092);
            impostorScoresUser18User93 = ManhDist.CalculateImpostorScores(s018Mean, s093);
            impostorScoresUser18User94 = ManhDist.CalculateImpostorScores(s018Mean, s094);
            impostorScoresUser18User95 = ManhDist.CalculateImpostorScores(s018Mean, s095);
            impostorScoresUser18User96 = ManhDist.CalculateImpostorScores(s018Mean, s096);
            impostorScoresUser18User97 = ManhDist.CalculateImpostorScores(s018Mean, s097);
            impostorScoresUser18User98 = ManhDist.CalculateImpostorScores(s018Mean, s098);
            impostorScoresUser18User99 = ManhDist.CalculateImpostorScores(s018Mean, s099);
            impostorScoresUser18User100 = ManhDist.CalculateImpostorScores(s018Mean, s100);
            #endregion

            #region User 19 Impostor scores
            impostorScoresUser19User1 = ManhDist.CalculateImpostorScores(s019Mean, s001);
            impostorScoresUser19User2 = ManhDist.CalculateImpostorScores(s019Mean, s002);
            impostorScoresUser19User3 = ManhDist.CalculateImpostorScores(s019Mean, s003);
            impostorScoresUser19User4 = ManhDist.CalculateImpostorScores(s019Mean, s004);
            impostorScoresUser19User5 = ManhDist.CalculateImpostorScores(s019Mean, s005);
            impostorScoresUser19User6 = ManhDist.CalculateImpostorScores(s019Mean, s006);
            impostorScoresUser19User7 = ManhDist.CalculateImpostorScores(s019Mean, s007);
            impostorScoresUser19User8 = ManhDist.CalculateImpostorScores(s019Mean, s008);
            impostorScoresUser19User9 = ManhDist.CalculateImpostorScores(s019Mean, s009);
            impostorScoresUser19User10 = ManhDist.CalculateImpostorScores(s019Mean, s010);

            impostorScoresUser19User11 = ManhDist.CalculateImpostorScores(s019Mean, s011);
            impostorScoresUser19User12 = ManhDist.CalculateImpostorScores(s019Mean, s012);
            impostorScoresUser19User13 = ManhDist.CalculateImpostorScores(s019Mean, s013);
            impostorScoresUser19User14 = ManhDist.CalculateImpostorScores(s019Mean, s014);
            impostorScoresUser19User15 = ManhDist.CalculateImpostorScores(s019Mean, s015);
            impostorScoresUser19User16 = ManhDist.CalculateImpostorScores(s019Mean, s016);
            impostorScoresUser19User17 = ManhDist.CalculateImpostorScores(s019Mean, s017);
            impostorScoresUser19User18 = ManhDist.CalculateImpostorScores(s019Mean, s018);
            impostorScoresUser19User20 = ManhDist.CalculateImpostorScores(s019Mean, s020);

            impostorScoresUser19User21 = ManhDist.CalculateImpostorScores(s019Mean, s021);
            impostorScoresUser19User22 = ManhDist.CalculateImpostorScores(s019Mean, s022);
            impostorScoresUser19User23 = ManhDist.CalculateImpostorScores(s019Mean, s023);
            impostorScoresUser19User24 = ManhDist.CalculateImpostorScores(s019Mean, s024);
            impostorScoresUser19User25 = ManhDist.CalculateImpostorScores(s019Mean, s025);
            impostorScoresUser19User26 = ManhDist.CalculateImpostorScores(s019Mean, s026);
            impostorScoresUser19User27 = ManhDist.CalculateImpostorScores(s019Mean, s027);
            impostorScoresUser19User28 = ManhDist.CalculateImpostorScores(s019Mean, s028);
            impostorScoresUser19User29 = ManhDist.CalculateImpostorScores(s019Mean, s029);
            impostorScoresUser19User30 = ManhDist.CalculateImpostorScores(s019Mean, s030);

            impostorScoresUser19User31 = ManhDist.CalculateImpostorScores(s019Mean, s031);
            impostorScoresUser19User32 = ManhDist.CalculateImpostorScores(s019Mean, s032);
            impostorScoresUser19User33 = ManhDist.CalculateImpostorScores(s019Mean, s033);
            impostorScoresUser19User34 = ManhDist.CalculateImpostorScores(s019Mean, s034);
            impostorScoresUser19User35 = ManhDist.CalculateImpostorScores(s019Mean, s035);
            impostorScoresUser19User36 = ManhDist.CalculateImpostorScores(s019Mean, s036);
            impostorScoresUser19User37 = ManhDist.CalculateImpostorScores(s019Mean, s037);
            impostorScoresUser19User38 = ManhDist.CalculateImpostorScores(s019Mean, s038);
            impostorScoresUser19User39 = ManhDist.CalculateImpostorScores(s019Mean, s039);
            impostorScoresUser19User40 = ManhDist.CalculateImpostorScores(s019Mean, s040);

            impostorScoresUser19User41 = ManhDist.CalculateImpostorScores(s019Mean, s041);
            impostorScoresUser19User42 = ManhDist.CalculateImpostorScores(s019Mean, s042);
            impostorScoresUser19User43 = ManhDist.CalculateImpostorScores(s019Mean, s043);
            impostorScoresUser19User44 = ManhDist.CalculateImpostorScores(s019Mean, s044);
            impostorScoresUser19User45 = ManhDist.CalculateImpostorScores(s019Mean, s045);
            impostorScoresUser19User46 = ManhDist.CalculateImpostorScores(s019Mean, s046);
            impostorScoresUser19User47 = ManhDist.CalculateImpostorScores(s019Mean, s047);
            impostorScoresUser19User48 = ManhDist.CalculateImpostorScores(s019Mean, s048);
            impostorScoresUser19User49 = ManhDist.CalculateImpostorScores(s019Mean, s049);
            impostorScoresUser19User50 = ManhDist.CalculateImpostorScores(s019Mean, s050);

            impostorScoresUser19User51 = ManhDist.CalculateImpostorScores(s019Mean, s051);
            impostorScoresUser19User52 = ManhDist.CalculateImpostorScores(s019Mean, s052);
            impostorScoresUser19User53 = ManhDist.CalculateImpostorScores(s019Mean, s053);
            impostorScoresUser19User54 = ManhDist.CalculateImpostorScores(s019Mean, s054);
            impostorScoresUser19User55 = ManhDist.CalculateImpostorScores(s019Mean, s055);
            impostorScoresUser19User56 = ManhDist.CalculateImpostorScores(s019Mean, s056);
            impostorScoresUser19User57 = ManhDist.CalculateImpostorScores(s019Mean, s057);
            impostorScoresUser19User58 = ManhDist.CalculateImpostorScores(s019Mean, s058);
            impostorScoresUser19User59 = ManhDist.CalculateImpostorScores(s019Mean, s059);
            impostorScoresUser19User60 = ManhDist.CalculateImpostorScores(s019Mean, s060);

            impostorScoresUser19User61 = ManhDist.CalculateImpostorScores(s019Mean, s061);
            impostorScoresUser19User62 = ManhDist.CalculateImpostorScores(s019Mean, s062);
            impostorScoresUser19User63 = ManhDist.CalculateImpostorScores(s019Mean, s063);
            impostorScoresUser19User64 = ManhDist.CalculateImpostorScores(s019Mean, s064);
            impostorScoresUser19User65 = ManhDist.CalculateImpostorScores(s019Mean, s065);
            impostorScoresUser19User66 = ManhDist.CalculateImpostorScores(s019Mean, s066);
            impostorScoresUser19User67 = ManhDist.CalculateImpostorScores(s019Mean, s067);
            impostorScoresUser19User68 = ManhDist.CalculateImpostorScores(s019Mean, s068);
            impostorScoresUser19User69 = ManhDist.CalculateImpostorScores(s019Mean, s069);
            impostorScoresUser19User70 = ManhDist.CalculateImpostorScores(s019Mean, s070);

            impostorScoresUser19User71 = ManhDist.CalculateImpostorScores(s019Mean, s071);
            impostorScoresUser19User72 = ManhDist.CalculateImpostorScores(s019Mean, s072);
            impostorScoresUser19User73 = ManhDist.CalculateImpostorScores(s019Mean, s073);
            impostorScoresUser19User74 = ManhDist.CalculateImpostorScores(s019Mean, s074);
            impostorScoresUser19User75 = ManhDist.CalculateImpostorScores(s019Mean, s075);
            impostorScoresUser19User76 = ManhDist.CalculateImpostorScores(s019Mean, s076);
            impostorScoresUser19User77 = ManhDist.CalculateImpostorScores(s019Mean, s077);
            impostorScoresUser19User78 = ManhDist.CalculateImpostorScores(s019Mean, s078);
            impostorScoresUser19User79 = ManhDist.CalculateImpostorScores(s019Mean, s079);
            impostorScoresUser19User80 = ManhDist.CalculateImpostorScores(s019Mean, s080);

            impostorScoresUser19User81 = ManhDist.CalculateImpostorScores(s019Mean, s081);
            impostorScoresUser19User82 = ManhDist.CalculateImpostorScores(s019Mean, s082);
            impostorScoresUser19User83 = ManhDist.CalculateImpostorScores(s019Mean, s083);
            impostorScoresUser19User84 = ManhDist.CalculateImpostorScores(s019Mean, s084);
            impostorScoresUser19User85 = ManhDist.CalculateImpostorScores(s019Mean, s085);
            impostorScoresUser19User86 = ManhDist.CalculateImpostorScores(s019Mean, s086);
            impostorScoresUser19User87 = ManhDist.CalculateImpostorScores(s019Mean, s087);
            impostorScoresUser19User88 = ManhDist.CalculateImpostorScores(s019Mean, s088);
            impostorScoresUser19User89 = ManhDist.CalculateImpostorScores(s019Mean, s089);
            impostorScoresUser19User90 = ManhDist.CalculateImpostorScores(s019Mean, s090);

            impostorScoresUser19User91 = ManhDist.CalculateImpostorScores(s019Mean, s091);
            impostorScoresUser19User92 = ManhDist.CalculateImpostorScores(s019Mean, s092);
            impostorScoresUser19User93 = ManhDist.CalculateImpostorScores(s019Mean, s093);
            impostorScoresUser19User94 = ManhDist.CalculateImpostorScores(s019Mean, s094);
            impostorScoresUser19User95 = ManhDist.CalculateImpostorScores(s019Mean, s095);
            impostorScoresUser19User96 = ManhDist.CalculateImpostorScores(s019Mean, s096);
            impostorScoresUser19User97 = ManhDist.CalculateImpostorScores(s019Mean, s097);
            impostorScoresUser19User98 = ManhDist.CalculateImpostorScores(s019Mean, s098);
            impostorScoresUser19User99 = ManhDist.CalculateImpostorScores(s019Mean, s099);
            impostorScoresUser19User100 = ManhDist.CalculateImpostorScores(s019Mean, s100);
            #endregion

            #region User 20 Impostor scores
            impostorScoresUser20User1 = ManhDist.CalculateImpostorScores(s020Mean, s001);
            impostorScoresUser20User2 = ManhDist.CalculateImpostorScores(s020Mean, s002);
            impostorScoresUser20User3 = ManhDist.CalculateImpostorScores(s020Mean, s003);
            impostorScoresUser20User4 = ManhDist.CalculateImpostorScores(s020Mean, s004);
            impostorScoresUser20User5 = ManhDist.CalculateImpostorScores(s020Mean, s005);
            impostorScoresUser20User6 = ManhDist.CalculateImpostorScores(s020Mean, s006);
            impostorScoresUser20User7 = ManhDist.CalculateImpostorScores(s020Mean, s007);
            impostorScoresUser20User8 = ManhDist.CalculateImpostorScores(s020Mean, s008);
            impostorScoresUser20User9 = ManhDist.CalculateImpostorScores(s020Mean, s009);
            impostorScoresUser20User10 = ManhDist.CalculateImpostorScores(s020Mean, s010);

            impostorScoresUser20User11 = ManhDist.CalculateImpostorScores(s020Mean, s011);
            impostorScoresUser20User12 = ManhDist.CalculateImpostorScores(s020Mean, s012);
            impostorScoresUser20User13 = ManhDist.CalculateImpostorScores(s020Mean, s013);
            impostorScoresUser20User14 = ManhDist.CalculateImpostorScores(s020Mean, s014);
            impostorScoresUser20User15 = ManhDist.CalculateImpostorScores(s020Mean, s015);
            impostorScoresUser20User16 = ManhDist.CalculateImpostorScores(s020Mean, s016);
            impostorScoresUser20User17 = ManhDist.CalculateImpostorScores(s020Mean, s017);
            impostorScoresUser20User18 = ManhDist.CalculateImpostorScores(s020Mean, s018);
            impostorScoresUser20User19 = ManhDist.CalculateImpostorScores(s020Mean, s019);

            impostorScoresUser20User21 = ManhDist.CalculateImpostorScores(s020Mean, s021);
            impostorScoresUser20User22 = ManhDist.CalculateImpostorScores(s020Mean, s022);
            impostorScoresUser20User23 = ManhDist.CalculateImpostorScores(s020Mean, s023);
            impostorScoresUser20User24 = ManhDist.CalculateImpostorScores(s020Mean, s024);
            impostorScoresUser20User25 = ManhDist.CalculateImpostorScores(s020Mean, s025);
            impostorScoresUser20User26 = ManhDist.CalculateImpostorScores(s020Mean, s026);
            impostorScoresUser20User27 = ManhDist.CalculateImpostorScores(s020Mean, s027);
            impostorScoresUser20User28 = ManhDist.CalculateImpostorScores(s020Mean, s028);
            impostorScoresUser20User29 = ManhDist.CalculateImpostorScores(s020Mean, s029);
            impostorScoresUser20User30 = ManhDist.CalculateImpostorScores(s020Mean, s030);

            impostorScoresUser20User31 = ManhDist.CalculateImpostorScores(s020Mean, s031);
            impostorScoresUser20User32 = ManhDist.CalculateImpostorScores(s020Mean, s032);
            impostorScoresUser20User33 = ManhDist.CalculateImpostorScores(s020Mean, s033);
            impostorScoresUser20User34 = ManhDist.CalculateImpostorScores(s020Mean, s034);
            impostorScoresUser20User35 = ManhDist.CalculateImpostorScores(s020Mean, s035);
            impostorScoresUser20User36 = ManhDist.CalculateImpostorScores(s020Mean, s036);
            impostorScoresUser20User37 = ManhDist.CalculateImpostorScores(s020Mean, s037);
            impostorScoresUser20User38 = ManhDist.CalculateImpostorScores(s020Mean, s038);
            impostorScoresUser20User39 = ManhDist.CalculateImpostorScores(s020Mean, s039);
            impostorScoresUser20User40 = ManhDist.CalculateImpostorScores(s020Mean, s040);

            impostorScoresUser20User41 = ManhDist.CalculateImpostorScores(s020Mean, s041);
            impostorScoresUser20User42 = ManhDist.CalculateImpostorScores(s020Mean, s042);
            impostorScoresUser20User43 = ManhDist.CalculateImpostorScores(s020Mean, s043);
            impostorScoresUser20User44 = ManhDist.CalculateImpostorScores(s020Mean, s044);
            impostorScoresUser20User45 = ManhDist.CalculateImpostorScores(s020Mean, s045);
            impostorScoresUser20User46 = ManhDist.CalculateImpostorScores(s020Mean, s046);
            impostorScoresUser20User47 = ManhDist.CalculateImpostorScores(s020Mean, s047);
            impostorScoresUser20User48 = ManhDist.CalculateImpostorScores(s020Mean, s048);
            impostorScoresUser20User49 = ManhDist.CalculateImpostorScores(s020Mean, s049);
            impostorScoresUser20User50 = ManhDist.CalculateImpostorScores(s020Mean, s050);

            impostorScoresUser20User51 = ManhDist.CalculateImpostorScores(s020Mean, s051);
            impostorScoresUser20User52 = ManhDist.CalculateImpostorScores(s020Mean, s052);
            impostorScoresUser20User53 = ManhDist.CalculateImpostorScores(s020Mean, s053);
            impostorScoresUser20User54 = ManhDist.CalculateImpostorScores(s020Mean, s054);
            impostorScoresUser20User55 = ManhDist.CalculateImpostorScores(s020Mean, s055);
            impostorScoresUser20User56 = ManhDist.CalculateImpostorScores(s020Mean, s056);
            impostorScoresUser20User57 = ManhDist.CalculateImpostorScores(s020Mean, s057);
            impostorScoresUser20User58 = ManhDist.CalculateImpostorScores(s020Mean, s058); 
            #endregion

            #endregion
        }

        #endregion
    }
}