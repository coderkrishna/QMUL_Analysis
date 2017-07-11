/* 
 * Author: Pranav S. Krishnamurthy
 * 
 * File Name: Program.cs
 * 
 * Version History
 * 
 * Version  Date        Who     Description
 * -------  ----------  ------- -------------- 
 * 2.0.0    2017-02-17  PKR     Ensuring to have a printer class to take the double 2D arrays and convert them into 2D string arrays
 * 2.1.0    2017-06-25  PKR     Ensuring to have a separate class to encapsulate all of the Impostor Scores
 * 2.1.1    2017-06-26  PKR     Having further variables and verifier methods up-to-date
 * 2.2.0    2017-07-05  PKR     Ensuring to have all of the variables for the impostor scores of user 9 done - and populated.  Later on will be
 *                              going into calculating the equal error rates
 */
using System;
using OperationsLib;

///<summary>
/// Source of the Data: http://www.eecs.qmul.ac.uk/~ccloy/downloads_keystroke100.html
///</summary>

namespace QUML_Keystrokes
{
    class Program : ImpostorScoreVars
    {
        #region Static 2D Double arrays for all of the users
        static double[,] s001; static double[,] s002; static double[,] s003; static double[,] s004; static double[,] s005; static double[,] s006;
        static double[,] s007; static double[,] s008; static double[,] s009; static double[,] s010; static double[,] s011; static double[,] s012;
        static double[,] s013; static double[,] s014; static double[,] s015; static double[,] s016; static double[,] s017; static double[,] s018;
        static double[,] s019; static double[,] s020; static double[,] s021; static double[,] s022; static double[,] s023; static double[,] s024;
        static double[,] s025; static double[,] s026; static double[,] s027; static double[,] s028; static double[,] s029; static double[,] s030;

        static double[,] s031; static double[,] s032; static double[,] s033; static double[,] s034; static double[,] s035; static double[,] s036;
        static double[,] s037; static double[,] s038; static double[,] s039; static double[,] s040; static double[,] s041; static double[,] s042;
        static double[,] s043; static double[,] s044; static double[,] s045; static double[,] s046; static double[,] s047; static double[,] s048;
        static double[,] s049; static double[,] s050; static double[,] s051; static double[,] s052; static double[,] s053; static double[,] s054;
        static double[,] s055; static double[,] s056; static double[,] s057; static double[,] s058; static double[,] s059; static double[,] s060;

        static double[,] s061; static double[,] s062; static double[,] s063; static double[,] s064; static double[,] s065; static double[,] s066;
        static double[,] s067; static double[,] s068; static double[,] s069; static double[,] s070; static double[,] s071; static double[,] s072;
        static double[,] s073; static double[,] s074; static double[,] s075; static double[,] s076; static double[,] s077; static double[,] s078;
        static double[,] s079; static double[,] s080; static double[,] s081; static double[,] s082; static double[,] s083; static double[,] s084;

        static double[,] s085; static double[,] s086; static double[,] s087; static double[,] s088; static double[,] s089; static double[,] s090;
        static double[,] s091; static double[,] s092; static double[,] s093; static double[,] s094; static double[,] s095; static double[,] s096;
        static double[,] s097; static double[,] s098; static double[,] s099; static double[,] s100;
        #endregion

        #region Static Double arrays for each user - these are the mean arrays, also known as the templates
        static double[] s001Mean; static double[] s002Mean; static double[] s003Mean;
        static double[] s004Mean; static double[] s005Mean; static double[] s006Mean;
        static double[] s007Mean; static double[] s008Mean; static double[] s009Mean;
        static double[] s010Mean;

        static double[] s011Mean; static double[] s012Mean; static double[] s013Mean;
        static double[] s014Mean; static double[] s015Mean; static double[] s016Mean;
        static double[] s017Mean; static double[] s018Mean; static double[] s019Mean;
        static double[] s020Mean;

        static double[] s021Mean; static double[] s022Mean; static double[] s023Mean;
        static double[] s024Mean; static double[] s025Mean; static double[] s026Mean;
        static double[] s027Mean; static double[] s028Mean; static double[] s029Mean;
        static double[] s030Mean;

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
        static double[] s064Mean; static double[] s065Mean; static double[] s066Mean;
        static double[] s067Mean; static double[] s068Mean; static double[] s069Mean;
        static double[] s070Mean;

        static double[] s071Mean; static double[] s072Mean; static double[] s073Mean;
        static double[] s074Mean; static double[] s075Mean; static double[] s076Mean;
        static double[] s077Mean; static double[] s078Mean; static double[] s079Mean;
        static double[] s080Mean;

        static double[] s081Mean; static double[] s082Mean; static double[] s083Mean;
        static double[] s084Mean; static double[] s085Mean; static double[] s086Mean;
        static double[] s087Mean; static double[] s088Mean; static double[] s089Mean;
        static double[] s090Mean;

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
        static double[] stdDevUser1; static double[] stdDevUser2;
        static double[] stdDevUser3; static double[] stdDevUser4;
        static double[] stdDevUser5; static double[] stdDevUser6;
        static double[] stdDevUser7; static double[] stdDevUser8;
        static double[] stdDevUser9; static double[] stdDevUser10;

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

        static void Main(string[] args)
        {
            // The dataFiltering class will be referred to 
            DataFiltering dataFiltr = new DataFiltering();

            // Greeting of the Console
            Console.WriteLine("Welcome to the QUML Analyzer!" + Environment.NewLine);

            #region Data Extraction - This will be done before jumping into the use of any verifier
            s001 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user1.csv");
            s002 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user2.csv");
            s003 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user3.csv");
            s004 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user4.csv");
            s005 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user5.csv");
            s006 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user6.csv");
            s007 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user7.csv");
            s008 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user8.csv");
            s009 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user9.csv");
            s010 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user10.csv");

            s011 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user11.csv");
            s012 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user12.csv");
            s013 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user13.csv");
            s014 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user14.csv");
            s015 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user15.csv");
            s016 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user16.csv");
            s017 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user17.csv");
            s018 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user18.csv");
            s019 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user19.csv");
            s020 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user20.csv");

            s021 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user21.csv");
            s022 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user22.csv");
            s023 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user23.csv");
            s024 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user24.csv");
            s025 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user25.csv");
            s026 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user26.csv");
            s027 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user27.csv");
            s028 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user28.csv");
            s029 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user29.csv");
            s030 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user30.csv");

            s031 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user31.csv");
            s032 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user32.csv");
            s033 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user33.csv");
            s034 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user34.csv");
            s035 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user35.csv");
            s036 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user36.csv");
            s037 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user37.csv");
            s038 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user38.csv");
            s039 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user39.csv");
            s040 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user40.csv");

            s041 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user41.csv");
            s042 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user42.csv");
            s043 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user43.csv");
            s044 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user44.csv");
            s045 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user45.csv");
            s046 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user46.csv");
            s047 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user47.csv");
            s048 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user48.csv");
            s049 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user49.csv");
            s050 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user50.csv");

            s051 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user51.csv");
            s052 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user52.csv");
            s053 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user53.csv");
            s054 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user54.csv");
            s055 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user55.csv");
            s056 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user56.csv");
            s057 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user57.csv");
            s058 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user58.csv");
            s059 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user59.csv");
            s060 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user60.csv");

            s061 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user61.csv");
            s062 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user62.csv");
            s063 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user63.csv");
            s064 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user64.csv");
            s065 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user65.csv");
            s066 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user66.csv");
            s067 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user67.csv");
            s068 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user68.csv");
            s069 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user69.csv");
            s070 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user70.csv");

            s071 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user71.csv");
            s072 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user72.csv");
            s073 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user73.csv");
            s074 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user74.csv");
            s075 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user75.csv");
            s076 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user76.csv");
            s077 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user77.csv");
            s078 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user78.csv");
            s079 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user79.csv");
            s080 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user80.csv");

            s081 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user81.csv");
            s082 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user82.csv");
            s083 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user83.csv");
            s084 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user84.csv");
            s085 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user85.csv");
            s086 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user86.csv");
            s087 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user87.csv");
            s088 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user88.csv");
            s089 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user89.csv");
            s090 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user90.csv");

            s091 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user91.csv");
            s092 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user92.csv");
            s093 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user93.csv");
            s094 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user94.csv");
            s095 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user95.csv");
            s096 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user96.csv");
            s097 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user97.csv");
            s098 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user98.csv");
            s099 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user99.csv");
            s100 = dataFiltr.ParseData(@"D:\GitHub\QMUL_Analysis\QUML_Keystrokes\QUML_Keystrokes\Latency Data\user100.csv");
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

        #region Scaled Manhattan Verifier
        private static void UseScaledManhattanVerifier()
        {
            // Making reference to the ScaledManhattanDistance class
            ScaledManhattanDistance ScaledManhDist = new ScaledManhattanDistance();
            ImpostorScoreVars sv = new ImpostorScoreVars();

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
            sv.ImpostorScoresUser1User2 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s002);
            sv.ImpostorScoresUser1User3 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s003);
            sv.ImpostorScoresUser1User4 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s004);
            sv.ImpostorScoresUser1User5 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s005);
            sv.ImpostorScoresUser1User6 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s006);
            sv.ImpostorScoresUser1User7 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s007);
            sv.ImpostorScoresUser1User8 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s008);
            sv.ImpostorScoresUser1User9 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s009);
            sv.ImpostorScoresUser1User10 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s010);

            sv.ImpostorScoresUser1User11 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s011);
            sv.ImpostorScoresUser1User12 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s012);
            sv.ImpostorScoresUser1User13 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s013);
            sv.ImpostorScoresUser1User14 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s014);
            sv.ImpostorScoresUser1User15 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s015);
            sv.ImpostorScoresUser1User16 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s016);
            sv.ImpostorScoresUser1User17 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s017);
            sv.ImpostorScoresUser1User18 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s018);
            sv.ImpostorScoresUser1User19 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s019);
            sv.ImpostorScoresUser1User20 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s020);

            sv.ImpostorScoresUser1User21 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s021);
            sv.ImpostorScoresUser1User22 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s022);
            sv.ImpostorScoresUser1User23 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s023);
            sv.ImpostorScoresUser1User24 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s024);
            sv.ImpostorScoresUser1User25 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s025);
            sv.ImpostorScoresUser1User26 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s026);
            sv.ImpostorScoresUser1User27 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s027);
            sv.ImpostorScoresUser1User28 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s028);
            sv.ImpostorScoresUser1User29 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s029);
            sv.ImpostorScoresUser1User30 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s030);

            sv.ImpostorScoresUser1User31 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s031);
            sv.ImpostorScoresUser1User32 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s032);
            sv.ImpostorScoresUser1User33 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s033);
            sv.ImpostorScoresUser1User34 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s034);
            sv.ImpostorScoresUser1User35 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s035);
            sv.ImpostorScoresUser1User36 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s036);
            sv.ImpostorScoresUser1User37 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s037);
            sv.ImpostorScoresUser1User38 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s038);
            sv.ImpostorScoresUser1User39 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s039);
            sv.ImpostorScoresUser1User40 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s040);

            sv.ImpostorScoresUser1User41 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s041);
            sv.ImpostorScoresUser1User42 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s042);
            sv.ImpostorScoresUser1User43 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s043);
            sv.ImpostorScoresUser1User44 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s044);
            sv.ImpostorScoresUser1User45 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s045);
            sv.ImpostorScoresUser1User46 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s046);
            sv.ImpostorScoresUser1User47 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s047);
            sv.ImpostorScoresUser1User48 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s048);
            sv.ImpostorScoresUser1User49 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s049);
            sv.ImpostorScoresUser1User50 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s050);

            sv.ImpostorScoresUser1User51 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s051);
            sv.ImpostorScoresUser1User52 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s052);
            sv.ImpostorScoresUser1User53 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s053);
            sv.ImpostorScoresUser1User54 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s054);
            sv.ImpostorScoresUser1User55 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s055);
            sv.ImpostorScoresUser1User56 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s056);
            sv.ImpostorScoresUser1User57 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s057);
            sv.ImpostorScoresUser1User58 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s058);
            sv.ImpostorScoresUser1User59 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s059);
            sv.ImpostorScoresUser1User60 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s060);

            sv.ImpostorScoresUser1User61 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s061);
            sv.ImpostorScoresUser1User62 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s062);
            sv.ImpostorScoresUser1User63 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s063);
            sv.ImpostorScoresUser1User64 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s064);
            sv.ImpostorScoresUser1User65 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s065);
            sv.ImpostorScoresUser1User66 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s066);
            sv.ImpostorScoresUser1User67 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s067);
            sv.ImpostorScoresUser1User68 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s068);
            sv.ImpostorScoresUser1User69 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s069);
            sv.ImpostorScoresUser1User70 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s070);

            sv.ImpostorScoresUser1User71 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s071);
            sv.ImpostorScoresUser1User72 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s072);
            sv.ImpostorScoresUser1User73 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s073);
            sv.ImpostorScoresUser1User74 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s074);
            sv.ImpostorScoresUser1User75 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s075);
            sv.ImpostorScoresUser1User76 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s076);
            sv.ImpostorScoresUser1User77 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s077);
            sv.ImpostorScoresUser1User78 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s078);
            sv.ImpostorScoresUser1User79 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s079);
            sv.ImpostorScoresUser1User80 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s080);

            sv.ImpostorScoresUser1User81 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s081);
            sv.ImpostorScoresUser1User82 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s082);
            sv.ImpostorScoresUser1User83 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s083);
            sv.ImpostorScoresUser1User84 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s084);
            sv.ImpostorScoresUser1User85 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s085);
            sv.ImpostorScoresUser1User86 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s086);
            sv.ImpostorScoresUser1User87 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s087);
            sv.ImpostorScoresUser1User88 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s088);
            sv.ImpostorScoresUser1User89 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s089);
            sv.ImpostorScoresUser1User90 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s090);

            sv.ImpostorScoresUser1User91 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s091);
            sv.ImpostorScoresUser1User92 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s092);
            sv.ImpostorScoresUser1User93 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s093);
            sv.ImpostorScoresUser1User94 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s094);
            sv.ImpostorScoresUser1User95 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s095);
            sv.ImpostorScoresUser1User96 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s096);
            sv.ImpostorScoresUser1User97 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s097);
            sv.ImpostorScoresUser1User98 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s098);
            sv.ImpostorScoresUser1User99 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s099);
            sv.ImpostorScoresUser1User100 = ScaledManhDist.CalculateImpostorScores(s001Mean, stdDevUser1, s100);
            #endregion

            #region User 2 Impostor scores
            sv.ImpostorScoresUser2User1 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s001);
            sv.ImpostorScoresUser2User3 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s003);
            sv.ImpostorScoresUser2User4 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s004);
            sv.ImpostorScoresUser2User5 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s005);
            sv.ImpostorScoresUser2User6 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s006);
            sv.ImpostorScoresUser2User7 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s007);
            sv.ImpostorScoresUser2User8 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s008);
            sv.ImpostorScoresUser2User9 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s009);
            sv.ImpostorScoresUser2User10 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s010);

            sv.ImpostorScoresUser2User11 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s011);
            sv.ImpostorScoresUser2User12 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s012);
            sv.ImpostorScoresUser2User13 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s013);
            sv.ImpostorScoresUser2User14 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s014);
            sv.ImpostorScoresUser2User15 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s015);
            sv.ImpostorScoresUser2User16 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s016);
            sv.ImpostorScoresUser2User17 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s017);
            sv.ImpostorScoresUser2User18 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s018);
            sv.ImpostorScoresUser2User19 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s019);
            sv.ImpostorScoresUser2User20 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s020);

            sv.ImpostorScoresUser2User21 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s021);
            sv.ImpostorScoresUser2User22 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s022);
            sv.ImpostorScoresUser2User23 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s023);
            sv.ImpostorScoresUser2User24 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s024);
            sv.ImpostorScoresUser2User25 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s025);
            sv.ImpostorScoresUser2User26 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s026);
            sv.ImpostorScoresUser2User27 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s027);
            sv.ImpostorScoresUser2User28 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s028);
            sv.ImpostorScoresUser2User29 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s029);
            sv.ImpostorScoresUser2User30 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s030);

            sv.ImpostorScoresUser2User31 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s031);
            sv.ImpostorScoresUser2User32 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s032);
            sv.ImpostorScoresUser2User33 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s033);
            sv.ImpostorScoresUser2User34 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s034);
            sv.ImpostorScoresUser2User35 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s035);
            sv.ImpostorScoresUser2User36 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s036);
            sv.ImpostorScoresUser2User37 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s037);
            sv.ImpostorScoresUser2User38 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s038);
            sv.ImpostorScoresUser2User39 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s039);
            sv.ImpostorScoresUser2User40 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s040);

            sv.ImpostorScoresUser2User41 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s041);
            sv.ImpostorScoresUser2User42 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s042);
            sv.ImpostorScoresUser2User43 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s043);
            sv.ImpostorScoresUser2User44 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s044);
            sv.ImpostorScoresUser2User45 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s045);
            sv.ImpostorScoresUser2User46 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s046);
            sv.ImpostorScoresUser2User47 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s047);
            sv.ImpostorScoresUser2User48 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s048);
            sv.ImpostorScoresUser2User49 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s049);
            sv.ImpostorScoresUser2User50 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s050);

            sv.ImpostorScoresUser2User51 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s051);
            sv.ImpostorScoresUser2User52 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s052);
            sv.ImpostorScoresUser2User53 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s053);
            sv.ImpostorScoresUser2User54 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s054);
            sv.ImpostorScoresUser2User55 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s055);
            sv.ImpostorScoresUser2User56 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s056);
            sv.ImpostorScoresUser2User57 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s057);
            sv.ImpostorScoresUser2User58 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s058);
            sv.ImpostorScoresUser2User59 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s059);
            sv.ImpostorScoresUser2User60 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s060);

            sv.ImpostorScoresUser2User61 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s061);
            sv.ImpostorScoresUser2User62 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s062);
            sv.ImpostorScoresUser2User63 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s063);
            sv.ImpostorScoresUser2User64 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s064);
            sv.ImpostorScoresUser2User65 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s065);
            sv.ImpostorScoresUser2User66 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s066);
            sv.ImpostorScoresUser2User67 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s067);
            sv.ImpostorScoresUser2User68 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s068);
            sv.ImpostorScoresUser2User69 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s069);
            sv.ImpostorScoresUser2User70 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s070);

            sv.ImpostorScoresUser2User71 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s071);
            sv.ImpostorScoresUser2User72 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s072);
            sv.ImpostorScoresUser2User73 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s073);
            sv.ImpostorScoresUser2User74 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s074);
            sv.ImpostorScoresUser2User75 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s075);
            sv.ImpostorScoresUser2User76 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s076);
            sv.ImpostorScoresUser2User77 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s077);
            sv.ImpostorScoresUser2User78 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s078);
            sv.ImpostorScoresUser2User79 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s079);
            sv.ImpostorScoresUser2User80 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s080);

            sv.ImpostorScoresUser2User81 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s081);
            sv.ImpostorScoresUser2User82 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s082);
            sv.ImpostorScoresUser2User83 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s083);
            sv.ImpostorScoresUser2User84 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s084);
            sv.ImpostorScoresUser2User85 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s085);
            sv.ImpostorScoresUser2User86 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s086);
            sv.ImpostorScoresUser2User87 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s087);
            sv.ImpostorScoresUser2User88 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s088);
            sv.ImpostorScoresUser2User89 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s089);
            sv.ImpostorScoresUser2User90 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s090);

            sv.ImpostorScoresUser2User91 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s091);
            sv.ImpostorScoresUser2User92 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s092);
            sv.ImpostorScoresUser2User93 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s093);
            sv.ImpostorScoresUser2User94 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s094);
            sv.ImpostorScoresUser2User95 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s095);
            sv.ImpostorScoresUser2User96 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s096);
            sv.ImpostorScoresUser2User97 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s097);
            sv.ImpostorScoresUser2User98 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s098);
            sv.ImpostorScoresUser2User99 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s099);
            sv.ImpostorScoresUser2User100 = ScaledManhDist.CalculateImpostorScores(s002Mean, stdDevUser2, s100);
            #endregion

            #region User 3 Impostor scores
            sv.ImpostorScoresUser3User1 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s001);
            sv.ImpostorScoresUser3User2 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s002);
            sv.ImpostorScoresUser3User4 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s004);
            sv.ImpostorScoresUser3User5 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s005);
            sv.ImpostorScoresUser3User6 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s006);
            sv.ImpostorScoresUser3User7 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s007);
            sv.ImpostorScoresUser3User8 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s008);
            sv.ImpostorScoresUser3User9 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s009);
            sv.ImpostorScoresUser3User10 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s010);

            sv.ImpostorScoresUser3User11 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s011);
            sv.ImpostorScoresUser3User12 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s012);
            sv.ImpostorScoresUser3User13 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s013);
            sv.ImpostorScoresUser3User14 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s014);
            sv.ImpostorScoresUser3User15 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s015);
            sv.ImpostorScoresUser3User16 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s016);
            sv.ImpostorScoresUser3User17 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s017);
            sv.ImpostorScoresUser3User18 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s018);
            sv.ImpostorScoresUser3User19 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s019);
            sv.ImpostorScoresUser3User20 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s020);

            sv.ImpostorScoresUser3User21 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s021);
            sv.ImpostorScoresUser3User22 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s022);
            sv.ImpostorScoresUser3User23 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s023);
            sv.ImpostorScoresUser3User24 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s024);
            sv.ImpostorScoresUser3User25 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s025);
            sv.ImpostorScoresUser3User26 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s026);
            sv.ImpostorScoresUser3User27 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s027);
            sv.ImpostorScoresUser3User28 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s028);
            sv.ImpostorScoresUser3User29 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s029);
            sv.ImpostorScoresUser3User30 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s030);

            sv.ImpostorScoresUser3User31 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s031);
            sv.ImpostorScoresUser3User32 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s032);
            sv.ImpostorScoresUser3User33 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s033);
            sv.ImpostorScoresUser3User34 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s034);
            sv.ImpostorScoresUser3User35 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s035);
            sv.ImpostorScoresUser3User36 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s036);
            sv.ImpostorScoresUser3User37 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s037);
            sv.ImpostorScoresUser3User38 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s038);
            sv.ImpostorScoresUser3User39 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s039);
            sv.ImpostorScoresUser3User40 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s040);

            sv.ImpostorScoresUser3User41 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s041);
            sv.ImpostorScoresUser3User42 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s042);
            sv.ImpostorScoresUser3User43 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s043);
            sv.ImpostorScoresUser3User44 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s044);
            sv.ImpostorScoresUser3User45 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s045);
            sv.ImpostorScoresUser3User46 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s046);
            sv.ImpostorScoresUser3User47 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s047);
            sv.ImpostorScoresUser3User48 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s048);
            sv.ImpostorScoresUser3User49 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s049);
            sv.ImpostorScoresUser3User50 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s050);

            sv.ImpostorScoresUser3User51 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s051);
            sv.ImpostorScoresUser3User52 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s052);
            sv.ImpostorScoresUser3User53 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s053);
            sv.ImpostorScoresUser3User54 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s054);
            sv.ImpostorScoresUser3User55 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s055);
            sv.ImpostorScoresUser3User56 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s056);
            sv.ImpostorScoresUser3User57 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s057);
            sv.ImpostorScoresUser3User58 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s058);
            sv.ImpostorScoresUser3User59 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s059);
            sv.ImpostorScoresUser3User60 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s060);

            sv.ImpostorScoresUser3User61 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s061);
            sv.ImpostorScoresUser3User62 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s062);
            sv.ImpostorScoresUser3User63 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s063);
            sv.ImpostorScoresUser3User64 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s064);
            sv.ImpostorScoresUser3User65 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s065);
            sv.ImpostorScoresUser3User66 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s066);
            sv.ImpostorScoresUser3User67 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s067);
            sv.ImpostorScoresUser3User68 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s068);
            sv.ImpostorScoresUser3User69 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s069);
            sv.ImpostorScoresUser3User70 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s070);

            sv.ImpostorScoresUser3User71 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s071);
            sv.ImpostorScoresUser3User72 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s072);
            sv.ImpostorScoresUser3User73 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s073);
            sv.ImpostorScoresUser3User74 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s074);
            sv.ImpostorScoresUser3User75 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s075);
            sv.ImpostorScoresUser3User76 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s076);
            sv.ImpostorScoresUser3User77 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s077);
            sv.ImpostorScoresUser3User78 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s078);
            sv.ImpostorScoresUser3User79 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s079);
            sv.ImpostorScoresUser3User80 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s080);

            sv.ImpostorScoresUser3User81 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s081);
            sv.ImpostorScoresUser3User82 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s082);
            sv.ImpostorScoresUser3User83 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s083);
            sv.ImpostorScoresUser3User84 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s084);
            sv.ImpostorScoresUser3User85 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s085);
            sv.ImpostorScoresUser3User86 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s086);
            sv.ImpostorScoresUser3User87 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s087);
            sv.ImpostorScoresUser3User88 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s088);
            sv.ImpostorScoresUser3User89 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s089);
            sv.ImpostorScoresUser3User90 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s090);

            sv.ImpostorScoresUser3User91 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s091);
            sv.ImpostorScoresUser3User92 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s092);
            sv.ImpostorScoresUser3User93 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s093);
            sv.ImpostorScoresUser3User94 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s094);
            sv.ImpostorScoresUser3User95 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s095);
            sv.ImpostorScoresUser3User96 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s096);
            sv.ImpostorScoresUser3User97 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s097);
            sv.ImpostorScoresUser3User98 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s098);
            sv.ImpostorScoresUser3User99 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s099);
            sv.ImpostorScoresUser3User100 = ScaledManhDist.CalculateImpostorScores(s003Mean, stdDevUser3, s100);
            #endregion

            #region User 4 Impostor scores
            sv.ImpostorScoresUser4User1 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s001);
            sv.ImpostorScoresUser4User2 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s002);
            sv.ImpostorScoresUser4User3 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s003);
            sv.ImpostorScoresUser4User5 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s005);
            sv.ImpostorScoresUser4User6 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s006);
            sv.ImpostorScoresUser4User7 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s007);
            sv.ImpostorScoresUser4User8 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s008);
            sv.ImpostorScoresUser4User9 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s009);
            sv.ImpostorScoresUser4User10 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s010);

            sv.ImpostorScoresUser4User11 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s011);
            sv.ImpostorScoresUser4User12 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s012);
            sv.ImpostorScoresUser4User13 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s013);
            sv.ImpostorScoresUser4User14 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s014);
            sv.ImpostorScoresUser4User15 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s015);
            sv.ImpostorScoresUser4User16 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s016);
            sv.ImpostorScoresUser4User17 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s017);
            sv.ImpostorScoresUser4User18 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s018);
            sv.ImpostorScoresUser4User19 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s019);
            sv.ImpostorScoresUser4User20 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s020);

            sv.ImpostorScoresUser4User21 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s021);
            sv.ImpostorScoresUser4User22 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s022);
            sv.ImpostorScoresUser4User23 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s023);
            sv.ImpostorScoresUser4User24 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s024);
            sv.ImpostorScoresUser4User25 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s025);
            sv.ImpostorScoresUser4User26 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s026);
            sv.ImpostorScoresUser4User27 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s027);
            sv.ImpostorScoresUser4User28 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s028);
            sv.ImpostorScoresUser4User29 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s029);
            sv.ImpostorScoresUser4User30 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s030);

            sv.ImpostorScoresUser4User31 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s031);
            sv.ImpostorScoresUser4User32 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s032);
            sv.ImpostorScoresUser4User33 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s033);
            sv.ImpostorScoresUser4User34 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s034);
            sv.ImpostorScoresUser4User35 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s035);
            sv.ImpostorScoresUser4User36 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s036);
            sv.ImpostorScoresUser4User37 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s037);
            sv.ImpostorScoresUser4User38 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s038);
            sv.ImpostorScoresUser4User39 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s039);
            sv.ImpostorScoresUser4User40 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s040);

            sv.ImpostorScoresUser4User41 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s041);
            sv.ImpostorScoresUser4User42 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s042);
            sv.ImpostorScoresUser4User43 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s043);
            sv.ImpostorScoresUser4User44 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s044);
            sv.ImpostorScoresUser4User45 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s045);
            sv.ImpostorScoresUser4User46 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s046);
            sv.ImpostorScoresUser4User47 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s047);
            sv.ImpostorScoresUser4User48 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s048);
            sv.ImpostorScoresUser4User49 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s049);
            sv.ImpostorScoresUser4User50 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s050);

            sv.ImpostorScoresUser4User51 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s051);
            sv.ImpostorScoresUser4User52 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s052);
            sv.ImpostorScoresUser4User53 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s053);
            sv.ImpostorScoresUser4User54 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s054);
            sv.ImpostorScoresUser4User55 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s055);
            sv.ImpostorScoresUser4User56 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s056);
            sv.ImpostorScoresUser4User57 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s057);
            sv.ImpostorScoresUser4User58 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s058);
            sv.ImpostorScoresUser4User59 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s059);
            sv.ImpostorScoresUser4User60 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s060);

            sv.ImpostorScoresUser4User61 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s061);
            sv.ImpostorScoresUser4User62 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s062);
            sv.ImpostorScoresUser4User63 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s063);
            sv.ImpostorScoresUser4User64 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s064);
            sv.ImpostorScoresUser4User65 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s065);
            sv.ImpostorScoresUser4User66 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s066);
            sv.ImpostorScoresUser4User67 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s067);
            sv.ImpostorScoresUser4User68 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s068);
            sv.ImpostorScoresUser4User69 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s069);
            sv.ImpostorScoresUser4User70 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s070);

            sv.ImpostorScoresUser4User71 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s071);
            sv.ImpostorScoresUser4User72 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s072);
            sv.ImpostorScoresUser4User73 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s073);
            sv.ImpostorScoresUser4User74 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s074);
            sv.ImpostorScoresUser4User75 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s075);
            sv.ImpostorScoresUser4User76 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s076);
            sv.ImpostorScoresUser4User77 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s077);
            sv.ImpostorScoresUser4User78 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s078);
            sv.ImpostorScoresUser4User79 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s079);
            sv.ImpostorScoresUser4User80 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s080);

            sv.ImpostorScoresUser4User81 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s081);
            sv.ImpostorScoresUser4User82 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s082);
            sv.ImpostorScoresUser4User83 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s083);
            sv.ImpostorScoresUser4User84 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s084);
            sv.ImpostorScoresUser4User85 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s085);
            sv.ImpostorScoresUser4User86 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s086);
            sv.ImpostorScoresUser4User87 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s087);
            sv.ImpostorScoresUser4User88 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s088);
            sv.ImpostorScoresUser4User89 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s089);
            sv.ImpostorScoresUser4User90 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s090);

            sv.ImpostorScoresUser4User91 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s091);
            sv.ImpostorScoresUser4User92 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s092);
            sv.ImpostorScoresUser4User93 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s093);
            sv.ImpostorScoresUser4User94 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s094);
            sv.ImpostorScoresUser4User95 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s095);
            sv.ImpostorScoresUser4User96 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s096);
            sv.ImpostorScoresUser4User97 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s097);
            sv.ImpostorScoresUser4User98 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s098);
            sv.ImpostorScoresUser4User99 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s099);
            sv.ImpostorScoresUser4User100 = ScaledManhDist.CalculateImpostorScores(s004Mean, stdDevUser4, s100);
            #endregion

            #region User 5 Impostor scores
            sv.ImpostorScoresUser5User1 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s001);
            sv.ImpostorScoresUser5User2 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s002);
            sv.ImpostorScoresUser5User3 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s003);
            sv.ImpostorScoresUser5User4 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s004);
            sv.ImpostorScoresUser5User6 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s006);
            sv.ImpostorScoresUser5User7 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s007);
            sv.ImpostorScoresUser5User8 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s008);
            sv.ImpostorScoresUser5User9 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s009);
            sv.ImpostorScoresUser5User10 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s010);

            sv.ImpostorScoresUser5User11 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s011);
            sv.ImpostorScoresUser5User12 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s012);
            sv.ImpostorScoresUser5User13 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s013);
            sv.ImpostorScoresUser5User14 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s014);
            sv.ImpostorScoresUser5User15 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s015);
            sv.ImpostorScoresUser5User16 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s016);
            sv.ImpostorScoresUser5User17 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s017);
            sv.ImpostorScoresUser5User18 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s018);
            sv.ImpostorScoresUser5User19 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s019);
            sv.ImpostorScoresUser5User20 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s020);

            sv.ImpostorScoresUser5User21 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s021);
            sv.ImpostorScoresUser5User22 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s022);
            sv.ImpostorScoresUser5User23 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s023);
            sv.ImpostorScoresUser5User24 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s024);
            sv.ImpostorScoresUser5User25 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s025);
            sv.ImpostorScoresUser5User26 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s026);
            sv.ImpostorScoresUser5User27 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s027);
            sv.ImpostorScoresUser5User28 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s028);
            sv.ImpostorScoresUser5User29 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s029);
            sv.ImpostorScoresUser5User30 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s030);

            sv.ImpostorScoresUser5User31 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s031);
            sv.ImpostorScoresUser5User32 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s032);
            sv.ImpostorScoresUser5User33 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s033);
            sv.ImpostorScoresUser5User34 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s034);
            sv.ImpostorScoresUser5User35 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s035);
            sv.ImpostorScoresUser5User36 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s036);
            sv.ImpostorScoresUser5User37 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s037);
            sv.ImpostorScoresUser5User38 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s038);
            sv.ImpostorScoresUser5User39 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s039);
            sv.ImpostorScoresUser5User40 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s040);

            sv.ImpostorScoresUser5User41 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s041);
            sv.ImpostorScoresUser5User42 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s042);
            sv.ImpostorScoresUser5User43 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s043);
            sv.ImpostorScoresUser5User44 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s044);
            sv.ImpostorScoresUser5User45 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s045);
            sv.ImpostorScoresUser5User46 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s046);
            sv.ImpostorScoresUser5User47 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s047);
            sv.ImpostorScoresUser5User48 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s048);
            sv.ImpostorScoresUser5User49 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s049);
            sv.ImpostorScoresUser5User50 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s050);

            sv.ImpostorScoresUser5User51 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s051);
            sv.ImpostorScoresUser5User52 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s052);
            sv.ImpostorScoresUser5User53 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s053);
            sv.ImpostorScoresUser5User54 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s054);
            sv.ImpostorScoresUser5User55 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s055);
            sv.ImpostorScoresUser5User56 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s056);
            sv.ImpostorScoresUser5User57 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s057);
            sv.ImpostorScoresUser5User58 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s058);
            sv.ImpostorScoresUser5User59 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s059);
            sv.ImpostorScoresUser5User60 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s060);

            sv.ImpostorScoresUser5User61 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s061);
            sv.ImpostorScoresUser5User62 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s062);
            sv.ImpostorScoresUser5User63 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s063);
            sv.ImpostorScoresUser5User64 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s064);
            sv.ImpostorScoresUser5User65 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s065);
            sv.ImpostorScoresUser5User66 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s066);
            sv.ImpostorScoresUser5User67 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s067);
            sv.ImpostorScoresUser5User68 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s068);
            sv.ImpostorScoresUser5User69 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s069);
            sv.ImpostorScoresUser5User70 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s070);

            sv.ImpostorScoresUser5User71 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s071);
            sv.ImpostorScoresUser5User72 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s072);
            sv.ImpostorScoresUser5User73 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s073);
            sv.ImpostorScoresUser5User74 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s074);
            sv.ImpostorScoresUser5User75 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s075);
            sv.ImpostorScoresUser5User76 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s076);
            sv.ImpostorScoresUser5User77 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s077);
            sv.ImpostorScoresUser5User78 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s078);
            sv.ImpostorScoresUser5User79 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s079);
            sv.ImpostorScoresUser5User80 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s080);

            sv.ImpostorScoresUser5User81 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s081);
            sv.ImpostorScoresUser5User82 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s082);
            sv.ImpostorScoresUser5User83 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s083);
            sv.ImpostorScoresUser5User84 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s084);
            sv.ImpostorScoresUser5User85 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s085);
            sv.ImpostorScoresUser5User86 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s086);
            sv.ImpostorScoresUser5User87 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s087);
            sv.ImpostorScoresUser5User88 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s088);
            sv.ImpostorScoresUser5User89 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s089);
            sv.ImpostorScoresUser5User90 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s090);

            sv.ImpostorScoresUser5User91 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s091);
            sv.ImpostorScoresUser5User92 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s092);
            sv.ImpostorScoresUser5User93 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s093);
            sv.ImpostorScoresUser5User94 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s094);
            sv.ImpostorScoresUser5User95 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s095);
            sv.ImpostorScoresUser5User96 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s096);
            sv.ImpostorScoresUser5User97 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s097);
            sv.ImpostorScoresUser5User98 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s098);
            sv.ImpostorScoresUser5User99 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s099);
            sv.ImpostorScoresUser5User100 = ScaledManhDist.CalculateImpostorScores(s005Mean, stdDevUser5, s100);
            #endregion

            #region User 6 Impostor scores
            sv.ImpostorScoresUser6User1 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s001);
            sv.ImpostorScoresUser6User2 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s002);
            sv.ImpostorScoresUser6User3 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s003);
            sv.ImpostorScoresUser6User4 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s004);
            sv.ImpostorScoresUser6User5 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s005);
            sv.ImpostorScoresUser6User7 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s007);
            sv.ImpostorScoresUser6User8 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s008);
            sv.ImpostorScoresUser6User9 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s009);
            sv.ImpostorScoresUser6User10 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s010);

            sv.ImpostorScoresUser6User11 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s011);
            sv.ImpostorScoresUser6User12 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s012);
            sv.ImpostorScoresUser6User13 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s013);
            sv.ImpostorScoresUser6User14 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s014);
            sv.ImpostorScoresUser6User15 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s015);
            sv.ImpostorScoresUser6User16 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s016);
            sv.ImpostorScoresUser6User17 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s017);
            sv.ImpostorScoresUser6User18 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s018);
            sv.ImpostorScoresUser6User19 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s019);
            sv.ImpostorScoresUser6User20 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s020);

            sv.ImpostorScoresUser6User21 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s021);
            sv.ImpostorScoresUser6User22 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s022);
            sv.ImpostorScoresUser6User23 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s023);
            sv.ImpostorScoresUser6User24 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s024);
            sv.ImpostorScoresUser6User25 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s025);
            sv.ImpostorScoresUser6User26 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s026);
            sv.ImpostorScoresUser6User27 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s027);
            sv.ImpostorScoresUser6User28 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s028);
            sv.ImpostorScoresUser6User29 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s029);
            sv.ImpostorScoresUser6User30 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s030);

            sv.ImpostorScoresUser6User31 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s031);
            sv.ImpostorScoresUser6User32 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s032);
            sv.ImpostorScoresUser6User33 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s033);
            sv.ImpostorScoresUser6User34 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s034);
            sv.ImpostorScoresUser6User35 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s035);
            sv.ImpostorScoresUser6User36 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s036);
            sv.ImpostorScoresUser6User37 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s037);
            sv.ImpostorScoresUser6User38 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s038);
            sv.ImpostorScoresUser6User39 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s039);
            sv.ImpostorScoresUser6User40 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s040);

            sv.ImpostorScoresUser6User41 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s041);
            sv.ImpostorScoresUser6User42 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s042);
            sv.ImpostorScoresUser6User43 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s043);
            sv.ImpostorScoresUser6User44 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s044);
            sv.ImpostorScoresUser6User45 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s045);
            sv.ImpostorScoresUser6User46 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s046);
            sv.ImpostorScoresUser6User47 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s047);
            sv.ImpostorScoresUser6User48 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s048);
            sv.ImpostorScoresUser6User49 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s049);
            sv.ImpostorScoresUser6User50 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s050);

            sv.ImpostorScoresUser6User51 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s051);
            sv.ImpostorScoresUser6User52 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s052);
            sv.ImpostorScoresUser6User53 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s053);
            sv.ImpostorScoresUser6User54 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s054);
            sv.ImpostorScoresUser6User55 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s055);
            sv.ImpostorScoresUser6User56 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s056);
            sv.ImpostorScoresUser6User57 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s057);
            sv.ImpostorScoresUser6User58 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s058);
            sv.ImpostorScoresUser6User59 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s059);
            sv.ImpostorScoresUser6User60 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s060);

            sv.ImpostorScoresUser6User61 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s061);
            sv.ImpostorScoresUser6User62 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s062);
            sv.ImpostorScoresUser6User63 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s063);
            sv.ImpostorScoresUser6User64 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s064);
            sv.ImpostorScoresUser6User65 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s065);
            sv.ImpostorScoresUser6User66 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s066);
            sv.ImpostorScoresUser6User67 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s067);
            sv.ImpostorScoresUser6User68 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s068);
            sv.ImpostorScoresUser6User69 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s069);
            sv.ImpostorScoresUser6User70 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s070);

            sv.ImpostorScoresUser6User71 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s071);
            sv.ImpostorScoresUser6User72 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s072);
            sv.ImpostorScoresUser6User73 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s073);
            sv.ImpostorScoresUser6User74 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s074);
            sv.ImpostorScoresUser6User75 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s075);
            sv.ImpostorScoresUser6User76 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s076);
            sv.ImpostorScoresUser6User77 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s077);
            sv.ImpostorScoresUser6User78 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s078);
            sv.ImpostorScoresUser6User79 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s079);
            sv.ImpostorScoresUser6User80 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s080);

            sv.ImpostorScoresUser6User81 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s081);
            sv.ImpostorScoresUser6User82 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s082);
            sv.ImpostorScoresUser6User83 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s083);
            sv.ImpostorScoresUser6User84 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s084);
            sv.ImpostorScoresUser6User85 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s085);
            sv.ImpostorScoresUser6User86 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s086);
            sv.ImpostorScoresUser6User87 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s087);
            sv.ImpostorScoresUser6User88 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s088);
            sv.ImpostorScoresUser6User89 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s089);
            sv.ImpostorScoresUser6User90 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s090);

            sv.ImpostorScoresUser6User91 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s091);
            sv.ImpostorScoresUser6User92 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s092);
            sv.ImpostorScoresUser6User93 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s093);
            sv.ImpostorScoresUser6User94 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s094);
            sv.ImpostorScoresUser6User95 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s095);
            sv.ImpostorScoresUser6User96 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s096);
            sv.ImpostorScoresUser6User97 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s097);
            sv.ImpostorScoresUser6User98 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s098);
            sv.ImpostorScoresUser6User99 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s099);
            sv.ImpostorScoresUser6User100 = ScaledManhDist.CalculateImpostorScores(s006Mean, stdDevUser6, s100);
            #endregion

            #region User 7 Impostor scores
            sv.ImpostorScoresUser7User1 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s001);
            sv.ImpostorScoresUser7User2 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s002);
            sv.ImpostorScoresUser7User3 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s003);
            sv.ImpostorScoresUser7User4 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s004);
            sv.ImpostorScoresUser7User5 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s005);
            sv.ImpostorScoresUser7User6 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s006);
            sv.ImpostorScoresUser7User8 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s008);
            sv.ImpostorScoresUser7User9 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s009);
            sv.ImpostorScoresUser7User10 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s010);

            sv.ImpostorScoresUser7User11 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s011);
            sv.ImpostorScoresUser7User12 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s012);
            sv.ImpostorScoresUser7User13 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s013);
            sv.ImpostorScoresUser7User14 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s014);
            sv.ImpostorScoresUser7User15 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s015);
            sv.ImpostorScoresUser7User16 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s016);
            sv.ImpostorScoresUser7User17 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s017);
            sv.ImpostorScoresUser7User18 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s018);
            sv.ImpostorScoresUser7User19 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s019);
            sv.ImpostorScoresUser7User20 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s020);

            sv.ImpostorScoresUser7User21 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s021);
            sv.ImpostorScoresUser7User22 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s022);
            sv.ImpostorScoresUser7User23 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s023);
            sv.ImpostorScoresUser7User24 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s024);
            sv.ImpostorScoresUser7User25 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s025);
            sv.ImpostorScoresUser7User26 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s026);
            sv.ImpostorScoresUser7User27 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s027);
            sv.ImpostorScoresUser7User28 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s028);
            sv.ImpostorScoresUser7User29 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s029);
            sv.ImpostorScoresUser7User30 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s030);

            sv.ImpostorScoresUser7User31 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s031);
            sv.ImpostorScoresUser7User32 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s032);
            sv.ImpostorScoresUser7User33 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s033);
            sv.ImpostorScoresUser7User34 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s034);
            sv.ImpostorScoresUser7User35 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s035);
            sv.ImpostorScoresUser7User36 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s036);
            sv.ImpostorScoresUser7User37 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s037);
            sv.ImpostorScoresUser7User38 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s038);
            sv.ImpostorScoresUser7User39 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s039);
            sv.ImpostorScoresUser7User40 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s040);

            sv.ImpostorScoresUser7User41 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s041);
            sv.ImpostorScoresUser7User42 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s042);
            sv.ImpostorScoresUser7User43 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s043);
            sv.ImpostorScoresUser7User44 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s044);
            sv.ImpostorScoresUser7User45 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s045);
            sv.ImpostorScoresUser7User46 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s046);
            sv.ImpostorScoresUser7User47 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s047);
            sv.ImpostorScoresUser7User48 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s048);
            sv.ImpostorScoresUser7User49 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s049);
            sv.ImpostorScoresUser7User50 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s050);

            sv.ImpostorScoresUser7User51 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s051);
            sv.ImpostorScoresUser7User52 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s052);
            sv.ImpostorScoresUser7User53 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s053);
            sv.ImpostorScoresUser7User54 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s054);
            sv.ImpostorScoresUser7User55 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s055);
            sv.ImpostorScoresUser7User56 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s056);
            sv.ImpostorScoresUser7User57 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s057);
            sv.ImpostorScoresUser7User58 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s058);
            sv.ImpostorScoresUser7User59 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s059);
            sv.ImpostorScoresUser7User60 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s060);

            sv.ImpostorScoresUser7User61 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s061);
            sv.ImpostorScoresUser7User62 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s062);
            sv.ImpostorScoresUser7User63 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s063);
            sv.ImpostorScoresUser7User64 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s064);
            sv.ImpostorScoresUser7User65 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s065);
            sv.ImpostorScoresUser7User66 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s066);
            sv.ImpostorScoresUser7User67 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s067);
            sv.ImpostorScoresUser7User68 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s068);
            sv.ImpostorScoresUser7User69 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s069);
            sv.ImpostorScoresUser7User70 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s070);

            sv.ImpostorScoresUser7User71 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s071);
            sv.ImpostorScoresUser7User72 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s072);
            sv.ImpostorScoresUser7User73 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s073);
            sv.ImpostorScoresUser7User74 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s074);
            sv.ImpostorScoresUser7User75 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s075);
            sv.ImpostorScoresUser7User76 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s076);
            sv.ImpostorScoresUser7User77 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s077);
            sv.ImpostorScoresUser7User78 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s078);
            sv.ImpostorScoresUser7User79 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s079);
            sv.ImpostorScoresUser7User80 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s080);

            sv.ImpostorScoresUser7User81 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s081);
            sv.ImpostorScoresUser7User82 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s082);
            sv.ImpostorScoresUser7User83 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s083);
            sv.ImpostorScoresUser7User84 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s084);
            sv.ImpostorScoresUser7User85 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s085);
            sv.ImpostorScoresUser7User86 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s086);
            sv.ImpostorScoresUser7User87 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s087);
            sv.ImpostorScoresUser7User88 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s088);
            sv.ImpostorScoresUser7User89 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s089);
            sv.ImpostorScoresUser7User90 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s090);

            sv.ImpostorScoresUser7User91 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s091);
            sv.ImpostorScoresUser7User92 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s092);
            sv.ImpostorScoresUser7User93 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s093);
            sv.ImpostorScoresUser7User94 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s094);
            sv.ImpostorScoresUser7User95 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s095);
            sv.ImpostorScoresUser7User96 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s096);
            sv.ImpostorScoresUser7User97 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s097);
            sv.ImpostorScoresUser7User98 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s098);
            sv.ImpostorScoresUser7User99 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s099);
            sv.ImpostorScoresUser7User100 = ScaledManhDist.CalculateImpostorScores(s007Mean, stdDevUser7, s100);
            #endregion

            #region User 8 Impostor scores
            sv.ImpostorScoresUser8User1 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s001);
            sv.ImpostorScoresUser8User2 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s002);
            sv.ImpostorScoresUser8User3 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s003);
            sv.ImpostorScoresUser8User4 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s004);
            sv.ImpostorScoresUser8User5 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s005);
            sv.ImpostorScoresUser8User6 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s006);
            sv.ImpostorScoresUser8User7 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s007);
            sv.ImpostorScoresUser8User9 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s009);
            sv.ImpostorScoresUser8User10 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s010);

            sv.ImpostorScoresUser8User11 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s011);
            sv.ImpostorScoresUser8User12 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s012);
            sv.ImpostorScoresUser8User13 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s013);
            sv.ImpostorScoresUser8User14 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s014);
            sv.ImpostorScoresUser8User15 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s015);
            sv.ImpostorScoresUser8User16 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s016);
            sv.ImpostorScoresUser8User17 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s017);
            sv.ImpostorScoresUser8User18 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s018);
            sv.ImpostorScoresUser8User19 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s019);
            sv.ImpostorScoresUser8User20 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s020);

            sv.ImpostorScoresUser8User21 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s021);
            sv.ImpostorScoresUser8User22 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s022);
            sv.ImpostorScoresUser8User23 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s023);
            sv.ImpostorScoresUser8User24 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s024);
            sv.ImpostorScoresUser8User25 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s025);
            sv.ImpostorScoresUser8User26 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s026);
            sv.ImpostorScoresUser8User27 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s027);
            sv.ImpostorScoresUser8User28 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s028);
            sv.ImpostorScoresUser8User29 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s029);
            sv.ImpostorScoresUser8User30 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s030);

            sv.ImpostorScoresUser8User31 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s031);
            sv.ImpostorScoresUser8User32 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s032);
            sv.ImpostorScoresUser8User33 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s033);
            sv.ImpostorScoresUser8User34 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s034);
            sv.ImpostorScoresUser8User35 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s035);
            sv.ImpostorScoresUser8User36 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s036);
            sv.ImpostorScoresUser8User37 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s037);
            sv.ImpostorScoresUser8User38 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s038);
            sv.ImpostorScoresUser8User39 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s039);
            sv.ImpostorScoresUser8User40 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s040);

            sv.ImpostorScoresUser8User41 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s041);
            sv.ImpostorScoresUser8User42 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s042);
            sv.ImpostorScoresUser8User43 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s043);
            sv.ImpostorScoresUser8User44 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s044);
            sv.ImpostorScoresUser8User45 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s045);
            sv.ImpostorScoresUser8User46 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s046);
            sv.ImpostorScoresUser8User47 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s047);
            sv.ImpostorScoresUser8User48 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s048);
            sv.ImpostorScoresUser8User49 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s049);
            sv.ImpostorScoresUser8User50 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s050);

            sv.ImpostorScoresUser8User51 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s051);
            sv.ImpostorScoresUser8User52 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s052);
            sv.ImpostorScoresUser8User53 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s053);
            sv.ImpostorScoresUser8User54 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s054);
            sv.ImpostorScoresUser8User55 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s055);
            sv.ImpostorScoresUser8User56 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s056);
            sv.ImpostorScoresUser8User57 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s057);
            sv.ImpostorScoresUser8User58 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s058);
            sv.ImpostorScoresUser8User59 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s059);
            sv.ImpostorScoresUser8User60 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s060);

            sv.ImpostorScoresUser8User61 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s061);
            sv.ImpostorScoresUser8User62 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s062);
            sv.ImpostorScoresUser8User63 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s063);
            sv.ImpostorScoresUser8User64 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s064);
            sv.ImpostorScoresUser8User65 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s065);
            sv.ImpostorScoresUser8User66 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s066);
            sv.ImpostorScoresUser8User67 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s067);
            sv.ImpostorScoresUser8User68 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s068);
            sv.ImpostorScoresUser8User69 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s069);
            sv.ImpostorScoresUser8User70 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s070);

            sv.ImpostorScoresUser8User71 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s071);
            sv.ImpostorScoresUser8User72 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s072);
            sv.ImpostorScoresUser8User73 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s073);
            sv.ImpostorScoresUser8User74 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s074);
            sv.ImpostorScoresUser8User75 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s075);
            sv.ImpostorScoresUser8User76 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s076);
            sv.ImpostorScoresUser8User77 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s077);
            sv.ImpostorScoresUser8User78 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s078);
            sv.ImpostorScoresUser8User79 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s079);
            sv.ImpostorScoresUser8User80 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s080);

            sv.ImpostorScoresUser8User81 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s081);
            sv.ImpostorScoresUser8User82 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s082);
            sv.ImpostorScoresUser8User83 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s083);
            sv.ImpostorScoresUser8User84 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s084);
            sv.ImpostorScoresUser8User85 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s085);
            sv.ImpostorScoresUser8User86 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s086);
            sv.ImpostorScoresUser8User87 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s087);
            sv.ImpostorScoresUser8User88 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s088);
            sv.ImpostorScoresUser8User89 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s089);
            sv.ImpostorScoresUser8User90 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s090);

            sv.ImpostorScoresUser8User91 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s091);
            sv.ImpostorScoresUser8User92 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s092);
            sv.ImpostorScoresUser8User93 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s093);
            sv.ImpostorScoresUser8User94 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s094);
            sv.ImpostorScoresUser8User95 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s095);
            sv.ImpostorScoresUser8User96 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s096);
            sv.ImpostorScoresUser8User97 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s097);
            sv.ImpostorScoresUser8User98 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s098);
            sv.ImpostorScoresUser8User99 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s099);
            sv.ImpostorScoresUser8User100 = ScaledManhDist.CalculateImpostorScores(s008Mean, stdDevUser8, s100);
            #endregion

            #region User 9 Impostor scores 
            sv.ImpostorScoresUser9User1 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s001);
            sv.ImpostorScoresUser9User2 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s002);
            sv.ImpostorScoresUser9User3 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s003);
            sv.ImpostorScoresUser9User4 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s004);
            sv.ImpostorScoresUser9User5 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s005);
            sv.ImpostorScoresUser9User6 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s006);
            sv.ImpostorScoresUser9User7 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s007);
            sv.ImpostorScoresUser9User8 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s008);
            sv.ImpostorScoresUser9User10 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s010);

            sv.ImpostorScoresUser9User11 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s011);
            sv.ImpostorScoresUser9User12 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s012);
            sv.ImpostorScoresUser9User13 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s013);
            sv.ImpostorScoresUser9User14 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s014);
            sv.ImpostorScoresUser9User15 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s015);
            sv.ImpostorScoresUser9User16 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s016);
            sv.ImpostorScoresUser9User17 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s017);
            sv.ImpostorScoresUser9User18 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s018);
            sv.ImpostorScoresUser9User19 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s019);
            sv.ImpostorScoresUser9User20 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s020);

            sv.ImpostorScoresUser9User21 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s021);
            sv.ImpostorScoresUser9User22 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s022);
            sv.ImpostorScoresUser9User23 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s023);
            sv.ImpostorScoresUser9User24 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s024);
            sv.ImpostorScoresUser9User25 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s025);
            sv.ImpostorScoresUser9User26 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s026);
            sv.ImpostorScoresUser9User27 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s027);
            sv.ImpostorScoresUser9User28 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s028);
            sv.ImpostorScoresUser9User29 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s029);
            sv.ImpostorScoresUser9User30 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s030);

            sv.ImpostorScoresUser9User31 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s031);
            sv.ImpostorScoresUser9User32 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s032);
            sv.ImpostorScoresUser9User33 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s033);
            sv.ImpostorScoresUser9User34 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s034);
            sv.ImpostorScoresUser9User35 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s035);
            sv.ImpostorScoresUser9User36 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s036);
            sv.ImpostorScoresUser9User37 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s037);
            sv.ImpostorScoresUser9User38 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s038);
            sv.ImpostorScoresUser9User39 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s039);
            sv.ImpostorScoresUser9User40 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s040);

            sv.ImpostorScoresUser9User41 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s041);
            sv.ImpostorScoresUser9User42 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s042);
            sv.ImpostorScoresUser9User43 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s043);
            sv.ImpostorScoresUser9User44 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s044);
            sv.ImpostorScoresUser9User45 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s045);
            sv.ImpostorScoresUser9User46 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s046);
            sv.ImpostorScoresUser9User47 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s047);
            sv.ImpostorScoresUser9User48 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s048);
            sv.ImpostorScoresUser9User49 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s049);
            sv.ImpostorScoresUser9User50 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s050);

            sv.ImpostorScoresUser9User51 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s051);
            sv.ImpostorScoresUser9User52 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s052);
            sv.ImpostorScoresUser9User53 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s053);
            sv.ImpostorScoresUser9User54 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s054);
            sv.ImpostorScoresUser9User55 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s055);
            sv.ImpostorScoresUser9User56 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s056);
            sv.ImpostorScoresUser9User57 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s057);
            sv.ImpostorScoresUser9User58 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s058);
            sv.ImpostorScoresUser9User59 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s059);
            sv.ImpostorScoresUser9User60 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s060);

            sv.ImpostorScoresUser9User61 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s061);
            sv.ImpostorScoresUser9User62 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s062);
            sv.ImpostorScoresUser9User63 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s063);
            sv.ImpostorScoresUser9User64 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s064);
            sv.ImpostorScoresUser9User65 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s065);
            sv.ImpostorScoresUser9User66 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s066);
            sv.ImpostorScoresUser9User67 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s067);
            sv.ImpostorScoresUser9User68 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s068);
            sv.ImpostorScoresUser9User69 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s069);
            sv.ImpostorScoresUser9User70 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s070);

            sv.ImpostorScoresUser9User71 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s071);
            sv.ImpostorScoresUser9User72 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s072);
            sv.ImpostorScoresUser9User73 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s073);
            sv.ImpostorScoresUser9User74 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s074);
            sv.ImpostorScoresUser9User75 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s075);
            sv.ImpostorScoresUser9User76 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s076);
            sv.ImpostorScoresUser9User77 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s077);
            sv.ImpostorScoresUser9User78 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s078);
            sv.ImpostorScoresUser9User79 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s079);
            sv.ImpostorScoresUser9User80 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s080);

            sv.ImpostorScoresUser9User81 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s081);
            sv.ImpostorScoresUser9User82 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s082);
            sv.ImpostorScoresUser9User83 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s083);
            sv.ImpostorScoresUser9User84 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s084);
            sv.ImpostorScoresUser9User85 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s085);
            sv.ImpostorScoresUser9User86 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s086);
            sv.ImpostorScoresUser9User87 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s087);
            sv.ImpostorScoresUser9User88 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s088);
            sv.ImpostorScoresUser9User89 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s089);
            sv.ImpostorScoresUser9User90 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s090);

            sv.ImpostorScoresUser9User91 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s091);
            sv.ImpostorScoresUser9User92 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s092);
            sv.ImpostorScoresUser9User93 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s093);
            sv.ImpostorScoresUser9User94 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s094);
            sv.ImpostorScoresUser9User95 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s095);
            sv.ImpostorScoresUser9User96 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s096);
            sv.ImpostorScoresUser9User97 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s097);
            sv.ImpostorScoresUser9User98 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s098);
            sv.ImpostorScoresUser9User99 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s099);
            sv.ImpostorScoresUser9User100 = ScaledManhDist.CalculateImpostorScores(s009Mean, stdDevUser9, s100);
            #endregion

            #region User 10 Impostor scores
            sv.ImpostorScoresUser10User1 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s001);
            sv.ImpostorScoresUser10User2 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s002);
            sv.ImpostorScoresUser10User3 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s003);
            sv.ImpostorScoresUser10User4 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s004);
            sv.ImpostorScoresUser10User5 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s005);
            sv.ImpostorScoresUser10User6 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s006);
            sv.ImpostorScoresUser10User7 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s007);
            sv.ImpostorScoresUser10User8 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s008);
            sv.ImpostorScoresUser10User9 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s009);

            sv.ImpostorScoresUser10User11 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s011);
            sv.ImpostorScoresUser10User12 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s012);
            sv.ImpostorScoresUser10User13 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s013);
            sv.ImpostorScoresUser10User14 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s014);
            sv.ImpostorScoresUser10User15 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s015);
            sv.ImpostorScoresUser10User16 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s016);
            sv.ImpostorScoresUser10User17 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s017);
            sv.ImpostorScoresUser10User18 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s018);
            sv.ImpostorScoresUser10User19 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s019);
            sv.ImpostorScoresUser10User20 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s020);

            sv.ImpostorScoresUser10User21 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s021);
            sv.ImpostorScoresUser10User22 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s022);
            sv.ImpostorScoresUser10User23 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s023);
            sv.ImpostorScoresUser10User24 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s024);
            sv.ImpostorScoresUser10User25 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s025);
            sv.ImpostorScoresUser10User26 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s026);
            sv.ImpostorScoresUser10User27 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s027);
            sv.ImpostorScoresUser10User28 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s028);
            sv.ImpostorScoresUser10User29 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s029);
            sv.ImpostorScoresUser10User30 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s030);

            sv.ImpostorScoresUser10User31 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s031);
            sv.ImpostorScoresUser10User32 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s032);
            sv.ImpostorScoresUser10User33 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s033);
            sv.ImpostorScoresUser10User34 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s034);
            sv.ImpostorScoresUser10User35 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s035);
            sv.ImpostorScoresUser10User36 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s036);
            sv.ImpostorScoresUser10User37 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s037);
            sv.ImpostorScoresUser10User38 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s038);
            sv.ImpostorScoresUser10User39 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s039);
            sv.ImpostorScoresUser10User40 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s040);

            sv.ImpostorScoresUser10User41 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s041);
            sv.ImpostorScoresUser10User42 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s042);
            sv.ImpostorScoresUser10User43 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s043);
            sv.ImpostorScoresUser10User44 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s044);
            sv.ImpostorScoresUser10User45 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s045);
            sv.ImpostorScoresUser10User46 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s046);
            sv.ImpostorScoresUser10User47 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s047);
            sv.ImpostorScoresUser10User48 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s048);
            sv.ImpostorScoresUser10User49 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s049);
            sv.ImpostorScoresUser10User50 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s050);

            sv.ImpostorScoresUser10User51 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s051);
            sv.ImpostorScoresUser10User52 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s052);
            sv.ImpostorScoresUser10User53 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s053);
            sv.ImpostorScoresUser10User54 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s054);
            sv.ImpostorScoresUser10User55 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s055);
            sv.ImpostorScoresUser10User56 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s056);
            sv.ImpostorScoresUser10User57 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s057);
            sv.ImpostorScoresUser10User58 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s058);
            sv.ImpostorScoresUser10User59 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s059);
            sv.ImpostorScoresUser10User60 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s060);

            sv.ImpostorScoresUser10User61 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s061);
            sv.ImpostorScoresUser10User62 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s062);
            sv.ImpostorScoresUser10User63 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s063);
            sv.ImpostorScoresUser10User64 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s064);
            sv.ImpostorScoresUser10User65 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s065);
            sv.ImpostorScoresUser10User66 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s066);
            sv.ImpostorScoresUser10User67 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s067);
            sv.ImpostorScoresUser10User68 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s068);
            sv.ImpostorScoresUser10User69 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s069);
            sv.ImpostorScoresUser10User70 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s070);

            sv.ImpostorScoresUser10User71 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s071);
            sv.ImpostorScoresUser10User72 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s072);
            sv.ImpostorScoresUser10User73 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s073);
            sv.ImpostorScoresUser10User74 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s074);
            sv.ImpostorScoresUser10User75 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s075);
            sv.ImpostorScoresUser10User76 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s076);
            sv.ImpostorScoresUser10User77 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s077);
            sv.ImpostorScoresUser10User78 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s078);
            sv.ImpostorScoresUser10User79 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s079);
            sv.ImpostorScoresUser10User80 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s080);

            sv.ImpostorScoresUser10User81 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s081);
            sv.ImpostorScoresUser10User82 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s082);
            sv.ImpostorScoresUser10User83 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s083);
            sv.ImpostorScoresUser10User84 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s084);
            sv.ImpostorScoresUser10User85 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s085);
            sv.ImpostorScoresUser10User86 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s086);
            sv.ImpostorScoresUser10User87 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s087);
            sv.ImpostorScoresUser10User88 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s088);
            sv.ImpostorScoresUser10User89 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s089);
            sv.ImpostorScoresUser10User90 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s090);

            sv.ImpostorScoresUser10User91 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s091);
            sv.ImpostorScoresUser10User92 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s092);
            sv.ImpostorScoresUser10User93 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s093);
            sv.ImpostorScoresUser10User94 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s094);
            sv.ImpostorScoresUser10User95 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s095);
            sv.ImpostorScoresUser10User96 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s096);
            sv.ImpostorScoresUser10User97 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s097);
            sv.ImpostorScoresUser10User98 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s098);
            sv.ImpostorScoresUser10User99 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s099);
            sv.ImpostorScoresUser10User100 = ScaledManhDist.CalculateImpostorScores(s010Mean, stdDevUser10, s100);
            #endregion

            #region User 11 Impostor scores
            sv.ImpostorScoresUser11User1 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s001);
            sv.ImpostorScoresUser11User2 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s002);
            sv.ImpostorScoresUser11User3 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s003);
            sv.ImpostorScoresUser11User4 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s004);
            sv.ImpostorScoresUser11User5 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s005);
            sv.ImpostorScoresUser11User6 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s006);
            sv.ImpostorScoresUser11User7 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s007);
            sv.ImpostorScoresUser11User8 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s008);
            sv.ImpostorScoresUser11User9 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s009);
            sv.ImpostorScoresUser11User10 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s010);

            sv.ImpostorScoresUser11User12 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s012);
            sv.ImpostorScoresUser11User13 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s013);
            sv.ImpostorScoresUser11User14 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s014);
            sv.ImpostorScoresUser11User15 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s015);
            sv.ImpostorScoresUser11User16 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s016);
            sv.ImpostorScoresUser11User17 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s017);
            sv.ImpostorScoresUser11User18 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s018);
            sv.ImpostorScoresUser11User19 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s019);
            sv.ImpostorScoresUser11User20 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s020);

            sv.ImpostorScoresUser11User21 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s021);
            sv.ImpostorScoresUser11User22 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s022);
            sv.ImpostorScoresUser11User23 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s023);
            sv.ImpostorScoresUser11User24 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s024);
            sv.ImpostorScoresUser11User25 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s025);
            sv.ImpostorScoresUser11User26 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s026);
            sv.ImpostorScoresUser11User27 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s027);
            sv.ImpostorScoresUser11User28 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s028);
            sv.ImpostorScoresUser11User29 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s029);
            sv.ImpostorScoresUser11User30 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s030);

            sv.ImpostorScoresUser11User31 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s031);
            sv.ImpostorScoresUser11User32 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s032);
            sv.ImpostorScoresUser11User33 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s033);
            sv.ImpostorScoresUser11User34 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s034);
            sv.ImpostorScoresUser11User35 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s035);
            sv.ImpostorScoresUser11User36 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s036);
            sv.ImpostorScoresUser11User37 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s037);
            sv.ImpostorScoresUser11User38 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s038);
            sv.ImpostorScoresUser11User39 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s039);
            sv.ImpostorScoresUser11User40 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s040);

            sv.ImpostorScoresUser11User41 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s041);
            sv.ImpostorScoresUser11User42 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s042);
            sv.ImpostorScoresUser11User43 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s043);
            sv.ImpostorScoresUser11User44 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s044);
            sv.ImpostorScoresUser11User45 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s045);
            sv.ImpostorScoresUser11User46 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s046);
            sv.ImpostorScoresUser11User47 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s047);
            sv.ImpostorScoresUser11User48 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s048);
            sv.ImpostorScoresUser11User49 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s049);
            sv.ImpostorScoresUser11User50 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s050);

            sv.ImpostorScoresUser11User51 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s051);
            sv.ImpostorScoresUser11User52 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s052);
            sv.ImpostorScoresUser11User53 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s053);
            sv.ImpostorScoresUser11User54 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s054);
            sv.ImpostorScoresUser11User55 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s055);
            sv.ImpostorScoresUser11User56 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s056);
            sv.ImpostorScoresUser11User57 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s057);
            sv.ImpostorScoresUser11User58 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s058);
            sv.ImpostorScoresUser11User59 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s059);
            sv.ImpostorScoresUser11User60 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s060);

            sv.ImpostorScoresUser11User61 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s061);
            sv.ImpostorScoresUser11User62 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s062);
            sv.ImpostorScoresUser11User63 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s063);
            sv.ImpostorScoresUser11User64 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s064);
            sv.ImpostorScoresUser11User65 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s065);
            sv.ImpostorScoresUser11User66 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s066);
            sv.ImpostorScoresUser11User67 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s067);
            sv.ImpostorScoresUser11User68 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s068);
            sv.ImpostorScoresUser11User69 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s069);
            sv.ImpostorScoresUser11User70 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s070);

            sv.ImpostorScoresUser11User71 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s071);
            sv.ImpostorScoresUser11User72 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s072);
            sv.ImpostorScoresUser11User73 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s073);
            sv.ImpostorScoresUser11User74 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s074);
            sv.ImpostorScoresUser11User75 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s075);
            sv.ImpostorScoresUser11User76 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s076);
            sv.ImpostorScoresUser11User77 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s077);
            sv.ImpostorScoresUser11User78 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s078);
            sv.ImpostorScoresUser11User79 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s079);
            sv.ImpostorScoresUser11User80 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s080);

            sv.ImpostorScoresUser11User81 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s081);
            sv.ImpostorScoresUser11User82 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s082);
            sv.ImpostorScoresUser11User83 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s083);
            sv.ImpostorScoresUser11User84 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s084);
            sv.ImpostorScoresUser11User85 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s085);
            sv.ImpostorScoresUser11User86 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s086);
            sv.ImpostorScoresUser11User87 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s087);
            sv.ImpostorScoresUser11User88 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s088);
            sv.ImpostorScoresUser11User89 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s089);
            sv.ImpostorScoresUser11User90 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s090);

            sv.ImpostorScoresUser11User91 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s091);
            sv.ImpostorScoresUser11User92 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s092);
            sv.ImpostorScoresUser11User93 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s093);
            sv.ImpostorScoresUser11User94 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s094);
            sv.ImpostorScoresUser11User95 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s095);
            sv.ImpostorScoresUser11User96 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s096);
            sv.ImpostorScoresUser11User97 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s097);
            sv.ImpostorScoresUser11User98 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s098);
            sv.ImpostorScoresUser11User99 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s099);
            sv.ImpostorScoresUser11User100 = ScaledManhDist.CalculateImpostorScores(s011Mean, stdDevUser11, s100);
            #endregion

            #region User 12 Impostor scores
            sv.ImpostorScoresUser12User1 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s001);
            sv.ImpostorScoresUser12User2 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s002);
            sv.ImpostorScoresUser12User3 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s003);
            sv.ImpostorScoresUser12User4 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s004);
            sv.ImpostorScoresUser12User5 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s005);
            sv.ImpostorScoresUser12User6 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s006);
            sv.ImpostorScoresUser12User7 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s007);
            sv.ImpostorScoresUser12User8 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s008);
            sv.ImpostorScoresUser12User9 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s009);
            sv.ImpostorScoresUser12User10 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s010);

            sv.ImpostorScoresUser12User11 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s011);
            sv.ImpostorScoresUser12User13 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s013);
            sv.ImpostorScoresUser12User14 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s014);
            sv.ImpostorScoresUser12User15 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s015);
            sv.ImpostorScoresUser12User16 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s016);
            sv.ImpostorScoresUser12User17 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s017);
            sv.ImpostorScoresUser12User18 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s018);
            sv.ImpostorScoresUser12User19 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s019);
            sv.ImpostorScoresUser12User20 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s020);

            sv.ImpostorScoresUser12User21 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s021);
            sv.ImpostorScoresUser12User22 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s022);
            sv.ImpostorScoresUser12User23 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s023);
            sv.ImpostorScoresUser12User24 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s024);
            sv.ImpostorScoresUser12User25 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s025);
            sv.ImpostorScoresUser12User26 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s026);
            sv.ImpostorScoresUser12User27 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s027);
            sv.ImpostorScoresUser12User28 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s028);
            sv.ImpostorScoresUser12User29 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s029);
            sv.ImpostorScoresUser12User30 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s030);

            sv.ImpostorScoresUser12User31 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s031);
            sv.ImpostorScoresUser12User32 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s032);
            sv.ImpostorScoresUser12User33 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s033);
            sv.ImpostorScoresUser12User34 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s034);
            sv.ImpostorScoresUser12User35 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s035);
            sv.ImpostorScoresUser12User36 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s036);
            sv.ImpostorScoresUser12User37 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s037);
            sv.ImpostorScoresUser12User38 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s038);
            sv.ImpostorScoresUser12User39 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s039);
            sv.ImpostorScoresUser12User40 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s040);

            sv.ImpostorScoresUser12User41 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s041);
            sv.ImpostorScoresUser12User42 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s042);
            sv.ImpostorScoresUser12User43 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s043);
            sv.ImpostorScoresUser12User44 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s044);
            sv.ImpostorScoresUser12User45 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s045);
            sv.ImpostorScoresUser12User46 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s046);
            sv.ImpostorScoresUser12User47 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s047);
            sv.ImpostorScoresUser12User48 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s048);
            sv.ImpostorScoresUser12User49 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s049);
            sv.ImpostorScoresUser12User50 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s050);

            sv.ImpostorScoresUser12User51 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s051);
            sv.ImpostorScoresUser12User52 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s052);
            sv.ImpostorScoresUser12User53 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s053);
            sv.ImpostorScoresUser12User54 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s054);
            sv.ImpostorScoresUser12User55 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s055);
            sv.ImpostorScoresUser12User56 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s056);
            sv.ImpostorScoresUser12User57 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s057);
            sv.ImpostorScoresUser12User58 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s058);
            sv.ImpostorScoresUser12User59 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s059);
            sv.ImpostorScoresUser12User60 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s060);

            sv.ImpostorScoresUser12User61 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s061);
            sv.ImpostorScoresUser12User62 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s062);
            sv.ImpostorScoresUser12User63 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s063);
            sv.ImpostorScoresUser12User64 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s064);
            sv.ImpostorScoresUser12User65 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s065);
            sv.ImpostorScoresUser12User66 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s066);
            sv.ImpostorScoresUser12User67 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s067);
            sv.ImpostorScoresUser12User68 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s068);
            sv.ImpostorScoresUser12User69 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s069);
            sv.ImpostorScoresUser12User70 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s070);

            sv.ImpostorScoresUser12User71 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s071);
            sv.ImpostorScoresUser12User72 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s072);
            sv.ImpostorScoresUser12User73 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s073);
            sv.ImpostorScoresUser12User74 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s074);
            sv.ImpostorScoresUser12User75 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s075);
            sv.ImpostorScoresUser12User76 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s076);
            sv.ImpostorScoresUser12User77 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s077);
            sv.ImpostorScoresUser12User78 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s078);
            sv.ImpostorScoresUser12User79 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s079);
            sv.ImpostorScoresUser12User80 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s080);

            sv.ImpostorScoresUser12User81 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s081);
            sv.ImpostorScoresUser12User82 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s082);
            sv.ImpostorScoresUser12User83 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s083);
            sv.ImpostorScoresUser12User84 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s084);
            sv.ImpostorScoresUser12User85 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s085);
            sv.ImpostorScoresUser12User86 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s086);
            sv.ImpostorScoresUser12User87 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s087);
            sv.ImpostorScoresUser12User88 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s088);
            sv.ImpostorScoresUser12User89 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s089);
            sv.ImpostorScoresUser12User90 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s090);

            sv.ImpostorScoresUser12User91 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s091);
            sv.ImpostorScoresUser12User92 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s092);
            sv.ImpostorScoresUser12User93 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s093);
            sv.ImpostorScoresUser12User94 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s094);
            sv.ImpostorScoresUser12User95 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s095);
            sv.ImpostorScoresUser12User96 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s096);
            sv.ImpostorScoresUser12User97 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s097);
            sv.ImpostorScoresUser12User98 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s098);
            sv.ImpostorScoresUser12User99 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s099);
            sv.ImpostorScoresUser12User100 = ScaledManhDist.CalculateImpostorScores(s012Mean, stdDevUser12, s100);
            #endregion

            #endregion
        }
        #endregion

        #region Euclidean Verifier
        private static void UseEuclideanVerifier()
        {
            EuclideanDistance EuclidDist = new EuclideanDistance();
            ImpostorScoreVars sv = new ImpostorScoreVars();

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
            sv.ImpostorScoresUser1User2 = EuclidDist.CalculateImpostorScores(s001Mean, s002);
            sv.ImpostorScoresUser1User3 = EuclidDist.CalculateImpostorScores(s001Mean, s003);
            sv.ImpostorScoresUser1User4 = EuclidDist.CalculateImpostorScores(s001Mean, s004);
            sv.ImpostorScoresUser1User5 = EuclidDist.CalculateImpostorScores(s001Mean, s005);
            sv.ImpostorScoresUser1User6 = EuclidDist.CalculateImpostorScores(s001Mean, s006);
            sv.ImpostorScoresUser1User7 = EuclidDist.CalculateImpostorScores(s001Mean, s007);
            sv.ImpostorScoresUser1User8 = EuclidDist.CalculateImpostorScores(s001Mean, s008);
            sv.ImpostorScoresUser1User9 = EuclidDist.CalculateImpostorScores(s001Mean, s009);
            sv.ImpostorScoresUser1User10 = EuclidDist.CalculateImpostorScores(s001Mean, s010);

            sv.ImpostorScoresUser1User11 = EuclidDist.CalculateImpostorScores(s001Mean, s011);
            sv.ImpostorScoresUser1User12 = EuclidDist.CalculateImpostorScores(s001Mean, s012);
            sv.ImpostorScoresUser1User13 = EuclidDist.CalculateImpostorScores(s001Mean, s013);
            sv.ImpostorScoresUser1User14 = EuclidDist.CalculateImpostorScores(s001Mean, s014);
            sv.ImpostorScoresUser1User15 = EuclidDist.CalculateImpostorScores(s001Mean, s015);
            sv.ImpostorScoresUser1User16 = EuclidDist.CalculateImpostorScores(s001Mean, s016);
            sv.ImpostorScoresUser1User17 = EuclidDist.CalculateImpostorScores(s001Mean, s017);
            sv.ImpostorScoresUser1User18 = EuclidDist.CalculateImpostorScores(s001Mean, s018);
            sv.ImpostorScoresUser1User19 = EuclidDist.CalculateImpostorScores(s001Mean, s019);
            sv.ImpostorScoresUser1User20 = EuclidDist.CalculateImpostorScores(s001Mean, s020);

            sv.ImpostorScoresUser1User21 = EuclidDist.CalculateImpostorScores(s001Mean, s021);
            sv.ImpostorScoresUser1User22 = EuclidDist.CalculateImpostorScores(s001Mean, s022);
            sv.ImpostorScoresUser1User23 = EuclidDist.CalculateImpostorScores(s001Mean, s023);
            sv.ImpostorScoresUser1User24 = EuclidDist.CalculateImpostorScores(s001Mean, s024);
            sv.ImpostorScoresUser1User25 = EuclidDist.CalculateImpostorScores(s001Mean, s025);
            sv.ImpostorScoresUser1User26 = EuclidDist.CalculateImpostorScores(s001Mean, s026);
            sv.ImpostorScoresUser1User27 = EuclidDist.CalculateImpostorScores(s001Mean, s027);
            sv.ImpostorScoresUser1User28 = EuclidDist.CalculateImpostorScores(s001Mean, s028);
            sv.ImpostorScoresUser1User29 = EuclidDist.CalculateImpostorScores(s001Mean, s029);
            sv.ImpostorScoresUser1User30 = EuclidDist.CalculateImpostorScores(s001Mean, s030);

            sv.ImpostorScoresUser1User31 = EuclidDist.CalculateImpostorScores(s001Mean, s031);
            sv.ImpostorScoresUser1User32 = EuclidDist.CalculateImpostorScores(s001Mean, s032);
            sv.ImpostorScoresUser1User33 = EuclidDist.CalculateImpostorScores(s001Mean, s033);
            sv.ImpostorScoresUser1User34 = EuclidDist.CalculateImpostorScores(s001Mean, s034);
            sv.ImpostorScoresUser1User35 = EuclidDist.CalculateImpostorScores(s001Mean, s035);
            sv.ImpostorScoresUser1User36 = EuclidDist.CalculateImpostorScores(s001Mean, s036);
            sv.ImpostorScoresUser1User37 = EuclidDist.CalculateImpostorScores(s001Mean, s037);
            sv.ImpostorScoresUser1User38 = EuclidDist.CalculateImpostorScores(s001Mean, s038);
            sv.ImpostorScoresUser1User39 = EuclidDist.CalculateImpostorScores(s001Mean, s039);
            sv.ImpostorScoresUser1User40 = EuclidDist.CalculateImpostorScores(s001Mean, s040);

            sv.ImpostorScoresUser1User41 = EuclidDist.CalculateImpostorScores(s001Mean, s041);
            sv.ImpostorScoresUser1User42 = EuclidDist.CalculateImpostorScores(s001Mean, s042);
            sv.ImpostorScoresUser1User43 = EuclidDist.CalculateImpostorScores(s001Mean, s043);
            sv.ImpostorScoresUser1User44 = EuclidDist.CalculateImpostorScores(s001Mean, s044);
            sv.ImpostorScoresUser1User45 = EuclidDist.CalculateImpostorScores(s001Mean, s045);
            sv.ImpostorScoresUser1User46 = EuclidDist.CalculateImpostorScores(s001Mean, s046);
            sv.ImpostorScoresUser1User47 = EuclidDist.CalculateImpostorScores(s001Mean, s047);
            sv.ImpostorScoresUser1User48 = EuclidDist.CalculateImpostorScores(s001Mean, s048);
            sv.ImpostorScoresUser1User49 = EuclidDist.CalculateImpostorScores(s001Mean, s049);
            sv.ImpostorScoresUser1User50 = EuclidDist.CalculateImpostorScores(s001Mean, s050);

            sv.ImpostorScoresUser1User51 = EuclidDist.CalculateImpostorScores(s001Mean, s051);
            sv.ImpostorScoresUser1User52 = EuclidDist.CalculateImpostorScores(s001Mean, s052);
            sv.ImpostorScoresUser1User53 = EuclidDist.CalculateImpostorScores(s001Mean, s053);
            sv.ImpostorScoresUser1User54 = EuclidDist.CalculateImpostorScores(s001Mean, s054);
            sv.ImpostorScoresUser1User55 = EuclidDist.CalculateImpostorScores(s001Mean, s055);
            sv.ImpostorScoresUser1User56 = EuclidDist.CalculateImpostorScores(s001Mean, s056);
            sv.ImpostorScoresUser1User57 = EuclidDist.CalculateImpostorScores(s001Mean, s057);
            sv.ImpostorScoresUser1User58 = EuclidDist.CalculateImpostorScores(s001Mean, s058);
            sv.ImpostorScoresUser1User59 = EuclidDist.CalculateImpostorScores(s001Mean, s059);
            sv.ImpostorScoresUser1User60 = EuclidDist.CalculateImpostorScores(s001Mean, s060);

            sv.ImpostorScoresUser1User61 = EuclidDist.CalculateImpostorScores(s001Mean, s061);
            sv.ImpostorScoresUser1User62 = EuclidDist.CalculateImpostorScores(s001Mean, s062);
            sv.ImpostorScoresUser1User63 = EuclidDist.CalculateImpostorScores(s001Mean, s063);
            sv.ImpostorScoresUser1User64 = EuclidDist.CalculateImpostorScores(s001Mean, s064);
            sv.ImpostorScoresUser1User65 = EuclidDist.CalculateImpostorScores(s001Mean, s065);
            sv.ImpostorScoresUser1User66 = EuclidDist.CalculateImpostorScores(s001Mean, s066);
            sv.ImpostorScoresUser1User67 = EuclidDist.CalculateImpostorScores(s001Mean, s067);
            sv.ImpostorScoresUser1User68 = EuclidDist.CalculateImpostorScores(s001Mean, s068);
            sv.ImpostorScoresUser1User69 = EuclidDist.CalculateImpostorScores(s001Mean, s069);
            sv.ImpostorScoresUser1User70 = EuclidDist.CalculateImpostorScores(s001Mean, s070);

            sv.ImpostorScoresUser1User71 = EuclidDist.CalculateImpostorScores(s001Mean, s071);
            sv.ImpostorScoresUser1User72 = EuclidDist.CalculateImpostorScores(s001Mean, s072);
            sv.ImpostorScoresUser1User73 = EuclidDist.CalculateImpostorScores(s001Mean, s073);
            sv.ImpostorScoresUser1User74 = EuclidDist.CalculateImpostorScores(s001Mean, s074);
            sv.ImpostorScoresUser1User75 = EuclidDist.CalculateImpostorScores(s001Mean, s075);
            sv.ImpostorScoresUser1User76 = EuclidDist.CalculateImpostorScores(s001Mean, s076);
            sv.ImpostorScoresUser1User77 = EuclidDist.CalculateImpostorScores(s001Mean, s077);
            sv.ImpostorScoresUser1User78 = EuclidDist.CalculateImpostorScores(s001Mean, s078);
            sv.ImpostorScoresUser1User79 = EuclidDist.CalculateImpostorScores(s001Mean, s079);
            sv.ImpostorScoresUser1User80 = EuclidDist.CalculateImpostorScores(s001Mean, s080);

            sv.ImpostorScoresUser1User81 = EuclidDist.CalculateImpostorScores(s001Mean, s081);
            sv.ImpostorScoresUser1User82 = EuclidDist.CalculateImpostorScores(s001Mean, s082);
            sv.ImpostorScoresUser1User83 = EuclidDist.CalculateImpostorScores(s001Mean, s083);
            sv.ImpostorScoresUser1User84 = EuclidDist.CalculateImpostorScores(s001Mean, s084);
            sv.ImpostorScoresUser1User85 = EuclidDist.CalculateImpostorScores(s001Mean, s085);
            sv.ImpostorScoresUser1User86 = EuclidDist.CalculateImpostorScores(s001Mean, s086);
            sv.ImpostorScoresUser1User87 = EuclidDist.CalculateImpostorScores(s001Mean, s087);
            sv.ImpostorScoresUser1User88 = EuclidDist.CalculateImpostorScores(s001Mean, s088);
            sv.ImpostorScoresUser1User89 = EuclidDist.CalculateImpostorScores(s001Mean, s089);
            sv.ImpostorScoresUser1User90 = EuclidDist.CalculateImpostorScores(s001Mean, s090);

            sv.ImpostorScoresUser1User91 = EuclidDist.CalculateImpostorScores(s001Mean, s091);
            sv.ImpostorScoresUser1User92 = EuclidDist.CalculateImpostorScores(s001Mean, s092);
            sv.ImpostorScoresUser1User93 = EuclidDist.CalculateImpostorScores(s001Mean, s093);
            sv.ImpostorScoresUser1User94 = EuclidDist.CalculateImpostorScores(s001Mean, s094);
            sv.ImpostorScoresUser1User95 = EuclidDist.CalculateImpostorScores(s001Mean, s095);
            sv.ImpostorScoresUser1User96 = EuclidDist.CalculateImpostorScores(s001Mean, s096);
            sv.ImpostorScoresUser1User97 = EuclidDist.CalculateImpostorScores(s001Mean, s097);
            sv.ImpostorScoresUser1User98 = EuclidDist.CalculateImpostorScores(s001Mean, s098);
            sv.ImpostorScoresUser1User99 = EuclidDist.CalculateImpostorScores(s001Mean, s099);
            sv.ImpostorScoresUser1User100 = EuclidDist.CalculateImpostorScores(s001Mean, s100);
            #endregion

            #region User 2 Impostor scores
            sv.ImpostorScoresUser2User1 = EuclidDist.CalculateImpostorScores(s002Mean, s001);
            sv.ImpostorScoresUser2User3 = EuclidDist.CalculateImpostorScores(s002Mean, s003);
            sv.ImpostorScoresUser2User4 = EuclidDist.CalculateImpostorScores(s002Mean, s004);
            sv.ImpostorScoresUser2User5 = EuclidDist.CalculateImpostorScores(s002Mean, s005);
            sv.ImpostorScoresUser2User6 = EuclidDist.CalculateImpostorScores(s002Mean, s006);
            sv.ImpostorScoresUser2User7 = EuclidDist.CalculateImpostorScores(s002Mean, s007);
            sv.ImpostorScoresUser2User8 = EuclidDist.CalculateImpostorScores(s002Mean, s008);
            sv.ImpostorScoresUser2User9 = EuclidDist.CalculateImpostorScores(s002Mean, s009);
            sv.ImpostorScoresUser2User10 = EuclidDist.CalculateImpostorScores(s002Mean, s010);

            sv.ImpostorScoresUser2User11 = EuclidDist.CalculateImpostorScores(s002Mean, s011);
            sv.ImpostorScoresUser2User12 = EuclidDist.CalculateImpostorScores(s002Mean, s012);
            sv.ImpostorScoresUser2User13 = EuclidDist.CalculateImpostorScores(s002Mean, s013);
            sv.ImpostorScoresUser2User14 = EuclidDist.CalculateImpostorScores(s002Mean, s014);
            sv.ImpostorScoresUser2User15 = EuclidDist.CalculateImpostorScores(s002Mean, s015);
            sv.ImpostorScoresUser2User16 = EuclidDist.CalculateImpostorScores(s002Mean, s016);
            sv.ImpostorScoresUser2User17 = EuclidDist.CalculateImpostorScores(s002Mean, s017);
            sv.ImpostorScoresUser2User18 = EuclidDist.CalculateImpostorScores(s002Mean, s018);
            sv.ImpostorScoresUser2User19 = EuclidDist.CalculateImpostorScores(s002Mean, s019);
            sv.ImpostorScoresUser2User20 = EuclidDist.CalculateImpostorScores(s002Mean, s020);

            sv.ImpostorScoresUser2User21 = EuclidDist.CalculateImpostorScores(s002Mean, s021);
            sv.ImpostorScoresUser2User22 = EuclidDist.CalculateImpostorScores(s002Mean, s022);
            sv.ImpostorScoresUser2User23 = EuclidDist.CalculateImpostorScores(s002Mean, s023);
            sv.ImpostorScoresUser2User24 = EuclidDist.CalculateImpostorScores(s002Mean, s024);
            sv.ImpostorScoresUser2User25 = EuclidDist.CalculateImpostorScores(s002Mean, s025);
            sv.ImpostorScoresUser2User26 = EuclidDist.CalculateImpostorScores(s002Mean, s026);
            sv.ImpostorScoresUser2User27 = EuclidDist.CalculateImpostorScores(s002Mean, s027);
            sv.ImpostorScoresUser2User28 = EuclidDist.CalculateImpostorScores(s002Mean, s028);
            sv.ImpostorScoresUser2User29 = EuclidDist.CalculateImpostorScores(s002Mean, s029);
            sv.ImpostorScoresUser2User30 = EuclidDist.CalculateImpostorScores(s002Mean, s030);

            sv.ImpostorScoresUser2User31 = EuclidDist.CalculateImpostorScores(s002Mean, s031);
            sv.ImpostorScoresUser2User32 = EuclidDist.CalculateImpostorScores(s002Mean, s032);
            sv.ImpostorScoresUser2User33 = EuclidDist.CalculateImpostorScores(s002Mean, s033);
            sv.ImpostorScoresUser2User34 = EuclidDist.CalculateImpostorScores(s002Mean, s034);
            sv.ImpostorScoresUser2User35 = EuclidDist.CalculateImpostorScores(s002Mean, s035);
            sv.ImpostorScoresUser2User36 = EuclidDist.CalculateImpostorScores(s002Mean, s036);
            sv.ImpostorScoresUser2User37 = EuclidDist.CalculateImpostorScores(s002Mean, s037);
            sv.ImpostorScoresUser2User38 = EuclidDist.CalculateImpostorScores(s002Mean, s038);
            sv.ImpostorScoresUser2User39 = EuclidDist.CalculateImpostorScores(s002Mean, s039);
            sv.ImpostorScoresUser2User40 = EuclidDist.CalculateImpostorScores(s002Mean, s040);

            sv.ImpostorScoresUser2User41 = EuclidDist.CalculateImpostorScores(s002Mean, s041);
            sv.ImpostorScoresUser2User42 = EuclidDist.CalculateImpostorScores(s002Mean, s042);
            sv.ImpostorScoresUser2User43 = EuclidDist.CalculateImpostorScores(s002Mean, s043);
            sv.ImpostorScoresUser2User44 = EuclidDist.CalculateImpostorScores(s002Mean, s044);
            sv.ImpostorScoresUser2User45 = EuclidDist.CalculateImpostorScores(s002Mean, s045);
            sv.ImpostorScoresUser2User46 = EuclidDist.CalculateImpostorScores(s002Mean, s046);
            sv.ImpostorScoresUser2User47 = EuclidDist.CalculateImpostorScores(s002Mean, s047);
            sv.ImpostorScoresUser2User48 = EuclidDist.CalculateImpostorScores(s002Mean, s048);
            sv.ImpostorScoresUser2User49 = EuclidDist.CalculateImpostorScores(s002Mean, s049);
            sv.ImpostorScoresUser2User50 = EuclidDist.CalculateImpostorScores(s002Mean, s050);

            sv.ImpostorScoresUser2User51 = EuclidDist.CalculateImpostorScores(s002Mean, s051);
            sv.ImpostorScoresUser2User52 = EuclidDist.CalculateImpostorScores(s002Mean, s052);
            sv.ImpostorScoresUser2User53 = EuclidDist.CalculateImpostorScores(s002Mean, s053);
            sv.ImpostorScoresUser2User54 = EuclidDist.CalculateImpostorScores(s002Mean, s054);
            sv.ImpostorScoresUser2User55 = EuclidDist.CalculateImpostorScores(s002Mean, s055);
            sv.ImpostorScoresUser2User56 = EuclidDist.CalculateImpostorScores(s002Mean, s056);
            sv.ImpostorScoresUser2User57 = EuclidDist.CalculateImpostorScores(s002Mean, s057);
            sv.ImpostorScoresUser2User58 = EuclidDist.CalculateImpostorScores(s002Mean, s058);
            sv.ImpostorScoresUser2User59 = EuclidDist.CalculateImpostorScores(s002Mean, s059);
            sv.ImpostorScoresUser2User60 = EuclidDist.CalculateImpostorScores(s002Mean, s060);

            sv.ImpostorScoresUser2User61 = EuclidDist.CalculateImpostorScores(s002Mean, s061);
            sv.ImpostorScoresUser2User62 = EuclidDist.CalculateImpostorScores(s002Mean, s062);
            sv.ImpostorScoresUser2User63 = EuclidDist.CalculateImpostorScores(s002Mean, s063);
            sv.ImpostorScoresUser2User64 = EuclidDist.CalculateImpostorScores(s002Mean, s064);
            sv.ImpostorScoresUser2User65 = EuclidDist.CalculateImpostorScores(s002Mean, s065);
            sv.ImpostorScoresUser2User66 = EuclidDist.CalculateImpostorScores(s002Mean, s066);
            sv.ImpostorScoresUser2User67 = EuclidDist.CalculateImpostorScores(s002Mean, s067);
            sv.ImpostorScoresUser2User68 = EuclidDist.CalculateImpostorScores(s002Mean, s068);
            sv.ImpostorScoresUser2User69 = EuclidDist.CalculateImpostorScores(s002Mean, s069);
            sv.ImpostorScoresUser2User70 = EuclidDist.CalculateImpostorScores(s002Mean, s070);

            sv.ImpostorScoresUser2User71 = EuclidDist.CalculateImpostorScores(s002Mean, s071);
            sv.ImpostorScoresUser2User72 = EuclidDist.CalculateImpostorScores(s002Mean, s072);
            sv.ImpostorScoresUser2User73 = EuclidDist.CalculateImpostorScores(s002Mean, s073);
            sv.ImpostorScoresUser2User74 = EuclidDist.CalculateImpostorScores(s002Mean, s074);
            sv.ImpostorScoresUser2User75 = EuclidDist.CalculateImpostorScores(s002Mean, s075);
            sv.ImpostorScoresUser2User76 = EuclidDist.CalculateImpostorScores(s002Mean, s076);
            sv.ImpostorScoresUser2User77 = EuclidDist.CalculateImpostorScores(s002Mean, s077);
            sv.ImpostorScoresUser2User78 = EuclidDist.CalculateImpostorScores(s002Mean, s078);
            sv.ImpostorScoresUser2User79 = EuclidDist.CalculateImpostorScores(s002Mean, s079);
            sv.ImpostorScoresUser2User80 = EuclidDist.CalculateImpostorScores(s002Mean, s080);

            sv.ImpostorScoresUser2User81 = EuclidDist.CalculateImpostorScores(s002Mean, s081);
            sv.ImpostorScoresUser2User82 = EuclidDist.CalculateImpostorScores(s002Mean, s082);
            sv.ImpostorScoresUser2User83 = EuclidDist.CalculateImpostorScores(s002Mean, s083);
            sv.ImpostorScoresUser2User84 = EuclidDist.CalculateImpostorScores(s002Mean, s084);
            sv.ImpostorScoresUser2User85 = EuclidDist.CalculateImpostorScores(s002Mean, s085);
            sv.ImpostorScoresUser2User86 = EuclidDist.CalculateImpostorScores(s002Mean, s086);
            sv.ImpostorScoresUser2User87 = EuclidDist.CalculateImpostorScores(s002Mean, s087);
            sv.ImpostorScoresUser2User88 = EuclidDist.CalculateImpostorScores(s002Mean, s088);
            sv.ImpostorScoresUser2User89 = EuclidDist.CalculateImpostorScores(s002Mean, s089);
            sv.ImpostorScoresUser2User90 = EuclidDist.CalculateImpostorScores(s002Mean, s090);

            sv.ImpostorScoresUser2User91 = EuclidDist.CalculateImpostorScores(s002Mean, s091);
            sv.ImpostorScoresUser2User92 = EuclidDist.CalculateImpostorScores(s002Mean, s092);
            sv.ImpostorScoresUser2User93 = EuclidDist.CalculateImpostorScores(s002Mean, s093);
            sv.ImpostorScoresUser2User94 = EuclidDist.CalculateImpostorScores(s002Mean, s094);
            sv.ImpostorScoresUser2User95 = EuclidDist.CalculateImpostorScores(s002Mean, s095);
            sv.ImpostorScoresUser2User96 = EuclidDist.CalculateImpostorScores(s002Mean, s096);
            sv.ImpostorScoresUser2User97 = EuclidDist.CalculateImpostorScores(s002Mean, s097);
            sv.ImpostorScoresUser2User98 = EuclidDist.CalculateImpostorScores(s002Mean, s098);
            sv.ImpostorScoresUser2User99 = EuclidDist.CalculateImpostorScores(s002Mean, s099);
            sv.ImpostorScoresUser2User100 = EuclidDist.CalculateImpostorScores(s002Mean, s100);
            #endregion

            #region User 3 Impostor scores
            sv.ImpostorScoresUser3User1 = EuclidDist.CalculateImpostorScores(s003Mean, s001);
            sv.ImpostorScoresUser3User2 = EuclidDist.CalculateImpostorScores(s003Mean, s002);
            sv.ImpostorScoresUser3User4 = EuclidDist.CalculateImpostorScores(s003Mean, s004);
            sv.ImpostorScoresUser3User5 = EuclidDist.CalculateImpostorScores(s003Mean, s005);
            sv.ImpostorScoresUser3User6 = EuclidDist.CalculateImpostorScores(s003Mean, s006);
            sv.ImpostorScoresUser3User7 = EuclidDist.CalculateImpostorScores(s003Mean, s007);
            sv.ImpostorScoresUser3User8 = EuclidDist.CalculateImpostorScores(s003Mean, s008);
            sv.ImpostorScoresUser3User9 = EuclidDist.CalculateImpostorScores(s003Mean, s009);

            sv.ImpostorScoresUser3User10 = EuclidDist.CalculateImpostorScores(s003Mean, s010);
            sv.ImpostorScoresUser3User11 = EuclidDist.CalculateImpostorScores(s003Mean, s011);
            sv.ImpostorScoresUser3User12 = EuclidDist.CalculateImpostorScores(s003Mean, s012);
            sv.ImpostorScoresUser3User13 = EuclidDist.CalculateImpostorScores(s003Mean, s013);
            sv.ImpostorScoresUser3User14 = EuclidDist.CalculateImpostorScores(s003Mean, s014);
            sv.ImpostorScoresUser3User15 = EuclidDist.CalculateImpostorScores(s003Mean, s015);
            sv.ImpostorScoresUser3User16 = EuclidDist.CalculateImpostorScores(s003Mean, s016);
            sv.ImpostorScoresUser3User17 = EuclidDist.CalculateImpostorScores(s003Mean, s017);
            sv.ImpostorScoresUser3User18 = EuclidDist.CalculateImpostorScores(s003Mean, s018);
            sv.ImpostorScoresUser3User19 = EuclidDist.CalculateImpostorScores(s003Mean, s019);
            sv.ImpostorScoresUser3User20 = EuclidDist.CalculateImpostorScores(s003Mean, s020);

            sv.ImpostorScoresUser3User21 = EuclidDist.CalculateImpostorScores(s003Mean, s021);
            sv.ImpostorScoresUser3User22 = EuclidDist.CalculateImpostorScores(s003Mean, s022);
            sv.ImpostorScoresUser3User23 = EuclidDist.CalculateImpostorScores(s003Mean, s023);
            sv.ImpostorScoresUser3User24 = EuclidDist.CalculateImpostorScores(s003Mean, s024);
            sv.ImpostorScoresUser3User25 = EuclidDist.CalculateImpostorScores(s003Mean, s025);
            sv.ImpostorScoresUser3User26 = EuclidDist.CalculateImpostorScores(s003Mean, s026);
            sv.ImpostorScoresUser3User27 = EuclidDist.CalculateImpostorScores(s003Mean, s027);
            sv.ImpostorScoresUser3User28 = EuclidDist.CalculateImpostorScores(s003Mean, s028);
            sv.ImpostorScoresUser3User29 = EuclidDist.CalculateImpostorScores(s003Mean, s029);
            sv.ImpostorScoresUser3User30 = EuclidDist.CalculateImpostorScores(s003Mean, s030);

            sv.ImpostorScoresUser3User31 = EuclidDist.CalculateImpostorScores(s003Mean, s031);
            sv.ImpostorScoresUser3User32 = EuclidDist.CalculateImpostorScores(s003Mean, s032);
            sv.ImpostorScoresUser3User33 = EuclidDist.CalculateImpostorScores(s003Mean, s033);
            sv.ImpostorScoresUser3User34 = EuclidDist.CalculateImpostorScores(s003Mean, s034);
            sv.ImpostorScoresUser3User35 = EuclidDist.CalculateImpostorScores(s003Mean, s035);
            sv.ImpostorScoresUser3User36 = EuclidDist.CalculateImpostorScores(s003Mean, s036);
            sv.ImpostorScoresUser3User37 = EuclidDist.CalculateImpostorScores(s003Mean, s037);
            sv.ImpostorScoresUser3User38 = EuclidDist.CalculateImpostorScores(s003Mean, s038);
            sv.ImpostorScoresUser3User39 = EuclidDist.CalculateImpostorScores(s003Mean, s039);
            sv.ImpostorScoresUser3User40 = EuclidDist.CalculateImpostorScores(s003Mean, s040);

            sv.ImpostorScoresUser3User41 = EuclidDist.CalculateImpostorScores(s003Mean, s041);
            sv.ImpostorScoresUser3User42 = EuclidDist.CalculateImpostorScores(s003Mean, s042);
            sv.ImpostorScoresUser3User43 = EuclidDist.CalculateImpostorScores(s003Mean, s043);
            sv.ImpostorScoresUser3User44 = EuclidDist.CalculateImpostorScores(s003Mean, s044);
            sv.ImpostorScoresUser3User45 = EuclidDist.CalculateImpostorScores(s003Mean, s045);
            sv.ImpostorScoresUser3User46 = EuclidDist.CalculateImpostorScores(s003Mean, s046);
            sv.ImpostorScoresUser3User47 = EuclidDist.CalculateImpostorScores(s003Mean, s047);
            sv.ImpostorScoresUser3User48 = EuclidDist.CalculateImpostorScores(s003Mean, s048);
            sv.ImpostorScoresUser3User49 = EuclidDist.CalculateImpostorScores(s003Mean, s049);
            sv.ImpostorScoresUser3User50 = EuclidDist.CalculateImpostorScores(s003Mean, s050);

            sv.ImpostorScoresUser3User51 = EuclidDist.CalculateImpostorScores(s003Mean, s051);
            sv.ImpostorScoresUser3User52 = EuclidDist.CalculateImpostorScores(s003Mean, s052);
            sv.ImpostorScoresUser3User53 = EuclidDist.CalculateImpostorScores(s003Mean, s053);
            sv.ImpostorScoresUser3User54 = EuclidDist.CalculateImpostorScores(s003Mean, s054);
            sv.ImpostorScoresUser3User55 = EuclidDist.CalculateImpostorScores(s003Mean, s055);
            sv.ImpostorScoresUser3User56 = EuclidDist.CalculateImpostorScores(s003Mean, s056);
            sv.ImpostorScoresUser3User57 = EuclidDist.CalculateImpostorScores(s003Mean, s057);
            sv.ImpostorScoresUser3User58 = EuclidDist.CalculateImpostorScores(s003Mean, s058);
            sv.ImpostorScoresUser3User59 = EuclidDist.CalculateImpostorScores(s003Mean, s059);
            sv.ImpostorScoresUser3User60 = EuclidDist.CalculateImpostorScores(s003Mean, s060);

            sv.ImpostorScoresUser3User61 = EuclidDist.CalculateImpostorScores(s003Mean, s061);
            sv.ImpostorScoresUser3User62 = EuclidDist.CalculateImpostorScores(s003Mean, s062);
            sv.ImpostorScoresUser3User63 = EuclidDist.CalculateImpostorScores(s003Mean, s063);
            sv.ImpostorScoresUser3User64 = EuclidDist.CalculateImpostorScores(s003Mean, s064);
            sv.ImpostorScoresUser3User65 = EuclidDist.CalculateImpostorScores(s003Mean, s065);
            sv.ImpostorScoresUser3User66 = EuclidDist.CalculateImpostorScores(s003Mean, s066);
            sv.ImpostorScoresUser3User67 = EuclidDist.CalculateImpostorScores(s003Mean, s067);
            sv.ImpostorScoresUser3User68 = EuclidDist.CalculateImpostorScores(s003Mean, s068);
            sv.ImpostorScoresUser3User69 = EuclidDist.CalculateImpostorScores(s003Mean, s069);
            sv.ImpostorScoresUser3User70 = EuclidDist.CalculateImpostorScores(s003Mean, s070);

            sv.ImpostorScoresUser3User71 = EuclidDist.CalculateImpostorScores(s003Mean, s071);
            sv.ImpostorScoresUser3User72 = EuclidDist.CalculateImpostorScores(s003Mean, s072);
            sv.ImpostorScoresUser3User73 = EuclidDist.CalculateImpostorScores(s003Mean, s073);
            sv.ImpostorScoresUser3User74 = EuclidDist.CalculateImpostorScores(s003Mean, s074);
            sv.ImpostorScoresUser3User75 = EuclidDist.CalculateImpostorScores(s003Mean, s075);
            sv.ImpostorScoresUser3User76 = EuclidDist.CalculateImpostorScores(s003Mean, s076);
            sv.ImpostorScoresUser3User77 = EuclidDist.CalculateImpostorScores(s003Mean, s077);
            sv.ImpostorScoresUser3User78 = EuclidDist.CalculateImpostorScores(s003Mean, s078);
            sv.ImpostorScoresUser3User79 = EuclidDist.CalculateImpostorScores(s003Mean, s079);
            sv.ImpostorScoresUser3User80 = EuclidDist.CalculateImpostorScores(s003Mean, s080);

            sv.ImpostorScoresUser3User81 = EuclidDist.CalculateImpostorScores(s003Mean, s081);
            sv.ImpostorScoresUser3User82 = EuclidDist.CalculateImpostorScores(s003Mean, s082);
            sv.ImpostorScoresUser3User83 = EuclidDist.CalculateImpostorScores(s003Mean, s083);
            sv.ImpostorScoresUser3User84 = EuclidDist.CalculateImpostorScores(s003Mean, s084);
            sv.ImpostorScoresUser3User85 = EuclidDist.CalculateImpostorScores(s003Mean, s085);
            sv.ImpostorScoresUser3User86 = EuclidDist.CalculateImpostorScores(s003Mean, s086);
            sv.ImpostorScoresUser3User87 = EuclidDist.CalculateImpostorScores(s003Mean, s087);
            sv.ImpostorScoresUser3User88 = EuclidDist.CalculateImpostorScores(s003Mean, s088);
            sv.ImpostorScoresUser3User89 = EuclidDist.CalculateImpostorScores(s003Mean, s089);
            sv.ImpostorScoresUser3User90 = EuclidDist.CalculateImpostorScores(s003Mean, s090);

            sv.ImpostorScoresUser3User91 = EuclidDist.CalculateImpostorScores(s003Mean, s091);
            sv.ImpostorScoresUser3User92 = EuclidDist.CalculateImpostorScores(s003Mean, s092);
            sv.ImpostorScoresUser3User93 = EuclidDist.CalculateImpostorScores(s003Mean, s093);
            sv.ImpostorScoresUser3User94 = EuclidDist.CalculateImpostorScores(s003Mean, s094);
            sv.ImpostorScoresUser3User95 = EuclidDist.CalculateImpostorScores(s003Mean, s095);
            sv.ImpostorScoresUser3User96 = EuclidDist.CalculateImpostorScores(s003Mean, s096);
            sv.ImpostorScoresUser3User97 = EuclidDist.CalculateImpostorScores(s003Mean, s097);
            sv.ImpostorScoresUser3User98 = EuclidDist.CalculateImpostorScores(s003Mean, s098);
            sv.ImpostorScoresUser3User99 = EuclidDist.CalculateImpostorScores(s003Mean, s099);
            sv.ImpostorScoresUser3User100 = EuclidDist.CalculateImpostorScores(s003Mean, s100);
            #endregion

            #region User 4 Impostor scores
            sv.ImpostorScoresUser4User1 = EuclidDist.CalculateImpostorScores(s004Mean, s001);
            sv.ImpostorScoresUser4User2 = EuclidDist.CalculateImpostorScores(s004Mean, s002);
            sv.ImpostorScoresUser4User3 = EuclidDist.CalculateImpostorScores(s004Mean, s003);
            sv.ImpostorScoresUser4User5 = EuclidDist.CalculateImpostorScores(s004Mean, s005);
            sv.ImpostorScoresUser4User6 = EuclidDist.CalculateImpostorScores(s004Mean, s006);
            sv.ImpostorScoresUser4User7 = EuclidDist.CalculateImpostorScores(s004Mean, s007);
            sv.ImpostorScoresUser4User8 = EuclidDist.CalculateImpostorScores(s004Mean, s008);
            sv.ImpostorScoresUser4User9 = EuclidDist.CalculateImpostorScores(s004Mean, s009);
            sv.ImpostorScoresUser4User10 = EuclidDist.CalculateImpostorScores(s004Mean, s010);

            sv.ImpostorScoresUser4User11 = EuclidDist.CalculateImpostorScores(s004Mean, s011);
            sv.ImpostorScoresUser4User12 = EuclidDist.CalculateImpostorScores(s004Mean, s012);
            sv.ImpostorScoresUser4User13 = EuclidDist.CalculateImpostorScores(s004Mean, s013);
            sv.ImpostorScoresUser4User14 = EuclidDist.CalculateImpostorScores(s004Mean, s014);
            sv.ImpostorScoresUser4User15 = EuclidDist.CalculateImpostorScores(s004Mean, s015);
            sv.ImpostorScoresUser4User16 = EuclidDist.CalculateImpostorScores(s004Mean, s016);
            sv.ImpostorScoresUser4User17 = EuclidDist.CalculateImpostorScores(s004Mean, s017);
            sv.ImpostorScoresUser4User18 = EuclidDist.CalculateImpostorScores(s004Mean, s018);
            sv.ImpostorScoresUser4User19 = EuclidDist.CalculateImpostorScores(s004Mean, s019);
            sv.ImpostorScoresUser4User20 = EuclidDist.CalculateImpostorScores(s004Mean, s020);

            sv.ImpostorScoresUser4User21 = EuclidDist.CalculateImpostorScores(s004Mean, s021);
            sv.ImpostorScoresUser4User22 = EuclidDist.CalculateImpostorScores(s004Mean, s022);
            sv.ImpostorScoresUser4User23 = EuclidDist.CalculateImpostorScores(s004Mean, s023);
            sv.ImpostorScoresUser4User24 = EuclidDist.CalculateImpostorScores(s004Mean, s024);
            sv.ImpostorScoresUser4User25 = EuclidDist.CalculateImpostorScores(s004Mean, s025);
            sv.ImpostorScoresUser4User26 = EuclidDist.CalculateImpostorScores(s004Mean, s026);
            sv.ImpostorScoresUser4User27 = EuclidDist.CalculateImpostorScores(s004Mean, s027);
            sv.ImpostorScoresUser4User28 = EuclidDist.CalculateImpostorScores(s004Mean, s028);
            sv.ImpostorScoresUser4User29 = EuclidDist.CalculateImpostorScores(s004Mean, s029);
            sv.ImpostorScoresUser4User30 = EuclidDist.CalculateImpostorScores(s004Mean, s030);

            sv.ImpostorScoresUser4User31 = EuclidDist.CalculateImpostorScores(s004Mean, s031);
            sv.ImpostorScoresUser4User32 = EuclidDist.CalculateImpostorScores(s004Mean, s032);
            sv.ImpostorScoresUser4User33 = EuclidDist.CalculateImpostorScores(s004Mean, s033);
            sv.ImpostorScoresUser4User34 = EuclidDist.CalculateImpostorScores(s004Mean, s034);
            sv.ImpostorScoresUser4User35 = EuclidDist.CalculateImpostorScores(s004Mean, s035);
            sv.ImpostorScoresUser4User36 = EuclidDist.CalculateImpostorScores(s004Mean, s036);
            sv.ImpostorScoresUser4User37 = EuclidDist.CalculateImpostorScores(s004Mean, s037);
            sv.ImpostorScoresUser4User38 = EuclidDist.CalculateImpostorScores(s004Mean, s038);
            sv.ImpostorScoresUser4User39 = EuclidDist.CalculateImpostorScores(s004Mean, s039);
            sv.ImpostorScoresUser4User40 = EuclidDist.CalculateImpostorScores(s004Mean, s040);

            sv.ImpostorScoresUser4User41 = EuclidDist.CalculateImpostorScores(s004Mean, s041);
            sv.ImpostorScoresUser4User42 = EuclidDist.CalculateImpostorScores(s004Mean, s042);
            sv.ImpostorScoresUser4User43 = EuclidDist.CalculateImpostorScores(s004Mean, s043);
            sv.ImpostorScoresUser4User44 = EuclidDist.CalculateImpostorScores(s004Mean, s044);
            sv.ImpostorScoresUser4User45 = EuclidDist.CalculateImpostorScores(s004Mean, s045);
            sv.ImpostorScoresUser4User46 = EuclidDist.CalculateImpostorScores(s004Mean, s046);
            sv.ImpostorScoresUser4User47 = EuclidDist.CalculateImpostorScores(s004Mean, s047);
            sv.ImpostorScoresUser4User48 = EuclidDist.CalculateImpostorScores(s004Mean, s048);
            sv.ImpostorScoresUser4User49 = EuclidDist.CalculateImpostorScores(s004Mean, s049);
            sv.ImpostorScoresUser4User50 = EuclidDist.CalculateImpostorScores(s004Mean, s050);

            sv.ImpostorScoresUser4User51 = EuclidDist.CalculateImpostorScores(s004Mean, s051);
            sv.ImpostorScoresUser4User52 = EuclidDist.CalculateImpostorScores(s004Mean, s052);
            sv.ImpostorScoresUser4User53 = EuclidDist.CalculateImpostorScores(s004Mean, s053);
            sv.ImpostorScoresUser4User54 = EuclidDist.CalculateImpostorScores(s004Mean, s054);
            sv.ImpostorScoresUser4User55 = EuclidDist.CalculateImpostorScores(s004Mean, s055);
            sv.ImpostorScoresUser4User56 = EuclidDist.CalculateImpostorScores(s004Mean, s056);
            sv.ImpostorScoresUser4User57 = EuclidDist.CalculateImpostorScores(s004Mean, s057);
            sv.ImpostorScoresUser4User58 = EuclidDist.CalculateImpostorScores(s004Mean, s058);
            sv.ImpostorScoresUser4User59 = EuclidDist.CalculateImpostorScores(s004Mean, s059);
            sv.ImpostorScoresUser4User60 = EuclidDist.CalculateImpostorScores(s004Mean, s060);

            sv.ImpostorScoresUser4User61 = EuclidDist.CalculateImpostorScores(s004Mean, s061);
            sv.ImpostorScoresUser4User62 = EuclidDist.CalculateImpostorScores(s004Mean, s062);
            sv.ImpostorScoresUser4User63 = EuclidDist.CalculateImpostorScores(s004Mean, s063);
            sv.ImpostorScoresUser4User64 = EuclidDist.CalculateImpostorScores(s004Mean, s064);
            sv.ImpostorScoresUser4User65 = EuclidDist.CalculateImpostorScores(s004Mean, s065);
            sv.ImpostorScoresUser4User66 = EuclidDist.CalculateImpostorScores(s004Mean, s066);
            sv.ImpostorScoresUser4User67 = EuclidDist.CalculateImpostorScores(s004Mean, s067);
            sv.ImpostorScoresUser4User68 = EuclidDist.CalculateImpostorScores(s004Mean, s068);
            sv.ImpostorScoresUser4User69 = EuclidDist.CalculateImpostorScores(s004Mean, s069);
            sv.ImpostorScoresUser4User70 = EuclidDist.CalculateImpostorScores(s004Mean, s070);

            sv.ImpostorScoresUser4User71 = EuclidDist.CalculateImpostorScores(s004Mean, s071);
            sv.ImpostorScoresUser4User72 = EuclidDist.CalculateImpostorScores(s004Mean, s072);
            sv.ImpostorScoresUser4User73 = EuclidDist.CalculateImpostorScores(s004Mean, s073);
            sv.ImpostorScoresUser4User74 = EuclidDist.CalculateImpostorScores(s004Mean, s074);
            sv.ImpostorScoresUser4User75 = EuclidDist.CalculateImpostorScores(s004Mean, s075);
            sv.ImpostorScoresUser4User76 = EuclidDist.CalculateImpostorScores(s004Mean, s076);
            sv.ImpostorScoresUser4User77 = EuclidDist.CalculateImpostorScores(s004Mean, s077);
            sv.ImpostorScoresUser4User78 = EuclidDist.CalculateImpostorScores(s004Mean, s078);
            sv.ImpostorScoresUser4User79 = EuclidDist.CalculateImpostorScores(s004Mean, s079);
            sv.ImpostorScoresUser4User80 = EuclidDist.CalculateImpostorScores(s004Mean, s080);

            sv.ImpostorScoresUser4User81 = EuclidDist.CalculateImpostorScores(s004Mean, s081);
            sv.ImpostorScoresUser4User82 = EuclidDist.CalculateImpostorScores(s004Mean, s082);
            sv.ImpostorScoresUser4User83 = EuclidDist.CalculateImpostorScores(s004Mean, s083);
            sv.ImpostorScoresUser4User84 = EuclidDist.CalculateImpostorScores(s004Mean, s084);
            sv.ImpostorScoresUser4User85 = EuclidDist.CalculateImpostorScores(s004Mean, s085);
            sv.ImpostorScoresUser4User86 = EuclidDist.CalculateImpostorScores(s004Mean, s086);
            sv.ImpostorScoresUser4User87 = EuclidDist.CalculateImpostorScores(s004Mean, s087);
            sv.ImpostorScoresUser4User88 = EuclidDist.CalculateImpostorScores(s004Mean, s088);
            sv.ImpostorScoresUser4User89 = EuclidDist.CalculateImpostorScores(s004Mean, s089);
            sv.ImpostorScoresUser4User90 = EuclidDist.CalculateImpostorScores(s004Mean, s090);

            sv.ImpostorScoresUser4User91 = EuclidDist.CalculateImpostorScores(s004Mean, s091);
            sv.ImpostorScoresUser4User92 = EuclidDist.CalculateImpostorScores(s004Mean, s092);
            sv.ImpostorScoresUser4User93 = EuclidDist.CalculateImpostorScores(s004Mean, s093);
            sv.ImpostorScoresUser4User94 = EuclidDist.CalculateImpostorScores(s004Mean, s094);
            sv.ImpostorScoresUser4User95 = EuclidDist.CalculateImpostorScores(s004Mean, s095);
            sv.ImpostorScoresUser4User96 = EuclidDist.CalculateImpostorScores(s004Mean, s096);
            sv.ImpostorScoresUser4User97 = EuclidDist.CalculateImpostorScores(s004Mean, s097);
            sv.ImpostorScoresUser4User98 = EuclidDist.CalculateImpostorScores(s004Mean, s098);
            sv.ImpostorScoresUser4User99 = EuclidDist.CalculateImpostorScores(s004Mean, s099);
            sv.ImpostorScoresUser4User100 = EuclidDist.CalculateImpostorScores(s004Mean, s100);
            #endregion

            #region User 5 Impostor scores
            sv.ImpostorScoresUser5User1 = EuclidDist.CalculateImpostorScores(s005Mean, s001);
            sv.ImpostorScoresUser5User2 = EuclidDist.CalculateImpostorScores(s005Mean, s002);
            sv.ImpostorScoresUser5User3 = EuclidDist.CalculateImpostorScores(s005Mean, s003);
            sv.ImpostorScoresUser5User4 = EuclidDist.CalculateImpostorScores(s005Mean, s004);
            sv.ImpostorScoresUser5User6 = EuclidDist.CalculateImpostorScores(s005Mean, s006);
            sv.ImpostorScoresUser5User7 = EuclidDist.CalculateImpostorScores(s005Mean, s007);
            sv.ImpostorScoresUser5User8 = EuclidDist.CalculateImpostorScores(s005Mean, s008);
            sv.ImpostorScoresUser5User9 = EuclidDist.CalculateImpostorScores(s005Mean, s009);
            sv.ImpostorScoresUser5User10 = EuclidDist.CalculateImpostorScores(s005Mean, s010);

            sv.ImpostorScoresUser5User11 = EuclidDist.CalculateImpostorScores(s005Mean, s011);
            sv.ImpostorScoresUser5User12 = EuclidDist.CalculateImpostorScores(s005Mean, s012);
            sv.ImpostorScoresUser5User13 = EuclidDist.CalculateImpostorScores(s005Mean, s013);
            sv.ImpostorScoresUser5User14 = EuclidDist.CalculateImpostorScores(s005Mean, s014);
            sv.ImpostorScoresUser5User15 = EuclidDist.CalculateImpostorScores(s005Mean, s015);
            sv.ImpostorScoresUser5User16 = EuclidDist.CalculateImpostorScores(s005Mean, s016);
            sv.ImpostorScoresUser5User17 = EuclidDist.CalculateImpostorScores(s005Mean, s017);
            sv.ImpostorScoresUser5User18 = EuclidDist.CalculateImpostorScores(s005Mean, s018);
            sv.ImpostorScoresUser5User19 = EuclidDist.CalculateImpostorScores(s005Mean, s019);
            sv.ImpostorScoresUser5User20 = EuclidDist.CalculateImpostorScores(s005Mean, s020);

            sv.ImpostorScoresUser5User21 = EuclidDist.CalculateImpostorScores(s005Mean, s021);
            sv.ImpostorScoresUser5User22 = EuclidDist.CalculateImpostorScores(s005Mean, s022);
            sv.ImpostorScoresUser5User23 = EuclidDist.CalculateImpostorScores(s005Mean, s023);
            sv.ImpostorScoresUser5User24 = EuclidDist.CalculateImpostorScores(s005Mean, s024);
            sv.ImpostorScoresUser5User25 = EuclidDist.CalculateImpostorScores(s005Mean, s025);
            sv.ImpostorScoresUser5User26 = EuclidDist.CalculateImpostorScores(s005Mean, s026);
            sv.ImpostorScoresUser5User27 = EuclidDist.CalculateImpostorScores(s005Mean, s027);
            sv.ImpostorScoresUser5User28 = EuclidDist.CalculateImpostorScores(s005Mean, s028);
            sv.ImpostorScoresUser5User29 = EuclidDist.CalculateImpostorScores(s005Mean, s029);
            sv.ImpostorScoresUser5User30 = EuclidDist.CalculateImpostorScores(s005Mean, s030);

            sv.ImpostorScoresUser5User31 = EuclidDist.CalculateImpostorScores(s005Mean, s031);
            sv.ImpostorScoresUser5User32 = EuclidDist.CalculateImpostorScores(s005Mean, s032);
            sv.ImpostorScoresUser5User33 = EuclidDist.CalculateImpostorScores(s005Mean, s033);
            sv.ImpostorScoresUser5User34 = EuclidDist.CalculateImpostorScores(s005Mean, s034);
            sv.ImpostorScoresUser5User35 = EuclidDist.CalculateImpostorScores(s005Mean, s035);
            sv.ImpostorScoresUser5User36 = EuclidDist.CalculateImpostorScores(s005Mean, s036);
            sv.ImpostorScoresUser5User37 = EuclidDist.CalculateImpostorScores(s005Mean, s037);
            sv.ImpostorScoresUser5User38 = EuclidDist.CalculateImpostorScores(s005Mean, s038);
            sv.ImpostorScoresUser5User39 = EuclidDist.CalculateImpostorScores(s005Mean, s039);
            sv.ImpostorScoresUser5User40 = EuclidDist.CalculateImpostorScores(s005Mean, s040);

            sv.ImpostorScoresUser5User41 = EuclidDist.CalculateImpostorScores(s005Mean, s041);
            sv.ImpostorScoresUser5User42 = EuclidDist.CalculateImpostorScores(s005Mean, s042);
            sv.ImpostorScoresUser5User43 = EuclidDist.CalculateImpostorScores(s005Mean, s043);
            sv.ImpostorScoresUser5User44 = EuclidDist.CalculateImpostorScores(s005Mean, s044);
            sv.ImpostorScoresUser5User45 = EuclidDist.CalculateImpostorScores(s005Mean, s045);
            sv.ImpostorScoresUser5User46 = EuclidDist.CalculateImpostorScores(s005Mean, s046);
            sv.ImpostorScoresUser5User47 = EuclidDist.CalculateImpostorScores(s005Mean, s047);
            sv.ImpostorScoresUser5User48 = EuclidDist.CalculateImpostorScores(s005Mean, s048);
            sv.ImpostorScoresUser5User49 = EuclidDist.CalculateImpostorScores(s005Mean, s049);
            sv.ImpostorScoresUser5User50 = EuclidDist.CalculateImpostorScores(s005Mean, s050);

            sv.ImpostorScoresUser5User51 = EuclidDist.CalculateImpostorScores(s005Mean, s051);
            sv.ImpostorScoresUser5User52 = EuclidDist.CalculateImpostorScores(s005Mean, s052);
            sv.ImpostorScoresUser5User53 = EuclidDist.CalculateImpostorScores(s005Mean, s053);
            sv.ImpostorScoresUser5User54 = EuclidDist.CalculateImpostorScores(s005Mean, s054);
            sv.ImpostorScoresUser5User55 = EuclidDist.CalculateImpostorScores(s005Mean, s055);
            sv.ImpostorScoresUser5User56 = EuclidDist.CalculateImpostorScores(s005Mean, s056);
            sv.ImpostorScoresUser5User57 = EuclidDist.CalculateImpostorScores(s005Mean, s057);
            sv.ImpostorScoresUser5User58 = EuclidDist.CalculateImpostorScores(s005Mean, s058);
            sv.ImpostorScoresUser5User59 = EuclidDist.CalculateImpostorScores(s005Mean, s059);
            sv.ImpostorScoresUser5User60 = EuclidDist.CalculateImpostorScores(s005Mean, s060);

            sv.ImpostorScoresUser5User61 = EuclidDist.CalculateImpostorScores(s005Mean, s061);
            sv.ImpostorScoresUser5User62 = EuclidDist.CalculateImpostorScores(s005Mean, s062);
            sv.ImpostorScoresUser5User63 = EuclidDist.CalculateImpostorScores(s005Mean, s063);
            sv.ImpostorScoresUser5User64 = EuclidDist.CalculateImpostorScores(s005Mean, s064);
            sv.ImpostorScoresUser5User65 = EuclidDist.CalculateImpostorScores(s005Mean, s065);
            sv.ImpostorScoresUser5User66 = EuclidDist.CalculateImpostorScores(s005Mean, s066);
            sv.ImpostorScoresUser5User67 = EuclidDist.CalculateImpostorScores(s005Mean, s067);
            sv.ImpostorScoresUser5User68 = EuclidDist.CalculateImpostorScores(s005Mean, s068);
            sv.ImpostorScoresUser5User69 = EuclidDist.CalculateImpostorScores(s005Mean, s069);
            sv.ImpostorScoresUser5User70 = EuclidDist.CalculateImpostorScores(s005Mean, s070);

            sv.ImpostorScoresUser5User71 = EuclidDist.CalculateImpostorScores(s005Mean, s071);
            sv.ImpostorScoresUser5User72 = EuclidDist.CalculateImpostorScores(s005Mean, s072);
            sv.ImpostorScoresUser5User73 = EuclidDist.CalculateImpostorScores(s005Mean, s073);
            sv.ImpostorScoresUser5User74 = EuclidDist.CalculateImpostorScores(s005Mean, s074);
            sv.ImpostorScoresUser5User75 = EuclidDist.CalculateImpostorScores(s005Mean, s075);
            sv.ImpostorScoresUser5User76 = EuclidDist.CalculateImpostorScores(s005Mean, s076);
            sv.ImpostorScoresUser5User77 = EuclidDist.CalculateImpostorScores(s005Mean, s077);
            sv.ImpostorScoresUser5User78 = EuclidDist.CalculateImpostorScores(s005Mean, s078);
            sv.ImpostorScoresUser5User79 = EuclidDist.CalculateImpostorScores(s005Mean, s079);
            sv.ImpostorScoresUser5User80 = EuclidDist.CalculateImpostorScores(s005Mean, s080);

            sv.ImpostorScoresUser5User81 = EuclidDist.CalculateImpostorScores(s005Mean, s081);
            sv.ImpostorScoresUser5User82 = EuclidDist.CalculateImpostorScores(s005Mean, s082);
            sv.ImpostorScoresUser5User83 = EuclidDist.CalculateImpostorScores(s005Mean, s083);
            sv.ImpostorScoresUser5User84 = EuclidDist.CalculateImpostorScores(s005Mean, s084);
            sv.ImpostorScoresUser5User85 = EuclidDist.CalculateImpostorScores(s005Mean, s085);
            sv.ImpostorScoresUser5User86 = EuclidDist.CalculateImpostorScores(s005Mean, s086);
            sv.ImpostorScoresUser5User87 = EuclidDist.CalculateImpostorScores(s005Mean, s087);
            sv.ImpostorScoresUser5User88 = EuclidDist.CalculateImpostorScores(s005Mean, s088);
            sv.ImpostorScoresUser5User89 = EuclidDist.CalculateImpostorScores(s005Mean, s089);
            sv.ImpostorScoresUser5User90 = EuclidDist.CalculateImpostorScores(s005Mean, s090);

            sv.ImpostorScoresUser5User91 = EuclidDist.CalculateImpostorScores(s005Mean, s091);
            sv.ImpostorScoresUser5User92 = EuclidDist.CalculateImpostorScores(s005Mean, s092);
            sv.ImpostorScoresUser5User93 = EuclidDist.CalculateImpostorScores(s005Mean, s093);
            sv.ImpostorScoresUser5User94 = EuclidDist.CalculateImpostorScores(s005Mean, s094);
            sv.ImpostorScoresUser5User95 = EuclidDist.CalculateImpostorScores(s005Mean, s095);
            sv.ImpostorScoresUser5User96 = EuclidDist.CalculateImpostorScores(s005Mean, s096);
            sv.ImpostorScoresUser5User97 = EuclidDist.CalculateImpostorScores(s005Mean, s097);
            sv.ImpostorScoresUser5User98 = EuclidDist.CalculateImpostorScores(s005Mean, s098);
            sv.ImpostorScoresUser5User99 = EuclidDist.CalculateImpostorScores(s005Mean, s099);
            sv.ImpostorScoresUser5User100 = EuclidDist.CalculateImpostorScores(s005Mean, s100);
            #endregion

            #region User 6 Impostor scores
            sv.ImpostorScoresUser6User1 = EuclidDist.CalculateImpostorScores(s006Mean, s001);
            sv.ImpostorScoresUser6User2 = EuclidDist.CalculateImpostorScores(s006Mean, s002);
            sv.ImpostorScoresUser6User3 = EuclidDist.CalculateImpostorScores(s006Mean, s003);
            sv.ImpostorScoresUser6User4 = EuclidDist.CalculateImpostorScores(s006Mean, s004);
            sv.ImpostorScoresUser6User5 = EuclidDist.CalculateImpostorScores(s006Mean, s005);
            sv.ImpostorScoresUser6User7 = EuclidDist.CalculateImpostorScores(s006Mean, s007);
            sv.ImpostorScoresUser6User8 = EuclidDist.CalculateImpostorScores(s006Mean, s008);
            sv.ImpostorScoresUser6User9 = EuclidDist.CalculateImpostorScores(s006Mean, s009);
            sv.ImpostorScoresUser6User10 = EuclidDist.CalculateImpostorScores(s006Mean, s010);

            sv.ImpostorScoresUser6User11 = EuclidDist.CalculateImpostorScores(s006Mean, s011);
            sv.ImpostorScoresUser6User12 = EuclidDist.CalculateImpostorScores(s006Mean, s012);
            sv.ImpostorScoresUser6User13 = EuclidDist.CalculateImpostorScores(s006Mean, s013);
            sv.ImpostorScoresUser6User14 = EuclidDist.CalculateImpostorScores(s006Mean, s014);
            sv.ImpostorScoresUser6User15 = EuclidDist.CalculateImpostorScores(s006Mean, s015);
            sv.ImpostorScoresUser6User16 = EuclidDist.CalculateImpostorScores(s006Mean, s016);
            sv.ImpostorScoresUser6User17 = EuclidDist.CalculateImpostorScores(s006Mean, s017);
            sv.ImpostorScoresUser6User18 = EuclidDist.CalculateImpostorScores(s006Mean, s018);
            sv.ImpostorScoresUser6User19 = EuclidDist.CalculateImpostorScores(s006Mean, s019);
            sv.ImpostorScoresUser6User20 = EuclidDist.CalculateImpostorScores(s006Mean, s020);

            sv.ImpostorScoresUser6User21 = EuclidDist.CalculateImpostorScores(s006Mean, s021);
            sv.ImpostorScoresUser6User22 = EuclidDist.CalculateImpostorScores(s006Mean, s022);
            sv.ImpostorScoresUser6User23 = EuclidDist.CalculateImpostorScores(s006Mean, s023);
            sv.ImpostorScoresUser6User24 = EuclidDist.CalculateImpostorScores(s006Mean, s024);
            sv.ImpostorScoresUser6User25 = EuclidDist.CalculateImpostorScores(s006Mean, s025);
            sv.ImpostorScoresUser6User26 = EuclidDist.CalculateImpostorScores(s006Mean, s026);
            sv.ImpostorScoresUser6User27 = EuclidDist.CalculateImpostorScores(s006Mean, s027);
            sv.ImpostorScoresUser6User28 = EuclidDist.CalculateImpostorScores(s006Mean, s028);
            sv.ImpostorScoresUser6User29 = EuclidDist.CalculateImpostorScores(s006Mean, s029);
            sv.ImpostorScoresUser6User30 = EuclidDist.CalculateImpostorScores(s006Mean, s030);

            sv.ImpostorScoresUser6User31 = EuclidDist.CalculateImpostorScores(s006Mean, s031);
            sv.ImpostorScoresUser6User32 = EuclidDist.CalculateImpostorScores(s006Mean, s032);
            sv.ImpostorScoresUser6User33 = EuclidDist.CalculateImpostorScores(s006Mean, s033);
            sv.ImpostorScoresUser6User34 = EuclidDist.CalculateImpostorScores(s006Mean, s034);
            sv.ImpostorScoresUser6User35 = EuclidDist.CalculateImpostorScores(s006Mean, s035);
            sv.ImpostorScoresUser6User36 = EuclidDist.CalculateImpostorScores(s006Mean, s036);
            sv.ImpostorScoresUser6User37 = EuclidDist.CalculateImpostorScores(s006Mean, s037);
            sv.ImpostorScoresUser6User38 = EuclidDist.CalculateImpostorScores(s006Mean, s038);
            sv.ImpostorScoresUser6User39 = EuclidDist.CalculateImpostorScores(s006Mean, s039);
            sv.ImpostorScoresUser6User40 = EuclidDist.CalculateImpostorScores(s006Mean, s040);

            sv.ImpostorScoresUser6User41 = EuclidDist.CalculateImpostorScores(s006Mean, s041);
            sv.ImpostorScoresUser6User42 = EuclidDist.CalculateImpostorScores(s006Mean, s042);
            sv.ImpostorScoresUser6User43 = EuclidDist.CalculateImpostorScores(s006Mean, s043);
            sv.ImpostorScoresUser6User44 = EuclidDist.CalculateImpostorScores(s006Mean, s044);
            sv.ImpostorScoresUser6User45 = EuclidDist.CalculateImpostorScores(s006Mean, s045);
            sv.ImpostorScoresUser6User46 = EuclidDist.CalculateImpostorScores(s006Mean, s046);
            sv.ImpostorScoresUser6User47 = EuclidDist.CalculateImpostorScores(s006Mean, s047);
            sv.ImpostorScoresUser6User48 = EuclidDist.CalculateImpostorScores(s006Mean, s048);
            sv.ImpostorScoresUser6User49 = EuclidDist.CalculateImpostorScores(s006Mean, s049);
            sv.ImpostorScoresUser6User50 = EuclidDist.CalculateImpostorScores(s006Mean, s050);

            sv.ImpostorScoresUser6User51 = EuclidDist.CalculateImpostorScores(s006Mean, s051);
            sv.ImpostorScoresUser6User52 = EuclidDist.CalculateImpostorScores(s006Mean, s052);
            sv.ImpostorScoresUser6User53 = EuclidDist.CalculateImpostorScores(s006Mean, s053);
            sv.ImpostorScoresUser6User54 = EuclidDist.CalculateImpostorScores(s006Mean, s054);
            sv.ImpostorScoresUser6User55 = EuclidDist.CalculateImpostorScores(s006Mean, s055);
            sv.ImpostorScoresUser6User56 = EuclidDist.CalculateImpostorScores(s006Mean, s056);
            sv.ImpostorScoresUser6User57 = EuclidDist.CalculateImpostorScores(s006Mean, s057);
            sv.ImpostorScoresUser6User58 = EuclidDist.CalculateImpostorScores(s006Mean, s058);
            sv.ImpostorScoresUser6User59 = EuclidDist.CalculateImpostorScores(s006Mean, s059);
            sv.ImpostorScoresUser6User60 = EuclidDist.CalculateImpostorScores(s006Mean, s060);

            sv.ImpostorScoresUser6User61 = EuclidDist.CalculateImpostorScores(s006Mean, s061);
            sv.ImpostorScoresUser6User62 = EuclidDist.CalculateImpostorScores(s006Mean, s062);
            sv.ImpostorScoresUser6User63 = EuclidDist.CalculateImpostorScores(s006Mean, s063);
            sv.ImpostorScoresUser6User64 = EuclidDist.CalculateImpostorScores(s006Mean, s064);
            sv.ImpostorScoresUser6User65 = EuclidDist.CalculateImpostorScores(s006Mean, s065);
            sv.ImpostorScoresUser6User66 = EuclidDist.CalculateImpostorScores(s006Mean, s066);
            sv.ImpostorScoresUser6User67 = EuclidDist.CalculateImpostorScores(s006Mean, s067);
            sv.ImpostorScoresUser6User68 = EuclidDist.CalculateImpostorScores(s006Mean, s068);
            sv.ImpostorScoresUser6User69 = EuclidDist.CalculateImpostorScores(s006Mean, s069);
            sv.ImpostorScoresUser6User70 = EuclidDist.CalculateImpostorScores(s006Mean, s070);

            sv.ImpostorScoresUser6User71 = EuclidDist.CalculateImpostorScores(s006Mean, s071);
            sv.ImpostorScoresUser6User72 = EuclidDist.CalculateImpostorScores(s006Mean, s072);
            sv.ImpostorScoresUser6User73 = EuclidDist.CalculateImpostorScores(s006Mean, s073);
            sv.ImpostorScoresUser6User74 = EuclidDist.CalculateImpostorScores(s006Mean, s074);
            sv.ImpostorScoresUser6User75 = EuclidDist.CalculateImpostorScores(s006Mean, s075);
            sv.ImpostorScoresUser6User76 = EuclidDist.CalculateImpostorScores(s006Mean, s076);
            sv.ImpostorScoresUser6User77 = EuclidDist.CalculateImpostorScores(s006Mean, s077);
            sv.ImpostorScoresUser6User78 = EuclidDist.CalculateImpostorScores(s006Mean, s078);
            sv.ImpostorScoresUser6User79 = EuclidDist.CalculateImpostorScores(s006Mean, s079);
            sv.ImpostorScoresUser6User80 = EuclidDist.CalculateImpostorScores(s006Mean, s080);

            sv.ImpostorScoresUser6User81 = EuclidDist.CalculateImpostorScores(s006Mean, s081);
            sv.ImpostorScoresUser6User82 = EuclidDist.CalculateImpostorScores(s006Mean, s082);
            sv.ImpostorScoresUser6User83 = EuclidDist.CalculateImpostorScores(s006Mean, s083);
            sv.ImpostorScoresUser6User84 = EuclidDist.CalculateImpostorScores(s006Mean, s084);
            sv.ImpostorScoresUser6User85 = EuclidDist.CalculateImpostorScores(s006Mean, s085);
            sv.ImpostorScoresUser6User86 = EuclidDist.CalculateImpostorScores(s006Mean, s086);
            sv.ImpostorScoresUser6User87 = EuclidDist.CalculateImpostorScores(s006Mean, s087);
            sv.ImpostorScoresUser6User88 = EuclidDist.CalculateImpostorScores(s006Mean, s088);
            sv.ImpostorScoresUser6User89 = EuclidDist.CalculateImpostorScores(s006Mean, s089);
            sv.ImpostorScoresUser6User90 = EuclidDist.CalculateImpostorScores(s006Mean, s090);

            sv.ImpostorScoresUser6User91 = EuclidDist.CalculateImpostorScores(s006Mean, s091);
            sv.ImpostorScoresUser6User92 = EuclidDist.CalculateImpostorScores(s006Mean, s092);
            sv.ImpostorScoresUser6User93 = EuclidDist.CalculateImpostorScores(s006Mean, s093);
            sv.ImpostorScoresUser6User94 = EuclidDist.CalculateImpostorScores(s006Mean, s094);
            sv.ImpostorScoresUser6User95 = EuclidDist.CalculateImpostorScores(s006Mean, s095);
            sv.ImpostorScoresUser6User96 = EuclidDist.CalculateImpostorScores(s006Mean, s096);
            sv.ImpostorScoresUser6User97 = EuclidDist.CalculateImpostorScores(s006Mean, s097);
            sv.ImpostorScoresUser6User98 = EuclidDist.CalculateImpostorScores(s006Mean, s098);
            sv.ImpostorScoresUser6User99 = EuclidDist.CalculateImpostorScores(s006Mean, s099);
            sv.ImpostorScoresUser6User100 = EuclidDist.CalculateImpostorScores(s006Mean, s100);
            #endregion

            #region User 7 Impostor scores
            sv.ImpostorScoresUser7User1 = EuclidDist.CalculateImpostorScores(s007Mean, s001);
            sv.ImpostorScoresUser7User2 = EuclidDist.CalculateImpostorScores(s007Mean, s002);
            sv.ImpostorScoresUser7User3 = EuclidDist.CalculateImpostorScores(s007Mean, s003);
            sv.ImpostorScoresUser7User4 = EuclidDist.CalculateImpostorScores(s007Mean, s004);
            sv.ImpostorScoresUser7User5 = EuclidDist.CalculateImpostorScores(s007Mean, s005);
            sv.ImpostorScoresUser7User6 = EuclidDist.CalculateImpostorScores(s007Mean, s006);
            sv.ImpostorScoresUser7User8 = EuclidDist.CalculateImpostorScores(s007Mean, s008);
            sv.ImpostorScoresUser7User9 = EuclidDist.CalculateImpostorScores(s007Mean, s009);
            sv.ImpostorScoresUser7User10 = EuclidDist.CalculateImpostorScores(s007Mean, s010);

            sv.ImpostorScoresUser7User11 = EuclidDist.CalculateImpostorScores(s007Mean, s011);
            sv.ImpostorScoresUser7User12 = EuclidDist.CalculateImpostorScores(s007Mean, s012);
            sv.ImpostorScoresUser7User13 = EuclidDist.CalculateImpostorScores(s007Mean, s013);
            sv.ImpostorScoresUser7User14 = EuclidDist.CalculateImpostorScores(s007Mean, s014);
            sv.ImpostorScoresUser7User15 = EuclidDist.CalculateImpostorScores(s007Mean, s015);
            sv.ImpostorScoresUser7User16 = EuclidDist.CalculateImpostorScores(s007Mean, s016);
            sv.ImpostorScoresUser7User17 = EuclidDist.CalculateImpostorScores(s007Mean, s017);
            sv.ImpostorScoresUser7User18 = EuclidDist.CalculateImpostorScores(s007Mean, s018);
            sv.ImpostorScoresUser7User19 = EuclidDist.CalculateImpostorScores(s007Mean, s019);
            sv.ImpostorScoresUser7User20 = EuclidDist.CalculateImpostorScores(s007Mean, s020);

            sv.ImpostorScoresUser7User21 = EuclidDist.CalculateImpostorScores(s007Mean, s021);
            sv.ImpostorScoresUser7User22 = EuclidDist.CalculateImpostorScores(s007Mean, s022);
            sv.ImpostorScoresUser7User23 = EuclidDist.CalculateImpostorScores(s007Mean, s023);
            sv.ImpostorScoresUser7User24 = EuclidDist.CalculateImpostorScores(s007Mean, s024);
            sv.ImpostorScoresUser7User25 = EuclidDist.CalculateImpostorScores(s007Mean, s025);
            sv.ImpostorScoresUser7User26 = EuclidDist.CalculateImpostorScores(s007Mean, s026);
            sv.ImpostorScoresUser7User27 = EuclidDist.CalculateImpostorScores(s007Mean, s027);
            sv.ImpostorScoresUser7User28 = EuclidDist.CalculateImpostorScores(s007Mean, s028);
            sv.ImpostorScoresUser7User29 = EuclidDist.CalculateImpostorScores(s007Mean, s029);
            sv.ImpostorScoresUser7User30 = EuclidDist.CalculateImpostorScores(s007Mean, s030);

            sv.ImpostorScoresUser7User31 = EuclidDist.CalculateImpostorScores(s007Mean, s031);
            sv.ImpostorScoresUser7User32 = EuclidDist.CalculateImpostorScores(s007Mean, s032);
            sv.ImpostorScoresUser7User33 = EuclidDist.CalculateImpostorScores(s007Mean, s033);
            sv.ImpostorScoresUser7User34 = EuclidDist.CalculateImpostorScores(s007Mean, s034);
            sv.ImpostorScoresUser7User35 = EuclidDist.CalculateImpostorScores(s007Mean, s035);
            sv.ImpostorScoresUser7User36 = EuclidDist.CalculateImpostorScores(s007Mean, s036);
            sv.ImpostorScoresUser7User37 = EuclidDist.CalculateImpostorScores(s007Mean, s037);
            sv.ImpostorScoresUser7User38 = EuclidDist.CalculateImpostorScores(s007Mean, s038);
            sv.ImpostorScoresUser7User39 = EuclidDist.CalculateImpostorScores(s007Mean, s039);
            sv.ImpostorScoresUser7User40 = EuclidDist.CalculateImpostorScores(s007Mean, s040);

            sv.ImpostorScoresUser7User41 = EuclidDist.CalculateImpostorScores(s007Mean, s041);
            sv.ImpostorScoresUser7User42 = EuclidDist.CalculateImpostorScores(s007Mean, s042);
            sv.ImpostorScoresUser7User43 = EuclidDist.CalculateImpostorScores(s007Mean, s043);
            sv.ImpostorScoresUser7User44 = EuclidDist.CalculateImpostorScores(s007Mean, s044);
            sv.ImpostorScoresUser7User45 = EuclidDist.CalculateImpostorScores(s007Mean, s045);
            sv.ImpostorScoresUser7User46 = EuclidDist.CalculateImpostorScores(s007Mean, s046);
            sv.ImpostorScoresUser7User47 = EuclidDist.CalculateImpostorScores(s007Mean, s047);
            sv.ImpostorScoresUser7User48 = EuclidDist.CalculateImpostorScores(s007Mean, s048);
            sv.ImpostorScoresUser7User49 = EuclidDist.CalculateImpostorScores(s007Mean, s049);
            sv.ImpostorScoresUser7User50 = EuclidDist.CalculateImpostorScores(s007Mean, s050);

            sv.ImpostorScoresUser7User51 = EuclidDist.CalculateImpostorScores(s007Mean, s051);
            sv.ImpostorScoresUser7User52 = EuclidDist.CalculateImpostorScores(s007Mean, s052);
            sv.ImpostorScoresUser7User53 = EuclidDist.CalculateImpostorScores(s007Mean, s053);
            sv.ImpostorScoresUser7User54 = EuclidDist.CalculateImpostorScores(s007Mean, s054);
            sv.ImpostorScoresUser7User55 = EuclidDist.CalculateImpostorScores(s007Mean, s055);
            sv.ImpostorScoresUser7User56 = EuclidDist.CalculateImpostorScores(s007Mean, s056);
            sv.ImpostorScoresUser7User57 = EuclidDist.CalculateImpostorScores(s007Mean, s057);
            sv.ImpostorScoresUser7User58 = EuclidDist.CalculateImpostorScores(s007Mean, s058);
            sv.ImpostorScoresUser7User59 = EuclidDist.CalculateImpostorScores(s007Mean, s059);
            sv.ImpostorScoresUser7User60 = EuclidDist.CalculateImpostorScores(s007Mean, s060);

            sv.ImpostorScoresUser7User61 = EuclidDist.CalculateImpostorScores(s007Mean, s061);
            sv.ImpostorScoresUser7User62 = EuclidDist.CalculateImpostorScores(s007Mean, s062);
            sv.ImpostorScoresUser7User63 = EuclidDist.CalculateImpostorScores(s007Mean, s063);
            sv.ImpostorScoresUser7User64 = EuclidDist.CalculateImpostorScores(s007Mean, s064);
            sv.ImpostorScoresUser7User65 = EuclidDist.CalculateImpostorScores(s007Mean, s065);
            sv.ImpostorScoresUser7User66 = EuclidDist.CalculateImpostorScores(s007Mean, s066);
            sv.ImpostorScoresUser7User67 = EuclidDist.CalculateImpostorScores(s007Mean, s067);
            sv.ImpostorScoresUser7User68 = EuclidDist.CalculateImpostorScores(s007Mean, s068);
            sv.ImpostorScoresUser7User69 = EuclidDist.CalculateImpostorScores(s007Mean, s069);
            sv.ImpostorScoresUser7User70 = EuclidDist.CalculateImpostorScores(s007Mean, s070);

            sv.ImpostorScoresUser7User71 = EuclidDist.CalculateImpostorScores(s007Mean, s071);
            sv.ImpostorScoresUser7User72 = EuclidDist.CalculateImpostorScores(s007Mean, s072);
            sv.ImpostorScoresUser7User73 = EuclidDist.CalculateImpostorScores(s007Mean, s073);
            sv.ImpostorScoresUser7User74 = EuclidDist.CalculateImpostorScores(s007Mean, s074);
            sv.ImpostorScoresUser7User75 = EuclidDist.CalculateImpostorScores(s007Mean, s075);
            sv.ImpostorScoresUser7User76 = EuclidDist.CalculateImpostorScores(s007Mean, s076);
            sv.ImpostorScoresUser7User77 = EuclidDist.CalculateImpostorScores(s007Mean, s077);
            sv.ImpostorScoresUser7User78 = EuclidDist.CalculateImpostorScores(s007Mean, s078);
            sv.ImpostorScoresUser7User79 = EuclidDist.CalculateImpostorScores(s007Mean, s079);
            sv.ImpostorScoresUser7User80 = EuclidDist.CalculateImpostorScores(s007Mean, s080);

            sv.ImpostorScoresUser7User81 = EuclidDist.CalculateImpostorScores(s007Mean, s081);
            sv.ImpostorScoresUser7User82 = EuclidDist.CalculateImpostorScores(s007Mean, s082);
            sv.ImpostorScoresUser7User83 = EuclidDist.CalculateImpostorScores(s007Mean, s083);
            sv.ImpostorScoresUser7User84 = EuclidDist.CalculateImpostorScores(s007Mean, s084);
            sv.ImpostorScoresUser7User85 = EuclidDist.CalculateImpostorScores(s007Mean, s085);
            sv.ImpostorScoresUser7User86 = EuclidDist.CalculateImpostorScores(s007Mean, s086);
            sv.ImpostorScoresUser7User87 = EuclidDist.CalculateImpostorScores(s007Mean, s087);
            sv.ImpostorScoresUser7User88 = EuclidDist.CalculateImpostorScores(s007Mean, s088);
            sv.ImpostorScoresUser7User89 = EuclidDist.CalculateImpostorScores(s007Mean, s089);
            sv.ImpostorScoresUser7User90 = EuclidDist.CalculateImpostorScores(s007Mean, s090);

            sv.ImpostorScoresUser7User91 = EuclidDist.CalculateImpostorScores(s007Mean, s091);
            sv.ImpostorScoresUser7User92 = EuclidDist.CalculateImpostorScores(s007Mean, s092);
            sv.ImpostorScoresUser7User93 = EuclidDist.CalculateImpostorScores(s007Mean, s093);
            sv.ImpostorScoresUser7User94 = EuclidDist.CalculateImpostorScores(s007Mean, s094);
            sv.ImpostorScoresUser7User95 = EuclidDist.CalculateImpostorScores(s007Mean, s095);
            sv.ImpostorScoresUser7User96 = EuclidDist.CalculateImpostorScores(s007Mean, s096);
            sv.ImpostorScoresUser7User97 = EuclidDist.CalculateImpostorScores(s007Mean, s097);
            sv.ImpostorScoresUser7User98 = EuclidDist.CalculateImpostorScores(s007Mean, s098);
            sv.ImpostorScoresUser7User99 = EuclidDist.CalculateImpostorScores(s007Mean, s099);
            sv.ImpostorScoresUser7User100 = EuclidDist.CalculateImpostorScores(s007Mean, s100);
            #endregion

            #region User 8 Impostor scores
            sv.ImpostorScoresUser8User1 = EuclidDist.CalculateImpostorScores(s008Mean, s001);
            sv.ImpostorScoresUser8User2 = EuclidDist.CalculateImpostorScores(s008Mean, s002);
            sv.ImpostorScoresUser8User3 = EuclidDist.CalculateImpostorScores(s008Mean, s003);
            sv.ImpostorScoresUser8User4 = EuclidDist.CalculateImpostorScores(s008Mean, s004);
            sv.ImpostorScoresUser8User5 = EuclidDist.CalculateImpostorScores(s008Mean, s005);
            sv.ImpostorScoresUser8User6 = EuclidDist.CalculateImpostorScores(s008Mean, s006);
            sv.ImpostorScoresUser8User7 = EuclidDist.CalculateImpostorScores(s008Mean, s008);
            sv.ImpostorScoresUser8User9 = EuclidDist.CalculateImpostorScores(s008Mean, s009);
            sv.ImpostorScoresUser8User10 = EuclidDist.CalculateImpostorScores(s008Mean, s010);

            sv.ImpostorScoresUser8User11 = EuclidDist.CalculateImpostorScores(s008Mean, s011);
            sv.ImpostorScoresUser8User12 = EuclidDist.CalculateImpostorScores(s008Mean, s012);
            sv.ImpostorScoresUser8User13 = EuclidDist.CalculateImpostorScores(s008Mean, s013);
            sv.ImpostorScoresUser8User14 = EuclidDist.CalculateImpostorScores(s008Mean, s014);
            sv.ImpostorScoresUser8User15 = EuclidDist.CalculateImpostorScores(s008Mean, s015);
            sv.ImpostorScoresUser8User16 = EuclidDist.CalculateImpostorScores(s008Mean, s016);
            sv.ImpostorScoresUser8User17 = EuclidDist.CalculateImpostorScores(s008Mean, s017);
            sv.ImpostorScoresUser8User18 = EuclidDist.CalculateImpostorScores(s008Mean, s018);
            sv.ImpostorScoresUser8User19 = EuclidDist.CalculateImpostorScores(s008Mean, s019);
            sv.ImpostorScoresUser8User20 = EuclidDist.CalculateImpostorScores(s008Mean, s020);

            sv.ImpostorScoresUser8User21 = EuclidDist.CalculateImpostorScores(s008Mean, s021);
            sv.ImpostorScoresUser8User22 = EuclidDist.CalculateImpostorScores(s008Mean, s022);
            sv.ImpostorScoresUser8User23 = EuclidDist.CalculateImpostorScores(s008Mean, s023);
            sv.ImpostorScoresUser8User24 = EuclidDist.CalculateImpostorScores(s008Mean, s024);
            sv.ImpostorScoresUser8User25 = EuclidDist.CalculateImpostorScores(s008Mean, s025);
            sv.ImpostorScoresUser8User26 = EuclidDist.CalculateImpostorScores(s008Mean, s026);
            sv.ImpostorScoresUser8User27 = EuclidDist.CalculateImpostorScores(s008Mean, s027);
            sv.ImpostorScoresUser8User28 = EuclidDist.CalculateImpostorScores(s008Mean, s028);
            sv.ImpostorScoresUser8User29 = EuclidDist.CalculateImpostorScores(s008Mean, s029);
            sv.ImpostorScoresUser8User30 = EuclidDist.CalculateImpostorScores(s008Mean, s030);

            sv.ImpostorScoresUser8User31 = EuclidDist.CalculateImpostorScores(s008Mean, s031);
            sv.ImpostorScoresUser8User32 = EuclidDist.CalculateImpostorScores(s008Mean, s032);
            sv.ImpostorScoresUser8User33 = EuclidDist.CalculateImpostorScores(s008Mean, s033);
            sv.ImpostorScoresUser8User34 = EuclidDist.CalculateImpostorScores(s008Mean, s034);
            sv.ImpostorScoresUser8User35 = EuclidDist.CalculateImpostorScores(s008Mean, s035);
            sv.ImpostorScoresUser8User36 = EuclidDist.CalculateImpostorScores(s008Mean, s036);
            sv.ImpostorScoresUser8User37 = EuclidDist.CalculateImpostorScores(s008Mean, s037);
            sv.ImpostorScoresUser8User38 = EuclidDist.CalculateImpostorScores(s008Mean, s038);
            sv.ImpostorScoresUser8User39 = EuclidDist.CalculateImpostorScores(s008Mean, s039);
            sv.ImpostorScoresUser8User40 = EuclidDist.CalculateImpostorScores(s008Mean, s040);

            sv.ImpostorScoresUser8User41 = EuclidDist.CalculateImpostorScores(s008Mean, s041);
            sv.ImpostorScoresUser8User42 = EuclidDist.CalculateImpostorScores(s008Mean, s042);
            sv.ImpostorScoresUser8User43 = EuclidDist.CalculateImpostorScores(s008Mean, s043);
            sv.ImpostorScoresUser8User44 = EuclidDist.CalculateImpostorScores(s008Mean, s044);
            sv.ImpostorScoresUser8User45 = EuclidDist.CalculateImpostorScores(s008Mean, s045);
            sv.ImpostorScoresUser8User46 = EuclidDist.CalculateImpostorScores(s008Mean, s046);
            sv.ImpostorScoresUser8User47 = EuclidDist.CalculateImpostorScores(s008Mean, s047);
            sv.ImpostorScoresUser8User48 = EuclidDist.CalculateImpostorScores(s008Mean, s048);
            sv.ImpostorScoresUser8User49 = EuclidDist.CalculateImpostorScores(s008Mean, s049);
            sv.ImpostorScoresUser8User50 = EuclidDist.CalculateImpostorScores(s008Mean, s050);

            sv.ImpostorScoresUser8User51 = EuclidDist.CalculateImpostorScores(s008Mean, s051);
            sv.ImpostorScoresUser8User52 = EuclidDist.CalculateImpostorScores(s008Mean, s052);
            sv.ImpostorScoresUser8User53 = EuclidDist.CalculateImpostorScores(s008Mean, s053);
            sv.ImpostorScoresUser8User54 = EuclidDist.CalculateImpostorScores(s008Mean, s054);
            sv.ImpostorScoresUser8User55 = EuclidDist.CalculateImpostorScores(s008Mean, s055);
            sv.ImpostorScoresUser8User56 = EuclidDist.CalculateImpostorScores(s008Mean, s056);
            sv.ImpostorScoresUser8User57 = EuclidDist.CalculateImpostorScores(s008Mean, s057);
            sv.ImpostorScoresUser8User58 = EuclidDist.CalculateImpostorScores(s008Mean, s058);
            sv.ImpostorScoresUser8User59 = EuclidDist.CalculateImpostorScores(s008Mean, s059);
            sv.ImpostorScoresUser8User60 = EuclidDist.CalculateImpostorScores(s008Mean, s060);

            sv.ImpostorScoresUser8User61 = EuclidDist.CalculateImpostorScores(s008Mean, s061);
            sv.ImpostorScoresUser8User62 = EuclidDist.CalculateImpostorScores(s008Mean, s062);
            sv.ImpostorScoresUser8User63 = EuclidDist.CalculateImpostorScores(s008Mean, s063);
            sv.ImpostorScoresUser8User64 = EuclidDist.CalculateImpostorScores(s008Mean, s064);
            sv.ImpostorScoresUser8User65 = EuclidDist.CalculateImpostorScores(s008Mean, s065);
            sv.ImpostorScoresUser8User66 = EuclidDist.CalculateImpostorScores(s008Mean, s066);
            sv.ImpostorScoresUser8User67 = EuclidDist.CalculateImpostorScores(s008Mean, s067);
            sv.ImpostorScoresUser8User68 = EuclidDist.CalculateImpostorScores(s008Mean, s068);
            sv.ImpostorScoresUser8User69 = EuclidDist.CalculateImpostorScores(s008Mean, s069);
            sv.ImpostorScoresUser8User70 = EuclidDist.CalculateImpostorScores(s008Mean, s070);

            sv.ImpostorScoresUser8User71 = EuclidDist.CalculateImpostorScores(s008Mean, s071);
            sv.ImpostorScoresUser8User72 = EuclidDist.CalculateImpostorScores(s008Mean, s072);
            sv.ImpostorScoresUser8User73 = EuclidDist.CalculateImpostorScores(s008Mean, s073);
            sv.ImpostorScoresUser8User74 = EuclidDist.CalculateImpostorScores(s008Mean, s074);
            sv.ImpostorScoresUser8User75 = EuclidDist.CalculateImpostorScores(s008Mean, s075);
            sv.ImpostorScoresUser8User76 = EuclidDist.CalculateImpostorScores(s008Mean, s076);
            sv.ImpostorScoresUser8User77 = EuclidDist.CalculateImpostorScores(s008Mean, s077);
            sv.ImpostorScoresUser8User78 = EuclidDist.CalculateImpostorScores(s008Mean, s078);
            sv.ImpostorScoresUser8User79 = EuclidDist.CalculateImpostorScores(s008Mean, s079);
            sv.ImpostorScoresUser8User80 = EuclidDist.CalculateImpostorScores(s008Mean, s080);

            sv.ImpostorScoresUser8User81 = EuclidDist.CalculateImpostorScores(s008Mean, s081);
            sv.ImpostorScoresUser8User82 = EuclidDist.CalculateImpostorScores(s008Mean, s082);
            sv.ImpostorScoresUser8User83 = EuclidDist.CalculateImpostorScores(s008Mean, s083);
            sv.ImpostorScoresUser8User84 = EuclidDist.CalculateImpostorScores(s008Mean, s084);
            sv.ImpostorScoresUser8User85 = EuclidDist.CalculateImpostorScores(s008Mean, s085);
            sv.ImpostorScoresUser8User86 = EuclidDist.CalculateImpostorScores(s008Mean, s086);
            sv.ImpostorScoresUser8User87 = EuclidDist.CalculateImpostorScores(s008Mean, s087);
            sv.ImpostorScoresUser8User88 = EuclidDist.CalculateImpostorScores(s008Mean, s088);
            sv.ImpostorScoresUser8User89 = EuclidDist.CalculateImpostorScores(s008Mean, s089);
            sv.ImpostorScoresUser8User90 = EuclidDist.CalculateImpostorScores(s008Mean, s090);

            sv.ImpostorScoresUser8User91 = EuclidDist.CalculateImpostorScores(s008Mean, s091);
            sv.ImpostorScoresUser8User92 = EuclidDist.CalculateImpostorScores(s008Mean, s092);
            sv.ImpostorScoresUser8User93 = EuclidDist.CalculateImpostorScores(s008Mean, s093);
            sv.ImpostorScoresUser8User94 = EuclidDist.CalculateImpostorScores(s008Mean, s094);
            sv.ImpostorScoresUser8User95 = EuclidDist.CalculateImpostorScores(s008Mean, s095);
            sv.ImpostorScoresUser8User96 = EuclidDist.CalculateImpostorScores(s008Mean, s096);
            sv.ImpostorScoresUser8User97 = EuclidDist.CalculateImpostorScores(s008Mean, s097);
            sv.ImpostorScoresUser8User98 = EuclidDist.CalculateImpostorScores(s008Mean, s098);
            sv.ImpostorScoresUser8User99 = EuclidDist.CalculateImpostorScores(s008Mean, s099);
            sv.ImpostorScoresUser8User100 = EuclidDist.CalculateImpostorScores(s008Mean, s100);
            #endregion

            #region User 9 Impostor scores
            sv.ImpostorScoresUser9User1 = EuclidDist.CalculateImpostorScores(s009Mean, s001);
            sv.ImpostorScoresUser9User2 = EuclidDist.CalculateImpostorScores(s009Mean, s002);
            sv.ImpostorScoresUser9User3 = EuclidDist.CalculateImpostorScores(s009Mean, s003);
            sv.ImpostorScoresUser9User4 = EuclidDist.CalculateImpostorScores(s009Mean, s004);
            sv.ImpostorScoresUser9User5 = EuclidDist.CalculateImpostorScores(s009Mean, s005);
            sv.ImpostorScoresUser9User6 = EuclidDist.CalculateImpostorScores(s009Mean, s006);
            sv.ImpostorScoresUser9User7 = EuclidDist.CalculateImpostorScores(s009Mean, s007);
            sv.ImpostorScoresUser9User8 = EuclidDist.CalculateImpostorScores(s009Mean, s008);
            sv.ImpostorScoresUser9User10 = EuclidDist.CalculateImpostorScores(s009Mean, s010);

            sv.ImpostorScoresUser9User11 = EuclidDist.CalculateImpostorScores(s009Mean, s011);
            sv.ImpostorScoresUser9User12 = EuclidDist.CalculateImpostorScores(s009Mean, s012);
            sv.ImpostorScoresUser9User13 = EuclidDist.CalculateImpostorScores(s009Mean, s013);
            sv.ImpostorScoresUser9User14 = EuclidDist.CalculateImpostorScores(s009Mean, s014);
            sv.ImpostorScoresUser9User15 = EuclidDist.CalculateImpostorScores(s009Mean, s015);
            sv.ImpostorScoresUser9User16 = EuclidDist.CalculateImpostorScores(s009Mean, s016);
            sv.ImpostorScoresUser9User17 = EuclidDist.CalculateImpostorScores(s009Mean, s017);
            sv.ImpostorScoresUser9User18 = EuclidDist.CalculateImpostorScores(s009Mean, s018);
            sv.ImpostorScoresUser9User19 = EuclidDist.CalculateImpostorScores(s009Mean, s019);
            sv.ImpostorScoresUser9User20 = EuclidDist.CalculateImpostorScores(s009Mean, s020);

            sv.ImpostorScoresUser9User21 = EuclidDist.CalculateImpostorScores(s009Mean, s021);
            sv.ImpostorScoresUser9User22 = EuclidDist.CalculateImpostorScores(s009Mean, s022);
            sv.ImpostorScoresUser9User23 = EuclidDist.CalculateImpostorScores(s009Mean, s023);
            sv.ImpostorScoresUser9User24 = EuclidDist.CalculateImpostorScores(s009Mean, s024);
            sv.ImpostorScoresUser9User25 = EuclidDist.CalculateImpostorScores(s009Mean, s025);
            sv.ImpostorScoresUser9User26 = EuclidDist.CalculateImpostorScores(s009Mean, s026);
            sv.ImpostorScoresUser9User27 = EuclidDist.CalculateImpostorScores(s009Mean, s027);
            sv.ImpostorScoresUser9User28 = EuclidDist.CalculateImpostorScores(s009Mean, s028);
            sv.ImpostorScoresUser9User29 = EuclidDist.CalculateImpostorScores(s009Mean, s029);
            sv.ImpostorScoresUser9User30 = EuclidDist.CalculateImpostorScores(s009Mean, s030);

            sv.ImpostorScoresUser9User31 = EuclidDist.CalculateImpostorScores(s009Mean, s031);
            sv.ImpostorScoresUser9User32 = EuclidDist.CalculateImpostorScores(s009Mean, s032);
            sv.ImpostorScoresUser9User33 = EuclidDist.CalculateImpostorScores(s009Mean, s033);
            sv.ImpostorScoresUser9User34 = EuclidDist.CalculateImpostorScores(s009Mean, s034);
            sv.ImpostorScoresUser9User35 = EuclidDist.CalculateImpostorScores(s009Mean, s035);
            sv.ImpostorScoresUser9User36 = EuclidDist.CalculateImpostorScores(s009Mean, s036);
            sv.ImpostorScoresUser9User37 = EuclidDist.CalculateImpostorScores(s009Mean, s037);
            sv.ImpostorScoresUser9User38 = EuclidDist.CalculateImpostorScores(s009Mean, s038);
            sv.ImpostorScoresUser9User39 = EuclidDist.CalculateImpostorScores(s009Mean, s039);
            sv.ImpostorScoresUser9User40 = EuclidDist.CalculateImpostorScores(s009Mean, s040);

            sv.ImpostorScoresUser9User41 = EuclidDist.CalculateImpostorScores(s009Mean, s041);
            sv.ImpostorScoresUser9User42 = EuclidDist.CalculateImpostorScores(s009Mean, s042);
            sv.ImpostorScoresUser9User43 = EuclidDist.CalculateImpostorScores(s009Mean, s043);
            sv.ImpostorScoresUser9User44 = EuclidDist.CalculateImpostorScores(s009Mean, s044);
            sv.ImpostorScoresUser9User45 = EuclidDist.CalculateImpostorScores(s009Mean, s045);
            sv.ImpostorScoresUser9User46 = EuclidDist.CalculateImpostorScores(s009Mean, s046);
            sv.ImpostorScoresUser9User47 = EuclidDist.CalculateImpostorScores(s009Mean, s047);
            sv.ImpostorScoresUser9User48 = EuclidDist.CalculateImpostorScores(s009Mean, s048);
            sv.ImpostorScoresUser9User49 = EuclidDist.CalculateImpostorScores(s009Mean, s049);
            sv.ImpostorScoresUser9User50 = EuclidDist.CalculateImpostorScores(s009Mean, s050);

            sv.ImpostorScoresUser9User51 = EuclidDist.CalculateImpostorScores(s009Mean, s051);
            sv.ImpostorScoresUser9User52 = EuclidDist.CalculateImpostorScores(s009Mean, s052);
            sv.ImpostorScoresUser9User53 = EuclidDist.CalculateImpostorScores(s009Mean, s053);
            sv.ImpostorScoresUser9User54 = EuclidDist.CalculateImpostorScores(s009Mean, s054);
            sv.ImpostorScoresUser9User55 = EuclidDist.CalculateImpostorScores(s009Mean, s055);
            sv.ImpostorScoresUser9User56 = EuclidDist.CalculateImpostorScores(s009Mean, s056);
            sv.ImpostorScoresUser9User57 = EuclidDist.CalculateImpostorScores(s009Mean, s057);
            sv.ImpostorScoresUser9User58 = EuclidDist.CalculateImpostorScores(s009Mean, s058);
            sv.ImpostorScoresUser9User59 = EuclidDist.CalculateImpostorScores(s009Mean, s059);
            sv.ImpostorScoresUser9User60 = EuclidDist.CalculateImpostorScores(s009Mean, s060);

            sv.ImpostorScoresUser9User61 = EuclidDist.CalculateImpostorScores(s009Mean, s061);
            sv.ImpostorScoresUser9User62 = EuclidDist.CalculateImpostorScores(s009Mean, s062);
            sv.ImpostorScoresUser9User63 = EuclidDist.CalculateImpostorScores(s009Mean, s063);
            sv.ImpostorScoresUser9User64 = EuclidDist.CalculateImpostorScores(s009Mean, s064);
            sv.ImpostorScoresUser9User65 = EuclidDist.CalculateImpostorScores(s009Mean, s065);
            sv.ImpostorScoresUser9User66 = EuclidDist.CalculateImpostorScores(s009Mean, s066);
            sv.ImpostorScoresUser9User67 = EuclidDist.CalculateImpostorScores(s009Mean, s067);
            sv.ImpostorScoresUser9User68 = EuclidDist.CalculateImpostorScores(s009Mean, s068);
            sv.ImpostorScoresUser9User69 = EuclidDist.CalculateImpostorScores(s009Mean, s069);
            sv.ImpostorScoresUser9User70 = EuclidDist.CalculateImpostorScores(s009Mean, s070);

            sv.ImpostorScoresUser9User71 = EuclidDist.CalculateImpostorScores(s009Mean, s071);
            sv.ImpostorScoresUser9User72 = EuclidDist.CalculateImpostorScores(s009Mean, s072);
            sv.ImpostorScoresUser9User73 = EuclidDist.CalculateImpostorScores(s009Mean, s073);
            sv.ImpostorScoresUser9User74 = EuclidDist.CalculateImpostorScores(s009Mean, s074);
            sv.ImpostorScoresUser9User75 = EuclidDist.CalculateImpostorScores(s009Mean, s075);
            sv.ImpostorScoresUser9User76 = EuclidDist.CalculateImpostorScores(s009Mean, s076);
            sv.ImpostorScoresUser9User77 = EuclidDist.CalculateImpostorScores(s009Mean, s077);
            sv.ImpostorScoresUser9User78 = EuclidDist.CalculateImpostorScores(s009Mean, s078);
            sv.ImpostorScoresUser9User79 = EuclidDist.CalculateImpostorScores(s009Mean, s079);
            sv.ImpostorScoresUser9User80 = EuclidDist.CalculateImpostorScores(s009Mean, s080);

            sv.ImpostorScoresUser9User81 = EuclidDist.CalculateImpostorScores(s009Mean, s081);
            sv.ImpostorScoresUser9User82 = EuclidDist.CalculateImpostorScores(s009Mean, s082);
            sv.ImpostorScoresUser9User83 = EuclidDist.CalculateImpostorScores(s009Mean, s083);
            sv.ImpostorScoresUser9User84 = EuclidDist.CalculateImpostorScores(s009Mean, s084);
            sv.ImpostorScoresUser9User85 = EuclidDist.CalculateImpostorScores(s009Mean, s085);
            sv.ImpostorScoresUser9User86 = EuclidDist.CalculateImpostorScores(s009Mean, s086);
            sv.ImpostorScoresUser9User87 = EuclidDist.CalculateImpostorScores(s009Mean, s087);
            sv.ImpostorScoresUser9User88 = EuclidDist.CalculateImpostorScores(s009Mean, s088);
            sv.ImpostorScoresUser9User89 = EuclidDist.CalculateImpostorScores(s009Mean, s089);
            sv.ImpostorScoresUser9User90 = EuclidDist.CalculateImpostorScores(s009Mean, s090);

            sv.ImpostorScoresUser9User91 = EuclidDist.CalculateImpostorScores(s009Mean, s091);
            sv.ImpostorScoresUser9User92 = EuclidDist.CalculateImpostorScores(s009Mean, s092);
            sv.ImpostorScoresUser9User93 = EuclidDist.CalculateImpostorScores(s009Mean, s093);
            sv.ImpostorScoresUser9User94 = EuclidDist.CalculateImpostorScores(s009Mean, s094);
            sv.ImpostorScoresUser9User95 = EuclidDist.CalculateImpostorScores(s009Mean, s095);
            sv.ImpostorScoresUser9User96 = EuclidDist.CalculateImpostorScores(s009Mean, s096);
            sv.ImpostorScoresUser9User97 = EuclidDist.CalculateImpostorScores(s009Mean, s097);
            sv.ImpostorScoresUser9User98 = EuclidDist.CalculateImpostorScores(s009Mean, s098);
            sv.ImpostorScoresUser9User99 = EuclidDist.CalculateImpostorScores(s009Mean, s099);
            sv.ImpostorScoresUser9User100 = EuclidDist.CalculateImpostorScores(s009Mean, s100);
            #endregion

            #region User 10 Impostor scores
            sv.ImpostorScoresUser10User1 = EuclidDist.CalculateImpostorScores(s010Mean, s001);
            sv.ImpostorScoresUser10User2 = EuclidDist.CalculateImpostorScores(s010Mean, s002);
            sv.ImpostorScoresUser10User3 = EuclidDist.CalculateImpostorScores(s010Mean, s003);
            sv.ImpostorScoresUser10User4 = EuclidDist.CalculateImpostorScores(s010Mean, s004);
            sv.ImpostorScoresUser10User5 = EuclidDist.CalculateImpostorScores(s010Mean, s005);
            sv.ImpostorScoresUser10User6 = EuclidDist.CalculateImpostorScores(s010Mean, s006);
            sv.ImpostorScoresUser10User7 = EuclidDist.CalculateImpostorScores(s010Mean, s007);
            sv.ImpostorScoresUser10User8 = EuclidDist.CalculateImpostorScores(s010Mean, s008);
            sv.ImpostorScoresUser10User9 = EuclidDist.CalculateImpostorScores(s010Mean, s009);

            sv.ImpostorScoresUser10User11 = EuclidDist.CalculateImpostorScores(s010Mean, s011);
            sv.ImpostorScoresUser10User12 = EuclidDist.CalculateImpostorScores(s010Mean, s012);
            sv.ImpostorScoresUser10User13 = EuclidDist.CalculateImpostorScores(s010Mean, s013);
            sv.ImpostorScoresUser10User14 = EuclidDist.CalculateImpostorScores(s010Mean, s014);
            sv.ImpostorScoresUser10User15 = EuclidDist.CalculateImpostorScores(s010Mean, s015);
            sv.ImpostorScoresUser10User16 = EuclidDist.CalculateImpostorScores(s010Mean, s016);
            sv.ImpostorScoresUser10User17 = EuclidDist.CalculateImpostorScores(s010Mean, s017);
            sv.ImpostorScoresUser10User18 = EuclidDist.CalculateImpostorScores(s010Mean, s018);
            sv.ImpostorScoresUser10User19 = EuclidDist.CalculateImpostorScores(s010Mean, s019);
            sv.ImpostorScoresUser10User20 = EuclidDist.CalculateImpostorScores(s010Mean, s020);

            sv.ImpostorScoresUser10User21 = EuclidDist.CalculateImpostorScores(s010Mean, s021);
            sv.ImpostorScoresUser10User22 = EuclidDist.CalculateImpostorScores(s010Mean, s022);
            sv.ImpostorScoresUser10User23 = EuclidDist.CalculateImpostorScores(s010Mean, s023);
            sv.ImpostorScoresUser10User24 = EuclidDist.CalculateImpostorScores(s010Mean, s024);
            sv.ImpostorScoresUser10User25 = EuclidDist.CalculateImpostorScores(s010Mean, s025);
            sv.ImpostorScoresUser10User26 = EuclidDist.CalculateImpostorScores(s010Mean, s026);
            sv.ImpostorScoresUser10User27 = EuclidDist.CalculateImpostorScores(s010Mean, s027);
            sv.ImpostorScoresUser10User28 = EuclidDist.CalculateImpostorScores(s010Mean, s028);
            sv.ImpostorScoresUser10User29 = EuclidDist.CalculateImpostorScores(s010Mean, s029);
            sv.ImpostorScoresUser10User30 = EuclidDist.CalculateImpostorScores(s010Mean, s030);

            sv.ImpostorScoresUser10User31 = EuclidDist.CalculateImpostorScores(s010Mean, s031);
            sv.ImpostorScoresUser10User32 = EuclidDist.CalculateImpostorScores(s010Mean, s032);
            sv.ImpostorScoresUser10User33 = EuclidDist.CalculateImpostorScores(s010Mean, s033);
            sv.ImpostorScoresUser10User34 = EuclidDist.CalculateImpostorScores(s010Mean, s034);
            sv.ImpostorScoresUser10User35 = EuclidDist.CalculateImpostorScores(s010Mean, s035);
            sv.ImpostorScoresUser10User36 = EuclidDist.CalculateImpostorScores(s010Mean, s036);
            sv.ImpostorScoresUser10User37 = EuclidDist.CalculateImpostorScores(s010Mean, s037);
            sv.ImpostorScoresUser10User38 = EuclidDist.CalculateImpostorScores(s010Mean, s038);
            sv.ImpostorScoresUser10User39 = EuclidDist.CalculateImpostorScores(s010Mean, s039);
            sv.ImpostorScoresUser10User40 = EuclidDist.CalculateImpostorScores(s010Mean, s040);

            sv.ImpostorScoresUser10User41 = EuclidDist.CalculateImpostorScores(s010Mean, s041);
            sv.ImpostorScoresUser10User42 = EuclidDist.CalculateImpostorScores(s010Mean, s042);
            sv.ImpostorScoresUser10User43 = EuclidDist.CalculateImpostorScores(s010Mean, s043);
            sv.ImpostorScoresUser10User44 = EuclidDist.CalculateImpostorScores(s010Mean, s044);
            sv.ImpostorScoresUser10User45 = EuclidDist.CalculateImpostorScores(s010Mean, s045);
            sv.ImpostorScoresUser10User46 = EuclidDist.CalculateImpostorScores(s010Mean, s046);
            sv.ImpostorScoresUser10User47 = EuclidDist.CalculateImpostorScores(s010Mean, s047);
            sv.ImpostorScoresUser10User48 = EuclidDist.CalculateImpostorScores(s010Mean, s048);
            sv.ImpostorScoresUser10User49 = EuclidDist.CalculateImpostorScores(s010Mean, s049);
            sv.ImpostorScoresUser10User50 = EuclidDist.CalculateImpostorScores(s010Mean, s050);

            sv.ImpostorScoresUser10User51 = EuclidDist.CalculateImpostorScores(s010Mean, s051);
            sv.ImpostorScoresUser10User52 = EuclidDist.CalculateImpostorScores(s010Mean, s052);
            sv.ImpostorScoresUser10User53 = EuclidDist.CalculateImpostorScores(s010Mean, s053);
            sv.ImpostorScoresUser10User54 = EuclidDist.CalculateImpostorScores(s010Mean, s054);
            sv.ImpostorScoresUser10User55 = EuclidDist.CalculateImpostorScores(s010Mean, s055);
            sv.ImpostorScoresUser10User56 = EuclidDist.CalculateImpostorScores(s010Mean, s056);
            sv.ImpostorScoresUser10User57 = EuclidDist.CalculateImpostorScores(s010Mean, s057);
            sv.ImpostorScoresUser10User58 = EuclidDist.CalculateImpostorScores(s010Mean, s058);
            sv.ImpostorScoresUser10User59 = EuclidDist.CalculateImpostorScores(s010Mean, s059);
            sv.ImpostorScoresUser10User60 = EuclidDist.CalculateImpostorScores(s010Mean, s060);

            sv.ImpostorScoresUser10User61 = EuclidDist.CalculateImpostorScores(s010Mean, s061);
            sv.ImpostorScoresUser10User62 = EuclidDist.CalculateImpostorScores(s010Mean, s062);
            sv.ImpostorScoresUser10User63 = EuclidDist.CalculateImpostorScores(s010Mean, s063);
            sv.ImpostorScoresUser10User64 = EuclidDist.CalculateImpostorScores(s010Mean, s064);
            sv.ImpostorScoresUser10User65 = EuclidDist.CalculateImpostorScores(s010Mean, s065);
            sv.ImpostorScoresUser10User66 = EuclidDist.CalculateImpostorScores(s010Mean, s066);
            sv.ImpostorScoresUser10User67 = EuclidDist.CalculateImpostorScores(s010Mean, s067);
            sv.ImpostorScoresUser10User68 = EuclidDist.CalculateImpostorScores(s010Mean, s068);
            sv.ImpostorScoresUser10User69 = EuclidDist.CalculateImpostorScores(s010Mean, s069);
            sv.ImpostorScoresUser10User70 = EuclidDist.CalculateImpostorScores(s010Mean, s070);

            sv.ImpostorScoresUser10User71 = EuclidDist.CalculateImpostorScores(s010Mean, s071);
            sv.ImpostorScoresUser10User72 = EuclidDist.CalculateImpostorScores(s010Mean, s072);
            sv.ImpostorScoresUser10User73 = EuclidDist.CalculateImpostorScores(s010Mean, s073);
            sv.ImpostorScoresUser10User74 = EuclidDist.CalculateImpostorScores(s010Mean, s074);
            sv.ImpostorScoresUser10User75 = EuclidDist.CalculateImpostorScores(s010Mean, s075);
            sv.ImpostorScoresUser10User76 = EuclidDist.CalculateImpostorScores(s010Mean, s076);
            sv.ImpostorScoresUser10User77 = EuclidDist.CalculateImpostorScores(s010Mean, s077);
            sv.ImpostorScoresUser10User78 = EuclidDist.CalculateImpostorScores(s010Mean, s078);
            sv.ImpostorScoresUser10User79 = EuclidDist.CalculateImpostorScores(s010Mean, s079);
            sv.ImpostorScoresUser10User80 = EuclidDist.CalculateImpostorScores(s010Mean, s080);

            sv.ImpostorScoresUser10User81 = EuclidDist.CalculateImpostorScores(s010Mean, s081);
            sv.ImpostorScoresUser10User82 = EuclidDist.CalculateImpostorScores(s010Mean, s082);
            sv.ImpostorScoresUser10User83 = EuclidDist.CalculateImpostorScores(s010Mean, s083);
            sv.ImpostorScoresUser10User84 = EuclidDist.CalculateImpostorScores(s010Mean, s084);
            sv.ImpostorScoresUser10User85 = EuclidDist.CalculateImpostorScores(s010Mean, s085);
            sv.ImpostorScoresUser10User86 = EuclidDist.CalculateImpostorScores(s010Mean, s086);
            sv.ImpostorScoresUser10User87 = EuclidDist.CalculateImpostorScores(s010Mean, s087);
            sv.ImpostorScoresUser10User88 = EuclidDist.CalculateImpostorScores(s010Mean, s088);
            sv.ImpostorScoresUser10User89 = EuclidDist.CalculateImpostorScores(s010Mean, s089);
            sv.ImpostorScoresUser10User90 = EuclidDist.CalculateImpostorScores(s010Mean, s090);

            sv.ImpostorScoresUser10User91 = EuclidDist.CalculateImpostorScores(s010Mean, s091);
            sv.ImpostorScoresUser10User92 = EuclidDist.CalculateImpostorScores(s010Mean, s092);
            sv.ImpostorScoresUser10User93 = EuclidDist.CalculateImpostorScores(s010Mean, s093);
            sv.ImpostorScoresUser10User94 = EuclidDist.CalculateImpostorScores(s010Mean, s094);
            sv.ImpostorScoresUser10User95 = EuclidDist.CalculateImpostorScores(s010Mean, s095);
            sv.ImpostorScoresUser10User96 = EuclidDist.CalculateImpostorScores(s010Mean, s096);
            sv.ImpostorScoresUser10User97 = EuclidDist.CalculateImpostorScores(s010Mean, s097);
            sv.ImpostorScoresUser10User98 = EuclidDist.CalculateImpostorScores(s010Mean, s098);
            sv.ImpostorScoresUser10User99 = EuclidDist.CalculateImpostorScores(s010Mean, s099);
            sv.ImpostorScoresUser10User100 = EuclidDist.CalculateImpostorScores(s010Mean, s100);
            #endregion

            #region User 11 Impostor scores
            sv.ImpostorScoresUser11User1 = EuclidDist.CalculateImpostorScores(s011Mean, s001);
            sv.ImpostorScoresUser11User2 = EuclidDist.CalculateImpostorScores(s011Mean, s002);
            sv.ImpostorScoresUser11User3 = EuclidDist.CalculateImpostorScores(s011Mean, s003);
            sv.ImpostorScoresUser11User4 = EuclidDist.CalculateImpostorScores(s011Mean, s004);
            sv.ImpostorScoresUser11User5 = EuclidDist.CalculateImpostorScores(s011Mean, s005);
            sv.ImpostorScoresUser11User6 = EuclidDist.CalculateImpostorScores(s011Mean, s006);
            sv.ImpostorScoresUser11User7 = EuclidDist.CalculateImpostorScores(s011Mean, s007);
            sv.ImpostorScoresUser11User8 = EuclidDist.CalculateImpostorScores(s011Mean, s008);
            sv.ImpostorScoresUser11User9 = EuclidDist.CalculateImpostorScores(s011Mean, s009);
            sv.ImpostorScoresUser11User10 = EuclidDist.CalculateImpostorScores(s011Mean, s010);

            sv.ImpostorScoresUser11User12 = EuclidDist.CalculateImpostorScores(s011Mean, s012);
            sv.ImpostorScoresUser11User13 = EuclidDist.CalculateImpostorScores(s011Mean, s013);
            sv.ImpostorScoresUser11User14 = EuclidDist.CalculateImpostorScores(s011Mean, s014);
            sv.ImpostorScoresUser11User15 = EuclidDist.CalculateImpostorScores(s011Mean, s015);
            sv.ImpostorScoresUser11User16 = EuclidDist.CalculateImpostorScores(s011Mean, s016);
            sv.ImpostorScoresUser11User17 = EuclidDist.CalculateImpostorScores(s011Mean, s017);
            sv.ImpostorScoresUser11User18 = EuclidDist.CalculateImpostorScores(s011Mean, s018);
            sv.ImpostorScoresUser11User19 = EuclidDist.CalculateImpostorScores(s011Mean, s019);
            sv.ImpostorScoresUser11User20 = EuclidDist.CalculateImpostorScores(s011Mean, s020);

            sv.ImpostorScoresUser11User21 = EuclidDist.CalculateImpostorScores(s011Mean, s021);
            sv.ImpostorScoresUser11User22 = EuclidDist.CalculateImpostorScores(s011Mean, s022);
            sv.ImpostorScoresUser11User23 = EuclidDist.CalculateImpostorScores(s011Mean, s023);
            sv.ImpostorScoresUser11User24 = EuclidDist.CalculateImpostorScores(s011Mean, s024);
            sv.ImpostorScoresUser11User25 = EuclidDist.CalculateImpostorScores(s011Mean, s025);
            sv.ImpostorScoresUser11User26 = EuclidDist.CalculateImpostorScores(s011Mean, s026);
            sv.ImpostorScoresUser11User27 = EuclidDist.CalculateImpostorScores(s011Mean, s027);
            sv.ImpostorScoresUser11User28 = EuclidDist.CalculateImpostorScores(s011Mean, s028);
            sv.ImpostorScoresUser11User29 = EuclidDist.CalculateImpostorScores(s011Mean, s029);
            sv.ImpostorScoresUser11User30 = EuclidDist.CalculateImpostorScores(s011Mean, s030);

            sv.ImpostorScoresUser11User31 = EuclidDist.CalculateImpostorScores(s011Mean, s031);
            sv.ImpostorScoresUser11User32 = EuclidDist.CalculateImpostorScores(s011Mean, s032);
            sv.ImpostorScoresUser11User33 = EuclidDist.CalculateImpostorScores(s011Mean, s033);
            sv.ImpostorScoresUser11User34 = EuclidDist.CalculateImpostorScores(s011Mean, s034);
            sv.ImpostorScoresUser11User35 = EuclidDist.CalculateImpostorScores(s011Mean, s035);
            sv.ImpostorScoresUser11User36 = EuclidDist.CalculateImpostorScores(s011Mean, s036);
            sv.ImpostorScoresUser11User37 = EuclidDist.CalculateImpostorScores(s011Mean, s037);
            sv.ImpostorScoresUser11User38 = EuclidDist.CalculateImpostorScores(s011Mean, s038);
            sv.ImpostorScoresUser11User39 = EuclidDist.CalculateImpostorScores(s011Mean, s039);
            sv.ImpostorScoresUser11User40 = EuclidDist.CalculateImpostorScores(s011Mean, s040);

            sv.ImpostorScoresUser11User41 = EuclidDist.CalculateImpostorScores(s011Mean, s041);
            sv.ImpostorScoresUser11User42 = EuclidDist.CalculateImpostorScores(s011Mean, s042);
            sv.ImpostorScoresUser11User43 = EuclidDist.CalculateImpostorScores(s011Mean, s043);
            sv.ImpostorScoresUser11User44 = EuclidDist.CalculateImpostorScores(s011Mean, s044);
            sv.ImpostorScoresUser11User45 = EuclidDist.CalculateImpostorScores(s011Mean, s045);
            sv.ImpostorScoresUser11User46 = EuclidDist.CalculateImpostorScores(s011Mean, s046);
            sv.ImpostorScoresUser11User47 = EuclidDist.CalculateImpostorScores(s011Mean, s047);
            sv.ImpostorScoresUser11User48 = EuclidDist.CalculateImpostorScores(s011Mean, s048);
            sv.ImpostorScoresUser11User49 = EuclidDist.CalculateImpostorScores(s011Mean, s049);
            sv.ImpostorScoresUser11User50 = EuclidDist.CalculateImpostorScores(s011Mean, s050);

            sv.ImpostorScoresUser11User51 = EuclidDist.CalculateImpostorScores(s011Mean, s051);
            sv.ImpostorScoresUser11User52 = EuclidDist.CalculateImpostorScores(s011Mean, s052);
            sv.ImpostorScoresUser11User53 = EuclidDist.CalculateImpostorScores(s011Mean, s053);
            sv.ImpostorScoresUser11User54 = EuclidDist.CalculateImpostorScores(s011Mean, s054);
            sv.ImpostorScoresUser11User55 = EuclidDist.CalculateImpostorScores(s011Mean, s055);
            sv.ImpostorScoresUser11User56 = EuclidDist.CalculateImpostorScores(s011Mean, s056);
            sv.ImpostorScoresUser11User57 = EuclidDist.CalculateImpostorScores(s011Mean, s057);
            sv.ImpostorScoresUser11User58 = EuclidDist.CalculateImpostorScores(s011Mean, s058);
            sv.ImpostorScoresUser11User59 = EuclidDist.CalculateImpostorScores(s011Mean, s059);
            sv.ImpostorScoresUser11User60 = EuclidDist.CalculateImpostorScores(s011Mean, s060);

            sv.ImpostorScoresUser11User61 = EuclidDist.CalculateImpostorScores(s011Mean, s061);
            sv.ImpostorScoresUser11User62 = EuclidDist.CalculateImpostorScores(s011Mean, s062);
            sv.ImpostorScoresUser11User63 = EuclidDist.CalculateImpostorScores(s011Mean, s063);
            sv.ImpostorScoresUser11User64 = EuclidDist.CalculateImpostorScores(s011Mean, s064);
            sv.ImpostorScoresUser11User65 = EuclidDist.CalculateImpostorScores(s011Mean, s065);
            sv.ImpostorScoresUser11User66 = EuclidDist.CalculateImpostorScores(s011Mean, s066);
            sv.ImpostorScoresUser11User67 = EuclidDist.CalculateImpostorScores(s011Mean, s067);
            sv.ImpostorScoresUser11User68 = EuclidDist.CalculateImpostorScores(s011Mean, s068);
            sv.ImpostorScoresUser11User69 = EuclidDist.CalculateImpostorScores(s011Mean, s069);
            sv.ImpostorScoresUser11User70 = EuclidDist.CalculateImpostorScores(s011Mean, s070);

            sv.ImpostorScoresUser11User71 = EuclidDist.CalculateImpostorScores(s011Mean, s071);
            sv.ImpostorScoresUser11User72 = EuclidDist.CalculateImpostorScores(s011Mean, s072);
            sv.ImpostorScoresUser11User73 = EuclidDist.CalculateImpostorScores(s011Mean, s073);
            sv.ImpostorScoresUser11User74 = EuclidDist.CalculateImpostorScores(s011Mean, s074);
            sv.ImpostorScoresUser11User75 = EuclidDist.CalculateImpostorScores(s011Mean, s075);
            sv.ImpostorScoresUser11User76 = EuclidDist.CalculateImpostorScores(s011Mean, s076);
            sv.ImpostorScoresUser11User77 = EuclidDist.CalculateImpostorScores(s011Mean, s077);
            sv.ImpostorScoresUser11User78 = EuclidDist.CalculateImpostorScores(s011Mean, s078);
            sv.ImpostorScoresUser11User79 = EuclidDist.CalculateImpostorScores(s011Mean, s079);
            sv.ImpostorScoresUser11User80 = EuclidDist.CalculateImpostorScores(s011Mean, s080);

            sv.ImpostorScoresUser11User81 = EuclidDist.CalculateImpostorScores(s011Mean, s081);
            sv.ImpostorScoresUser11User82 = EuclidDist.CalculateImpostorScores(s011Mean, s082);
            sv.ImpostorScoresUser11User83 = EuclidDist.CalculateImpostorScores(s011Mean, s083);
            sv.ImpostorScoresUser11User84 = EuclidDist.CalculateImpostorScores(s011Mean, s084);
            sv.ImpostorScoresUser11User85 = EuclidDist.CalculateImpostorScores(s011Mean, s085);
            sv.ImpostorScoresUser11User86 = EuclidDist.CalculateImpostorScores(s011Mean, s086);
            sv.ImpostorScoresUser11User87 = EuclidDist.CalculateImpostorScores(s011Mean, s087);
            sv.ImpostorScoresUser11User88 = EuclidDist.CalculateImpostorScores(s011Mean, s088);
            sv.ImpostorScoresUser11User89 = EuclidDist.CalculateImpostorScores(s011Mean, s089);
            sv.ImpostorScoresUser11User90 = EuclidDist.CalculateImpostorScores(s011Mean, s090);

            sv.ImpostorScoresUser11User91 = EuclidDist.CalculateImpostorScores(s011Mean, s091);
            sv.ImpostorScoresUser11User92 = EuclidDist.CalculateImpostorScores(s011Mean, s092);
            sv.ImpostorScoresUser11User93 = EuclidDist.CalculateImpostorScores(s011Mean, s093);
            sv.ImpostorScoresUser11User94 = EuclidDist.CalculateImpostorScores(s011Mean, s094);
            sv.ImpostorScoresUser11User95 = EuclidDist.CalculateImpostorScores(s011Mean, s095);
            sv.ImpostorScoresUser11User96 = EuclidDist.CalculateImpostorScores(s011Mean, s096);
            sv.ImpostorScoresUser11User97 = EuclidDist.CalculateImpostorScores(s011Mean, s097);
            sv.ImpostorScoresUser11User98 = EuclidDist.CalculateImpostorScores(s011Mean, s098);
            sv.ImpostorScoresUser11User99 = EuclidDist.CalculateImpostorScores(s011Mean, s099);
            sv.ImpostorScoresUser11User100 = EuclidDist.CalculateImpostorScores(s011Mean, s100);
            #endregion

            #region User 12 Impostor scores
            sv.ImpostorScoresUser12User1 = EuclidDist.CalculateImpostorScores(s012Mean, s001);
            sv.ImpostorScoresUser12User2 = EuclidDist.CalculateImpostorScores(s012Mean, s002);
            sv.ImpostorScoresUser12User3 = EuclidDist.CalculateImpostorScores(s012Mean, s003);
            sv.ImpostorScoresUser12User4 = EuclidDist.CalculateImpostorScores(s012Mean, s004);
            sv.ImpostorScoresUser12User5 = EuclidDist.CalculateImpostorScores(s012Mean, s005);
            sv.ImpostorScoresUser12User6 = EuclidDist.CalculateImpostorScores(s012Mean, s006);
            sv.ImpostorScoresUser12User7 = EuclidDist.CalculateImpostorScores(s012Mean, s007);
            sv.ImpostorScoresUser12User8 = EuclidDist.CalculateImpostorScores(s012Mean, s008);
            sv.ImpostorScoresUser12User9 = EuclidDist.CalculateImpostorScores(s012Mean, s009);
            sv.ImpostorScoresUser12User10 = EuclidDist.CalculateImpostorScores(s012Mean, s010);

            sv.ImpostorScoresUser12User11 = EuclidDist.CalculateImpostorScores(s012Mean, s011);
            sv.ImpostorScoresUser12User13 = EuclidDist.CalculateImpostorScores(s012Mean, s013);
            sv.ImpostorScoresUser12User14 = EuclidDist.CalculateImpostorScores(s012Mean, s014);
            sv.ImpostorScoresUser12User15 = EuclidDist.CalculateImpostorScores(s012Mean, s015);
            sv.ImpostorScoresUser12User16 = EuclidDist.CalculateImpostorScores(s012Mean, s016);
            sv.ImpostorScoresUser12User17 = EuclidDist.CalculateImpostorScores(s012Mean, s017);
            sv.ImpostorScoresUser12User18 = EuclidDist.CalculateImpostorScores(s012Mean, s018);
            sv.ImpostorScoresUser12User19 = EuclidDist.CalculateImpostorScores(s012Mean, s019);
            sv.ImpostorScoresUser12User20 = EuclidDist.CalculateImpostorScores(s012Mean, s020);

            sv.ImpostorScoresUser12User21 = EuclidDist.CalculateImpostorScores(s012Mean, s021);
            sv.ImpostorScoresUser12User22 = EuclidDist.CalculateImpostorScores(s012Mean, s022);
            sv.ImpostorScoresUser12User23 = EuclidDist.CalculateImpostorScores(s012Mean, s023);
            sv.ImpostorScoresUser12User24 = EuclidDist.CalculateImpostorScores(s012Mean, s024);
            sv.ImpostorScoresUser12User25 = EuclidDist.CalculateImpostorScores(s012Mean, s025);
            sv.ImpostorScoresUser12User26 = EuclidDist.CalculateImpostorScores(s012Mean, s026);
            sv.ImpostorScoresUser12User27 = EuclidDist.CalculateImpostorScores(s012Mean, s027);
            sv.ImpostorScoresUser12User28 = EuclidDist.CalculateImpostorScores(s012Mean, s028);
            sv.ImpostorScoresUser12User29 = EuclidDist.CalculateImpostorScores(s012Mean, s029);
            sv.ImpostorScoresUser12User30 = EuclidDist.CalculateImpostorScores(s012Mean, s030);

            sv.ImpostorScoresUser12User31 = EuclidDist.CalculateImpostorScores(s012Mean, s031);
            sv.ImpostorScoresUser12User32 = EuclidDist.CalculateImpostorScores(s012Mean, s032);
            sv.ImpostorScoresUser12User33 = EuclidDist.CalculateImpostorScores(s012Mean, s033);
            sv.ImpostorScoresUser12User34 = EuclidDist.CalculateImpostorScores(s012Mean, s034);
            sv.ImpostorScoresUser12User35 = EuclidDist.CalculateImpostorScores(s012Mean, s035);
            sv.ImpostorScoresUser12User36 = EuclidDist.CalculateImpostorScores(s012Mean, s036);
            sv.ImpostorScoresUser12User37 = EuclidDist.CalculateImpostorScores(s012Mean, s037);
            sv.ImpostorScoresUser12User38 = EuclidDist.CalculateImpostorScores(s012Mean, s038);
            sv.ImpostorScoresUser12User39 = EuclidDist.CalculateImpostorScores(s012Mean, s039);
            sv.ImpostorScoresUser12User40 = EuclidDist.CalculateImpostorScores(s012Mean, s040);

            sv.ImpostorScoresUser12User41 = EuclidDist.CalculateImpostorScores(s012Mean, s041);
            sv.ImpostorScoresUser12User42 = EuclidDist.CalculateImpostorScores(s012Mean, s042);
            sv.ImpostorScoresUser12User43 = EuclidDist.CalculateImpostorScores(s012Mean, s043);
            sv.ImpostorScoresUser12User44 = EuclidDist.CalculateImpostorScores(s012Mean, s044);
            sv.ImpostorScoresUser12User45 = EuclidDist.CalculateImpostorScores(s012Mean, s045);
            sv.ImpostorScoresUser12User46 = EuclidDist.CalculateImpostorScores(s012Mean, s046);
            sv.ImpostorScoresUser12User47 = EuclidDist.CalculateImpostorScores(s012Mean, s047);
            sv.ImpostorScoresUser12User48 = EuclidDist.CalculateImpostorScores(s012Mean, s048);
            sv.ImpostorScoresUser12User49 = EuclidDist.CalculateImpostorScores(s012Mean, s049);
            sv.ImpostorScoresUser12User50 = EuclidDist.CalculateImpostorScores(s012Mean, s050);

            sv.ImpostorScoresUser12User51 = EuclidDist.CalculateImpostorScores(s012Mean, s051);
            sv.ImpostorScoresUser12User52 = EuclidDist.CalculateImpostorScores(s012Mean, s052);
            sv.ImpostorScoresUser12User53 = EuclidDist.CalculateImpostorScores(s012Mean, s053);
            sv.ImpostorScoresUser12User54 = EuclidDist.CalculateImpostorScores(s012Mean, s054);
            sv.ImpostorScoresUser12User55 = EuclidDist.CalculateImpostorScores(s012Mean, s055);
            sv.ImpostorScoresUser12User56 = EuclidDist.CalculateImpostorScores(s012Mean, s056);
            sv.ImpostorScoresUser12User57 = EuclidDist.CalculateImpostorScores(s012Mean, s057);
            sv.ImpostorScoresUser12User58 = EuclidDist.CalculateImpostorScores(s012Mean, s058);
            sv.ImpostorScoresUser12User59 = EuclidDist.CalculateImpostorScores(s012Mean, s059);
            sv.ImpostorScoresUser12User60 = EuclidDist.CalculateImpostorScores(s012Mean, s060);

            sv.ImpostorScoresUser12User61 = EuclidDist.CalculateImpostorScores(s012Mean, s061);
            sv.ImpostorScoresUser12User62 = EuclidDist.CalculateImpostorScores(s012Mean, s062);
            sv.ImpostorScoresUser12User63 = EuclidDist.CalculateImpostorScores(s012Mean, s063);
            sv.ImpostorScoresUser12User64 = EuclidDist.CalculateImpostorScores(s012Mean, s064);
            sv.ImpostorScoresUser12User65 = EuclidDist.CalculateImpostorScores(s012Mean, s065);
            sv.ImpostorScoresUser12User66 = EuclidDist.CalculateImpostorScores(s012Mean, s066);
            sv.ImpostorScoresUser12User67 = EuclidDist.CalculateImpostorScores(s012Mean, s067);
            sv.ImpostorScoresUser12User68 = EuclidDist.CalculateImpostorScores(s012Mean, s068);
            sv.ImpostorScoresUser12User69 = EuclidDist.CalculateImpostorScores(s012Mean, s069);
            sv.ImpostorScoresUser12User70 = EuclidDist.CalculateImpostorScores(s012Mean, s070);

            sv.ImpostorScoresUser12User71 = EuclidDist.CalculateImpostorScores(s012Mean, s071);
            sv.ImpostorScoresUser12User72 = EuclidDist.CalculateImpostorScores(s012Mean, s072);
            sv.ImpostorScoresUser12User73 = EuclidDist.CalculateImpostorScores(s012Mean, s073);
            sv.ImpostorScoresUser12User74 = EuclidDist.CalculateImpostorScores(s012Mean, s074);
            sv.ImpostorScoresUser12User75 = EuclidDist.CalculateImpostorScores(s012Mean, s075);
            sv.ImpostorScoresUser12User76 = EuclidDist.CalculateImpostorScores(s012Mean, s076);
            sv.ImpostorScoresUser12User77 = EuclidDist.CalculateImpostorScores(s012Mean, s077);
            sv.ImpostorScoresUser12User78 = EuclidDist.CalculateImpostorScores(s012Mean, s078);
            sv.ImpostorScoresUser12User79 = EuclidDist.CalculateImpostorScores(s012Mean, s079);
            sv.ImpostorScoresUser12User80 = EuclidDist.CalculateImpostorScores(s012Mean, s080);

            sv.ImpostorScoresUser12User81 = EuclidDist.CalculateImpostorScores(s012Mean, s081);
            sv.ImpostorScoresUser12User82 = EuclidDist.CalculateImpostorScores(s012Mean, s082);
            sv.ImpostorScoresUser12User83 = EuclidDist.CalculateImpostorScores(s012Mean, s083);
            sv.ImpostorScoresUser12User84 = EuclidDist.CalculateImpostorScores(s012Mean, s084);
            sv.ImpostorScoresUser12User85 = EuclidDist.CalculateImpostorScores(s012Mean, s085);
            sv.ImpostorScoresUser12User86 = EuclidDist.CalculateImpostorScores(s012Mean, s086);
            sv.ImpostorScoresUser12User87 = EuclidDist.CalculateImpostorScores(s012Mean, s087);
            sv.ImpostorScoresUser12User88 = EuclidDist.CalculateImpostorScores(s012Mean, s088);
            sv.ImpostorScoresUser12User89 = EuclidDist.CalculateImpostorScores(s012Mean, s089);
            sv.ImpostorScoresUser12User90 = EuclidDist.CalculateImpostorScores(s012Mean, s090);

            sv.ImpostorScoresUser12User91 = EuclidDist.CalculateImpostorScores(s012Mean, s091);
            sv.ImpostorScoresUser12User92 = EuclidDist.CalculateImpostorScores(s012Mean, s092);
            sv.ImpostorScoresUser12User93 = EuclidDist.CalculateImpostorScores(s012Mean, s093);
            sv.ImpostorScoresUser12User94 = EuclidDist.CalculateImpostorScores(s012Mean, s094);
            sv.ImpostorScoresUser12User95 = EuclidDist.CalculateImpostorScores(s012Mean, s095);
            sv.ImpostorScoresUser12User96 = EuclidDist.CalculateImpostorScores(s012Mean, s096);
            sv.ImpostorScoresUser12User97 = EuclidDist.CalculateImpostorScores(s012Mean, s097);
            sv.ImpostorScoresUser12User98 = EuclidDist.CalculateImpostorScores(s012Mean, s098);
            sv.ImpostorScoresUser12User99 = EuclidDist.CalculateImpostorScores(s012Mean, s099);
            sv.ImpostorScoresUser12User100 = EuclidDist.CalculateImpostorScores(s012Mean, s100);
            #endregion

            #endregion
        }
        #endregion

        #region Manhattan Verifier
        private static void UseManhattanVerifier()
        {
            ManhattanDistance ManhDist = new ManhattanDistance();
            ImpostorScoreVars sv = new ImpostorScoreVars();

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

            #region Impostor Scores

            #region User 1 Impostor scores
            sv.ImpostorScoresUser1User2 = ManhDist.CalculateImpostorScores(s001Mean, s002);
            sv.ImpostorScoresUser1User3 = ManhDist.CalculateImpostorScores(s001Mean, s003);
            sv.ImpostorScoresUser1User4 = ManhDist.CalculateImpostorScores(s001Mean, s004);
            sv.ImpostorScoresUser1User5 = ManhDist.CalculateImpostorScores(s001Mean, s005);
            sv.ImpostorScoresUser1User6 = ManhDist.CalculateImpostorScores(s001Mean, s006);
            sv.ImpostorScoresUser1User7 = ManhDist.CalculateImpostorScores(s001Mean, s007);
            sv.ImpostorScoresUser1User8 = ManhDist.CalculateImpostorScores(s001Mean, s008);
            sv.ImpostorScoresUser1User9 = ManhDist.CalculateImpostorScores(s001Mean, s009);
            sv.ImpostorScoresUser1User10 = ManhDist.CalculateImpostorScores(s001Mean, s010);

            sv.ImpostorScoresUser1User11 = ManhDist.CalculateImpostorScores(s001Mean, s011);
            sv.ImpostorScoresUser1User12 = ManhDist.CalculateImpostorScores(s001Mean, s012);
            sv.ImpostorScoresUser1User13 = ManhDist.CalculateImpostorScores(s001Mean, s013);
            sv.ImpostorScoresUser1User14 = ManhDist.CalculateImpostorScores(s001Mean, s014);
            sv.ImpostorScoresUser1User15 = ManhDist.CalculateImpostorScores(s001Mean, s015);
            sv.ImpostorScoresUser1User16 = ManhDist.CalculateImpostorScores(s001Mean, s016);
            sv.ImpostorScoresUser1User17 = ManhDist.CalculateImpostorScores(s001Mean, s017);
            sv.ImpostorScoresUser1User18 = ManhDist.CalculateImpostorScores(s001Mean, s018);
            sv.ImpostorScoresUser1User19 = ManhDist.CalculateImpostorScores(s001Mean, s019);
            sv.ImpostorScoresUser1User20 = ManhDist.CalculateImpostorScores(s001Mean, s020);

            sv.ImpostorScoresUser1User21 = ManhDist.CalculateImpostorScores(s001Mean, s021);
            sv.ImpostorScoresUser1User22 = ManhDist.CalculateImpostorScores(s001Mean, s022);
            sv.ImpostorScoresUser1User23 = ManhDist.CalculateImpostorScores(s001Mean, s023);
            sv.ImpostorScoresUser1User24 = ManhDist.CalculateImpostorScores(s001Mean, s024);
            sv.ImpostorScoresUser1User25 = ManhDist.CalculateImpostorScores(s001Mean, s025);
            sv.ImpostorScoresUser1User26 = ManhDist.CalculateImpostorScores(s001Mean, s026);
            sv.ImpostorScoresUser1User27 = ManhDist.CalculateImpostorScores(s001Mean, s027);
            sv.ImpostorScoresUser1User28 = ManhDist.CalculateImpostorScores(s001Mean, s028);
            sv.ImpostorScoresUser1User29 = ManhDist.CalculateImpostorScores(s001Mean, s029);
            sv.ImpostorScoresUser1User30 = ManhDist.CalculateImpostorScores(s001Mean, s030);

            sv.ImpostorScoresUser1User31 = ManhDist.CalculateImpostorScores(s001Mean, s031);
            sv.ImpostorScoresUser1User32 = ManhDist.CalculateImpostorScores(s001Mean, s032);
            sv.ImpostorScoresUser1User33 = ManhDist.CalculateImpostorScores(s001Mean, s033);
            sv.ImpostorScoresUser1User34 = ManhDist.CalculateImpostorScores(s001Mean, s034);
            sv.ImpostorScoresUser1User35 = ManhDist.CalculateImpostorScores(s001Mean, s035);
            sv.ImpostorScoresUser1User36 = ManhDist.CalculateImpostorScores(s001Mean, s036);
            sv.ImpostorScoresUser1User37 = ManhDist.CalculateImpostorScores(s001Mean, s037);
            sv.ImpostorScoresUser1User38 = ManhDist.CalculateImpostorScores(s001Mean, s038);
            sv.ImpostorScoresUser1User39 = ManhDist.CalculateImpostorScores(s001Mean, s039);
            sv.ImpostorScoresUser1User40 = ManhDist.CalculateImpostorScores(s001Mean, s040);

            sv.ImpostorScoresUser1User41 = ManhDist.CalculateImpostorScores(s001Mean, s041);
            sv.ImpostorScoresUser1User42 = ManhDist.CalculateImpostorScores(s001Mean, s042);
            sv.ImpostorScoresUser1User43 = ManhDist.CalculateImpostorScores(s001Mean, s043);
            sv.ImpostorScoresUser1User44 = ManhDist.CalculateImpostorScores(s001Mean, s044);
            sv.ImpostorScoresUser1User45 = ManhDist.CalculateImpostorScores(s001Mean, s045);
            sv.ImpostorScoresUser1User46 = ManhDist.CalculateImpostorScores(s001Mean, s046);
            sv.ImpostorScoresUser1User47 = ManhDist.CalculateImpostorScores(s001Mean, s047);
            sv.ImpostorScoresUser1User48 = ManhDist.CalculateImpostorScores(s001Mean, s048);
            sv.ImpostorScoresUser1User49 = ManhDist.CalculateImpostorScores(s001Mean, s049);
            sv.ImpostorScoresUser1User50 = ManhDist.CalculateImpostorScores(s001Mean, s050);

            sv.ImpostorScoresUser1User51 = ManhDist.CalculateImpostorScores(s001Mean, s051);
            sv.ImpostorScoresUser1User52 = ManhDist.CalculateImpostorScores(s001Mean, s052);
            sv.ImpostorScoresUser1User53 = ManhDist.CalculateImpostorScores(s001Mean, s053);
            sv.ImpostorScoresUser1User54 = ManhDist.CalculateImpostorScores(s001Mean, s054);
            sv.ImpostorScoresUser1User55 = ManhDist.CalculateImpostorScores(s001Mean, s055);
            sv.ImpostorScoresUser1User56 = ManhDist.CalculateImpostorScores(s001Mean, s056);
            sv.ImpostorScoresUser1User57 = ManhDist.CalculateImpostorScores(s001Mean, s057);
            sv.ImpostorScoresUser1User58 = ManhDist.CalculateImpostorScores(s001Mean, s058);
            sv.ImpostorScoresUser1User59 = ManhDist.CalculateImpostorScores(s001Mean, s059);
            sv.ImpostorScoresUser1User60 = ManhDist.CalculateImpostorScores(s001Mean, s060);

            sv.ImpostorScoresUser1User61 = ManhDist.CalculateImpostorScores(s001Mean, s061);
            sv.ImpostorScoresUser1User62 = ManhDist.CalculateImpostorScores(s001Mean, s062);
            sv.ImpostorScoresUser1User63 = ManhDist.CalculateImpostorScores(s001Mean, s063);
            sv.ImpostorScoresUser1User64 = ManhDist.CalculateImpostorScores(s001Mean, s064);
            sv.ImpostorScoresUser1User65 = ManhDist.CalculateImpostorScores(s001Mean, s065);
            sv.ImpostorScoresUser1User66 = ManhDist.CalculateImpostorScores(s001Mean, s066);
            sv.ImpostorScoresUser1User67 = ManhDist.CalculateImpostorScores(s001Mean, s067);
            sv.ImpostorScoresUser1User68 = ManhDist.CalculateImpostorScores(s001Mean, s068);
            sv.ImpostorScoresUser1User69 = ManhDist.CalculateImpostorScores(s001Mean, s069);
            sv.ImpostorScoresUser1User70 = ManhDist.CalculateImpostorScores(s001Mean, s070);

            sv.ImpostorScoresUser1User71 = ManhDist.CalculateImpostorScores(s001Mean, s071);
            sv.ImpostorScoresUser1User72 = ManhDist.CalculateImpostorScores(s001Mean, s072);
            sv.ImpostorScoresUser1User73 = ManhDist.CalculateImpostorScores(s001Mean, s073);
            sv.ImpostorScoresUser1User74 = ManhDist.CalculateImpostorScores(s001Mean, s074);
            sv.ImpostorScoresUser1User75 = ManhDist.CalculateImpostorScores(s001Mean, s075);
            sv.ImpostorScoresUser1User76 = ManhDist.CalculateImpostorScores(s001Mean, s076);
            sv.ImpostorScoresUser1User77 = ManhDist.CalculateImpostorScores(s001Mean, s077);
            sv.ImpostorScoresUser1User78 = ManhDist.CalculateImpostorScores(s001Mean, s078);
            sv.ImpostorScoresUser1User79 = ManhDist.CalculateImpostorScores(s001Mean, s079);
            sv.ImpostorScoresUser1User80 = ManhDist.CalculateImpostorScores(s001Mean, s080);

            sv.ImpostorScoresUser1User81 = ManhDist.CalculateImpostorScores(s001Mean, s081);
            sv.ImpostorScoresUser1User82 = ManhDist.CalculateImpostorScores(s001Mean, s082);
            sv.ImpostorScoresUser1User83 = ManhDist.CalculateImpostorScores(s001Mean, s083);
            sv.ImpostorScoresUser1User84 = ManhDist.CalculateImpostorScores(s001Mean, s084);
            sv.ImpostorScoresUser1User85 = ManhDist.CalculateImpostorScores(s001Mean, s085);
            sv.ImpostorScoresUser1User86 = ManhDist.CalculateImpostorScores(s001Mean, s086);
            sv.ImpostorScoresUser1User87 = ManhDist.CalculateImpostorScores(s001Mean, s087);
            sv.ImpostorScoresUser1User88 = ManhDist.CalculateImpostorScores(s001Mean, s088);
            sv.ImpostorScoresUser1User89 = ManhDist.CalculateImpostorScores(s001Mean, s089);
            sv.ImpostorScoresUser1User90 = ManhDist.CalculateImpostorScores(s001Mean, s090);

            sv.ImpostorScoresUser1User91 = ManhDist.CalculateImpostorScores(s001Mean, s091);
            sv.ImpostorScoresUser1User92 = ManhDist.CalculateImpostorScores(s001Mean, s092);
            sv.ImpostorScoresUser1User93 = ManhDist.CalculateImpostorScores(s001Mean, s093);
            sv.ImpostorScoresUser1User94 = ManhDist.CalculateImpostorScores(s001Mean, s094);
            sv.ImpostorScoresUser1User95 = ManhDist.CalculateImpostorScores(s001Mean, s095);
            sv.ImpostorScoresUser1User96 = ManhDist.CalculateImpostorScores(s001Mean, s096);
            sv.ImpostorScoresUser1User97 = ManhDist.CalculateImpostorScores(s001Mean, s097);
            sv.ImpostorScoresUser1User98 = ManhDist.CalculateImpostorScores(s001Mean, s098);
            sv.ImpostorScoresUser1User99 = ManhDist.CalculateImpostorScores(s001Mean, s099);
            sv.ImpostorScoresUser1User100 = ManhDist.CalculateImpostorScores(s001Mean, s100);
            #endregion

            #region User 2 Impostor scores
            sv.ImpostorScoresUser2User1 = ManhDist.CalculateImpostorScores(s002Mean, s001);
            sv.ImpostorScoresUser2User3 = ManhDist.CalculateImpostorScores(s002Mean, s003);
            sv.ImpostorScoresUser2User4 = ManhDist.CalculateImpostorScores(s002Mean, s004);
            sv.ImpostorScoresUser2User5 = ManhDist.CalculateImpostorScores(s002Mean, s005);
            sv.ImpostorScoresUser2User6 = ManhDist.CalculateImpostorScores(s002Mean, s006);
            sv.ImpostorScoresUser2User7 = ManhDist.CalculateImpostorScores(s002Mean, s007);
            sv.ImpostorScoresUser2User8 = ManhDist.CalculateImpostorScores(s002Mean, s008);
            sv.ImpostorScoresUser2User9 = ManhDist.CalculateImpostorScores(s002Mean, s009);
            sv.ImpostorScoresUser2User10 = ManhDist.CalculateImpostorScores(s002Mean, s010);

            sv.ImpostorScoresUser2User11 = ManhDist.CalculateImpostorScores(s002Mean, s011);
            sv.ImpostorScoresUser2User12 = ManhDist.CalculateImpostorScores(s002Mean, s012);
            sv.ImpostorScoresUser2User13 = ManhDist.CalculateImpostorScores(s002Mean, s013);
            sv.ImpostorScoresUser2User14 = ManhDist.CalculateImpostorScores(s002Mean, s014);
            sv.ImpostorScoresUser2User15 = ManhDist.CalculateImpostorScores(s002Mean, s015);
            sv.ImpostorScoresUser2User16 = ManhDist.CalculateImpostorScores(s002Mean, s016);
            sv.ImpostorScoresUser2User17 = ManhDist.CalculateImpostorScores(s002Mean, s017);
            sv.ImpostorScoresUser2User18 = ManhDist.CalculateImpostorScores(s002Mean, s018);
            sv.ImpostorScoresUser2User19 = ManhDist.CalculateImpostorScores(s002Mean, s019);
            sv.ImpostorScoresUser2User20 = ManhDist.CalculateImpostorScores(s002Mean, s020);

            sv.ImpostorScoresUser2User21 = ManhDist.CalculateImpostorScores(s002Mean, s021);
            sv.ImpostorScoresUser2User22 = ManhDist.CalculateImpostorScores(s002Mean, s022);
            sv.ImpostorScoresUser2User23 = ManhDist.CalculateImpostorScores(s002Mean, s023);
            sv.ImpostorScoresUser2User24 = ManhDist.CalculateImpostorScores(s002Mean, s024);
            sv.ImpostorScoresUser2User25 = ManhDist.CalculateImpostorScores(s002Mean, s025);
            sv.ImpostorScoresUser2User26 = ManhDist.CalculateImpostorScores(s002Mean, s026);
            sv.ImpostorScoresUser2User27 = ManhDist.CalculateImpostorScores(s002Mean, s027);
            sv.ImpostorScoresUser2User28 = ManhDist.CalculateImpostorScores(s002Mean, s028);
            sv.ImpostorScoresUser2User29 = ManhDist.CalculateImpostorScores(s002Mean, s029);
            sv.ImpostorScoresUser2User30 = ManhDist.CalculateImpostorScores(s002Mean, s030);

            sv.ImpostorScoresUser2User31 = ManhDist.CalculateImpostorScores(s002Mean, s031);
            sv.ImpostorScoresUser2User32 = ManhDist.CalculateImpostorScores(s002Mean, s032);
            sv.ImpostorScoresUser2User33 = ManhDist.CalculateImpostorScores(s002Mean, s033);
            sv.ImpostorScoresUser2User34 = ManhDist.CalculateImpostorScores(s002Mean, s034);
            sv.ImpostorScoresUser2User35 = ManhDist.CalculateImpostorScores(s002Mean, s035);
            sv.ImpostorScoresUser2User36 = ManhDist.CalculateImpostorScores(s002Mean, s036);
            sv.ImpostorScoresUser2User37 = ManhDist.CalculateImpostorScores(s002Mean, s037);
            sv.ImpostorScoresUser2User38 = ManhDist.CalculateImpostorScores(s002Mean, s038);
            sv.ImpostorScoresUser2User39 = ManhDist.CalculateImpostorScores(s002Mean, s039);
            sv.ImpostorScoresUser2User40 = ManhDist.CalculateImpostorScores(s002Mean, s040);

            sv.ImpostorScoresUser2User41 = ManhDist.CalculateImpostorScores(s002Mean, s041);
            sv.ImpostorScoresUser2User42 = ManhDist.CalculateImpostorScores(s002Mean, s042);
            sv.ImpostorScoresUser2User43 = ManhDist.CalculateImpostorScores(s002Mean, s043);
            sv.ImpostorScoresUser2User44 = ManhDist.CalculateImpostorScores(s002Mean, s044);
            sv.ImpostorScoresUser2User45 = ManhDist.CalculateImpostorScores(s002Mean, s045);
            sv.ImpostorScoresUser2User46 = ManhDist.CalculateImpostorScores(s002Mean, s046);
            sv.ImpostorScoresUser2User47 = ManhDist.CalculateImpostorScores(s002Mean, s047);
            sv.ImpostorScoresUser2User48 = ManhDist.CalculateImpostorScores(s002Mean, s048);
            sv.ImpostorScoresUser2User49 = ManhDist.CalculateImpostorScores(s002Mean, s049);
            sv.ImpostorScoresUser2User50 = ManhDist.CalculateImpostorScores(s002Mean, s050);

            sv.ImpostorScoresUser2User51 = ManhDist.CalculateImpostorScores(s002Mean, s051);
            sv.ImpostorScoresUser2User52 = ManhDist.CalculateImpostorScores(s002Mean, s052);
            sv.ImpostorScoresUser2User53 = ManhDist.CalculateImpostorScores(s002Mean, s053);
            sv.ImpostorScoresUser2User54 = ManhDist.CalculateImpostorScores(s002Mean, s054);
            sv.ImpostorScoresUser2User55 = ManhDist.CalculateImpostorScores(s002Mean, s055);
            sv.ImpostorScoresUser2User56 = ManhDist.CalculateImpostorScores(s002Mean, s056);
            sv.ImpostorScoresUser2User57 = ManhDist.CalculateImpostorScores(s002Mean, s057);
            sv.ImpostorScoresUser2User58 = ManhDist.CalculateImpostorScores(s002Mean, s058);
            sv.ImpostorScoresUser2User59 = ManhDist.CalculateImpostorScores(s002Mean, s059);
            sv.ImpostorScoresUser2User60 = ManhDist.CalculateImpostorScores(s002Mean, s060);

            sv.ImpostorScoresUser2User61 = ManhDist.CalculateImpostorScores(s002Mean, s061);
            sv.ImpostorScoresUser2User62 = ManhDist.CalculateImpostorScores(s002Mean, s062);
            sv.ImpostorScoresUser2User63 = ManhDist.CalculateImpostorScores(s002Mean, s063);
            sv.ImpostorScoresUser2User64 = ManhDist.CalculateImpostorScores(s002Mean, s064);
            sv.ImpostorScoresUser2User65 = ManhDist.CalculateImpostorScores(s002Mean, s065);
            sv.ImpostorScoresUser2User66 = ManhDist.CalculateImpostorScores(s002Mean, s066);
            sv.ImpostorScoresUser2User67 = ManhDist.CalculateImpostorScores(s002Mean, s067);
            sv.ImpostorScoresUser2User68 = ManhDist.CalculateImpostorScores(s002Mean, s068);
            sv.ImpostorScoresUser2User69 = ManhDist.CalculateImpostorScores(s002Mean, s069);
            sv.ImpostorScoresUser2User70 = ManhDist.CalculateImpostorScores(s002Mean, s070);

            sv.ImpostorScoresUser2User71 = ManhDist.CalculateImpostorScores(s002Mean, s071);
            sv.ImpostorScoresUser2User72 = ManhDist.CalculateImpostorScores(s002Mean, s072);
            sv.ImpostorScoresUser2User73 = ManhDist.CalculateImpostorScores(s002Mean, s073);
            sv.ImpostorScoresUser2User74 = ManhDist.CalculateImpostorScores(s002Mean, s074);
            sv.ImpostorScoresUser2User75 = ManhDist.CalculateImpostorScores(s002Mean, s075);
            sv.ImpostorScoresUser2User76 = ManhDist.CalculateImpostorScores(s002Mean, s076);
            sv.ImpostorScoresUser2User77 = ManhDist.CalculateImpostorScores(s002Mean, s077);
            sv.ImpostorScoresUser2User78 = ManhDist.CalculateImpostorScores(s002Mean, s078);
            sv.ImpostorScoresUser2User79 = ManhDist.CalculateImpostorScores(s002Mean, s079);
            sv.ImpostorScoresUser2User80 = ManhDist.CalculateImpostorScores(s002Mean, s080);

            sv.ImpostorScoresUser2User81 = ManhDist.CalculateImpostorScores(s002Mean, s081);
            sv.ImpostorScoresUser2User82 = ManhDist.CalculateImpostorScores(s002Mean, s082);
            sv.ImpostorScoresUser2User83 = ManhDist.CalculateImpostorScores(s002Mean, s083);
            sv.ImpostorScoresUser2User84 = ManhDist.CalculateImpostorScores(s002Mean, s084);
            sv.ImpostorScoresUser2User85 = ManhDist.CalculateImpostorScores(s002Mean, s085);
            sv.ImpostorScoresUser2User86 = ManhDist.CalculateImpostorScores(s002Mean, s086);
            sv.ImpostorScoresUser2User87 = ManhDist.CalculateImpostorScores(s002Mean, s087);
            sv.ImpostorScoresUser2User88 = ManhDist.CalculateImpostorScores(s002Mean, s088);
            sv.ImpostorScoresUser2User89 = ManhDist.CalculateImpostorScores(s002Mean, s089);
            sv.ImpostorScoresUser2User90 = ManhDist.CalculateImpostorScores(s002Mean, s090);

            sv.ImpostorScoresUser2User91 = ManhDist.CalculateImpostorScores(s002Mean, s091);
            sv.ImpostorScoresUser2User92 = ManhDist.CalculateImpostorScores(s002Mean, s092);
            sv.ImpostorScoresUser2User93 = ManhDist.CalculateImpostorScores(s002Mean, s093);
            sv.ImpostorScoresUser2User94 = ManhDist.CalculateImpostorScores(s002Mean, s094);
            sv.ImpostorScoresUser2User95 = ManhDist.CalculateImpostorScores(s002Mean, s095);
            sv.ImpostorScoresUser2User96 = ManhDist.CalculateImpostorScores(s002Mean, s096);
            sv.ImpostorScoresUser2User97 = ManhDist.CalculateImpostorScores(s002Mean, s097);
            sv.ImpostorScoresUser2User98 = ManhDist.CalculateImpostorScores(s002Mean, s098);
            sv.ImpostorScoresUser2User99 = ManhDist.CalculateImpostorScores(s002Mean, s099);
            sv.ImpostorScoresUser2User100 = ManhDist.CalculateImpostorScores(s002Mean, s100);
            #endregion

            #region User 3 Impostor scores
            sv.ImpostorScoresUser3User1 = ManhDist.CalculateImpostorScores(s003Mean, s001);
            sv.ImpostorScoresUser3User2 = ManhDist.CalculateImpostorScores(s003Mean, s002);
            sv.ImpostorScoresUser3User4 = ManhDist.CalculateImpostorScores(s003Mean, s004);
            sv.ImpostorScoresUser3User5 = ManhDist.CalculateImpostorScores(s003Mean, s005);
            sv.ImpostorScoresUser3User6 = ManhDist.CalculateImpostorScores(s003Mean, s006);
            sv.ImpostorScoresUser3User7 = ManhDist.CalculateImpostorScores(s003Mean, s007);
            sv.ImpostorScoresUser3User8 = ManhDist.CalculateImpostorScores(s003Mean, s008);
            sv.ImpostorScoresUser3User9 = ManhDist.CalculateImpostorScores(s003Mean, s009);
            sv.ImpostorScoresUser3User10 = ManhDist.CalculateImpostorScores(s003Mean, s010);

            sv.ImpostorScoresUser3User11 = ManhDist.CalculateImpostorScores(s003Mean, s011);
            sv.ImpostorScoresUser3User12 = ManhDist.CalculateImpostorScores(s003Mean, s012);
            sv.ImpostorScoresUser3User13 = ManhDist.CalculateImpostorScores(s003Mean, s013);
            sv.ImpostorScoresUser3User14 = ManhDist.CalculateImpostorScores(s003Mean, s014);
            sv.ImpostorScoresUser3User15 = ManhDist.CalculateImpostorScores(s003Mean, s015);
            sv.ImpostorScoresUser3User16 = ManhDist.CalculateImpostorScores(s003Mean, s016);
            sv.ImpostorScoresUser3User17 = ManhDist.CalculateImpostorScores(s003Mean, s017);
            sv.ImpostorScoresUser3User18 = ManhDist.CalculateImpostorScores(s003Mean, s018);
            sv.ImpostorScoresUser3User19 = ManhDist.CalculateImpostorScores(s003Mean, s019);
            sv.ImpostorScoresUser3User20 = ManhDist.CalculateImpostorScores(s003Mean, s020);

            sv.ImpostorScoresUser3User21 = ManhDist.CalculateImpostorScores(s003Mean, s021);
            sv.ImpostorScoresUser3User22 = ManhDist.CalculateImpostorScores(s003Mean, s022);
            sv.ImpostorScoresUser3User23 = ManhDist.CalculateImpostorScores(s003Mean, s023);
            sv.ImpostorScoresUser3User24 = ManhDist.CalculateImpostorScores(s003Mean, s024);
            sv.ImpostorScoresUser3User25 = ManhDist.CalculateImpostorScores(s003Mean, s025);
            sv.ImpostorScoresUser3User26 = ManhDist.CalculateImpostorScores(s003Mean, s026);
            sv.ImpostorScoresUser3User27 = ManhDist.CalculateImpostorScores(s003Mean, s027);
            sv.ImpostorScoresUser3User28 = ManhDist.CalculateImpostorScores(s003Mean, s028);
            sv.ImpostorScoresUser3User29 = ManhDist.CalculateImpostorScores(s003Mean, s029);
            sv.ImpostorScoresUser3User30 = ManhDist.CalculateImpostorScores(s003Mean, s030);

            sv.ImpostorScoresUser3User31 = ManhDist.CalculateImpostorScores(s003Mean, s031);
            sv.ImpostorScoresUser3User32 = ManhDist.CalculateImpostorScores(s003Mean, s032);
            sv.ImpostorScoresUser3User33 = ManhDist.CalculateImpostorScores(s003Mean, s033);
            sv.ImpostorScoresUser3User34 = ManhDist.CalculateImpostorScores(s003Mean, s034);
            sv.ImpostorScoresUser3User35 = ManhDist.CalculateImpostorScores(s003Mean, s035);
            sv.ImpostorScoresUser3User36 = ManhDist.CalculateImpostorScores(s003Mean, s036);
            sv.ImpostorScoresUser3User37 = ManhDist.CalculateImpostorScores(s003Mean, s037);
            sv.ImpostorScoresUser3User38 = ManhDist.CalculateImpostorScores(s003Mean, s038);
            sv.ImpostorScoresUser3User39 = ManhDist.CalculateImpostorScores(s003Mean, s039);
            sv.ImpostorScoresUser3User40 = ManhDist.CalculateImpostorScores(s003Mean, s040);

            sv.ImpostorScoresUser3User41 = ManhDist.CalculateImpostorScores(s003Mean, s041);
            sv.ImpostorScoresUser3User42 = ManhDist.CalculateImpostorScores(s003Mean, s042);
            sv.ImpostorScoresUser3User43 = ManhDist.CalculateImpostorScores(s003Mean, s043);
            sv.ImpostorScoresUser3User44 = ManhDist.CalculateImpostorScores(s003Mean, s044);
            sv.ImpostorScoresUser3User45 = ManhDist.CalculateImpostorScores(s003Mean, s045);
            sv.ImpostorScoresUser3User46 = ManhDist.CalculateImpostorScores(s003Mean, s046);
            sv.ImpostorScoresUser3User47 = ManhDist.CalculateImpostorScores(s003Mean, s047);
            sv.ImpostorScoresUser3User48 = ManhDist.CalculateImpostorScores(s003Mean, s048);
            sv.ImpostorScoresUser3User49 = ManhDist.CalculateImpostorScores(s003Mean, s049);
            sv.ImpostorScoresUser3User50 = ManhDist.CalculateImpostorScores(s003Mean, s050);

            sv.ImpostorScoresUser3User51 = ManhDist.CalculateImpostorScores(s003Mean, s051);
            sv.ImpostorScoresUser3User52 = ManhDist.CalculateImpostorScores(s003Mean, s052);
            sv.ImpostorScoresUser3User53 = ManhDist.CalculateImpostorScores(s003Mean, s053);
            sv.ImpostorScoresUser3User54 = ManhDist.CalculateImpostorScores(s003Mean, s054);
            sv.ImpostorScoresUser3User55 = ManhDist.CalculateImpostorScores(s003Mean, s055);
            sv.ImpostorScoresUser3User56 = ManhDist.CalculateImpostorScores(s003Mean, s056);
            sv.ImpostorScoresUser3User57 = ManhDist.CalculateImpostorScores(s003Mean, s057);
            sv.ImpostorScoresUser3User58 = ManhDist.CalculateImpostorScores(s003Mean, s058);
            sv.ImpostorScoresUser3User59 = ManhDist.CalculateImpostorScores(s003Mean, s059);
            sv.ImpostorScoresUser3User60 = ManhDist.CalculateImpostorScores(s003Mean, s060);

            sv.ImpostorScoresUser3User61 = ManhDist.CalculateImpostorScores(s003Mean, s061);
            sv.ImpostorScoresUser3User62 = ManhDist.CalculateImpostorScores(s003Mean, s062);
            sv.ImpostorScoresUser3User63 = ManhDist.CalculateImpostorScores(s003Mean, s063);
            sv.ImpostorScoresUser3User64 = ManhDist.CalculateImpostorScores(s003Mean, s064);
            sv.ImpostorScoresUser3User65 = ManhDist.CalculateImpostorScores(s003Mean, s065);
            sv.ImpostorScoresUser3User66 = ManhDist.CalculateImpostorScores(s003Mean, s066);
            sv.ImpostorScoresUser3User67 = ManhDist.CalculateImpostorScores(s003Mean, s067);
            sv.ImpostorScoresUser3User68 = ManhDist.CalculateImpostorScores(s003Mean, s068);
            sv.ImpostorScoresUser3User69 = ManhDist.CalculateImpostorScores(s003Mean, s069);
            sv.ImpostorScoresUser3User70 = ManhDist.CalculateImpostorScores(s003Mean, s070);

            sv.ImpostorScoresUser3User71 = ManhDist.CalculateImpostorScores(s003Mean, s071);
            sv.ImpostorScoresUser3User72 = ManhDist.CalculateImpostorScores(s003Mean, s072);
            sv.ImpostorScoresUser3User73 = ManhDist.CalculateImpostorScores(s003Mean, s073);
            sv.ImpostorScoresUser3User74 = ManhDist.CalculateImpostorScores(s003Mean, s074);
            sv.ImpostorScoresUser3User75 = ManhDist.CalculateImpostorScores(s003Mean, s075);
            sv.ImpostorScoresUser3User76 = ManhDist.CalculateImpostorScores(s003Mean, s076);
            sv.ImpostorScoresUser3User77 = ManhDist.CalculateImpostorScores(s003Mean, s077);
            sv.ImpostorScoresUser3User78 = ManhDist.CalculateImpostorScores(s003Mean, s078);
            sv.ImpostorScoresUser3User79 = ManhDist.CalculateImpostorScores(s003Mean, s079);
            sv.ImpostorScoresUser3User80 = ManhDist.CalculateImpostorScores(s003Mean, s080);

            sv.ImpostorScoresUser3User81 = ManhDist.CalculateImpostorScores(s003Mean, s081);
            sv.ImpostorScoresUser3User82 = ManhDist.CalculateImpostorScores(s003Mean, s082);
            sv.ImpostorScoresUser3User83 = ManhDist.CalculateImpostorScores(s003Mean, s083);
            sv.ImpostorScoresUser3User84 = ManhDist.CalculateImpostorScores(s003Mean, s084);
            sv.ImpostorScoresUser3User85 = ManhDist.CalculateImpostorScores(s003Mean, s085);
            sv.ImpostorScoresUser3User86 = ManhDist.CalculateImpostorScores(s003Mean, s086);
            sv.ImpostorScoresUser3User87 = ManhDist.CalculateImpostorScores(s003Mean, s087);
            sv.ImpostorScoresUser3User88 = ManhDist.CalculateImpostorScores(s003Mean, s088);
            sv.ImpostorScoresUser3User89 = ManhDist.CalculateImpostorScores(s003Mean, s089);
            sv.ImpostorScoresUser3User90 = ManhDist.CalculateImpostorScores(s003Mean, s090);

            sv.ImpostorScoresUser3User91 = ManhDist.CalculateImpostorScores(s003Mean, s091);
            sv.ImpostorScoresUser3User92 = ManhDist.CalculateImpostorScores(s003Mean, s092);
            sv.ImpostorScoresUser3User93 = ManhDist.CalculateImpostorScores(s003Mean, s093);
            sv.ImpostorScoresUser3User94 = ManhDist.CalculateImpostorScores(s003Mean, s094);
            sv.ImpostorScoresUser3User95 = ManhDist.CalculateImpostorScores(s003Mean, s095);
            sv.ImpostorScoresUser3User96 = ManhDist.CalculateImpostorScores(s003Mean, s096);
            sv.ImpostorScoresUser3User97 = ManhDist.CalculateImpostorScores(s003Mean, s097);
            sv.ImpostorScoresUser3User98 = ManhDist.CalculateImpostorScores(s003Mean, s098);
            sv.ImpostorScoresUser3User99 = ManhDist.CalculateImpostorScores(s003Mean, s099);
            sv.ImpostorScoresUser3User100 = ManhDist.CalculateImpostorScores(s003Mean, s100);
            #endregion

            #region User 4 Impostor scores
            sv.ImpostorScoresUser4User1 = ManhDist.CalculateImpostorScores(s004Mean, s001);
            sv.ImpostorScoresUser4User2 = ManhDist.CalculateImpostorScores(s004Mean, s002);
            sv.ImpostorScoresUser4User3 = ManhDist.CalculateImpostorScores(s004Mean, s003);
            sv.ImpostorScoresUser4User5 = ManhDist.CalculateImpostorScores(s004Mean, s005);
            sv.ImpostorScoresUser4User6 = ManhDist.CalculateImpostorScores(s004Mean, s006);
            sv.ImpostorScoresUser4User7 = ManhDist.CalculateImpostorScores(s004Mean, s007);
            sv.ImpostorScoresUser4User8 = ManhDist.CalculateImpostorScores(s004Mean, s008);
            sv.ImpostorScoresUser4User9 = ManhDist.CalculateImpostorScores(s004Mean, s009);
            sv.ImpostorScoresUser4User10 = ManhDist.CalculateImpostorScores(s004Mean, s010);

            sv.ImpostorScoresUser4User11 = ManhDist.CalculateImpostorScores(s004Mean, s011);
            sv.ImpostorScoresUser4User12 = ManhDist.CalculateImpostorScores(s004Mean, s012);
            sv.ImpostorScoresUser4User13 = ManhDist.CalculateImpostorScores(s004Mean, s013);
            sv.ImpostorScoresUser4User14 = ManhDist.CalculateImpostorScores(s004Mean, s014);
            sv.ImpostorScoresUser4User15 = ManhDist.CalculateImpostorScores(s004Mean, s015);
            sv.ImpostorScoresUser4User16 = ManhDist.CalculateImpostorScores(s004Mean, s016);
            sv.ImpostorScoresUser4User17 = ManhDist.CalculateImpostorScores(s004Mean, s017);
            sv.ImpostorScoresUser4User18 = ManhDist.CalculateImpostorScores(s004Mean, s018);
            sv.ImpostorScoresUser4User19 = ManhDist.CalculateImpostorScores(s004Mean, s019);
            sv.ImpostorScoresUser4User20 = ManhDist.CalculateImpostorScores(s004Mean, s020);

            sv.ImpostorScoresUser4User21 = ManhDist.CalculateImpostorScores(s004Mean, s021);
            sv.ImpostorScoresUser4User22 = ManhDist.CalculateImpostorScores(s004Mean, s022);
            sv.ImpostorScoresUser4User23 = ManhDist.CalculateImpostorScores(s004Mean, s023);
            sv.ImpostorScoresUser4User24 = ManhDist.CalculateImpostorScores(s004Mean, s024);
            sv.ImpostorScoresUser4User25 = ManhDist.CalculateImpostorScores(s004Mean, s025);
            sv.ImpostorScoresUser4User26 = ManhDist.CalculateImpostorScores(s004Mean, s026);
            sv.ImpostorScoresUser4User27 = ManhDist.CalculateImpostorScores(s004Mean, s027);
            sv.ImpostorScoresUser4User28 = ManhDist.CalculateImpostorScores(s004Mean, s028);
            sv.ImpostorScoresUser4User29 = ManhDist.CalculateImpostorScores(s004Mean, s029);
            sv.ImpostorScoresUser4User30 = ManhDist.CalculateImpostorScores(s004Mean, s030);

            sv.ImpostorScoresUser4User31 = ManhDist.CalculateImpostorScores(s004Mean, s031);
            sv.ImpostorScoresUser4User32 = ManhDist.CalculateImpostorScores(s004Mean, s032);
            sv.ImpostorScoresUser4User33 = ManhDist.CalculateImpostorScores(s004Mean, s033);
            sv.ImpostorScoresUser4User34 = ManhDist.CalculateImpostorScores(s004Mean, s034);
            sv.ImpostorScoresUser4User35 = ManhDist.CalculateImpostorScores(s004Mean, s035);
            sv.ImpostorScoresUser4User36 = ManhDist.CalculateImpostorScores(s004Mean, s036);
            sv.ImpostorScoresUser4User37 = ManhDist.CalculateImpostorScores(s004Mean, s037);
            sv.ImpostorScoresUser4User38 = ManhDist.CalculateImpostorScores(s004Mean, s038);
            sv.ImpostorScoresUser4User39 = ManhDist.CalculateImpostorScores(s004Mean, s039);
            sv.ImpostorScoresUser4User40 = ManhDist.CalculateImpostorScores(s004Mean, s040);

            sv.ImpostorScoresUser4User41 = ManhDist.CalculateImpostorScores(s004Mean, s041);
            sv.ImpostorScoresUser4User42 = ManhDist.CalculateImpostorScores(s004Mean, s042);
            sv.ImpostorScoresUser4User43 = ManhDist.CalculateImpostorScores(s004Mean, s043);
            sv.ImpostorScoresUser4User44 = ManhDist.CalculateImpostorScores(s004Mean, s044);
            sv.ImpostorScoresUser4User45 = ManhDist.CalculateImpostorScores(s004Mean, s045);
            sv.ImpostorScoresUser4User46 = ManhDist.CalculateImpostorScores(s004Mean, s046);
            sv.ImpostorScoresUser4User47 = ManhDist.CalculateImpostorScores(s004Mean, s047);
            sv.ImpostorScoresUser4User48 = ManhDist.CalculateImpostorScores(s004Mean, s048);
            sv.ImpostorScoresUser4User49 = ManhDist.CalculateImpostorScores(s004Mean, s049);
            sv.ImpostorScoresUser4User50 = ManhDist.CalculateImpostorScores(s004Mean, s050);

            sv.ImpostorScoresUser4User51 = ManhDist.CalculateImpostorScores(s004Mean, s051);
            sv.ImpostorScoresUser4User52 = ManhDist.CalculateImpostorScores(s004Mean, s052);
            sv.ImpostorScoresUser4User53 = ManhDist.CalculateImpostorScores(s004Mean, s053);
            sv.ImpostorScoresUser4User54 = ManhDist.CalculateImpostorScores(s004Mean, s054);
            sv.ImpostorScoresUser4User55 = ManhDist.CalculateImpostorScores(s004Mean, s055);
            sv.ImpostorScoresUser4User56 = ManhDist.CalculateImpostorScores(s004Mean, s056);
            sv.ImpostorScoresUser4User57 = ManhDist.CalculateImpostorScores(s004Mean, s057);
            sv.ImpostorScoresUser4User58 = ManhDist.CalculateImpostorScores(s004Mean, s058);
            sv.ImpostorScoresUser4User59 = ManhDist.CalculateImpostorScores(s004Mean, s059);
            sv.ImpostorScoresUser4User60 = ManhDist.CalculateImpostorScores(s004Mean, s060);

            sv.ImpostorScoresUser4User61 = ManhDist.CalculateImpostorScores(s004Mean, s061);
            sv.ImpostorScoresUser4User62 = ManhDist.CalculateImpostorScores(s004Mean, s062);
            sv.ImpostorScoresUser4User63 = ManhDist.CalculateImpostorScores(s004Mean, s063);
            sv.ImpostorScoresUser4User64 = ManhDist.CalculateImpostorScores(s004Mean, s064);
            sv.ImpostorScoresUser4User65 = ManhDist.CalculateImpostorScores(s004Mean, s065);
            sv.ImpostorScoresUser4User66 = ManhDist.CalculateImpostorScores(s004Mean, s066);
            sv.ImpostorScoresUser4User67 = ManhDist.CalculateImpostorScores(s004Mean, s067);
            sv.ImpostorScoresUser4User68 = ManhDist.CalculateImpostorScores(s004Mean, s068);
            sv.ImpostorScoresUser4User69 = ManhDist.CalculateImpostorScores(s004Mean, s069);
            sv.ImpostorScoresUser4User70 = ManhDist.CalculateImpostorScores(s004Mean, s070);

            sv.ImpostorScoresUser4User71 = ManhDist.CalculateImpostorScores(s004Mean, s071);
            sv.ImpostorScoresUser4User72 = ManhDist.CalculateImpostorScores(s004Mean, s072);
            sv.ImpostorScoresUser4User73 = ManhDist.CalculateImpostorScores(s004Mean, s073);
            sv.ImpostorScoresUser4User74 = ManhDist.CalculateImpostorScores(s004Mean, s074);
            sv.ImpostorScoresUser4User75 = ManhDist.CalculateImpostorScores(s004Mean, s075);
            sv.ImpostorScoresUser4User76 = ManhDist.CalculateImpostorScores(s004Mean, s076);
            sv.ImpostorScoresUser4User77 = ManhDist.CalculateImpostorScores(s004Mean, s077);
            sv.ImpostorScoresUser4User78 = ManhDist.CalculateImpostorScores(s004Mean, s078);
            sv.ImpostorScoresUser4User79 = ManhDist.CalculateImpostorScores(s004Mean, s079);
            sv.ImpostorScoresUser4User80 = ManhDist.CalculateImpostorScores(s004Mean, s080);

            sv.ImpostorScoresUser4User81 = ManhDist.CalculateImpostorScores(s004Mean, s081);
            sv.ImpostorScoresUser4User82 = ManhDist.CalculateImpostorScores(s004Mean, s082);
            sv.ImpostorScoresUser4User83 = ManhDist.CalculateImpostorScores(s004Mean, s083);
            sv.ImpostorScoresUser4User84 = ManhDist.CalculateImpostorScores(s004Mean, s084);
            sv.ImpostorScoresUser4User85 = ManhDist.CalculateImpostorScores(s004Mean, s085);
            sv.ImpostorScoresUser4User86 = ManhDist.CalculateImpostorScores(s004Mean, s086);
            sv.ImpostorScoresUser4User87 = ManhDist.CalculateImpostorScores(s004Mean, s087);
            sv.ImpostorScoresUser4User88 = ManhDist.CalculateImpostorScores(s004Mean, s088);
            sv.ImpostorScoresUser4User89 = ManhDist.CalculateImpostorScores(s004Mean, s089);
            sv.ImpostorScoresUser4User90 = ManhDist.CalculateImpostorScores(s004Mean, s090);

            sv.ImpostorScoresUser4User91 = ManhDist.CalculateImpostorScores(s004Mean, s091);
            sv.ImpostorScoresUser4User92 = ManhDist.CalculateImpostorScores(s004Mean, s092);
            sv.ImpostorScoresUser4User93 = ManhDist.CalculateImpostorScores(s004Mean, s093);
            sv.ImpostorScoresUser4User94 = ManhDist.CalculateImpostorScores(s004Mean, s094);
            sv.ImpostorScoresUser4User95 = ManhDist.CalculateImpostorScores(s004Mean, s095);
            sv.ImpostorScoresUser4User96 = ManhDist.CalculateImpostorScores(s004Mean, s096);
            sv.ImpostorScoresUser4User97 = ManhDist.CalculateImpostorScores(s004Mean, s097);
            sv.ImpostorScoresUser4User98 = ManhDist.CalculateImpostorScores(s004Mean, s098);
            sv.ImpostorScoresUser4User99 = ManhDist.CalculateImpostorScores(s004Mean, s099);
            sv.ImpostorScoresUser4User100 = ManhDist.CalculateImpostorScores(s004Mean, s100);
            #endregion

            #region User 5 Impostor scores
            sv.ImpostorScoresUser5User1 = ManhDist.CalculateImpostorScores(s005Mean, s001);
            sv.ImpostorScoresUser5User2 = ManhDist.CalculateImpostorScores(s005Mean, s002);
            sv.ImpostorScoresUser5User3 = ManhDist.CalculateImpostorScores(s005Mean, s003);
            sv.ImpostorScoresUser5User4 = ManhDist.CalculateImpostorScores(s005Mean, s004);
            sv.ImpostorScoresUser5User6 = ManhDist.CalculateImpostorScores(s005Mean, s006);
            sv.ImpostorScoresUser5User7 = ManhDist.CalculateImpostorScores(s005Mean, s007);
            sv.ImpostorScoresUser5User8 = ManhDist.CalculateImpostorScores(s005Mean, s008);
            sv.ImpostorScoresUser5User9 = ManhDist.CalculateImpostorScores(s005Mean, s009);
            sv.ImpostorScoresUser5User10 = ManhDist.CalculateImpostorScores(s005Mean, s010);

            sv.ImpostorScoresUser5User11 = ManhDist.CalculateImpostorScores(s005Mean, s011);
            sv.ImpostorScoresUser5User12 = ManhDist.CalculateImpostorScores(s005Mean, s012);
            sv.ImpostorScoresUser5User13 = ManhDist.CalculateImpostorScores(s005Mean, s013);
            sv.ImpostorScoresUser5User14 = ManhDist.CalculateImpostorScores(s005Mean, s014);
            sv.ImpostorScoresUser5User15 = ManhDist.CalculateImpostorScores(s005Mean, s015);
            sv.ImpostorScoresUser5User16 = ManhDist.CalculateImpostorScores(s005Mean, s016);
            sv.ImpostorScoresUser5User17 = ManhDist.CalculateImpostorScores(s005Mean, s017);
            sv.ImpostorScoresUser5User18 = ManhDist.CalculateImpostorScores(s005Mean, s018);
            sv.ImpostorScoresUser5User19 = ManhDist.CalculateImpostorScores(s005Mean, s019);
            sv.ImpostorScoresUser5User20 = ManhDist.CalculateImpostorScores(s005Mean, s020);

            sv.ImpostorScoresUser5User21 = ManhDist.CalculateImpostorScores(s005Mean, s021);
            sv.ImpostorScoresUser5User22 = ManhDist.CalculateImpostorScores(s005Mean, s022);
            sv.ImpostorScoresUser5User23 = ManhDist.CalculateImpostorScores(s005Mean, s023);
            sv.ImpostorScoresUser5User24 = ManhDist.CalculateImpostorScores(s005Mean, s024);
            sv.ImpostorScoresUser5User25 = ManhDist.CalculateImpostorScores(s005Mean, s025);
            sv.ImpostorScoresUser5User26 = ManhDist.CalculateImpostorScores(s005Mean, s026);
            sv.ImpostorScoresUser5User27 = ManhDist.CalculateImpostorScores(s005Mean, s027);
            sv.ImpostorScoresUser5User28 = ManhDist.CalculateImpostorScores(s005Mean, s028);
            sv.ImpostorScoresUser5User29 = ManhDist.CalculateImpostorScores(s005Mean, s029);
            sv.ImpostorScoresUser5User30 = ManhDist.CalculateImpostorScores(s005Mean, s030);

            sv.ImpostorScoresUser5User31 = ManhDist.CalculateImpostorScores(s005Mean, s031);
            sv.ImpostorScoresUser5User32 = ManhDist.CalculateImpostorScores(s005Mean, s032);
            sv.ImpostorScoresUser5User33 = ManhDist.CalculateImpostorScores(s005Mean, s033);
            sv.ImpostorScoresUser5User34 = ManhDist.CalculateImpostorScores(s005Mean, s034);
            sv.ImpostorScoresUser5User35 = ManhDist.CalculateImpostorScores(s005Mean, s035);
            sv.ImpostorScoresUser5User36 = ManhDist.CalculateImpostorScores(s005Mean, s036);
            sv.ImpostorScoresUser5User37 = ManhDist.CalculateImpostorScores(s005Mean, s037);
            sv.ImpostorScoresUser5User38 = ManhDist.CalculateImpostorScores(s005Mean, s038);
            sv.ImpostorScoresUser5User39 = ManhDist.CalculateImpostorScores(s005Mean, s039);
            sv.ImpostorScoresUser5User40 = ManhDist.CalculateImpostorScores(s005Mean, s040);

            sv.ImpostorScoresUser5User41 = ManhDist.CalculateImpostorScores(s005Mean, s041);
            sv.ImpostorScoresUser5User42 = ManhDist.CalculateImpostorScores(s005Mean, s042);
            sv.ImpostorScoresUser5User43 = ManhDist.CalculateImpostorScores(s005Mean, s043);
            sv.ImpostorScoresUser5User44 = ManhDist.CalculateImpostorScores(s005Mean, s044);
            sv.ImpostorScoresUser5User45 = ManhDist.CalculateImpostorScores(s005Mean, s045);
            sv.ImpostorScoresUser5User46 = ManhDist.CalculateImpostorScores(s005Mean, s046);
            sv.ImpostorScoresUser5User47 = ManhDist.CalculateImpostorScores(s005Mean, s047);
            sv.ImpostorScoresUser5User48 = ManhDist.CalculateImpostorScores(s005Mean, s048);
            sv.ImpostorScoresUser5User49 = ManhDist.CalculateImpostorScores(s005Mean, s049);
            sv.ImpostorScoresUser5User50 = ManhDist.CalculateImpostorScores(s005Mean, s050);

            sv.ImpostorScoresUser5User51 = ManhDist.CalculateImpostorScores(s005Mean, s051);
            sv.ImpostorScoresUser5User52 = ManhDist.CalculateImpostorScores(s005Mean, s052);
            sv.ImpostorScoresUser5User53 = ManhDist.CalculateImpostorScores(s005Mean, s053);
            sv.ImpostorScoresUser5User54 = ManhDist.CalculateImpostorScores(s005Mean, s054);
            sv.ImpostorScoresUser5User55 = ManhDist.CalculateImpostorScores(s005Mean, s055);
            sv.ImpostorScoresUser5User56 = ManhDist.CalculateImpostorScores(s005Mean, s056);
            sv.ImpostorScoresUser5User57 = ManhDist.CalculateImpostorScores(s005Mean, s057);
            sv.ImpostorScoresUser5User58 = ManhDist.CalculateImpostorScores(s005Mean, s058);
            sv.ImpostorScoresUser5User59 = ManhDist.CalculateImpostorScores(s005Mean, s059);
            sv.ImpostorScoresUser5User60 = ManhDist.CalculateImpostorScores(s005Mean, s060);

            sv.ImpostorScoresUser5User61 = ManhDist.CalculateImpostorScores(s005Mean, s061);
            sv.ImpostorScoresUser5User62 = ManhDist.CalculateImpostorScores(s005Mean, s062);
            sv.ImpostorScoresUser5User63 = ManhDist.CalculateImpostorScores(s005Mean, s063);
            sv.ImpostorScoresUser5User64 = ManhDist.CalculateImpostorScores(s005Mean, s064);
            sv.ImpostorScoresUser5User65 = ManhDist.CalculateImpostorScores(s005Mean, s065);
            sv.ImpostorScoresUser5User66 = ManhDist.CalculateImpostorScores(s005Mean, s066);
            sv.ImpostorScoresUser5User67 = ManhDist.CalculateImpostorScores(s005Mean, s067);
            sv.ImpostorScoresUser5User68 = ManhDist.CalculateImpostorScores(s005Mean, s068);
            sv.ImpostorScoresUser5User69 = ManhDist.CalculateImpostorScores(s005Mean, s069);
            sv.ImpostorScoresUser5User70 = ManhDist.CalculateImpostorScores(s005Mean, s070);

            sv.ImpostorScoresUser5User71 = ManhDist.CalculateImpostorScores(s005Mean, s071);
            sv.ImpostorScoresUser5User72 = ManhDist.CalculateImpostorScores(s005Mean, s072);
            sv.ImpostorScoresUser5User73 = ManhDist.CalculateImpostorScores(s005Mean, s073);
            sv.ImpostorScoresUser5User74 = ManhDist.CalculateImpostorScores(s005Mean, s074);
            sv.ImpostorScoresUser5User75 = ManhDist.CalculateImpostorScores(s005Mean, s075);
            sv.ImpostorScoresUser5User76 = ManhDist.CalculateImpostorScores(s005Mean, s076);
            sv.ImpostorScoresUser5User77 = ManhDist.CalculateImpostorScores(s005Mean, s077);
            sv.ImpostorScoresUser5User78 = ManhDist.CalculateImpostorScores(s005Mean, s078);
            sv.ImpostorScoresUser5User79 = ManhDist.CalculateImpostorScores(s005Mean, s079);
            sv.ImpostorScoresUser5User80 = ManhDist.CalculateImpostorScores(s005Mean, s080);

            sv.ImpostorScoresUser5User81 = ManhDist.CalculateImpostorScores(s005Mean, s081);
            sv.ImpostorScoresUser5User82 = ManhDist.CalculateImpostorScores(s005Mean, s082);
            sv.ImpostorScoresUser5User83 = ManhDist.CalculateImpostorScores(s005Mean, s083);
            sv.ImpostorScoresUser5User84 = ManhDist.CalculateImpostorScores(s005Mean, s084);
            sv.ImpostorScoresUser5User85 = ManhDist.CalculateImpostorScores(s005Mean, s085);
            sv.ImpostorScoresUser5User86 = ManhDist.CalculateImpostorScores(s005Mean, s086);
            sv.ImpostorScoresUser5User87 = ManhDist.CalculateImpostorScores(s005Mean, s087);
            sv.ImpostorScoresUser5User88 = ManhDist.CalculateImpostorScores(s005Mean, s088);
            sv.ImpostorScoresUser5User89 = ManhDist.CalculateImpostorScores(s005Mean, s089);
            sv.ImpostorScoresUser5User90 = ManhDist.CalculateImpostorScores(s005Mean, s090);

            sv.ImpostorScoresUser5User91 = ManhDist.CalculateImpostorScores(s005Mean, s091);
            sv.ImpostorScoresUser5User92 = ManhDist.CalculateImpostorScores(s005Mean, s092);
            sv.ImpostorScoresUser5User93 = ManhDist.CalculateImpostorScores(s005Mean, s093);
            sv.ImpostorScoresUser5User94 = ManhDist.CalculateImpostorScores(s005Mean, s094);
            sv.ImpostorScoresUser5User95 = ManhDist.CalculateImpostorScores(s005Mean, s095);
            sv.ImpostorScoresUser5User96 = ManhDist.CalculateImpostorScores(s005Mean, s096);
            sv.ImpostorScoresUser5User97 = ManhDist.CalculateImpostorScores(s005Mean, s097);
            sv.ImpostorScoresUser5User98 = ManhDist.CalculateImpostorScores(s005Mean, s098);
            sv.ImpostorScoresUser5User99 = ManhDist.CalculateImpostorScores(s005Mean, s099);
            sv.ImpostorScoresUser5User100 = ManhDist.CalculateImpostorScores(s005Mean, s100);
            #endregion

            #region User 6 Impostor scores
            sv.ImpostorScoresUser6User1 = ManhDist.CalculateImpostorScores(s006Mean, s001);
            sv.ImpostorScoresUser6User2 = ManhDist.CalculateImpostorScores(s006Mean, s002);
            sv.ImpostorScoresUser6User3 = ManhDist.CalculateImpostorScores(s006Mean, s003);
            sv.ImpostorScoresUser6User4 = ManhDist.CalculateImpostorScores(s006Mean, s004);
            sv.ImpostorScoresUser6User5 = ManhDist.CalculateImpostorScores(s006Mean, s005);
            sv.ImpostorScoresUser6User7 = ManhDist.CalculateImpostorScores(s006Mean, s007);
            sv.ImpostorScoresUser6User8 = ManhDist.CalculateImpostorScores(s006Mean, s008);
            sv.ImpostorScoresUser6User9 = ManhDist.CalculateImpostorScores(s006Mean, s009);
            sv.ImpostorScoresUser6User10 = ManhDist.CalculateImpostorScores(s006Mean, s010);

            sv.ImpostorScoresUser6User11 = ManhDist.CalculateImpostorScores(s006Mean, s011);
            sv.ImpostorScoresUser6User12 = ManhDist.CalculateImpostorScores(s006Mean, s012);
            sv.ImpostorScoresUser6User13 = ManhDist.CalculateImpostorScores(s006Mean, s013);
            sv.ImpostorScoresUser6User14 = ManhDist.CalculateImpostorScores(s006Mean, s014);
            sv.ImpostorScoresUser6User15 = ManhDist.CalculateImpostorScores(s006Mean, s015);
            sv.ImpostorScoresUser6User16 = ManhDist.CalculateImpostorScores(s006Mean, s016);
            sv.ImpostorScoresUser6User17 = ManhDist.CalculateImpostorScores(s006Mean, s017);
            sv.ImpostorScoresUser6User18 = ManhDist.CalculateImpostorScores(s006Mean, s018);
            sv.ImpostorScoresUser6User19 = ManhDist.CalculateImpostorScores(s006Mean, s019);
            sv.ImpostorScoresUser6User20 = ManhDist.CalculateImpostorScores(s006Mean, s020);

            sv.ImpostorScoresUser6User21 = ManhDist.CalculateImpostorScores(s006Mean, s021);
            sv.ImpostorScoresUser6User22 = ManhDist.CalculateImpostorScores(s006Mean, s022);
            sv.ImpostorScoresUser6User23 = ManhDist.CalculateImpostorScores(s006Mean, s023);
            sv.ImpostorScoresUser6User24 = ManhDist.CalculateImpostorScores(s006Mean, s024);
            sv.ImpostorScoresUser6User25 = ManhDist.CalculateImpostorScores(s006Mean, s025);
            sv.ImpostorScoresUser6User26 = ManhDist.CalculateImpostorScores(s006Mean, s026);
            sv.ImpostorScoresUser6User27 = ManhDist.CalculateImpostorScores(s006Mean, s027);
            sv.ImpostorScoresUser6User28 = ManhDist.CalculateImpostorScores(s006Mean, s028);
            sv.ImpostorScoresUser6User29 = ManhDist.CalculateImpostorScores(s006Mean, s029);
            sv.ImpostorScoresUser6User30 = ManhDist.CalculateImpostorScores(s006Mean, s030);

            sv.ImpostorScoresUser6User31 = ManhDist.CalculateImpostorScores(s006Mean, s031);
            sv.ImpostorScoresUser6User32 = ManhDist.CalculateImpostorScores(s006Mean, s032);
            sv.ImpostorScoresUser6User33 = ManhDist.CalculateImpostorScores(s006Mean, s033);
            sv.ImpostorScoresUser6User34 = ManhDist.CalculateImpostorScores(s006Mean, s034);
            sv.ImpostorScoresUser6User35 = ManhDist.CalculateImpostorScores(s006Mean, s035);
            sv.ImpostorScoresUser6User36 = ManhDist.CalculateImpostorScores(s006Mean, s036);
            sv.ImpostorScoresUser6User37 = ManhDist.CalculateImpostorScores(s006Mean, s037);
            sv.ImpostorScoresUser6User38 = ManhDist.CalculateImpostorScores(s006Mean, s038);
            sv.ImpostorScoresUser6User39 = ManhDist.CalculateImpostorScores(s006Mean, s039);
            sv.ImpostorScoresUser6User40 = ManhDist.CalculateImpostorScores(s006Mean, s040);

            sv.ImpostorScoresUser6User41 = ManhDist.CalculateImpostorScores(s006Mean, s041);
            sv.ImpostorScoresUser6User42 = ManhDist.CalculateImpostorScores(s006Mean, s042);
            sv.ImpostorScoresUser6User43 = ManhDist.CalculateImpostorScores(s006Mean, s043);
            sv.ImpostorScoresUser6User44 = ManhDist.CalculateImpostorScores(s006Mean, s044);
            sv.ImpostorScoresUser6User45 = ManhDist.CalculateImpostorScores(s006Mean, s045);
            sv.ImpostorScoresUser6User46 = ManhDist.CalculateImpostorScores(s006Mean, s046);
            sv.ImpostorScoresUser6User47 = ManhDist.CalculateImpostorScores(s006Mean, s047);
            sv.ImpostorScoresUser6User48 = ManhDist.CalculateImpostorScores(s006Mean, s048);
            sv.ImpostorScoresUser6User49 = ManhDist.CalculateImpostorScores(s006Mean, s049);
            sv.ImpostorScoresUser6User50 = ManhDist.CalculateImpostorScores(s006Mean, s050);

            sv.ImpostorScoresUser6User51 = ManhDist.CalculateImpostorScores(s006Mean, s051);
            sv.ImpostorScoresUser6User52 = ManhDist.CalculateImpostorScores(s006Mean, s052);
            sv.ImpostorScoresUser6User53 = ManhDist.CalculateImpostorScores(s006Mean, s053);
            sv.ImpostorScoresUser6User54 = ManhDist.CalculateImpostorScores(s006Mean, s054);
            sv.ImpostorScoresUser6User55 = ManhDist.CalculateImpostorScores(s006Mean, s055);
            sv.ImpostorScoresUser6User56 = ManhDist.CalculateImpostorScores(s006Mean, s056);
            sv.ImpostorScoresUser6User57 = ManhDist.CalculateImpostorScores(s006Mean, s057);
            sv.ImpostorScoresUser6User58 = ManhDist.CalculateImpostorScores(s006Mean, s058);
            sv.ImpostorScoresUser6User59 = ManhDist.CalculateImpostorScores(s006Mean, s059);
            sv.ImpostorScoresUser6User60 = ManhDist.CalculateImpostorScores(s006Mean, s060);

            sv.ImpostorScoresUser6User61 = ManhDist.CalculateImpostorScores(s006Mean, s061);
            sv.ImpostorScoresUser6User62 = ManhDist.CalculateImpostorScores(s006Mean, s062);
            sv.ImpostorScoresUser6User63 = ManhDist.CalculateImpostorScores(s006Mean, s063);
            sv.ImpostorScoresUser6User64 = ManhDist.CalculateImpostorScores(s006Mean, s064);
            sv.ImpostorScoresUser6User65 = ManhDist.CalculateImpostorScores(s006Mean, s065);
            sv.ImpostorScoresUser6User66 = ManhDist.CalculateImpostorScores(s006Mean, s066);
            sv.ImpostorScoresUser6User67 = ManhDist.CalculateImpostorScores(s006Mean, s067);
            sv.ImpostorScoresUser6User68 = ManhDist.CalculateImpostorScores(s006Mean, s068);
            sv.ImpostorScoresUser6User69 = ManhDist.CalculateImpostorScores(s006Mean, s069);
            sv.ImpostorScoresUser6User70 = ManhDist.CalculateImpostorScores(s006Mean, s070);

            sv.ImpostorScoresUser6User71 = ManhDist.CalculateImpostorScores(s006Mean, s071);
            sv.ImpostorScoresUser6User72 = ManhDist.CalculateImpostorScores(s006Mean, s072);
            sv.ImpostorScoresUser6User73 = ManhDist.CalculateImpostorScores(s006Mean, s073);
            sv.ImpostorScoresUser6User74 = ManhDist.CalculateImpostorScores(s006Mean, s074);
            sv.ImpostorScoresUser6User75 = ManhDist.CalculateImpostorScores(s006Mean, s075);
            sv.ImpostorScoresUser6User76 = ManhDist.CalculateImpostorScores(s006Mean, s076);
            sv.ImpostorScoresUser6User77 = ManhDist.CalculateImpostorScores(s006Mean, s077);
            sv.ImpostorScoresUser6User78 = ManhDist.CalculateImpostorScores(s006Mean, s078);
            sv.ImpostorScoresUser6User79 = ManhDist.CalculateImpostorScores(s006Mean, s079);
            sv.ImpostorScoresUser6User80 = ManhDist.CalculateImpostorScores(s006Mean, s080);

            sv.ImpostorScoresUser6User81 = ManhDist.CalculateImpostorScores(s006Mean, s081);
            sv.ImpostorScoresUser6User82 = ManhDist.CalculateImpostorScores(s006Mean, s082);
            sv.ImpostorScoresUser6User83 = ManhDist.CalculateImpostorScores(s006Mean, s083);
            sv.ImpostorScoresUser6User84 = ManhDist.CalculateImpostorScores(s006Mean, s084);
            sv.ImpostorScoresUser6User85 = ManhDist.CalculateImpostorScores(s006Mean, s085);
            sv.ImpostorScoresUser6User86 = ManhDist.CalculateImpostorScores(s006Mean, s086);
            sv.ImpostorScoresUser6User87 = ManhDist.CalculateImpostorScores(s006Mean, s087);
            sv.ImpostorScoresUser6User88 = ManhDist.CalculateImpostorScores(s006Mean, s088);
            sv.ImpostorScoresUser6User89 = ManhDist.CalculateImpostorScores(s006Mean, s089);
            sv.ImpostorScoresUser6User90 = ManhDist.CalculateImpostorScores(s006Mean, s090);

            sv.ImpostorScoresUser6User91 = ManhDist.CalculateImpostorScores(s006Mean, s091);
            sv.ImpostorScoresUser6User92 = ManhDist.CalculateImpostorScores(s006Mean, s092);
            sv.ImpostorScoresUser6User93 = ManhDist.CalculateImpostorScores(s006Mean, s093);
            sv.ImpostorScoresUser6User94 = ManhDist.CalculateImpostorScores(s006Mean, s094);
            sv.ImpostorScoresUser6User95 = ManhDist.CalculateImpostorScores(s006Mean, s095);
            sv.ImpostorScoresUser6User96 = ManhDist.CalculateImpostorScores(s006Mean, s096);
            sv.ImpostorScoresUser6User97 = ManhDist.CalculateImpostorScores(s006Mean, s097);
            sv.ImpostorScoresUser6User98 = ManhDist.CalculateImpostorScores(s006Mean, s098);
            sv.ImpostorScoresUser6User99 = ManhDist.CalculateImpostorScores(s006Mean, s099);
            sv.ImpostorScoresUser6User100 = ManhDist.CalculateImpostorScores(s006Mean, s100);
            #endregion

            #region User 7 Impostor scores
            sv.ImpostorScoresUser7User1 = ManhDist.CalculateImpostorScores(s007Mean, s001);
            sv.ImpostorScoresUser7User2 = ManhDist.CalculateImpostorScores(s007Mean, s002);
            sv.ImpostorScoresUser7User3 = ManhDist.CalculateImpostorScores(s007Mean, s003);
            sv.ImpostorScoresUser7User4 = ManhDist.CalculateImpostorScores(s007Mean, s004);
            sv.ImpostorScoresUser7User5 = ManhDist.CalculateImpostorScores(s007Mean, s005);
            sv.ImpostorScoresUser7User6 = ManhDist.CalculateImpostorScores(s007Mean, s006);
            sv.ImpostorScoresUser7User8 = ManhDist.CalculateImpostorScores(s007Mean, s008);
            sv.ImpostorScoresUser7User9 = ManhDist.CalculateImpostorScores(s007Mean, s009);
            sv.ImpostorScoresUser7User10 = ManhDist.CalculateImpostorScores(s007Mean, s010);

            sv.ImpostorScoresUser7User11 = ManhDist.CalculateImpostorScores(s007Mean, s011);
            sv.ImpostorScoresUser7User12 = ManhDist.CalculateImpostorScores(s007Mean, s012);
            sv.ImpostorScoresUser7User13 = ManhDist.CalculateImpostorScores(s007Mean, s013);
            sv.ImpostorScoresUser7User14 = ManhDist.CalculateImpostorScores(s007Mean, s014);
            sv.ImpostorScoresUser7User15 = ManhDist.CalculateImpostorScores(s007Mean, s015);
            sv.ImpostorScoresUser7User16 = ManhDist.CalculateImpostorScores(s007Mean, s016);
            sv.ImpostorScoresUser7User17 = ManhDist.CalculateImpostorScores(s007Mean, s017);
            sv.ImpostorScoresUser7User18 = ManhDist.CalculateImpostorScores(s007Mean, s018);
            sv.ImpostorScoresUser7User19 = ManhDist.CalculateImpostorScores(s007Mean, s019);
            sv.ImpostorScoresUser7User20 = ManhDist.CalculateImpostorScores(s007Mean, s020);

            sv.ImpostorScoresUser7User21 = ManhDist.CalculateImpostorScores(s007Mean, s021);
            sv.ImpostorScoresUser7User22 = ManhDist.CalculateImpostorScores(s007Mean, s022);
            sv.ImpostorScoresUser7User23 = ManhDist.CalculateImpostorScores(s007Mean, s023);
            sv.ImpostorScoresUser7User24 = ManhDist.CalculateImpostorScores(s007Mean, s024);
            sv.ImpostorScoresUser7User25 = ManhDist.CalculateImpostorScores(s007Mean, s025);
            sv.ImpostorScoresUser7User26 = ManhDist.CalculateImpostorScores(s007Mean, s026);
            sv.ImpostorScoresUser7User27 = ManhDist.CalculateImpostorScores(s007Mean, s027);
            sv.ImpostorScoresUser7User28 = ManhDist.CalculateImpostorScores(s007Mean, s028);
            sv.ImpostorScoresUser7User29 = ManhDist.CalculateImpostorScores(s007Mean, s029);
            sv.ImpostorScoresUser7User30 = ManhDist.CalculateImpostorScores(s007Mean, s030);

            sv.ImpostorScoresUser7User31 = ManhDist.CalculateImpostorScores(s007Mean, s031);
            sv.ImpostorScoresUser7User32 = ManhDist.CalculateImpostorScores(s007Mean, s032);
            sv.ImpostorScoresUser7User33 = ManhDist.CalculateImpostorScores(s007Mean, s033);
            sv.ImpostorScoresUser7User34 = ManhDist.CalculateImpostorScores(s007Mean, s034);
            sv.ImpostorScoresUser7User35 = ManhDist.CalculateImpostorScores(s007Mean, s035);
            sv.ImpostorScoresUser7User36 = ManhDist.CalculateImpostorScores(s007Mean, s036);
            sv.ImpostorScoresUser7User37 = ManhDist.CalculateImpostorScores(s007Mean, s037);
            sv.ImpostorScoresUser7User38 = ManhDist.CalculateImpostorScores(s007Mean, s038);
            sv.ImpostorScoresUser7User39 = ManhDist.CalculateImpostorScores(s007Mean, s039);
            sv.ImpostorScoresUser7User40 = ManhDist.CalculateImpostorScores(s007Mean, s040);

            sv.ImpostorScoresUser7User41 = ManhDist.CalculateImpostorScores(s007Mean, s041);
            sv.ImpostorScoresUser7User42 = ManhDist.CalculateImpostorScores(s007Mean, s042);
            sv.ImpostorScoresUser7User43 = ManhDist.CalculateImpostorScores(s007Mean, s043);
            sv.ImpostorScoresUser7User44 = ManhDist.CalculateImpostorScores(s007Mean, s044);
            sv.ImpostorScoresUser7User45 = ManhDist.CalculateImpostorScores(s007Mean, s045);
            sv.ImpostorScoresUser7User46 = ManhDist.CalculateImpostorScores(s007Mean, s046);
            sv.ImpostorScoresUser7User47 = ManhDist.CalculateImpostorScores(s007Mean, s047);
            sv.ImpostorScoresUser7User48 = ManhDist.CalculateImpostorScores(s007Mean, s048);
            sv.ImpostorScoresUser7User49 = ManhDist.CalculateImpostorScores(s007Mean, s049);
            sv.ImpostorScoresUser7User50 = ManhDist.CalculateImpostorScores(s007Mean, s050);

            sv.ImpostorScoresUser7User51 = ManhDist.CalculateImpostorScores(s007Mean, s051);
            sv.ImpostorScoresUser7User52 = ManhDist.CalculateImpostorScores(s007Mean, s052);
            sv.ImpostorScoresUser7User53 = ManhDist.CalculateImpostorScores(s007Mean, s053);
            sv.ImpostorScoresUser7User54 = ManhDist.CalculateImpostorScores(s007Mean, s054);
            sv.ImpostorScoresUser7User55 = ManhDist.CalculateImpostorScores(s007Mean, s055);
            sv.ImpostorScoresUser7User56 = ManhDist.CalculateImpostorScores(s007Mean, s056);
            sv.ImpostorScoresUser7User57 = ManhDist.CalculateImpostorScores(s007Mean, s057);
            sv.ImpostorScoresUser7User58 = ManhDist.CalculateImpostorScores(s007Mean, s058);
            sv.ImpostorScoresUser7User59 = ManhDist.CalculateImpostorScores(s007Mean, s059);
            sv.ImpostorScoresUser7User60 = ManhDist.CalculateImpostorScores(s007Mean, s060);

            sv.ImpostorScoresUser7User61 = ManhDist.CalculateImpostorScores(s007Mean, s061);
            sv.ImpostorScoresUser7User62 = ManhDist.CalculateImpostorScores(s007Mean, s062);
            sv.ImpostorScoresUser7User63 = ManhDist.CalculateImpostorScores(s007Mean, s063);
            sv.ImpostorScoresUser7User64 = ManhDist.CalculateImpostorScores(s007Mean, s064);
            sv.ImpostorScoresUser7User65 = ManhDist.CalculateImpostorScores(s007Mean, s065);
            sv.ImpostorScoresUser7User66 = ManhDist.CalculateImpostorScores(s007Mean, s066);
            sv.ImpostorScoresUser7User67 = ManhDist.CalculateImpostorScores(s007Mean, s067);
            sv.ImpostorScoresUser7User68 = ManhDist.CalculateImpostorScores(s007Mean, s068);
            sv.ImpostorScoresUser7User69 = ManhDist.CalculateImpostorScores(s007Mean, s069);
            sv.ImpostorScoresUser7User70 = ManhDist.CalculateImpostorScores(s007Mean, s070);

            sv.ImpostorScoresUser7User71 = ManhDist.CalculateImpostorScores(s007Mean, s071);
            sv.ImpostorScoresUser7User72 = ManhDist.CalculateImpostorScores(s007Mean, s072);
            sv.ImpostorScoresUser7User73 = ManhDist.CalculateImpostorScores(s007Mean, s073);
            sv.ImpostorScoresUser7User74 = ManhDist.CalculateImpostorScores(s007Mean, s074);
            sv.ImpostorScoresUser7User75 = ManhDist.CalculateImpostorScores(s007Mean, s075);
            sv.ImpostorScoresUser7User76 = ManhDist.CalculateImpostorScores(s007Mean, s076);
            sv.ImpostorScoresUser7User77 = ManhDist.CalculateImpostorScores(s007Mean, s077);
            sv.ImpostorScoresUser7User78 = ManhDist.CalculateImpostorScores(s007Mean, s078);
            sv.ImpostorScoresUser7User79 = ManhDist.CalculateImpostorScores(s007Mean, s079);
            sv.ImpostorScoresUser7User80 = ManhDist.CalculateImpostorScores(s007Mean, s080);

            sv.ImpostorScoresUser7User81 = ManhDist.CalculateImpostorScores(s007Mean, s081);
            sv.ImpostorScoresUser7User82 = ManhDist.CalculateImpostorScores(s007Mean, s082);
            sv.ImpostorScoresUser7User83 = ManhDist.CalculateImpostorScores(s007Mean, s083);
            sv.ImpostorScoresUser7User84 = ManhDist.CalculateImpostorScores(s007Mean, s084);
            sv.ImpostorScoresUser7User85 = ManhDist.CalculateImpostorScores(s007Mean, s085);
            sv.ImpostorScoresUser7User86 = ManhDist.CalculateImpostorScores(s007Mean, s086);
            sv.ImpostorScoresUser7User87 = ManhDist.CalculateImpostorScores(s007Mean, s087);
            sv.ImpostorScoresUser7User88 = ManhDist.CalculateImpostorScores(s007Mean, s088);
            sv.ImpostorScoresUser7User89 = ManhDist.CalculateImpostorScores(s007Mean, s089);
            sv.ImpostorScoresUser7User90 = ManhDist.CalculateImpostorScores(s007Mean, s090);

            sv.ImpostorScoresUser7User91 = ManhDist.CalculateImpostorScores(s007Mean, s091);
            sv.ImpostorScoresUser7User92 = ManhDist.CalculateImpostorScores(s007Mean, s092);
            sv.ImpostorScoresUser7User93 = ManhDist.CalculateImpostorScores(s007Mean, s093);
            sv.ImpostorScoresUser7User94 = ManhDist.CalculateImpostorScores(s007Mean, s094);
            sv.ImpostorScoresUser7User95 = ManhDist.CalculateImpostorScores(s007Mean, s095);
            sv.ImpostorScoresUser7User96 = ManhDist.CalculateImpostorScores(s007Mean, s096);
            sv.ImpostorScoresUser7User97 = ManhDist.CalculateImpostorScores(s007Mean, s097);
            sv.ImpostorScoresUser7User98 = ManhDist.CalculateImpostorScores(s007Mean, s098);
            sv.ImpostorScoresUser7User99 = ManhDist.CalculateImpostorScores(s007Mean, s099);
            sv.ImpostorScoresUser7User100 = ManhDist.CalculateImpostorScores(s007Mean, s100);
            #endregion

            #region User 8 Impostor scores
            sv.ImpostorScoresUser8User1 = ManhDist.CalculateImpostorScores(s008Mean, s001);
            sv.ImpostorScoresUser8User2 = ManhDist.CalculateImpostorScores(s008Mean, s002);
            sv.ImpostorScoresUser8User3 = ManhDist.CalculateImpostorScores(s008Mean, s003);
            sv.ImpostorScoresUser8User4 = ManhDist.CalculateImpostorScores(s008Mean, s004);
            sv.ImpostorScoresUser8User5 = ManhDist.CalculateImpostorScores(s008Mean, s005);
            sv.ImpostorScoresUser8User6 = ManhDist.CalculateImpostorScores(s008Mean, s006);
            sv.ImpostorScoresUser8User7 = ManhDist.CalculateImpostorScores(s008Mean, s008);
            sv.ImpostorScoresUser8User9 = ManhDist.CalculateImpostorScores(s008Mean, s009);
            sv.ImpostorScoresUser8User10 = ManhDist.CalculateImpostorScores(s008Mean, s010);

            sv.ImpostorScoresUser8User11 = ManhDist.CalculateImpostorScores(s008Mean, s011);
            sv.ImpostorScoresUser8User12 = ManhDist.CalculateImpostorScores(s008Mean, s012);
            sv.ImpostorScoresUser8User13 = ManhDist.CalculateImpostorScores(s008Mean, s013);
            sv.ImpostorScoresUser8User14 = ManhDist.CalculateImpostorScores(s008Mean, s014);
            sv.ImpostorScoresUser8User15 = ManhDist.CalculateImpostorScores(s008Mean, s015);
            sv.ImpostorScoresUser8User16 = ManhDist.CalculateImpostorScores(s008Mean, s016);
            sv.ImpostorScoresUser8User17 = ManhDist.CalculateImpostorScores(s008Mean, s017);
            sv.ImpostorScoresUser8User18 = ManhDist.CalculateImpostorScores(s008Mean, s018);
            sv.ImpostorScoresUser8User19 = ManhDist.CalculateImpostorScores(s008Mean, s019);
            sv.ImpostorScoresUser8User20 = ManhDist.CalculateImpostorScores(s008Mean, s020);

            sv.ImpostorScoresUser8User21 = ManhDist.CalculateImpostorScores(s008Mean, s021);
            sv.ImpostorScoresUser8User22 = ManhDist.CalculateImpostorScores(s008Mean, s022);
            sv.ImpostorScoresUser8User23 = ManhDist.CalculateImpostorScores(s008Mean, s023);
            sv.ImpostorScoresUser8User24 = ManhDist.CalculateImpostorScores(s008Mean, s024);
            sv.ImpostorScoresUser8User25 = ManhDist.CalculateImpostorScores(s008Mean, s025);
            sv.ImpostorScoresUser8User26 = ManhDist.CalculateImpostorScores(s008Mean, s026);
            sv.ImpostorScoresUser8User27 = ManhDist.CalculateImpostorScores(s008Mean, s027);
            sv.ImpostorScoresUser8User28 = ManhDist.CalculateImpostorScores(s008Mean, s028);
            sv.ImpostorScoresUser8User29 = ManhDist.CalculateImpostorScores(s008Mean, s029);
            sv.ImpostorScoresUser8User30 = ManhDist.CalculateImpostorScores(s008Mean, s030);
                                           
            sv.ImpostorScoresUser8User31 = ManhDist.CalculateImpostorScores(s008Mean, s031);
            sv.ImpostorScoresUser8User32 = ManhDist.CalculateImpostorScores(s008Mean, s032);
            sv.ImpostorScoresUser8User33 = ManhDist.CalculateImpostorScores(s008Mean, s033);
            sv.ImpostorScoresUser8User34 = ManhDist.CalculateImpostorScores(s008Mean, s034);
            sv.ImpostorScoresUser8User35 = ManhDist.CalculateImpostorScores(s008Mean, s035);
            sv.ImpostorScoresUser8User36 = ManhDist.CalculateImpostorScores(s008Mean, s036);
            sv.ImpostorScoresUser8User37 = ManhDist.CalculateImpostorScores(s008Mean, s037);
            sv.ImpostorScoresUser8User38 = ManhDist.CalculateImpostorScores(s008Mean, s038);
            sv.ImpostorScoresUser8User39 = ManhDist.CalculateImpostorScores(s008Mean, s039);
            sv.ImpostorScoresUser8User40 = ManhDist.CalculateImpostorScores(s008Mean, s040);
                                           
            sv.ImpostorScoresUser8User41 = ManhDist.CalculateImpostorScores(s008Mean, s041);
            sv.ImpostorScoresUser8User42 = ManhDist.CalculateImpostorScores(s008Mean, s042);
            sv.ImpostorScoresUser8User43 = ManhDist.CalculateImpostorScores(s008Mean, s043);
            sv.ImpostorScoresUser8User44 = ManhDist.CalculateImpostorScores(s008Mean, s044);
            sv.ImpostorScoresUser8User45 = ManhDist.CalculateImpostorScores(s008Mean, s045);
            sv.ImpostorScoresUser8User46 = ManhDist.CalculateImpostorScores(s008Mean, s046);
            sv.ImpostorScoresUser8User47 = ManhDist.CalculateImpostorScores(s008Mean, s047);
            sv.ImpostorScoresUser8User48 = ManhDist.CalculateImpostorScores(s008Mean, s048);
            sv.ImpostorScoresUser8User49 = ManhDist.CalculateImpostorScores(s008Mean, s049);
            sv.ImpostorScoresUser8User50 = ManhDist.CalculateImpostorScores(s008Mean, s050);
                                           
            sv.ImpostorScoresUser8User51 = ManhDist.CalculateImpostorScores(s008Mean, s051);
            sv.ImpostorScoresUser8User52 = ManhDist.CalculateImpostorScores(s008Mean, s052);
            sv.ImpostorScoresUser8User53 = ManhDist.CalculateImpostorScores(s008Mean, s053);
            sv.ImpostorScoresUser8User54 = ManhDist.CalculateImpostorScores(s008Mean, s054);
            sv.ImpostorScoresUser8User55 = ManhDist.CalculateImpostorScores(s008Mean, s055);
            sv.ImpostorScoresUser8User56 = ManhDist.CalculateImpostorScores(s008Mean, s056);
            sv.ImpostorScoresUser8User57 = ManhDist.CalculateImpostorScores(s008Mean, s057);
            sv.ImpostorScoresUser8User58 = ManhDist.CalculateImpostorScores(s008Mean, s058);
            sv.ImpostorScoresUser8User59 = ManhDist.CalculateImpostorScores(s008Mean, s059);
            sv.ImpostorScoresUser8User60 = ManhDist.CalculateImpostorScores(s008Mean, s060);
                                           
            sv.ImpostorScoresUser8User61 = ManhDist.CalculateImpostorScores(s008Mean, s061);
            sv.ImpostorScoresUser8User62 = ManhDist.CalculateImpostorScores(s008Mean, s062);
            sv.ImpostorScoresUser8User63 = ManhDist.CalculateImpostorScores(s008Mean, s063);
            sv.ImpostorScoresUser8User64 = ManhDist.CalculateImpostorScores(s008Mean, s064);
            sv.ImpostorScoresUser8User65 = ManhDist.CalculateImpostorScores(s008Mean, s065);
            sv.ImpostorScoresUser8User66 = ManhDist.CalculateImpostorScores(s008Mean, s066);
            sv.ImpostorScoresUser8User67 = ManhDist.CalculateImpostorScores(s008Mean, s067);
            sv.ImpostorScoresUser8User68 = ManhDist.CalculateImpostorScores(s008Mean, s068);
            sv.ImpostorScoresUser8User69 = ManhDist.CalculateImpostorScores(s008Mean, s069);
            sv.ImpostorScoresUser8User70 = ManhDist.CalculateImpostorScores(s008Mean, s070);

            sv.ImpostorScoresUser8User71 = ManhDist.CalculateImpostorScores(s008Mean, s071);
            sv.ImpostorScoresUser8User72 = ManhDist.CalculateImpostorScores(s008Mean, s072);
            sv.ImpostorScoresUser8User73 = ManhDist.CalculateImpostorScores(s008Mean, s073);
            sv.ImpostorScoresUser8User74 = ManhDist.CalculateImpostorScores(s008Mean, s074);
            sv.ImpostorScoresUser8User75 = ManhDist.CalculateImpostorScores(s008Mean, s075);
            sv.ImpostorScoresUser8User76 = ManhDist.CalculateImpostorScores(s008Mean, s076);
            sv.ImpostorScoresUser8User77 = ManhDist.CalculateImpostorScores(s008Mean, s077);
            sv.ImpostorScoresUser8User78 = ManhDist.CalculateImpostorScores(s008Mean, s078);
            sv.ImpostorScoresUser8User79 = ManhDist.CalculateImpostorScores(s008Mean, s079);
            sv.ImpostorScoresUser8User80 = ManhDist.CalculateImpostorScores(s008Mean, s080);
                                           
            sv.ImpostorScoresUser8User81 = ManhDist.CalculateImpostorScores(s008Mean, s081);
            sv.ImpostorScoresUser8User82 = ManhDist.CalculateImpostorScores(s008Mean, s082);
            sv.ImpostorScoresUser8User83 = ManhDist.CalculateImpostorScores(s008Mean, s083);
            sv.ImpostorScoresUser8User84 = ManhDist.CalculateImpostorScores(s008Mean, s084);
            sv.ImpostorScoresUser8User85 = ManhDist.CalculateImpostorScores(s008Mean, s085);
            sv.ImpostorScoresUser8User86 = ManhDist.CalculateImpostorScores(s008Mean, s086);
            sv.ImpostorScoresUser8User87 = ManhDist.CalculateImpostorScores(s008Mean, s087);
            sv.ImpostorScoresUser8User88 = ManhDist.CalculateImpostorScores(s008Mean, s088);
            sv.ImpostorScoresUser8User89 = ManhDist.CalculateImpostorScores(s008Mean, s089);
            sv.ImpostorScoresUser8User90 = ManhDist.CalculateImpostorScores(s008Mean, s090);
                                           
            sv.ImpostorScoresUser8User91 = ManhDist.CalculateImpostorScores(s008Mean, s091);
            sv.ImpostorScoresUser8User92 = ManhDist.CalculateImpostorScores(s008Mean, s092);
            sv.ImpostorScoresUser8User93 = ManhDist.CalculateImpostorScores(s008Mean, s093);
            sv.ImpostorScoresUser8User94 = ManhDist.CalculateImpostorScores(s008Mean, s094);
            sv.ImpostorScoresUser8User95 = ManhDist.CalculateImpostorScores(s008Mean, s095);
            sv.ImpostorScoresUser8User96 = ManhDist.CalculateImpostorScores(s008Mean, s096);
            sv.ImpostorScoresUser8User97 = ManhDist.CalculateImpostorScores(s008Mean, s097);
            sv.ImpostorScoresUser8User98 = ManhDist.CalculateImpostorScores(s008Mean, s098);
            sv.ImpostorScoresUser8User99 = ManhDist.CalculateImpostorScores(s008Mean, s099);
            sv.ImpostorScoresUser8User100 = ManhDist.CalculateImpostorScores(s008Mean, s100);
            #endregion

            #region User 9 Impostor scores
            sv.ImpostorScoresUser9User1 = ManhDist.CalculateImpostorScores(s009Mean, s001);
            sv.ImpostorScoresUser9User2 = ManhDist.CalculateImpostorScores(s009Mean, s002);
            sv.ImpostorScoresUser9User3 = ManhDist.CalculateImpostorScores(s009Mean, s003);
            sv.ImpostorScoresUser9User4 = ManhDist.CalculateImpostorScores(s009Mean, s004);
            sv.ImpostorScoresUser9User5 = ManhDist.CalculateImpostorScores(s009Mean, s005);
            sv.ImpostorScoresUser9User6 = ManhDist.CalculateImpostorScores(s009Mean, s006);
            sv.ImpostorScoresUser9User7 = ManhDist.CalculateImpostorScores(s009Mean, s007);
            sv.ImpostorScoresUser9User8 = ManhDist.CalculateImpostorScores(s009Mean, s008);
            sv.ImpostorScoresUser9User10 = ManhDist.CalculateImpostorScores(s009Mean, s010);

            sv.ImpostorScoresUser9User11 = ManhDist.CalculateImpostorScores(s009Mean, s011);
            sv.ImpostorScoresUser9User12 = ManhDist.CalculateImpostorScores(s009Mean, s012);
            sv.ImpostorScoresUser9User13 = ManhDist.CalculateImpostorScores(s009Mean, s013);
            sv.ImpostorScoresUser9User14 = ManhDist.CalculateImpostorScores(s009Mean, s014);
            sv.ImpostorScoresUser9User15 = ManhDist.CalculateImpostorScores(s009Mean, s015);
            sv.ImpostorScoresUser9User16 = ManhDist.CalculateImpostorScores(s009Mean, s016);
            sv.ImpostorScoresUser9User17 = ManhDist.CalculateImpostorScores(s009Mean, s017);
            sv.ImpostorScoresUser9User18 = ManhDist.CalculateImpostorScores(s009Mean, s018);
            sv.ImpostorScoresUser9User19 = ManhDist.CalculateImpostorScores(s009Mean, s019);
            sv.ImpostorScoresUser9User20 = ManhDist.CalculateImpostorScores(s009Mean, s020);

            sv.ImpostorScoresUser9User21 = ManhDist.CalculateImpostorScores(s009Mean, s021);
            sv.ImpostorScoresUser9User22 = ManhDist.CalculateImpostorScores(s009Mean, s022);
            sv.ImpostorScoresUser9User23 = ManhDist.CalculateImpostorScores(s009Mean, s023);
            sv.ImpostorScoresUser9User24 = ManhDist.CalculateImpostorScores(s009Mean, s024);
            sv.ImpostorScoresUser9User25 = ManhDist.CalculateImpostorScores(s009Mean, s025);
            sv.ImpostorScoresUser9User26 = ManhDist.CalculateImpostorScores(s009Mean, s026);
            sv.ImpostorScoresUser9User27 = ManhDist.CalculateImpostorScores(s009Mean, s027);
            sv.ImpostorScoresUser9User28 = ManhDist.CalculateImpostorScores(s009Mean, s028);
            sv.ImpostorScoresUser9User29 = ManhDist.CalculateImpostorScores(s009Mean, s029);
            sv.ImpostorScoresUser9User30 = ManhDist.CalculateImpostorScores(s009Mean, s030);

            sv.ImpostorScoresUser9User31 = ManhDist.CalculateImpostorScores(s009Mean, s031);
            sv.ImpostorScoresUser9User32 = ManhDist.CalculateImpostorScores(s009Mean, s032);
            sv.ImpostorScoresUser9User33 = ManhDist.CalculateImpostorScores(s009Mean, s033);
            sv.ImpostorScoresUser9User34 = ManhDist.CalculateImpostorScores(s009Mean, s034);
            sv.ImpostorScoresUser9User35 = ManhDist.CalculateImpostorScores(s009Mean, s035);
            sv.ImpostorScoresUser9User36 = ManhDist.CalculateImpostorScores(s009Mean, s036);
            sv.ImpostorScoresUser9User37 = ManhDist.CalculateImpostorScores(s009Mean, s037);
            sv.ImpostorScoresUser9User38 = ManhDist.CalculateImpostorScores(s009Mean, s038);
            sv.ImpostorScoresUser9User39 = ManhDist.CalculateImpostorScores(s009Mean, s039);
            sv.ImpostorScoresUser9User40 = ManhDist.CalculateImpostorScores(s009Mean, s040);

            sv.ImpostorScoresUser9User41 = ManhDist.CalculateImpostorScores(s009Mean, s041);
            sv.ImpostorScoresUser9User42 = ManhDist.CalculateImpostorScores(s009Mean, s042);
            sv.ImpostorScoresUser9User43 = ManhDist.CalculateImpostorScores(s009Mean, s043);
            sv.ImpostorScoresUser9User44 = ManhDist.CalculateImpostorScores(s009Mean, s044);
            sv.ImpostorScoresUser9User45 = ManhDist.CalculateImpostorScores(s009Mean, s045);
            sv.ImpostorScoresUser9User46 = ManhDist.CalculateImpostorScores(s009Mean, s046);
            sv.ImpostorScoresUser9User47 = ManhDist.CalculateImpostorScores(s009Mean, s047);
            sv.ImpostorScoresUser9User48 = ManhDist.CalculateImpostorScores(s009Mean, s048);
            sv.ImpostorScoresUser9User49 = ManhDist.CalculateImpostorScores(s009Mean, s049);
            sv.ImpostorScoresUser9User50 = ManhDist.CalculateImpostorScores(s009Mean, s050);

            sv.ImpostorScoresUser9User51 = ManhDist.CalculateImpostorScores(s009Mean, s051);
            sv.ImpostorScoresUser9User52 = ManhDist.CalculateImpostorScores(s009Mean, s052);
            sv.ImpostorScoresUser9User53 = ManhDist.CalculateImpostorScores(s009Mean, s053);
            sv.ImpostorScoresUser9User54 = ManhDist.CalculateImpostorScores(s009Mean, s054);
            sv.ImpostorScoresUser9User55 = ManhDist.CalculateImpostorScores(s009Mean, s055);
            sv.ImpostorScoresUser9User56 = ManhDist.CalculateImpostorScores(s009Mean, s056);
            sv.ImpostorScoresUser9User57 = ManhDist.CalculateImpostorScores(s009Mean, s057);
            sv.ImpostorScoresUser9User58 = ManhDist.CalculateImpostorScores(s009Mean, s058);
            sv.ImpostorScoresUser9User59 = ManhDist.CalculateImpostorScores(s009Mean, s059);
            sv.ImpostorScoresUser9User60 = ManhDist.CalculateImpostorScores(s009Mean, s060);

            sv.ImpostorScoresUser9User61 = ManhDist.CalculateImpostorScores(s009Mean, s061);
            sv.ImpostorScoresUser9User62 = ManhDist.CalculateImpostorScores(s009Mean, s062);
            sv.ImpostorScoresUser9User63 = ManhDist.CalculateImpostorScores(s009Mean, s063);
            sv.ImpostorScoresUser9User64 = ManhDist.CalculateImpostorScores(s009Mean, s064);
            sv.ImpostorScoresUser9User65 = ManhDist.CalculateImpostorScores(s009Mean, s065);
            sv.ImpostorScoresUser9User66 = ManhDist.CalculateImpostorScores(s009Mean, s066);
            sv.ImpostorScoresUser9User67 = ManhDist.CalculateImpostorScores(s009Mean, s067);
            sv.ImpostorScoresUser9User68 = ManhDist.CalculateImpostorScores(s009Mean, s068);
            sv.ImpostorScoresUser9User69 = ManhDist.CalculateImpostorScores(s009Mean, s069);
            sv.ImpostorScoresUser9User70 = ManhDist.CalculateImpostorScores(s009Mean, s070);

            sv.ImpostorScoresUser9User71 = ManhDist.CalculateImpostorScores(s009Mean, s071);
            sv.ImpostorScoresUser9User72 = ManhDist.CalculateImpostorScores(s009Mean, s072);
            sv.ImpostorScoresUser9User73 = ManhDist.CalculateImpostorScores(s009Mean, s073);
            sv.ImpostorScoresUser9User74 = ManhDist.CalculateImpostorScores(s009Mean, s074);
            sv.ImpostorScoresUser9User75 = ManhDist.CalculateImpostorScores(s009Mean, s075);
            sv.ImpostorScoresUser9User76 = ManhDist.CalculateImpostorScores(s009Mean, s076);
            sv.ImpostorScoresUser9User77 = ManhDist.CalculateImpostorScores(s009Mean, s077);
            sv.ImpostorScoresUser9User78 = ManhDist.CalculateImpostorScores(s009Mean, s078);
            sv.ImpostorScoresUser9User79 = ManhDist.CalculateImpostorScores(s009Mean, s079);
            sv.ImpostorScoresUser9User80 = ManhDist.CalculateImpostorScores(s009Mean, s080);

            sv.ImpostorScoresUser9User81 = ManhDist.CalculateImpostorScores(s009Mean, s081);
            sv.ImpostorScoresUser9User82 = ManhDist.CalculateImpostorScores(s009Mean, s082);
            sv.ImpostorScoresUser9User83 = ManhDist.CalculateImpostorScores(s009Mean, s083);
            sv.ImpostorScoresUser9User84 = ManhDist.CalculateImpostorScores(s009Mean, s084);
            sv.ImpostorScoresUser9User85 = ManhDist.CalculateImpostorScores(s009Mean, s085);
            sv.ImpostorScoresUser9User86 = ManhDist.CalculateImpostorScores(s009Mean, s086);
            sv.ImpostorScoresUser9User87 = ManhDist.CalculateImpostorScores(s009Mean, s087);
            sv.ImpostorScoresUser9User88 = ManhDist.CalculateImpostorScores(s009Mean, s088);
            sv.ImpostorScoresUser9User89 = ManhDist.CalculateImpostorScores(s009Mean, s089);
            sv.ImpostorScoresUser9User90 = ManhDist.CalculateImpostorScores(s009Mean, s090);

            sv.ImpostorScoresUser9User91 = ManhDist.CalculateImpostorScores(s009Mean, s091);
            sv.ImpostorScoresUser9User92 = ManhDist.CalculateImpostorScores(s009Mean, s092);
            sv.ImpostorScoresUser9User93 = ManhDist.CalculateImpostorScores(s009Mean, s093);
            sv.ImpostorScoresUser9User94 = ManhDist.CalculateImpostorScores(s009Mean, s094);
            sv.ImpostorScoresUser9User95 = ManhDist.CalculateImpostorScores(s009Mean, s095);
            sv.ImpostorScoresUser9User96 = ManhDist.CalculateImpostorScores(s009Mean, s096);
            sv.ImpostorScoresUser9User97 = ManhDist.CalculateImpostorScores(s009Mean, s097);
            sv.ImpostorScoresUser9User98 = ManhDist.CalculateImpostorScores(s009Mean, s098);
            sv.ImpostorScoresUser9User99 = ManhDist.CalculateImpostorScores(s009Mean, s099);
            sv.ImpostorScoresUser9User100 = ManhDist.CalculateImpostorScores(s009Mean, s100);
            #endregion

            #region User 10 Impostor scores
            sv.ImpostorScoresUser10User1 = ManhDist.CalculateImpostorScores(s010Mean, s001);
            sv.ImpostorScoresUser10User2 = ManhDist.CalculateImpostorScores(s010Mean, s002);
            sv.ImpostorScoresUser10User3 = ManhDist.CalculateImpostorScores(s010Mean, s003);
            sv.ImpostorScoresUser10User4 = ManhDist.CalculateImpostorScores(s010Mean, s004);
            sv.ImpostorScoresUser10User5 = ManhDist.CalculateImpostorScores(s010Mean, s005);
            sv.ImpostorScoresUser10User6 = ManhDist.CalculateImpostorScores(s010Mean, s006);
            sv.ImpostorScoresUser10User7 = ManhDist.CalculateImpostorScores(s010Mean, s007);
            sv.ImpostorScoresUser10User8 = ManhDist.CalculateImpostorScores(s010Mean, s008);
            sv.ImpostorScoresUser10User9 = ManhDist.CalculateImpostorScores(s010Mean, s009);

            sv.ImpostorScoresUser10User11 = ManhDist.CalculateImpostorScores(s010Mean, s011);
            sv.ImpostorScoresUser10User12 = ManhDist.CalculateImpostorScores(s010Mean, s012);
            sv.ImpostorScoresUser10User13 = ManhDist.CalculateImpostorScores(s010Mean, s013);
            sv.ImpostorScoresUser10User14 = ManhDist.CalculateImpostorScores(s010Mean, s014);
            sv.ImpostorScoresUser10User15 = ManhDist.CalculateImpostorScores(s010Mean, s015);
            sv.ImpostorScoresUser10User16 = ManhDist.CalculateImpostorScores(s010Mean, s016);
            sv.ImpostorScoresUser10User17 = ManhDist.CalculateImpostorScores(s010Mean, s017);
            sv.ImpostorScoresUser10User18 = ManhDist.CalculateImpostorScores(s010Mean, s018);
            sv.ImpostorScoresUser10User19 = ManhDist.CalculateImpostorScores(s010Mean, s019);
            sv.ImpostorScoresUser10User20 = ManhDist.CalculateImpostorScores(s010Mean, s020);

            sv.ImpostorScoresUser10User21 = ManhDist.CalculateImpostorScores(s010Mean, s021);
            sv.ImpostorScoresUser10User22 = ManhDist.CalculateImpostorScores(s010Mean, s022);
            sv.ImpostorScoresUser10User23 = ManhDist.CalculateImpostorScores(s010Mean, s023);
            sv.ImpostorScoresUser10User24 = ManhDist.CalculateImpostorScores(s010Mean, s024);
            sv.ImpostorScoresUser10User25 = ManhDist.CalculateImpostorScores(s010Mean, s025);
            sv.ImpostorScoresUser10User26 = ManhDist.CalculateImpostorScores(s010Mean, s026);
            sv.ImpostorScoresUser10User27 = ManhDist.CalculateImpostorScores(s010Mean, s027);
            sv.ImpostorScoresUser10User28 = ManhDist.CalculateImpostorScores(s010Mean, s028);
            sv.ImpostorScoresUser10User29 = ManhDist.CalculateImpostorScores(s010Mean, s029);
            sv.ImpostorScoresUser10User30 = ManhDist.CalculateImpostorScores(s010Mean, s030);

            sv.ImpostorScoresUser10User31 = ManhDist.CalculateImpostorScores(s010Mean, s031);
            sv.ImpostorScoresUser10User32 = ManhDist.CalculateImpostorScores(s010Mean, s032);
            sv.ImpostorScoresUser10User33 = ManhDist.CalculateImpostorScores(s010Mean, s033);
            sv.ImpostorScoresUser10User34 = ManhDist.CalculateImpostorScores(s010Mean, s034);
            sv.ImpostorScoresUser10User35 = ManhDist.CalculateImpostorScores(s010Mean, s035);
            sv.ImpostorScoresUser10User36 = ManhDist.CalculateImpostorScores(s010Mean, s036);
            sv.ImpostorScoresUser10User37 = ManhDist.CalculateImpostorScores(s010Mean, s037);
            sv.ImpostorScoresUser10User38 = ManhDist.CalculateImpostorScores(s010Mean, s038);
            sv.ImpostorScoresUser10User39 = ManhDist.CalculateImpostorScores(s010Mean, s039);
            sv.ImpostorScoresUser10User40 = ManhDist.CalculateImpostorScores(s010Mean, s040);

            sv.ImpostorScoresUser10User41 = ManhDist.CalculateImpostorScores(s010Mean, s041);
            sv.ImpostorScoresUser10User42 = ManhDist.CalculateImpostorScores(s010Mean, s042);
            sv.ImpostorScoresUser10User43 = ManhDist.CalculateImpostorScores(s010Mean, s043);
            sv.ImpostorScoresUser10User44 = ManhDist.CalculateImpostorScores(s010Mean, s044);
            sv.ImpostorScoresUser10User45 = ManhDist.CalculateImpostorScores(s010Mean, s045);
            sv.ImpostorScoresUser10User46 = ManhDist.CalculateImpostorScores(s010Mean, s046);
            sv.ImpostorScoresUser10User47 = ManhDist.CalculateImpostorScores(s010Mean, s047);
            sv.ImpostorScoresUser10User48 = ManhDist.CalculateImpostorScores(s010Mean, s048);
            sv.ImpostorScoresUser10User49 = ManhDist.CalculateImpostorScores(s010Mean, s049);
            sv.ImpostorScoresUser10User50 = ManhDist.CalculateImpostorScores(s010Mean, s050);

            sv.ImpostorScoresUser10User51 = ManhDist.CalculateImpostorScores(s010Mean, s051);
            sv.ImpostorScoresUser10User52 = ManhDist.CalculateImpostorScores(s010Mean, s052);
            sv.ImpostorScoresUser10User53 = ManhDist.CalculateImpostorScores(s010Mean, s053);
            sv.ImpostorScoresUser10User54 = ManhDist.CalculateImpostorScores(s010Mean, s054);
            sv.ImpostorScoresUser10User55 = ManhDist.CalculateImpostorScores(s010Mean, s055);
            sv.ImpostorScoresUser10User56 = ManhDist.CalculateImpostorScores(s010Mean, s056);
            sv.ImpostorScoresUser10User57 = ManhDist.CalculateImpostorScores(s010Mean, s057);
            sv.ImpostorScoresUser10User58 = ManhDist.CalculateImpostorScores(s010Mean, s058);
            sv.ImpostorScoresUser10User59 = ManhDist.CalculateImpostorScores(s010Mean, s059);
            sv.ImpostorScoresUser10User60 = ManhDist.CalculateImpostorScores(s010Mean, s060);

            sv.ImpostorScoresUser10User61 = ManhDist.CalculateImpostorScores(s010Mean, s061);
            sv.ImpostorScoresUser10User62 = ManhDist.CalculateImpostorScores(s010Mean, s062);
            sv.ImpostorScoresUser10User63 = ManhDist.CalculateImpostorScores(s010Mean, s063);
            sv.ImpostorScoresUser10User64 = ManhDist.CalculateImpostorScores(s010Mean, s064);
            sv.ImpostorScoresUser10User65 = ManhDist.CalculateImpostorScores(s010Mean, s065);
            sv.ImpostorScoresUser10User66 = ManhDist.CalculateImpostorScores(s010Mean, s066);
            sv.ImpostorScoresUser10User67 = ManhDist.CalculateImpostorScores(s010Mean, s067);
            sv.ImpostorScoresUser10User68 = ManhDist.CalculateImpostorScores(s010Mean, s068);
            sv.ImpostorScoresUser10User69 = ManhDist.CalculateImpostorScores(s010Mean, s069);
            sv.ImpostorScoresUser10User70 = ManhDist.CalculateImpostorScores(s010Mean, s070);

            sv.ImpostorScoresUser10User71 = ManhDist.CalculateImpostorScores(s010Mean, s071);
            sv.ImpostorScoresUser10User72 = ManhDist.CalculateImpostorScores(s010Mean, s072);
            sv.ImpostorScoresUser10User73 = ManhDist.CalculateImpostorScores(s010Mean, s073);
            sv.ImpostorScoresUser10User74 = ManhDist.CalculateImpostorScores(s010Mean, s074);
            sv.ImpostorScoresUser10User75 = ManhDist.CalculateImpostorScores(s010Mean, s075);
            sv.ImpostorScoresUser10User76 = ManhDist.CalculateImpostorScores(s010Mean, s076);
            sv.ImpostorScoresUser10User77 = ManhDist.CalculateImpostorScores(s010Mean, s077);
            sv.ImpostorScoresUser10User78 = ManhDist.CalculateImpostorScores(s010Mean, s078);
            sv.ImpostorScoresUser10User79 = ManhDist.CalculateImpostorScores(s010Mean, s079);
            sv.ImpostorScoresUser10User80 = ManhDist.CalculateImpostorScores(s010Mean, s080);

            sv.ImpostorScoresUser10User81 = ManhDist.CalculateImpostorScores(s010Mean, s081);
            sv.ImpostorScoresUser10User82 = ManhDist.CalculateImpostorScores(s010Mean, s082);
            sv.ImpostorScoresUser10User83 = ManhDist.CalculateImpostorScores(s010Mean, s083);
            sv.ImpostorScoresUser10User84 = ManhDist.CalculateImpostorScores(s010Mean, s084);
            sv.ImpostorScoresUser10User85 = ManhDist.CalculateImpostorScores(s010Mean, s085);
            sv.ImpostorScoresUser10User86 = ManhDist.CalculateImpostorScores(s010Mean, s086);
            sv.ImpostorScoresUser10User87 = ManhDist.CalculateImpostorScores(s010Mean, s087);
            sv.ImpostorScoresUser10User88 = ManhDist.CalculateImpostorScores(s010Mean, s088);
            sv.ImpostorScoresUser10User89 = ManhDist.CalculateImpostorScores(s010Mean, s089);
            sv.ImpostorScoresUser10User90 = ManhDist.CalculateImpostorScores(s010Mean, s090);

            sv.ImpostorScoresUser10User91 = ManhDist.CalculateImpostorScores(s010Mean, s091);
            sv.ImpostorScoresUser10User92 = ManhDist.CalculateImpostorScores(s010Mean, s092);
            sv.ImpostorScoresUser10User93 = ManhDist.CalculateImpostorScores(s010Mean, s093);
            sv.ImpostorScoresUser10User94 = ManhDist.CalculateImpostorScores(s010Mean, s094);
            sv.ImpostorScoresUser10User95 = ManhDist.CalculateImpostorScores(s010Mean, s095);
            sv.ImpostorScoresUser10User96 = ManhDist.CalculateImpostorScores(s010Mean, s096);
            sv.ImpostorScoresUser10User97 = ManhDist.CalculateImpostorScores(s010Mean, s097);
            sv.ImpostorScoresUser10User98 = ManhDist.CalculateImpostorScores(s010Mean, s098);
            sv.ImpostorScoresUser10User99 = ManhDist.CalculateImpostorScores(s010Mean, s099);
            sv.ImpostorScoresUser10User100 = ManhDist.CalculateImpostorScores(s010Mean, s100);
            #endregion

            #region User 11 Impostor scores
            sv.ImpostorScoresUser11User1 = ManhDist.CalculateImpostorScores(s011Mean, s001);
            sv.ImpostorScoresUser11User2 = ManhDist.CalculateImpostorScores(s011Mean, s002);
            sv.ImpostorScoresUser11User3 = ManhDist.CalculateImpostorScores(s011Mean, s003);
            sv.ImpostorScoresUser11User4 = ManhDist.CalculateImpostorScores(s011Mean, s004);
            sv.ImpostorScoresUser11User5 = ManhDist.CalculateImpostorScores(s011Mean, s005);
            sv.ImpostorScoresUser11User6 = ManhDist.CalculateImpostorScores(s011Mean, s006);
            sv.ImpostorScoresUser11User7 = ManhDist.CalculateImpostorScores(s011Mean, s007);
            sv.ImpostorScoresUser11User8 = ManhDist.CalculateImpostorScores(s011Mean, s008);
            sv.ImpostorScoresUser11User9 = ManhDist.CalculateImpostorScores(s011Mean, s009);
            sv.ImpostorScoresUser11User10 = ManhDist.CalculateImpostorScores(s011Mean, s010);

            sv.ImpostorScoresUser11User12 = ManhDist.CalculateImpostorScores(s011Mean, s012);
            sv.ImpostorScoresUser11User13 = ManhDist.CalculateImpostorScores(s011Mean, s013);
            sv.ImpostorScoresUser11User14 = ManhDist.CalculateImpostorScores(s011Mean, s014);
            sv.ImpostorScoresUser11User15 = ManhDist.CalculateImpostorScores(s011Mean, s015);
            sv.ImpostorScoresUser11User16 = ManhDist.CalculateImpostorScores(s011Mean, s016);
            sv.ImpostorScoresUser11User17 = ManhDist.CalculateImpostorScores(s011Mean, s017);
            sv.ImpostorScoresUser11User18 = ManhDist.CalculateImpostorScores(s011Mean, s018);
            sv.ImpostorScoresUser11User19 = ManhDist.CalculateImpostorScores(s011Mean, s019);
            sv.ImpostorScoresUser11User20 = ManhDist.CalculateImpostorScores(s011Mean, s020);

            sv.ImpostorScoresUser11User21 = ManhDist.CalculateImpostorScores(s011Mean, s021);
            sv.ImpostorScoresUser11User22 = ManhDist.CalculateImpostorScores(s011Mean, s022);
            sv.ImpostorScoresUser11User23 = ManhDist.CalculateImpostorScores(s011Mean, s023);
            sv.ImpostorScoresUser11User24 = ManhDist.CalculateImpostorScores(s011Mean, s024);
            sv.ImpostorScoresUser11User25 = ManhDist.CalculateImpostorScores(s011Mean, s025);
            sv.ImpostorScoresUser11User26 = ManhDist.CalculateImpostorScores(s011Mean, s026);
            sv.ImpostorScoresUser11User27 = ManhDist.CalculateImpostorScores(s011Mean, s027);
            sv.ImpostorScoresUser11User28 = ManhDist.CalculateImpostorScores(s011Mean, s028);
            sv.ImpostorScoresUser11User29 = ManhDist.CalculateImpostorScores(s011Mean, s029);
            sv.ImpostorScoresUser11User30 = ManhDist.CalculateImpostorScores(s011Mean, s030);

            sv.ImpostorScoresUser11User31 = ManhDist.CalculateImpostorScores(s011Mean, s031);
            sv.ImpostorScoresUser11User32 = ManhDist.CalculateImpostorScores(s011Mean, s032);
            sv.ImpostorScoresUser11User33 = ManhDist.CalculateImpostorScores(s011Mean, s033);
            sv.ImpostorScoresUser11User34 = ManhDist.CalculateImpostorScores(s011Mean, s034);
            sv.ImpostorScoresUser11User35 = ManhDist.CalculateImpostorScores(s011Mean, s035);
            sv.ImpostorScoresUser11User36 = ManhDist.CalculateImpostorScores(s011Mean, s036);
            sv.ImpostorScoresUser11User37 = ManhDist.CalculateImpostorScores(s011Mean, s037);
            sv.ImpostorScoresUser11User38 = ManhDist.CalculateImpostorScores(s011Mean, s038);
            sv.ImpostorScoresUser11User39 = ManhDist.CalculateImpostorScores(s011Mean, s039);
            sv.ImpostorScoresUser11User40 = ManhDist.CalculateImpostorScores(s011Mean, s040);

            sv.ImpostorScoresUser11User41 = ManhDist.CalculateImpostorScores(s011Mean, s041);
            sv.ImpostorScoresUser11User42 = ManhDist.CalculateImpostorScores(s011Mean, s042);
            sv.ImpostorScoresUser11User43 = ManhDist.CalculateImpostorScores(s011Mean, s043);
            sv.ImpostorScoresUser11User44 = ManhDist.CalculateImpostorScores(s011Mean, s044);
            sv.ImpostorScoresUser11User45 = ManhDist.CalculateImpostorScores(s011Mean, s045);
            sv.ImpostorScoresUser11User46 = ManhDist.CalculateImpostorScores(s011Mean, s046);
            sv.ImpostorScoresUser11User47 = ManhDist.CalculateImpostorScores(s011Mean, s047);
            sv.ImpostorScoresUser11User48 = ManhDist.CalculateImpostorScores(s011Mean, s048);
            sv.ImpostorScoresUser11User49 = ManhDist.CalculateImpostorScores(s011Mean, s049);
            sv.ImpostorScoresUser11User50 = ManhDist.CalculateImpostorScores(s011Mean, s050);

            sv.ImpostorScoresUser11User51 = ManhDist.CalculateImpostorScores(s011Mean, s051);
            sv.ImpostorScoresUser11User52 = ManhDist.CalculateImpostorScores(s011Mean, s052);
            sv.ImpostorScoresUser11User53 = ManhDist.CalculateImpostorScores(s011Mean, s053);
            sv.ImpostorScoresUser11User54 = ManhDist.CalculateImpostorScores(s011Mean, s054);
            sv.ImpostorScoresUser11User55 = ManhDist.CalculateImpostorScores(s011Mean, s055);
            sv.ImpostorScoresUser11User56 = ManhDist.CalculateImpostorScores(s011Mean, s056);
            sv.ImpostorScoresUser11User57 = ManhDist.CalculateImpostorScores(s011Mean, s057);
            sv.ImpostorScoresUser11User58 = ManhDist.CalculateImpostorScores(s011Mean, s058);
            sv.ImpostorScoresUser11User59 = ManhDist.CalculateImpostorScores(s011Mean, s059);
            sv.ImpostorScoresUser11User60 = ManhDist.CalculateImpostorScores(s011Mean, s060);

            sv.ImpostorScoresUser11User61 = ManhDist.CalculateImpostorScores(s011Mean, s061);
            sv.ImpostorScoresUser11User62 = ManhDist.CalculateImpostorScores(s011Mean, s062);
            sv.ImpostorScoresUser11User63 = ManhDist.CalculateImpostorScores(s011Mean, s063);
            sv.ImpostorScoresUser11User64 = ManhDist.CalculateImpostorScores(s011Mean, s064);
            sv.ImpostorScoresUser11User65 = ManhDist.CalculateImpostorScores(s011Mean, s065);
            sv.ImpostorScoresUser11User66 = ManhDist.CalculateImpostorScores(s011Mean, s066);
            sv.ImpostorScoresUser11User67 = ManhDist.CalculateImpostorScores(s011Mean, s067);
            sv.ImpostorScoresUser11User68 = ManhDist.CalculateImpostorScores(s011Mean, s068);
            sv.ImpostorScoresUser11User69 = ManhDist.CalculateImpostorScores(s011Mean, s069);
            sv.ImpostorScoresUser11User70 = ManhDist.CalculateImpostorScores(s011Mean, s070);

            sv.ImpostorScoresUser11User71 = ManhDist.CalculateImpostorScores(s011Mean, s071);
            sv.ImpostorScoresUser11User72 = ManhDist.CalculateImpostorScores(s011Mean, s072);
            sv.ImpostorScoresUser11User73 = ManhDist.CalculateImpostorScores(s011Mean, s073);
            sv.ImpostorScoresUser11User74 = ManhDist.CalculateImpostorScores(s011Mean, s074);
            sv.ImpostorScoresUser11User75 = ManhDist.CalculateImpostorScores(s011Mean, s075);
            sv.ImpostorScoresUser11User76 = ManhDist.CalculateImpostorScores(s011Mean, s076);
            sv.ImpostorScoresUser11User77 = ManhDist.CalculateImpostorScores(s011Mean, s077);
            sv.ImpostorScoresUser11User78 = ManhDist.CalculateImpostorScores(s011Mean, s078);
            sv.ImpostorScoresUser11User79 = ManhDist.CalculateImpostorScores(s011Mean, s079);
            sv.ImpostorScoresUser11User80 = ManhDist.CalculateImpostorScores(s011Mean, s080);

            sv.ImpostorScoresUser11User81 = ManhDist.CalculateImpostorScores(s011Mean, s081);
            sv.ImpostorScoresUser11User82 = ManhDist.CalculateImpostorScores(s011Mean, s082);
            sv.ImpostorScoresUser11User83 = ManhDist.CalculateImpostorScores(s011Mean, s083);
            sv.ImpostorScoresUser11User84 = ManhDist.CalculateImpostorScores(s011Mean, s084);
            sv.ImpostorScoresUser11User85 = ManhDist.CalculateImpostorScores(s011Mean, s085);
            sv.ImpostorScoresUser11User86 = ManhDist.CalculateImpostorScores(s011Mean, s086);
            sv.ImpostorScoresUser11User87 = ManhDist.CalculateImpostorScores(s011Mean, s087);
            sv.ImpostorScoresUser11User88 = ManhDist.CalculateImpostorScores(s011Mean, s088);
            sv.ImpostorScoresUser11User89 = ManhDist.CalculateImpostorScores(s011Mean, s089);
            sv.ImpostorScoresUser11User90 = ManhDist.CalculateImpostorScores(s011Mean, s090);

            sv.ImpostorScoresUser11User91 = ManhDist.CalculateImpostorScores(s011Mean, s091);
            sv.ImpostorScoresUser11User92 = ManhDist.CalculateImpostorScores(s011Mean, s092);
            sv.ImpostorScoresUser11User93 = ManhDist.CalculateImpostorScores(s011Mean, s093);
            sv.ImpostorScoresUser11User94 = ManhDist.CalculateImpostorScores(s011Mean, s094);
            sv.ImpostorScoresUser11User95 = ManhDist.CalculateImpostorScores(s011Mean, s095);
            sv.ImpostorScoresUser11User96 = ManhDist.CalculateImpostorScores(s011Mean, s096);
            sv.ImpostorScoresUser11User97 = ManhDist.CalculateImpostorScores(s011Mean, s097);
            sv.ImpostorScoresUser11User98 = ManhDist.CalculateImpostorScores(s011Mean, s098);
            sv.ImpostorScoresUser11User99 = ManhDist.CalculateImpostorScores(s011Mean, s099);
            sv.ImpostorScoresUser11User100 = ManhDist.CalculateImpostorScores(s011Mean, s100);
            #endregion

            #region User 12 Impostor scores
            sv.ImpostorScoresUser12User1 = ManhDist.CalculateImpostorScores(s012Mean, s001);
            sv.ImpostorScoresUser12User2 = ManhDist.CalculateImpostorScores(s012Mean, s002);
            sv.ImpostorScoresUser12User3 = ManhDist.CalculateImpostorScores(s012Mean, s003);
            sv.ImpostorScoresUser12User4 = ManhDist.CalculateImpostorScores(s012Mean, s004);
            sv.ImpostorScoresUser12User5 = ManhDist.CalculateImpostorScores(s012Mean, s005);
            sv.ImpostorScoresUser12User6 = ManhDist.CalculateImpostorScores(s012Mean, s006);
            sv.ImpostorScoresUser12User7 = ManhDist.CalculateImpostorScores(s012Mean, s007);
            sv.ImpostorScoresUser12User8 = ManhDist.CalculateImpostorScores(s012Mean, s008);
            sv.ImpostorScoresUser12User9 = ManhDist.CalculateImpostorScores(s012Mean, s009);
            sv.ImpostorScoresUser12User10 = ManhDist.CalculateImpostorScores(s012Mean, s010);

            sv.ImpostorScoresUser12User11 = ManhDist.CalculateImpostorScores(s012Mean, s011);
            sv.ImpostorScoresUser12User13 = ManhDist.CalculateImpostorScores(s012Mean, s013);
            sv.ImpostorScoresUser12User14 = ManhDist.CalculateImpostorScores(s012Mean, s014);
            sv.ImpostorScoresUser12User15 = ManhDist.CalculateImpostorScores(s012Mean, s015);
            sv.ImpostorScoresUser12User16 = ManhDist.CalculateImpostorScores(s012Mean, s016);
            sv.ImpostorScoresUser12User17 = ManhDist.CalculateImpostorScores(s012Mean, s017);
            sv.ImpostorScoresUser12User18 = ManhDist.CalculateImpostorScores(s012Mean, s018);
            sv.ImpostorScoresUser12User19 = ManhDist.CalculateImpostorScores(s012Mean, s019);
            sv.ImpostorScoresUser12User20 = ManhDist.CalculateImpostorScores(s012Mean, s020);

            sv.ImpostorScoresUser12User21 = ManhDist.CalculateImpostorScores(s012Mean, s021);
            sv.ImpostorScoresUser12User22 = ManhDist.CalculateImpostorScores(s012Mean, s022);
            sv.ImpostorScoresUser12User23 = ManhDist.CalculateImpostorScores(s012Mean, s023);
            sv.ImpostorScoresUser12User24 = ManhDist.CalculateImpostorScores(s012Mean, s024);
            sv.ImpostorScoresUser12User25 = ManhDist.CalculateImpostorScores(s012Mean, s025);
            sv.ImpostorScoresUser12User26 = ManhDist.CalculateImpostorScores(s012Mean, s026);
            sv.ImpostorScoresUser12User27 = ManhDist.CalculateImpostorScores(s012Mean, s027);
            sv.ImpostorScoresUser12User28 = ManhDist.CalculateImpostorScores(s012Mean, s028);
            sv.ImpostorScoresUser12User29 = ManhDist.CalculateImpostorScores(s012Mean, s029);
            sv.ImpostorScoresUser12User30 = ManhDist.CalculateImpostorScores(s012Mean, s030);

            sv.ImpostorScoresUser12User31 = ManhDist.CalculateImpostorScores(s012Mean, s031);
            sv.ImpostorScoresUser12User32 = ManhDist.CalculateImpostorScores(s012Mean, s032);
            sv.ImpostorScoresUser12User33 = ManhDist.CalculateImpostorScores(s012Mean, s033);
            sv.ImpostorScoresUser12User34 = ManhDist.CalculateImpostorScores(s012Mean, s034);
            sv.ImpostorScoresUser12User35 = ManhDist.CalculateImpostorScores(s012Mean, s035);
            sv.ImpostorScoresUser12User36 = ManhDist.CalculateImpostorScores(s012Mean, s036);
            sv.ImpostorScoresUser12User37 = ManhDist.CalculateImpostorScores(s012Mean, s037);
            sv.ImpostorScoresUser12User38 = ManhDist.CalculateImpostorScores(s012Mean, s038);
            sv.ImpostorScoresUser12User39 = ManhDist.CalculateImpostorScores(s012Mean, s039);
            sv.ImpostorScoresUser12User40 = ManhDist.CalculateImpostorScores(s012Mean, s040);

            sv.ImpostorScoresUser12User41 = ManhDist.CalculateImpostorScores(s012Mean, s041);
            sv.ImpostorScoresUser12User42 = ManhDist.CalculateImpostorScores(s012Mean, s042);
            sv.ImpostorScoresUser12User43 = ManhDist.CalculateImpostorScores(s012Mean, s043);
            sv.ImpostorScoresUser12User44 = ManhDist.CalculateImpostorScores(s012Mean, s044);
            sv.ImpostorScoresUser12User45 = ManhDist.CalculateImpostorScores(s012Mean, s045);
            sv.ImpostorScoresUser12User46 = ManhDist.CalculateImpostorScores(s012Mean, s046);
            sv.ImpostorScoresUser12User47 = ManhDist.CalculateImpostorScores(s012Mean, s047);
            sv.ImpostorScoresUser12User48 = ManhDist.CalculateImpostorScores(s012Mean, s048);
            sv.ImpostorScoresUser12User49 = ManhDist.CalculateImpostorScores(s012Mean, s049);
            sv.ImpostorScoresUser12User50 = ManhDist.CalculateImpostorScores(s012Mean, s050);

            sv.ImpostorScoresUser12User51 = ManhDist.CalculateImpostorScores(s012Mean, s051);
            sv.ImpostorScoresUser12User52 = ManhDist.CalculateImpostorScores(s012Mean, s052);
            sv.ImpostorScoresUser12User53 = ManhDist.CalculateImpostorScores(s012Mean, s053);
            sv.ImpostorScoresUser12User54 = ManhDist.CalculateImpostorScores(s012Mean, s054);
            sv.ImpostorScoresUser12User55 = ManhDist.CalculateImpostorScores(s012Mean, s055);
            sv.ImpostorScoresUser12User56 = ManhDist.CalculateImpostorScores(s012Mean, s056);
            sv.ImpostorScoresUser12User57 = ManhDist.CalculateImpostorScores(s012Mean, s057);
            sv.ImpostorScoresUser12User58 = ManhDist.CalculateImpostorScores(s012Mean, s058);
            sv.ImpostorScoresUser12User59 = ManhDist.CalculateImpostorScores(s012Mean, s059);
            sv.ImpostorScoresUser12User60 = ManhDist.CalculateImpostorScores(s012Mean, s060);

            sv.ImpostorScoresUser12User61 = ManhDist.CalculateImpostorScores(s012Mean, s061);
            sv.ImpostorScoresUser12User62 = ManhDist.CalculateImpostorScores(s012Mean, s062);
            sv.ImpostorScoresUser12User63 = ManhDist.CalculateImpostorScores(s012Mean, s063);
            sv.ImpostorScoresUser12User64 = ManhDist.CalculateImpostorScores(s012Mean, s064);
            sv.ImpostorScoresUser12User65 = ManhDist.CalculateImpostorScores(s012Mean, s065);
            sv.ImpostorScoresUser12User66 = ManhDist.CalculateImpostorScores(s012Mean, s066);
            sv.ImpostorScoresUser12User67 = ManhDist.CalculateImpostorScores(s012Mean, s067);
            sv.ImpostorScoresUser12User68 = ManhDist.CalculateImpostorScores(s012Mean, s068);
            sv.ImpostorScoresUser12User69 = ManhDist.CalculateImpostorScores(s012Mean, s069);
            sv.ImpostorScoresUser12User70 = ManhDist.CalculateImpostorScores(s012Mean, s070);

            sv.ImpostorScoresUser12User71 = ManhDist.CalculateImpostorScores(s012Mean, s071);
            sv.ImpostorScoresUser12User72 = ManhDist.CalculateImpostorScores(s012Mean, s072);
            sv.ImpostorScoresUser12User73 = ManhDist.CalculateImpostorScores(s012Mean, s073);
            sv.ImpostorScoresUser12User74 = ManhDist.CalculateImpostorScores(s012Mean, s074);
            sv.ImpostorScoresUser12User75 = ManhDist.CalculateImpostorScores(s012Mean, s075);
            sv.ImpostorScoresUser12User76 = ManhDist.CalculateImpostorScores(s012Mean, s076);
            sv.ImpostorScoresUser12User77 = ManhDist.CalculateImpostorScores(s012Mean, s077);
            sv.ImpostorScoresUser12User78 = ManhDist.CalculateImpostorScores(s012Mean, s078);
            sv.ImpostorScoresUser12User79 = ManhDist.CalculateImpostorScores(s012Mean, s079);
            sv.ImpostorScoresUser12User80 = ManhDist.CalculateImpostorScores(s012Mean, s080);

            sv.ImpostorScoresUser12User81 = ManhDist.CalculateImpostorScores(s012Mean, s081);
            sv.ImpostorScoresUser12User82 = ManhDist.CalculateImpostorScores(s012Mean, s082);
            sv.ImpostorScoresUser12User83 = ManhDist.CalculateImpostorScores(s012Mean, s083);
            sv.ImpostorScoresUser12User84 = ManhDist.CalculateImpostorScores(s012Mean, s084);
            sv.ImpostorScoresUser12User85 = ManhDist.CalculateImpostorScores(s012Mean, s085);
            sv.ImpostorScoresUser12User86 = ManhDist.CalculateImpostorScores(s012Mean, s086);
            sv.ImpostorScoresUser12User87 = ManhDist.CalculateImpostorScores(s012Mean, s087);
            sv.ImpostorScoresUser12User88 = ManhDist.CalculateImpostorScores(s012Mean, s088);
            sv.ImpostorScoresUser12User89 = ManhDist.CalculateImpostorScores(s012Mean, s089);
            sv.ImpostorScoresUser12User90 = ManhDist.CalculateImpostorScores(s012Mean, s090);

            sv.ImpostorScoresUser12User91 = ManhDist.CalculateImpostorScores(s012Mean, s091);
            sv.ImpostorScoresUser12User92 = ManhDist.CalculateImpostorScores(s012Mean, s092);
            sv.ImpostorScoresUser12User93 = ManhDist.CalculateImpostorScores(s012Mean, s093);
            sv.ImpostorScoresUser12User94 = ManhDist.CalculateImpostorScores(s012Mean, s094);
            sv.ImpostorScoresUser12User95 = ManhDist.CalculateImpostorScores(s012Mean, s095);
            sv.ImpostorScoresUser12User96 = ManhDist.CalculateImpostorScores(s012Mean, s096);
            sv.ImpostorScoresUser12User97 = ManhDist.CalculateImpostorScores(s012Mean, s097);
            sv.ImpostorScoresUser12User98 = ManhDist.CalculateImpostorScores(s012Mean, s098);
            sv.ImpostorScoresUser12User99 = ManhDist.CalculateImpostorScores(s012Mean, s099);
            sv.ImpostorScoresUser12User100 = ManhDist.CalculateImpostorScores(s012Mean, s100);
            #endregion

            #endregion

            #region Showing the output of the genuine scores
            Console.WriteLine("Enter a number between 1 and 100 to view the genuine scores:");

            int user = int.Parse(Console.ReadLine());

            Console.WriteLine("User chosen: " + user);
            switch (user)
            {
                case 1:
                    for (int i = 0; i < s001Gen.GetLength(0); i++)
                    {
                        for (int j = 0; j < s001Gen.GetLength(1); j++)
                        {
                            Console.Write(s001Gen[i, j] + " ");
                        }

                        Console.WriteLine();
                    }

                    Console.ReadKey();
                    break;
                case 2:
                    for (int i = 0; i < s002Gen.GetLength(0); i++)
                    {
                        for (int j = 0; j < s002Gen.GetLength(1); j++)
                        {
                            Console.Write(s002Gen[i, j] + " ");
                        }

                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 0; i < s003Gen.GetLength(0); i++)
                    {
                        for (int j = 0; j < s003Gen.GetLength(1); j++)
                        {
                            Console.Write(s003Gen[i, j] + " ");
                        }

                        Console.WriteLine();
                    }
                    break;
                case 4:
                    for (int i = 0; i < s004Gen.GetLength(0); i++)
                    {
                        for (int j = 0; j < s004Gen.GetLength(1); j++)
                        {
                            Console.Write(s004Gen[i, j] + " ");
                        }

                        Console.WriteLine();
                    }
                    break;
                case 5:
                    for (int i = 0; i < s005Gen.GetLength(0); i++)
                    {
                        for (int j = 0; j < s005Gen.GetLength(1); j++)
                        {
                            Console.Write(s005Gen[i, j] + " ");
                        }

                        Console.WriteLine();
                    }
                    break;
                case 6:
                    for (int i = 0; i < s006Gen.GetLength(0); i++)
                    {
                        for (int j = 0; j < s006Gen.GetLength(1); j++)
                        {
                            Console.Write(s006Gen[i, j] + " ");
                        }

                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("There was no choice made...the program will now exit!");
                    Console.ReadKey();
                    break;
            }
            #endregion
        } 
        #endregion
    }
}