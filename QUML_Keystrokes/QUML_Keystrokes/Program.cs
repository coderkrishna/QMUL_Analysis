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
 */
using System;
using OperationsLib;

///<summary>
/// Source of the Data: http://www.eecs.qmul.ac.uk/~ccloy/downloads_keystroke100.html
///</summary>

namespace QUML_Keystrokes
{
    class Program : ScoreVars
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

        #region Scaled Euclidean Verifier
        private static void UseScaledEuclideanVerifier()
        {
            Console.WriteLine("The Scaled Euclidean Verifier is to be coded - TBC");
        }
        #endregion

        #region Scaled Manhattan Verifier
        private static void UseScaledManhattanVerifier()
        {
            // Making reference to the ScaledManhattanDistance class
            ScaledManhattanDistance ScaledManhDist = new ScaledManhattanDistance();
            ScoreVars sv = new ScoreVars();

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


            #endregion
        }
        #endregion

        #region Euclidean Verifier
        private static void UseEuclideanVerifier()
        {
            EuclideanDistance EuclidDist = new EuclideanDistance();
            ScoreVars sv = new ScoreVars();

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

            #endregion
        }
        #endregion

        #region Manhattan Verifier
        private static void UseManhattanVerifier()
        {
            ManhattanDistance ManhDist = new ManhattanDistance();
            ScoreVars sv = new ScoreVars();

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