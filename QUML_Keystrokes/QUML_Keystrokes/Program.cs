﻿using System;
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

            Console.WriteLine("Now choose your verifier: " + Environment.NewLine + "0 for Manhattan" + Environment.NewLine + 
                "1 for Euclidean" + Environment.NewLine + "2 for Scaled Manhattan" + Environment.NewLine + "4 to Quit");

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

            #region User 13 Impostor scores
            sv.ImpostorScoresUser13User1 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s001);
            sv.ImpostorScoresUser13User2 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s002);
            sv.ImpostorScoresUser13User3 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s003);
            sv.ImpostorScoresUser13User4 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s004);
            sv.ImpostorScoresUser13User5 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s005);
            sv.ImpostorScoresUser13User6 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s006);
            sv.ImpostorScoresUser13User7 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s007);
            sv.ImpostorScoresUser13User8 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s008);
            sv.ImpostorScoresUser13User9 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s009);
            sv.ImpostorScoresUser13User10 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s010);

            sv.ImpostorScoresUser13User11 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s011);
            sv.ImpostorScoresUser13User12 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s012);
            sv.ImpostorScoresUser13User14 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s014);
            sv.ImpostorScoresUser13User15 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s015);
            sv.ImpostorScoresUser13User16 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s016);
            sv.ImpostorScoresUser13User17 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s017);
            sv.ImpostorScoresUser13User18 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s018);
            sv.ImpostorScoresUser13User19 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s019);
            sv.ImpostorScoresUser13User20 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s020);

            sv.ImpostorScoresUser13User21 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s021);
            sv.ImpostorScoresUser13User22 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s022);
            sv.ImpostorScoresUser13User23 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s023);
            sv.ImpostorScoresUser13User24 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s024);
            sv.ImpostorScoresUser13User25 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s025);
            sv.ImpostorScoresUser13User26 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s026);
            sv.ImpostorScoresUser13User27 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s027);
            sv.ImpostorScoresUser13User28 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s028);
            sv.ImpostorScoresUser13User29 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s029);
            sv.ImpostorScoresUser13User30 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s030);

            sv.ImpostorScoresUser13User31 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s031);
            sv.ImpostorScoresUser13User32 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s032);
            sv.ImpostorScoresUser13User33 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s033);
            sv.ImpostorScoresUser13User34 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s034);
            sv.ImpostorScoresUser13User35 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s035);
            sv.ImpostorScoresUser13User36 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s036);
            sv.ImpostorScoresUser13User37 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s037);
            sv.ImpostorScoresUser13User38 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s038);
            sv.ImpostorScoresUser13User39 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s039);
            sv.ImpostorScoresUser13User40 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s040);
                                                                                   
            sv.ImpostorScoresUser13User41 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s041);
            sv.ImpostorScoresUser13User42 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s042);
            sv.ImpostorScoresUser13User43 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s043);
            sv.ImpostorScoresUser13User44 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s044);
            sv.ImpostorScoresUser13User45 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s045);
            sv.ImpostorScoresUser13User46 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s046);
            sv.ImpostorScoresUser13User47 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s047);
            sv.ImpostorScoresUser13User48 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s048);
            sv.ImpostorScoresUser13User49 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s049);
            sv.ImpostorScoresUser13User50 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s050);
                                                                                   
            sv.ImpostorScoresUser13User51 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s051);
            sv.ImpostorScoresUser13User52 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s052);
            sv.ImpostorScoresUser13User53 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s053);
            sv.ImpostorScoresUser13User54 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s054);
            sv.ImpostorScoresUser13User55 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s055);
            sv.ImpostorScoresUser13User56 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s056);
            sv.ImpostorScoresUser13User57 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s057);
            sv.ImpostorScoresUser13User58 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s058);
            sv.ImpostorScoresUser13User59 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s059);
            sv.ImpostorScoresUser13User60 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s060);
                                                                                   
            sv.ImpostorScoresUser13User61 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s061);
            sv.ImpostorScoresUser13User62 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s062);
            sv.ImpostorScoresUser13User63 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s063);
            sv.ImpostorScoresUser13User64 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s064);
            sv.ImpostorScoresUser13User65 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s065);
            sv.ImpostorScoresUser13User66 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s066);
            sv.ImpostorScoresUser13User67 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s067);
            sv.ImpostorScoresUser13User68 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s068);
            sv.ImpostorScoresUser13User69 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s069);
            sv.ImpostorScoresUser13User70 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s070);
                                                                                   
            sv.ImpostorScoresUser13User71 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s071);
            sv.ImpostorScoresUser13User72 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s072);
            sv.ImpostorScoresUser13User73 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s073);
            sv.ImpostorScoresUser13User74 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s074);
            sv.ImpostorScoresUser13User75 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s075);
            sv.ImpostorScoresUser13User76 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s076);
            sv.ImpostorScoresUser13User77 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s077);
            sv.ImpostorScoresUser13User78 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s078);
            sv.ImpostorScoresUser13User79 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s079);
            sv.ImpostorScoresUser13User80 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s080);
                                                                                   
            sv.ImpostorScoresUser13User81 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s081);
            sv.ImpostorScoresUser13User82 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s082);
            sv.ImpostorScoresUser13User83 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s083);
            sv.ImpostorScoresUser13User84 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s084);
            sv.ImpostorScoresUser13User85 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s085);
            sv.ImpostorScoresUser13User86 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s086);
            sv.ImpostorScoresUser13User87 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s087);
            sv.ImpostorScoresUser13User88 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s088);
            sv.ImpostorScoresUser13User89 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s089);
            sv.ImpostorScoresUser13User90 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s090);
                                                                                   
            sv.ImpostorScoresUser13User91 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s091);
            sv.ImpostorScoresUser13User92 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s092);
            sv.ImpostorScoresUser13User93 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s093);
            sv.ImpostorScoresUser13User94 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s094);
            sv.ImpostorScoresUser13User95 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s095);
            sv.ImpostorScoresUser13User96 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s096);
            sv.ImpostorScoresUser13User97 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s097);
            sv.ImpostorScoresUser13User98 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s098);
            sv.ImpostorScoresUser13User99 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s099);
            sv.ImpostorScoresUser13User100 = ScaledManhDist.CalculateImpostorScores(s013Mean, stdDevUser13, s100);
            #endregion

            #region User 14 Impostor scores
            sv.ImpostorScoresUser14User1 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s001);
            sv.ImpostorScoresUser14User2 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s002);
            sv.ImpostorScoresUser14User3 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s003);
            sv.ImpostorScoresUser14User4 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s004);
            sv.ImpostorScoresUser14User5 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s005);
            sv.ImpostorScoresUser14User6 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s006);
            sv.ImpostorScoresUser14User7 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s007);
            sv.ImpostorScoresUser14User8 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s008);
            sv.ImpostorScoresUser14User9 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s009);
            sv.ImpostorScoresUser14User10 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s010);

            sv.ImpostorScoresUser14User11 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s011);
            sv.ImpostorScoresUser14User12 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s012);
            sv.ImpostorScoresUser14User13 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s013);
            sv.ImpostorScoresUser14User15 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s015);
            sv.ImpostorScoresUser14User16 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s016);
            sv.ImpostorScoresUser14User17 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s017);
            sv.ImpostorScoresUser14User18 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s018);
            sv.ImpostorScoresUser14User19 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s019);
            sv.ImpostorScoresUser14User20 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s020);

            sv.ImpostorScoresUser14User21 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s021);
            sv.ImpostorScoresUser14User22 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s022);
            sv.ImpostorScoresUser14User23 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s023);
            sv.ImpostorScoresUser14User24 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s024);
            sv.ImpostorScoresUser14User25 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s025);
            sv.ImpostorScoresUser14User26 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s026);
            sv.ImpostorScoresUser14User27 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s027);
            sv.ImpostorScoresUser14User28 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s028);
            sv.ImpostorScoresUser14User29 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s029);
            sv.ImpostorScoresUser14User30 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s030);

            sv.ImpostorScoresUser14User31 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s031);
            sv.ImpostorScoresUser14User32 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s032);
            sv.ImpostorScoresUser14User33 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s033);
            sv.ImpostorScoresUser14User34 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s034);
            sv.ImpostorScoresUser14User35 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s035);
            sv.ImpostorScoresUser14User36 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s036);
            sv.ImpostorScoresUser14User37 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s037);
            sv.ImpostorScoresUser14User38 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s038);
            sv.ImpostorScoresUser14User39 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s039);
            sv.ImpostorScoresUser14User40 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s040);

            sv.ImpostorScoresUser14User41 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s041);
            sv.ImpostorScoresUser14User42 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s042);
            sv.ImpostorScoresUser14User43 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s043);
            sv.ImpostorScoresUser14User44 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s044);
            sv.ImpostorScoresUser14User45 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s045);
            sv.ImpostorScoresUser14User46 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s046);
            sv.ImpostorScoresUser14User47 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s047);
            sv.ImpostorScoresUser14User48 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s048);
            sv.ImpostorScoresUser14User49 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s049);
            sv.ImpostorScoresUser14User50 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s050);

            sv.ImpostorScoresUser14User51 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s051);
            sv.ImpostorScoresUser14User52 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s052);
            sv.ImpostorScoresUser14User53 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s053);
            sv.ImpostorScoresUser14User54 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s054);
            sv.ImpostorScoresUser14User55 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s055);
            sv.ImpostorScoresUser14User56 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s056);
            sv.ImpostorScoresUser14User57 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s057);
            sv.ImpostorScoresUser14User58 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s058);
            sv.ImpostorScoresUser14User59 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s059);
            sv.ImpostorScoresUser14User60 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s060);

            sv.ImpostorScoresUser14User61 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s061);
            sv.ImpostorScoresUser14User62 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s062);
            sv.ImpostorScoresUser14User63 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s063);
            sv.ImpostorScoresUser14User64 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s064);
            sv.ImpostorScoresUser14User65 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s065);
            sv.ImpostorScoresUser14User66 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s066);
            sv.ImpostorScoresUser14User67 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s067);
            sv.ImpostorScoresUser14User68 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s068);
            sv.ImpostorScoresUser14User69 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s069);
            sv.ImpostorScoresUser14User70 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s070);

            sv.ImpostorScoresUser14User71 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s071);
            sv.ImpostorScoresUser14User72 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s072);
            sv.ImpostorScoresUser14User73 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s073);
            sv.ImpostorScoresUser14User74 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s074);
            sv.ImpostorScoresUser14User75 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s075);
            sv.ImpostorScoresUser14User76 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s076);
            sv.ImpostorScoresUser14User77 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s077);
            sv.ImpostorScoresUser14User78 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s078);
            sv.ImpostorScoresUser14User79 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s079);
            sv.ImpostorScoresUser14User80 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s080);

            sv.ImpostorScoresUser14User81 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s081);
            sv.ImpostorScoresUser14User82 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s082);
            sv.ImpostorScoresUser14User83 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s083);
            sv.ImpostorScoresUser14User84 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s084);
            sv.ImpostorScoresUser14User85 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s085);
            sv.ImpostorScoresUser14User86 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s086);
            sv.ImpostorScoresUser14User87 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s087);
            sv.ImpostorScoresUser14User88 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s088);
            sv.ImpostorScoresUser14User89 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s089);
            sv.ImpostorScoresUser14User90 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s090);

            sv.ImpostorScoresUser14User91 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s091);
            sv.ImpostorScoresUser14User92 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s092);
            sv.ImpostorScoresUser14User93 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s093);
            sv.ImpostorScoresUser14User94 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s094);
            sv.ImpostorScoresUser14User95 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s095);
            sv.ImpostorScoresUser14User96 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s096);
            sv.ImpostorScoresUser14User97 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s097);
            sv.ImpostorScoresUser14User98 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s098);
            sv.ImpostorScoresUser14User99 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s099);
            sv.ImpostorScoresUser14User100 = ScaledManhDist.CalculateImpostorScores(s014Mean, stdDevUser14, s100);
            #endregion

            #region User 15 Impostor scores
            sv.ImpostorScoresUser15User1 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s001);
            sv.ImpostorScoresUser15User2 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s002);
            sv.ImpostorScoresUser15User3 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s003);
            sv.ImpostorScoresUser15User4 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s004);
            sv.ImpostorScoresUser15User5 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s005);
            sv.ImpostorScoresUser15User6 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s006);
            sv.ImpostorScoresUser15User7 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s007);
            sv.ImpostorScoresUser15User8 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s008);
            sv.ImpostorScoresUser15User9 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s009);
            sv.ImpostorScoresUser15User10 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s010);

            sv.ImpostorScoresUser15User11 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s011);
            sv.ImpostorScoresUser15User12 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s012);
            sv.ImpostorScoresUser15User13 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s013);
            sv.ImpostorScoresUser15User14 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s014);
            sv.ImpostorScoresUser15User16 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s016);
            sv.ImpostorScoresUser15User17 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s017);
            sv.ImpostorScoresUser15User18 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s018);
            sv.ImpostorScoresUser15User19 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s019);
            sv.ImpostorScoresUser15User20 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s020);

            sv.ImpostorScoresUser15User21 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s021);
            sv.ImpostorScoresUser15User22 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s022);
            sv.ImpostorScoresUser15User23 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s023);
            sv.ImpostorScoresUser15User24 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s024);
            sv.ImpostorScoresUser15User25 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s025);
            sv.ImpostorScoresUser15User26 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s026);
            sv.ImpostorScoresUser15User27 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s027);
            sv.ImpostorScoresUser15User28 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s028);
            sv.ImpostorScoresUser15User29 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s029);
            sv.ImpostorScoresUser15User30 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s030);

            sv.ImpostorScoresUser15User31 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s031);
            sv.ImpostorScoresUser15User32 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s032);
            sv.ImpostorScoresUser15User33 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s033);
            sv.ImpostorScoresUser15User34 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s034);
            sv.ImpostorScoresUser15User35 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s035);
            sv.ImpostorScoresUser15User36 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s036);
            sv.ImpostorScoresUser15User37 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s037);
            sv.ImpostorScoresUser15User38 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s038);
            sv.ImpostorScoresUser15User39 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s039);
            sv.ImpostorScoresUser15User40 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s040);

            sv.ImpostorScoresUser15User41 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s041);
            sv.ImpostorScoresUser15User42 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s042);
            sv.ImpostorScoresUser15User43 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s043);
            sv.ImpostorScoresUser15User44 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s044);
            sv.ImpostorScoresUser15User45 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s045);
            sv.ImpostorScoresUser15User46 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s046);
            sv.ImpostorScoresUser15User47 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s047);
            sv.ImpostorScoresUser15User48 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s048);
            sv.ImpostorScoresUser15User49 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s049);
            sv.ImpostorScoresUser15User50 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s050);

            sv.ImpostorScoresUser15User51 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s051);
            sv.ImpostorScoresUser15User52 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s052);
            sv.ImpostorScoresUser15User53 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s053);
            sv.ImpostorScoresUser15User54 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s054);
            sv.ImpostorScoresUser15User55 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s055);
            sv.ImpostorScoresUser15User56 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s056);
            sv.ImpostorScoresUser15User57 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s057);
            sv.ImpostorScoresUser15User58 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s058);
            sv.ImpostorScoresUser15User59 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s059);
            sv.ImpostorScoresUser15User60 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s060);

            sv.ImpostorScoresUser15User61 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s061);
            sv.ImpostorScoresUser15User62 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s062);
            sv.ImpostorScoresUser15User63 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s063);
            sv.ImpostorScoresUser15User64 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s064);
            sv.ImpostorScoresUser15User65 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s065);
            sv.ImpostorScoresUser15User66 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s066);
            sv.ImpostorScoresUser15User67 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s067);
            sv.ImpostorScoresUser15User68 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s068);
            sv.ImpostorScoresUser15User69 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s069);
            sv.ImpostorScoresUser15User70 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s070);

            sv.ImpostorScoresUser15User71 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s071);
            sv.ImpostorScoresUser15User72 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s072);
            sv.ImpostorScoresUser15User73 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s073);
            sv.ImpostorScoresUser15User74 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s074);
            sv.ImpostorScoresUser15User75 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s075);
            sv.ImpostorScoresUser15User76 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s076);
            sv.ImpostorScoresUser15User77 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s077);
            sv.ImpostorScoresUser15User78 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s078);
            sv.ImpostorScoresUser15User79 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s079);
            sv.ImpostorScoresUser15User80 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s080);

            sv.ImpostorScoresUser15User81 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s081);
            sv.ImpostorScoresUser15User82 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s082);
            sv.ImpostorScoresUser15User83 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s083);
            sv.ImpostorScoresUser15User84 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s084);
            sv.ImpostorScoresUser15User85 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s085);
            sv.ImpostorScoresUser15User86 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s086);
            sv.ImpostorScoresUser15User87 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s087);
            sv.ImpostorScoresUser15User88 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s088);
            sv.ImpostorScoresUser15User89 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s089);
            sv.ImpostorScoresUser15User90 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s090);

            sv.ImpostorScoresUser15User91 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s091);
            sv.ImpostorScoresUser15User92 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s092);
            sv.ImpostorScoresUser15User93 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s093);
            sv.ImpostorScoresUser15User94 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s094);
            sv.ImpostorScoresUser15User95 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s095);
            sv.ImpostorScoresUser15User96 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s096);
            sv.ImpostorScoresUser15User97 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s097);
            sv.ImpostorScoresUser15User98 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s098);
            sv.ImpostorScoresUser15User99 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s099);
            sv.ImpostorScoresUser15User100 = ScaledManhDist.CalculateImpostorScores(s015Mean, stdDevUser15, s100);
            #endregion

            #region User 16 Impostor scores
            sv.ImpostorScoresUser16User1 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s001);
            sv.ImpostorScoresUser16User2 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s002);
            sv.ImpostorScoresUser16User3 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s003);
            sv.ImpostorScoresUser16User4 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s004);
            sv.ImpostorScoresUser16User5 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s005);
            sv.ImpostorScoresUser16User6 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s006);
            sv.ImpostorScoresUser16User7 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s007);
            sv.ImpostorScoresUser16User8 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s008);
            sv.ImpostorScoresUser16User9 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s009);
            sv.ImpostorScoresUser16User10 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s010);

            sv.ImpostorScoresUser16User11 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s011);
            sv.ImpostorScoresUser16User12 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s012);
            sv.ImpostorScoresUser16User13 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s013);
            sv.ImpostorScoresUser16User14 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s014);
            sv.ImpostorScoresUser16User15 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s015);
            sv.ImpostorScoresUser16User17 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s017);
            sv.ImpostorScoresUser16User18 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s018);
            sv.ImpostorScoresUser16User19 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s019);
            sv.ImpostorScoresUser16User20 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s020);

            sv.ImpostorScoresUser16User21 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s021);
            sv.ImpostorScoresUser16User22 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s022);
            sv.ImpostorScoresUser16User23 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s023);
            sv.ImpostorScoresUser16User24 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s024);
            sv.ImpostorScoresUser16User25 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s025);
            sv.ImpostorScoresUser16User26 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s026);
            sv.ImpostorScoresUser16User27 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s027);
            sv.ImpostorScoresUser16User28 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s028);
            sv.ImpostorScoresUser16User29 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s029);
            sv.ImpostorScoresUser16User30 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s030);

            sv.ImpostorScoresUser16User31 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s031);
            sv.ImpostorScoresUser16User32 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s032);
            sv.ImpostorScoresUser16User33 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s033);
            sv.ImpostorScoresUser16User34 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s034);
            sv.ImpostorScoresUser16User35 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s035);
            sv.ImpostorScoresUser16User36 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s036);
            sv.ImpostorScoresUser16User37 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s037);
            sv.ImpostorScoresUser16User38 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s038);
            sv.ImpostorScoresUser16User39 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s039);
            sv.ImpostorScoresUser16User40 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s040);

            sv.ImpostorScoresUser16User41 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s041);
            sv.ImpostorScoresUser16User42 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s042);
            sv.ImpostorScoresUser16User43 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s043);
            sv.ImpostorScoresUser16User44 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s044);
            sv.ImpostorScoresUser16User45 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s045);
            sv.ImpostorScoresUser16User46 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s046);
            sv.ImpostorScoresUser16User47 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s047);
            sv.ImpostorScoresUser16User48 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s048);
            sv.ImpostorScoresUser16User49 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s049);
            sv.ImpostorScoresUser16User50 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s050);

            sv.ImpostorScoresUser16User51 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s051);
            sv.ImpostorScoresUser16User52 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s052);
            sv.ImpostorScoresUser16User53 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s053);
            sv.ImpostorScoresUser16User54 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s054);
            sv.ImpostorScoresUser16User55 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s055);
            sv.ImpostorScoresUser16User56 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s056);
            sv.ImpostorScoresUser16User57 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s057);
            sv.ImpostorScoresUser16User58 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s058);
            sv.ImpostorScoresUser16User59 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s059);
            sv.ImpostorScoresUser16User60 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s060);

            sv.ImpostorScoresUser16User61 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s061);
            sv.ImpostorScoresUser16User62 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s062);
            sv.ImpostorScoresUser16User63 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s063);
            sv.ImpostorScoresUser16User64 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s064);
            sv.ImpostorScoresUser16User65 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s065);
            sv.ImpostorScoresUser16User66 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s066);
            sv.ImpostorScoresUser16User67 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s067);
            sv.ImpostorScoresUser16User68 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s068);
            sv.ImpostorScoresUser16User69 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s069);
            sv.ImpostorScoresUser16User70 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s070);

            sv.ImpostorScoresUser16User71 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s071);
            sv.ImpostorScoresUser16User72 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s072);
            sv.ImpostorScoresUser16User73 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s073);
            sv.ImpostorScoresUser16User74 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s074);
            sv.ImpostorScoresUser16User75 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s075);
            sv.ImpostorScoresUser16User76 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s076);
            sv.ImpostorScoresUser16User77 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s077);
            sv.ImpostorScoresUser16User78 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s078);
            sv.ImpostorScoresUser16User79 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s079);
            sv.ImpostorScoresUser16User80 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s080);

            sv.ImpostorScoresUser16User81 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s081);
            sv.ImpostorScoresUser16User82 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s082);
            sv.ImpostorScoresUser16User83 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s083);
            sv.ImpostorScoresUser16User84 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s084);
            sv.ImpostorScoresUser16User85 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s085);
            sv.ImpostorScoresUser16User86 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s086);
            sv.ImpostorScoresUser16User87 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s087);
            sv.ImpostorScoresUser16User88 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s088);
            sv.ImpostorScoresUser16User89 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s089);
            sv.ImpostorScoresUser16User90 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s090);

            sv.ImpostorScoresUser16User91 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s091);
            sv.ImpostorScoresUser16User92 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s092);
            sv.ImpostorScoresUser16User93 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s093);
            sv.ImpostorScoresUser16User94 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s094);
            sv.ImpostorScoresUser16User95 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s095);
            sv.ImpostorScoresUser16User96 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s096);
            sv.ImpostorScoresUser16User97 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s097);
            sv.ImpostorScoresUser16User98 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s098);
            sv.ImpostorScoresUser16User99 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s099);
            sv.ImpostorScoresUser16User100 = ScaledManhDist.CalculateImpostorScores(s016Mean, stdDevUser16, s100);
            #endregion

            #region User 17 Impostor scores
            sv.ImpostorScoresUser17User1 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s001);
            sv.ImpostorScoresUser17User2 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s002);
            sv.ImpostorScoresUser17User3 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s003);
            sv.ImpostorScoresUser17User4 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s004);
            sv.ImpostorScoresUser17User5 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s005);
            sv.ImpostorScoresUser17User6 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s006);
            sv.ImpostorScoresUser17User7 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s007);
            sv.ImpostorScoresUser17User8 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s008);
            sv.ImpostorScoresUser17User9 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s009);
            sv.ImpostorScoresUser17User10 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s010);

            sv.ImpostorScoresUser17User11 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s011);
            sv.ImpostorScoresUser17User12 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s012);
            sv.ImpostorScoresUser17User13 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s013);
            sv.ImpostorScoresUser17User14 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s014);
            sv.ImpostorScoresUser17User15 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s015);
            sv.ImpostorScoresUser17User16 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s016);
            sv.ImpostorScoresUser17User18 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s018);
            sv.ImpostorScoresUser17User19 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s019);
            sv.ImpostorScoresUser17User20 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s020);

            sv.ImpostorScoresUser17User21 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s021);
            sv.ImpostorScoresUser17User22 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s022);
            sv.ImpostorScoresUser17User23 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s023);
            sv.ImpostorScoresUser17User24 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s024);
            sv.ImpostorScoresUser17User25 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s025);
            sv.ImpostorScoresUser17User26 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s026);
            sv.ImpostorScoresUser17User27 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s027);
            sv.ImpostorScoresUser17User28 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s028);
            sv.ImpostorScoresUser17User29 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s029);
            sv.ImpostorScoresUser17User30 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s030);

            sv.ImpostorScoresUser17User31 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s031);
            sv.ImpostorScoresUser17User32 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s032);
            sv.ImpostorScoresUser17User33 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s033);
            sv.ImpostorScoresUser17User34 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s034);
            sv.ImpostorScoresUser17User35 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s035);
            sv.ImpostorScoresUser17User36 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s036);
            sv.ImpostorScoresUser17User37 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s037);
            sv.ImpostorScoresUser17User38 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s038);
            sv.ImpostorScoresUser17User39 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s039);
            sv.ImpostorScoresUser17User40 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s040);

            sv.ImpostorScoresUser17User41 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s041);
            sv.ImpostorScoresUser17User42 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s042);
            sv.ImpostorScoresUser17User43 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s043);
            sv.ImpostorScoresUser17User44 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s044);
            sv.ImpostorScoresUser17User45 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s045);
            sv.ImpostorScoresUser17User46 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s046);
            sv.ImpostorScoresUser17User47 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s047);
            sv.ImpostorScoresUser17User48 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s048);
            sv.ImpostorScoresUser17User49 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s049);
            sv.ImpostorScoresUser17User50 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s050);

            sv.ImpostorScoresUser17User51 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s051);
            sv.ImpostorScoresUser17User52 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s052);
            sv.ImpostorScoresUser17User53 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s053);
            sv.ImpostorScoresUser17User54 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s054);
            sv.ImpostorScoresUser17User55 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s055);
            sv.ImpostorScoresUser17User56 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s056);
            sv.ImpostorScoresUser17User57 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s057);
            sv.ImpostorScoresUser17User58 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s058);
            sv.ImpostorScoresUser17User59 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s059);
            sv.ImpostorScoresUser17User60 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s060);

            sv.ImpostorScoresUser17User61 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s061);
            sv.ImpostorScoresUser17User62 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s062);
            sv.ImpostorScoresUser17User63 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s063);
            sv.ImpostorScoresUser17User64 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s064);
            sv.ImpostorScoresUser17User65 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s065);
            sv.ImpostorScoresUser17User66 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s066);
            sv.ImpostorScoresUser17User67 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s067);
            sv.ImpostorScoresUser17User68 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s068);
            sv.ImpostorScoresUser17User69 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s069);
            sv.ImpostorScoresUser17User70 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s070);

            sv.ImpostorScoresUser17User71 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s071);
            sv.ImpostorScoresUser17User72 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s072);
            sv.ImpostorScoresUser17User73 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s073);
            sv.ImpostorScoresUser17User74 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s074);
            sv.ImpostorScoresUser17User75 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s075);
            sv.ImpostorScoresUser17User76 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s076);
            sv.ImpostorScoresUser17User77 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s077);
            sv.ImpostorScoresUser17User78 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s078);
            sv.ImpostorScoresUser17User79 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s079);
            sv.ImpostorScoresUser17User80 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s080);

            sv.ImpostorScoresUser17User81 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s081);
            sv.ImpostorScoresUser17User82 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s082);
            sv.ImpostorScoresUser17User83 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s083);
            sv.ImpostorScoresUser17User84 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s084);
            sv.ImpostorScoresUser17User85 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s085);
            sv.ImpostorScoresUser17User86 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s086);
            sv.ImpostorScoresUser17User87 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s087);
            sv.ImpostorScoresUser17User88 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s088);
            sv.ImpostorScoresUser17User89 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s089);
            sv.ImpostorScoresUser17User90 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s090);

            sv.ImpostorScoresUser17User91 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s091);
            sv.ImpostorScoresUser17User92 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s092);
            sv.ImpostorScoresUser17User93 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s093);
            sv.ImpostorScoresUser17User94 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s094);
            sv.ImpostorScoresUser17User95 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s095);
            sv.ImpostorScoresUser17User96 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s096);
            sv.ImpostorScoresUser17User97 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s097);
            sv.ImpostorScoresUser17User98 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s098);
            sv.ImpostorScoresUser17User99 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s099);
            sv.ImpostorScoresUser17User100 = ScaledManhDist.CalculateImpostorScores(s017Mean, stdDevUser17, s100);
            #endregion

            #region User 18 Impostor scores
            sv.ImpostorScoresUser18User1 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s001);
            sv.ImpostorScoresUser18User2 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s002);
            sv.ImpostorScoresUser18User3 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s003);
            sv.ImpostorScoresUser18User4 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s004);
            sv.ImpostorScoresUser18User5 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s005);
            sv.ImpostorScoresUser18User6 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s006);
            sv.ImpostorScoresUser18User7 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s007);
            sv.ImpostorScoresUser18User8 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s008);
            sv.ImpostorScoresUser18User9 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s009);
            sv.ImpostorScoresUser18User10 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s010);

            sv.ImpostorScoresUser18User11 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s011);
            sv.ImpostorScoresUser18User12 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s012);
            sv.ImpostorScoresUser18User13 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s013);
            sv.ImpostorScoresUser18User14 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s014);
            sv.ImpostorScoresUser18User15 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s015);
            sv.ImpostorScoresUser18User16 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s016);
            sv.ImpostorScoresUser18User17 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s017);
            sv.ImpostorScoresUser18User19 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s019);
            sv.ImpostorScoresUser18User20 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s020);

            sv.ImpostorScoresUser18User21 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s021);
            sv.ImpostorScoresUser18User22 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s022);
            sv.ImpostorScoresUser18User23 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s023);
            sv.ImpostorScoresUser18User24 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s024);
            sv.ImpostorScoresUser18User25 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s025);
            sv.ImpostorScoresUser18User26 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s026);
            sv.ImpostorScoresUser18User27 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s027);
            sv.ImpostorScoresUser18User28 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s028);
            sv.ImpostorScoresUser18User29 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s029);
            sv.ImpostorScoresUser18User30 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s030);

            sv.ImpostorScoresUser18User31 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s031);
            sv.ImpostorScoresUser18User32 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s032);
            sv.ImpostorScoresUser18User33 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s033);
            sv.ImpostorScoresUser18User34 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s034);
            sv.ImpostorScoresUser18User35 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s035);
            sv.ImpostorScoresUser18User36 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s036);
            sv.ImpostorScoresUser18User37 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s037);
            sv.ImpostorScoresUser18User38 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s038);
            sv.ImpostorScoresUser18User39 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s039);
            sv.ImpostorScoresUser18User40 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s040);

            sv.ImpostorScoresUser18User41 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s041);
            sv.ImpostorScoresUser18User42 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s042);
            sv.ImpostorScoresUser18User43 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s043);
            sv.ImpostorScoresUser18User44 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s044);
            sv.ImpostorScoresUser18User45 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s045);
            sv.ImpostorScoresUser18User46 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s046);
            sv.ImpostorScoresUser18User47 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s047);
            sv.ImpostorScoresUser18User48 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s048);
            sv.ImpostorScoresUser18User49 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s049);
            sv.ImpostorScoresUser18User50 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s050);

            sv.ImpostorScoresUser18User51 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s051);
            sv.ImpostorScoresUser18User52 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s052);
            sv.ImpostorScoresUser18User53 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s053);
            sv.ImpostorScoresUser18User54 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s054);
            sv.ImpostorScoresUser18User55 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s055);
            sv.ImpostorScoresUser18User56 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s056);
            sv.ImpostorScoresUser18User57 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s057);
            sv.ImpostorScoresUser18User58 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s058);
            sv.ImpostorScoresUser18User59 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s059);
            sv.ImpostorScoresUser18User60 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s060);

            sv.ImpostorScoresUser18User61 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s061);
            sv.ImpostorScoresUser18User62 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s062);
            sv.ImpostorScoresUser18User63 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s063);
            sv.ImpostorScoresUser18User64 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s064);
            sv.ImpostorScoresUser18User65 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s065);
            sv.ImpostorScoresUser18User66 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s066);
            sv.ImpostorScoresUser18User67 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s067);
            sv.ImpostorScoresUser18User68 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s068);
            sv.ImpostorScoresUser18User69 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s069);
            sv.ImpostorScoresUser18User70 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s070);

            sv.ImpostorScoresUser18User71 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s071);
            sv.ImpostorScoresUser18User72 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s072);
            sv.ImpostorScoresUser18User73 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s073);
            sv.ImpostorScoresUser18User74 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s074);
            sv.ImpostorScoresUser18User75 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s075);
            sv.ImpostorScoresUser18User76 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s076);
            sv.ImpostorScoresUser18User77 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s077);
            sv.ImpostorScoresUser18User78 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s078);
            sv.ImpostorScoresUser18User79 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s079);
            sv.ImpostorScoresUser18User80 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s080);

            sv.ImpostorScoresUser18User81 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s081);
            sv.ImpostorScoresUser18User82 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s082);
            sv.ImpostorScoresUser18User83 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s083);
            sv.ImpostorScoresUser18User84 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s084);
            sv.ImpostorScoresUser18User85 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s085);
            sv.ImpostorScoresUser18User86 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s086);
            sv.ImpostorScoresUser18User87 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s087);
            sv.ImpostorScoresUser18User88 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s088);
            sv.ImpostorScoresUser18User89 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s089);
            sv.ImpostorScoresUser18User90 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s090);

            sv.ImpostorScoresUser18User91 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s091);
            sv.ImpostorScoresUser18User92 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s092);
            sv.ImpostorScoresUser18User93 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s093);
            sv.ImpostorScoresUser18User94 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s094);
            sv.ImpostorScoresUser18User95 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s095);
            sv.ImpostorScoresUser18User96 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s096);
            sv.ImpostorScoresUser18User97 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s097);
            sv.ImpostorScoresUser18User98 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s098);
            sv.ImpostorScoresUser18User99 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s099);
            sv.ImpostorScoresUser18User100 = ScaledManhDist.CalculateImpostorScores(s018Mean, stdDevUser18, s100);
            #endregion

            #region User 19 Impostor scores
            sv.ImpostorScoresUser19User1 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s001);
            sv.ImpostorScoresUser19User2 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s002);
            sv.ImpostorScoresUser19User3 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s003);
            sv.ImpostorScoresUser19User4 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s004);
            sv.ImpostorScoresUser19User5 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s005);
            sv.ImpostorScoresUser19User6 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s006);
            sv.ImpostorScoresUser19User7 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s007);
            sv.ImpostorScoresUser19User8 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s008);
            sv.ImpostorScoresUser19User9 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s009);
            sv.ImpostorScoresUser19User10 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s010);

            sv.ImpostorScoresUser19User11 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s011);
            sv.ImpostorScoresUser19User12 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s012);
            sv.ImpostorScoresUser19User13 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s013);
            sv.ImpostorScoresUser19User14 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s014);
            sv.ImpostorScoresUser19User15 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s015);
            sv.ImpostorScoresUser19User16 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s016);
            sv.ImpostorScoresUser19User17 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s017);
            sv.ImpostorScoresUser19User18 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s018);
            sv.ImpostorScoresUser19User20 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s020);

            sv.ImpostorScoresUser19User21 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s021);
            sv.ImpostorScoresUser19User22 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s022);
            sv.ImpostorScoresUser19User23 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s023);
            sv.ImpostorScoresUser19User24 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s024);
            sv.ImpostorScoresUser19User25 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s025);
            sv.ImpostorScoresUser19User26 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s026);
            sv.ImpostorScoresUser19User27 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s027);
            sv.ImpostorScoresUser19User28 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s028);
            sv.ImpostorScoresUser19User29 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s029);
            sv.ImpostorScoresUser19User30 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s030);

            sv.ImpostorScoresUser19User31 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s031);
            sv.ImpostorScoresUser19User32 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s032);
            sv.ImpostorScoresUser19User33 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s033);
            sv.ImpostorScoresUser19User34 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s034);
            sv.ImpostorScoresUser19User35 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s035);
            sv.ImpostorScoresUser19User36 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s036);
            sv.ImpostorScoresUser19User37 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s037);
            sv.ImpostorScoresUser19User38 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s038);
            sv.ImpostorScoresUser19User39 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s039);
            sv.ImpostorScoresUser19User40 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s040);

            sv.ImpostorScoresUser19User41 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s041);
            sv.ImpostorScoresUser19User42 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s042);
            sv.ImpostorScoresUser19User43 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s043);
            sv.ImpostorScoresUser19User44 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s044);
            sv.ImpostorScoresUser19User45 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s045);
            sv.ImpostorScoresUser19User46 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s046);
            sv.ImpostorScoresUser19User47 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s047);
            sv.ImpostorScoresUser19User48 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s048);
            sv.ImpostorScoresUser19User49 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s049);
            sv.ImpostorScoresUser19User50 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s050);

            sv.ImpostorScoresUser19User51 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s051);
            sv.ImpostorScoresUser19User52 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s052);
            sv.ImpostorScoresUser19User53 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s053);
            sv.ImpostorScoresUser19User54 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s054);
            sv.ImpostorScoresUser19User55 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s055);
            sv.ImpostorScoresUser19User56 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s056);
            sv.ImpostorScoresUser19User57 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s057);
            sv.ImpostorScoresUser19User58 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s058);
            sv.ImpostorScoresUser19User59 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s059);
            sv.ImpostorScoresUser19User60 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s060);

            sv.ImpostorScoresUser19User61 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s061);
            sv.ImpostorScoresUser19User62 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s062);
            sv.ImpostorScoresUser19User63 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s063);
            sv.ImpostorScoresUser19User64 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s064);
            sv.ImpostorScoresUser19User65 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s065);
            sv.ImpostorScoresUser19User66 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s066);
            sv.ImpostorScoresUser19User67 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s067);
            sv.ImpostorScoresUser19User68 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s068);
            sv.ImpostorScoresUser19User69 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s069);
            sv.ImpostorScoresUser19User70 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s070);

            sv.ImpostorScoresUser19User71 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s071);
            sv.ImpostorScoresUser19User72 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s072);
            sv.ImpostorScoresUser19User73 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s073);
            sv.ImpostorScoresUser19User74 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s074);
            sv.ImpostorScoresUser19User75 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s075);
            sv.ImpostorScoresUser19User76 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s076);
            sv.ImpostorScoresUser19User77 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s077);
            sv.ImpostorScoresUser19User78 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s078);
            sv.ImpostorScoresUser19User79 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s079);
            sv.ImpostorScoresUser19User80 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s080);

            sv.ImpostorScoresUser19User81 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s081);
            sv.ImpostorScoresUser19User82 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s082);
            sv.ImpostorScoresUser19User83 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s083);
            sv.ImpostorScoresUser19User84 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s084);
            sv.ImpostorScoresUser19User85 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s085);
            sv.ImpostorScoresUser19User86 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s086);
            sv.ImpostorScoresUser19User87 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s087);
            sv.ImpostorScoresUser19User88 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s088);
            sv.ImpostorScoresUser19User89 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s089);
            sv.ImpostorScoresUser19User90 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s090);

            sv.ImpostorScoresUser19User91 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s091);
            sv.ImpostorScoresUser19User92 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s092);
            sv.ImpostorScoresUser19User93 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s093);
            sv.ImpostorScoresUser19User94 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s094);
            sv.ImpostorScoresUser19User95 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s095);
            sv.ImpostorScoresUser19User96 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s096);
            sv.ImpostorScoresUser19User97 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s097);
            sv.ImpostorScoresUser19User98 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s098);
            sv.ImpostorScoresUser19User99 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s099);
            sv.ImpostorScoresUser19User100 = ScaledManhDist.CalculateImpostorScores(s019Mean, stdDevUser19, s100);
            #endregion

            #region User 20 Impostor scores
            sv.ImpostorScoresUser20User1 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s001);
            sv.ImpostorScoresUser20User2 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s002);
            sv.ImpostorScoresUser20User3 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s003);
            sv.ImpostorScoresUser20User4 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s004);
            sv.ImpostorScoresUser20User5 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s005);
            sv.ImpostorScoresUser20User6 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s006);
            sv.ImpostorScoresUser20User7 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s007);
            sv.ImpostorScoresUser20User8 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s008);
            sv.ImpostorScoresUser20User9 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s009);
            sv.ImpostorScoresUser20User10 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s010);

            sv.ImpostorScoresUser20User11 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s011);
            sv.ImpostorScoresUser20User12 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s012);
            sv.ImpostorScoresUser20User13 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s013);
            sv.ImpostorScoresUser20User14 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s014);
            sv.ImpostorScoresUser20User15 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s015);
            sv.ImpostorScoresUser20User16 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s016);
            sv.ImpostorScoresUser20User17 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s017);
            sv.ImpostorScoresUser20User18 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s018);
            sv.ImpostorScoresUser20User19 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s019);

            sv.ImpostorScoresUser20User21 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s021);
            sv.ImpostorScoresUser20User22 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s022);
            sv.ImpostorScoresUser20User23 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s023);
            sv.ImpostorScoresUser20User24 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s024);
            sv.ImpostorScoresUser20User25 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s025);
            sv.ImpostorScoresUser20User26 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s026);
            sv.ImpostorScoresUser20User27 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s027);
            sv.ImpostorScoresUser20User28 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s028);
            sv.ImpostorScoresUser20User29 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s029);
            sv.ImpostorScoresUser20User30 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s030);

            sv.ImpostorScoresUser20User31 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s031);
            sv.ImpostorScoresUser20User32 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s032);
            sv.ImpostorScoresUser20User33 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s033);
            sv.ImpostorScoresUser20User34 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s034);
            sv.ImpostorScoresUser20User35 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s035);
            sv.ImpostorScoresUser20User36 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s036);
            sv.ImpostorScoresUser20User37 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s037);
            sv.ImpostorScoresUser20User38 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s038);
            sv.ImpostorScoresUser20User39 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s039);
            sv.ImpostorScoresUser20User40 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s040);

            sv.ImpostorScoresUser20User41 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s041);
            sv.ImpostorScoresUser20User42 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s042);
            sv.ImpostorScoresUser20User43 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s043);
            sv.ImpostorScoresUser20User44 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s044);
            sv.ImpostorScoresUser20User45 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s045);
            sv.ImpostorScoresUser20User46 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s046);
            sv.ImpostorScoresUser20User47 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s047);
            sv.ImpostorScoresUser20User48 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s048);
            sv.ImpostorScoresUser20User49 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s049);
            sv.ImpostorScoresUser20User50 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s050);

            sv.ImpostorScoresUser20User51 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s051);
            sv.ImpostorScoresUser20User52 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s052);
            sv.ImpostorScoresUser20User53 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s053);
            sv.ImpostorScoresUser20User54 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s054);
            sv.ImpostorScoresUser20User55 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s055);
            sv.ImpostorScoresUser20User56 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s056);
            sv.ImpostorScoresUser20User57 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s057);
            sv.ImpostorScoresUser20User58 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s058);
            sv.ImpostorScoresUser20User59 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s059);
            sv.ImpostorScoresUser20User60 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s060);

            sv.ImpostorScoresUser20User61 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s061);
            sv.ImpostorScoresUser20User62 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s062);
            sv.ImpostorScoresUser20User63 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s063);
            sv.ImpostorScoresUser20User64 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s064);
            sv.ImpostorScoresUser20User65 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s065);
            sv.ImpostorScoresUser20User66 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s066);
            sv.ImpostorScoresUser20User67 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s067);
            sv.ImpostorScoresUser20User68 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s068);
            sv.ImpostorScoresUser20User69 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s069);
            sv.ImpostorScoresUser20User70 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s070);

            sv.ImpostorScoresUser20User71 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s071);
            sv.ImpostorScoresUser20User72 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s072);
            sv.ImpostorScoresUser20User73 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s073);
            sv.ImpostorScoresUser20User74 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s074);
            sv.ImpostorScoresUser20User75 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s075);
            sv.ImpostorScoresUser20User76 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s076);
            sv.ImpostorScoresUser20User77 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s077);
            sv.ImpostorScoresUser20User78 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s078);
            sv.ImpostorScoresUser20User79 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s079);
            sv.ImpostorScoresUser20User80 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s080);

            sv.ImpostorScoresUser20User81 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s081);
            sv.ImpostorScoresUser20User82 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s082);
            sv.ImpostorScoresUser20User83 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s083);
            sv.ImpostorScoresUser20User84 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s084);
            sv.ImpostorScoresUser20User85 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s085);
            sv.ImpostorScoresUser20User86 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s086);
            sv.ImpostorScoresUser20User87 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s087);
            sv.ImpostorScoresUser20User88 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s088);
            sv.ImpostorScoresUser20User89 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s089);
            sv.ImpostorScoresUser20User90 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s090);

            sv.ImpostorScoresUser20User91 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s091);
            sv.ImpostorScoresUser20User92 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s092);
            sv.ImpostorScoresUser20User93 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s093);
            sv.ImpostorScoresUser20User94 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s094);
            sv.ImpostorScoresUser20User95 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s095);
            sv.ImpostorScoresUser20User96 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s096);
            sv.ImpostorScoresUser20User97 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s097);
            sv.ImpostorScoresUser20User98 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s098);
            sv.ImpostorScoresUser20User99 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s099);
            sv.ImpostorScoresUser20User100 = ScaledManhDist.CalculateImpostorScores(s020Mean, stdDevUser20, s100);
            #endregion

            #region User 21 Impostor scores
            sv.ImpostorScoresUser21User1 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s001);
            sv.ImpostorScoresUser21User2 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s002);
            sv.ImpostorScoresUser21User3 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s003);
            sv.ImpostorScoresUser21User4 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s004);
            sv.ImpostorScoresUser21User5 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s005);
            sv.ImpostorScoresUser21User6 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s006);
            sv.ImpostorScoresUser21User7 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s007);
            sv.ImpostorScoresUser21User8 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s008);
            sv.ImpostorScoresUser21User9 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s009);
            sv.ImpostorScoresUser21User10 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s010);

            sv.ImpostorScoresUser21User11 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s011);
            sv.ImpostorScoresUser21User12 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s012);
            sv.ImpostorScoresUser21User13 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s013);
            sv.ImpostorScoresUser21User14 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s014);
            sv.ImpostorScoresUser21User15 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s015);
            sv.ImpostorScoresUser21User16 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s016);
            sv.ImpostorScoresUser21User17 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s017);
            sv.ImpostorScoresUser21User18 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s018);
            sv.ImpostorScoresUser21User19 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s019);
            sv.ImpostorScoresUser21User20 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s020);

            sv.ImpostorScoresUser21User22 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s022);
            sv.ImpostorScoresUser21User23 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s023);
            sv.ImpostorScoresUser21User24 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s024);
            sv.ImpostorScoresUser21User25 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s025);
            sv.ImpostorScoresUser21User26 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s026);
            sv.ImpostorScoresUser21User27 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s027);
            sv.ImpostorScoresUser21User28 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s028);
            sv.ImpostorScoresUser21User29 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s029);
            sv.ImpostorScoresUser21User30 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s030);

            sv.ImpostorScoresUser21User31 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s031);
            sv.ImpostorScoresUser21User32 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s032);
            sv.ImpostorScoresUser21User33 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s033);
            sv.ImpostorScoresUser21User34 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s034);
            sv.ImpostorScoresUser21User35 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s035);
            sv.ImpostorScoresUser21User36 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s036);
            sv.ImpostorScoresUser21User37 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s037);
            sv.ImpostorScoresUser21User38 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s038);
            sv.ImpostorScoresUser21User39 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s039);
            sv.ImpostorScoresUser21User40 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s040);

            sv.ImpostorScoresUser21User41 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s041);
            sv.ImpostorScoresUser21User42 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s042);
            sv.ImpostorScoresUser21User43 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s043);
            sv.ImpostorScoresUser21User44 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s044);
            sv.ImpostorScoresUser21User45 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s045);
            sv.ImpostorScoresUser21User46 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s046);
            sv.ImpostorScoresUser21User47 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s047);
            sv.ImpostorScoresUser21User48 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s048);
            sv.ImpostorScoresUser21User49 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s049);
            sv.ImpostorScoresUser21User50 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s050);

            sv.ImpostorScoresUser21User51 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s051);
            sv.ImpostorScoresUser21User52 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s052);
            sv.ImpostorScoresUser21User53 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s053);
            sv.ImpostorScoresUser21User54 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s054);
            sv.ImpostorScoresUser21User55 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s055);
            sv.ImpostorScoresUser21User56 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s056);
            sv.ImpostorScoresUser21User57 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s057);
            sv.ImpostorScoresUser21User58 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s058);
            sv.ImpostorScoresUser21User59 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s059);
            sv.ImpostorScoresUser21User60 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s060);

            sv.ImpostorScoresUser21User61 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s061);
            sv.ImpostorScoresUser21User62 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s062);
            sv.ImpostorScoresUser21User63 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s063);
            sv.ImpostorScoresUser21User64 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s064);
            sv.ImpostorScoresUser21User65 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s065);
            sv.ImpostorScoresUser21User66 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s066);
            sv.ImpostorScoresUser21User67 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s067);
            sv.ImpostorScoresUser21User68 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s068);
            sv.ImpostorScoresUser21User69 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s069);
            sv.ImpostorScoresUser21User70 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s070);

            sv.ImpostorScoresUser21User71 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s071);
            sv.ImpostorScoresUser21User72 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s072);
            sv.ImpostorScoresUser21User73 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s073);
            sv.ImpostorScoresUser21User74 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s074);
            sv.ImpostorScoresUser21User75 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s075);
            sv.ImpostorScoresUser21User76 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s076);
            sv.ImpostorScoresUser21User77 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s077);
            sv.ImpostorScoresUser21User78 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s078);
            sv.ImpostorScoresUser21User79 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s079);
            sv.ImpostorScoresUser21User80 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s080);

            sv.ImpostorScoresUser21User81 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s081);
            sv.ImpostorScoresUser21User82 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s082);
            sv.ImpostorScoresUser21User83 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s083);
            sv.ImpostorScoresUser21User84 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s084);
            sv.ImpostorScoresUser21User85 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s085);
            sv.ImpostorScoresUser21User86 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s086);
            sv.ImpostorScoresUser21User87 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s087);
            sv.ImpostorScoresUser21User88 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s088);
            sv.ImpostorScoresUser21User89 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s089);
            sv.ImpostorScoresUser21User90 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s090);

            sv.ImpostorScoresUser21User91 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s091);
            sv.ImpostorScoresUser21User92 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s092);
            sv.ImpostorScoresUser21User93 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s093);
            sv.ImpostorScoresUser21User94 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s094);
            sv.ImpostorScoresUser21User95 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s095);
            sv.ImpostorScoresUser21User96 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s096);
            sv.ImpostorScoresUser21User97 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s097);
            sv.ImpostorScoresUser21User98 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s098);
            sv.ImpostorScoresUser21User99 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s099);
            sv.ImpostorScoresUser21User100 = ScaledManhDist.CalculateImpostorScores(s021Mean, stdDevUser21, s100);
            #endregion

            #region User 22 Impostor scores
            sv.ImpostorScoresUser22User1 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s001);
            sv.ImpostorScoresUser22User2 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s002);
            sv.ImpostorScoresUser22User3 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s003);
            sv.ImpostorScoresUser22User4 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s004);
            sv.ImpostorScoresUser22User5 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s005);
            sv.ImpostorScoresUser22User6 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s006);
            sv.ImpostorScoresUser22User7 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s007);
            sv.ImpostorScoresUser22User8 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s008);
            sv.ImpostorScoresUser22User9 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s009);
            sv.ImpostorScoresUser22User10 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s010);

            sv.ImpostorScoresUser22User11 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s011);
            sv.ImpostorScoresUser22User12 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s012);
            sv.ImpostorScoresUser22User13 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s013);
            sv.ImpostorScoresUser22User14 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s014);
            sv.ImpostorScoresUser22User15 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s015);
            sv.ImpostorScoresUser22User16 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s016);
            sv.ImpostorScoresUser22User17 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s017);
            sv.ImpostorScoresUser22User18 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s018);
            sv.ImpostorScoresUser22User19 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s019);
            sv.ImpostorScoresUser22User20 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s020);

            sv.ImpostorScoresUser22User21 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s022);
            sv.ImpostorScoresUser22User23 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s023);
            sv.ImpostorScoresUser22User24 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s024);
            sv.ImpostorScoresUser22User25 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s025);
            sv.ImpostorScoresUser22User26 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s026);
            sv.ImpostorScoresUser22User27 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s027);
            sv.ImpostorScoresUser22User28 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s028);
            sv.ImpostorScoresUser22User29 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s029);
            sv.ImpostorScoresUser22User30 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s030);

            sv.ImpostorScoresUser22User31 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s031);
            sv.ImpostorScoresUser22User32 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s032);
            sv.ImpostorScoresUser22User33 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s033);
            sv.ImpostorScoresUser22User34 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s034);
            sv.ImpostorScoresUser22User35 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s035);
            sv.ImpostorScoresUser22User36 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s036);
            sv.ImpostorScoresUser22User37 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s037);
            sv.ImpostorScoresUser22User38 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s038);
            sv.ImpostorScoresUser22User39 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s039);
            sv.ImpostorScoresUser22User40 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s040);

            sv.ImpostorScoresUser22User41 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s041);
            sv.ImpostorScoresUser22User42 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s042);
            sv.ImpostorScoresUser22User43 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s043);
            sv.ImpostorScoresUser22User44 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s044);
            sv.ImpostorScoresUser22User45 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s045);
            sv.ImpostorScoresUser22User46 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s046);
            sv.ImpostorScoresUser22User47 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s047);
            sv.ImpostorScoresUser22User48 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s048);
            sv.ImpostorScoresUser22User49 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s049);
            sv.ImpostorScoresUser22User50 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s050);

            sv.ImpostorScoresUser22User51 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s051);
            sv.ImpostorScoresUser22User52 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s052);
            sv.ImpostorScoresUser22User53 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s053);
            sv.ImpostorScoresUser22User54 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s054);
            sv.ImpostorScoresUser22User55 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s055);
            sv.ImpostorScoresUser22User56 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s056);
            sv.ImpostorScoresUser22User57 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s057);
            sv.ImpostorScoresUser22User58 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s058);
            sv.ImpostorScoresUser22User59 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s059);
            sv.ImpostorScoresUser22User60 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s060);

            sv.ImpostorScoresUser22User61 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s061);
            sv.ImpostorScoresUser22User62 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s062);
            sv.ImpostorScoresUser22User63 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s063);
            sv.ImpostorScoresUser22User64 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s064);
            sv.ImpostorScoresUser22User65 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s065);
            sv.ImpostorScoresUser22User66 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s066);
            sv.ImpostorScoresUser22User67 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s067);
            sv.ImpostorScoresUser22User68 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s068);
            sv.ImpostorScoresUser22User69 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s069);
            sv.ImpostorScoresUser22User70 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s070);

            sv.ImpostorScoresUser22User71 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s071);
            sv.ImpostorScoresUser22User72 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s072);
            sv.ImpostorScoresUser22User73 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s073);
            sv.ImpostorScoresUser22User74 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s074);
            sv.ImpostorScoresUser22User75 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s075);
            sv.ImpostorScoresUser22User76 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s076);
            sv.ImpostorScoresUser22User77 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s077);
            sv.ImpostorScoresUser22User78 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s078);
            sv.ImpostorScoresUser22User79 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s079);
            sv.ImpostorScoresUser22User80 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s080);

            sv.ImpostorScoresUser22User81 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s081);
            sv.ImpostorScoresUser22User82 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s082);
            sv.ImpostorScoresUser22User83 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s083);
            sv.ImpostorScoresUser22User84 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s084);
            sv.ImpostorScoresUser22User85 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s085);
            sv.ImpostorScoresUser22User86 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s086);
            sv.ImpostorScoresUser22User87 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s087);
            sv.ImpostorScoresUser22User88 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s088);
            sv.ImpostorScoresUser22User89 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s089);
            sv.ImpostorScoresUser22User90 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s090);

            sv.ImpostorScoresUser22User91 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s091);
            sv.ImpostorScoresUser22User92 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s092);
            sv.ImpostorScoresUser22User93 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s093);
            sv.ImpostorScoresUser22User94 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s094);
            sv.ImpostorScoresUser22User95 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s095);
            sv.ImpostorScoresUser22User96 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s096);
            sv.ImpostorScoresUser22User97 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s097);
            sv.ImpostorScoresUser22User98 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s098);
            sv.ImpostorScoresUser22User99 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s099);
            sv.ImpostorScoresUser22User100 = ScaledManhDist.CalculateImpostorScores(s022Mean, stdDevUser22, s100);
            #endregion

            #region User 23 Impostor scores
            sv.ImpostorScoresUser23User1 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s001);
            sv.ImpostorScoresUser23User2 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s002);
            sv.ImpostorScoresUser23User3 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s003);
            sv.ImpostorScoresUser23User4 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s004);
            sv.ImpostorScoresUser23User5 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s005);
            sv.ImpostorScoresUser23User6 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s006);
            sv.ImpostorScoresUser23User7 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s007);
            sv.ImpostorScoresUser23User8 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s008);
            sv.ImpostorScoresUser23User9 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s009);
            sv.ImpostorScoresUser23User10 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s010);

            sv.ImpostorScoresUser23User11 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s011);
            sv.ImpostorScoresUser23User12 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s012);
            sv.ImpostorScoresUser23User13 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s013);
            sv.ImpostorScoresUser23User14 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s014);
            sv.ImpostorScoresUser23User15 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s015);
            sv.ImpostorScoresUser23User16 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s016);
            sv.ImpostorScoresUser23User17 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s017);
            sv.ImpostorScoresUser23User18 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s018);
            sv.ImpostorScoresUser23User19 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s019);
            sv.ImpostorScoresUser23User20 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s020);

            sv.ImpostorScoresUser23User21 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s021);
            sv.ImpostorScoresUser23User22 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s022);
            sv.ImpostorScoresUser23User24 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s024);
            sv.ImpostorScoresUser23User25 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s025);
            sv.ImpostorScoresUser23User26 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s026);
            sv.ImpostorScoresUser23User27 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s027);
            sv.ImpostorScoresUser23User28 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s028);
            sv.ImpostorScoresUser23User29 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s029);
            sv.ImpostorScoresUser23User30 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s030);

            sv.ImpostorScoresUser23User31 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s031);
            sv.ImpostorScoresUser23User32 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s032);
            sv.ImpostorScoresUser23User33 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s033);
            sv.ImpostorScoresUser23User34 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s034);
            sv.ImpostorScoresUser23User35 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s035);
            sv.ImpostorScoresUser23User36 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s036);
            sv.ImpostorScoresUser23User37 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s037);
            sv.ImpostorScoresUser23User38 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s038);
            sv.ImpostorScoresUser23User39 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s039);
            sv.ImpostorScoresUser23User40 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s040);

            sv.ImpostorScoresUser23User41 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s041);
            sv.ImpostorScoresUser23User42 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s042);
            sv.ImpostorScoresUser23User43 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s043);
            sv.ImpostorScoresUser23User44 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s044);
            sv.ImpostorScoresUser23User45 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s045);
            sv.ImpostorScoresUser23User46 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s046);
            sv.ImpostorScoresUser23User47 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s047);
            sv.ImpostorScoresUser23User48 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s048);
            sv.ImpostorScoresUser23User49 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s049);
            sv.ImpostorScoresUser23User50 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s050);

            sv.ImpostorScoresUser23User51 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s051);
            sv.ImpostorScoresUser23User52 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s052);
            sv.ImpostorScoresUser23User53 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s053);
            sv.ImpostorScoresUser23User54 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s054);
            sv.ImpostorScoresUser23User55 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s055);
            sv.ImpostorScoresUser23User56 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s056);
            sv.ImpostorScoresUser23User57 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s057);
            sv.ImpostorScoresUser23User58 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s058);
            sv.ImpostorScoresUser23User59 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s059);
            sv.ImpostorScoresUser23User60 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s060);

            sv.ImpostorScoresUser23User61 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s061);
            sv.ImpostorScoresUser23User62 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s062);
            sv.ImpostorScoresUser23User63 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s063);
            sv.ImpostorScoresUser23User64 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s064);
            sv.ImpostorScoresUser23User65 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s065);
            sv.ImpostorScoresUser23User66 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s066);
            sv.ImpostorScoresUser23User67 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s067);
            sv.ImpostorScoresUser23User68 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s068);
            sv.ImpostorScoresUser23User69 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s069);
            sv.ImpostorScoresUser23User70 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s070);

            sv.ImpostorScoresUser23User71 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s071);
            sv.ImpostorScoresUser23User72 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s072);
            sv.ImpostorScoresUser23User73 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s073);
            sv.ImpostorScoresUser23User74 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s074);
            sv.ImpostorScoresUser23User75 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s075);
            sv.ImpostorScoresUser23User76 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s076);
            sv.ImpostorScoresUser23User77 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s077);
            sv.ImpostorScoresUser23User78 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s078);
            sv.ImpostorScoresUser23User79 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s079);
            sv.ImpostorScoresUser23User80 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s080);

            sv.ImpostorScoresUser23User81 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s081);
            sv.ImpostorScoresUser23User82 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s082);
            sv.ImpostorScoresUser23User83 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s083);
            sv.ImpostorScoresUser23User84 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s084);
            sv.ImpostorScoresUser23User85 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s085);
            sv.ImpostorScoresUser23User86 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s086);
            sv.ImpostorScoresUser23User87 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s087);
            sv.ImpostorScoresUser23User88 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s088);
            sv.ImpostorScoresUser23User89 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s089);
            sv.ImpostorScoresUser23User90 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s090);

            sv.ImpostorScoresUser23User91 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s091);
            sv.ImpostorScoresUser23User92 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s092);
            sv.ImpostorScoresUser23User93 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s093);
            sv.ImpostorScoresUser23User94 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s094);
            sv.ImpostorScoresUser23User95 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s095);
            sv.ImpostorScoresUser23User96 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s096);
            sv.ImpostorScoresUser23User97 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s097);
            sv.ImpostorScoresUser23User98 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s098);
            sv.ImpostorScoresUser23User99 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s099);
            sv.ImpostorScoresUser23User100 = ScaledManhDist.CalculateImpostorScores(s023Mean, stdDevUser23, s100);
            #endregion

            #region User 24 Impostor scores
            sv.ImpostorScoresUser24User1 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s001);
            sv.ImpostorScoresUser24User2 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s002);
            sv.ImpostorScoresUser24User3 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s003);
            sv.ImpostorScoresUser24User4 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s004);
            sv.ImpostorScoresUser24User5 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s005);
            sv.ImpostorScoresUser24User6 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s006);
            sv.ImpostorScoresUser24User7 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s007);
            sv.ImpostorScoresUser24User8 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s008);
            sv.ImpostorScoresUser24User9 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s009);
            sv.ImpostorScoresUser24User10 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s010);

            sv.ImpostorScoresUser24User11 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s011);
            sv.ImpostorScoresUser24User12 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s012);
            sv.ImpostorScoresUser24User13 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s013);
            sv.ImpostorScoresUser24User14 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s014);
            sv.ImpostorScoresUser24User15 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s015);
            sv.ImpostorScoresUser24User16 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s016);
            sv.ImpostorScoresUser24User17 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s017);
            sv.ImpostorScoresUser24User18 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s018);
            sv.ImpostorScoresUser24User19 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s019);
            sv.ImpostorScoresUser24User20 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s020);

            sv.ImpostorScoresUser24User21 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s021);
            sv.ImpostorScoresUser24User22 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s022);
            sv.ImpostorScoresUser24User23 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s023);
            sv.ImpostorScoresUser24User25 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s025);
            sv.ImpostorScoresUser24User26 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s026);
            sv.ImpostorScoresUser24User27 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s027);
            sv.ImpostorScoresUser24User28 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s028);
            sv.ImpostorScoresUser24User29 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s029);
            sv.ImpostorScoresUser24User30 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s030);

            sv.ImpostorScoresUser24User31 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s031);
            sv.ImpostorScoresUser24User32 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s032);
            sv.ImpostorScoresUser24User33 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s033);
            sv.ImpostorScoresUser24User34 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s034);
            sv.ImpostorScoresUser24User35 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s035);
            sv.ImpostorScoresUser24User36 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s036);
            sv.ImpostorScoresUser24User37 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s037);
            sv.ImpostorScoresUser24User38 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s038);
            sv.ImpostorScoresUser24User39 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s039);
            sv.ImpostorScoresUser24User40 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s040);

            sv.ImpostorScoresUser24User41 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s041);
            sv.ImpostorScoresUser24User42 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s042);
            sv.ImpostorScoresUser24User43 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s043);
            sv.ImpostorScoresUser24User44 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s044);
            sv.ImpostorScoresUser24User45 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s045);
            sv.ImpostorScoresUser24User46 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s046);
            sv.ImpostorScoresUser24User47 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s047);
            sv.ImpostorScoresUser24User48 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s048);
            sv.ImpostorScoresUser24User49 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s049);
            sv.ImpostorScoresUser24User50 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s050);

            sv.ImpostorScoresUser24User51 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s051);
            sv.ImpostorScoresUser24User52 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s052);
            sv.ImpostorScoresUser24User53 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s053);
            sv.ImpostorScoresUser24User54 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s054);
            sv.ImpostorScoresUser24User55 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s055);
            sv.ImpostorScoresUser24User56 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s056);
            sv.ImpostorScoresUser24User57 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s057);
            sv.ImpostorScoresUser24User58 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s058);
            sv.ImpostorScoresUser24User59 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s059);
            sv.ImpostorScoresUser24User60 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s060);

            sv.ImpostorScoresUser24User61 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s061);
            sv.ImpostorScoresUser24User62 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s062);
            sv.ImpostorScoresUser24User63 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s063);
            sv.ImpostorScoresUser24User64 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s064);
            sv.ImpostorScoresUser24User65 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s065);
            sv.ImpostorScoresUser24User66 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s066);
            sv.ImpostorScoresUser24User67 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s067);
            sv.ImpostorScoresUser24User68 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s068);
            sv.ImpostorScoresUser24User69 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s069);
            sv.ImpostorScoresUser24User70 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s070);

            sv.ImpostorScoresUser24User71 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s071);
            sv.ImpostorScoresUser24User72 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s072);
            sv.ImpostorScoresUser24User73 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s073);
            sv.ImpostorScoresUser24User74 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s074);
            sv.ImpostorScoresUser24User75 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s075);
            sv.ImpostorScoresUser24User76 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s076);
            sv.ImpostorScoresUser24User77 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s077);
            sv.ImpostorScoresUser24User78 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s078);
            sv.ImpostorScoresUser24User79 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s079);
            sv.ImpostorScoresUser24User80 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s080);

            sv.ImpostorScoresUser24User81 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s081);
            sv.ImpostorScoresUser24User82 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s082);
            sv.ImpostorScoresUser24User83 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s083);
            sv.ImpostorScoresUser24User84 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s084);
            sv.ImpostorScoresUser24User85 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s085);
            sv.ImpostorScoresUser24User86 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s086);
            sv.ImpostorScoresUser24User87 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s087);
            sv.ImpostorScoresUser24User88 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s088);
            sv.ImpostorScoresUser24User89 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s089);
            sv.ImpostorScoresUser24User90 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s090);

            sv.ImpostorScoresUser24User91 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s091);
            sv.ImpostorScoresUser24User92 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s092);
            sv.ImpostorScoresUser24User93 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s093);
            sv.ImpostorScoresUser24User94 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s094);
            sv.ImpostorScoresUser24User95 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s095);
            sv.ImpostorScoresUser24User96 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s096);
            sv.ImpostorScoresUser24User97 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s097);
            sv.ImpostorScoresUser24User98 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s098);
            sv.ImpostorScoresUser24User99 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s099);
            sv.ImpostorScoresUser24User100 = ScaledManhDist.CalculateImpostorScores(s024Mean, stdDevUser24, s100);
            #endregion

            #region User 25 Impostor scores
            sv.ImpostorScoresUser25User1 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s001);
            sv.ImpostorScoresUser25User2 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s002);
            sv.ImpostorScoresUser25User3 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s003);
            sv.ImpostorScoresUser25User4 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s004);
            sv.ImpostorScoresUser25User5 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s005);
            sv.ImpostorScoresUser25User6 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s006);
            sv.ImpostorScoresUser25User7 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s007);
            sv.ImpostorScoresUser25User8 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s008);
            sv.ImpostorScoresUser25User9 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s009);
            sv.ImpostorScoresUser25User10 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s010);

            sv.ImpostorScoresUser25User11 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s011);
            sv.ImpostorScoresUser25User12 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s012);
            sv.ImpostorScoresUser25User13 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s013);
            sv.ImpostorScoresUser25User14 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s014);
            sv.ImpostorScoresUser25User15 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s015);
            sv.ImpostorScoresUser25User16 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s016);
            sv.ImpostorScoresUser25User17 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s017);
            sv.ImpostorScoresUser25User18 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s018);
            sv.ImpostorScoresUser25User19 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s019);
            sv.ImpostorScoresUser25User20 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s020);

            sv.ImpostorScoresUser25User21 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s021);
            sv.ImpostorScoresUser25User22 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s022);
            sv.ImpostorScoresUser25User23 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s023);
            sv.ImpostorScoresUser25User24 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s024);
            sv.ImpostorScoresUser25User26 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s026);
            sv.ImpostorScoresUser25User27 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s027);
            sv.ImpostorScoresUser25User28 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s028);
            sv.ImpostorScoresUser25User29 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s029);
            sv.ImpostorScoresUser25User30 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s030);

            sv.ImpostorScoresUser25User31 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s031);
            sv.ImpostorScoresUser25User32 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s032);
            sv.ImpostorScoresUser25User33 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s033);
            sv.ImpostorScoresUser25User34 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s034);
            sv.ImpostorScoresUser25User35 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s035);
            sv.ImpostorScoresUser25User36 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s036);
            sv.ImpostorScoresUser25User37 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s037);
            sv.ImpostorScoresUser25User38 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s038);
            sv.ImpostorScoresUser25User39 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s039);
            sv.ImpostorScoresUser25User40 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s040);

            sv.ImpostorScoresUser25User41 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s041);
            sv.ImpostorScoresUser25User42 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s042);
            sv.ImpostorScoresUser25User43 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s043);
            sv.ImpostorScoresUser25User44 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s044);
            sv.ImpostorScoresUser25User45 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s045);
            sv.ImpostorScoresUser25User46 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s046);
            sv.ImpostorScoresUser25User47 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s047);
            sv.ImpostorScoresUser25User48 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s048);
            sv.ImpostorScoresUser25User49 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s049);
            sv.ImpostorScoresUser25User50 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s050);

            sv.ImpostorScoresUser25User51 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s051);
            sv.ImpostorScoresUser25User52 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s052);
            sv.ImpostorScoresUser25User53 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s053);
            sv.ImpostorScoresUser25User54 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s054);
            sv.ImpostorScoresUser25User55 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s055);
            sv.ImpostorScoresUser25User56 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s056);
            sv.ImpostorScoresUser25User57 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s057);
            sv.ImpostorScoresUser25User58 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s058);
            sv.ImpostorScoresUser25User59 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s059);
            sv.ImpostorScoresUser25User60 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s060);

            sv.ImpostorScoresUser25User61 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s061);
            sv.ImpostorScoresUser25User62 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s062);
            sv.ImpostorScoresUser25User63 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s063);
            sv.ImpostorScoresUser25User64 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s064);
            sv.ImpostorScoresUser25User65 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s065);
            sv.ImpostorScoresUser25User66 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s066);
            sv.ImpostorScoresUser25User67 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s067);
            sv.ImpostorScoresUser25User68 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s068);
            sv.ImpostorScoresUser25User69 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s069);
            sv.ImpostorScoresUser25User70 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s070);

            sv.ImpostorScoresUser25User71 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s071);
            sv.ImpostorScoresUser25User72 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s072);
            sv.ImpostorScoresUser25User73 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s073);
            sv.ImpostorScoresUser25User74 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s074);
            sv.ImpostorScoresUser25User75 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s075);
            sv.ImpostorScoresUser25User76 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s076);
            sv.ImpostorScoresUser25User77 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s077);
            sv.ImpostorScoresUser25User78 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s078);
            sv.ImpostorScoresUser25User79 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s079);
            sv.ImpostorScoresUser25User80 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s080);

            sv.ImpostorScoresUser25User81 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s081);
            sv.ImpostorScoresUser25User82 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s082);
            sv.ImpostorScoresUser25User83 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s083);
            sv.ImpostorScoresUser25User84 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s084);
            sv.ImpostorScoresUser25User85 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s085);
            sv.ImpostorScoresUser25User86 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s086);
            sv.ImpostorScoresUser25User87 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s087);
            sv.ImpostorScoresUser25User88 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s088);
            sv.ImpostorScoresUser25User89 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s089);
            sv.ImpostorScoresUser25User90 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s090);

            sv.ImpostorScoresUser25User91 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s091);
            sv.ImpostorScoresUser25User92 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s092);
            sv.ImpostorScoresUser25User93 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s093);
            sv.ImpostorScoresUser25User94 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s094);
            sv.ImpostorScoresUser25User95 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s095);
            sv.ImpostorScoresUser25User96 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s096);
            sv.ImpostorScoresUser25User97 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s097);
            sv.ImpostorScoresUser25User98 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s098);
            sv.ImpostorScoresUser25User99 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s099);
            sv.ImpostorScoresUser25User100 = ScaledManhDist.CalculateImpostorScores(s025Mean, stdDevUser25, s100);
            #endregion

            #region User 26 Impostor scores
            sv.ImpostorScoresUser26User1 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s001);
            sv.ImpostorScoresUser26User2 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s002);
            sv.ImpostorScoresUser26User3 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s003);
            sv.ImpostorScoresUser26User4 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s004);
            sv.ImpostorScoresUser26User5 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s005);
            sv.ImpostorScoresUser26User6 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s006);
            sv.ImpostorScoresUser26User7 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s007);
            sv.ImpostorScoresUser26User8 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s008);
            sv.ImpostorScoresUser26User9 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s009);
            sv.ImpostorScoresUser26User10 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s010);

            sv.ImpostorScoresUser26User11 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s011);
            sv.ImpostorScoresUser26User12 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s012);
            sv.ImpostorScoresUser26User13 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s013);
            sv.ImpostorScoresUser26User14 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s014);
            sv.ImpostorScoresUser26User15 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s015);
            sv.ImpostorScoresUser26User16 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s016);
            sv.ImpostorScoresUser26User17 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s017);
            sv.ImpostorScoresUser26User18 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s018);
            sv.ImpostorScoresUser26User19 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s019);
            sv.ImpostorScoresUser26User20 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s020);

            sv.ImpostorScoresUser26User21 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s021);
            sv.ImpostorScoresUser26User22 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s022);
            sv.ImpostorScoresUser26User23 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s023);
            sv.ImpostorScoresUser26User24 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s024);
            sv.ImpostorScoresUser26User25 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s025);
            sv.ImpostorScoresUser26User27 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s027);
            sv.ImpostorScoresUser26User28 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s028);
            sv.ImpostorScoresUser26User29 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s029);
            sv.ImpostorScoresUser26User30 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s030);

            sv.ImpostorScoresUser26User31 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s031);
            sv.ImpostorScoresUser26User32 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s032);
            sv.ImpostorScoresUser26User33 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s033);
            sv.ImpostorScoresUser26User34 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s034);
            sv.ImpostorScoresUser26User35 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s035);
            sv.ImpostorScoresUser26User36 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s036);
            sv.ImpostorScoresUser26User37 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s037);
            sv.ImpostorScoresUser26User38 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s038);
            sv.ImpostorScoresUser26User39 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s039);
            sv.ImpostorScoresUser26User40 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s040);

            sv.ImpostorScoresUser26User41 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s041);
            sv.ImpostorScoresUser26User42 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s042);
            sv.ImpostorScoresUser26User43 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s043);
            sv.ImpostorScoresUser26User44 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s044);
            sv.ImpostorScoresUser26User45 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s045);
            sv.ImpostorScoresUser26User46 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s046);
            sv.ImpostorScoresUser26User47 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s047);
            sv.ImpostorScoresUser26User48 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s048);
            sv.ImpostorScoresUser26User49 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s049);
            sv.ImpostorScoresUser26User50 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s050);

            sv.ImpostorScoresUser26User51 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s051);
            sv.ImpostorScoresUser26User52 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s052);
            sv.ImpostorScoresUser26User53 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s053);
            sv.ImpostorScoresUser26User54 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s054);
            sv.ImpostorScoresUser26User55 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s055);
            sv.ImpostorScoresUser26User56 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s056);
            sv.ImpostorScoresUser26User57 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s057);
            sv.ImpostorScoresUser26User58 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s058);
            sv.ImpostorScoresUser26User59 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s059);
            sv.ImpostorScoresUser26User60 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s060);

            sv.ImpostorScoresUser26User61 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s061);
            sv.ImpostorScoresUser26User62 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s062);
            sv.ImpostorScoresUser26User63 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s063);
            sv.ImpostorScoresUser26User64 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s064);
            sv.ImpostorScoresUser26User65 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s065);
            sv.ImpostorScoresUser26User66 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s066);
            sv.ImpostorScoresUser26User67 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s067);
            sv.ImpostorScoresUser26User68 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s068);
            sv.ImpostorScoresUser26User69 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s069);
            sv.ImpostorScoresUser26User70 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s070);

            sv.ImpostorScoresUser26User71 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s071);
            sv.ImpostorScoresUser26User72 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s072);
            sv.ImpostorScoresUser26User73 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s073);
            sv.ImpostorScoresUser26User74 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s074);
            sv.ImpostorScoresUser26User75 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s075);
            sv.ImpostorScoresUser26User76 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s076);
            sv.ImpostorScoresUser26User77 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s077);
            sv.ImpostorScoresUser26User78 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s078);
            sv.ImpostorScoresUser26User79 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s079);
            sv.ImpostorScoresUser26User80 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s080);

            sv.ImpostorScoresUser26User81 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s081);
            sv.ImpostorScoresUser26User82 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s082);
            sv.ImpostorScoresUser26User83 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s083);
            sv.ImpostorScoresUser26User84 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s084);
            sv.ImpostorScoresUser26User85 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s085);
            sv.ImpostorScoresUser26User86 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s086);
            sv.ImpostorScoresUser26User87 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s087);
            sv.ImpostorScoresUser26User88 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s088);
            sv.ImpostorScoresUser26User89 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s089);
            sv.ImpostorScoresUser26User90 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s090);

            sv.ImpostorScoresUser26User91 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s091);
            sv.ImpostorScoresUser26User92 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s092);
            sv.ImpostorScoresUser26User93 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s093);
            sv.ImpostorScoresUser26User94 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s094);
            sv.ImpostorScoresUser26User95 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s095);
            sv.ImpostorScoresUser26User96 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s096);
            sv.ImpostorScoresUser26User97 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s097);
            sv.ImpostorScoresUser26User98 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s098);
            sv.ImpostorScoresUser26User99 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s099);
            sv.ImpostorScoresUser26User100 = ScaledManhDist.CalculateImpostorScores(s026Mean, stdDevUser26, s100);
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

            #region User 13 Impostor scores
            sv.ImpostorScoresUser13User1 = EuclidDist.CalculateImpostorScores(s013Mean, s001);
            sv.ImpostorScoresUser13User2 = EuclidDist.CalculateImpostorScores(s013Mean, s002);
            sv.ImpostorScoresUser13User3 = EuclidDist.CalculateImpostorScores(s013Mean, s003);
            sv.ImpostorScoresUser13User4 = EuclidDist.CalculateImpostorScores(s013Mean, s004);
            sv.ImpostorScoresUser13User5 = EuclidDist.CalculateImpostorScores(s013Mean, s005);
            sv.ImpostorScoresUser13User6 = EuclidDist.CalculateImpostorScores(s013Mean, s006);
            sv.ImpostorScoresUser13User7 = EuclidDist.CalculateImpostorScores(s013Mean, s007);
            sv.ImpostorScoresUser13User8 = EuclidDist.CalculateImpostorScores(s013Mean, s008);
            sv.ImpostorScoresUser13User9 = EuclidDist.CalculateImpostorScores(s013Mean, s009);
            sv.ImpostorScoresUser13User10 = EuclidDist.CalculateImpostorScores(s013Mean, s010);

            sv.ImpostorScoresUser13User11 = EuclidDist.CalculateImpostorScores(s013Mean, s011);
            sv.ImpostorScoresUser13User12 = EuclidDist.CalculateImpostorScores(s013Mean, s012);
            sv.ImpostorScoresUser13User14 = EuclidDist.CalculateImpostorScores(s013Mean, s014);
            sv.ImpostorScoresUser13User15 = EuclidDist.CalculateImpostorScores(s013Mean, s015);
            sv.ImpostorScoresUser13User16 = EuclidDist.CalculateImpostorScores(s013Mean, s016);
            sv.ImpostorScoresUser13User17 = EuclidDist.CalculateImpostorScores(s013Mean, s017);
            sv.ImpostorScoresUser13User18 = EuclidDist.CalculateImpostorScores(s013Mean, s018);
            sv.ImpostorScoresUser13User19 = EuclidDist.CalculateImpostorScores(s013Mean, s019);
            sv.ImpostorScoresUser13User20 = EuclidDist.CalculateImpostorScores(s013Mean, s020);

            sv.ImpostorScoresUser13User21 = EuclidDist.CalculateImpostorScores(s013Mean, s021);
            sv.ImpostorScoresUser13User22 = EuclidDist.CalculateImpostorScores(s013Mean, s022);
            sv.ImpostorScoresUser13User23 = EuclidDist.CalculateImpostorScores(s013Mean, s023);
            sv.ImpostorScoresUser13User24 = EuclidDist.CalculateImpostorScores(s013Mean, s024);
            sv.ImpostorScoresUser13User25 = EuclidDist.CalculateImpostorScores(s013Mean, s025);
            sv.ImpostorScoresUser13User26 = EuclidDist.CalculateImpostorScores(s013Mean, s026);
            sv.ImpostorScoresUser13User27 = EuclidDist.CalculateImpostorScores(s013Mean, s027);
            sv.ImpostorScoresUser13User28 = EuclidDist.CalculateImpostorScores(s013Mean, s028);
            sv.ImpostorScoresUser13User29 = EuclidDist.CalculateImpostorScores(s013Mean, s029);
            sv.ImpostorScoresUser13User30 = EuclidDist.CalculateImpostorScores(s013Mean, s030);

            sv.ImpostorScoresUser13User31 = EuclidDist.CalculateImpostorScores(s013Mean, s031);
            sv.ImpostorScoresUser13User32 = EuclidDist.CalculateImpostorScores(s013Mean, s032);
            sv.ImpostorScoresUser13User33 = EuclidDist.CalculateImpostorScores(s013Mean, s033);
            sv.ImpostorScoresUser13User34 = EuclidDist.CalculateImpostorScores(s013Mean, s034);
            sv.ImpostorScoresUser13User35 = EuclidDist.CalculateImpostorScores(s013Mean, s035);
            sv.ImpostorScoresUser13User36 = EuclidDist.CalculateImpostorScores(s013Mean, s036);
            sv.ImpostorScoresUser13User37 = EuclidDist.CalculateImpostorScores(s013Mean, s037);
            sv.ImpostorScoresUser13User38 = EuclidDist.CalculateImpostorScores(s013Mean, s038);
            sv.ImpostorScoresUser13User39 = EuclidDist.CalculateImpostorScores(s013Mean, s039);
            sv.ImpostorScoresUser13User40 = EuclidDist.CalculateImpostorScores(s013Mean, s040);

            sv.ImpostorScoresUser13User41 = EuclidDist.CalculateImpostorScores(s013Mean, s041);
            sv.ImpostorScoresUser13User42 = EuclidDist.CalculateImpostorScores(s013Mean, s042);
            sv.ImpostorScoresUser13User43 = EuclidDist.CalculateImpostorScores(s013Mean, s043);
            sv.ImpostorScoresUser13User44 = EuclidDist.CalculateImpostorScores(s013Mean, s044);
            sv.ImpostorScoresUser13User45 = EuclidDist.CalculateImpostorScores(s013Mean, s045);
            sv.ImpostorScoresUser13User46 = EuclidDist.CalculateImpostorScores(s013Mean, s046);
            sv.ImpostorScoresUser13User47 = EuclidDist.CalculateImpostorScores(s013Mean, s047);
            sv.ImpostorScoresUser13User48 = EuclidDist.CalculateImpostorScores(s013Mean, s048);
            sv.ImpostorScoresUser13User49 = EuclidDist.CalculateImpostorScores(s013Mean, s049);
            sv.ImpostorScoresUser13User50 = EuclidDist.CalculateImpostorScores(s013Mean, s050);

            sv.ImpostorScoresUser13User51 = EuclidDist.CalculateImpostorScores(s013Mean, s051);
            sv.ImpostorScoresUser13User52 = EuclidDist.CalculateImpostorScores(s013Mean, s052);
            sv.ImpostorScoresUser13User53 = EuclidDist.CalculateImpostorScores(s013Mean, s053);
            sv.ImpostorScoresUser13User54 = EuclidDist.CalculateImpostorScores(s013Mean, s054);
            sv.ImpostorScoresUser13User55 = EuclidDist.CalculateImpostorScores(s013Mean, s055);
            sv.ImpostorScoresUser13User56 = EuclidDist.CalculateImpostorScores(s013Mean, s056);
            sv.ImpostorScoresUser13User57 = EuclidDist.CalculateImpostorScores(s013Mean, s057);
            sv.ImpostorScoresUser13User58 = EuclidDist.CalculateImpostorScores(s013Mean, s058);
            sv.ImpostorScoresUser13User59 = EuclidDist.CalculateImpostorScores(s013Mean, s059);
            sv.ImpostorScoresUser13User60 = EuclidDist.CalculateImpostorScores(s013Mean, s060);

            sv.ImpostorScoresUser13User61 = EuclidDist.CalculateImpostorScores(s013Mean, s061);
            sv.ImpostorScoresUser13User62 = EuclidDist.CalculateImpostorScores(s013Mean, s062);
            sv.ImpostorScoresUser13User63 = EuclidDist.CalculateImpostorScores(s013Mean, s063);
            sv.ImpostorScoresUser13User64 = EuclidDist.CalculateImpostorScores(s013Mean, s064);
            sv.ImpostorScoresUser13User65 = EuclidDist.CalculateImpostorScores(s013Mean, s065);
            sv.ImpostorScoresUser13User66 = EuclidDist.CalculateImpostorScores(s013Mean, s066);
            sv.ImpostorScoresUser13User67 = EuclidDist.CalculateImpostorScores(s013Mean, s067);
            sv.ImpostorScoresUser13User68 = EuclidDist.CalculateImpostorScores(s013Mean, s068);
            sv.ImpostorScoresUser13User69 = EuclidDist.CalculateImpostorScores(s013Mean, s069);
            sv.ImpostorScoresUser13User70 = EuclidDist.CalculateImpostorScores(s013Mean, s070);

            sv.ImpostorScoresUser13User71 = EuclidDist.CalculateImpostorScores(s013Mean, s071);
            sv.ImpostorScoresUser13User72 = EuclidDist.CalculateImpostorScores(s013Mean, s072);
            sv.ImpostorScoresUser13User73 = EuclidDist.CalculateImpostorScores(s013Mean, s073);
            sv.ImpostorScoresUser13User74 = EuclidDist.CalculateImpostorScores(s013Mean, s074);
            sv.ImpostorScoresUser13User75 = EuclidDist.CalculateImpostorScores(s013Mean, s075);
            sv.ImpostorScoresUser13User76 = EuclidDist.CalculateImpostorScores(s013Mean, s076);
            sv.ImpostorScoresUser13User77 = EuclidDist.CalculateImpostorScores(s013Mean, s077);
            sv.ImpostorScoresUser13User78 = EuclidDist.CalculateImpostorScores(s013Mean, s078);
            sv.ImpostorScoresUser13User79 = EuclidDist.CalculateImpostorScores(s013Mean, s079);
            sv.ImpostorScoresUser13User80 = EuclidDist.CalculateImpostorScores(s013Mean, s080);

            sv.ImpostorScoresUser13User81 = EuclidDist.CalculateImpostorScores(s013Mean, s081);
            sv.ImpostorScoresUser13User82 = EuclidDist.CalculateImpostorScores(s013Mean, s082);
            sv.ImpostorScoresUser13User83 = EuclidDist.CalculateImpostorScores(s013Mean, s083);
            sv.ImpostorScoresUser13User84 = EuclidDist.CalculateImpostorScores(s013Mean, s084);
            sv.ImpostorScoresUser13User85 = EuclidDist.CalculateImpostorScores(s013Mean, s085);
            sv.ImpostorScoresUser13User86 = EuclidDist.CalculateImpostorScores(s013Mean, s086);
            sv.ImpostorScoresUser13User87 = EuclidDist.CalculateImpostorScores(s013Mean, s087);
            sv.ImpostorScoresUser13User88 = EuclidDist.CalculateImpostorScores(s013Mean, s088);
            sv.ImpostorScoresUser13User89 = EuclidDist.CalculateImpostorScores(s013Mean, s089);
            sv.ImpostorScoresUser13User90 = EuclidDist.CalculateImpostorScores(s013Mean, s090);

            sv.ImpostorScoresUser13User91 = EuclidDist.CalculateImpostorScores(s013Mean, s091);
            sv.ImpostorScoresUser13User92 = EuclidDist.CalculateImpostorScores(s013Mean, s092);
            sv.ImpostorScoresUser13User93 = EuclidDist.CalculateImpostorScores(s013Mean, s093);
            sv.ImpostorScoresUser13User94 = EuclidDist.CalculateImpostorScores(s013Mean, s094);
            sv.ImpostorScoresUser13User95 = EuclidDist.CalculateImpostorScores(s013Mean, s095);
            sv.ImpostorScoresUser13User96 = EuclidDist.CalculateImpostorScores(s013Mean, s096);
            sv.ImpostorScoresUser13User97 = EuclidDist.CalculateImpostorScores(s013Mean, s097);
            sv.ImpostorScoresUser13User98 = EuclidDist.CalculateImpostorScores(s013Mean, s098);
            sv.ImpostorScoresUser13User99 = EuclidDist.CalculateImpostorScores(s013Mean, s099);
            sv.ImpostorScoresUser13User100 = EuclidDist.CalculateImpostorScores(s013Mean, s100);
            #endregion

            #region User 14 Impostor scores
            sv.ImpostorScoresUser14User1 = EuclidDist.CalculateImpostorScores(s014Mean, s001);
            sv.ImpostorScoresUser14User2 = EuclidDist.CalculateImpostorScores(s014Mean, s002);
            sv.ImpostorScoresUser14User3 = EuclidDist.CalculateImpostorScores(s014Mean, s003);
            sv.ImpostorScoresUser14User4 = EuclidDist.CalculateImpostorScores(s014Mean, s004);
            sv.ImpostorScoresUser14User5 = EuclidDist.CalculateImpostorScores(s014Mean, s005);
            sv.ImpostorScoresUser14User6 = EuclidDist.CalculateImpostorScores(s014Mean, s006);
            sv.ImpostorScoresUser14User7 = EuclidDist.CalculateImpostorScores(s014Mean, s007);
            sv.ImpostorScoresUser14User8 = EuclidDist.CalculateImpostorScores(s014Mean, s008);
            sv.ImpostorScoresUser14User9 = EuclidDist.CalculateImpostorScores(s014Mean, s009);
            sv.ImpostorScoresUser14User10 = EuclidDist.CalculateImpostorScores(s014Mean, s010);

            sv.ImpostorScoresUser14User11 = EuclidDist.CalculateImpostorScores(s014Mean, s011);
            sv.ImpostorScoresUser14User12 = EuclidDist.CalculateImpostorScores(s014Mean, s012);
            sv.ImpostorScoresUser14User13 = EuclidDist.CalculateImpostorScores(s014Mean, s014);
            sv.ImpostorScoresUser14User15 = EuclidDist.CalculateImpostorScores(s014Mean, s015);
            sv.ImpostorScoresUser14User16 = EuclidDist.CalculateImpostorScores(s014Mean, s016);
            sv.ImpostorScoresUser14User17 = EuclidDist.CalculateImpostorScores(s014Mean, s017);
            sv.ImpostorScoresUser14User18 = EuclidDist.CalculateImpostorScores(s014Mean, s018);
            sv.ImpostorScoresUser14User19 = EuclidDist.CalculateImpostorScores(s014Mean, s019);
            sv.ImpostorScoresUser14User20 = EuclidDist.CalculateImpostorScores(s014Mean, s020);

            sv.ImpostorScoresUser14User21 = EuclidDist.CalculateImpostorScores(s014Mean, s021);
            sv.ImpostorScoresUser14User22 = EuclidDist.CalculateImpostorScores(s014Mean, s022);
            sv.ImpostorScoresUser14User23 = EuclidDist.CalculateImpostorScores(s014Mean, s023);
            sv.ImpostorScoresUser14User24 = EuclidDist.CalculateImpostorScores(s014Mean, s024);
            sv.ImpostorScoresUser14User25 = EuclidDist.CalculateImpostorScores(s014Mean, s025);
            sv.ImpostorScoresUser14User26 = EuclidDist.CalculateImpostorScores(s014Mean, s026);
            sv.ImpostorScoresUser14User27 = EuclidDist.CalculateImpostorScores(s014Mean, s027);
            sv.ImpostorScoresUser14User28 = EuclidDist.CalculateImpostorScores(s014Mean, s028);
            sv.ImpostorScoresUser14User29 = EuclidDist.CalculateImpostorScores(s014Mean, s029);
            sv.ImpostorScoresUser14User30 = EuclidDist.CalculateImpostorScores(s014Mean, s030);

            sv.ImpostorScoresUser14User31 = EuclidDist.CalculateImpostorScores(s014Mean, s031);
            sv.ImpostorScoresUser14User32 = EuclidDist.CalculateImpostorScores(s014Mean, s032);
            sv.ImpostorScoresUser14User33 = EuclidDist.CalculateImpostorScores(s014Mean, s033);
            sv.ImpostorScoresUser14User34 = EuclidDist.CalculateImpostorScores(s014Mean, s034);
            sv.ImpostorScoresUser14User35 = EuclidDist.CalculateImpostorScores(s014Mean, s035);
            sv.ImpostorScoresUser14User36 = EuclidDist.CalculateImpostorScores(s014Mean, s036);
            sv.ImpostorScoresUser14User37 = EuclidDist.CalculateImpostorScores(s014Mean, s037);
            sv.ImpostorScoresUser14User38 = EuclidDist.CalculateImpostorScores(s014Mean, s038);
            sv.ImpostorScoresUser14User39 = EuclidDist.CalculateImpostorScores(s014Mean, s039);
            sv.ImpostorScoresUser14User40 = EuclidDist.CalculateImpostorScores(s014Mean, s040);

            sv.ImpostorScoresUser14User41 = EuclidDist.CalculateImpostorScores(s014Mean, s041);
            sv.ImpostorScoresUser14User42 = EuclidDist.CalculateImpostorScores(s014Mean, s042);
            sv.ImpostorScoresUser14User43 = EuclidDist.CalculateImpostorScores(s014Mean, s043);
            sv.ImpostorScoresUser14User44 = EuclidDist.CalculateImpostorScores(s014Mean, s044);
            sv.ImpostorScoresUser14User45 = EuclidDist.CalculateImpostorScores(s014Mean, s045);
            sv.ImpostorScoresUser14User46 = EuclidDist.CalculateImpostorScores(s014Mean, s046);
            sv.ImpostorScoresUser14User47 = EuclidDist.CalculateImpostorScores(s014Mean, s047);
            sv.ImpostorScoresUser14User48 = EuclidDist.CalculateImpostorScores(s014Mean, s048);
            sv.ImpostorScoresUser14User49 = EuclidDist.CalculateImpostorScores(s014Mean, s049);
            sv.ImpostorScoresUser14User50 = EuclidDist.CalculateImpostorScores(s014Mean, s050);

            sv.ImpostorScoresUser14User51 = EuclidDist.CalculateImpostorScores(s014Mean, s051);
            sv.ImpostorScoresUser14User52 = EuclidDist.CalculateImpostorScores(s014Mean, s052);
            sv.ImpostorScoresUser14User53 = EuclidDist.CalculateImpostorScores(s014Mean, s053);
            sv.ImpostorScoresUser14User54 = EuclidDist.CalculateImpostorScores(s014Mean, s054);
            sv.ImpostorScoresUser14User55 = EuclidDist.CalculateImpostorScores(s014Mean, s055);
            sv.ImpostorScoresUser14User56 = EuclidDist.CalculateImpostorScores(s014Mean, s056);
            sv.ImpostorScoresUser14User57 = EuclidDist.CalculateImpostorScores(s014Mean, s057);
            sv.ImpostorScoresUser14User58 = EuclidDist.CalculateImpostorScores(s014Mean, s058);
            sv.ImpostorScoresUser14User59 = EuclidDist.CalculateImpostorScores(s014Mean, s059);
            sv.ImpostorScoresUser14User60 = EuclidDist.CalculateImpostorScores(s014Mean, s060);

            sv.ImpostorScoresUser14User61 = EuclidDist.CalculateImpostorScores(s014Mean, s061);
            sv.ImpostorScoresUser14User62 = EuclidDist.CalculateImpostorScores(s014Mean, s062);
            sv.ImpostorScoresUser14User63 = EuclidDist.CalculateImpostorScores(s014Mean, s063);
            sv.ImpostorScoresUser14User64 = EuclidDist.CalculateImpostorScores(s014Mean, s064);
            sv.ImpostorScoresUser14User65 = EuclidDist.CalculateImpostorScores(s014Mean, s065);
            sv.ImpostorScoresUser14User66 = EuclidDist.CalculateImpostorScores(s014Mean, s066);
            sv.ImpostorScoresUser14User67 = EuclidDist.CalculateImpostorScores(s014Mean, s067);
            sv.ImpostorScoresUser14User68 = EuclidDist.CalculateImpostorScores(s014Mean, s068);
            sv.ImpostorScoresUser14User69 = EuclidDist.CalculateImpostorScores(s014Mean, s069);
            sv.ImpostorScoresUser14User70 = EuclidDist.CalculateImpostorScores(s014Mean, s070);

            sv.ImpostorScoresUser14User71 = EuclidDist.CalculateImpostorScores(s014Mean, s071);
            sv.ImpostorScoresUser14User72 = EuclidDist.CalculateImpostorScores(s014Mean, s072);
            sv.ImpostorScoresUser14User73 = EuclidDist.CalculateImpostorScores(s014Mean, s073);
            sv.ImpostorScoresUser14User74 = EuclidDist.CalculateImpostorScores(s014Mean, s074);
            sv.ImpostorScoresUser14User75 = EuclidDist.CalculateImpostorScores(s014Mean, s075);
            sv.ImpostorScoresUser14User76 = EuclidDist.CalculateImpostorScores(s014Mean, s076);
            sv.ImpostorScoresUser14User77 = EuclidDist.CalculateImpostorScores(s014Mean, s077);
            sv.ImpostorScoresUser14User78 = EuclidDist.CalculateImpostorScores(s014Mean, s078);
            sv.ImpostorScoresUser14User79 = EuclidDist.CalculateImpostorScores(s014Mean, s079);
            sv.ImpostorScoresUser14User80 = EuclidDist.CalculateImpostorScores(s014Mean, s080);

            sv.ImpostorScoresUser14User81 = EuclidDist.CalculateImpostorScores(s014Mean, s081);
            sv.ImpostorScoresUser14User82 = EuclidDist.CalculateImpostorScores(s014Mean, s082);
            sv.ImpostorScoresUser14User83 = EuclidDist.CalculateImpostorScores(s014Mean, s083);
            sv.ImpostorScoresUser14User84 = EuclidDist.CalculateImpostorScores(s014Mean, s084);
            sv.ImpostorScoresUser14User85 = EuclidDist.CalculateImpostorScores(s014Mean, s085);
            sv.ImpostorScoresUser14User86 = EuclidDist.CalculateImpostorScores(s014Mean, s086);
            sv.ImpostorScoresUser14User87 = EuclidDist.CalculateImpostorScores(s014Mean, s087);
            sv.ImpostorScoresUser14User88 = EuclidDist.CalculateImpostorScores(s014Mean, s088);
            sv.ImpostorScoresUser14User89 = EuclidDist.CalculateImpostorScores(s014Mean, s089);
            sv.ImpostorScoresUser14User90 = EuclidDist.CalculateImpostorScores(s014Mean, s090);

            sv.ImpostorScoresUser14User91 = EuclidDist.CalculateImpostorScores(s014Mean, s091);
            sv.ImpostorScoresUser14User92 = EuclidDist.CalculateImpostorScores(s014Mean, s092);
            sv.ImpostorScoresUser14User93 = EuclidDist.CalculateImpostorScores(s014Mean, s093);
            sv.ImpostorScoresUser14User94 = EuclidDist.CalculateImpostorScores(s014Mean, s094);
            sv.ImpostorScoresUser14User95 = EuclidDist.CalculateImpostorScores(s014Mean, s095);
            sv.ImpostorScoresUser14User96 = EuclidDist.CalculateImpostorScores(s014Mean, s096);
            sv.ImpostorScoresUser14User97 = EuclidDist.CalculateImpostorScores(s014Mean, s097);
            sv.ImpostorScoresUser14User98 = EuclidDist.CalculateImpostorScores(s014Mean, s098);
            sv.ImpostorScoresUser14User99 = EuclidDist.CalculateImpostorScores(s014Mean, s099);
            sv.ImpostorScoresUser14User100 = EuclidDist.CalculateImpostorScores(s014Mean, s100);
            #endregion

            #region User 15 Impostor scores
            sv.ImpostorScoresUser15User1 = EuclidDist.CalculateImpostorScores(s015Mean, s001);
            sv.ImpostorScoresUser15User2 = EuclidDist.CalculateImpostorScores(s015Mean, s002);
            sv.ImpostorScoresUser15User3 = EuclidDist.CalculateImpostorScores(s015Mean, s003);
            sv.ImpostorScoresUser15User4 = EuclidDist.CalculateImpostorScores(s015Mean, s004);
            sv.ImpostorScoresUser15User5 = EuclidDist.CalculateImpostorScores(s015Mean, s005);
            sv.ImpostorScoresUser15User6 = EuclidDist.CalculateImpostorScores(s015Mean, s006);
            sv.ImpostorScoresUser15User7 = EuclidDist.CalculateImpostorScores(s015Mean, s007);
            sv.ImpostorScoresUser15User8 = EuclidDist.CalculateImpostorScores(s015Mean, s008);
            sv.ImpostorScoresUser15User9 = EuclidDist.CalculateImpostorScores(s015Mean, s009);
            sv.ImpostorScoresUser15User10 = EuclidDist.CalculateImpostorScores(s015Mean, s010);

            sv.ImpostorScoresUser15User11 = EuclidDist.CalculateImpostorScores(s015Mean, s011);
            sv.ImpostorScoresUser15User12 = EuclidDist.CalculateImpostorScores(s015Mean, s012);
            sv.ImpostorScoresUser15User13 = EuclidDist.CalculateImpostorScores(s015Mean, s013);
            sv.ImpostorScoresUser15User14 = EuclidDist.CalculateImpostorScores(s015Mean, s014);
            sv.ImpostorScoresUser15User16 = EuclidDist.CalculateImpostorScores(s015Mean, s016);
            sv.ImpostorScoresUser15User17 = EuclidDist.CalculateImpostorScores(s015Mean, s017);
            sv.ImpostorScoresUser15User18 = EuclidDist.CalculateImpostorScores(s015Mean, s018);
            sv.ImpostorScoresUser15User19 = EuclidDist.CalculateImpostorScores(s015Mean, s019);
            sv.ImpostorScoresUser15User20 = EuclidDist.CalculateImpostorScores(s015Mean, s020);

            sv.ImpostorScoresUser15User21 = EuclidDist.CalculateImpostorScores(s015Mean, s021);
            sv.ImpostorScoresUser15User22 = EuclidDist.CalculateImpostorScores(s015Mean, s022);
            sv.ImpostorScoresUser15User23 = EuclidDist.CalculateImpostorScores(s015Mean, s023);
            sv.ImpostorScoresUser15User24 = EuclidDist.CalculateImpostorScores(s015Mean, s024);
            sv.ImpostorScoresUser15User25 = EuclidDist.CalculateImpostorScores(s015Mean, s025);
            sv.ImpostorScoresUser15User26 = EuclidDist.CalculateImpostorScores(s015Mean, s026);
            sv.ImpostorScoresUser15User27 = EuclidDist.CalculateImpostorScores(s015Mean, s027);
            sv.ImpostorScoresUser15User28 = EuclidDist.CalculateImpostorScores(s015Mean, s028);
            sv.ImpostorScoresUser15User29 = EuclidDist.CalculateImpostorScores(s015Mean, s029);
            sv.ImpostorScoresUser15User30 = EuclidDist.CalculateImpostorScores(s015Mean, s030);

            sv.ImpostorScoresUser15User31 = EuclidDist.CalculateImpostorScores(s015Mean, s031);
            sv.ImpostorScoresUser15User32 = EuclidDist.CalculateImpostorScores(s015Mean, s032);
            sv.ImpostorScoresUser15User33 = EuclidDist.CalculateImpostorScores(s015Mean, s033);
            sv.ImpostorScoresUser15User34 = EuclidDist.CalculateImpostorScores(s015Mean, s034);
            sv.ImpostorScoresUser15User35 = EuclidDist.CalculateImpostorScores(s015Mean, s035);
            sv.ImpostorScoresUser15User36 = EuclidDist.CalculateImpostorScores(s015Mean, s036);
            sv.ImpostorScoresUser15User37 = EuclidDist.CalculateImpostorScores(s015Mean, s037);
            sv.ImpostorScoresUser15User38 = EuclidDist.CalculateImpostorScores(s015Mean, s038);
            sv.ImpostorScoresUser15User39 = EuclidDist.CalculateImpostorScores(s015Mean, s039);
            sv.ImpostorScoresUser15User40 = EuclidDist.CalculateImpostorScores(s015Mean, s040);

            sv.ImpostorScoresUser15User41 = EuclidDist.CalculateImpostorScores(s015Mean, s041);
            sv.ImpostorScoresUser15User42 = EuclidDist.CalculateImpostorScores(s015Mean, s042);
            sv.ImpostorScoresUser15User43 = EuclidDist.CalculateImpostorScores(s015Mean, s043);
            sv.ImpostorScoresUser15User44 = EuclidDist.CalculateImpostorScores(s015Mean, s044);
            sv.ImpostorScoresUser15User45 = EuclidDist.CalculateImpostorScores(s015Mean, s045);
            sv.ImpostorScoresUser15User46 = EuclidDist.CalculateImpostorScores(s015Mean, s046);
            sv.ImpostorScoresUser15User47 = EuclidDist.CalculateImpostorScores(s015Mean, s047);
            sv.ImpostorScoresUser15User48 = EuclidDist.CalculateImpostorScores(s015Mean, s048);
            sv.ImpostorScoresUser15User49 = EuclidDist.CalculateImpostorScores(s015Mean, s049);
            sv.ImpostorScoresUser15User50 = EuclidDist.CalculateImpostorScores(s015Mean, s050);

            sv.ImpostorScoresUser15User51 = EuclidDist.CalculateImpostorScores(s015Mean, s051);
            sv.ImpostorScoresUser15User52 = EuclidDist.CalculateImpostorScores(s015Mean, s052);
            sv.ImpostorScoresUser15User53 = EuclidDist.CalculateImpostorScores(s015Mean, s053);
            sv.ImpostorScoresUser15User54 = EuclidDist.CalculateImpostorScores(s015Mean, s054);
            sv.ImpostorScoresUser15User55 = EuclidDist.CalculateImpostorScores(s015Mean, s055);
            sv.ImpostorScoresUser15User56 = EuclidDist.CalculateImpostorScores(s015Mean, s056);
            sv.ImpostorScoresUser15User57 = EuclidDist.CalculateImpostorScores(s015Mean, s057);
            sv.ImpostorScoresUser15User58 = EuclidDist.CalculateImpostorScores(s015Mean, s058);
            sv.ImpostorScoresUser15User59 = EuclidDist.CalculateImpostorScores(s015Mean, s059);
            sv.ImpostorScoresUser15User60 = EuclidDist.CalculateImpostorScores(s015Mean, s060);

            sv.ImpostorScoresUser15User61 = EuclidDist.CalculateImpostorScores(s015Mean, s061);
            sv.ImpostorScoresUser15User62 = EuclidDist.CalculateImpostorScores(s015Mean, s062);
            sv.ImpostorScoresUser15User63 = EuclidDist.CalculateImpostorScores(s015Mean, s063);
            sv.ImpostorScoresUser15User64 = EuclidDist.CalculateImpostorScores(s015Mean, s064);
            sv.ImpostorScoresUser15User65 = EuclidDist.CalculateImpostorScores(s015Mean, s065);
            sv.ImpostorScoresUser15User66 = EuclidDist.CalculateImpostorScores(s015Mean, s066);
            sv.ImpostorScoresUser15User67 = EuclidDist.CalculateImpostorScores(s015Mean, s067);
            sv.ImpostorScoresUser15User68 = EuclidDist.CalculateImpostorScores(s015Mean, s068);
            sv.ImpostorScoresUser15User69 = EuclidDist.CalculateImpostorScores(s015Mean, s069);
            sv.ImpostorScoresUser15User70 = EuclidDist.CalculateImpostorScores(s015Mean, s070);

            sv.ImpostorScoresUser15User71 = EuclidDist.CalculateImpostorScores(s015Mean, s071);
            sv.ImpostorScoresUser15User72 = EuclidDist.CalculateImpostorScores(s015Mean, s072);
            sv.ImpostorScoresUser15User73 = EuclidDist.CalculateImpostorScores(s015Mean, s073);
            sv.ImpostorScoresUser15User74 = EuclidDist.CalculateImpostorScores(s015Mean, s074);
            sv.ImpostorScoresUser15User75 = EuclidDist.CalculateImpostorScores(s015Mean, s075);
            sv.ImpostorScoresUser15User76 = EuclidDist.CalculateImpostorScores(s015Mean, s076);
            sv.ImpostorScoresUser15User77 = EuclidDist.CalculateImpostorScores(s015Mean, s077);
            sv.ImpostorScoresUser15User78 = EuclidDist.CalculateImpostorScores(s015Mean, s078);
            sv.ImpostorScoresUser15User79 = EuclidDist.CalculateImpostorScores(s015Mean, s079);
            sv.ImpostorScoresUser15User80 = EuclidDist.CalculateImpostorScores(s015Mean, s080);

            sv.ImpostorScoresUser15User81 = EuclidDist.CalculateImpostorScores(s015Mean, s081);
            sv.ImpostorScoresUser15User82 = EuclidDist.CalculateImpostorScores(s015Mean, s082);
            sv.ImpostorScoresUser15User83 = EuclidDist.CalculateImpostorScores(s015Mean, s083);
            sv.ImpostorScoresUser15User84 = EuclidDist.CalculateImpostorScores(s015Mean, s084);
            sv.ImpostorScoresUser15User85 = EuclidDist.CalculateImpostorScores(s015Mean, s085);
            sv.ImpostorScoresUser15User86 = EuclidDist.CalculateImpostorScores(s015Mean, s086);
            sv.ImpostorScoresUser15User87 = EuclidDist.CalculateImpostorScores(s015Mean, s087);
            sv.ImpostorScoresUser15User88 = EuclidDist.CalculateImpostorScores(s015Mean, s088);
            sv.ImpostorScoresUser15User89 = EuclidDist.CalculateImpostorScores(s015Mean, s089);
            sv.ImpostorScoresUser15User90 = EuclidDist.CalculateImpostorScores(s015Mean, s090);

            sv.ImpostorScoresUser15User91 = EuclidDist.CalculateImpostorScores(s015Mean, s091);
            sv.ImpostorScoresUser15User92 = EuclidDist.CalculateImpostorScores(s015Mean, s092);
            sv.ImpostorScoresUser15User93 = EuclidDist.CalculateImpostorScores(s015Mean, s093);
            sv.ImpostorScoresUser15User94 = EuclidDist.CalculateImpostorScores(s015Mean, s094);
            sv.ImpostorScoresUser15User95 = EuclidDist.CalculateImpostorScores(s015Mean, s095);
            sv.ImpostorScoresUser15User96 = EuclidDist.CalculateImpostorScores(s015Mean, s096);
            sv.ImpostorScoresUser15User97 = EuclidDist.CalculateImpostorScores(s015Mean, s097);
            sv.ImpostorScoresUser15User98 = EuclidDist.CalculateImpostorScores(s015Mean, s098);
            sv.ImpostorScoresUser15User99 = EuclidDist.CalculateImpostorScores(s015Mean, s099);
            sv.ImpostorScoresUser15User100 = EuclidDist.CalculateImpostorScores(s015Mean, s100);
            #endregion

            #region User 16 Impostor scores
            sv.ImpostorScoresUser16User1 = EuclidDist.CalculateImpostorScores(s016Mean, s001);
            sv.ImpostorScoresUser16User2 = EuclidDist.CalculateImpostorScores(s016Mean, s002);
            sv.ImpostorScoresUser16User3 = EuclidDist.CalculateImpostorScores(s016Mean, s003);
            sv.ImpostorScoresUser16User4 = EuclidDist.CalculateImpostorScores(s016Mean, s004);
            sv.ImpostorScoresUser16User5 = EuclidDist.CalculateImpostorScores(s016Mean, s005);
            sv.ImpostorScoresUser16User6 = EuclidDist.CalculateImpostorScores(s016Mean, s006);
            sv.ImpostorScoresUser16User7 = EuclidDist.CalculateImpostorScores(s016Mean, s007);
            sv.ImpostorScoresUser16User8 = EuclidDist.CalculateImpostorScores(s016Mean, s008);
            sv.ImpostorScoresUser16User9 = EuclidDist.CalculateImpostorScores(s016Mean, s009);
            sv.ImpostorScoresUser16User10 = EuclidDist.CalculateImpostorScores(s016Mean, s010);

            sv.ImpostorScoresUser16User11 = EuclidDist.CalculateImpostorScores(s016Mean, s011);
            sv.ImpostorScoresUser16User12 = EuclidDist.CalculateImpostorScores(s016Mean, s012);
            sv.ImpostorScoresUser16User13 = EuclidDist.CalculateImpostorScores(s016Mean, s013);
            sv.ImpostorScoresUser16User14 = EuclidDist.CalculateImpostorScores(s016Mean, s014);
            sv.ImpostorScoresUser16User15 = EuclidDist.CalculateImpostorScores(s016Mean, s016);
            sv.ImpostorScoresUser16User17 = EuclidDist.CalculateImpostorScores(s016Mean, s017);
            sv.ImpostorScoresUser16User18 = EuclidDist.CalculateImpostorScores(s016Mean, s018);
            sv.ImpostorScoresUser16User19 = EuclidDist.CalculateImpostorScores(s016Mean, s019);
            sv.ImpostorScoresUser16User20 = EuclidDist.CalculateImpostorScores(s016Mean, s020);

            sv.ImpostorScoresUser16User21 = EuclidDist.CalculateImpostorScores(s016Mean, s021);
            sv.ImpostorScoresUser16User22 = EuclidDist.CalculateImpostorScores(s016Mean, s022);
            sv.ImpostorScoresUser16User23 = EuclidDist.CalculateImpostorScores(s016Mean, s023);
            sv.ImpostorScoresUser16User24 = EuclidDist.CalculateImpostorScores(s016Mean, s024);
            sv.ImpostorScoresUser16User25 = EuclidDist.CalculateImpostorScores(s016Mean, s025);
            sv.ImpostorScoresUser16User26 = EuclidDist.CalculateImpostorScores(s016Mean, s026);
            sv.ImpostorScoresUser16User27 = EuclidDist.CalculateImpostorScores(s016Mean, s027);
            sv.ImpostorScoresUser16User28 = EuclidDist.CalculateImpostorScores(s016Mean, s028);
            sv.ImpostorScoresUser16User29 = EuclidDist.CalculateImpostorScores(s016Mean, s029);
            sv.ImpostorScoresUser16User30 = EuclidDist.CalculateImpostorScores(s016Mean, s030);

            sv.ImpostorScoresUser16User31 = EuclidDist.CalculateImpostorScores(s016Mean, s031);
            sv.ImpostorScoresUser16User32 = EuclidDist.CalculateImpostorScores(s016Mean, s032);
            sv.ImpostorScoresUser16User33 = EuclidDist.CalculateImpostorScores(s016Mean, s033);
            sv.ImpostorScoresUser16User34 = EuclidDist.CalculateImpostorScores(s016Mean, s034);
            sv.ImpostorScoresUser16User35 = EuclidDist.CalculateImpostorScores(s016Mean, s035);
            sv.ImpostorScoresUser16User36 = EuclidDist.CalculateImpostorScores(s016Mean, s036);
            sv.ImpostorScoresUser16User37 = EuclidDist.CalculateImpostorScores(s016Mean, s037);
            sv.ImpostorScoresUser16User38 = EuclidDist.CalculateImpostorScores(s016Mean, s038);
            sv.ImpostorScoresUser16User39 = EuclidDist.CalculateImpostorScores(s016Mean, s039);
            sv.ImpostorScoresUser16User40 = EuclidDist.CalculateImpostorScores(s016Mean, s040);

            sv.ImpostorScoresUser16User41 = EuclidDist.CalculateImpostorScores(s016Mean, s041);
            sv.ImpostorScoresUser16User42 = EuclidDist.CalculateImpostorScores(s016Mean, s042);
            sv.ImpostorScoresUser16User43 = EuclidDist.CalculateImpostorScores(s016Mean, s043);
            sv.ImpostorScoresUser16User44 = EuclidDist.CalculateImpostorScores(s016Mean, s044);
            sv.ImpostorScoresUser16User45 = EuclidDist.CalculateImpostorScores(s016Mean, s045);
            sv.ImpostorScoresUser16User46 = EuclidDist.CalculateImpostorScores(s016Mean, s046);
            sv.ImpostorScoresUser16User47 = EuclidDist.CalculateImpostorScores(s016Mean, s047);
            sv.ImpostorScoresUser16User48 = EuclidDist.CalculateImpostorScores(s016Mean, s048);
            sv.ImpostorScoresUser16User49 = EuclidDist.CalculateImpostorScores(s016Mean, s049);
            sv.ImpostorScoresUser16User50 = EuclidDist.CalculateImpostorScores(s016Mean, s050);

            sv.ImpostorScoresUser16User51 = EuclidDist.CalculateImpostorScores(s016Mean, s051);
            sv.ImpostorScoresUser16User52 = EuclidDist.CalculateImpostorScores(s016Mean, s052);
            sv.ImpostorScoresUser16User53 = EuclidDist.CalculateImpostorScores(s016Mean, s053);
            sv.ImpostorScoresUser16User54 = EuclidDist.CalculateImpostorScores(s016Mean, s054);
            sv.ImpostorScoresUser16User55 = EuclidDist.CalculateImpostorScores(s016Mean, s055);
            sv.ImpostorScoresUser16User56 = EuclidDist.CalculateImpostorScores(s016Mean, s056);
            sv.ImpostorScoresUser16User57 = EuclidDist.CalculateImpostorScores(s016Mean, s057);
            sv.ImpostorScoresUser16User58 = EuclidDist.CalculateImpostorScores(s016Mean, s058);
            sv.ImpostorScoresUser16User59 = EuclidDist.CalculateImpostorScores(s016Mean, s059);
            sv.ImpostorScoresUser16User60 = EuclidDist.CalculateImpostorScores(s016Mean, s060);

            sv.ImpostorScoresUser16User61 = EuclidDist.CalculateImpostorScores(s016Mean, s061);
            sv.ImpostorScoresUser16User62 = EuclidDist.CalculateImpostorScores(s016Mean, s062);
            sv.ImpostorScoresUser16User63 = EuclidDist.CalculateImpostorScores(s016Mean, s063);
            sv.ImpostorScoresUser16User64 = EuclidDist.CalculateImpostorScores(s016Mean, s064);
            sv.ImpostorScoresUser16User65 = EuclidDist.CalculateImpostorScores(s016Mean, s065);
            sv.ImpostorScoresUser16User66 = EuclidDist.CalculateImpostorScores(s016Mean, s066);
            sv.ImpostorScoresUser16User67 = EuclidDist.CalculateImpostorScores(s016Mean, s067);
            sv.ImpostorScoresUser16User68 = EuclidDist.CalculateImpostorScores(s016Mean, s068);
            sv.ImpostorScoresUser16User69 = EuclidDist.CalculateImpostorScores(s016Mean, s069);
            sv.ImpostorScoresUser16User70 = EuclidDist.CalculateImpostorScores(s016Mean, s070);

            sv.ImpostorScoresUser16User71 = EuclidDist.CalculateImpostorScores(s016Mean, s071);
            sv.ImpostorScoresUser16User72 = EuclidDist.CalculateImpostorScores(s016Mean, s072);
            sv.ImpostorScoresUser16User73 = EuclidDist.CalculateImpostorScores(s016Mean, s073);
            sv.ImpostorScoresUser16User74 = EuclidDist.CalculateImpostorScores(s016Mean, s074);
            sv.ImpostorScoresUser16User75 = EuclidDist.CalculateImpostorScores(s016Mean, s075);
            sv.ImpostorScoresUser16User76 = EuclidDist.CalculateImpostorScores(s016Mean, s076);
            sv.ImpostorScoresUser16User77 = EuclidDist.CalculateImpostorScores(s016Mean, s077);
            sv.ImpostorScoresUser16User78 = EuclidDist.CalculateImpostorScores(s016Mean, s078);
            sv.ImpostorScoresUser16User79 = EuclidDist.CalculateImpostorScores(s016Mean, s079);
            sv.ImpostorScoresUser16User80 = EuclidDist.CalculateImpostorScores(s016Mean, s080);

            sv.ImpostorScoresUser16User81 = EuclidDist.CalculateImpostorScores(s016Mean, s081);
            sv.ImpostorScoresUser16User82 = EuclidDist.CalculateImpostorScores(s016Mean, s082);
            sv.ImpostorScoresUser16User83 = EuclidDist.CalculateImpostorScores(s016Mean, s083);
            sv.ImpostorScoresUser16User84 = EuclidDist.CalculateImpostorScores(s016Mean, s084);
            sv.ImpostorScoresUser16User85 = EuclidDist.CalculateImpostorScores(s016Mean, s085);
            sv.ImpostorScoresUser16User86 = EuclidDist.CalculateImpostorScores(s016Mean, s086);
            sv.ImpostorScoresUser16User87 = EuclidDist.CalculateImpostorScores(s016Mean, s087);
            sv.ImpostorScoresUser16User88 = EuclidDist.CalculateImpostorScores(s016Mean, s088);
            sv.ImpostorScoresUser16User89 = EuclidDist.CalculateImpostorScores(s016Mean, s089);
            sv.ImpostorScoresUser16User90 = EuclidDist.CalculateImpostorScores(s016Mean, s090);

            sv.ImpostorScoresUser16User91 = EuclidDist.CalculateImpostorScores(s016Mean, s091);
            sv.ImpostorScoresUser16User92 = EuclidDist.CalculateImpostorScores(s016Mean, s092);
            sv.ImpostorScoresUser16User93 = EuclidDist.CalculateImpostorScores(s016Mean, s093);
            sv.ImpostorScoresUser16User94 = EuclidDist.CalculateImpostorScores(s016Mean, s094);
            sv.ImpostorScoresUser16User95 = EuclidDist.CalculateImpostorScores(s016Mean, s095);
            sv.ImpostorScoresUser16User96 = EuclidDist.CalculateImpostorScores(s016Mean, s096);
            sv.ImpostorScoresUser16User97 = EuclidDist.CalculateImpostorScores(s016Mean, s097);
            sv.ImpostorScoresUser16User98 = EuclidDist.CalculateImpostorScores(s016Mean, s098);
            sv.ImpostorScoresUser16User99 = EuclidDist.CalculateImpostorScores(s016Mean, s099);
            sv.ImpostorScoresUser16User100 = EuclidDist.CalculateImpostorScores(s016Mean, s100);
            #endregion

            #region User 17 Impostor scores
            sv.ImpostorScoresUser17User1 = EuclidDist.CalculateImpostorScores(s017Mean, s001);
            sv.ImpostorScoresUser17User2 = EuclidDist.CalculateImpostorScores(s017Mean, s002);
            sv.ImpostorScoresUser17User3 = EuclidDist.CalculateImpostorScores(s017Mean, s003);
            sv.ImpostorScoresUser17User4 = EuclidDist.CalculateImpostorScores(s017Mean, s004);
            sv.ImpostorScoresUser17User5 = EuclidDist.CalculateImpostorScores(s017Mean, s005);
            sv.ImpostorScoresUser17User6 = EuclidDist.CalculateImpostorScores(s017Mean, s006);
            sv.ImpostorScoresUser17User7 = EuclidDist.CalculateImpostorScores(s017Mean, s007);
            sv.ImpostorScoresUser17User8 = EuclidDist.CalculateImpostorScores(s017Mean, s008);
            sv.ImpostorScoresUser17User9 = EuclidDist.CalculateImpostorScores(s017Mean, s009);
            sv.ImpostorScoresUser17User10 = EuclidDist.CalculateImpostorScores(s017Mean, s010);

            sv.ImpostorScoresUser17User11 = EuclidDist.CalculateImpostorScores(s017Mean, s011);
            sv.ImpostorScoresUser17User12 = EuclidDist.CalculateImpostorScores(s017Mean, s012);
            sv.ImpostorScoresUser17User13 = EuclidDist.CalculateImpostorScores(s017Mean, s013);
            sv.ImpostorScoresUser17User14 = EuclidDist.CalculateImpostorScores(s017Mean, s014);
            sv.ImpostorScoresUser17User15 = EuclidDist.CalculateImpostorScores(s017Mean, s015);
            sv.ImpostorScoresUser17User16 = EuclidDist.CalculateImpostorScores(s017Mean, s016);
            sv.ImpostorScoresUser17User18 = EuclidDist.CalculateImpostorScores(s017Mean, s018);
            sv.ImpostorScoresUser17User19 = EuclidDist.CalculateImpostorScores(s017Mean, s019);
            sv.ImpostorScoresUser17User20 = EuclidDist.CalculateImpostorScores(s017Mean, s020);

            sv.ImpostorScoresUser17User21 = EuclidDist.CalculateImpostorScores(s017Mean, s021);
            sv.ImpostorScoresUser17User22 = EuclidDist.CalculateImpostorScores(s017Mean, s022);
            sv.ImpostorScoresUser17User23 = EuclidDist.CalculateImpostorScores(s017Mean, s023);
            sv.ImpostorScoresUser17User24 = EuclidDist.CalculateImpostorScores(s017Mean, s024);
            sv.ImpostorScoresUser17User25 = EuclidDist.CalculateImpostorScores(s017Mean, s025);
            sv.ImpostorScoresUser17User26 = EuclidDist.CalculateImpostorScores(s017Mean, s026);
            sv.ImpostorScoresUser17User27 = EuclidDist.CalculateImpostorScores(s017Mean, s027);
            sv.ImpostorScoresUser17User28 = EuclidDist.CalculateImpostorScores(s017Mean, s028);
            sv.ImpostorScoresUser17User29 = EuclidDist.CalculateImpostorScores(s017Mean, s029);
            sv.ImpostorScoresUser17User30 = EuclidDist.CalculateImpostorScores(s017Mean, s030);

            sv.ImpostorScoresUser17User31 = EuclidDist.CalculateImpostorScores(s017Mean, s031);
            sv.ImpostorScoresUser17User32 = EuclidDist.CalculateImpostorScores(s017Mean, s032);
            sv.ImpostorScoresUser17User33 = EuclidDist.CalculateImpostorScores(s017Mean, s033);
            sv.ImpostorScoresUser17User34 = EuclidDist.CalculateImpostorScores(s017Mean, s034);
            sv.ImpostorScoresUser17User35 = EuclidDist.CalculateImpostorScores(s017Mean, s035);
            sv.ImpostorScoresUser17User36 = EuclidDist.CalculateImpostorScores(s017Mean, s036);
            sv.ImpostorScoresUser17User37 = EuclidDist.CalculateImpostorScores(s017Mean, s037);
            sv.ImpostorScoresUser17User38 = EuclidDist.CalculateImpostorScores(s017Mean, s038);
            sv.ImpostorScoresUser17User39 = EuclidDist.CalculateImpostorScores(s017Mean, s039);
            sv.ImpostorScoresUser17User40 = EuclidDist.CalculateImpostorScores(s017Mean, s040);

            sv.ImpostorScoresUser17User41 = EuclidDist.CalculateImpostorScores(s017Mean, s041);
            sv.ImpostorScoresUser17User42 = EuclidDist.CalculateImpostorScores(s017Mean, s042);
            sv.ImpostorScoresUser17User43 = EuclidDist.CalculateImpostorScores(s017Mean, s043);
            sv.ImpostorScoresUser17User44 = EuclidDist.CalculateImpostorScores(s017Mean, s044);
            sv.ImpostorScoresUser17User45 = EuclidDist.CalculateImpostorScores(s017Mean, s045);
            sv.ImpostorScoresUser17User46 = EuclidDist.CalculateImpostorScores(s017Mean, s046);
            sv.ImpostorScoresUser17User47 = EuclidDist.CalculateImpostorScores(s017Mean, s047);
            sv.ImpostorScoresUser17User48 = EuclidDist.CalculateImpostorScores(s017Mean, s048);
            sv.ImpostorScoresUser17User49 = EuclidDist.CalculateImpostorScores(s017Mean, s049);
            sv.ImpostorScoresUser17User50 = EuclidDist.CalculateImpostorScores(s017Mean, s050);

            sv.ImpostorScoresUser17User51 = EuclidDist.CalculateImpostorScores(s017Mean, s051);
            sv.ImpostorScoresUser17User52 = EuclidDist.CalculateImpostorScores(s017Mean, s052);
            sv.ImpostorScoresUser17User53 = EuclidDist.CalculateImpostorScores(s017Mean, s053);
            sv.ImpostorScoresUser17User54 = EuclidDist.CalculateImpostorScores(s017Mean, s054);
            sv.ImpostorScoresUser17User55 = EuclidDist.CalculateImpostorScores(s017Mean, s055);
            sv.ImpostorScoresUser17User56 = EuclidDist.CalculateImpostorScores(s017Mean, s056);
            sv.ImpostorScoresUser17User57 = EuclidDist.CalculateImpostorScores(s017Mean, s057);
            sv.ImpostorScoresUser17User58 = EuclidDist.CalculateImpostorScores(s017Mean, s058);
            sv.ImpostorScoresUser17User59 = EuclidDist.CalculateImpostorScores(s017Mean, s059);
            sv.ImpostorScoresUser17User60 = EuclidDist.CalculateImpostorScores(s017Mean, s060);

            sv.ImpostorScoresUser17User61 = EuclidDist.CalculateImpostorScores(s017Mean, s061);
            sv.ImpostorScoresUser17User62 = EuclidDist.CalculateImpostorScores(s017Mean, s062);
            sv.ImpostorScoresUser17User63 = EuclidDist.CalculateImpostorScores(s017Mean, s063);
            sv.ImpostorScoresUser17User64 = EuclidDist.CalculateImpostorScores(s017Mean, s064);
            sv.ImpostorScoresUser17User65 = EuclidDist.CalculateImpostorScores(s017Mean, s065);
            sv.ImpostorScoresUser17User66 = EuclidDist.CalculateImpostorScores(s017Mean, s066);
            sv.ImpostorScoresUser17User67 = EuclidDist.CalculateImpostorScores(s017Mean, s067);
            sv.ImpostorScoresUser17User68 = EuclidDist.CalculateImpostorScores(s017Mean, s068);
            sv.ImpostorScoresUser17User69 = EuclidDist.CalculateImpostorScores(s017Mean, s069);
            sv.ImpostorScoresUser17User70 = EuclidDist.CalculateImpostorScores(s017Mean, s070);

            sv.ImpostorScoresUser17User71 = EuclidDist.CalculateImpostorScores(s017Mean, s071);
            sv.ImpostorScoresUser17User72 = EuclidDist.CalculateImpostorScores(s017Mean, s072);
            sv.ImpostorScoresUser17User73 = EuclidDist.CalculateImpostorScores(s017Mean, s073);
            sv.ImpostorScoresUser17User74 = EuclidDist.CalculateImpostorScores(s017Mean, s074);
            sv.ImpostorScoresUser17User75 = EuclidDist.CalculateImpostorScores(s017Mean, s075);
            sv.ImpostorScoresUser17User76 = EuclidDist.CalculateImpostorScores(s017Mean, s076);
            sv.ImpostorScoresUser17User77 = EuclidDist.CalculateImpostorScores(s017Mean, s077);
            sv.ImpostorScoresUser17User78 = EuclidDist.CalculateImpostorScores(s017Mean, s078);
            sv.ImpostorScoresUser17User79 = EuclidDist.CalculateImpostorScores(s017Mean, s079);
            sv.ImpostorScoresUser17User80 = EuclidDist.CalculateImpostorScores(s017Mean, s080);

            sv.ImpostorScoresUser17User81 = EuclidDist.CalculateImpostorScores(s017Mean, s081);
            sv.ImpostorScoresUser17User82 = EuclidDist.CalculateImpostorScores(s017Mean, s082);
            sv.ImpostorScoresUser17User83 = EuclidDist.CalculateImpostorScores(s017Mean, s083);
            sv.ImpostorScoresUser17User84 = EuclidDist.CalculateImpostorScores(s017Mean, s084);
            sv.ImpostorScoresUser17User85 = EuclidDist.CalculateImpostorScores(s017Mean, s085);
            sv.ImpostorScoresUser17User86 = EuclidDist.CalculateImpostorScores(s017Mean, s086);
            sv.ImpostorScoresUser17User87 = EuclidDist.CalculateImpostorScores(s017Mean, s087);
            sv.ImpostorScoresUser17User88 = EuclidDist.CalculateImpostorScores(s017Mean, s088);
            sv.ImpostorScoresUser17User89 = EuclidDist.CalculateImpostorScores(s017Mean, s089);
            sv.ImpostorScoresUser17User90 = EuclidDist.CalculateImpostorScores(s017Mean, s090);

            sv.ImpostorScoresUser17User91 = EuclidDist.CalculateImpostorScores(s017Mean, s091);
            sv.ImpostorScoresUser17User92 = EuclidDist.CalculateImpostorScores(s017Mean, s092);
            sv.ImpostorScoresUser17User93 = EuclidDist.CalculateImpostorScores(s017Mean, s093);
            sv.ImpostorScoresUser17User94 = EuclidDist.CalculateImpostorScores(s017Mean, s094);
            sv.ImpostorScoresUser17User95 = EuclidDist.CalculateImpostorScores(s017Mean, s095);
            sv.ImpostorScoresUser17User96 = EuclidDist.CalculateImpostorScores(s017Mean, s096);
            sv.ImpostorScoresUser17User97 = EuclidDist.CalculateImpostorScores(s017Mean, s097);
            sv.ImpostorScoresUser17User98 = EuclidDist.CalculateImpostorScores(s017Mean, s098);
            sv.ImpostorScoresUser17User99 = EuclidDist.CalculateImpostorScores(s017Mean, s099);
            sv.ImpostorScoresUser17User100 = EuclidDist.CalculateImpostorScores(s017Mean, s100);
            #endregion

            #region User 18 Impostor scores
            sv.ImpostorScoresUser18User1 = EuclidDist.CalculateImpostorScores(s018Mean, s001);
            sv.ImpostorScoresUser18User2 = EuclidDist.CalculateImpostorScores(s018Mean, s002);
            sv.ImpostorScoresUser18User3 = EuclidDist.CalculateImpostorScores(s018Mean, s003);
            sv.ImpostorScoresUser18User4 = EuclidDist.CalculateImpostorScores(s018Mean, s004);
            sv.ImpostorScoresUser18User5 = EuclidDist.CalculateImpostorScores(s018Mean, s005);
            sv.ImpostorScoresUser18User6 = EuclidDist.CalculateImpostorScores(s018Mean, s006);
            sv.ImpostorScoresUser18User7 = EuclidDist.CalculateImpostorScores(s018Mean, s007);
            sv.ImpostorScoresUser18User8 = EuclidDist.CalculateImpostorScores(s018Mean, s008);
            sv.ImpostorScoresUser18User9 = EuclidDist.CalculateImpostorScores(s018Mean, s009);
            sv.ImpostorScoresUser18User10 = EuclidDist.CalculateImpostorScores(s018Mean, s010);

            sv.ImpostorScoresUser18User11 = EuclidDist.CalculateImpostorScores(s018Mean, s011);
            sv.ImpostorScoresUser18User12 = EuclidDist.CalculateImpostorScores(s018Mean, s012);
            sv.ImpostorScoresUser18User13 = EuclidDist.CalculateImpostorScores(s018Mean, s013);
            sv.ImpostorScoresUser18User14 = EuclidDist.CalculateImpostorScores(s018Mean, s014);
            sv.ImpostorScoresUser18User15 = EuclidDist.CalculateImpostorScores(s018Mean, s015);
            sv.ImpostorScoresUser18User16 = EuclidDist.CalculateImpostorScores(s018Mean, s016);
            sv.ImpostorScoresUser18User17 = EuclidDist.CalculateImpostorScores(s018Mean, s017);
            sv.ImpostorScoresUser18User19 = EuclidDist.CalculateImpostorScores(s018Mean, s019);
            sv.ImpostorScoresUser18User20 = EuclidDist.CalculateImpostorScores(s018Mean, s020);

            sv.ImpostorScoresUser18User21 = EuclidDist.CalculateImpostorScores(s018Mean, s021);
            sv.ImpostorScoresUser18User22 = EuclidDist.CalculateImpostorScores(s018Mean, s022);
            sv.ImpostorScoresUser18User23 = EuclidDist.CalculateImpostorScores(s018Mean, s023);
            sv.ImpostorScoresUser18User24 = EuclidDist.CalculateImpostorScores(s018Mean, s024);
            sv.ImpostorScoresUser18User25 = EuclidDist.CalculateImpostorScores(s018Mean, s025);
            sv.ImpostorScoresUser18User26 = EuclidDist.CalculateImpostorScores(s018Mean, s026);
            sv.ImpostorScoresUser18User27 = EuclidDist.CalculateImpostorScores(s018Mean, s027);
            sv.ImpostorScoresUser18User28 = EuclidDist.CalculateImpostorScores(s018Mean, s028);
            sv.ImpostorScoresUser18User29 = EuclidDist.CalculateImpostorScores(s018Mean, s029);
            sv.ImpostorScoresUser18User30 = EuclidDist.CalculateImpostorScores(s018Mean, s030);

            sv.ImpostorScoresUser18User31 = EuclidDist.CalculateImpostorScores(s018Mean, s031);
            sv.ImpostorScoresUser18User32 = EuclidDist.CalculateImpostorScores(s018Mean, s032);
            sv.ImpostorScoresUser18User33 = EuclidDist.CalculateImpostorScores(s018Mean, s033);
            sv.ImpostorScoresUser18User34 = EuclidDist.CalculateImpostorScores(s018Mean, s034);
            sv.ImpostorScoresUser18User35 = EuclidDist.CalculateImpostorScores(s018Mean, s035);
            sv.ImpostorScoresUser18User36 = EuclidDist.CalculateImpostorScores(s018Mean, s036);
            sv.ImpostorScoresUser18User37 = EuclidDist.CalculateImpostorScores(s018Mean, s037);
            sv.ImpostorScoresUser18User38 = EuclidDist.CalculateImpostorScores(s018Mean, s038);
            sv.ImpostorScoresUser18User39 = EuclidDist.CalculateImpostorScores(s018Mean, s039);
            sv.ImpostorScoresUser18User40 = EuclidDist.CalculateImpostorScores(s018Mean, s040);

            sv.ImpostorScoresUser18User41 = EuclidDist.CalculateImpostorScores(s018Mean, s041);
            sv.ImpostorScoresUser18User42 = EuclidDist.CalculateImpostorScores(s018Mean, s042);
            sv.ImpostorScoresUser18User43 = EuclidDist.CalculateImpostorScores(s018Mean, s043);
            sv.ImpostorScoresUser18User44 = EuclidDist.CalculateImpostorScores(s018Mean, s044);
            sv.ImpostorScoresUser18User45 = EuclidDist.CalculateImpostorScores(s018Mean, s045);
            sv.ImpostorScoresUser18User46 = EuclidDist.CalculateImpostorScores(s018Mean, s046);
            sv.ImpostorScoresUser18User47 = EuclidDist.CalculateImpostorScores(s018Mean, s047);
            sv.ImpostorScoresUser18User48 = EuclidDist.CalculateImpostorScores(s018Mean, s048);
            sv.ImpostorScoresUser18User49 = EuclidDist.CalculateImpostorScores(s018Mean, s049);
            sv.ImpostorScoresUser18User50 = EuclidDist.CalculateImpostorScores(s018Mean, s050);

            sv.ImpostorScoresUser18User51 = EuclidDist.CalculateImpostorScores(s018Mean, s051);
            sv.ImpostorScoresUser18User52 = EuclidDist.CalculateImpostorScores(s018Mean, s052);
            sv.ImpostorScoresUser18User53 = EuclidDist.CalculateImpostorScores(s018Mean, s053);
            sv.ImpostorScoresUser18User54 = EuclidDist.CalculateImpostorScores(s018Mean, s054);
            sv.ImpostorScoresUser18User55 = EuclidDist.CalculateImpostorScores(s018Mean, s055);
            sv.ImpostorScoresUser18User56 = EuclidDist.CalculateImpostorScores(s018Mean, s056);
            sv.ImpostorScoresUser18User57 = EuclidDist.CalculateImpostorScores(s018Mean, s057);
            sv.ImpostorScoresUser18User58 = EuclidDist.CalculateImpostorScores(s018Mean, s058);
            sv.ImpostorScoresUser18User59 = EuclidDist.CalculateImpostorScores(s018Mean, s059);
            sv.ImpostorScoresUser18User60 = EuclidDist.CalculateImpostorScores(s018Mean, s060);

            sv.ImpostorScoresUser18User61 = EuclidDist.CalculateImpostorScores(s018Mean, s061);
            sv.ImpostorScoresUser18User62 = EuclidDist.CalculateImpostorScores(s018Mean, s062);
            sv.ImpostorScoresUser18User63 = EuclidDist.CalculateImpostorScores(s018Mean, s063);
            sv.ImpostorScoresUser18User64 = EuclidDist.CalculateImpostorScores(s018Mean, s064);
            sv.ImpostorScoresUser18User65 = EuclidDist.CalculateImpostorScores(s018Mean, s065);
            sv.ImpostorScoresUser18User66 = EuclidDist.CalculateImpostorScores(s018Mean, s066);
            sv.ImpostorScoresUser18User67 = EuclidDist.CalculateImpostorScores(s018Mean, s067);
            sv.ImpostorScoresUser18User68 = EuclidDist.CalculateImpostorScores(s018Mean, s068);
            sv.ImpostorScoresUser18User69 = EuclidDist.CalculateImpostorScores(s018Mean, s069);
            sv.ImpostorScoresUser18User70 = EuclidDist.CalculateImpostorScores(s018Mean, s070);

            sv.ImpostorScoresUser18User71 = EuclidDist.CalculateImpostorScores(s018Mean, s071);
            sv.ImpostorScoresUser18User72 = EuclidDist.CalculateImpostorScores(s018Mean, s072);
            sv.ImpostorScoresUser18User73 = EuclidDist.CalculateImpostorScores(s018Mean, s073);
            sv.ImpostorScoresUser18User74 = EuclidDist.CalculateImpostorScores(s018Mean, s074);
            sv.ImpostorScoresUser18User75 = EuclidDist.CalculateImpostorScores(s018Mean, s075);
            sv.ImpostorScoresUser18User76 = EuclidDist.CalculateImpostorScores(s018Mean, s076);
            sv.ImpostorScoresUser18User77 = EuclidDist.CalculateImpostorScores(s018Mean, s077);
            sv.ImpostorScoresUser18User78 = EuclidDist.CalculateImpostorScores(s018Mean, s078);
            sv.ImpostorScoresUser18User79 = EuclidDist.CalculateImpostorScores(s018Mean, s079);
            sv.ImpostorScoresUser18User80 = EuclidDist.CalculateImpostorScores(s018Mean, s080);

            sv.ImpostorScoresUser18User81 = EuclidDist.CalculateImpostorScores(s018Mean, s081);
            sv.ImpostorScoresUser18User82 = EuclidDist.CalculateImpostorScores(s018Mean, s082);
            sv.ImpostorScoresUser18User83 = EuclidDist.CalculateImpostorScores(s018Mean, s083);
            sv.ImpostorScoresUser18User84 = EuclidDist.CalculateImpostorScores(s018Mean, s084);
            sv.ImpostorScoresUser18User85 = EuclidDist.CalculateImpostorScores(s018Mean, s085);
            sv.ImpostorScoresUser18User86 = EuclidDist.CalculateImpostorScores(s018Mean, s086);
            sv.ImpostorScoresUser18User87 = EuclidDist.CalculateImpostorScores(s018Mean, s087);
            sv.ImpostorScoresUser18User88 = EuclidDist.CalculateImpostorScores(s018Mean, s088);
            sv.ImpostorScoresUser18User89 = EuclidDist.CalculateImpostorScores(s018Mean, s089);
            sv.ImpostorScoresUser18User90 = EuclidDist.CalculateImpostorScores(s018Mean, s090);

            sv.ImpostorScoresUser18User91 = EuclidDist.CalculateImpostorScores(s018Mean, s091);
            sv.ImpostorScoresUser18User92 = EuclidDist.CalculateImpostorScores(s018Mean, s092);
            sv.ImpostorScoresUser18User93 = EuclidDist.CalculateImpostorScores(s018Mean, s093);
            sv.ImpostorScoresUser18User94 = EuclidDist.CalculateImpostorScores(s018Mean, s094);
            sv.ImpostorScoresUser18User95 = EuclidDist.CalculateImpostorScores(s018Mean, s095);
            sv.ImpostorScoresUser18User96 = EuclidDist.CalculateImpostorScores(s018Mean, s096);
            sv.ImpostorScoresUser18User97 = EuclidDist.CalculateImpostorScores(s018Mean, s097);
            sv.ImpostorScoresUser18User98 = EuclidDist.CalculateImpostorScores(s018Mean, s098);
            sv.ImpostorScoresUser18User99 = EuclidDist.CalculateImpostorScores(s018Mean, s099);
            sv.ImpostorScoresUser18User100 = EuclidDist.CalculateImpostorScores(s018Mean, s100);
            #endregion

            #region User 19 Impostor scores
            sv.ImpostorScoresUser19User1 = EuclidDist.CalculateImpostorScores(s019Mean, s001);
            sv.ImpostorScoresUser19User2 = EuclidDist.CalculateImpostorScores(s019Mean, s002);
            sv.ImpostorScoresUser19User3 = EuclidDist.CalculateImpostorScores(s019Mean, s003);
            sv.ImpostorScoresUser19User4 = EuclidDist.CalculateImpostorScores(s019Mean, s004);
            sv.ImpostorScoresUser19User5 = EuclidDist.CalculateImpostorScores(s019Mean, s005);
            sv.ImpostorScoresUser19User6 = EuclidDist.CalculateImpostorScores(s019Mean, s006);
            sv.ImpostorScoresUser19User7 = EuclidDist.CalculateImpostorScores(s019Mean, s007);
            sv.ImpostorScoresUser19User8 = EuclidDist.CalculateImpostorScores(s019Mean, s008);
            sv.ImpostorScoresUser19User9 = EuclidDist.CalculateImpostorScores(s019Mean, s009);
            sv.ImpostorScoresUser19User10 = EuclidDist.CalculateImpostorScores(s019Mean, s010);

            sv.ImpostorScoresUser19User11 = EuclidDist.CalculateImpostorScores(s019Mean, s011);
            sv.ImpostorScoresUser19User12 = EuclidDist.CalculateImpostorScores(s019Mean, s012);
            sv.ImpostorScoresUser19User13 = EuclidDist.CalculateImpostorScores(s019Mean, s013);
            sv.ImpostorScoresUser19User14 = EuclidDist.CalculateImpostorScores(s019Mean, s014);
            sv.ImpostorScoresUser19User15 = EuclidDist.CalculateImpostorScores(s019Mean, s015);
            sv.ImpostorScoresUser19User16 = EuclidDist.CalculateImpostorScores(s019Mean, s016);
            sv.ImpostorScoresUser19User17 = EuclidDist.CalculateImpostorScores(s019Mean, s017);
            sv.ImpostorScoresUser19User18 = EuclidDist.CalculateImpostorScores(s019Mean, s018);
            sv.ImpostorScoresUser19User20 = EuclidDist.CalculateImpostorScores(s019Mean, s020);

            sv.ImpostorScoresUser19User21 = EuclidDist.CalculateImpostorScores(s019Mean, s021);
            sv.ImpostorScoresUser19User22 = EuclidDist.CalculateImpostorScores(s019Mean, s022);
            sv.ImpostorScoresUser19User23 = EuclidDist.CalculateImpostorScores(s019Mean, s023);
            sv.ImpostorScoresUser19User24 = EuclidDist.CalculateImpostorScores(s019Mean, s024);
            sv.ImpostorScoresUser19User25 = EuclidDist.CalculateImpostorScores(s019Mean, s025);
            sv.ImpostorScoresUser19User26 = EuclidDist.CalculateImpostorScores(s019Mean, s026);
            sv.ImpostorScoresUser19User27 = EuclidDist.CalculateImpostorScores(s019Mean, s027);
            sv.ImpostorScoresUser19User28 = EuclidDist.CalculateImpostorScores(s019Mean, s028);
            sv.ImpostorScoresUser19User29 = EuclidDist.CalculateImpostorScores(s019Mean, s029);
            sv.ImpostorScoresUser19User30 = EuclidDist.CalculateImpostorScores(s019Mean, s030);

            sv.ImpostorScoresUser19User31 = EuclidDist.CalculateImpostorScores(s019Mean, s031);
            sv.ImpostorScoresUser19User32 = EuclidDist.CalculateImpostorScores(s019Mean, s032);
            sv.ImpostorScoresUser19User33 = EuclidDist.CalculateImpostorScores(s019Mean, s033);
            sv.ImpostorScoresUser19User34 = EuclidDist.CalculateImpostorScores(s019Mean, s034);
            sv.ImpostorScoresUser19User35 = EuclidDist.CalculateImpostorScores(s019Mean, s035);
            sv.ImpostorScoresUser19User36 = EuclidDist.CalculateImpostorScores(s019Mean, s036);
            sv.ImpostorScoresUser19User37 = EuclidDist.CalculateImpostorScores(s019Mean, s037);
            sv.ImpostorScoresUser19User38 = EuclidDist.CalculateImpostorScores(s019Mean, s038);
            sv.ImpostorScoresUser19User39 = EuclidDist.CalculateImpostorScores(s019Mean, s039);
            sv.ImpostorScoresUser19User40 = EuclidDist.CalculateImpostorScores(s019Mean, s040);

            sv.ImpostorScoresUser19User41 = EuclidDist.CalculateImpostorScores(s019Mean, s041);
            sv.ImpostorScoresUser19User42 = EuclidDist.CalculateImpostorScores(s019Mean, s042);
            sv.ImpostorScoresUser19User43 = EuclidDist.CalculateImpostorScores(s019Mean, s043);
            sv.ImpostorScoresUser19User44 = EuclidDist.CalculateImpostorScores(s019Mean, s044);
            sv.ImpostorScoresUser19User45 = EuclidDist.CalculateImpostorScores(s019Mean, s045);
            sv.ImpostorScoresUser19User46 = EuclidDist.CalculateImpostorScores(s019Mean, s046);
            sv.ImpostorScoresUser19User47 = EuclidDist.CalculateImpostorScores(s019Mean, s047);
            sv.ImpostorScoresUser19User48 = EuclidDist.CalculateImpostorScores(s019Mean, s048);
            sv.ImpostorScoresUser19User49 = EuclidDist.CalculateImpostorScores(s019Mean, s049);
            sv.ImpostorScoresUser19User50 = EuclidDist.CalculateImpostorScores(s019Mean, s050);

            sv.ImpostorScoresUser19User51 = EuclidDist.CalculateImpostorScores(s019Mean, s051);
            sv.ImpostorScoresUser19User52 = EuclidDist.CalculateImpostorScores(s019Mean, s052);
            sv.ImpostorScoresUser19User53 = EuclidDist.CalculateImpostorScores(s019Mean, s053);
            sv.ImpostorScoresUser19User54 = EuclidDist.CalculateImpostorScores(s019Mean, s054);
            sv.ImpostorScoresUser19User55 = EuclidDist.CalculateImpostorScores(s019Mean, s055);
            sv.ImpostorScoresUser19User56 = EuclidDist.CalculateImpostorScores(s019Mean, s056);
            sv.ImpostorScoresUser19User57 = EuclidDist.CalculateImpostorScores(s019Mean, s057);
            sv.ImpostorScoresUser19User58 = EuclidDist.CalculateImpostorScores(s019Mean, s058);
            sv.ImpostorScoresUser19User59 = EuclidDist.CalculateImpostorScores(s019Mean, s059);
            sv.ImpostorScoresUser19User60 = EuclidDist.CalculateImpostorScores(s019Mean, s060);

            sv.ImpostorScoresUser19User61 = EuclidDist.CalculateImpostorScores(s019Mean, s061);
            sv.ImpostorScoresUser19User62 = EuclidDist.CalculateImpostorScores(s019Mean, s062);
            sv.ImpostorScoresUser19User63 = EuclidDist.CalculateImpostorScores(s019Mean, s063);
            sv.ImpostorScoresUser19User64 = EuclidDist.CalculateImpostorScores(s019Mean, s064);
            sv.ImpostorScoresUser19User65 = EuclidDist.CalculateImpostorScores(s019Mean, s065);
            sv.ImpostorScoresUser19User66 = EuclidDist.CalculateImpostorScores(s019Mean, s066);
            sv.ImpostorScoresUser19User67 = EuclidDist.CalculateImpostorScores(s019Mean, s067);
            sv.ImpostorScoresUser19User68 = EuclidDist.CalculateImpostorScores(s019Mean, s068);
            sv.ImpostorScoresUser19User69 = EuclidDist.CalculateImpostorScores(s019Mean, s069);
            sv.ImpostorScoresUser19User70 = EuclidDist.CalculateImpostorScores(s019Mean, s070);

            sv.ImpostorScoresUser19User71 = EuclidDist.CalculateImpostorScores(s019Mean, s071);
            sv.ImpostorScoresUser19User72 = EuclidDist.CalculateImpostorScores(s019Mean, s072);
            sv.ImpostorScoresUser19User73 = EuclidDist.CalculateImpostorScores(s019Mean, s073);
            sv.ImpostorScoresUser19User74 = EuclidDist.CalculateImpostorScores(s019Mean, s074);
            sv.ImpostorScoresUser19User75 = EuclidDist.CalculateImpostorScores(s019Mean, s075);
            sv.ImpostorScoresUser19User76 = EuclidDist.CalculateImpostorScores(s019Mean, s076);
            sv.ImpostorScoresUser19User77 = EuclidDist.CalculateImpostorScores(s019Mean, s077);
            sv.ImpostorScoresUser19User78 = EuclidDist.CalculateImpostorScores(s019Mean, s078);
            sv.ImpostorScoresUser19User79 = EuclidDist.CalculateImpostorScores(s019Mean, s079);
            sv.ImpostorScoresUser19User80 = EuclidDist.CalculateImpostorScores(s019Mean, s080);

            sv.ImpostorScoresUser19User81 = EuclidDist.CalculateImpostorScores(s019Mean, s081);
            sv.ImpostorScoresUser19User82 = EuclidDist.CalculateImpostorScores(s019Mean, s082);
            sv.ImpostorScoresUser19User83 = EuclidDist.CalculateImpostorScores(s019Mean, s083);
            sv.ImpostorScoresUser19User84 = EuclidDist.CalculateImpostorScores(s019Mean, s084);
            sv.ImpostorScoresUser19User85 = EuclidDist.CalculateImpostorScores(s019Mean, s085);
            sv.ImpostorScoresUser19User86 = EuclidDist.CalculateImpostorScores(s019Mean, s086);
            sv.ImpostorScoresUser19User87 = EuclidDist.CalculateImpostorScores(s019Mean, s087);
            sv.ImpostorScoresUser19User88 = EuclidDist.CalculateImpostorScores(s019Mean, s088);
            sv.ImpostorScoresUser19User89 = EuclidDist.CalculateImpostorScores(s019Mean, s089);
            sv.ImpostorScoresUser19User90 = EuclidDist.CalculateImpostorScores(s019Mean, s090);

            sv.ImpostorScoresUser19User91 = EuclidDist.CalculateImpostorScores(s019Mean, s091);
            sv.ImpostorScoresUser19User92 = EuclidDist.CalculateImpostorScores(s019Mean, s092);
            sv.ImpostorScoresUser19User93 = EuclidDist.CalculateImpostorScores(s019Mean, s093);
            sv.ImpostorScoresUser19User94 = EuclidDist.CalculateImpostorScores(s019Mean, s094);
            sv.ImpostorScoresUser19User95 = EuclidDist.CalculateImpostorScores(s019Mean, s095);
            sv.ImpostorScoresUser19User96 = EuclidDist.CalculateImpostorScores(s019Mean, s096);
            sv.ImpostorScoresUser19User97 = EuclidDist.CalculateImpostorScores(s019Mean, s097);
            sv.ImpostorScoresUser19User98 = EuclidDist.CalculateImpostorScores(s019Mean, s098);
            sv.ImpostorScoresUser19User99 = EuclidDist.CalculateImpostorScores(s019Mean, s099);
            sv.ImpostorScoresUser19User100 = EuclidDist.CalculateImpostorScores(s019Mean, s100);
            #endregion

            #region User 20 Impostor scores
            sv.ImpostorScoresUser20User1 = EuclidDist.CalculateImpostorScores(s020Mean, s001);
            sv.ImpostorScoresUser20User2 = EuclidDist.CalculateImpostorScores(s020Mean, s002);
            sv.ImpostorScoresUser20User3 = EuclidDist.CalculateImpostorScores(s020Mean, s003);
            sv.ImpostorScoresUser20User4 = EuclidDist.CalculateImpostorScores(s020Mean, s004);
            sv.ImpostorScoresUser20User5 = EuclidDist.CalculateImpostorScores(s020Mean, s005);
            sv.ImpostorScoresUser20User6 = EuclidDist.CalculateImpostorScores(s020Mean, s006);
            sv.ImpostorScoresUser20User7 = EuclidDist.CalculateImpostorScores(s020Mean, s007);
            sv.ImpostorScoresUser20User8 = EuclidDist.CalculateImpostorScores(s020Mean, s008);
            sv.ImpostorScoresUser20User9 = EuclidDist.CalculateImpostorScores(s020Mean, s009);
            sv.ImpostorScoresUser20User10 = EuclidDist.CalculateImpostorScores(s020Mean, s010);

            sv.ImpostorScoresUser20User11 = EuclidDist.CalculateImpostorScores(s020Mean, s011);
            sv.ImpostorScoresUser20User12 = EuclidDist.CalculateImpostorScores(s020Mean, s012);
            sv.ImpostorScoresUser20User13 = EuclidDist.CalculateImpostorScores(s020Mean, s013);
            sv.ImpostorScoresUser20User14 = EuclidDist.CalculateImpostorScores(s020Mean, s014);
            sv.ImpostorScoresUser20User15 = EuclidDist.CalculateImpostorScores(s020Mean, s015);
            sv.ImpostorScoresUser20User16 = EuclidDist.CalculateImpostorScores(s020Mean, s016);
            sv.ImpostorScoresUser20User17 = EuclidDist.CalculateImpostorScores(s020Mean, s017);
            sv.ImpostorScoresUser20User18 = EuclidDist.CalculateImpostorScores(s020Mean, s018);
            sv.ImpostorScoresUser20User19 = EuclidDist.CalculateImpostorScores(s020Mean, s019);

            sv.ImpostorScoresUser20User21 = EuclidDist.CalculateImpostorScores(s020Mean, s021);
            sv.ImpostorScoresUser20User22 = EuclidDist.CalculateImpostorScores(s020Mean, s022);
            sv.ImpostorScoresUser20User23 = EuclidDist.CalculateImpostorScores(s020Mean, s023);
            sv.ImpostorScoresUser20User24 = EuclidDist.CalculateImpostorScores(s020Mean, s024);
            sv.ImpostorScoresUser20User25 = EuclidDist.CalculateImpostorScores(s020Mean, s025);
            sv.ImpostorScoresUser20User26 = EuclidDist.CalculateImpostorScores(s020Mean, s026);
            sv.ImpostorScoresUser20User27 = EuclidDist.CalculateImpostorScores(s020Mean, s027);
            sv.ImpostorScoresUser20User28 = EuclidDist.CalculateImpostorScores(s020Mean, s028);
            sv.ImpostorScoresUser20User29 = EuclidDist.CalculateImpostorScores(s020Mean, s029);
            sv.ImpostorScoresUser20User30 = EuclidDist.CalculateImpostorScores(s020Mean, s030);

            sv.ImpostorScoresUser20User31 = EuclidDist.CalculateImpostorScores(s020Mean, s031);
            sv.ImpostorScoresUser20User32 = EuclidDist.CalculateImpostorScores(s020Mean, s032);
            sv.ImpostorScoresUser20User33 = EuclidDist.CalculateImpostorScores(s020Mean, s033);
            sv.ImpostorScoresUser20User34 = EuclidDist.CalculateImpostorScores(s020Mean, s034);
            sv.ImpostorScoresUser20User35 = EuclidDist.CalculateImpostorScores(s020Mean, s035);
            sv.ImpostorScoresUser20User36 = EuclidDist.CalculateImpostorScores(s020Mean, s036);
            sv.ImpostorScoresUser20User37 = EuclidDist.CalculateImpostorScores(s020Mean, s037);
            sv.ImpostorScoresUser20User38 = EuclidDist.CalculateImpostorScores(s020Mean, s038);
            sv.ImpostorScoresUser20User39 = EuclidDist.CalculateImpostorScores(s020Mean, s039);
            sv.ImpostorScoresUser20User40 = EuclidDist.CalculateImpostorScores(s020Mean, s040);

            sv.ImpostorScoresUser20User41 = EuclidDist.CalculateImpostorScores(s020Mean, s041);
            sv.ImpostorScoresUser20User42 = EuclidDist.CalculateImpostorScores(s020Mean, s042);
            sv.ImpostorScoresUser20User43 = EuclidDist.CalculateImpostorScores(s020Mean, s043);
            sv.ImpostorScoresUser20User44 = EuclidDist.CalculateImpostorScores(s020Mean, s044);
            sv.ImpostorScoresUser20User45 = EuclidDist.CalculateImpostorScores(s020Mean, s045);
            sv.ImpostorScoresUser20User46 = EuclidDist.CalculateImpostorScores(s020Mean, s046);
            sv.ImpostorScoresUser20User47 = EuclidDist.CalculateImpostorScores(s020Mean, s047);
            sv.ImpostorScoresUser20User48 = EuclidDist.CalculateImpostorScores(s020Mean, s048);
            sv.ImpostorScoresUser20User49 = EuclidDist.CalculateImpostorScores(s020Mean, s049);
            sv.ImpostorScoresUser20User50 = EuclidDist.CalculateImpostorScores(s020Mean, s050);

            sv.ImpostorScoresUser20User51 = EuclidDist.CalculateImpostorScores(s020Mean, s051);
            sv.ImpostorScoresUser20User52 = EuclidDist.CalculateImpostorScores(s020Mean, s052);
            sv.ImpostorScoresUser20User53 = EuclidDist.CalculateImpostorScores(s020Mean, s053);
            sv.ImpostorScoresUser20User54 = EuclidDist.CalculateImpostorScores(s020Mean, s054);
            sv.ImpostorScoresUser20User55 = EuclidDist.CalculateImpostorScores(s020Mean, s055);
            sv.ImpostorScoresUser20User56 = EuclidDist.CalculateImpostorScores(s020Mean, s056);
            sv.ImpostorScoresUser20User57 = EuclidDist.CalculateImpostorScores(s020Mean, s057);
            sv.ImpostorScoresUser20User58 = EuclidDist.CalculateImpostorScores(s020Mean, s058);
            sv.ImpostorScoresUser20User59 = EuclidDist.CalculateImpostorScores(s020Mean, s059);
            sv.ImpostorScoresUser20User60 = EuclidDist.CalculateImpostorScores(s020Mean, s060);

            sv.ImpostorScoresUser20User61 = EuclidDist.CalculateImpostorScores(s020Mean, s061);
            sv.ImpostorScoresUser20User62 = EuclidDist.CalculateImpostorScores(s020Mean, s062);
            sv.ImpostorScoresUser20User63 = EuclidDist.CalculateImpostorScores(s020Mean, s063);
            sv.ImpostorScoresUser20User64 = EuclidDist.CalculateImpostorScores(s020Mean, s064);
            sv.ImpostorScoresUser20User65 = EuclidDist.CalculateImpostorScores(s020Mean, s065);
            sv.ImpostorScoresUser20User66 = EuclidDist.CalculateImpostorScores(s020Mean, s066);
            sv.ImpostorScoresUser20User67 = EuclidDist.CalculateImpostorScores(s020Mean, s067);
            sv.ImpostorScoresUser20User68 = EuclidDist.CalculateImpostorScores(s020Mean, s068);
            sv.ImpostorScoresUser20User69 = EuclidDist.CalculateImpostorScores(s020Mean, s069);
            sv.ImpostorScoresUser20User70 = EuclidDist.CalculateImpostorScores(s020Mean, s070);

            sv.ImpostorScoresUser20User71 = EuclidDist.CalculateImpostorScores(s020Mean, s071);
            sv.ImpostorScoresUser20User72 = EuclidDist.CalculateImpostorScores(s020Mean, s072);
            sv.ImpostorScoresUser20User73 = EuclidDist.CalculateImpostorScores(s020Mean, s073);
            sv.ImpostorScoresUser20User74 = EuclidDist.CalculateImpostorScores(s020Mean, s074);
            sv.ImpostorScoresUser20User75 = EuclidDist.CalculateImpostorScores(s020Mean, s075);
            sv.ImpostorScoresUser20User76 = EuclidDist.CalculateImpostorScores(s020Mean, s076);
            sv.ImpostorScoresUser20User77 = EuclidDist.CalculateImpostorScores(s020Mean, s077);
            sv.ImpostorScoresUser20User78 = EuclidDist.CalculateImpostorScores(s020Mean, s078);
            sv.ImpostorScoresUser20User79 = EuclidDist.CalculateImpostorScores(s020Mean, s079);
            sv.ImpostorScoresUser20User80 = EuclidDist.CalculateImpostorScores(s020Mean, s080);

            sv.ImpostorScoresUser20User81 = EuclidDist.CalculateImpostorScores(s020Mean, s081);
            sv.ImpostorScoresUser20User82 = EuclidDist.CalculateImpostorScores(s020Mean, s082);
            sv.ImpostorScoresUser20User83 = EuclidDist.CalculateImpostorScores(s020Mean, s083);
            sv.ImpostorScoresUser20User84 = EuclidDist.CalculateImpostorScores(s020Mean, s084);
            sv.ImpostorScoresUser20User85 = EuclidDist.CalculateImpostorScores(s020Mean, s085);
            sv.ImpostorScoresUser20User86 = EuclidDist.CalculateImpostorScores(s020Mean, s086);
            sv.ImpostorScoresUser20User87 = EuclidDist.CalculateImpostorScores(s020Mean, s087);
            sv.ImpostorScoresUser20User88 = EuclidDist.CalculateImpostorScores(s020Mean, s088);
            sv.ImpostorScoresUser20User89 = EuclidDist.CalculateImpostorScores(s020Mean, s089);
            sv.ImpostorScoresUser20User90 = EuclidDist.CalculateImpostorScores(s020Mean, s090);

            sv.ImpostorScoresUser20User91 = EuclidDist.CalculateImpostorScores(s020Mean, s091);
            sv.ImpostorScoresUser20User92 = EuclidDist.CalculateImpostorScores(s020Mean, s092);
            sv.ImpostorScoresUser20User93 = EuclidDist.CalculateImpostorScores(s020Mean, s093);
            sv.ImpostorScoresUser20User94 = EuclidDist.CalculateImpostorScores(s020Mean, s094);
            sv.ImpostorScoresUser20User95 = EuclidDist.CalculateImpostorScores(s020Mean, s095);
            sv.ImpostorScoresUser20User96 = EuclidDist.CalculateImpostorScores(s020Mean, s096);
            sv.ImpostorScoresUser20User97 = EuclidDist.CalculateImpostorScores(s020Mean, s097);
            sv.ImpostorScoresUser20User98 = EuclidDist.CalculateImpostorScores(s020Mean, s098);
            sv.ImpostorScoresUser20User99 = EuclidDist.CalculateImpostorScores(s020Mean, s099);
            sv.ImpostorScoresUser20User100 = EuclidDist.CalculateImpostorScores(s020Mean, s100);
            #endregion

            #region User 21 Impostor scores
            sv.ImpostorScoresUser21User1 = EuclidDist.CalculateImpostorScores(s021Mean, s001);
            sv.ImpostorScoresUser21User2 = EuclidDist.CalculateImpostorScores(s021Mean, s002);
            sv.ImpostorScoresUser21User3 = EuclidDist.CalculateImpostorScores(s021Mean, s003);
            sv.ImpostorScoresUser21User4 = EuclidDist.CalculateImpostorScores(s021Mean, s004);
            sv.ImpostorScoresUser21User5 = EuclidDist.CalculateImpostorScores(s021Mean, s005);
            sv.ImpostorScoresUser21User6 = EuclidDist.CalculateImpostorScores(s021Mean, s006);
            sv.ImpostorScoresUser21User7 = EuclidDist.CalculateImpostorScores(s021Mean, s007);
            sv.ImpostorScoresUser21User8 = EuclidDist.CalculateImpostorScores(s021Mean, s008);
            sv.ImpostorScoresUser21User9 = EuclidDist.CalculateImpostorScores(s021Mean, s009);
            sv.ImpostorScoresUser21User10 = EuclidDist.CalculateImpostorScores(s021Mean, s010);

            sv.ImpostorScoresUser21User11 = EuclidDist.CalculateImpostorScores(s021Mean, s011);
            sv.ImpostorScoresUser21User12 = EuclidDist.CalculateImpostorScores(s021Mean, s012);
            sv.ImpostorScoresUser21User13 = EuclidDist.CalculateImpostorScores(s021Mean, s013);
            sv.ImpostorScoresUser21User14 = EuclidDist.CalculateImpostorScores(s021Mean, s014);
            sv.ImpostorScoresUser21User15 = EuclidDist.CalculateImpostorScores(s021Mean, s015);
            sv.ImpostorScoresUser21User16 = EuclidDist.CalculateImpostorScores(s021Mean, s016);
            sv.ImpostorScoresUser21User17 = EuclidDist.CalculateImpostorScores(s021Mean, s017);
            sv.ImpostorScoresUser21User18 = EuclidDist.CalculateImpostorScores(s021Mean, s018);
            sv.ImpostorScoresUser21User19 = EuclidDist.CalculateImpostorScores(s021Mean, s019);
            sv.ImpostorScoresUser21User20 = EuclidDist.CalculateImpostorScores(s021Mean, s020);

            sv.ImpostorScoresUser21User22 = EuclidDist.CalculateImpostorScores(s021Mean, s022);
            sv.ImpostorScoresUser21User23 = EuclidDist.CalculateImpostorScores(s021Mean, s023);
            sv.ImpostorScoresUser21User24 = EuclidDist.CalculateImpostorScores(s021Mean, s024);
            sv.ImpostorScoresUser21User25 = EuclidDist.CalculateImpostorScores(s021Mean, s025);
            sv.ImpostorScoresUser21User26 = EuclidDist.CalculateImpostorScores(s021Mean, s026);
            sv.ImpostorScoresUser21User27 = EuclidDist.CalculateImpostorScores(s021Mean, s027);
            sv.ImpostorScoresUser21User28 = EuclidDist.CalculateImpostorScores(s021Mean, s028);
            sv.ImpostorScoresUser21User29 = EuclidDist.CalculateImpostorScores(s021Mean, s029);
            sv.ImpostorScoresUser21User30 = EuclidDist.CalculateImpostorScores(s021Mean, s030);

            sv.ImpostorScoresUser21User31 = EuclidDist.CalculateImpostorScores(s021Mean, s031);
            sv.ImpostorScoresUser21User32 = EuclidDist.CalculateImpostorScores(s021Mean, s032);
            sv.ImpostorScoresUser21User33 = EuclidDist.CalculateImpostorScores(s021Mean, s033);
            sv.ImpostorScoresUser21User34 = EuclidDist.CalculateImpostorScores(s021Mean, s034);
            sv.ImpostorScoresUser21User35 = EuclidDist.CalculateImpostorScores(s021Mean, s035);
            sv.ImpostorScoresUser21User36 = EuclidDist.CalculateImpostorScores(s021Mean, s036);
            sv.ImpostorScoresUser21User37 = EuclidDist.CalculateImpostorScores(s021Mean, s037);
            sv.ImpostorScoresUser21User38 = EuclidDist.CalculateImpostorScores(s021Mean, s038);
            sv.ImpostorScoresUser21User39 = EuclidDist.CalculateImpostorScores(s021Mean, s039);
            sv.ImpostorScoresUser21User40 = EuclidDist.CalculateImpostorScores(s021Mean, s040);

            sv.ImpostorScoresUser21User41 = EuclidDist.CalculateImpostorScores(s021Mean, s041);
            sv.ImpostorScoresUser21User42 = EuclidDist.CalculateImpostorScores(s021Mean, s042);
            sv.ImpostorScoresUser21User43 = EuclidDist.CalculateImpostorScores(s021Mean, s043);
            sv.ImpostorScoresUser21User44 = EuclidDist.CalculateImpostorScores(s021Mean, s044);
            sv.ImpostorScoresUser21User45 = EuclidDist.CalculateImpostorScores(s021Mean, s045);
            sv.ImpostorScoresUser21User46 = EuclidDist.CalculateImpostorScores(s021Mean, s046);
            sv.ImpostorScoresUser21User47 = EuclidDist.CalculateImpostorScores(s021Mean, s047);
            sv.ImpostorScoresUser21User48 = EuclidDist.CalculateImpostorScores(s021Mean, s048);
            sv.ImpostorScoresUser21User49 = EuclidDist.CalculateImpostorScores(s021Mean, s049);
            sv.ImpostorScoresUser21User50 = EuclidDist.CalculateImpostorScores(s021Mean, s050);

            sv.ImpostorScoresUser21User51 = EuclidDist.CalculateImpostorScores(s021Mean, s051);
            sv.ImpostorScoresUser21User52 = EuclidDist.CalculateImpostorScores(s021Mean, s052);
            sv.ImpostorScoresUser21User53 = EuclidDist.CalculateImpostorScores(s021Mean, s053);
            sv.ImpostorScoresUser21User54 = EuclidDist.CalculateImpostorScores(s021Mean, s054);
            sv.ImpostorScoresUser21User55 = EuclidDist.CalculateImpostorScores(s021Mean, s055);
            sv.ImpostorScoresUser21User56 = EuclidDist.CalculateImpostorScores(s021Mean, s056);
            sv.ImpostorScoresUser21User57 = EuclidDist.CalculateImpostorScores(s021Mean, s057);
            sv.ImpostorScoresUser21User58 = EuclidDist.CalculateImpostorScores(s021Mean, s058);
            sv.ImpostorScoresUser21User59 = EuclidDist.CalculateImpostorScores(s021Mean, s059);
            sv.ImpostorScoresUser21User60 = EuclidDist.CalculateImpostorScores(s021Mean, s060);

            sv.ImpostorScoresUser21User61 = EuclidDist.CalculateImpostorScores(s021Mean, s061);
            sv.ImpostorScoresUser21User62 = EuclidDist.CalculateImpostorScores(s021Mean, s062);
            sv.ImpostorScoresUser21User63 = EuclidDist.CalculateImpostorScores(s021Mean, s063);
            sv.ImpostorScoresUser21User64 = EuclidDist.CalculateImpostorScores(s021Mean, s064);
            sv.ImpostorScoresUser21User65 = EuclidDist.CalculateImpostorScores(s021Mean, s065);
            sv.ImpostorScoresUser21User66 = EuclidDist.CalculateImpostorScores(s021Mean, s066);
            sv.ImpostorScoresUser21User67 = EuclidDist.CalculateImpostorScores(s021Mean, s067);
            sv.ImpostorScoresUser21User68 = EuclidDist.CalculateImpostorScores(s021Mean, s068);
            sv.ImpostorScoresUser21User69 = EuclidDist.CalculateImpostorScores(s021Mean, s069);
            sv.ImpostorScoresUser21User70 = EuclidDist.CalculateImpostorScores(s021Mean, s070);

            sv.ImpostorScoresUser21User71 = EuclidDist.CalculateImpostorScores(s021Mean, s071);
            sv.ImpostorScoresUser21User72 = EuclidDist.CalculateImpostorScores(s021Mean, s072);
            sv.ImpostorScoresUser21User73 = EuclidDist.CalculateImpostorScores(s021Mean, s073);
            sv.ImpostorScoresUser21User74 = EuclidDist.CalculateImpostorScores(s021Mean, s074);
            sv.ImpostorScoresUser21User75 = EuclidDist.CalculateImpostorScores(s021Mean, s075);
            sv.ImpostorScoresUser21User76 = EuclidDist.CalculateImpostorScores(s021Mean, s076);
            sv.ImpostorScoresUser21User77 = EuclidDist.CalculateImpostorScores(s021Mean, s077);
            sv.ImpostorScoresUser21User78 = EuclidDist.CalculateImpostorScores(s021Mean, s078);
            sv.ImpostorScoresUser21User79 = EuclidDist.CalculateImpostorScores(s021Mean, s079);
            sv.ImpostorScoresUser21User80 = EuclidDist.CalculateImpostorScores(s021Mean, s080);

            sv.ImpostorScoresUser21User81 = EuclidDist.CalculateImpostorScores(s021Mean, s081);
            sv.ImpostorScoresUser21User82 = EuclidDist.CalculateImpostorScores(s021Mean, s082);
            sv.ImpostorScoresUser21User83 = EuclidDist.CalculateImpostorScores(s021Mean, s083);
            sv.ImpostorScoresUser21User84 = EuclidDist.CalculateImpostorScores(s021Mean, s084);
            sv.ImpostorScoresUser21User85 = EuclidDist.CalculateImpostorScores(s021Mean, s085);
            sv.ImpostorScoresUser21User86 = EuclidDist.CalculateImpostorScores(s021Mean, s086);
            sv.ImpostorScoresUser21User87 = EuclidDist.CalculateImpostorScores(s021Mean, s087);
            sv.ImpostorScoresUser21User88 = EuclidDist.CalculateImpostorScores(s021Mean, s088);
            sv.ImpostorScoresUser21User89 = EuclidDist.CalculateImpostorScores(s021Mean, s089);
            sv.ImpostorScoresUser21User90 = EuclidDist.CalculateImpostorScores(s021Mean, s090);

            sv.ImpostorScoresUser21User91 = EuclidDist.CalculateImpostorScores(s021Mean, s091);
            sv.ImpostorScoresUser21User92 = EuclidDist.CalculateImpostorScores(s021Mean, s092);
            sv.ImpostorScoresUser21User93 = EuclidDist.CalculateImpostorScores(s021Mean, s093);
            sv.ImpostorScoresUser21User94 = EuclidDist.CalculateImpostorScores(s021Mean, s094);
            sv.ImpostorScoresUser21User95 = EuclidDist.CalculateImpostorScores(s021Mean, s095);
            sv.ImpostorScoresUser21User96 = EuclidDist.CalculateImpostorScores(s021Mean, s096);
            sv.ImpostorScoresUser21User97 = EuclidDist.CalculateImpostorScores(s021Mean, s097);
            sv.ImpostorScoresUser21User98 = EuclidDist.CalculateImpostorScores(s021Mean, s098);
            sv.ImpostorScoresUser21User99 = EuclidDist.CalculateImpostorScores(s021Mean, s099);
            sv.ImpostorScoresUser21User100 = EuclidDist.CalculateImpostorScores(s021Mean, s100);
            #endregion

            #region User 22 Impostor scores
            sv.ImpostorScoresUser22User1 = EuclidDist.CalculateImpostorScores(s022Mean, s001);
            sv.ImpostorScoresUser22User2 = EuclidDist.CalculateImpostorScores(s022Mean, s002);
            sv.ImpostorScoresUser22User3 = EuclidDist.CalculateImpostorScores(s022Mean, s003);
            sv.ImpostorScoresUser22User4 = EuclidDist.CalculateImpostorScores(s022Mean, s004);
            sv.ImpostorScoresUser22User5 = EuclidDist.CalculateImpostorScores(s022Mean, s005);
            sv.ImpostorScoresUser22User6 = EuclidDist.CalculateImpostorScores(s022Mean, s006);
            sv.ImpostorScoresUser22User7 = EuclidDist.CalculateImpostorScores(s022Mean, s007);
            sv.ImpostorScoresUser22User8 = EuclidDist.CalculateImpostorScores(s022Mean, s008);
            sv.ImpostorScoresUser22User9 = EuclidDist.CalculateImpostorScores(s022Mean, s009);
            sv.ImpostorScoresUser22User10 = EuclidDist.CalculateImpostorScores(s022Mean, s010);

            sv.ImpostorScoresUser22User11 = EuclidDist.CalculateImpostorScores(s022Mean, s011);
            sv.ImpostorScoresUser22User12 = EuclidDist.CalculateImpostorScores(s022Mean, s012);
            sv.ImpostorScoresUser22User13 = EuclidDist.CalculateImpostorScores(s022Mean, s013);
            sv.ImpostorScoresUser22User14 = EuclidDist.CalculateImpostorScores(s022Mean, s014);
            sv.ImpostorScoresUser22User15 = EuclidDist.CalculateImpostorScores(s022Mean, s015);
            sv.ImpostorScoresUser22User16 = EuclidDist.CalculateImpostorScores(s022Mean, s016);
            sv.ImpostorScoresUser22User17 = EuclidDist.CalculateImpostorScores(s022Mean, s017);
            sv.ImpostorScoresUser22User18 = EuclidDist.CalculateImpostorScores(s022Mean, s018);
            sv.ImpostorScoresUser22User19 = EuclidDist.CalculateImpostorScores(s022Mean, s019);
            sv.ImpostorScoresUser22User20 = EuclidDist.CalculateImpostorScores(s022Mean, s020);

            sv.ImpostorScoresUser22User21 = EuclidDist.CalculateImpostorScores(s022Mean, s021);
            sv.ImpostorScoresUser22User23 = EuclidDist.CalculateImpostorScores(s022Mean, s023);
            sv.ImpostorScoresUser22User24 = EuclidDist.CalculateImpostorScores(s022Mean, s024);
            sv.ImpostorScoresUser22User25 = EuclidDist.CalculateImpostorScores(s022Mean, s025);
            sv.ImpostorScoresUser22User26 = EuclidDist.CalculateImpostorScores(s022Mean, s026);
            sv.ImpostorScoresUser22User27 = EuclidDist.CalculateImpostorScores(s022Mean, s027);
            sv.ImpostorScoresUser22User28 = EuclidDist.CalculateImpostorScores(s022Mean, s028);
            sv.ImpostorScoresUser22User29 = EuclidDist.CalculateImpostorScores(s022Mean, s029);
            sv.ImpostorScoresUser22User30 = EuclidDist.CalculateImpostorScores(s022Mean, s030);

            sv.ImpostorScoresUser22User31 = EuclidDist.CalculateImpostorScores(s022Mean, s031);
            sv.ImpostorScoresUser22User32 = EuclidDist.CalculateImpostorScores(s022Mean, s032);
            sv.ImpostorScoresUser22User33 = EuclidDist.CalculateImpostorScores(s022Mean, s033);
            sv.ImpostorScoresUser22User34 = EuclidDist.CalculateImpostorScores(s022Mean, s034);
            sv.ImpostorScoresUser22User35 = EuclidDist.CalculateImpostorScores(s022Mean, s035);
            sv.ImpostorScoresUser22User36 = EuclidDist.CalculateImpostorScores(s022Mean, s036);
            sv.ImpostorScoresUser22User37 = EuclidDist.CalculateImpostorScores(s022Mean, s037);
            sv.ImpostorScoresUser22User38 = EuclidDist.CalculateImpostorScores(s022Mean, s038);
            sv.ImpostorScoresUser22User39 = EuclidDist.CalculateImpostorScores(s022Mean, s039);
            sv.ImpostorScoresUser22User40 = EuclidDist.CalculateImpostorScores(s022Mean, s040);

            sv.ImpostorScoresUser22User41 = EuclidDist.CalculateImpostorScores(s022Mean, s041);
            sv.ImpostorScoresUser22User42 = EuclidDist.CalculateImpostorScores(s022Mean, s042);
            sv.ImpostorScoresUser22User43 = EuclidDist.CalculateImpostorScores(s022Mean, s043);
            sv.ImpostorScoresUser22User44 = EuclidDist.CalculateImpostorScores(s022Mean, s044);
            sv.ImpostorScoresUser22User45 = EuclidDist.CalculateImpostorScores(s022Mean, s045);
            sv.ImpostorScoresUser22User46 = EuclidDist.CalculateImpostorScores(s022Mean, s046);
            sv.ImpostorScoresUser22User47 = EuclidDist.CalculateImpostorScores(s022Mean, s047);
            sv.ImpostorScoresUser22User48 = EuclidDist.CalculateImpostorScores(s022Mean, s048);
            sv.ImpostorScoresUser22User49 = EuclidDist.CalculateImpostorScores(s022Mean, s049);
            sv.ImpostorScoresUser22User50 = EuclidDist.CalculateImpostorScores(s022Mean, s050);

            sv.ImpostorScoresUser22User51 = EuclidDist.CalculateImpostorScores(s022Mean, s051);
            sv.ImpostorScoresUser22User52 = EuclidDist.CalculateImpostorScores(s022Mean, s052);
            sv.ImpostorScoresUser22User53 = EuclidDist.CalculateImpostorScores(s022Mean, s053);
            sv.ImpostorScoresUser22User54 = EuclidDist.CalculateImpostorScores(s022Mean, s054);
            sv.ImpostorScoresUser22User55 = EuclidDist.CalculateImpostorScores(s022Mean, s055);
            sv.ImpostorScoresUser22User56 = EuclidDist.CalculateImpostorScores(s022Mean, s056);
            sv.ImpostorScoresUser22User57 = EuclidDist.CalculateImpostorScores(s022Mean, s057);
            sv.ImpostorScoresUser22User58 = EuclidDist.CalculateImpostorScores(s022Mean, s058);
            sv.ImpostorScoresUser22User59 = EuclidDist.CalculateImpostorScores(s022Mean, s059);
            sv.ImpostorScoresUser22User60 = EuclidDist.CalculateImpostorScores(s022Mean, s060);

            sv.ImpostorScoresUser22User61 = EuclidDist.CalculateImpostorScores(s022Mean, s061);
            sv.ImpostorScoresUser22User62 = EuclidDist.CalculateImpostorScores(s022Mean, s062);
            sv.ImpostorScoresUser22User63 = EuclidDist.CalculateImpostorScores(s022Mean, s063);
            sv.ImpostorScoresUser22User64 = EuclidDist.CalculateImpostorScores(s022Mean, s064);
            sv.ImpostorScoresUser22User65 = EuclidDist.CalculateImpostorScores(s022Mean, s065);
            sv.ImpostorScoresUser22User66 = EuclidDist.CalculateImpostorScores(s022Mean, s066);
            sv.ImpostorScoresUser22User67 = EuclidDist.CalculateImpostorScores(s022Mean, s067);
            sv.ImpostorScoresUser22User68 = EuclidDist.CalculateImpostorScores(s022Mean, s068);
            sv.ImpostorScoresUser22User69 = EuclidDist.CalculateImpostorScores(s022Mean, s069);
            sv.ImpostorScoresUser22User70 = EuclidDist.CalculateImpostorScores(s022Mean, s070);

            sv.ImpostorScoresUser22User71 = EuclidDist.CalculateImpostorScores(s022Mean, s071);
            sv.ImpostorScoresUser22User72 = EuclidDist.CalculateImpostorScores(s022Mean, s072);
            sv.ImpostorScoresUser22User73 = EuclidDist.CalculateImpostorScores(s022Mean, s073);
            sv.ImpostorScoresUser22User74 = EuclidDist.CalculateImpostorScores(s022Mean, s074);
            sv.ImpostorScoresUser22User75 = EuclidDist.CalculateImpostorScores(s022Mean, s075);
            sv.ImpostorScoresUser22User76 = EuclidDist.CalculateImpostorScores(s022Mean, s076);
            sv.ImpostorScoresUser22User77 = EuclidDist.CalculateImpostorScores(s022Mean, s077);
            sv.ImpostorScoresUser22User78 = EuclidDist.CalculateImpostorScores(s022Mean, s078);
            sv.ImpostorScoresUser22User79 = EuclidDist.CalculateImpostorScores(s022Mean, s079);
            sv.ImpostorScoresUser22User80 = EuclidDist.CalculateImpostorScores(s022Mean, s080);

            sv.ImpostorScoresUser22User81 = EuclidDist.CalculateImpostorScores(s022Mean, s081);
            sv.ImpostorScoresUser22User82 = EuclidDist.CalculateImpostorScores(s022Mean, s082);
            sv.ImpostorScoresUser22User83 = EuclidDist.CalculateImpostorScores(s022Mean, s083);
            sv.ImpostorScoresUser22User84 = EuclidDist.CalculateImpostorScores(s022Mean, s084);
            sv.ImpostorScoresUser22User85 = EuclidDist.CalculateImpostorScores(s022Mean, s085);
            sv.ImpostorScoresUser22User86 = EuclidDist.CalculateImpostorScores(s022Mean, s086);
            sv.ImpostorScoresUser22User87 = EuclidDist.CalculateImpostorScores(s022Mean, s087);
            sv.ImpostorScoresUser22User88 = EuclidDist.CalculateImpostorScores(s022Mean, s088);
            sv.ImpostorScoresUser22User89 = EuclidDist.CalculateImpostorScores(s022Mean, s089);
            sv.ImpostorScoresUser22User90 = EuclidDist.CalculateImpostorScores(s022Mean, s090);

            sv.ImpostorScoresUser22User91 = EuclidDist.CalculateImpostorScores(s022Mean, s091);
            sv.ImpostorScoresUser22User92 = EuclidDist.CalculateImpostorScores(s022Mean, s092);
            sv.ImpostorScoresUser22User93 = EuclidDist.CalculateImpostorScores(s022Mean, s093);
            sv.ImpostorScoresUser22User94 = EuclidDist.CalculateImpostorScores(s022Mean, s094);
            sv.ImpostorScoresUser22User95 = EuclidDist.CalculateImpostorScores(s022Mean, s095);
            sv.ImpostorScoresUser22User96 = EuclidDist.CalculateImpostorScores(s022Mean, s096);
            sv.ImpostorScoresUser22User97 = EuclidDist.CalculateImpostorScores(s022Mean, s097);
            sv.ImpostorScoresUser22User98 = EuclidDist.CalculateImpostorScores(s022Mean, s098);
            sv.ImpostorScoresUser22User99 = EuclidDist.CalculateImpostorScores(s022Mean, s099);
            sv.ImpostorScoresUser22User100 = EuclidDist.CalculateImpostorScores(s022Mean, s100);
            #endregion

            #region User 23 Impostor scores
            sv.ImpostorScoresUser23User1 = EuclidDist.CalculateImpostorScores(s023Mean, s001);
            sv.ImpostorScoresUser23User2 = EuclidDist.CalculateImpostorScores(s023Mean, s002);
            sv.ImpostorScoresUser23User3 = EuclidDist.CalculateImpostorScores(s023Mean, s003);
            sv.ImpostorScoresUser23User4 = EuclidDist.CalculateImpostorScores(s023Mean, s004);
            sv.ImpostorScoresUser23User5 = EuclidDist.CalculateImpostorScores(s023Mean, s005);
            sv.ImpostorScoresUser23User6 = EuclidDist.CalculateImpostorScores(s023Mean, s006);
            sv.ImpostorScoresUser23User7 = EuclidDist.CalculateImpostorScores(s023Mean, s007);
            sv.ImpostorScoresUser23User8 = EuclidDist.CalculateImpostorScores(s023Mean, s008);
            sv.ImpostorScoresUser23User9 = EuclidDist.CalculateImpostorScores(s023Mean, s009);
            sv.ImpostorScoresUser23User10 = EuclidDist.CalculateImpostorScores(s023Mean, s010);

            sv.ImpostorScoresUser23User11 = EuclidDist.CalculateImpostorScores(s023Mean, s011);
            sv.ImpostorScoresUser23User12 = EuclidDist.CalculateImpostorScores(s023Mean, s012);
            sv.ImpostorScoresUser23User13 = EuclidDist.CalculateImpostorScores(s023Mean, s013);
            sv.ImpostorScoresUser23User14 = EuclidDist.CalculateImpostorScores(s023Mean, s014);
            sv.ImpostorScoresUser23User15 = EuclidDist.CalculateImpostorScores(s023Mean, s015);
            sv.ImpostorScoresUser23User16 = EuclidDist.CalculateImpostorScores(s023Mean, s016);
            sv.ImpostorScoresUser23User17 = EuclidDist.CalculateImpostorScores(s023Mean, s017);
            sv.ImpostorScoresUser23User18 = EuclidDist.CalculateImpostorScores(s023Mean, s018);
            sv.ImpostorScoresUser23User19 = EuclidDist.CalculateImpostorScores(s023Mean, s019);
            sv.ImpostorScoresUser23User20 = EuclidDist.CalculateImpostorScores(s023Mean, s020);

            sv.ImpostorScoresUser23User21 = EuclidDist.CalculateImpostorScores(s023Mean, s021);
            sv.ImpostorScoresUser23User22 = EuclidDist.CalculateImpostorScores(s023Mean, s022);
            sv.ImpostorScoresUser23User24 = EuclidDist.CalculateImpostorScores(s023Mean, s024);
            sv.ImpostorScoresUser23User25 = EuclidDist.CalculateImpostorScores(s023Mean, s025);
            sv.ImpostorScoresUser23User26 = EuclidDist.CalculateImpostorScores(s023Mean, s026);
            sv.ImpostorScoresUser23User27 = EuclidDist.CalculateImpostorScores(s023Mean, s027);
            sv.ImpostorScoresUser23User28 = EuclidDist.CalculateImpostorScores(s023Mean, s028);
            sv.ImpostorScoresUser23User29 = EuclidDist.CalculateImpostorScores(s023Mean, s029);
            sv.ImpostorScoresUser23User30 = EuclidDist.CalculateImpostorScores(s023Mean, s030);

            sv.ImpostorScoresUser23User31 = EuclidDist.CalculateImpostorScores(s023Mean, s031);
            sv.ImpostorScoresUser23User32 = EuclidDist.CalculateImpostorScores(s023Mean, s032);
            sv.ImpostorScoresUser23User33 = EuclidDist.CalculateImpostorScores(s023Mean, s033);
            sv.ImpostorScoresUser23User34 = EuclidDist.CalculateImpostorScores(s023Mean, s034);
            sv.ImpostorScoresUser23User35 = EuclidDist.CalculateImpostorScores(s023Mean, s035);
            sv.ImpostorScoresUser23User36 = EuclidDist.CalculateImpostorScores(s023Mean, s036);
            sv.ImpostorScoresUser23User37 = EuclidDist.CalculateImpostorScores(s023Mean, s037);
            sv.ImpostorScoresUser23User38 = EuclidDist.CalculateImpostorScores(s023Mean, s038);
            sv.ImpostorScoresUser23User39 = EuclidDist.CalculateImpostorScores(s023Mean, s039);
            sv.ImpostorScoresUser23User40 = EuclidDist.CalculateImpostorScores(s023Mean, s040);

            sv.ImpostorScoresUser23User41 = EuclidDist.CalculateImpostorScores(s023Mean, s041);
            sv.ImpostorScoresUser23User42 = EuclidDist.CalculateImpostorScores(s023Mean, s042);
            sv.ImpostorScoresUser23User43 = EuclidDist.CalculateImpostorScores(s023Mean, s043);
            sv.ImpostorScoresUser23User44 = EuclidDist.CalculateImpostorScores(s023Mean, s044);
            sv.ImpostorScoresUser23User45 = EuclidDist.CalculateImpostorScores(s023Mean, s045);
            sv.ImpostorScoresUser23User46 = EuclidDist.CalculateImpostorScores(s023Mean, s046);
            sv.ImpostorScoresUser23User47 = EuclidDist.CalculateImpostorScores(s023Mean, s047);
            sv.ImpostorScoresUser23User48 = EuclidDist.CalculateImpostorScores(s023Mean, s048);
            sv.ImpostorScoresUser23User49 = EuclidDist.CalculateImpostorScores(s023Mean, s049);
            sv.ImpostorScoresUser23User50 = EuclidDist.CalculateImpostorScores(s023Mean, s050);

            sv.ImpostorScoresUser23User51 = EuclidDist.CalculateImpostorScores(s023Mean, s051);
            sv.ImpostorScoresUser23User52 = EuclidDist.CalculateImpostorScores(s023Mean, s052);
            sv.ImpostorScoresUser23User53 = EuclidDist.CalculateImpostorScores(s023Mean, s053);
            sv.ImpostorScoresUser23User54 = EuclidDist.CalculateImpostorScores(s023Mean, s054);
            sv.ImpostorScoresUser23User55 = EuclidDist.CalculateImpostorScores(s023Mean, s055);
            sv.ImpostorScoresUser23User56 = EuclidDist.CalculateImpostorScores(s023Mean, s056);
            sv.ImpostorScoresUser23User57 = EuclidDist.CalculateImpostorScores(s023Mean, s057);
            sv.ImpostorScoresUser23User58 = EuclidDist.CalculateImpostorScores(s023Mean, s058);
            sv.ImpostorScoresUser23User59 = EuclidDist.CalculateImpostorScores(s023Mean, s059);
            sv.ImpostorScoresUser23User60 = EuclidDist.CalculateImpostorScores(s023Mean, s060);

            sv.ImpostorScoresUser23User61 = EuclidDist.CalculateImpostorScores(s023Mean, s061);
            sv.ImpostorScoresUser23User62 = EuclidDist.CalculateImpostorScores(s023Mean, s062);
            sv.ImpostorScoresUser23User63 = EuclidDist.CalculateImpostorScores(s023Mean, s063);
            sv.ImpostorScoresUser23User64 = EuclidDist.CalculateImpostorScores(s023Mean, s064);
            sv.ImpostorScoresUser23User65 = EuclidDist.CalculateImpostorScores(s023Mean, s065);
            sv.ImpostorScoresUser23User66 = EuclidDist.CalculateImpostorScores(s023Mean, s066);
            sv.ImpostorScoresUser23User67 = EuclidDist.CalculateImpostorScores(s023Mean, s067);
            sv.ImpostorScoresUser23User68 = EuclidDist.CalculateImpostorScores(s023Mean, s068);
            sv.ImpostorScoresUser23User69 = EuclidDist.CalculateImpostorScores(s023Mean, s069);
            sv.ImpostorScoresUser23User70 = EuclidDist.CalculateImpostorScores(s023Mean, s070);

            sv.ImpostorScoresUser23User71 = EuclidDist.CalculateImpostorScores(s023Mean, s071);
            sv.ImpostorScoresUser23User72 = EuclidDist.CalculateImpostorScores(s023Mean, s072);
            sv.ImpostorScoresUser23User73 = EuclidDist.CalculateImpostorScores(s023Mean, s073);
            sv.ImpostorScoresUser23User74 = EuclidDist.CalculateImpostorScores(s023Mean, s074);
            sv.ImpostorScoresUser23User75 = EuclidDist.CalculateImpostorScores(s023Mean, s075);
            sv.ImpostorScoresUser23User76 = EuclidDist.CalculateImpostorScores(s023Mean, s076);
            sv.ImpostorScoresUser23User77 = EuclidDist.CalculateImpostorScores(s023Mean, s077);
            sv.ImpostorScoresUser23User78 = EuclidDist.CalculateImpostorScores(s023Mean, s078);
            sv.ImpostorScoresUser23User79 = EuclidDist.CalculateImpostorScores(s023Mean, s079);
            sv.ImpostorScoresUser23User80 = EuclidDist.CalculateImpostorScores(s023Mean, s080);

            sv.ImpostorScoresUser23User81 = EuclidDist.CalculateImpostorScores(s023Mean, s081);
            sv.ImpostorScoresUser23User82 = EuclidDist.CalculateImpostorScores(s023Mean, s082);
            sv.ImpostorScoresUser23User83 = EuclidDist.CalculateImpostorScores(s023Mean, s083);
            sv.ImpostorScoresUser23User84 = EuclidDist.CalculateImpostorScores(s023Mean, s084);
            sv.ImpostorScoresUser23User85 = EuclidDist.CalculateImpostorScores(s023Mean, s085);
            sv.ImpostorScoresUser23User86 = EuclidDist.CalculateImpostorScores(s023Mean, s086);
            sv.ImpostorScoresUser23User87 = EuclidDist.CalculateImpostorScores(s023Mean, s087);
            sv.ImpostorScoresUser23User88 = EuclidDist.CalculateImpostorScores(s023Mean, s088);
            sv.ImpostorScoresUser23User89 = EuclidDist.CalculateImpostorScores(s023Mean, s089);
            sv.ImpostorScoresUser23User90 = EuclidDist.CalculateImpostorScores(s023Mean, s090);

            sv.ImpostorScoresUser23User91 = EuclidDist.CalculateImpostorScores(s023Mean, s091);
            sv.ImpostorScoresUser23User92 = EuclidDist.CalculateImpostorScores(s023Mean, s092);
            sv.ImpostorScoresUser23User93 = EuclidDist.CalculateImpostorScores(s023Mean, s093);
            sv.ImpostorScoresUser23User94 = EuclidDist.CalculateImpostorScores(s023Mean, s094);
            sv.ImpostorScoresUser23User95 = EuclidDist.CalculateImpostorScores(s023Mean, s095);
            sv.ImpostorScoresUser23User96 = EuclidDist.CalculateImpostorScores(s023Mean, s096);
            sv.ImpostorScoresUser23User97 = EuclidDist.CalculateImpostorScores(s023Mean, s097);
            sv.ImpostorScoresUser23User98 = EuclidDist.CalculateImpostorScores(s023Mean, s098);
            sv.ImpostorScoresUser23User99 = EuclidDist.CalculateImpostorScores(s023Mean, s099);
            sv.ImpostorScoresUser23User100 = EuclidDist.CalculateImpostorScores(s023Mean, s100);
            #endregion

            #region User 24 Impostor scores
            sv.ImpostorScoresUser24User1 = EuclidDist.CalculateImpostorScores(s024Mean, s001);
            sv.ImpostorScoresUser24User2 = EuclidDist.CalculateImpostorScores(s024Mean, s002);
            sv.ImpostorScoresUser24User3 = EuclidDist.CalculateImpostorScores(s024Mean, s003);
            sv.ImpostorScoresUser24User4 = EuclidDist.CalculateImpostorScores(s024Mean, s004);
            sv.ImpostorScoresUser24User5 = EuclidDist.CalculateImpostorScores(s024Mean, s005);
            sv.ImpostorScoresUser24User6 = EuclidDist.CalculateImpostorScores(s024Mean, s006);
            sv.ImpostorScoresUser24User7 = EuclidDist.CalculateImpostorScores(s024Mean, s007);
            sv.ImpostorScoresUser24User8 = EuclidDist.CalculateImpostorScores(s024Mean, s008);
            sv.ImpostorScoresUser24User9 = EuclidDist.CalculateImpostorScores(s024Mean, s009);
            sv.ImpostorScoresUser24User10 = EuclidDist.CalculateImpostorScores(s024Mean, s010);

            sv.ImpostorScoresUser24User11 = EuclidDist.CalculateImpostorScores(s024Mean, s011);
            sv.ImpostorScoresUser24User12 = EuclidDist.CalculateImpostorScores(s024Mean, s012);
            sv.ImpostorScoresUser24User13 = EuclidDist.CalculateImpostorScores(s024Mean, s013);
            sv.ImpostorScoresUser24User14 = EuclidDist.CalculateImpostorScores(s024Mean, s014);
            sv.ImpostorScoresUser24User15 = EuclidDist.CalculateImpostorScores(s024Mean, s015);
            sv.ImpostorScoresUser24User16 = EuclidDist.CalculateImpostorScores(s024Mean, s016);
            sv.ImpostorScoresUser24User17 = EuclidDist.CalculateImpostorScores(s024Mean, s017);
            sv.ImpostorScoresUser24User18 = EuclidDist.CalculateImpostorScores(s024Mean, s018);
            sv.ImpostorScoresUser24User19 = EuclidDist.CalculateImpostorScores(s024Mean, s019);
            sv.ImpostorScoresUser24User20 = EuclidDist.CalculateImpostorScores(s024Mean, s020);

            sv.ImpostorScoresUser24User21 = EuclidDist.CalculateImpostorScores(s024Mean, s021);
            sv.ImpostorScoresUser24User22 = EuclidDist.CalculateImpostorScores(s024Mean, s022);
            sv.ImpostorScoresUser24User23 = EuclidDist.CalculateImpostorScores(s024Mean, s023);
            sv.ImpostorScoresUser24User25 = EuclidDist.CalculateImpostorScores(s024Mean, s025);
            sv.ImpostorScoresUser24User26 = EuclidDist.CalculateImpostorScores(s024Mean, s026);
            sv.ImpostorScoresUser24User27 = EuclidDist.CalculateImpostorScores(s024Mean, s027);
            sv.ImpostorScoresUser24User28 = EuclidDist.CalculateImpostorScores(s024Mean, s028);
            sv.ImpostorScoresUser24User29 = EuclidDist.CalculateImpostorScores(s024Mean, s029);
            sv.ImpostorScoresUser24User30 = EuclidDist.CalculateImpostorScores(s024Mean, s030);

            sv.ImpostorScoresUser24User31 = EuclidDist.CalculateImpostorScores(s024Mean, s031);
            sv.ImpostorScoresUser24User32 = EuclidDist.CalculateImpostorScores(s024Mean, s032);
            sv.ImpostorScoresUser24User33 = EuclidDist.CalculateImpostorScores(s024Mean, s033);
            sv.ImpostorScoresUser24User34 = EuclidDist.CalculateImpostorScores(s024Mean, s034);
            sv.ImpostorScoresUser24User35 = EuclidDist.CalculateImpostorScores(s024Mean, s035);
            sv.ImpostorScoresUser24User36 = EuclidDist.CalculateImpostorScores(s024Mean, s036);
            sv.ImpostorScoresUser24User37 = EuclidDist.CalculateImpostorScores(s024Mean, s037);
            sv.ImpostorScoresUser24User38 = EuclidDist.CalculateImpostorScores(s024Mean, s038);
            sv.ImpostorScoresUser24User39 = EuclidDist.CalculateImpostorScores(s024Mean, s039);
            sv.ImpostorScoresUser24User40 = EuclidDist.CalculateImpostorScores(s024Mean, s040);

            sv.ImpostorScoresUser24User41 = EuclidDist.CalculateImpostorScores(s024Mean, s041);
            sv.ImpostorScoresUser24User42 = EuclidDist.CalculateImpostorScores(s024Mean, s042);
            sv.ImpostorScoresUser24User43 = EuclidDist.CalculateImpostorScores(s024Mean, s043);
            sv.ImpostorScoresUser24User44 = EuclidDist.CalculateImpostorScores(s024Mean, s044);
            sv.ImpostorScoresUser24User45 = EuclidDist.CalculateImpostorScores(s024Mean, s045);
            sv.ImpostorScoresUser24User46 = EuclidDist.CalculateImpostorScores(s024Mean, s046);
            sv.ImpostorScoresUser24User47 = EuclidDist.CalculateImpostorScores(s024Mean, s047);
            sv.ImpostorScoresUser24User48 = EuclidDist.CalculateImpostorScores(s024Mean, s048);
            sv.ImpostorScoresUser24User49 = EuclidDist.CalculateImpostorScores(s024Mean, s049);
            sv.ImpostorScoresUser24User50 = EuclidDist.CalculateImpostorScores(s024Mean, s050);

            sv.ImpostorScoresUser24User51 = EuclidDist.CalculateImpostorScores(s024Mean, s051);
            sv.ImpostorScoresUser24User52 = EuclidDist.CalculateImpostorScores(s024Mean, s052);
            sv.ImpostorScoresUser24User53 = EuclidDist.CalculateImpostorScores(s024Mean, s053);
            sv.ImpostorScoresUser24User54 = EuclidDist.CalculateImpostorScores(s024Mean, s054);
            sv.ImpostorScoresUser24User55 = EuclidDist.CalculateImpostorScores(s024Mean, s055);
            sv.ImpostorScoresUser24User56 = EuclidDist.CalculateImpostorScores(s024Mean, s056);
            sv.ImpostorScoresUser24User57 = EuclidDist.CalculateImpostorScores(s024Mean, s057);
            sv.ImpostorScoresUser24User58 = EuclidDist.CalculateImpostorScores(s024Mean, s058);
            sv.ImpostorScoresUser24User59 = EuclidDist.CalculateImpostorScores(s024Mean, s059);
            sv.ImpostorScoresUser24User60 = EuclidDist.CalculateImpostorScores(s024Mean, s060);

            sv.ImpostorScoresUser24User61 = EuclidDist.CalculateImpostorScores(s024Mean, s061);
            sv.ImpostorScoresUser24User62 = EuclidDist.CalculateImpostorScores(s024Mean, s062);
            sv.ImpostorScoresUser24User63 = EuclidDist.CalculateImpostorScores(s024Mean, s063);
            sv.ImpostorScoresUser24User64 = EuclidDist.CalculateImpostorScores(s024Mean, s064);
            sv.ImpostorScoresUser24User65 = EuclidDist.CalculateImpostorScores(s024Mean, s065);
            sv.ImpostorScoresUser24User66 = EuclidDist.CalculateImpostorScores(s024Mean, s066);
            sv.ImpostorScoresUser24User67 = EuclidDist.CalculateImpostorScores(s024Mean, s067);
            sv.ImpostorScoresUser24User68 = EuclidDist.CalculateImpostorScores(s024Mean, s068);
            sv.ImpostorScoresUser24User69 = EuclidDist.CalculateImpostorScores(s024Mean, s069);
            sv.ImpostorScoresUser24User70 = EuclidDist.CalculateImpostorScores(s024Mean, s070);

            sv.ImpostorScoresUser24User71 = EuclidDist.CalculateImpostorScores(s024Mean, s071);
            sv.ImpostorScoresUser24User72 = EuclidDist.CalculateImpostorScores(s024Mean, s072);
            sv.ImpostorScoresUser24User73 = EuclidDist.CalculateImpostorScores(s024Mean, s073);
            sv.ImpostorScoresUser24User74 = EuclidDist.CalculateImpostorScores(s024Mean, s074);
            sv.ImpostorScoresUser24User75 = EuclidDist.CalculateImpostorScores(s024Mean, s075);
            sv.ImpostorScoresUser24User76 = EuclidDist.CalculateImpostorScores(s024Mean, s076);
            sv.ImpostorScoresUser24User77 = EuclidDist.CalculateImpostorScores(s024Mean, s077);
            sv.ImpostorScoresUser24User78 = EuclidDist.CalculateImpostorScores(s024Mean, s078);
            sv.ImpostorScoresUser24User79 = EuclidDist.CalculateImpostorScores(s024Mean, s079);
            sv.ImpostorScoresUser24User80 = EuclidDist.CalculateImpostorScores(s024Mean, s080);

            sv.ImpostorScoresUser24User81 = EuclidDist.CalculateImpostorScores(s024Mean, s081);
            sv.ImpostorScoresUser24User82 = EuclidDist.CalculateImpostorScores(s024Mean, s082);
            sv.ImpostorScoresUser24User83 = EuclidDist.CalculateImpostorScores(s024Mean, s083);
            sv.ImpostorScoresUser24User84 = EuclidDist.CalculateImpostorScores(s024Mean, s084);
            sv.ImpostorScoresUser24User85 = EuclidDist.CalculateImpostorScores(s024Mean, s085);
            sv.ImpostorScoresUser24User86 = EuclidDist.CalculateImpostorScores(s024Mean, s086);
            sv.ImpostorScoresUser24User87 = EuclidDist.CalculateImpostorScores(s024Mean, s087);
            sv.ImpostorScoresUser24User88 = EuclidDist.CalculateImpostorScores(s024Mean, s088);
            sv.ImpostorScoresUser24User89 = EuclidDist.CalculateImpostorScores(s024Mean, s089);
            sv.ImpostorScoresUser24User90 = EuclidDist.CalculateImpostorScores(s024Mean, s090);

            sv.ImpostorScoresUser24User91 = EuclidDist.CalculateImpostorScores(s024Mean, s091);
            sv.ImpostorScoresUser24User92 = EuclidDist.CalculateImpostorScores(s024Mean, s092);
            sv.ImpostorScoresUser24User93 = EuclidDist.CalculateImpostorScores(s024Mean, s093);
            sv.ImpostorScoresUser24User94 = EuclidDist.CalculateImpostorScores(s024Mean, s094);
            sv.ImpostorScoresUser24User95 = EuclidDist.CalculateImpostorScores(s024Mean, s095);
            sv.ImpostorScoresUser24User96 = EuclidDist.CalculateImpostorScores(s024Mean, s096);
            sv.ImpostorScoresUser24User97 = EuclidDist.CalculateImpostorScores(s024Mean, s097);
            sv.ImpostorScoresUser24User98 = EuclidDist.CalculateImpostorScores(s024Mean, s098);
            sv.ImpostorScoresUser24User99 = EuclidDist.CalculateImpostorScores(s024Mean, s099);
            sv.ImpostorScoresUser24User100 = EuclidDist.CalculateImpostorScores(s024Mean, s100);
            #endregion

            #region User 25 Impostor scores
            sv.ImpostorScoresUser25User1 = EuclidDist.CalculateImpostorScores(s025Mean, s001);
            sv.ImpostorScoresUser25User2 = EuclidDist.CalculateImpostorScores(s025Mean, s002);
            sv.ImpostorScoresUser25User3 = EuclidDist.CalculateImpostorScores(s025Mean, s003);
            sv.ImpostorScoresUser25User4 = EuclidDist.CalculateImpostorScores(s025Mean, s004);
            sv.ImpostorScoresUser25User5 = EuclidDist.CalculateImpostorScores(s025Mean, s005);
            sv.ImpostorScoresUser25User6 = EuclidDist.CalculateImpostorScores(s025Mean, s006);
            sv.ImpostorScoresUser25User7 = EuclidDist.CalculateImpostorScores(s025Mean, s007);
            sv.ImpostorScoresUser25User8 = EuclidDist.CalculateImpostorScores(s025Mean, s008);
            sv.ImpostorScoresUser25User9 = EuclidDist.CalculateImpostorScores(s025Mean, s009);
            sv.ImpostorScoresUser25User10 = EuclidDist.CalculateImpostorScores(s025Mean, s010);

            sv.ImpostorScoresUser25User11 = EuclidDist.CalculateImpostorScores(s025Mean, s011);
            sv.ImpostorScoresUser25User12 = EuclidDist.CalculateImpostorScores(s025Mean, s012);
            sv.ImpostorScoresUser25User13 = EuclidDist.CalculateImpostorScores(s025Mean, s013);
            sv.ImpostorScoresUser25User14 = EuclidDist.CalculateImpostorScores(s025Mean, s014);
            sv.ImpostorScoresUser25User15 = EuclidDist.CalculateImpostorScores(s025Mean, s015);
            sv.ImpostorScoresUser25User16 = EuclidDist.CalculateImpostorScores(s025Mean, s016);
            sv.ImpostorScoresUser25User17 = EuclidDist.CalculateImpostorScores(s025Mean, s017);
            sv.ImpostorScoresUser25User18 = EuclidDist.CalculateImpostorScores(s025Mean, s018);
            sv.ImpostorScoresUser25User19 = EuclidDist.CalculateImpostorScores(s025Mean, s019);
            sv.ImpostorScoresUser25User20 = EuclidDist.CalculateImpostorScores(s025Mean, s020);

            sv.ImpostorScoresUser25User21 = EuclidDist.CalculateImpostorScores(s025Mean, s021);
            sv.ImpostorScoresUser25User22 = EuclidDist.CalculateImpostorScores(s025Mean, s022);
            sv.ImpostorScoresUser25User23 = EuclidDist.CalculateImpostorScores(s025Mean, s023);
            sv.ImpostorScoresUser25User24 = EuclidDist.CalculateImpostorScores(s025Mean, s024);
            sv.ImpostorScoresUser25User26 = EuclidDist.CalculateImpostorScores(s025Mean, s026);
            sv.ImpostorScoresUser25User27 = EuclidDist.CalculateImpostorScores(s025Mean, s027);
            sv.ImpostorScoresUser25User28 = EuclidDist.CalculateImpostorScores(s025Mean, s028);
            sv.ImpostorScoresUser25User29 = EuclidDist.CalculateImpostorScores(s025Mean, s029);
            sv.ImpostorScoresUser25User30 = EuclidDist.CalculateImpostorScores(s025Mean, s030);

            sv.ImpostorScoresUser25User31 = EuclidDist.CalculateImpostorScores(s025Mean, s031);
            sv.ImpostorScoresUser25User32 = EuclidDist.CalculateImpostorScores(s025Mean, s032);
            sv.ImpostorScoresUser25User33 = EuclidDist.CalculateImpostorScores(s025Mean, s033);
            sv.ImpostorScoresUser25User34 = EuclidDist.CalculateImpostorScores(s025Mean, s034);
            sv.ImpostorScoresUser25User35 = EuclidDist.CalculateImpostorScores(s025Mean, s035);
            sv.ImpostorScoresUser25User36 = EuclidDist.CalculateImpostorScores(s025Mean, s036);
            sv.ImpostorScoresUser25User37 = EuclidDist.CalculateImpostorScores(s025Mean, s037);
            sv.ImpostorScoresUser25User38 = EuclidDist.CalculateImpostorScores(s025Mean, s038);
            sv.ImpostorScoresUser25User39 = EuclidDist.CalculateImpostorScores(s025Mean, s039);
            sv.ImpostorScoresUser25User40 = EuclidDist.CalculateImpostorScores(s025Mean, s040);

            sv.ImpostorScoresUser25User41 = EuclidDist.CalculateImpostorScores(s025Mean, s041);
            sv.ImpostorScoresUser25User42 = EuclidDist.CalculateImpostorScores(s025Mean, s042);
            sv.ImpostorScoresUser25User43 = EuclidDist.CalculateImpostorScores(s025Mean, s043);
            sv.ImpostorScoresUser25User44 = EuclidDist.CalculateImpostorScores(s025Mean, s044);
            sv.ImpostorScoresUser25User45 = EuclidDist.CalculateImpostorScores(s025Mean, s045);
            sv.ImpostorScoresUser25User46 = EuclidDist.CalculateImpostorScores(s025Mean, s046);
            sv.ImpostorScoresUser25User47 = EuclidDist.CalculateImpostorScores(s025Mean, s047);
            sv.ImpostorScoresUser25User48 = EuclidDist.CalculateImpostorScores(s025Mean, s048);
            sv.ImpostorScoresUser25User49 = EuclidDist.CalculateImpostorScores(s025Mean, s049);
            sv.ImpostorScoresUser25User50 = EuclidDist.CalculateImpostorScores(s025Mean, s050);

            sv.ImpostorScoresUser25User51 = EuclidDist.CalculateImpostorScores(s025Mean, s051);
            sv.ImpostorScoresUser25User52 = EuclidDist.CalculateImpostorScores(s025Mean, s052);
            sv.ImpostorScoresUser25User53 = EuclidDist.CalculateImpostorScores(s025Mean, s053);
            sv.ImpostorScoresUser25User54 = EuclidDist.CalculateImpostorScores(s025Mean, s054);
            sv.ImpostorScoresUser25User55 = EuclidDist.CalculateImpostorScores(s025Mean, s055);
            sv.ImpostorScoresUser25User56 = EuclidDist.CalculateImpostorScores(s025Mean, s056);
            sv.ImpostorScoresUser25User57 = EuclidDist.CalculateImpostorScores(s025Mean, s057);
            sv.ImpostorScoresUser25User58 = EuclidDist.CalculateImpostorScores(s025Mean, s058);
            sv.ImpostorScoresUser25User59 = EuclidDist.CalculateImpostorScores(s025Mean, s059);
            sv.ImpostorScoresUser25User60 = EuclidDist.CalculateImpostorScores(s025Mean, s060);

            sv.ImpostorScoresUser25User61 = EuclidDist.CalculateImpostorScores(s025Mean, s061);
            sv.ImpostorScoresUser25User62 = EuclidDist.CalculateImpostorScores(s025Mean, s062);
            sv.ImpostorScoresUser25User63 = EuclidDist.CalculateImpostorScores(s025Mean, s063);
            sv.ImpostorScoresUser25User64 = EuclidDist.CalculateImpostorScores(s025Mean, s064);
            sv.ImpostorScoresUser25User65 = EuclidDist.CalculateImpostorScores(s025Mean, s065);
            sv.ImpostorScoresUser25User66 = EuclidDist.CalculateImpostorScores(s025Mean, s066);
            sv.ImpostorScoresUser25User67 = EuclidDist.CalculateImpostorScores(s025Mean, s067);
            sv.ImpostorScoresUser25User68 = EuclidDist.CalculateImpostorScores(s025Mean, s068);
            sv.ImpostorScoresUser25User69 = EuclidDist.CalculateImpostorScores(s025Mean, s069);
            sv.ImpostorScoresUser25User70 = EuclidDist.CalculateImpostorScores(s025Mean, s070);

            sv.ImpostorScoresUser25User71 = EuclidDist.CalculateImpostorScores(s025Mean, s071);
            sv.ImpostorScoresUser25User72 = EuclidDist.CalculateImpostorScores(s025Mean, s072);
            sv.ImpostorScoresUser25User73 = EuclidDist.CalculateImpostorScores(s025Mean, s073);
            sv.ImpostorScoresUser25User74 = EuclidDist.CalculateImpostorScores(s025Mean, s074);
            sv.ImpostorScoresUser25User75 = EuclidDist.CalculateImpostorScores(s025Mean, s075);
            sv.ImpostorScoresUser25User76 = EuclidDist.CalculateImpostorScores(s025Mean, s076);
            sv.ImpostorScoresUser25User77 = EuclidDist.CalculateImpostorScores(s025Mean, s077);
            sv.ImpostorScoresUser25User78 = EuclidDist.CalculateImpostorScores(s025Mean, s078);
            sv.ImpostorScoresUser25User79 = EuclidDist.CalculateImpostorScores(s025Mean, s079);
            sv.ImpostorScoresUser25User80 = EuclidDist.CalculateImpostorScores(s025Mean, s080);

            sv.ImpostorScoresUser25User81 = EuclidDist.CalculateImpostorScores(s025Mean, s081);
            sv.ImpostorScoresUser25User82 = EuclidDist.CalculateImpostorScores(s025Mean, s082);
            sv.ImpostorScoresUser25User83 = EuclidDist.CalculateImpostorScores(s025Mean, s083);
            sv.ImpostorScoresUser25User84 = EuclidDist.CalculateImpostorScores(s025Mean, s084);
            sv.ImpostorScoresUser25User85 = EuclidDist.CalculateImpostorScores(s025Mean, s085);
            sv.ImpostorScoresUser25User86 = EuclidDist.CalculateImpostorScores(s025Mean, s086);
            sv.ImpostorScoresUser25User87 = EuclidDist.CalculateImpostorScores(s025Mean, s087);
            sv.ImpostorScoresUser25User88 = EuclidDist.CalculateImpostorScores(s025Mean, s088);
            sv.ImpostorScoresUser25User89 = EuclidDist.CalculateImpostorScores(s025Mean, s089);
            sv.ImpostorScoresUser25User90 = EuclidDist.CalculateImpostorScores(s025Mean, s090);

            sv.ImpostorScoresUser25User91 = EuclidDist.CalculateImpostorScores(s025Mean, s091);
            sv.ImpostorScoresUser25User92 = EuclidDist.CalculateImpostorScores(s025Mean, s092);
            sv.ImpostorScoresUser25User93 = EuclidDist.CalculateImpostorScores(s025Mean, s093);
            sv.ImpostorScoresUser25User94 = EuclidDist.CalculateImpostorScores(s025Mean, s094);
            sv.ImpostorScoresUser25User95 = EuclidDist.CalculateImpostorScores(s025Mean, s095);
            sv.ImpostorScoresUser25User96 = EuclidDist.CalculateImpostorScores(s025Mean, s096);
            sv.ImpostorScoresUser25User97 = EuclidDist.CalculateImpostorScores(s025Mean, s097);
            sv.ImpostorScoresUser25User98 = EuclidDist.CalculateImpostorScores(s025Mean, s098);
            sv.ImpostorScoresUser25User99 = EuclidDist.CalculateImpostorScores(s025Mean, s099);
            sv.ImpostorScoresUser25User100 = EuclidDist.CalculateImpostorScores(s025Mean, s100);
            #endregion

            #region User 25 Impostor scores
            sv.ImpostorScoresUser26User1 = EuclidDist.CalculateImpostorScores(s026Mean, s001);
            sv.ImpostorScoresUser26User2 = EuclidDist.CalculateImpostorScores(s026Mean, s002);
            sv.ImpostorScoresUser26User3 = EuclidDist.CalculateImpostorScores(s026Mean, s003);
            sv.ImpostorScoresUser26User4 = EuclidDist.CalculateImpostorScores(s026Mean, s004);
            sv.ImpostorScoresUser26User5 = EuclidDist.CalculateImpostorScores(s026Mean, s005);
            sv.ImpostorScoresUser26User6 = EuclidDist.CalculateImpostorScores(s026Mean, s006);
            sv.ImpostorScoresUser26User7 = EuclidDist.CalculateImpostorScores(s026Mean, s007);
            sv.ImpostorScoresUser26User8 = EuclidDist.CalculateImpostorScores(s026Mean, s008);
            sv.ImpostorScoresUser26User9 = EuclidDist.CalculateImpostorScores(s026Mean, s009);
            sv.ImpostorScoresUser26User10 = EuclidDist.CalculateImpostorScores(s026Mean, s010);

            sv.ImpostorScoresUser26User11 = EuclidDist.CalculateImpostorScores(s026Mean, s011);
            sv.ImpostorScoresUser26User12 = EuclidDist.CalculateImpostorScores(s026Mean, s012);
            sv.ImpostorScoresUser26User13 = EuclidDist.CalculateImpostorScores(s026Mean, s013);
            sv.ImpostorScoresUser26User14 = EuclidDist.CalculateImpostorScores(s026Mean, s014);
            sv.ImpostorScoresUser26User15 = EuclidDist.CalculateImpostorScores(s026Mean, s015);
            sv.ImpostorScoresUser26User16 = EuclidDist.CalculateImpostorScores(s026Mean, s016);
            sv.ImpostorScoresUser26User17 = EuclidDist.CalculateImpostorScores(s026Mean, s017);
            sv.ImpostorScoresUser26User18 = EuclidDist.CalculateImpostorScores(s026Mean, s018);
            sv.ImpostorScoresUser26User19 = EuclidDist.CalculateImpostorScores(s026Mean, s019);
            sv.ImpostorScoresUser26User20 = EuclidDist.CalculateImpostorScores(s026Mean, s020);

            sv.ImpostorScoresUser26User21 = EuclidDist.CalculateImpostorScores(s026Mean, s021);
            sv.ImpostorScoresUser26User22 = EuclidDist.CalculateImpostorScores(s026Mean, s022);
            sv.ImpostorScoresUser26User23 = EuclidDist.CalculateImpostorScores(s026Mean, s023);
            sv.ImpostorScoresUser26User24 = EuclidDist.CalculateImpostorScores(s026Mean, s024);
            sv.ImpostorScoresUser26User25 = EuclidDist.CalculateImpostorScores(s026Mean, s025);
            sv.ImpostorScoresUser26User27 = EuclidDist.CalculateImpostorScores(s026Mean, s027);
            sv.ImpostorScoresUser26User28 = EuclidDist.CalculateImpostorScores(s026Mean, s028);
            sv.ImpostorScoresUser26User29 = EuclidDist.CalculateImpostorScores(s026Mean, s029);
            sv.ImpostorScoresUser26User30 = EuclidDist.CalculateImpostorScores(s026Mean, s030);

            sv.ImpostorScoresUser26User31 = EuclidDist.CalculateImpostorScores(s026Mean, s031);
            sv.ImpostorScoresUser26User32 = EuclidDist.CalculateImpostorScores(s026Mean, s032);
            sv.ImpostorScoresUser26User33 = EuclidDist.CalculateImpostorScores(s026Mean, s033);
            sv.ImpostorScoresUser26User34 = EuclidDist.CalculateImpostorScores(s026Mean, s034);
            sv.ImpostorScoresUser26User35 = EuclidDist.CalculateImpostorScores(s026Mean, s035);
            sv.ImpostorScoresUser26User36 = EuclidDist.CalculateImpostorScores(s026Mean, s036);
            sv.ImpostorScoresUser26User37 = EuclidDist.CalculateImpostorScores(s026Mean, s037);
            sv.ImpostorScoresUser26User38 = EuclidDist.CalculateImpostorScores(s026Mean, s038);
            sv.ImpostorScoresUser26User39 = EuclidDist.CalculateImpostorScores(s026Mean, s039);
            sv.ImpostorScoresUser26User40 = EuclidDist.CalculateImpostorScores(s026Mean, s040);

            sv.ImpostorScoresUser26User41 = EuclidDist.CalculateImpostorScores(s026Mean, s041);
            sv.ImpostorScoresUser26User42 = EuclidDist.CalculateImpostorScores(s026Mean, s042);
            sv.ImpostorScoresUser26User43 = EuclidDist.CalculateImpostorScores(s026Mean, s043);
            sv.ImpostorScoresUser26User44 = EuclidDist.CalculateImpostorScores(s026Mean, s044);
            sv.ImpostorScoresUser26User45 = EuclidDist.CalculateImpostorScores(s026Mean, s045);
            sv.ImpostorScoresUser26User46 = EuclidDist.CalculateImpostorScores(s026Mean, s046);
            sv.ImpostorScoresUser26User47 = EuclidDist.CalculateImpostorScores(s026Mean, s047);
            sv.ImpostorScoresUser26User48 = EuclidDist.CalculateImpostorScores(s026Mean, s048);
            sv.ImpostorScoresUser26User49 = EuclidDist.CalculateImpostorScores(s026Mean, s049);
            sv.ImpostorScoresUser26User50 = EuclidDist.CalculateImpostorScores(s026Mean, s050);

            sv.ImpostorScoresUser26User51 = EuclidDist.CalculateImpostorScores(s026Mean, s051);
            sv.ImpostorScoresUser26User52 = EuclidDist.CalculateImpostorScores(s026Mean, s052);
            sv.ImpostorScoresUser26User53 = EuclidDist.CalculateImpostorScores(s026Mean, s053);
            sv.ImpostorScoresUser26User54 = EuclidDist.CalculateImpostorScores(s026Mean, s054);
            sv.ImpostorScoresUser26User55 = EuclidDist.CalculateImpostorScores(s026Mean, s055);
            sv.ImpostorScoresUser26User56 = EuclidDist.CalculateImpostorScores(s026Mean, s056);
            sv.ImpostorScoresUser26User57 = EuclidDist.CalculateImpostorScores(s026Mean, s057);
            sv.ImpostorScoresUser26User58 = EuclidDist.CalculateImpostorScores(s026Mean, s058);
            sv.ImpostorScoresUser26User59 = EuclidDist.CalculateImpostorScores(s026Mean, s059);
            sv.ImpostorScoresUser26User60 = EuclidDist.CalculateImpostorScores(s026Mean, s060);

            sv.ImpostorScoresUser26User61 = EuclidDist.CalculateImpostorScores(s026Mean, s061);
            sv.ImpostorScoresUser26User62 = EuclidDist.CalculateImpostorScores(s026Mean, s062);
            sv.ImpostorScoresUser26User63 = EuclidDist.CalculateImpostorScores(s026Mean, s063);
            sv.ImpostorScoresUser26User64 = EuclidDist.CalculateImpostorScores(s026Mean, s064);
            sv.ImpostorScoresUser26User65 = EuclidDist.CalculateImpostorScores(s026Mean, s065);
            sv.ImpostorScoresUser26User66 = EuclidDist.CalculateImpostorScores(s026Mean, s066);
            sv.ImpostorScoresUser26User67 = EuclidDist.CalculateImpostorScores(s026Mean, s067);
            sv.ImpostorScoresUser26User68 = EuclidDist.CalculateImpostorScores(s026Mean, s068);
            sv.ImpostorScoresUser26User69 = EuclidDist.CalculateImpostorScores(s026Mean, s069);
            sv.ImpostorScoresUser26User70 = EuclidDist.CalculateImpostorScores(s026Mean, s070);

            sv.ImpostorScoresUser26User71 = EuclidDist.CalculateImpostorScores(s026Mean, s071);
            sv.ImpostorScoresUser26User72 = EuclidDist.CalculateImpostorScores(s026Mean, s072);
            sv.ImpostorScoresUser26User73 = EuclidDist.CalculateImpostorScores(s026Mean, s073);
            sv.ImpostorScoresUser26User74 = EuclidDist.CalculateImpostorScores(s026Mean, s074);
            sv.ImpostorScoresUser26User75 = EuclidDist.CalculateImpostorScores(s026Mean, s075);
            sv.ImpostorScoresUser26User76 = EuclidDist.CalculateImpostorScores(s026Mean, s076);
            sv.ImpostorScoresUser26User77 = EuclidDist.CalculateImpostorScores(s026Mean, s077);
            sv.ImpostorScoresUser26User78 = EuclidDist.CalculateImpostorScores(s026Mean, s078);
            sv.ImpostorScoresUser26User79 = EuclidDist.CalculateImpostorScores(s026Mean, s079);
            sv.ImpostorScoresUser26User80 = EuclidDist.CalculateImpostorScores(s026Mean, s080);

            sv.ImpostorScoresUser25User81 = EuclidDist.CalculateImpostorScores(s025Mean, s081);
            sv.ImpostorScoresUser25User82 = EuclidDist.CalculateImpostorScores(s025Mean, s082);
            sv.ImpostorScoresUser25User83 = EuclidDist.CalculateImpostorScores(s025Mean, s083);
            sv.ImpostorScoresUser25User84 = EuclidDist.CalculateImpostorScores(s025Mean, s084);
            sv.ImpostorScoresUser25User85 = EuclidDist.CalculateImpostorScores(s025Mean, s085);
            sv.ImpostorScoresUser25User86 = EuclidDist.CalculateImpostorScores(s025Mean, s086);
            sv.ImpostorScoresUser25User87 = EuclidDist.CalculateImpostorScores(s025Mean, s087);
            sv.ImpostorScoresUser25User88 = EuclidDist.CalculateImpostorScores(s025Mean, s088);
            sv.ImpostorScoresUser25User89 = EuclidDist.CalculateImpostorScores(s025Mean, s089);
            sv.ImpostorScoresUser25User90 = EuclidDist.CalculateImpostorScores(s025Mean, s090);

            sv.ImpostorScoresUser26User91 = EuclidDist.CalculateImpostorScores(s026Mean, s091);
            sv.ImpostorScoresUser26User92 = EuclidDist.CalculateImpostorScores(s026Mean, s092);
            sv.ImpostorScoresUser26User93 = EuclidDist.CalculateImpostorScores(s026Mean, s093);
            sv.ImpostorScoresUser26User94 = EuclidDist.CalculateImpostorScores(s026Mean, s094);
            sv.ImpostorScoresUser26User95 = EuclidDist.CalculateImpostorScores(s026Mean, s095);
            sv.ImpostorScoresUser26User96 = EuclidDist.CalculateImpostorScores(s026Mean, s096);
            sv.ImpostorScoresUser26User97 = EuclidDist.CalculateImpostorScores(s026Mean, s097);
            sv.ImpostorScoresUser26User98 = EuclidDist.CalculateImpostorScores(s026Mean, s098);
            sv.ImpostorScoresUser26User99 = EuclidDist.CalculateImpostorScores(s026Mean, s099);
            sv.ImpostorScoresUser26User100 = EuclidDist.CalculateImpostorScores(s026Mean, s100);
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

            #region User 13 Impostor scores
            sv.ImpostorScoresUser13User1 = ManhDist.CalculateImpostorScores(s013Mean, s001);
            sv.ImpostorScoresUser13User2 = ManhDist.CalculateImpostorScores(s013Mean, s002);
            sv.ImpostorScoresUser13User3 = ManhDist.CalculateImpostorScores(s013Mean, s003);
            sv.ImpostorScoresUser13User4 = ManhDist.CalculateImpostorScores(s013Mean, s004);
            sv.ImpostorScoresUser13User5 = ManhDist.CalculateImpostorScores(s013Mean, s005);
            sv.ImpostorScoresUser13User6 = ManhDist.CalculateImpostorScores(s013Mean, s006);
            sv.ImpostorScoresUser13User7 = ManhDist.CalculateImpostorScores(s013Mean, s007);
            sv.ImpostorScoresUser13User8 = ManhDist.CalculateImpostorScores(s013Mean, s008);
            sv.ImpostorScoresUser13User9 = ManhDist.CalculateImpostorScores(s013Mean, s009);
            sv.ImpostorScoresUser13User10 = ManhDist.CalculateImpostorScores(s013Mean, s010);

            sv.ImpostorScoresUser13User11 = ManhDist.CalculateImpostorScores(s013Mean, s011);
            sv.ImpostorScoresUser13User12 = ManhDist.CalculateImpostorScores(s013Mean, s012);
            sv.ImpostorScoresUser13User14 = ManhDist.CalculateImpostorScores(s013Mean, s014);
            sv.ImpostorScoresUser13User15 = ManhDist.CalculateImpostorScores(s013Mean, s015);
            sv.ImpostorScoresUser13User16 = ManhDist.CalculateImpostorScores(s013Mean, s016);
            sv.ImpostorScoresUser13User17 = ManhDist.CalculateImpostorScores(s013Mean, s017);
            sv.ImpostorScoresUser13User18 = ManhDist.CalculateImpostorScores(s013Mean, s018);
            sv.ImpostorScoresUser13User19 = ManhDist.CalculateImpostorScores(s013Mean, s019);
            sv.ImpostorScoresUser13User20 = ManhDist.CalculateImpostorScores(s013Mean, s020);

            sv.ImpostorScoresUser13User21 = ManhDist.CalculateImpostorScores(s013Mean, s021);
            sv.ImpostorScoresUser13User22 = ManhDist.CalculateImpostorScores(s013Mean, s022);
            sv.ImpostorScoresUser13User23 = ManhDist.CalculateImpostorScores(s013Mean, s023);
            sv.ImpostorScoresUser13User24 = ManhDist.CalculateImpostorScores(s013Mean, s024);
            sv.ImpostorScoresUser13User25 = ManhDist.CalculateImpostorScores(s013Mean, s025);
            sv.ImpostorScoresUser13User26 = ManhDist.CalculateImpostorScores(s013Mean, s026);
            sv.ImpostorScoresUser13User27 = ManhDist.CalculateImpostorScores(s013Mean, s027);
            sv.ImpostorScoresUser13User28 = ManhDist.CalculateImpostorScores(s013Mean, s028);
            sv.ImpostorScoresUser13User29 = ManhDist.CalculateImpostorScores(s013Mean, s029);
            sv.ImpostorScoresUser13User30 = ManhDist.CalculateImpostorScores(s013Mean, s030);

            sv.ImpostorScoresUser13User31 = ManhDist.CalculateImpostorScores(s013Mean, s031);
            sv.ImpostorScoresUser13User32 = ManhDist.CalculateImpostorScores(s013Mean, s032);
            sv.ImpostorScoresUser13User33 = ManhDist.CalculateImpostorScores(s013Mean, s033);
            sv.ImpostorScoresUser13User34 = ManhDist.CalculateImpostorScores(s013Mean, s034);
            sv.ImpostorScoresUser13User35 = ManhDist.CalculateImpostorScores(s013Mean, s035);
            sv.ImpostorScoresUser13User36 = ManhDist.CalculateImpostorScores(s013Mean, s036);
            sv.ImpostorScoresUser13User37 = ManhDist.CalculateImpostorScores(s013Mean, s037);
            sv.ImpostorScoresUser13User38 = ManhDist.CalculateImpostorScores(s013Mean, s038);
            sv.ImpostorScoresUser13User39 = ManhDist.CalculateImpostorScores(s013Mean, s039);
            sv.ImpostorScoresUser13User40 = ManhDist.CalculateImpostorScores(s013Mean, s040);

            sv.ImpostorScoresUser13User41 = ManhDist.CalculateImpostorScores(s013Mean, s041);
            sv.ImpostorScoresUser13User42 = ManhDist.CalculateImpostorScores(s013Mean, s042);
            sv.ImpostorScoresUser13User43 = ManhDist.CalculateImpostorScores(s013Mean, s043);
            sv.ImpostorScoresUser13User44 = ManhDist.CalculateImpostorScores(s013Mean, s044);
            sv.ImpostorScoresUser13User45 = ManhDist.CalculateImpostorScores(s013Mean, s045);
            sv.ImpostorScoresUser13User46 = ManhDist.CalculateImpostorScores(s013Mean, s046);
            sv.ImpostorScoresUser13User47 = ManhDist.CalculateImpostorScores(s013Mean, s047);
            sv.ImpostorScoresUser13User48 = ManhDist.CalculateImpostorScores(s013Mean, s048);
            sv.ImpostorScoresUser13User49 = ManhDist.CalculateImpostorScores(s013Mean, s049);
            sv.ImpostorScoresUser13User50 = ManhDist.CalculateImpostorScores(s013Mean, s050);

            sv.ImpostorScoresUser13User51 = ManhDist.CalculateImpostorScores(s013Mean, s051);
            sv.ImpostorScoresUser13User52 = ManhDist.CalculateImpostorScores(s013Mean, s052);
            sv.ImpostorScoresUser13User53 = ManhDist.CalculateImpostorScores(s013Mean, s053);
            sv.ImpostorScoresUser13User54 = ManhDist.CalculateImpostorScores(s013Mean, s054);
            sv.ImpostorScoresUser13User55 = ManhDist.CalculateImpostorScores(s013Mean, s055);
            sv.ImpostorScoresUser13User56 = ManhDist.CalculateImpostorScores(s013Mean, s056);
            sv.ImpostorScoresUser13User57 = ManhDist.CalculateImpostorScores(s013Mean, s057);
            sv.ImpostorScoresUser13User58 = ManhDist.CalculateImpostorScores(s013Mean, s058);
            sv.ImpostorScoresUser13User59 = ManhDist.CalculateImpostorScores(s013Mean, s059);
            sv.ImpostorScoresUser13User60 = ManhDist.CalculateImpostorScores(s013Mean, s060);

            sv.ImpostorScoresUser13User61 = ManhDist.CalculateImpostorScores(s013Mean, s061);
            sv.ImpostorScoresUser13User62 = ManhDist.CalculateImpostorScores(s013Mean, s062);
            sv.ImpostorScoresUser13User63 = ManhDist.CalculateImpostorScores(s013Mean, s063);
            sv.ImpostorScoresUser13User64 = ManhDist.CalculateImpostorScores(s013Mean, s064);
            sv.ImpostorScoresUser13User65 = ManhDist.CalculateImpostorScores(s013Mean, s065);
            sv.ImpostorScoresUser13User66 = ManhDist.CalculateImpostorScores(s013Mean, s066);
            sv.ImpostorScoresUser13User67 = ManhDist.CalculateImpostorScores(s013Mean, s067);
            sv.ImpostorScoresUser13User68 = ManhDist.CalculateImpostorScores(s013Mean, s068);
            sv.ImpostorScoresUser13User69 = ManhDist.CalculateImpostorScores(s013Mean, s069);
            sv.ImpostorScoresUser13User70 = ManhDist.CalculateImpostorScores(s013Mean, s070);

            sv.ImpostorScoresUser13User71 = ManhDist.CalculateImpostorScores(s013Mean, s071);
            sv.ImpostorScoresUser13User72 = ManhDist.CalculateImpostorScores(s013Mean, s072);
            sv.ImpostorScoresUser13User73 = ManhDist.CalculateImpostorScores(s013Mean, s073);
            sv.ImpostorScoresUser13User74 = ManhDist.CalculateImpostorScores(s013Mean, s074);
            sv.ImpostorScoresUser13User75 = ManhDist.CalculateImpostorScores(s013Mean, s075);
            sv.ImpostorScoresUser13User76 = ManhDist.CalculateImpostorScores(s013Mean, s076);
            sv.ImpostorScoresUser13User77 = ManhDist.CalculateImpostorScores(s013Mean, s077);
            sv.ImpostorScoresUser13User78 = ManhDist.CalculateImpostorScores(s013Mean, s078);
            sv.ImpostorScoresUser13User79 = ManhDist.CalculateImpostorScores(s013Mean, s079);
            sv.ImpostorScoresUser13User80 = ManhDist.CalculateImpostorScores(s013Mean, s080);

            sv.ImpostorScoresUser13User81 = ManhDist.CalculateImpostorScores(s013Mean, s081);
            sv.ImpostorScoresUser13User82 = ManhDist.CalculateImpostorScores(s013Mean, s082);
            sv.ImpostorScoresUser13User83 = ManhDist.CalculateImpostorScores(s013Mean, s083);
            sv.ImpostorScoresUser13User84 = ManhDist.CalculateImpostorScores(s013Mean, s084);
            sv.ImpostorScoresUser13User85 = ManhDist.CalculateImpostorScores(s013Mean, s085);
            sv.ImpostorScoresUser13User86 = ManhDist.CalculateImpostorScores(s013Mean, s086);
            sv.ImpostorScoresUser13User87 = ManhDist.CalculateImpostorScores(s013Mean, s087);
            sv.ImpostorScoresUser13User88 = ManhDist.CalculateImpostorScores(s013Mean, s088);
            sv.ImpostorScoresUser13User89 = ManhDist.CalculateImpostorScores(s013Mean, s089);
            sv.ImpostorScoresUser13User90 = ManhDist.CalculateImpostorScores(s013Mean, s090);

            sv.ImpostorScoresUser13User91 = ManhDist.CalculateImpostorScores(s013Mean, s091);
            sv.ImpostorScoresUser13User92 = ManhDist.CalculateImpostorScores(s013Mean, s092);
            sv.ImpostorScoresUser13User93 = ManhDist.CalculateImpostorScores(s013Mean, s093);
            sv.ImpostorScoresUser13User94 = ManhDist.CalculateImpostorScores(s013Mean, s094);
            sv.ImpostorScoresUser13User95 = ManhDist.CalculateImpostorScores(s013Mean, s095);
            sv.ImpostorScoresUser13User96 = ManhDist.CalculateImpostorScores(s013Mean, s096);
            sv.ImpostorScoresUser13User97 = ManhDist.CalculateImpostorScores(s013Mean, s097);
            sv.ImpostorScoresUser13User98 = ManhDist.CalculateImpostorScores(s013Mean, s098);
            sv.ImpostorScoresUser13User99 = ManhDist.CalculateImpostorScores(s013Mean, s099);
            sv.ImpostorScoresUser13User100 = ManhDist.CalculateImpostorScores(s013Mean, s100);
            #endregion

            #region User 14 Impostor scores
            sv.ImpostorScoresUser14User1 = ManhDist.CalculateImpostorScores(s014Mean, s001);
            sv.ImpostorScoresUser14User2 = ManhDist.CalculateImpostorScores(s014Mean, s002);
            sv.ImpostorScoresUser14User3 = ManhDist.CalculateImpostorScores(s014Mean, s003);
            sv.ImpostorScoresUser14User4 = ManhDist.CalculateImpostorScores(s014Mean, s004);
            sv.ImpostorScoresUser14User5 = ManhDist.CalculateImpostorScores(s014Mean, s005);
            sv.ImpostorScoresUser14User6 = ManhDist.CalculateImpostorScores(s014Mean, s006);
            sv.ImpostorScoresUser14User7 = ManhDist.CalculateImpostorScores(s014Mean, s007);
            sv.ImpostorScoresUser14User8 = ManhDist.CalculateImpostorScores(s014Mean, s008);
            sv.ImpostorScoresUser14User9 = ManhDist.CalculateImpostorScores(s014Mean, s009);
            sv.ImpostorScoresUser14User10 = ManhDist.CalculateImpostorScores(s014Mean, s010);

            sv.ImpostorScoresUser14User11 = ManhDist.CalculateImpostorScores(s014Mean, s011);
            sv.ImpostorScoresUser14User12 = ManhDist.CalculateImpostorScores(s014Mean, s012);
            sv.ImpostorScoresUser14User13 = ManhDist.CalculateImpostorScores(s014Mean, s013);
            sv.ImpostorScoresUser14User15 = ManhDist.CalculateImpostorScores(s014Mean, s015);
            sv.ImpostorScoresUser14User16 = ManhDist.CalculateImpostorScores(s014Mean, s016);
            sv.ImpostorScoresUser14User17 = ManhDist.CalculateImpostorScores(s014Mean, s017);
            sv.ImpostorScoresUser14User18 = ManhDist.CalculateImpostorScores(s014Mean, s018);
            sv.ImpostorScoresUser14User19 = ManhDist.CalculateImpostorScores(s014Mean, s019);
            sv.ImpostorScoresUser14User20 = ManhDist.CalculateImpostorScores(s014Mean, s020);

            sv.ImpostorScoresUser14User21 = ManhDist.CalculateImpostorScores(s014Mean, s021);
            sv.ImpostorScoresUser14User22 = ManhDist.CalculateImpostorScores(s014Mean, s022);
            sv.ImpostorScoresUser14User23 = ManhDist.CalculateImpostorScores(s014Mean, s023);
            sv.ImpostorScoresUser14User24 = ManhDist.CalculateImpostorScores(s014Mean, s024);
            sv.ImpostorScoresUser14User25 = ManhDist.CalculateImpostorScores(s014Mean, s025);
            sv.ImpostorScoresUser14User26 = ManhDist.CalculateImpostorScores(s014Mean, s026);
            sv.ImpostorScoresUser14User27 = ManhDist.CalculateImpostorScores(s014Mean, s027);
            sv.ImpostorScoresUser14User28 = ManhDist.CalculateImpostorScores(s014Mean, s028);
            sv.ImpostorScoresUser14User29 = ManhDist.CalculateImpostorScores(s014Mean, s029);
            sv.ImpostorScoresUser14User30 = ManhDist.CalculateImpostorScores(s014Mean, s030);

            sv.ImpostorScoresUser14User31 = ManhDist.CalculateImpostorScores(s014Mean, s031);
            sv.ImpostorScoresUser14User32 = ManhDist.CalculateImpostorScores(s014Mean, s032);
            sv.ImpostorScoresUser14User33 = ManhDist.CalculateImpostorScores(s014Mean, s033);
            sv.ImpostorScoresUser14User34 = ManhDist.CalculateImpostorScores(s014Mean, s034);
            sv.ImpostorScoresUser14User35 = ManhDist.CalculateImpostorScores(s014Mean, s035);
            sv.ImpostorScoresUser14User36 = ManhDist.CalculateImpostorScores(s014Mean, s036);
            sv.ImpostorScoresUser14User37 = ManhDist.CalculateImpostorScores(s014Mean, s037);
            sv.ImpostorScoresUser14User38 = ManhDist.CalculateImpostorScores(s014Mean, s038);
            sv.ImpostorScoresUser14User39 = ManhDist.CalculateImpostorScores(s014Mean, s039);
            sv.ImpostorScoresUser14User40 = ManhDist.CalculateImpostorScores(s014Mean, s040);

            sv.ImpostorScoresUser14User41 = ManhDist.CalculateImpostorScores(s014Mean, s041);
            sv.ImpostorScoresUser14User42 = ManhDist.CalculateImpostorScores(s014Mean, s042);
            sv.ImpostorScoresUser14User43 = ManhDist.CalculateImpostorScores(s014Mean, s043);
            sv.ImpostorScoresUser14User44 = ManhDist.CalculateImpostorScores(s014Mean, s044);
            sv.ImpostorScoresUser14User45 = ManhDist.CalculateImpostorScores(s014Mean, s045);
            sv.ImpostorScoresUser14User46 = ManhDist.CalculateImpostorScores(s014Mean, s046);
            sv.ImpostorScoresUser14User47 = ManhDist.CalculateImpostorScores(s014Mean, s047);
            sv.ImpostorScoresUser14User48 = ManhDist.CalculateImpostorScores(s014Mean, s048);
            sv.ImpostorScoresUser14User49 = ManhDist.CalculateImpostorScores(s014Mean, s049);
            sv.ImpostorScoresUser14User50 = ManhDist.CalculateImpostorScores(s014Mean, s050);

            sv.ImpostorScoresUser14User51 = ManhDist.CalculateImpostorScores(s014Mean, s051);
            sv.ImpostorScoresUser14User52 = ManhDist.CalculateImpostorScores(s014Mean, s052);
            sv.ImpostorScoresUser14User53 = ManhDist.CalculateImpostorScores(s014Mean, s053);
            sv.ImpostorScoresUser14User54 = ManhDist.CalculateImpostorScores(s014Mean, s054);
            sv.ImpostorScoresUser14User55 = ManhDist.CalculateImpostorScores(s014Mean, s055);
            sv.ImpostorScoresUser14User56 = ManhDist.CalculateImpostorScores(s014Mean, s056);
            sv.ImpostorScoresUser14User57 = ManhDist.CalculateImpostorScores(s014Mean, s057);
            sv.ImpostorScoresUser14User58 = ManhDist.CalculateImpostorScores(s014Mean, s058);
            sv.ImpostorScoresUser14User59 = ManhDist.CalculateImpostorScores(s014Mean, s059);
            sv.ImpostorScoresUser14User60 = ManhDist.CalculateImpostorScores(s014Mean, s060);

            sv.ImpostorScoresUser14User61 = ManhDist.CalculateImpostorScores(s014Mean, s061);
            sv.ImpostorScoresUser14User62 = ManhDist.CalculateImpostorScores(s014Mean, s062);
            sv.ImpostorScoresUser14User63 = ManhDist.CalculateImpostorScores(s014Mean, s063);
            sv.ImpostorScoresUser14User64 = ManhDist.CalculateImpostorScores(s014Mean, s064);
            sv.ImpostorScoresUser14User65 = ManhDist.CalculateImpostorScores(s014Mean, s065);
            sv.ImpostorScoresUser14User66 = ManhDist.CalculateImpostorScores(s014Mean, s066);
            sv.ImpostorScoresUser14User67 = ManhDist.CalculateImpostorScores(s014Mean, s067);
            sv.ImpostorScoresUser14User68 = ManhDist.CalculateImpostorScores(s014Mean, s068);
            sv.ImpostorScoresUser14User69 = ManhDist.CalculateImpostorScores(s014Mean, s069);
            sv.ImpostorScoresUser14User70 = ManhDist.CalculateImpostorScores(s014Mean, s070);

            sv.ImpostorScoresUser14User71 = ManhDist.CalculateImpostorScores(s014Mean, s071);
            sv.ImpostorScoresUser14User72 = ManhDist.CalculateImpostorScores(s014Mean, s072);
            sv.ImpostorScoresUser14User73 = ManhDist.CalculateImpostorScores(s014Mean, s073);
            sv.ImpostorScoresUser14User74 = ManhDist.CalculateImpostorScores(s014Mean, s074);
            sv.ImpostorScoresUser14User75 = ManhDist.CalculateImpostorScores(s014Mean, s075);
            sv.ImpostorScoresUser14User76 = ManhDist.CalculateImpostorScores(s014Mean, s076);
            sv.ImpostorScoresUser14User77 = ManhDist.CalculateImpostorScores(s014Mean, s077);
            sv.ImpostorScoresUser14User78 = ManhDist.CalculateImpostorScores(s014Mean, s078);
            sv.ImpostorScoresUser14User79 = ManhDist.CalculateImpostorScores(s014Mean, s079);
            sv.ImpostorScoresUser14User80 = ManhDist.CalculateImpostorScores(s014Mean, s080);

            sv.ImpostorScoresUser14User81 = ManhDist.CalculateImpostorScores(s014Mean, s081);
            sv.ImpostorScoresUser14User82 = ManhDist.CalculateImpostorScores(s014Mean, s082);
            sv.ImpostorScoresUser14User83 = ManhDist.CalculateImpostorScores(s014Mean, s083);
            sv.ImpostorScoresUser14User84 = ManhDist.CalculateImpostorScores(s014Mean, s084);
            sv.ImpostorScoresUser14User85 = ManhDist.CalculateImpostorScores(s014Mean, s085);
            sv.ImpostorScoresUser14User86 = ManhDist.CalculateImpostorScores(s014Mean, s086);
            sv.ImpostorScoresUser14User87 = ManhDist.CalculateImpostorScores(s014Mean, s087);
            sv.ImpostorScoresUser14User88 = ManhDist.CalculateImpostorScores(s014Mean, s088);
            sv.ImpostorScoresUser14User89 = ManhDist.CalculateImpostorScores(s014Mean, s089);
            sv.ImpostorScoresUser14User90 = ManhDist.CalculateImpostorScores(s014Mean, s090);

            sv.ImpostorScoresUser14User91 = ManhDist.CalculateImpostorScores(s014Mean, s091);
            sv.ImpostorScoresUser14User92 = ManhDist.CalculateImpostorScores(s014Mean, s092);
            sv.ImpostorScoresUser14User93 = ManhDist.CalculateImpostorScores(s014Mean, s093);
            sv.ImpostorScoresUser14User94 = ManhDist.CalculateImpostorScores(s014Mean, s094);
            sv.ImpostorScoresUser14User95 = ManhDist.CalculateImpostorScores(s014Mean, s095);
            sv.ImpostorScoresUser14User96 = ManhDist.CalculateImpostorScores(s014Mean, s096);
            sv.ImpostorScoresUser14User97 = ManhDist.CalculateImpostorScores(s014Mean, s097);
            sv.ImpostorScoresUser14User98 = ManhDist.CalculateImpostorScores(s014Mean, s098);
            sv.ImpostorScoresUser14User99 = ManhDist.CalculateImpostorScores(s014Mean, s099);
            sv.ImpostorScoresUser14User100 = ManhDist.CalculateImpostorScores(s014Mean, s100);
            #endregion

            #region User 15 Impostor scores
            sv.ImpostorScoresUser15User1 = ManhDist.CalculateImpostorScores(s015Mean, s001);
            sv.ImpostorScoresUser15User2 = ManhDist.CalculateImpostorScores(s015Mean, s002);
            sv.ImpostorScoresUser15User3 = ManhDist.CalculateImpostorScores(s015Mean, s003);
            sv.ImpostorScoresUser15User4 = ManhDist.CalculateImpostorScores(s015Mean, s004);
            sv.ImpostorScoresUser15User5 = ManhDist.CalculateImpostorScores(s015Mean, s005);
            sv.ImpostorScoresUser15User6 = ManhDist.CalculateImpostorScores(s015Mean, s006);
            sv.ImpostorScoresUser15User7 = ManhDist.CalculateImpostorScores(s015Mean, s007);
            sv.ImpostorScoresUser15User8 = ManhDist.CalculateImpostorScores(s015Mean, s008);
            sv.ImpostorScoresUser15User9 = ManhDist.CalculateImpostorScores(s015Mean, s009);
            sv.ImpostorScoresUser15User10 = ManhDist.CalculateImpostorScores(s015Mean, s010);

            sv.ImpostorScoresUser15User11 = ManhDist.CalculateImpostorScores(s015Mean, s011);
            sv.ImpostorScoresUser15User12 = ManhDist.CalculateImpostorScores(s015Mean, s012);
            sv.ImpostorScoresUser15User13 = ManhDist.CalculateImpostorScores(s015Mean, s013);
            sv.ImpostorScoresUser15User14 = ManhDist.CalculateImpostorScores(s015Mean, s014);
            sv.ImpostorScoresUser15User16 = ManhDist.CalculateImpostorScores(s015Mean, s016);
            sv.ImpostorScoresUser15User17 = ManhDist.CalculateImpostorScores(s015Mean, s017);
            sv.ImpostorScoresUser15User18 = ManhDist.CalculateImpostorScores(s015Mean, s018);
            sv.ImpostorScoresUser15User19 = ManhDist.CalculateImpostorScores(s015Mean, s019);
            sv.ImpostorScoresUser15User20 = ManhDist.CalculateImpostorScores(s015Mean, s020);

            sv.ImpostorScoresUser15User21 = ManhDist.CalculateImpostorScores(s015Mean, s021);
            sv.ImpostorScoresUser15User22 = ManhDist.CalculateImpostorScores(s015Mean, s022);
            sv.ImpostorScoresUser15User23 = ManhDist.CalculateImpostorScores(s015Mean, s023);
            sv.ImpostorScoresUser15User24 = ManhDist.CalculateImpostorScores(s015Mean, s024);
            sv.ImpostorScoresUser15User25 = ManhDist.CalculateImpostorScores(s015Mean, s025);
            sv.ImpostorScoresUser15User26 = ManhDist.CalculateImpostorScores(s015Mean, s026);
            sv.ImpostorScoresUser15User27 = ManhDist.CalculateImpostorScores(s015Mean, s027);
            sv.ImpostorScoresUser15User28 = ManhDist.CalculateImpostorScores(s015Mean, s028);
            sv.ImpostorScoresUser15User29 = ManhDist.CalculateImpostorScores(s015Mean, s029);
            sv.ImpostorScoresUser15User30 = ManhDist.CalculateImpostorScores(s015Mean, s030);

            sv.ImpostorScoresUser15User31 = ManhDist.CalculateImpostorScores(s015Mean, s031);
            sv.ImpostorScoresUser15User32 = ManhDist.CalculateImpostorScores(s015Mean, s032);
            sv.ImpostorScoresUser15User33 = ManhDist.CalculateImpostorScores(s015Mean, s033);
            sv.ImpostorScoresUser15User34 = ManhDist.CalculateImpostorScores(s015Mean, s034);
            sv.ImpostorScoresUser15User35 = ManhDist.CalculateImpostorScores(s015Mean, s035);
            sv.ImpostorScoresUser15User36 = ManhDist.CalculateImpostorScores(s015Mean, s036);
            sv.ImpostorScoresUser15User37 = ManhDist.CalculateImpostorScores(s015Mean, s037);
            sv.ImpostorScoresUser15User38 = ManhDist.CalculateImpostorScores(s015Mean, s038);
            sv.ImpostorScoresUser15User39 = ManhDist.CalculateImpostorScores(s015Mean, s039);
            sv.ImpostorScoresUser15User40 = ManhDist.CalculateImpostorScores(s015Mean, s040);

            sv.ImpostorScoresUser15User41 = ManhDist.CalculateImpostorScores(s015Mean, s041);
            sv.ImpostorScoresUser15User42 = ManhDist.CalculateImpostorScores(s015Mean, s042);
            sv.ImpostorScoresUser15User43 = ManhDist.CalculateImpostorScores(s015Mean, s043);
            sv.ImpostorScoresUser15User44 = ManhDist.CalculateImpostorScores(s015Mean, s044);
            sv.ImpostorScoresUser15User45 = ManhDist.CalculateImpostorScores(s015Mean, s045);
            sv.ImpostorScoresUser15User46 = ManhDist.CalculateImpostorScores(s015Mean, s046);
            sv.ImpostorScoresUser15User47 = ManhDist.CalculateImpostorScores(s015Mean, s047);
            sv.ImpostorScoresUser15User48 = ManhDist.CalculateImpostorScores(s015Mean, s048);
            sv.ImpostorScoresUser15User49 = ManhDist.CalculateImpostorScores(s015Mean, s049);
            sv.ImpostorScoresUser15User50 = ManhDist.CalculateImpostorScores(s015Mean, s050);

            sv.ImpostorScoresUser15User51 = ManhDist.CalculateImpostorScores(s015Mean, s051);
            sv.ImpostorScoresUser15User52 = ManhDist.CalculateImpostorScores(s015Mean, s052);
            sv.ImpostorScoresUser15User53 = ManhDist.CalculateImpostorScores(s015Mean, s053);
            sv.ImpostorScoresUser15User54 = ManhDist.CalculateImpostorScores(s015Mean, s054);
            sv.ImpostorScoresUser15User55 = ManhDist.CalculateImpostorScores(s015Mean, s055);
            sv.ImpostorScoresUser15User56 = ManhDist.CalculateImpostorScores(s015Mean, s056);
            sv.ImpostorScoresUser15User57 = ManhDist.CalculateImpostorScores(s015Mean, s057);
            sv.ImpostorScoresUser15User58 = ManhDist.CalculateImpostorScores(s015Mean, s058);
            sv.ImpostorScoresUser15User59 = ManhDist.CalculateImpostorScores(s015Mean, s059);
            sv.ImpostorScoresUser15User60 = ManhDist.CalculateImpostorScores(s015Mean, s060);

            sv.ImpostorScoresUser15User61 = ManhDist.CalculateImpostorScores(s015Mean, s061);
            sv.ImpostorScoresUser15User62 = ManhDist.CalculateImpostorScores(s015Mean, s062);
            sv.ImpostorScoresUser15User63 = ManhDist.CalculateImpostorScores(s015Mean, s063);
            sv.ImpostorScoresUser15User64 = ManhDist.CalculateImpostorScores(s015Mean, s064);
            sv.ImpostorScoresUser15User65 = ManhDist.CalculateImpostorScores(s015Mean, s065);
            sv.ImpostorScoresUser15User66 = ManhDist.CalculateImpostorScores(s015Mean, s066);
            sv.ImpostorScoresUser15User67 = ManhDist.CalculateImpostorScores(s015Mean, s067);
            sv.ImpostorScoresUser15User68 = ManhDist.CalculateImpostorScores(s015Mean, s068);
            sv.ImpostorScoresUser15User69 = ManhDist.CalculateImpostorScores(s015Mean, s069);
            sv.ImpostorScoresUser15User70 = ManhDist.CalculateImpostorScores(s015Mean, s070);

            sv.ImpostorScoresUser15User71 = ManhDist.CalculateImpostorScores(s015Mean, s071);
            sv.ImpostorScoresUser15User72 = ManhDist.CalculateImpostorScores(s015Mean, s072);
            sv.ImpostorScoresUser15User73 = ManhDist.CalculateImpostorScores(s015Mean, s073);
            sv.ImpostorScoresUser15User74 = ManhDist.CalculateImpostorScores(s015Mean, s074);
            sv.ImpostorScoresUser15User75 = ManhDist.CalculateImpostorScores(s015Mean, s075);
            sv.ImpostorScoresUser15User76 = ManhDist.CalculateImpostorScores(s015Mean, s076);
            sv.ImpostorScoresUser15User77 = ManhDist.CalculateImpostorScores(s015Mean, s077);
            sv.ImpostorScoresUser15User78 = ManhDist.CalculateImpostorScores(s015Mean, s078);
            sv.ImpostorScoresUser15User79 = ManhDist.CalculateImpostorScores(s015Mean, s079);
            sv.ImpostorScoresUser15User80 = ManhDist.CalculateImpostorScores(s015Mean, s080);

            sv.ImpostorScoresUser15User81 = ManhDist.CalculateImpostorScores(s015Mean, s081);
            sv.ImpostorScoresUser15User82 = ManhDist.CalculateImpostorScores(s015Mean, s082);
            sv.ImpostorScoresUser15User83 = ManhDist.CalculateImpostorScores(s015Mean, s083);
            sv.ImpostorScoresUser15User84 = ManhDist.CalculateImpostorScores(s015Mean, s084);
            sv.ImpostorScoresUser15User85 = ManhDist.CalculateImpostorScores(s015Mean, s085);
            sv.ImpostorScoresUser15User86 = ManhDist.CalculateImpostorScores(s015Mean, s086);
            sv.ImpostorScoresUser15User87 = ManhDist.CalculateImpostorScores(s015Mean, s087);
            sv.ImpostorScoresUser15User88 = ManhDist.CalculateImpostorScores(s015Mean, s088);
            sv.ImpostorScoresUser15User89 = ManhDist.CalculateImpostorScores(s015Mean, s089);
            sv.ImpostorScoresUser15User90 = ManhDist.CalculateImpostorScores(s015Mean, s090);

            sv.ImpostorScoresUser15User91 = ManhDist.CalculateImpostorScores(s015Mean, s091);
            sv.ImpostorScoresUser15User92 = ManhDist.CalculateImpostorScores(s015Mean, s092);
            sv.ImpostorScoresUser15User93 = ManhDist.CalculateImpostorScores(s015Mean, s093);
            sv.ImpostorScoresUser15User94 = ManhDist.CalculateImpostorScores(s015Mean, s094);
            sv.ImpostorScoresUser15User95 = ManhDist.CalculateImpostorScores(s015Mean, s095);
            sv.ImpostorScoresUser15User96 = ManhDist.CalculateImpostorScores(s015Mean, s096);
            sv.ImpostorScoresUser15User97 = ManhDist.CalculateImpostorScores(s015Mean, s097);
            sv.ImpostorScoresUser15User98 = ManhDist.CalculateImpostorScores(s015Mean, s098);
            sv.ImpostorScoresUser15User99 = ManhDist.CalculateImpostorScores(s015Mean, s099);
            sv.ImpostorScoresUser15User100 = ManhDist.CalculateImpostorScores(s015Mean, s100);
            #endregion

            #region User 16 Impostor scores
            sv.ImpostorScoresUser16User1 = ManhDist.CalculateImpostorScores(s016Mean, s001);
            sv.ImpostorScoresUser16User2 = ManhDist.CalculateImpostorScores(s016Mean, s002);
            sv.ImpostorScoresUser16User3 = ManhDist.CalculateImpostorScores(s016Mean, s003);
            sv.ImpostorScoresUser16User4 = ManhDist.CalculateImpostorScores(s016Mean, s004);
            sv.ImpostorScoresUser16User5 = ManhDist.CalculateImpostorScores(s016Mean, s005);
            sv.ImpostorScoresUser16User6 = ManhDist.CalculateImpostorScores(s016Mean, s006);
            sv.ImpostorScoresUser16User7 = ManhDist.CalculateImpostorScores(s016Mean, s007);
            sv.ImpostorScoresUser16User8 = ManhDist.CalculateImpostorScores(s016Mean, s008);
            sv.ImpostorScoresUser16User9 = ManhDist.CalculateImpostorScores(s016Mean, s009);
            sv.ImpostorScoresUser16User10 = ManhDist.CalculateImpostorScores(s016Mean, s010);

            sv.ImpostorScoresUser16User11 = ManhDist.CalculateImpostorScores(s016Mean, s011);
            sv.ImpostorScoresUser16User12 = ManhDist.CalculateImpostorScores(s016Mean, s012);
            sv.ImpostorScoresUser16User13 = ManhDist.CalculateImpostorScores(s016Mean, s013);
            sv.ImpostorScoresUser16User14 = ManhDist.CalculateImpostorScores(s016Mean, s014);
            sv.ImpostorScoresUser16User15 = ManhDist.CalculateImpostorScores(s016Mean, s015);
            sv.ImpostorScoresUser16User17 = ManhDist.CalculateImpostorScores(s016Mean, s017);
            sv.ImpostorScoresUser16User18 = ManhDist.CalculateImpostorScores(s016Mean, s018);
            sv.ImpostorScoresUser16User19 = ManhDist.CalculateImpostorScores(s016Mean, s019);
            sv.ImpostorScoresUser16User20 = ManhDist.CalculateImpostorScores(s016Mean, s020);

            sv.ImpostorScoresUser16User21 = ManhDist.CalculateImpostorScores(s016Mean, s021);
            sv.ImpostorScoresUser16User22 = ManhDist.CalculateImpostorScores(s016Mean, s022);
            sv.ImpostorScoresUser16User23 = ManhDist.CalculateImpostorScores(s016Mean, s023);
            sv.ImpostorScoresUser16User24 = ManhDist.CalculateImpostorScores(s016Mean, s024);
            sv.ImpostorScoresUser16User25 = ManhDist.CalculateImpostorScores(s016Mean, s025);
            sv.ImpostorScoresUser16User26 = ManhDist.CalculateImpostorScores(s016Mean, s026);
            sv.ImpostorScoresUser16User27 = ManhDist.CalculateImpostorScores(s016Mean, s027);
            sv.ImpostorScoresUser16User28 = ManhDist.CalculateImpostorScores(s016Mean, s028);
            sv.ImpostorScoresUser16User29 = ManhDist.CalculateImpostorScores(s016Mean, s029);
            sv.ImpostorScoresUser16User30 = ManhDist.CalculateImpostorScores(s016Mean, s030);

            sv.ImpostorScoresUser16User31 = ManhDist.CalculateImpostorScores(s016Mean, s031);
            sv.ImpostorScoresUser16User32 = ManhDist.CalculateImpostorScores(s016Mean, s032);
            sv.ImpostorScoresUser16User33 = ManhDist.CalculateImpostorScores(s016Mean, s033);
            sv.ImpostorScoresUser16User34 = ManhDist.CalculateImpostorScores(s016Mean, s034);
            sv.ImpostorScoresUser16User35 = ManhDist.CalculateImpostorScores(s016Mean, s035);
            sv.ImpostorScoresUser16User36 = ManhDist.CalculateImpostorScores(s016Mean, s036);
            sv.ImpostorScoresUser16User37 = ManhDist.CalculateImpostorScores(s016Mean, s037);
            sv.ImpostorScoresUser16User38 = ManhDist.CalculateImpostorScores(s016Mean, s038);
            sv.ImpostorScoresUser16User39 = ManhDist.CalculateImpostorScores(s016Mean, s039);
            sv.ImpostorScoresUser16User40 = ManhDist.CalculateImpostorScores(s016Mean, s040);

            sv.ImpostorScoresUser16User41 = ManhDist.CalculateImpostorScores(s016Mean, s041);
            sv.ImpostorScoresUser16User42 = ManhDist.CalculateImpostorScores(s016Mean, s042);
            sv.ImpostorScoresUser16User43 = ManhDist.CalculateImpostorScores(s016Mean, s043);
            sv.ImpostorScoresUser16User44 = ManhDist.CalculateImpostorScores(s016Mean, s044);
            sv.ImpostorScoresUser16User45 = ManhDist.CalculateImpostorScores(s016Mean, s045);
            sv.ImpostorScoresUser16User46 = ManhDist.CalculateImpostorScores(s016Mean, s046);
            sv.ImpostorScoresUser16User47 = ManhDist.CalculateImpostorScores(s016Mean, s047);
            sv.ImpostorScoresUser16User48 = ManhDist.CalculateImpostorScores(s016Mean, s048);
            sv.ImpostorScoresUser16User49 = ManhDist.CalculateImpostorScores(s016Mean, s049);
            sv.ImpostorScoresUser16User50 = ManhDist.CalculateImpostorScores(s016Mean, s050);

            sv.ImpostorScoresUser16User51 = ManhDist.CalculateImpostorScores(s016Mean, s051);
            sv.ImpostorScoresUser16User52 = ManhDist.CalculateImpostorScores(s016Mean, s052);
            sv.ImpostorScoresUser16User53 = ManhDist.CalculateImpostorScores(s016Mean, s053);
            sv.ImpostorScoresUser16User54 = ManhDist.CalculateImpostorScores(s016Mean, s054);
            sv.ImpostorScoresUser16User55 = ManhDist.CalculateImpostorScores(s016Mean, s055);
            sv.ImpostorScoresUser16User56 = ManhDist.CalculateImpostorScores(s016Mean, s056);
            sv.ImpostorScoresUser16User57 = ManhDist.CalculateImpostorScores(s016Mean, s057);
            sv.ImpostorScoresUser16User58 = ManhDist.CalculateImpostorScores(s016Mean, s058);
            sv.ImpostorScoresUser16User59 = ManhDist.CalculateImpostorScores(s016Mean, s059);
            sv.ImpostorScoresUser16User60 = ManhDist.CalculateImpostorScores(s016Mean, s060);

            sv.ImpostorScoresUser16User61 = ManhDist.CalculateImpostorScores(s016Mean, s061);
            sv.ImpostorScoresUser16User62 = ManhDist.CalculateImpostorScores(s016Mean, s062);
            sv.ImpostorScoresUser16User63 = ManhDist.CalculateImpostorScores(s016Mean, s063);
            sv.ImpostorScoresUser16User64 = ManhDist.CalculateImpostorScores(s016Mean, s064);
            sv.ImpostorScoresUser16User65 = ManhDist.CalculateImpostorScores(s016Mean, s065);
            sv.ImpostorScoresUser16User66 = ManhDist.CalculateImpostorScores(s016Mean, s066);
            sv.ImpostorScoresUser16User67 = ManhDist.CalculateImpostorScores(s016Mean, s067);
            sv.ImpostorScoresUser16User68 = ManhDist.CalculateImpostorScores(s016Mean, s068);
            sv.ImpostorScoresUser16User69 = ManhDist.CalculateImpostorScores(s016Mean, s069);
            sv.ImpostorScoresUser16User70 = ManhDist.CalculateImpostorScores(s016Mean, s070);

            sv.ImpostorScoresUser16User71 = ManhDist.CalculateImpostorScores(s016Mean, s071);
            sv.ImpostorScoresUser16User72 = ManhDist.CalculateImpostorScores(s016Mean, s072);
            sv.ImpostorScoresUser16User73 = ManhDist.CalculateImpostorScores(s016Mean, s073);
            sv.ImpostorScoresUser16User74 = ManhDist.CalculateImpostorScores(s016Mean, s074);
            sv.ImpostorScoresUser16User75 = ManhDist.CalculateImpostorScores(s016Mean, s075);
            sv.ImpostorScoresUser16User76 = ManhDist.CalculateImpostorScores(s016Mean, s076);
            sv.ImpostorScoresUser16User77 = ManhDist.CalculateImpostorScores(s016Mean, s077);
            sv.ImpostorScoresUser16User78 = ManhDist.CalculateImpostorScores(s016Mean, s078);
            sv.ImpostorScoresUser16User79 = ManhDist.CalculateImpostorScores(s016Mean, s079);
            sv.ImpostorScoresUser16User80 = ManhDist.CalculateImpostorScores(s016Mean, s080);

            sv.ImpostorScoresUser16User81 = ManhDist.CalculateImpostorScores(s016Mean, s081);
            sv.ImpostorScoresUser16User82 = ManhDist.CalculateImpostorScores(s016Mean, s082);
            sv.ImpostorScoresUser16User83 = ManhDist.CalculateImpostorScores(s016Mean, s083);
            sv.ImpostorScoresUser16User84 = ManhDist.CalculateImpostorScores(s016Mean, s084);
            sv.ImpostorScoresUser16User85 = ManhDist.CalculateImpostorScores(s016Mean, s085);
            sv.ImpostorScoresUser16User86 = ManhDist.CalculateImpostorScores(s016Mean, s086);
            sv.ImpostorScoresUser16User87 = ManhDist.CalculateImpostorScores(s016Mean, s087);
            sv.ImpostorScoresUser16User88 = ManhDist.CalculateImpostorScores(s016Mean, s088);
            sv.ImpostorScoresUser16User89 = ManhDist.CalculateImpostorScores(s016Mean, s089);
            sv.ImpostorScoresUser16User90 = ManhDist.CalculateImpostorScores(s016Mean, s090);

            sv.ImpostorScoresUser16User91 = ManhDist.CalculateImpostorScores(s016Mean, s091);
            sv.ImpostorScoresUser16User92 = ManhDist.CalculateImpostorScores(s016Mean, s092);
            sv.ImpostorScoresUser16User93 = ManhDist.CalculateImpostorScores(s016Mean, s093);
            sv.ImpostorScoresUser16User94 = ManhDist.CalculateImpostorScores(s016Mean, s094);
            sv.ImpostorScoresUser16User95 = ManhDist.CalculateImpostorScores(s016Mean, s095);
            sv.ImpostorScoresUser16User96 = ManhDist.CalculateImpostorScores(s016Mean, s096);
            sv.ImpostorScoresUser16User97 = ManhDist.CalculateImpostorScores(s016Mean, s097);
            sv.ImpostorScoresUser16User98 = ManhDist.CalculateImpostorScores(s016Mean, s098);
            sv.ImpostorScoresUser16User99 = ManhDist.CalculateImpostorScores(s016Mean, s099);
            sv.ImpostorScoresUser16User100 = ManhDist.CalculateImpostorScores(s016Mean, s100);
            #endregion

            #region User 17 Impostor scores
            sv.ImpostorScoresUser17User1 = ManhDist.CalculateImpostorScores(s017Mean, s001);
            sv.ImpostorScoresUser17User2 = ManhDist.CalculateImpostorScores(s017Mean, s002);
            sv.ImpostorScoresUser17User3 = ManhDist.CalculateImpostorScores(s017Mean, s003);
            sv.ImpostorScoresUser17User4 = ManhDist.CalculateImpostorScores(s017Mean, s004);
            sv.ImpostorScoresUser17User5 = ManhDist.CalculateImpostorScores(s017Mean, s005);
            sv.ImpostorScoresUser17User6 = ManhDist.CalculateImpostorScores(s017Mean, s006);
            sv.ImpostorScoresUser17User7 = ManhDist.CalculateImpostorScores(s017Mean, s007);
            sv.ImpostorScoresUser17User8 = ManhDist.CalculateImpostorScores(s017Mean, s008);
            sv.ImpostorScoresUser17User9 = ManhDist.CalculateImpostorScores(s017Mean, s009);
            sv.ImpostorScoresUser17User10 = ManhDist.CalculateImpostorScores(s017Mean, s010);

            sv.ImpostorScoresUser17User11 = ManhDist.CalculateImpostorScores(s017Mean, s011);
            sv.ImpostorScoresUser17User12 = ManhDist.CalculateImpostorScores(s017Mean, s012);
            sv.ImpostorScoresUser17User13 = ManhDist.CalculateImpostorScores(s017Mean, s013);
            sv.ImpostorScoresUser17User14 = ManhDist.CalculateImpostorScores(s017Mean, s014);
            sv.ImpostorScoresUser17User15 = ManhDist.CalculateImpostorScores(s017Mean, s015);
            sv.ImpostorScoresUser17User16 = ManhDist.CalculateImpostorScores(s017Mean, s016);
            sv.ImpostorScoresUser17User18 = ManhDist.CalculateImpostorScores(s017Mean, s018);
            sv.ImpostorScoresUser17User19 = ManhDist.CalculateImpostorScores(s017Mean, s019);
            sv.ImpostorScoresUser17User20 = ManhDist.CalculateImpostorScores(s017Mean, s020);

            sv.ImpostorScoresUser17User21 = ManhDist.CalculateImpostorScores(s017Mean, s021);
            sv.ImpostorScoresUser17User22 = ManhDist.CalculateImpostorScores(s017Mean, s022);
            sv.ImpostorScoresUser17User23 = ManhDist.CalculateImpostorScores(s017Mean, s023);
            sv.ImpostorScoresUser17User24 = ManhDist.CalculateImpostorScores(s017Mean, s024);
            sv.ImpostorScoresUser17User25 = ManhDist.CalculateImpostorScores(s017Mean, s025);
            sv.ImpostorScoresUser17User26 = ManhDist.CalculateImpostorScores(s017Mean, s026);
            sv.ImpostorScoresUser17User27 = ManhDist.CalculateImpostorScores(s017Mean, s027);
            sv.ImpostorScoresUser17User28 = ManhDist.CalculateImpostorScores(s017Mean, s028);
            sv.ImpostorScoresUser17User29 = ManhDist.CalculateImpostorScores(s017Mean, s029);
            sv.ImpostorScoresUser17User30 = ManhDist.CalculateImpostorScores(s017Mean, s030);

            sv.ImpostorScoresUser17User31 = ManhDist.CalculateImpostorScores(s017Mean, s031);
            sv.ImpostorScoresUser17User32 = ManhDist.CalculateImpostorScores(s017Mean, s032);
            sv.ImpostorScoresUser17User33 = ManhDist.CalculateImpostorScores(s017Mean, s033);
            sv.ImpostorScoresUser17User34 = ManhDist.CalculateImpostorScores(s017Mean, s034);
            sv.ImpostorScoresUser17User35 = ManhDist.CalculateImpostorScores(s017Mean, s035);
            sv.ImpostorScoresUser17User36 = ManhDist.CalculateImpostorScores(s017Mean, s036);
            sv.ImpostorScoresUser17User37 = ManhDist.CalculateImpostorScores(s017Mean, s037);
            sv.ImpostorScoresUser17User38 = ManhDist.CalculateImpostorScores(s017Mean, s038);
            sv.ImpostorScoresUser17User39 = ManhDist.CalculateImpostorScores(s017Mean, s039);
            sv.ImpostorScoresUser17User40 = ManhDist.CalculateImpostorScores(s017Mean, s040);

            sv.ImpostorScoresUser17User41 = ManhDist.CalculateImpostorScores(s017Mean, s041);
            sv.ImpostorScoresUser17User42 = ManhDist.CalculateImpostorScores(s017Mean, s042);
            sv.ImpostorScoresUser17User43 = ManhDist.CalculateImpostorScores(s017Mean, s043);
            sv.ImpostorScoresUser17User44 = ManhDist.CalculateImpostorScores(s017Mean, s044);
            sv.ImpostorScoresUser17User45 = ManhDist.CalculateImpostorScores(s017Mean, s045);
            sv.ImpostorScoresUser17User46 = ManhDist.CalculateImpostorScores(s017Mean, s046);
            sv.ImpostorScoresUser17User47 = ManhDist.CalculateImpostorScores(s017Mean, s047);
            sv.ImpostorScoresUser17User48 = ManhDist.CalculateImpostorScores(s017Mean, s048);
            sv.ImpostorScoresUser17User49 = ManhDist.CalculateImpostorScores(s017Mean, s049);
            sv.ImpostorScoresUser17User50 = ManhDist.CalculateImpostorScores(s017Mean, s050);

            sv.ImpostorScoresUser17User51 = ManhDist.CalculateImpostorScores(s017Mean, s051);
            sv.ImpostorScoresUser17User52 = ManhDist.CalculateImpostorScores(s017Mean, s052);
            sv.ImpostorScoresUser17User53 = ManhDist.CalculateImpostorScores(s017Mean, s053);
            sv.ImpostorScoresUser17User54 = ManhDist.CalculateImpostorScores(s017Mean, s054);
            sv.ImpostorScoresUser17User55 = ManhDist.CalculateImpostorScores(s017Mean, s055);
            sv.ImpostorScoresUser17User56 = ManhDist.CalculateImpostorScores(s017Mean, s056);
            sv.ImpostorScoresUser17User57 = ManhDist.CalculateImpostorScores(s017Mean, s057);
            sv.ImpostorScoresUser17User58 = ManhDist.CalculateImpostorScores(s017Mean, s058);
            sv.ImpostorScoresUser17User59 = ManhDist.CalculateImpostorScores(s017Mean, s059);
            sv.ImpostorScoresUser17User60 = ManhDist.CalculateImpostorScores(s017Mean, s060);

            sv.ImpostorScoresUser17User61 = ManhDist.CalculateImpostorScores(s017Mean, s061);
            sv.ImpostorScoresUser17User62 = ManhDist.CalculateImpostorScores(s017Mean, s062);
            sv.ImpostorScoresUser17User63 = ManhDist.CalculateImpostorScores(s017Mean, s063);
            sv.ImpostorScoresUser17User64 = ManhDist.CalculateImpostorScores(s017Mean, s064);
            sv.ImpostorScoresUser17User65 = ManhDist.CalculateImpostorScores(s017Mean, s065);
            sv.ImpostorScoresUser17User66 = ManhDist.CalculateImpostorScores(s017Mean, s066);
            sv.ImpostorScoresUser17User67 = ManhDist.CalculateImpostorScores(s017Mean, s067);
            sv.ImpostorScoresUser17User68 = ManhDist.CalculateImpostorScores(s017Mean, s068);
            sv.ImpostorScoresUser17User69 = ManhDist.CalculateImpostorScores(s017Mean, s069);
            sv.ImpostorScoresUser17User70 = ManhDist.CalculateImpostorScores(s017Mean, s070);

            sv.ImpostorScoresUser17User71 = ManhDist.CalculateImpostorScores(s017Mean, s071);
            sv.ImpostorScoresUser17User72 = ManhDist.CalculateImpostorScores(s017Mean, s072);
            sv.ImpostorScoresUser17User73 = ManhDist.CalculateImpostorScores(s017Mean, s073);
            sv.ImpostorScoresUser17User74 = ManhDist.CalculateImpostorScores(s017Mean, s074);
            sv.ImpostorScoresUser17User75 = ManhDist.CalculateImpostorScores(s017Mean, s075);
            sv.ImpostorScoresUser17User76 = ManhDist.CalculateImpostorScores(s017Mean, s076);
            sv.ImpostorScoresUser17User77 = ManhDist.CalculateImpostorScores(s017Mean, s077);
            sv.ImpostorScoresUser17User78 = ManhDist.CalculateImpostorScores(s017Mean, s078);
            sv.ImpostorScoresUser17User79 = ManhDist.CalculateImpostorScores(s017Mean, s079);
            sv.ImpostorScoresUser17User80 = ManhDist.CalculateImpostorScores(s017Mean, s080);

            sv.ImpostorScoresUser17User81 = ManhDist.CalculateImpostorScores(s017Mean, s081);
            sv.ImpostorScoresUser17User82 = ManhDist.CalculateImpostorScores(s017Mean, s082);
            sv.ImpostorScoresUser17User83 = ManhDist.CalculateImpostorScores(s017Mean, s083);
            sv.ImpostorScoresUser17User84 = ManhDist.CalculateImpostorScores(s017Mean, s084);
            sv.ImpostorScoresUser17User85 = ManhDist.CalculateImpostorScores(s017Mean, s085);
            sv.ImpostorScoresUser17User86 = ManhDist.CalculateImpostorScores(s017Mean, s086);
            sv.ImpostorScoresUser17User87 = ManhDist.CalculateImpostorScores(s017Mean, s087);
            sv.ImpostorScoresUser17User88 = ManhDist.CalculateImpostorScores(s017Mean, s088);
            sv.ImpostorScoresUser17User89 = ManhDist.CalculateImpostorScores(s017Mean, s089);
            sv.ImpostorScoresUser17User90 = ManhDist.CalculateImpostorScores(s017Mean, s090);

            sv.ImpostorScoresUser17User91 = ManhDist.CalculateImpostorScores(s017Mean, s091);
            sv.ImpostorScoresUser17User92 = ManhDist.CalculateImpostorScores(s017Mean, s092);
            sv.ImpostorScoresUser17User93 = ManhDist.CalculateImpostorScores(s017Mean, s093);
            sv.ImpostorScoresUser17User94 = ManhDist.CalculateImpostorScores(s017Mean, s094);
            sv.ImpostorScoresUser17User95 = ManhDist.CalculateImpostorScores(s017Mean, s095);
            sv.ImpostorScoresUser17User96 = ManhDist.CalculateImpostorScores(s017Mean, s096);
            sv.ImpostorScoresUser17User97 = ManhDist.CalculateImpostorScores(s017Mean, s097);
            sv.ImpostorScoresUser17User98 = ManhDist.CalculateImpostorScores(s017Mean, s098);
            sv.ImpostorScoresUser17User99 = ManhDist.CalculateImpostorScores(s017Mean, s099);
            sv.ImpostorScoresUser17User100 = ManhDist.CalculateImpostorScores(s017Mean, s100);
            #endregion

            #region User 18 Impostor scores
            sv.ImpostorScoresUser18User1 = ManhDist.CalculateImpostorScores(s018Mean, s001);
            sv.ImpostorScoresUser18User2 = ManhDist.CalculateImpostorScores(s018Mean, s002);
            sv.ImpostorScoresUser18User3 = ManhDist.CalculateImpostorScores(s018Mean, s003);
            sv.ImpostorScoresUser18User4 = ManhDist.CalculateImpostorScores(s018Mean, s004);
            sv.ImpostorScoresUser18User5 = ManhDist.CalculateImpostorScores(s018Mean, s005);
            sv.ImpostorScoresUser18User6 = ManhDist.CalculateImpostorScores(s018Mean, s006);
            sv.ImpostorScoresUser18User7 = ManhDist.CalculateImpostorScores(s018Mean, s007);
            sv.ImpostorScoresUser18User8 = ManhDist.CalculateImpostorScores(s018Mean, s008);
            sv.ImpostorScoresUser18User9 = ManhDist.CalculateImpostorScores(s018Mean, s009);
            sv.ImpostorScoresUser18User10 = ManhDist.CalculateImpostorScores(s018Mean, s010);

            sv.ImpostorScoresUser18User11 = ManhDist.CalculateImpostorScores(s018Mean, s011);
            sv.ImpostorScoresUser18User12 = ManhDist.CalculateImpostorScores(s018Mean, s012);
            sv.ImpostorScoresUser18User13 = ManhDist.CalculateImpostorScores(s018Mean, s013);
            sv.ImpostorScoresUser18User14 = ManhDist.CalculateImpostorScores(s018Mean, s014);
            sv.ImpostorScoresUser18User15 = ManhDist.CalculateImpostorScores(s018Mean, s015);
            sv.ImpostorScoresUser18User16 = ManhDist.CalculateImpostorScores(s018Mean, s016);
            sv.ImpostorScoresUser18User17 = ManhDist.CalculateImpostorScores(s018Mean, s017);
            sv.ImpostorScoresUser18User19 = ManhDist.CalculateImpostorScores(s018Mean, s019);
            sv.ImpostorScoresUser18User20 = ManhDist.CalculateImpostorScores(s018Mean, s020);

            sv.ImpostorScoresUser18User21 = ManhDist.CalculateImpostorScores(s018Mean, s021);
            sv.ImpostorScoresUser18User22 = ManhDist.CalculateImpostorScores(s018Mean, s022);
            sv.ImpostorScoresUser18User23 = ManhDist.CalculateImpostorScores(s018Mean, s023);
            sv.ImpostorScoresUser18User24 = ManhDist.CalculateImpostorScores(s018Mean, s024);
            sv.ImpostorScoresUser18User25 = ManhDist.CalculateImpostorScores(s018Mean, s025);
            sv.ImpostorScoresUser18User26 = ManhDist.CalculateImpostorScores(s018Mean, s026);
            sv.ImpostorScoresUser18User27 = ManhDist.CalculateImpostorScores(s018Mean, s027);
            sv.ImpostorScoresUser18User28 = ManhDist.CalculateImpostorScores(s018Mean, s028);
            sv.ImpostorScoresUser18User29 = ManhDist.CalculateImpostorScores(s018Mean, s029);
            sv.ImpostorScoresUser18User30 = ManhDist.CalculateImpostorScores(s018Mean, s030);

            sv.ImpostorScoresUser18User31 = ManhDist.CalculateImpostorScores(s018Mean, s031);
            sv.ImpostorScoresUser18User32 = ManhDist.CalculateImpostorScores(s018Mean, s032);
            sv.ImpostorScoresUser18User33 = ManhDist.CalculateImpostorScores(s018Mean, s033);
            sv.ImpostorScoresUser18User34 = ManhDist.CalculateImpostorScores(s018Mean, s034);
            sv.ImpostorScoresUser18User35 = ManhDist.CalculateImpostorScores(s018Mean, s035);
            sv.ImpostorScoresUser18User36 = ManhDist.CalculateImpostorScores(s018Mean, s036);
            sv.ImpostorScoresUser18User37 = ManhDist.CalculateImpostorScores(s018Mean, s037);
            sv.ImpostorScoresUser18User38 = ManhDist.CalculateImpostorScores(s018Mean, s038);
            sv.ImpostorScoresUser18User39 = ManhDist.CalculateImpostorScores(s018Mean, s039);
            sv.ImpostorScoresUser18User40 = ManhDist.CalculateImpostorScores(s018Mean, s040);

            sv.ImpostorScoresUser18User41 = ManhDist.CalculateImpostorScores(s018Mean, s041);
            sv.ImpostorScoresUser18User42 = ManhDist.CalculateImpostorScores(s018Mean, s042);
            sv.ImpostorScoresUser18User43 = ManhDist.CalculateImpostorScores(s018Mean, s043);
            sv.ImpostorScoresUser18User44 = ManhDist.CalculateImpostorScores(s018Mean, s044);
            sv.ImpostorScoresUser18User45 = ManhDist.CalculateImpostorScores(s018Mean, s045);
            sv.ImpostorScoresUser18User46 = ManhDist.CalculateImpostorScores(s018Mean, s046);
            sv.ImpostorScoresUser18User47 = ManhDist.CalculateImpostorScores(s018Mean, s047);
            sv.ImpostorScoresUser18User48 = ManhDist.CalculateImpostorScores(s018Mean, s048);
            sv.ImpostorScoresUser18User49 = ManhDist.CalculateImpostorScores(s018Mean, s049);
            sv.ImpostorScoresUser18User50 = ManhDist.CalculateImpostorScores(s018Mean, s050);

            sv.ImpostorScoresUser18User51 = ManhDist.CalculateImpostorScores(s018Mean, s051);
            sv.ImpostorScoresUser18User52 = ManhDist.CalculateImpostorScores(s018Mean, s052);
            sv.ImpostorScoresUser18User53 = ManhDist.CalculateImpostorScores(s018Mean, s053);
            sv.ImpostorScoresUser18User54 = ManhDist.CalculateImpostorScores(s018Mean, s054);
            sv.ImpostorScoresUser18User55 = ManhDist.CalculateImpostorScores(s018Mean, s055);
            sv.ImpostorScoresUser18User56 = ManhDist.CalculateImpostorScores(s018Mean, s056);
            sv.ImpostorScoresUser18User57 = ManhDist.CalculateImpostorScores(s018Mean, s057);
            sv.ImpostorScoresUser18User58 = ManhDist.CalculateImpostorScores(s018Mean, s058);
            sv.ImpostorScoresUser18User59 = ManhDist.CalculateImpostorScores(s018Mean, s059);
            sv.ImpostorScoresUser18User60 = ManhDist.CalculateImpostorScores(s018Mean, s060);

            sv.ImpostorScoresUser18User61 = ManhDist.CalculateImpostorScores(s018Mean, s061);
            sv.ImpostorScoresUser18User62 = ManhDist.CalculateImpostorScores(s018Mean, s062);
            sv.ImpostorScoresUser18User63 = ManhDist.CalculateImpostorScores(s018Mean, s063);
            sv.ImpostorScoresUser18User64 = ManhDist.CalculateImpostorScores(s018Mean, s064);
            sv.ImpostorScoresUser18User65 = ManhDist.CalculateImpostorScores(s018Mean, s065);
            sv.ImpostorScoresUser18User66 = ManhDist.CalculateImpostorScores(s018Mean, s066);
            sv.ImpostorScoresUser18User67 = ManhDist.CalculateImpostorScores(s018Mean, s067);
            sv.ImpostorScoresUser18User68 = ManhDist.CalculateImpostorScores(s018Mean, s068);
            sv.ImpostorScoresUser18User69 = ManhDist.CalculateImpostorScores(s018Mean, s069);
            sv.ImpostorScoresUser18User70 = ManhDist.CalculateImpostorScores(s018Mean, s070);

            sv.ImpostorScoresUser18User71 = ManhDist.CalculateImpostorScores(s018Mean, s071);
            sv.ImpostorScoresUser18User72 = ManhDist.CalculateImpostorScores(s018Mean, s072);
            sv.ImpostorScoresUser18User73 = ManhDist.CalculateImpostorScores(s018Mean, s073);
            sv.ImpostorScoresUser18User74 = ManhDist.CalculateImpostorScores(s018Mean, s074);
            sv.ImpostorScoresUser18User75 = ManhDist.CalculateImpostorScores(s018Mean, s075);
            sv.ImpostorScoresUser18User76 = ManhDist.CalculateImpostorScores(s018Mean, s076);
            sv.ImpostorScoresUser18User77 = ManhDist.CalculateImpostorScores(s018Mean, s077);
            sv.ImpostorScoresUser18User78 = ManhDist.CalculateImpostorScores(s018Mean, s078);
            sv.ImpostorScoresUser18User79 = ManhDist.CalculateImpostorScores(s018Mean, s079);
            sv.ImpostorScoresUser18User80 = ManhDist.CalculateImpostorScores(s018Mean, s080);

            sv.ImpostorScoresUser18User81 = ManhDist.CalculateImpostorScores(s018Mean, s081);
            sv.ImpostorScoresUser18User82 = ManhDist.CalculateImpostorScores(s018Mean, s082);
            sv.ImpostorScoresUser18User83 = ManhDist.CalculateImpostorScores(s018Mean, s083);
            sv.ImpostorScoresUser18User84 = ManhDist.CalculateImpostorScores(s018Mean, s084);
            sv.ImpostorScoresUser18User85 = ManhDist.CalculateImpostorScores(s018Mean, s085);
            sv.ImpostorScoresUser18User86 = ManhDist.CalculateImpostorScores(s018Mean, s086);
            sv.ImpostorScoresUser18User87 = ManhDist.CalculateImpostorScores(s018Mean, s087);
            sv.ImpostorScoresUser18User88 = ManhDist.CalculateImpostorScores(s018Mean, s088);
            sv.ImpostorScoresUser18User89 = ManhDist.CalculateImpostorScores(s018Mean, s089);
            sv.ImpostorScoresUser18User90 = ManhDist.CalculateImpostorScores(s018Mean, s090);

            sv.ImpostorScoresUser18User91 = ManhDist.CalculateImpostorScores(s018Mean, s091);
            sv.ImpostorScoresUser18User92 = ManhDist.CalculateImpostorScores(s018Mean, s092);
            sv.ImpostorScoresUser18User93 = ManhDist.CalculateImpostorScores(s018Mean, s093);
            sv.ImpostorScoresUser18User94 = ManhDist.CalculateImpostorScores(s018Mean, s094);
            sv.ImpostorScoresUser18User95 = ManhDist.CalculateImpostorScores(s018Mean, s095);
            sv.ImpostorScoresUser18User96 = ManhDist.CalculateImpostorScores(s018Mean, s096);
            sv.ImpostorScoresUser18User97 = ManhDist.CalculateImpostorScores(s018Mean, s097);
            sv.ImpostorScoresUser18User98 = ManhDist.CalculateImpostorScores(s018Mean, s098);
            sv.ImpostorScoresUser18User99 = ManhDist.CalculateImpostorScores(s018Mean, s099);
            sv.ImpostorScoresUser18User100 = ManhDist.CalculateImpostorScores(s018Mean, s100);
            #endregion

            #region User 19 Impostor scores
            sv.ImpostorScoresUser19User1 = ManhDist.CalculateImpostorScores(s019Mean, s001);
            sv.ImpostorScoresUser19User2 = ManhDist.CalculateImpostorScores(s019Mean, s002);
            sv.ImpostorScoresUser19User3 = ManhDist.CalculateImpostorScores(s019Mean, s003);
            sv.ImpostorScoresUser19User4 = ManhDist.CalculateImpostorScores(s019Mean, s004);
            sv.ImpostorScoresUser19User5 = ManhDist.CalculateImpostorScores(s019Mean, s005);
            sv.ImpostorScoresUser19User6 = ManhDist.CalculateImpostorScores(s019Mean, s006);
            sv.ImpostorScoresUser19User7 = ManhDist.CalculateImpostorScores(s019Mean, s007);
            sv.ImpostorScoresUser19User8 = ManhDist.CalculateImpostorScores(s019Mean, s008);
            sv.ImpostorScoresUser19User9 = ManhDist.CalculateImpostorScores(s019Mean, s009);
            sv.ImpostorScoresUser19User10 = ManhDist.CalculateImpostorScores(s019Mean, s010);

            sv.ImpostorScoresUser19User11 = ManhDist.CalculateImpostorScores(s019Mean, s011);
            sv.ImpostorScoresUser19User12 = ManhDist.CalculateImpostorScores(s019Mean, s012);
            sv.ImpostorScoresUser19User13 = ManhDist.CalculateImpostorScores(s019Mean, s013);
            sv.ImpostorScoresUser19User14 = ManhDist.CalculateImpostorScores(s019Mean, s014);
            sv.ImpostorScoresUser19User15 = ManhDist.CalculateImpostorScores(s019Mean, s015);
            sv.ImpostorScoresUser19User16 = ManhDist.CalculateImpostorScores(s019Mean, s016);
            sv.ImpostorScoresUser19User17 = ManhDist.CalculateImpostorScores(s019Mean, s017);
            sv.ImpostorScoresUser19User18 = ManhDist.CalculateImpostorScores(s019Mean, s018);
            sv.ImpostorScoresUser19User20 = ManhDist.CalculateImpostorScores(s019Mean, s020);

            sv.ImpostorScoresUser19User21 = ManhDist.CalculateImpostorScores(s019Mean, s021);
            sv.ImpostorScoresUser19User22 = ManhDist.CalculateImpostorScores(s019Mean, s022);
            sv.ImpostorScoresUser19User23 = ManhDist.CalculateImpostorScores(s019Mean, s023);
            sv.ImpostorScoresUser19User24 = ManhDist.CalculateImpostorScores(s019Mean, s024);
            sv.ImpostorScoresUser19User25 = ManhDist.CalculateImpostorScores(s019Mean, s025);
            sv.ImpostorScoresUser19User26 = ManhDist.CalculateImpostorScores(s019Mean, s026);
            sv.ImpostorScoresUser19User27 = ManhDist.CalculateImpostorScores(s019Mean, s027);
            sv.ImpostorScoresUser19User28 = ManhDist.CalculateImpostorScores(s019Mean, s028);
            sv.ImpostorScoresUser19User29 = ManhDist.CalculateImpostorScores(s019Mean, s029);
            sv.ImpostorScoresUser19User30 = ManhDist.CalculateImpostorScores(s019Mean, s030);

            sv.ImpostorScoresUser19User31 = ManhDist.CalculateImpostorScores(s019Mean, s031);
            sv.ImpostorScoresUser19User32 = ManhDist.CalculateImpostorScores(s019Mean, s032);
            sv.ImpostorScoresUser19User33 = ManhDist.CalculateImpostorScores(s019Mean, s033);
            sv.ImpostorScoresUser19User34 = ManhDist.CalculateImpostorScores(s019Mean, s034);
            sv.ImpostorScoresUser19User35 = ManhDist.CalculateImpostorScores(s019Mean, s035);
            sv.ImpostorScoresUser19User36 = ManhDist.CalculateImpostorScores(s019Mean, s036);
            sv.ImpostorScoresUser19User37 = ManhDist.CalculateImpostorScores(s019Mean, s037);
            sv.ImpostorScoresUser19User38 = ManhDist.CalculateImpostorScores(s019Mean, s038);
            sv.ImpostorScoresUser19User39 = ManhDist.CalculateImpostorScores(s019Mean, s039);
            sv.ImpostorScoresUser19User40 = ManhDist.CalculateImpostorScores(s019Mean, s040);

            sv.ImpostorScoresUser19User41 = ManhDist.CalculateImpostorScores(s019Mean, s041);
            sv.ImpostorScoresUser19User42 = ManhDist.CalculateImpostorScores(s019Mean, s042);
            sv.ImpostorScoresUser19User43 = ManhDist.CalculateImpostorScores(s019Mean, s043);
            sv.ImpostorScoresUser19User44 = ManhDist.CalculateImpostorScores(s019Mean, s044);
            sv.ImpostorScoresUser19User45 = ManhDist.CalculateImpostorScores(s019Mean, s045);
            sv.ImpostorScoresUser19User46 = ManhDist.CalculateImpostorScores(s019Mean, s046);
            sv.ImpostorScoresUser19User47 = ManhDist.CalculateImpostorScores(s019Mean, s047);
            sv.ImpostorScoresUser19User48 = ManhDist.CalculateImpostorScores(s019Mean, s048);
            sv.ImpostorScoresUser19User49 = ManhDist.CalculateImpostorScores(s019Mean, s049);
            sv.ImpostorScoresUser19User50 = ManhDist.CalculateImpostorScores(s019Mean, s050);

            sv.ImpostorScoresUser19User51 = ManhDist.CalculateImpostorScores(s019Mean, s051);
            sv.ImpostorScoresUser19User52 = ManhDist.CalculateImpostorScores(s019Mean, s052);
            sv.ImpostorScoresUser19User53 = ManhDist.CalculateImpostorScores(s019Mean, s053);
            sv.ImpostorScoresUser19User54 = ManhDist.CalculateImpostorScores(s019Mean, s054);
            sv.ImpostorScoresUser19User55 = ManhDist.CalculateImpostorScores(s019Mean, s055);
            sv.ImpostorScoresUser19User56 = ManhDist.CalculateImpostorScores(s019Mean, s056);
            sv.ImpostorScoresUser19User57 = ManhDist.CalculateImpostorScores(s019Mean, s057);
            sv.ImpostorScoresUser19User58 = ManhDist.CalculateImpostorScores(s019Mean, s058);
            sv.ImpostorScoresUser19User59 = ManhDist.CalculateImpostorScores(s019Mean, s059);
            sv.ImpostorScoresUser19User60 = ManhDist.CalculateImpostorScores(s019Mean, s060);

            sv.ImpostorScoresUser19User61 = ManhDist.CalculateImpostorScores(s019Mean, s061);
            sv.ImpostorScoresUser19User62 = ManhDist.CalculateImpostorScores(s019Mean, s062);
            sv.ImpostorScoresUser19User63 = ManhDist.CalculateImpostorScores(s019Mean, s063);
            sv.ImpostorScoresUser19User64 = ManhDist.CalculateImpostorScores(s019Mean, s064);
            sv.ImpostorScoresUser19User65 = ManhDist.CalculateImpostorScores(s019Mean, s065);
            sv.ImpostorScoresUser19User66 = ManhDist.CalculateImpostorScores(s019Mean, s066);
            sv.ImpostorScoresUser19User67 = ManhDist.CalculateImpostorScores(s019Mean, s067);
            sv.ImpostorScoresUser19User68 = ManhDist.CalculateImpostorScores(s019Mean, s068);
            sv.ImpostorScoresUser19User69 = ManhDist.CalculateImpostorScores(s019Mean, s069);
            sv.ImpostorScoresUser19User70 = ManhDist.CalculateImpostorScores(s019Mean, s070);

            sv.ImpostorScoresUser19User71 = ManhDist.CalculateImpostorScores(s019Mean, s071);
            sv.ImpostorScoresUser19User72 = ManhDist.CalculateImpostorScores(s019Mean, s072);
            sv.ImpostorScoresUser19User73 = ManhDist.CalculateImpostorScores(s019Mean, s073);
            sv.ImpostorScoresUser19User74 = ManhDist.CalculateImpostorScores(s019Mean, s074);
            sv.ImpostorScoresUser19User75 = ManhDist.CalculateImpostorScores(s019Mean, s075);
            sv.ImpostorScoresUser19User76 = ManhDist.CalculateImpostorScores(s019Mean, s076);
            sv.ImpostorScoresUser19User77 = ManhDist.CalculateImpostorScores(s019Mean, s077);
            sv.ImpostorScoresUser19User78 = ManhDist.CalculateImpostorScores(s019Mean, s078);
            sv.ImpostorScoresUser19User79 = ManhDist.CalculateImpostorScores(s019Mean, s079);
            sv.ImpostorScoresUser19User80 = ManhDist.CalculateImpostorScores(s019Mean, s080);

            sv.ImpostorScoresUser19User81 = ManhDist.CalculateImpostorScores(s019Mean, s081);
            sv.ImpostorScoresUser19User82 = ManhDist.CalculateImpostorScores(s019Mean, s082);
            sv.ImpostorScoresUser19User83 = ManhDist.CalculateImpostorScores(s019Mean, s083);
            sv.ImpostorScoresUser19User84 = ManhDist.CalculateImpostorScores(s019Mean, s084);
            sv.ImpostorScoresUser19User85 = ManhDist.CalculateImpostorScores(s019Mean, s085);
            sv.ImpostorScoresUser19User86 = ManhDist.CalculateImpostorScores(s019Mean, s086);
            sv.ImpostorScoresUser19User87 = ManhDist.CalculateImpostorScores(s019Mean, s087);
            sv.ImpostorScoresUser19User88 = ManhDist.CalculateImpostorScores(s019Mean, s088);
            sv.ImpostorScoresUser19User89 = ManhDist.CalculateImpostorScores(s019Mean, s089);
            sv.ImpostorScoresUser19User90 = ManhDist.CalculateImpostorScores(s019Mean, s090);

            sv.ImpostorScoresUser19User91 = ManhDist.CalculateImpostorScores(s019Mean, s091);
            sv.ImpostorScoresUser19User92 = ManhDist.CalculateImpostorScores(s019Mean, s092);
            sv.ImpostorScoresUser19User93 = ManhDist.CalculateImpostorScores(s019Mean, s093);
            sv.ImpostorScoresUser19User94 = ManhDist.CalculateImpostorScores(s019Mean, s094);
            sv.ImpostorScoresUser19User95 = ManhDist.CalculateImpostorScores(s019Mean, s095);
            sv.ImpostorScoresUser19User96 = ManhDist.CalculateImpostorScores(s019Mean, s096);
            sv.ImpostorScoresUser19User97 = ManhDist.CalculateImpostorScores(s019Mean, s097);
            sv.ImpostorScoresUser19User98 = ManhDist.CalculateImpostorScores(s019Mean, s098);
            sv.ImpostorScoresUser19User99 = ManhDist.CalculateImpostorScores(s019Mean, s099);
            sv.ImpostorScoresUser19User100 = ManhDist.CalculateImpostorScores(s019Mean, s100);
            #endregion

            #region User 20 Impostor scores
            sv.ImpostorScoresUser20User1 = ManhDist.CalculateImpostorScores(s020Mean, s001);
            sv.ImpostorScoresUser20User2 = ManhDist.CalculateImpostorScores(s020Mean, s002);
            sv.ImpostorScoresUser20User3 = ManhDist.CalculateImpostorScores(s020Mean, s003);
            sv.ImpostorScoresUser20User4 = ManhDist.CalculateImpostorScores(s020Mean, s004);
            sv.ImpostorScoresUser20User5 = ManhDist.CalculateImpostorScores(s020Mean, s005);
            sv.ImpostorScoresUser20User6 = ManhDist.CalculateImpostorScores(s020Mean, s006);
            sv.ImpostorScoresUser20User7 = ManhDist.CalculateImpostorScores(s020Mean, s007);
            sv.ImpostorScoresUser20User8 = ManhDist.CalculateImpostorScores(s020Mean, s008);
            sv.ImpostorScoresUser20User9 = ManhDist.CalculateImpostorScores(s020Mean, s009);
            sv.ImpostorScoresUser20User10 = ManhDist.CalculateImpostorScores(s020Mean, s010);

            sv.ImpostorScoresUser20User11 = ManhDist.CalculateImpostorScores(s020Mean, s011);
            sv.ImpostorScoresUser20User12 = ManhDist.CalculateImpostorScores(s020Mean, s012);
            sv.ImpostorScoresUser20User13 = ManhDist.CalculateImpostorScores(s020Mean, s013);
            sv.ImpostorScoresUser20User14 = ManhDist.CalculateImpostorScores(s020Mean, s014);
            sv.ImpostorScoresUser20User15 = ManhDist.CalculateImpostorScores(s020Mean, s015);
            sv.ImpostorScoresUser20User16 = ManhDist.CalculateImpostorScores(s020Mean, s016);
            sv.ImpostorScoresUser20User17 = ManhDist.CalculateImpostorScores(s020Mean, s017);
            sv.ImpostorScoresUser20User18 = ManhDist.CalculateImpostorScores(s020Mean, s018);
            sv.ImpostorScoresUser20User19 = ManhDist.CalculateImpostorScores(s020Mean, s019);

            sv.ImpostorScoresUser20User21 = ManhDist.CalculateImpostorScores(s020Mean, s021);
            sv.ImpostorScoresUser20User22 = ManhDist.CalculateImpostorScores(s020Mean, s022);
            sv.ImpostorScoresUser20User23 = ManhDist.CalculateImpostorScores(s020Mean, s023);
            sv.ImpostorScoresUser20User24 = ManhDist.CalculateImpostorScores(s020Mean, s024);
            sv.ImpostorScoresUser20User25 = ManhDist.CalculateImpostorScores(s020Mean, s025);
            sv.ImpostorScoresUser20User26 = ManhDist.CalculateImpostorScores(s020Mean, s026);
            sv.ImpostorScoresUser20User27 = ManhDist.CalculateImpostorScores(s020Mean, s027);
            sv.ImpostorScoresUser20User28 = ManhDist.CalculateImpostorScores(s020Mean, s028);
            sv.ImpostorScoresUser20User29 = ManhDist.CalculateImpostorScores(s020Mean, s029);
            sv.ImpostorScoresUser20User30 = ManhDist.CalculateImpostorScores(s020Mean, s030);

            sv.ImpostorScoresUser20User31 = ManhDist.CalculateImpostorScores(s020Mean, s031);
            sv.ImpostorScoresUser20User32 = ManhDist.CalculateImpostorScores(s020Mean, s032);
            sv.ImpostorScoresUser20User33 = ManhDist.CalculateImpostorScores(s020Mean, s033);
            sv.ImpostorScoresUser20User34 = ManhDist.CalculateImpostorScores(s020Mean, s034);
            sv.ImpostorScoresUser20User35 = ManhDist.CalculateImpostorScores(s020Mean, s035);
            sv.ImpostorScoresUser20User36 = ManhDist.CalculateImpostorScores(s020Mean, s036);
            sv.ImpostorScoresUser20User37 = ManhDist.CalculateImpostorScores(s020Mean, s037);
            sv.ImpostorScoresUser20User38 = ManhDist.CalculateImpostorScores(s020Mean, s038);
            sv.ImpostorScoresUser20User39 = ManhDist.CalculateImpostorScores(s020Mean, s039);
            sv.ImpostorScoresUser20User40 = ManhDist.CalculateImpostorScores(s020Mean, s040);

            sv.ImpostorScoresUser20User41 = ManhDist.CalculateImpostorScores(s020Mean, s041);
            sv.ImpostorScoresUser20User42 = ManhDist.CalculateImpostorScores(s020Mean, s042);
            sv.ImpostorScoresUser20User43 = ManhDist.CalculateImpostorScores(s020Mean, s043);
            sv.ImpostorScoresUser20User44 = ManhDist.CalculateImpostorScores(s020Mean, s044);
            sv.ImpostorScoresUser20User45 = ManhDist.CalculateImpostorScores(s020Mean, s045);
            sv.ImpostorScoresUser20User46 = ManhDist.CalculateImpostorScores(s020Mean, s046);
            sv.ImpostorScoresUser20User47 = ManhDist.CalculateImpostorScores(s020Mean, s047);
            sv.ImpostorScoresUser20User48 = ManhDist.CalculateImpostorScores(s020Mean, s048);
            sv.ImpostorScoresUser20User49 = ManhDist.CalculateImpostorScores(s020Mean, s049);
            sv.ImpostorScoresUser20User50 = ManhDist.CalculateImpostorScores(s020Mean, s050);

            sv.ImpostorScoresUser20User51 = ManhDist.CalculateImpostorScores(s020Mean, s051);
            sv.ImpostorScoresUser20User52 = ManhDist.CalculateImpostorScores(s020Mean, s052);
            sv.ImpostorScoresUser20User53 = ManhDist.CalculateImpostorScores(s020Mean, s053);
            sv.ImpostorScoresUser20User54 = ManhDist.CalculateImpostorScores(s020Mean, s054);
            sv.ImpostorScoresUser20User55 = ManhDist.CalculateImpostorScores(s020Mean, s055);
            sv.ImpostorScoresUser20User56 = ManhDist.CalculateImpostorScores(s020Mean, s056);
            sv.ImpostorScoresUser20User57 = ManhDist.CalculateImpostorScores(s020Mean, s057);
            sv.ImpostorScoresUser20User58 = ManhDist.CalculateImpostorScores(s020Mean, s058);
            sv.ImpostorScoresUser20User59 = ManhDist.CalculateImpostorScores(s020Mean, s059);
            sv.ImpostorScoresUser20User60 = ManhDist.CalculateImpostorScores(s020Mean, s060);

            sv.ImpostorScoresUser20User61 = ManhDist.CalculateImpostorScores(s020Mean, s061);
            sv.ImpostorScoresUser20User62 = ManhDist.CalculateImpostorScores(s020Mean, s062);
            sv.ImpostorScoresUser20User63 = ManhDist.CalculateImpostorScores(s020Mean, s063);
            sv.ImpostorScoresUser20User64 = ManhDist.CalculateImpostorScores(s020Mean, s064);
            sv.ImpostorScoresUser20User65 = ManhDist.CalculateImpostorScores(s020Mean, s065);
            sv.ImpostorScoresUser20User66 = ManhDist.CalculateImpostorScores(s020Mean, s066);
            sv.ImpostorScoresUser20User67 = ManhDist.CalculateImpostorScores(s020Mean, s067);
            sv.ImpostorScoresUser20User68 = ManhDist.CalculateImpostorScores(s020Mean, s068);
            sv.ImpostorScoresUser20User69 = ManhDist.CalculateImpostorScores(s020Mean, s069);
            sv.ImpostorScoresUser20User70 = ManhDist.CalculateImpostorScores(s020Mean, s070);

            sv.ImpostorScoresUser20User71 = ManhDist.CalculateImpostorScores(s020Mean, s071);
            sv.ImpostorScoresUser20User72 = ManhDist.CalculateImpostorScores(s020Mean, s072);
            sv.ImpostorScoresUser20User73 = ManhDist.CalculateImpostorScores(s020Mean, s073);
            sv.ImpostorScoresUser20User74 = ManhDist.CalculateImpostorScores(s020Mean, s074);
            sv.ImpostorScoresUser20User75 = ManhDist.CalculateImpostorScores(s020Mean, s075);
            sv.ImpostorScoresUser20User76 = ManhDist.CalculateImpostorScores(s020Mean, s076);
            sv.ImpostorScoresUser20User77 = ManhDist.CalculateImpostorScores(s020Mean, s077);
            sv.ImpostorScoresUser20User78 = ManhDist.CalculateImpostorScores(s020Mean, s078);
            sv.ImpostorScoresUser20User79 = ManhDist.CalculateImpostorScores(s020Mean, s079);
            sv.ImpostorScoresUser20User80 = ManhDist.CalculateImpostorScores(s020Mean, s080);

            sv.ImpostorScoresUser20User81 = ManhDist.CalculateImpostorScores(s020Mean, s081);
            sv.ImpostorScoresUser20User82 = ManhDist.CalculateImpostorScores(s020Mean, s082);
            sv.ImpostorScoresUser20User83 = ManhDist.CalculateImpostorScores(s020Mean, s083);
            sv.ImpostorScoresUser20User84 = ManhDist.CalculateImpostorScores(s020Mean, s084);
            sv.ImpostorScoresUser20User85 = ManhDist.CalculateImpostorScores(s020Mean, s085);
            sv.ImpostorScoresUser20User86 = ManhDist.CalculateImpostorScores(s020Mean, s086);
            sv.ImpostorScoresUser20User87 = ManhDist.CalculateImpostorScores(s020Mean, s087);
            sv.ImpostorScoresUser20User88 = ManhDist.CalculateImpostorScores(s020Mean, s088);
            sv.ImpostorScoresUser20User89 = ManhDist.CalculateImpostorScores(s020Mean, s089);
            sv.ImpostorScoresUser20User90 = ManhDist.CalculateImpostorScores(s020Mean, s090);

            sv.ImpostorScoresUser20User91 = ManhDist.CalculateImpostorScores(s020Mean, s091);
            sv.ImpostorScoresUser20User92 = ManhDist.CalculateImpostorScores(s020Mean, s092);
            sv.ImpostorScoresUser20User93 = ManhDist.CalculateImpostorScores(s020Mean, s093);
            sv.ImpostorScoresUser20User94 = ManhDist.CalculateImpostorScores(s020Mean, s094);
            sv.ImpostorScoresUser20User95 = ManhDist.CalculateImpostorScores(s020Mean, s095);
            sv.ImpostorScoresUser20User96 = ManhDist.CalculateImpostorScores(s020Mean, s096);
            sv.ImpostorScoresUser20User97 = ManhDist.CalculateImpostorScores(s020Mean, s097);
            sv.ImpostorScoresUser20User98 = ManhDist.CalculateImpostorScores(s020Mean, s098);
            sv.ImpostorScoresUser20User99 = ManhDist.CalculateImpostorScores(s020Mean, s099);
            sv.ImpostorScoresUser20User100 = ManhDist.CalculateImpostorScores(s020Mean, s100);
            #endregion

            #region User 21 Impostor scores
            sv.ImpostorScoresUser21User1 = ManhDist.CalculateImpostorScores(s021Mean, s001);
            sv.ImpostorScoresUser21User2 = ManhDist.CalculateImpostorScores(s021Mean, s002);
            sv.ImpostorScoresUser21User3 = ManhDist.CalculateImpostorScores(s021Mean, s003);
            sv.ImpostorScoresUser21User4 = ManhDist.CalculateImpostorScores(s021Mean, s004);
            sv.ImpostorScoresUser21User5 = ManhDist.CalculateImpostorScores(s021Mean, s005);
            sv.ImpostorScoresUser21User6 = ManhDist.CalculateImpostorScores(s021Mean, s006);
            sv.ImpostorScoresUser21User7 = ManhDist.CalculateImpostorScores(s021Mean, s007);
            sv.ImpostorScoresUser21User8 = ManhDist.CalculateImpostorScores(s021Mean, s008);
            sv.ImpostorScoresUser21User9 = ManhDist.CalculateImpostorScores(s021Mean, s009);
            sv.ImpostorScoresUser21User10 = ManhDist.CalculateImpostorScores(s021Mean, s010);

            sv.ImpostorScoresUser21User11 = ManhDist.CalculateImpostorScores(s021Mean, s011);
            sv.ImpostorScoresUser21User12 = ManhDist.CalculateImpostorScores(s021Mean, s012);
            sv.ImpostorScoresUser21User13 = ManhDist.CalculateImpostorScores(s021Mean, s013);
            sv.ImpostorScoresUser21User14 = ManhDist.CalculateImpostorScores(s021Mean, s014);
            sv.ImpostorScoresUser21User15 = ManhDist.CalculateImpostorScores(s021Mean, s015);
            sv.ImpostorScoresUser21User16 = ManhDist.CalculateImpostorScores(s021Mean, s016);
            sv.ImpostorScoresUser21User17 = ManhDist.CalculateImpostorScores(s021Mean, s017);
            sv.ImpostorScoresUser21User18 = ManhDist.CalculateImpostorScores(s021Mean, s018);
            sv.ImpostorScoresUser21User19 = ManhDist.CalculateImpostorScores(s021Mean, s019);
            sv.ImpostorScoresUser21User20 = ManhDist.CalculateImpostorScores(s021Mean, s020);

            sv.ImpostorScoresUser21User22 = ManhDist.CalculateImpostorScores(s021Mean, s022);
            sv.ImpostorScoresUser21User23 = ManhDist.CalculateImpostorScores(s021Mean, s023);
            sv.ImpostorScoresUser21User24 = ManhDist.CalculateImpostorScores(s021Mean, s024);
            sv.ImpostorScoresUser21User25 = ManhDist.CalculateImpostorScores(s021Mean, s025);
            sv.ImpostorScoresUser21User26 = ManhDist.CalculateImpostorScores(s021Mean, s026);
            sv.ImpostorScoresUser21User27 = ManhDist.CalculateImpostorScores(s021Mean, s027);
            sv.ImpostorScoresUser21User28 = ManhDist.CalculateImpostorScores(s021Mean, s028);
            sv.ImpostorScoresUser21User29 = ManhDist.CalculateImpostorScores(s021Mean, s029);
            sv.ImpostorScoresUser21User30 = ManhDist.CalculateImpostorScores(s021Mean, s030);

            sv.ImpostorScoresUser21User31 = ManhDist.CalculateImpostorScores(s021Mean, s031);
            sv.ImpostorScoresUser21User32 = ManhDist.CalculateImpostorScores(s021Mean, s032);
            sv.ImpostorScoresUser21User33 = ManhDist.CalculateImpostorScores(s021Mean, s033);
            sv.ImpostorScoresUser21User34 = ManhDist.CalculateImpostorScores(s021Mean, s034);
            sv.ImpostorScoresUser21User35 = ManhDist.CalculateImpostorScores(s021Mean, s035);
            sv.ImpostorScoresUser21User36 = ManhDist.CalculateImpostorScores(s021Mean, s036);
            sv.ImpostorScoresUser21User37 = ManhDist.CalculateImpostorScores(s021Mean, s037);
            sv.ImpostorScoresUser21User38 = ManhDist.CalculateImpostorScores(s021Mean, s038);
            sv.ImpostorScoresUser21User39 = ManhDist.CalculateImpostorScores(s021Mean, s039);
            sv.ImpostorScoresUser21User40 = ManhDist.CalculateImpostorScores(s021Mean, s040);

            sv.ImpostorScoresUser21User41 = ManhDist.CalculateImpostorScores(s021Mean, s041);
            sv.ImpostorScoresUser21User42 = ManhDist.CalculateImpostorScores(s021Mean, s042);
            sv.ImpostorScoresUser21User43 = ManhDist.CalculateImpostorScores(s021Mean, s043);
            sv.ImpostorScoresUser21User44 = ManhDist.CalculateImpostorScores(s021Mean, s044);
            sv.ImpostorScoresUser21User45 = ManhDist.CalculateImpostorScores(s021Mean, s045);
            sv.ImpostorScoresUser21User46 = ManhDist.CalculateImpostorScores(s021Mean, s046);
            sv.ImpostorScoresUser21User47 = ManhDist.CalculateImpostorScores(s021Mean, s047);
            sv.ImpostorScoresUser21User48 = ManhDist.CalculateImpostorScores(s021Mean, s048);
            sv.ImpostorScoresUser21User49 = ManhDist.CalculateImpostorScores(s021Mean, s049);
            sv.ImpostorScoresUser21User50 = ManhDist.CalculateImpostorScores(s021Mean, s050);

            sv.ImpostorScoresUser21User51 = ManhDist.CalculateImpostorScores(s021Mean, s051);
            sv.ImpostorScoresUser21User52 = ManhDist.CalculateImpostorScores(s021Mean, s052);
            sv.ImpostorScoresUser21User53 = ManhDist.CalculateImpostorScores(s021Mean, s053);
            sv.ImpostorScoresUser21User54 = ManhDist.CalculateImpostorScores(s021Mean, s054);
            sv.ImpostorScoresUser21User55 = ManhDist.CalculateImpostorScores(s021Mean, s055);
            sv.ImpostorScoresUser21User56 = ManhDist.CalculateImpostorScores(s021Mean, s056);
            sv.ImpostorScoresUser21User57 = ManhDist.CalculateImpostorScores(s021Mean, s057);
            sv.ImpostorScoresUser21User58 = ManhDist.CalculateImpostorScores(s021Mean, s058);
            sv.ImpostorScoresUser21User59 = ManhDist.CalculateImpostorScores(s021Mean, s059);
            sv.ImpostorScoresUser21User60 = ManhDist.CalculateImpostorScores(s021Mean, s060);

            sv.ImpostorScoresUser21User61 = ManhDist.CalculateImpostorScores(s021Mean, s061);
            sv.ImpostorScoresUser21User62 = ManhDist.CalculateImpostorScores(s021Mean, s062);
            sv.ImpostorScoresUser21User63 = ManhDist.CalculateImpostorScores(s021Mean, s063);
            sv.ImpostorScoresUser21User64 = ManhDist.CalculateImpostorScores(s021Mean, s064);
            sv.ImpostorScoresUser21User65 = ManhDist.CalculateImpostorScores(s021Mean, s065);
            sv.ImpostorScoresUser21User66 = ManhDist.CalculateImpostorScores(s021Mean, s066);
            sv.ImpostorScoresUser21User67 = ManhDist.CalculateImpostorScores(s021Mean, s067);
            sv.ImpostorScoresUser21User68 = ManhDist.CalculateImpostorScores(s021Mean, s068);
            sv.ImpostorScoresUser21User69 = ManhDist.CalculateImpostorScores(s021Mean, s069);
            sv.ImpostorScoresUser21User70 = ManhDist.CalculateImpostorScores(s021Mean, s070);

            sv.ImpostorScoresUser21User71 = ManhDist.CalculateImpostorScores(s021Mean, s071);
            sv.ImpostorScoresUser21User72 = ManhDist.CalculateImpostorScores(s021Mean, s072);
            sv.ImpostorScoresUser21User73 = ManhDist.CalculateImpostorScores(s021Mean, s073);
            sv.ImpostorScoresUser21User74 = ManhDist.CalculateImpostorScores(s021Mean, s074);
            sv.ImpostorScoresUser21User75 = ManhDist.CalculateImpostorScores(s021Mean, s075);
            sv.ImpostorScoresUser21User76 = ManhDist.CalculateImpostorScores(s021Mean, s076);
            sv.ImpostorScoresUser21User77 = ManhDist.CalculateImpostorScores(s021Mean, s077);
            sv.ImpostorScoresUser21User78 = ManhDist.CalculateImpostorScores(s021Mean, s078);
            sv.ImpostorScoresUser21User79 = ManhDist.CalculateImpostorScores(s021Mean, s079);
            sv.ImpostorScoresUser21User80 = ManhDist.CalculateImpostorScores(s021Mean, s080);

            sv.ImpostorScoresUser21User81 = ManhDist.CalculateImpostorScores(s021Mean, s081);
            sv.ImpostorScoresUser21User82 = ManhDist.CalculateImpostorScores(s021Mean, s082);
            sv.ImpostorScoresUser21User83 = ManhDist.CalculateImpostorScores(s021Mean, s083);
            sv.ImpostorScoresUser21User84 = ManhDist.CalculateImpostorScores(s021Mean, s084);
            sv.ImpostorScoresUser21User85 = ManhDist.CalculateImpostorScores(s021Mean, s085);
            sv.ImpostorScoresUser21User86 = ManhDist.CalculateImpostorScores(s021Mean, s086);
            sv.ImpostorScoresUser21User87 = ManhDist.CalculateImpostorScores(s021Mean, s087);
            sv.ImpostorScoresUser21User88 = ManhDist.CalculateImpostorScores(s021Mean, s088);
            sv.ImpostorScoresUser21User89 = ManhDist.CalculateImpostorScores(s021Mean, s089);
            sv.ImpostorScoresUser21User90 = ManhDist.CalculateImpostorScores(s021Mean, s090);

            sv.ImpostorScoresUser21User91 = ManhDist.CalculateImpostorScores(s021Mean, s091);
            sv.ImpostorScoresUser21User92 = ManhDist.CalculateImpostorScores(s021Mean, s092);
            sv.ImpostorScoresUser21User93 = ManhDist.CalculateImpostorScores(s021Mean, s093);
            sv.ImpostorScoresUser21User94 = ManhDist.CalculateImpostorScores(s021Mean, s094);
            sv.ImpostorScoresUser21User95 = ManhDist.CalculateImpostorScores(s021Mean, s095);
            sv.ImpostorScoresUser21User96 = ManhDist.CalculateImpostorScores(s021Mean, s096);
            sv.ImpostorScoresUser21User97 = ManhDist.CalculateImpostorScores(s021Mean, s097);
            sv.ImpostorScoresUser21User98 = ManhDist.CalculateImpostorScores(s021Mean, s098);
            sv.ImpostorScoresUser21User99 = ManhDist.CalculateImpostorScores(s021Mean, s099);
            sv.ImpostorScoresUser21User100 = ManhDist.CalculateImpostorScores(s021Mean, s100);
            #endregion

            #region User 22 Impostor scores
            sv.ImpostorScoresUser22User1 = ManhDist.CalculateImpostorScores(s022Mean, s001);
            sv.ImpostorScoresUser22User2 = ManhDist.CalculateImpostorScores(s022Mean, s002);
            sv.ImpostorScoresUser22User3 = ManhDist.CalculateImpostorScores(s022Mean, s003);
            sv.ImpostorScoresUser22User4 = ManhDist.CalculateImpostorScores(s022Mean, s004);
            sv.ImpostorScoresUser22User5 = ManhDist.CalculateImpostorScores(s022Mean, s005);
            sv.ImpostorScoresUser22User6 = ManhDist.CalculateImpostorScores(s022Mean, s006);
            sv.ImpostorScoresUser22User7 = ManhDist.CalculateImpostorScores(s022Mean, s007);
            sv.ImpostorScoresUser22User8 = ManhDist.CalculateImpostorScores(s022Mean, s008);
            sv.ImpostorScoresUser22User9 = ManhDist.CalculateImpostorScores(s022Mean, s009);
            sv.ImpostorScoresUser22User10 = ManhDist.CalculateImpostorScores(s022Mean, s010);

            sv.ImpostorScoresUser22User11 = ManhDist.CalculateImpostorScores(s022Mean, s011);
            sv.ImpostorScoresUser22User12 = ManhDist.CalculateImpostorScores(s022Mean, s012);
            sv.ImpostorScoresUser22User13 = ManhDist.CalculateImpostorScores(s022Mean, s013);
            sv.ImpostorScoresUser22User14 = ManhDist.CalculateImpostorScores(s022Mean, s014);
            sv.ImpostorScoresUser22User15 = ManhDist.CalculateImpostorScores(s022Mean, s015);
            sv.ImpostorScoresUser22User16 = ManhDist.CalculateImpostorScores(s022Mean, s016);
            sv.ImpostorScoresUser22User17 = ManhDist.CalculateImpostorScores(s022Mean, s017);
            sv.ImpostorScoresUser22User18 = ManhDist.CalculateImpostorScores(s022Mean, s018);
            sv.ImpostorScoresUser22User19 = ManhDist.CalculateImpostorScores(s022Mean, s019);
            sv.ImpostorScoresUser22User20 = ManhDist.CalculateImpostorScores(s022Mean, s020);

            sv.ImpostorScoresUser22User21 = ManhDist.CalculateImpostorScores(s022Mean, s021);
            sv.ImpostorScoresUser22User23 = ManhDist.CalculateImpostorScores(s022Mean, s023);
            sv.ImpostorScoresUser22User24 = ManhDist.CalculateImpostorScores(s022Mean, s024);
            sv.ImpostorScoresUser22User25 = ManhDist.CalculateImpostorScores(s022Mean, s025);
            sv.ImpostorScoresUser22User26 = ManhDist.CalculateImpostorScores(s022Mean, s026);
            sv.ImpostorScoresUser22User27 = ManhDist.CalculateImpostorScores(s022Mean, s027);
            sv.ImpostorScoresUser22User28 = ManhDist.CalculateImpostorScores(s022Mean, s028);
            sv.ImpostorScoresUser22User29 = ManhDist.CalculateImpostorScores(s022Mean, s029);
            sv.ImpostorScoresUser22User30 = ManhDist.CalculateImpostorScores(s022Mean, s030);

            sv.ImpostorScoresUser22User31 = ManhDist.CalculateImpostorScores(s022Mean, s031);
            sv.ImpostorScoresUser22User32 = ManhDist.CalculateImpostorScores(s022Mean, s032);
            sv.ImpostorScoresUser22User33 = ManhDist.CalculateImpostorScores(s022Mean, s033);
            sv.ImpostorScoresUser22User34 = ManhDist.CalculateImpostorScores(s022Mean, s034);
            sv.ImpostorScoresUser22User35 = ManhDist.CalculateImpostorScores(s022Mean, s035);
            sv.ImpostorScoresUser22User36 = ManhDist.CalculateImpostorScores(s022Mean, s036);
            sv.ImpostorScoresUser22User37 = ManhDist.CalculateImpostorScores(s022Mean, s037);
            sv.ImpostorScoresUser22User38 = ManhDist.CalculateImpostorScores(s022Mean, s038);
            sv.ImpostorScoresUser22User39 = ManhDist.CalculateImpostorScores(s022Mean, s039);
            sv.ImpostorScoresUser22User40 = ManhDist.CalculateImpostorScores(s022Mean, s040);

            sv.ImpostorScoresUser22User41 = ManhDist.CalculateImpostorScores(s022Mean, s041);
            sv.ImpostorScoresUser22User42 = ManhDist.CalculateImpostorScores(s022Mean, s042);
            sv.ImpostorScoresUser22User43 = ManhDist.CalculateImpostorScores(s022Mean, s043);
            sv.ImpostorScoresUser22User44 = ManhDist.CalculateImpostorScores(s022Mean, s044);
            sv.ImpostorScoresUser22User45 = ManhDist.CalculateImpostorScores(s022Mean, s045);
            sv.ImpostorScoresUser22User46 = ManhDist.CalculateImpostorScores(s022Mean, s046);
            sv.ImpostorScoresUser22User47 = ManhDist.CalculateImpostorScores(s022Mean, s047);
            sv.ImpostorScoresUser22User48 = ManhDist.CalculateImpostorScores(s022Mean, s048);
            sv.ImpostorScoresUser22User49 = ManhDist.CalculateImpostorScores(s022Mean, s049);
            sv.ImpostorScoresUser22User50 = ManhDist.CalculateImpostorScores(s022Mean, s050);

            sv.ImpostorScoresUser22User51 = ManhDist.CalculateImpostorScores(s022Mean, s051);
            sv.ImpostorScoresUser22User52 = ManhDist.CalculateImpostorScores(s022Mean, s052);
            sv.ImpostorScoresUser22User53 = ManhDist.CalculateImpostorScores(s022Mean, s053);
            sv.ImpostorScoresUser22User54 = ManhDist.CalculateImpostorScores(s022Mean, s054);
            sv.ImpostorScoresUser22User55 = ManhDist.CalculateImpostorScores(s022Mean, s055);
            sv.ImpostorScoresUser22User56 = ManhDist.CalculateImpostorScores(s022Mean, s056);
            sv.ImpostorScoresUser22User57 = ManhDist.CalculateImpostorScores(s022Mean, s057);
            sv.ImpostorScoresUser22User58 = ManhDist.CalculateImpostorScores(s022Mean, s058);
            sv.ImpostorScoresUser22User59 = ManhDist.CalculateImpostorScores(s022Mean, s059);
            sv.ImpostorScoresUser22User60 = ManhDist.CalculateImpostorScores(s022Mean, s060);

            sv.ImpostorScoresUser22User61 = ManhDist.CalculateImpostorScores(s022Mean, s061);
            sv.ImpostorScoresUser22User62 = ManhDist.CalculateImpostorScores(s022Mean, s062);
            sv.ImpostorScoresUser22User63 = ManhDist.CalculateImpostorScores(s022Mean, s063);
            sv.ImpostorScoresUser22User64 = ManhDist.CalculateImpostorScores(s022Mean, s064);
            sv.ImpostorScoresUser22User65 = ManhDist.CalculateImpostorScores(s022Mean, s065);
            sv.ImpostorScoresUser22User66 = ManhDist.CalculateImpostorScores(s022Mean, s066);
            sv.ImpostorScoresUser22User67 = ManhDist.CalculateImpostorScores(s022Mean, s067);
            sv.ImpostorScoresUser22User68 = ManhDist.CalculateImpostorScores(s022Mean, s068);
            sv.ImpostorScoresUser22User69 = ManhDist.CalculateImpostorScores(s022Mean, s069);
            sv.ImpostorScoresUser22User70 = ManhDist.CalculateImpostorScores(s022Mean, s070);

            sv.ImpostorScoresUser22User71 = ManhDist.CalculateImpostorScores(s022Mean, s071);
            sv.ImpostorScoresUser22User72 = ManhDist.CalculateImpostorScores(s022Mean, s072);
            sv.ImpostorScoresUser22User73 = ManhDist.CalculateImpostorScores(s022Mean, s073);
            sv.ImpostorScoresUser22User74 = ManhDist.CalculateImpostorScores(s022Mean, s074);
            sv.ImpostorScoresUser22User75 = ManhDist.CalculateImpostorScores(s022Mean, s075);
            sv.ImpostorScoresUser22User76 = ManhDist.CalculateImpostorScores(s022Mean, s076);
            sv.ImpostorScoresUser22User77 = ManhDist.CalculateImpostorScores(s022Mean, s077);
            sv.ImpostorScoresUser22User78 = ManhDist.CalculateImpostorScores(s022Mean, s078);
            sv.ImpostorScoresUser22User79 = ManhDist.CalculateImpostorScores(s022Mean, s079);
            sv.ImpostorScoresUser22User80 = ManhDist.CalculateImpostorScores(s022Mean, s080);

            sv.ImpostorScoresUser22User81 = ManhDist.CalculateImpostorScores(s022Mean, s081);
            sv.ImpostorScoresUser22User82 = ManhDist.CalculateImpostorScores(s022Mean, s082);
            sv.ImpostorScoresUser22User83 = ManhDist.CalculateImpostorScores(s022Mean, s083);
            sv.ImpostorScoresUser22User84 = ManhDist.CalculateImpostorScores(s022Mean, s084);
            sv.ImpostorScoresUser22User85 = ManhDist.CalculateImpostorScores(s022Mean, s085);
            sv.ImpostorScoresUser22User86 = ManhDist.CalculateImpostorScores(s022Mean, s086);
            sv.ImpostorScoresUser22User87 = ManhDist.CalculateImpostorScores(s022Mean, s087);
            sv.ImpostorScoresUser22User88 = ManhDist.CalculateImpostorScores(s022Mean, s088);
            sv.ImpostorScoresUser22User89 = ManhDist.CalculateImpostorScores(s022Mean, s089);
            sv.ImpostorScoresUser22User90 = ManhDist.CalculateImpostorScores(s022Mean, s090);

            sv.ImpostorScoresUser22User91 = ManhDist.CalculateImpostorScores(s022Mean, s091);
            sv.ImpostorScoresUser22User92 = ManhDist.CalculateImpostorScores(s022Mean, s092);
            sv.ImpostorScoresUser22User93 = ManhDist.CalculateImpostorScores(s022Mean, s093);
            sv.ImpostorScoresUser22User94 = ManhDist.CalculateImpostorScores(s022Mean, s094);
            sv.ImpostorScoresUser22User95 = ManhDist.CalculateImpostorScores(s022Mean, s095);
            sv.ImpostorScoresUser22User96 = ManhDist.CalculateImpostorScores(s022Mean, s096);
            sv.ImpostorScoresUser22User97 = ManhDist.CalculateImpostorScores(s022Mean, s097);
            sv.ImpostorScoresUser22User98 = ManhDist.CalculateImpostorScores(s022Mean, s098);
            sv.ImpostorScoresUser22User99 = ManhDist.CalculateImpostorScores(s022Mean, s099);
            sv.ImpostorScoresUser22User100 = ManhDist.CalculateImpostorScores(s022Mean, s100);
            #endregion

            #region User 23 Impostor scores
            sv.ImpostorScoresUser23User1 = ManhDist.CalculateImpostorScores(s023Mean, s001);
            sv.ImpostorScoresUser23User2 = ManhDist.CalculateImpostorScores(s023Mean, s002);
            sv.ImpostorScoresUser23User3 = ManhDist.CalculateImpostorScores(s023Mean, s003);
            sv.ImpostorScoresUser23User4 = ManhDist.CalculateImpostorScores(s023Mean, s004);
            sv.ImpostorScoresUser23User5 = ManhDist.CalculateImpostorScores(s023Mean, s005);
            sv.ImpostorScoresUser23User6 = ManhDist.CalculateImpostorScores(s023Mean, s006);
            sv.ImpostorScoresUser23User7 = ManhDist.CalculateImpostorScores(s023Mean, s007);
            sv.ImpostorScoresUser23User8 = ManhDist.CalculateImpostorScores(s023Mean, s008);
            sv.ImpostorScoresUser23User9 = ManhDist.CalculateImpostorScores(s023Mean, s009);
            sv.ImpostorScoresUser23User10 = ManhDist.CalculateImpostorScores(s023Mean, s010);

            sv.ImpostorScoresUser23User11 = ManhDist.CalculateImpostorScores(s023Mean, s011);
            sv.ImpostorScoresUser23User12 = ManhDist.CalculateImpostorScores(s023Mean, s012);
            sv.ImpostorScoresUser23User13 = ManhDist.CalculateImpostorScores(s023Mean, s013);
            sv.ImpostorScoresUser23User14 = ManhDist.CalculateImpostorScores(s023Mean, s014);
            sv.ImpostorScoresUser23User15 = ManhDist.CalculateImpostorScores(s023Mean, s015);
            sv.ImpostorScoresUser23User16 = ManhDist.CalculateImpostorScores(s023Mean, s016);
            sv.ImpostorScoresUser23User17 = ManhDist.CalculateImpostorScores(s023Mean, s017);
            sv.ImpostorScoresUser23User18 = ManhDist.CalculateImpostorScores(s023Mean, s018);
            sv.ImpostorScoresUser23User19 = ManhDist.CalculateImpostorScores(s023Mean, s019);
            sv.ImpostorScoresUser23User20 = ManhDist.CalculateImpostorScores(s023Mean, s020);

            sv.ImpostorScoresUser23User21 = ManhDist.CalculateImpostorScores(s023Mean, s021);
            sv.ImpostorScoresUser23User22 = ManhDist.CalculateImpostorScores(s023Mean, s022);
            sv.ImpostorScoresUser23User24 = ManhDist.CalculateImpostorScores(s023Mean, s024);
            sv.ImpostorScoresUser23User25 = ManhDist.CalculateImpostorScores(s023Mean, s025);
            sv.ImpostorScoresUser23User26 = ManhDist.CalculateImpostorScores(s023Mean, s026);
            sv.ImpostorScoresUser23User27 = ManhDist.CalculateImpostorScores(s023Mean, s027);
            sv.ImpostorScoresUser23User28 = ManhDist.CalculateImpostorScores(s023Mean, s028);
            sv.ImpostorScoresUser23User29 = ManhDist.CalculateImpostorScores(s023Mean, s029);
            sv.ImpostorScoresUser23User30 = ManhDist.CalculateImpostorScores(s023Mean, s030);

            sv.ImpostorScoresUser23User31 = ManhDist.CalculateImpostorScores(s023Mean, s031);
            sv.ImpostorScoresUser23User32 = ManhDist.CalculateImpostorScores(s023Mean, s032);
            sv.ImpostorScoresUser23User33 = ManhDist.CalculateImpostorScores(s023Mean, s033);
            sv.ImpostorScoresUser23User34 = ManhDist.CalculateImpostorScores(s023Mean, s034);
            sv.ImpostorScoresUser23User35 = ManhDist.CalculateImpostorScores(s023Mean, s035);
            sv.ImpostorScoresUser23User36 = ManhDist.CalculateImpostorScores(s023Mean, s036);
            sv.ImpostorScoresUser23User37 = ManhDist.CalculateImpostorScores(s023Mean, s037);
            sv.ImpostorScoresUser23User38 = ManhDist.CalculateImpostorScores(s023Mean, s038);
            sv.ImpostorScoresUser23User39 = ManhDist.CalculateImpostorScores(s023Mean, s039);
            sv.ImpostorScoresUser23User40 = ManhDist.CalculateImpostorScores(s023Mean, s040);

            sv.ImpostorScoresUser23User41 = ManhDist.CalculateImpostorScores(s023Mean, s041);
            sv.ImpostorScoresUser23User42 = ManhDist.CalculateImpostorScores(s023Mean, s042);
            sv.ImpostorScoresUser23User43 = ManhDist.CalculateImpostorScores(s023Mean, s043);
            sv.ImpostorScoresUser23User44 = ManhDist.CalculateImpostorScores(s023Mean, s044);
            sv.ImpostorScoresUser23User45 = ManhDist.CalculateImpostorScores(s023Mean, s045);
            sv.ImpostorScoresUser23User46 = ManhDist.CalculateImpostorScores(s023Mean, s046);
            sv.ImpostorScoresUser23User47 = ManhDist.CalculateImpostorScores(s023Mean, s047);
            sv.ImpostorScoresUser23User48 = ManhDist.CalculateImpostorScores(s023Mean, s048);
            sv.ImpostorScoresUser23User49 = ManhDist.CalculateImpostorScores(s023Mean, s049);
            sv.ImpostorScoresUser23User50 = ManhDist.CalculateImpostorScores(s023Mean, s050);

            sv.ImpostorScoresUser23User51 = ManhDist.CalculateImpostorScores(s023Mean, s051);
            sv.ImpostorScoresUser23User52 = ManhDist.CalculateImpostorScores(s023Mean, s052);
            sv.ImpostorScoresUser23User53 = ManhDist.CalculateImpostorScores(s023Mean, s053);
            sv.ImpostorScoresUser23User54 = ManhDist.CalculateImpostorScores(s023Mean, s054);
            sv.ImpostorScoresUser23User55 = ManhDist.CalculateImpostorScores(s023Mean, s055);
            sv.ImpostorScoresUser23User56 = ManhDist.CalculateImpostorScores(s023Mean, s056);
            sv.ImpostorScoresUser23User57 = ManhDist.CalculateImpostorScores(s023Mean, s057);
            sv.ImpostorScoresUser23User58 = ManhDist.CalculateImpostorScores(s023Mean, s058);
            sv.ImpostorScoresUser23User59 = ManhDist.CalculateImpostorScores(s023Mean, s059);
            sv.ImpostorScoresUser23User60 = ManhDist.CalculateImpostorScores(s023Mean, s060);

            sv.ImpostorScoresUser23User61 = ManhDist.CalculateImpostorScores(s023Mean, s061);
            sv.ImpostorScoresUser23User62 = ManhDist.CalculateImpostorScores(s023Mean, s062);
            sv.ImpostorScoresUser23User63 = ManhDist.CalculateImpostorScores(s023Mean, s063);
            sv.ImpostorScoresUser23User64 = ManhDist.CalculateImpostorScores(s023Mean, s064);
            sv.ImpostorScoresUser23User65 = ManhDist.CalculateImpostorScores(s023Mean, s065);
            sv.ImpostorScoresUser23User66 = ManhDist.CalculateImpostorScores(s023Mean, s066);
            sv.ImpostorScoresUser23User67 = ManhDist.CalculateImpostorScores(s023Mean, s067);
            sv.ImpostorScoresUser23User68 = ManhDist.CalculateImpostorScores(s023Mean, s068);
            sv.ImpostorScoresUser23User69 = ManhDist.CalculateImpostorScores(s023Mean, s069);
            sv.ImpostorScoresUser23User70 = ManhDist.CalculateImpostorScores(s023Mean, s070);

            sv.ImpostorScoresUser23User71 = ManhDist.CalculateImpostorScores(s023Mean, s071);
            sv.ImpostorScoresUser23User72 = ManhDist.CalculateImpostorScores(s023Mean, s072);
            sv.ImpostorScoresUser23User73 = ManhDist.CalculateImpostorScores(s023Mean, s073);
            sv.ImpostorScoresUser23User74 = ManhDist.CalculateImpostorScores(s023Mean, s074);
            sv.ImpostorScoresUser23User75 = ManhDist.CalculateImpostorScores(s023Mean, s075);
            sv.ImpostorScoresUser23User76 = ManhDist.CalculateImpostorScores(s023Mean, s076);
            sv.ImpostorScoresUser23User77 = ManhDist.CalculateImpostorScores(s023Mean, s077);
            sv.ImpostorScoresUser23User78 = ManhDist.CalculateImpostorScores(s023Mean, s078);
            sv.ImpostorScoresUser23User79 = ManhDist.CalculateImpostorScores(s023Mean, s079);
            sv.ImpostorScoresUser23User80 = ManhDist.CalculateImpostorScores(s023Mean, s080);

            sv.ImpostorScoresUser23User81 = ManhDist.CalculateImpostorScores(s023Mean, s081);
            sv.ImpostorScoresUser23User82 = ManhDist.CalculateImpostorScores(s023Mean, s082);
            sv.ImpostorScoresUser23User83 = ManhDist.CalculateImpostorScores(s023Mean, s083);
            sv.ImpostorScoresUser23User84 = ManhDist.CalculateImpostorScores(s023Mean, s084);
            sv.ImpostorScoresUser23User85 = ManhDist.CalculateImpostorScores(s023Mean, s085);
            sv.ImpostorScoresUser23User86 = ManhDist.CalculateImpostorScores(s023Mean, s086);
            sv.ImpostorScoresUser23User87 = ManhDist.CalculateImpostorScores(s023Mean, s087);
            sv.ImpostorScoresUser23User88 = ManhDist.CalculateImpostorScores(s023Mean, s088);
            sv.ImpostorScoresUser23User89 = ManhDist.CalculateImpostorScores(s023Mean, s089);
            sv.ImpostorScoresUser23User90 = ManhDist.CalculateImpostorScores(s023Mean, s090);

            sv.ImpostorScoresUser23User91 = ManhDist.CalculateImpostorScores(s023Mean, s091);
            sv.ImpostorScoresUser23User92 = ManhDist.CalculateImpostorScores(s023Mean, s092);
            sv.ImpostorScoresUser23User93 = ManhDist.CalculateImpostorScores(s023Mean, s093);
            sv.ImpostorScoresUser23User94 = ManhDist.CalculateImpostorScores(s023Mean, s094);
            sv.ImpostorScoresUser23User95 = ManhDist.CalculateImpostorScores(s023Mean, s095);
            sv.ImpostorScoresUser23User96 = ManhDist.CalculateImpostorScores(s023Mean, s096);
            sv.ImpostorScoresUser23User97 = ManhDist.CalculateImpostorScores(s023Mean, s097);
            sv.ImpostorScoresUser23User98 = ManhDist.CalculateImpostorScores(s023Mean, s098);
            sv.ImpostorScoresUser23User99 = ManhDist.CalculateImpostorScores(s023Mean, s099);
            sv.ImpostorScoresUser23User100 = ManhDist.CalculateImpostorScores(s023Mean, s100);
            #endregion

            #region User 24 Impostor scores
            sv.ImpostorScoresUser24User1 = ManhDist.CalculateImpostorScores(s024Mean, s001);
            sv.ImpostorScoresUser24User2 = ManhDist.CalculateImpostorScores(s024Mean, s002);
            sv.ImpostorScoresUser24User3 = ManhDist.CalculateImpostorScores(s024Mean, s003);
            sv.ImpostorScoresUser24User4 = ManhDist.CalculateImpostorScores(s024Mean, s004);
            sv.ImpostorScoresUser24User5 = ManhDist.CalculateImpostorScores(s024Mean, s005);
            sv.ImpostorScoresUser24User6 = ManhDist.CalculateImpostorScores(s024Mean, s006);
            sv.ImpostorScoresUser24User7 = ManhDist.CalculateImpostorScores(s024Mean, s007);
            sv.ImpostorScoresUser24User8 = ManhDist.CalculateImpostorScores(s024Mean, s008);
            sv.ImpostorScoresUser24User9 = ManhDist.CalculateImpostorScores(s024Mean, s009);
            sv.ImpostorScoresUser24User10 = ManhDist.CalculateImpostorScores(s024Mean, s010);

            sv.ImpostorScoresUser24User11 = ManhDist.CalculateImpostorScores(s024Mean, s011);
            sv.ImpostorScoresUser24User12 = ManhDist.CalculateImpostorScores(s024Mean, s012);
            sv.ImpostorScoresUser24User13 = ManhDist.CalculateImpostorScores(s024Mean, s013);
            sv.ImpostorScoresUser24User14 = ManhDist.CalculateImpostorScores(s024Mean, s014);
            sv.ImpostorScoresUser24User15 = ManhDist.CalculateImpostorScores(s024Mean, s015);
            sv.ImpostorScoresUser24User16 = ManhDist.CalculateImpostorScores(s024Mean, s016);
            sv.ImpostorScoresUser24User17 = ManhDist.CalculateImpostorScores(s024Mean, s017);
            sv.ImpostorScoresUser24User18 = ManhDist.CalculateImpostorScores(s024Mean, s018);
            sv.ImpostorScoresUser24User19 = ManhDist.CalculateImpostorScores(s024Mean, s019);
            sv.ImpostorScoresUser24User20 = ManhDist.CalculateImpostorScores(s024Mean, s020);

            sv.ImpostorScoresUser24User21 = ManhDist.CalculateImpostorScores(s024Mean, s021);
            sv.ImpostorScoresUser24User22 = ManhDist.CalculateImpostorScores(s024Mean, s022);
            sv.ImpostorScoresUser24User23 = ManhDist.CalculateImpostorScores(s024Mean, s023);
            sv.ImpostorScoresUser24User25 = ManhDist.CalculateImpostorScores(s024Mean, s025);
            sv.ImpostorScoresUser24User26 = ManhDist.CalculateImpostorScores(s024Mean, s026);
            sv.ImpostorScoresUser24User27 = ManhDist.CalculateImpostorScores(s024Mean, s027);
            sv.ImpostorScoresUser24User28 = ManhDist.CalculateImpostorScores(s024Mean, s028);
            sv.ImpostorScoresUser24User29 = ManhDist.CalculateImpostorScores(s024Mean, s029);
            sv.ImpostorScoresUser24User30 = ManhDist.CalculateImpostorScores(s024Mean, s030);

            sv.ImpostorScoresUser24User31 = ManhDist.CalculateImpostorScores(s024Mean, s031);
            sv.ImpostorScoresUser24User32 = ManhDist.CalculateImpostorScores(s024Mean, s032);
            sv.ImpostorScoresUser24User33 = ManhDist.CalculateImpostorScores(s024Mean, s033);
            sv.ImpostorScoresUser24User34 = ManhDist.CalculateImpostorScores(s024Mean, s034);
            sv.ImpostorScoresUser24User35 = ManhDist.CalculateImpostorScores(s024Mean, s035);
            sv.ImpostorScoresUser24User36 = ManhDist.CalculateImpostorScores(s024Mean, s036);
            sv.ImpostorScoresUser24User37 = ManhDist.CalculateImpostorScores(s024Mean, s037);
            sv.ImpostorScoresUser24User38 = ManhDist.CalculateImpostorScores(s024Mean, s038);
            sv.ImpostorScoresUser24User39 = ManhDist.CalculateImpostorScores(s024Mean, s039);
            sv.ImpostorScoresUser24User40 = ManhDist.CalculateImpostorScores(s024Mean, s040);

            sv.ImpostorScoresUser24User41 = ManhDist.CalculateImpostorScores(s024Mean, s041);
            sv.ImpostorScoresUser24User42 = ManhDist.CalculateImpostorScores(s024Mean, s042);
            sv.ImpostorScoresUser24User43 = ManhDist.CalculateImpostorScores(s024Mean, s043);
            sv.ImpostorScoresUser24User44 = ManhDist.CalculateImpostorScores(s024Mean, s044);
            sv.ImpostorScoresUser24User45 = ManhDist.CalculateImpostorScores(s024Mean, s045);
            sv.ImpostorScoresUser24User46 = ManhDist.CalculateImpostorScores(s024Mean, s046);
            sv.ImpostorScoresUser24User47 = ManhDist.CalculateImpostorScores(s024Mean, s047);
            sv.ImpostorScoresUser24User48 = ManhDist.CalculateImpostorScores(s024Mean, s048);
            sv.ImpostorScoresUser24User49 = ManhDist.CalculateImpostorScores(s024Mean, s049);
            sv.ImpostorScoresUser24User50 = ManhDist.CalculateImpostorScores(s024Mean, s050);

            sv.ImpostorScoresUser24User51 = ManhDist.CalculateImpostorScores(s024Mean, s051);
            sv.ImpostorScoresUser24User52 = ManhDist.CalculateImpostorScores(s024Mean, s052);
            sv.ImpostorScoresUser24User53 = ManhDist.CalculateImpostorScores(s024Mean, s053);
            sv.ImpostorScoresUser24User54 = ManhDist.CalculateImpostorScores(s024Mean, s054);
            sv.ImpostorScoresUser24User55 = ManhDist.CalculateImpostorScores(s024Mean, s055);
            sv.ImpostorScoresUser24User56 = ManhDist.CalculateImpostorScores(s024Mean, s056);
            sv.ImpostorScoresUser24User57 = ManhDist.CalculateImpostorScores(s024Mean, s057);
            sv.ImpostorScoresUser24User58 = ManhDist.CalculateImpostorScores(s024Mean, s058);
            sv.ImpostorScoresUser24User59 = ManhDist.CalculateImpostorScores(s024Mean, s059);
            sv.ImpostorScoresUser24User60 = ManhDist.CalculateImpostorScores(s024Mean, s060);

            sv.ImpostorScoresUser24User61 = ManhDist.CalculateImpostorScores(s024Mean, s061);
            sv.ImpostorScoresUser24User62 = ManhDist.CalculateImpostorScores(s024Mean, s062);
            sv.ImpostorScoresUser24User63 = ManhDist.CalculateImpostorScores(s024Mean, s063);
            sv.ImpostorScoresUser24User64 = ManhDist.CalculateImpostorScores(s024Mean, s064);
            sv.ImpostorScoresUser24User65 = ManhDist.CalculateImpostorScores(s024Mean, s065);
            sv.ImpostorScoresUser24User66 = ManhDist.CalculateImpostorScores(s024Mean, s066);
            sv.ImpostorScoresUser24User67 = ManhDist.CalculateImpostorScores(s024Mean, s067);
            sv.ImpostorScoresUser24User68 = ManhDist.CalculateImpostorScores(s024Mean, s068);
            sv.ImpostorScoresUser24User69 = ManhDist.CalculateImpostorScores(s024Mean, s069);
            sv.ImpostorScoresUser24User70 = ManhDist.CalculateImpostorScores(s024Mean, s070);

            sv.ImpostorScoresUser24User71 = ManhDist.CalculateImpostorScores(s024Mean, s071);
            sv.ImpostorScoresUser24User72 = ManhDist.CalculateImpostorScores(s024Mean, s072);
            sv.ImpostorScoresUser24User73 = ManhDist.CalculateImpostorScores(s024Mean, s073);
            sv.ImpostorScoresUser24User74 = ManhDist.CalculateImpostorScores(s024Mean, s074);
            sv.ImpostorScoresUser24User75 = ManhDist.CalculateImpostorScores(s024Mean, s075);
            sv.ImpostorScoresUser24User76 = ManhDist.CalculateImpostorScores(s024Mean, s076);
            sv.ImpostorScoresUser24User77 = ManhDist.CalculateImpostorScores(s024Mean, s077);
            sv.ImpostorScoresUser24User78 = ManhDist.CalculateImpostorScores(s024Mean, s078);
            sv.ImpostorScoresUser24User79 = ManhDist.CalculateImpostorScores(s024Mean, s079);
            sv.ImpostorScoresUser24User80 = ManhDist.CalculateImpostorScores(s024Mean, s080);

            sv.ImpostorScoresUser24User81 = ManhDist.CalculateImpostorScores(s024Mean, s081);
            sv.ImpostorScoresUser24User82 = ManhDist.CalculateImpostorScores(s024Mean, s082);
            sv.ImpostorScoresUser24User83 = ManhDist.CalculateImpostorScores(s024Mean, s083);
            sv.ImpostorScoresUser24User84 = ManhDist.CalculateImpostorScores(s024Mean, s084);
            sv.ImpostorScoresUser24User85 = ManhDist.CalculateImpostorScores(s024Mean, s085);
            sv.ImpostorScoresUser24User86 = ManhDist.CalculateImpostorScores(s024Mean, s086);
            sv.ImpostorScoresUser24User87 = ManhDist.CalculateImpostorScores(s024Mean, s087);
            sv.ImpostorScoresUser24User88 = ManhDist.CalculateImpostorScores(s024Mean, s088);
            sv.ImpostorScoresUser24User89 = ManhDist.CalculateImpostorScores(s024Mean, s089);
            sv.ImpostorScoresUser24User90 = ManhDist.CalculateImpostorScores(s024Mean, s090);

            sv.ImpostorScoresUser24User91 = ManhDist.CalculateImpostorScores(s024Mean, s091);
            sv.ImpostorScoresUser24User92 = ManhDist.CalculateImpostorScores(s024Mean, s092);
            sv.ImpostorScoresUser24User93 = ManhDist.CalculateImpostorScores(s024Mean, s093);
            sv.ImpostorScoresUser24User94 = ManhDist.CalculateImpostorScores(s024Mean, s094);
            sv.ImpostorScoresUser24User95 = ManhDist.CalculateImpostorScores(s024Mean, s095);
            sv.ImpostorScoresUser24User96 = ManhDist.CalculateImpostorScores(s024Mean, s096);
            sv.ImpostorScoresUser24User97 = ManhDist.CalculateImpostorScores(s024Mean, s097);
            sv.ImpostorScoresUser24User98 = ManhDist.CalculateImpostorScores(s024Mean, s098);
            sv.ImpostorScoresUser24User99 = ManhDist.CalculateImpostorScores(s024Mean, s099);
            sv.ImpostorScoresUser24User100 = ManhDist.CalculateImpostorScores(s024Mean, s100);
            #endregion

            #region User 25 Impostor scores
            sv.ImpostorScoresUser25User1 = ManhDist.CalculateImpostorScores(s025Mean, s001);
            sv.ImpostorScoresUser25User2 = ManhDist.CalculateImpostorScores(s025Mean, s002);
            sv.ImpostorScoresUser25User3 = ManhDist.CalculateImpostorScores(s025Mean, s003);
            sv.ImpostorScoresUser25User4 = ManhDist.CalculateImpostorScores(s025Mean, s004);
            sv.ImpostorScoresUser25User5 = ManhDist.CalculateImpostorScores(s025Mean, s005);
            sv.ImpostorScoresUser25User6 = ManhDist.CalculateImpostorScores(s025Mean, s006);
            sv.ImpostorScoresUser25User7 = ManhDist.CalculateImpostorScores(s025Mean, s007);
            sv.ImpostorScoresUser25User8 = ManhDist.CalculateImpostorScores(s025Mean, s008);
            sv.ImpostorScoresUser25User9 = ManhDist.CalculateImpostorScores(s025Mean, s009);
            sv.ImpostorScoresUser25User10 = ManhDist.CalculateImpostorScores(s025Mean, s010);

            sv.ImpostorScoresUser25User11 = ManhDist.CalculateImpostorScores(s025Mean, s011);
            sv.ImpostorScoresUser25User12 = ManhDist.CalculateImpostorScores(s025Mean, s012);
            sv.ImpostorScoresUser25User13 = ManhDist.CalculateImpostorScores(s025Mean, s013);
            sv.ImpostorScoresUser25User14 = ManhDist.CalculateImpostorScores(s025Mean, s014);
            sv.ImpostorScoresUser25User15 = ManhDist.CalculateImpostorScores(s025Mean, s015);
            sv.ImpostorScoresUser25User16 = ManhDist.CalculateImpostorScores(s025Mean, s016);
            sv.ImpostorScoresUser25User17 = ManhDist.CalculateImpostorScores(s025Mean, s017);
            sv.ImpostorScoresUser25User18 = ManhDist.CalculateImpostorScores(s025Mean, s018);
            sv.ImpostorScoresUser25User19 = ManhDist.CalculateImpostorScores(s025Mean, s019);
            sv.ImpostorScoresUser25User20 = ManhDist.CalculateImpostorScores(s025Mean, s020);

            sv.ImpostorScoresUser25User21 = ManhDist.CalculateImpostorScores(s025Mean, s021);
            sv.ImpostorScoresUser25User22 = ManhDist.CalculateImpostorScores(s025Mean, s022);
            sv.ImpostorScoresUser25User23 = ManhDist.CalculateImpostorScores(s025Mean, s023);
            sv.ImpostorScoresUser25User24 = ManhDist.CalculateImpostorScores(s025Mean, s024);
            sv.ImpostorScoresUser25User26 = ManhDist.CalculateImpostorScores(s025Mean, s026);
            sv.ImpostorScoresUser25User27 = ManhDist.CalculateImpostorScores(s025Mean, s027);
            sv.ImpostorScoresUser25User28 = ManhDist.CalculateImpostorScores(s025Mean, s028);
            sv.ImpostorScoresUser25User29 = ManhDist.CalculateImpostorScores(s025Mean, s029);
            sv.ImpostorScoresUser25User30 = ManhDist.CalculateImpostorScores(s025Mean, s030);

            sv.ImpostorScoresUser25User31 = ManhDist.CalculateImpostorScores(s025Mean, s031);
            sv.ImpostorScoresUser25User32 = ManhDist.CalculateImpostorScores(s025Mean, s032);
            sv.ImpostorScoresUser25User33 = ManhDist.CalculateImpostorScores(s025Mean, s033);
            sv.ImpostorScoresUser25User34 = ManhDist.CalculateImpostorScores(s025Mean, s034);
            sv.ImpostorScoresUser25User35 = ManhDist.CalculateImpostorScores(s025Mean, s035);
            sv.ImpostorScoresUser25User36 = ManhDist.CalculateImpostorScores(s025Mean, s036);
            sv.ImpostorScoresUser25User37 = ManhDist.CalculateImpostorScores(s025Mean, s037);
            sv.ImpostorScoresUser25User38 = ManhDist.CalculateImpostorScores(s025Mean, s038);
            sv.ImpostorScoresUser25User39 = ManhDist.CalculateImpostorScores(s025Mean, s039);
            sv.ImpostorScoresUser25User40 = ManhDist.CalculateImpostorScores(s025Mean, s040);

            sv.ImpostorScoresUser25User41 = ManhDist.CalculateImpostorScores(s025Mean, s041);
            sv.ImpostorScoresUser25User42 = ManhDist.CalculateImpostorScores(s025Mean, s042);
            sv.ImpostorScoresUser25User43 = ManhDist.CalculateImpostorScores(s025Mean, s043);
            sv.ImpostorScoresUser25User44 = ManhDist.CalculateImpostorScores(s025Mean, s044);
            sv.ImpostorScoresUser25User45 = ManhDist.CalculateImpostorScores(s025Mean, s045);
            sv.ImpostorScoresUser25User46 = ManhDist.CalculateImpostorScores(s025Mean, s046);
            sv.ImpostorScoresUser25User47 = ManhDist.CalculateImpostorScores(s025Mean, s047);
            sv.ImpostorScoresUser25User48 = ManhDist.CalculateImpostorScores(s025Mean, s048);
            sv.ImpostorScoresUser25User49 = ManhDist.CalculateImpostorScores(s025Mean, s049);
            sv.ImpostorScoresUser25User50 = ManhDist.CalculateImpostorScores(s025Mean, s050);

            sv.ImpostorScoresUser25User51 = ManhDist.CalculateImpostorScores(s025Mean, s051);
            sv.ImpostorScoresUser25User52 = ManhDist.CalculateImpostorScores(s025Mean, s052);
            sv.ImpostorScoresUser25User53 = ManhDist.CalculateImpostorScores(s025Mean, s053);
            sv.ImpostorScoresUser25User54 = ManhDist.CalculateImpostorScores(s025Mean, s054);
            sv.ImpostorScoresUser25User55 = ManhDist.CalculateImpostorScores(s025Mean, s055);
            sv.ImpostorScoresUser25User56 = ManhDist.CalculateImpostorScores(s025Mean, s056);
            sv.ImpostorScoresUser25User57 = ManhDist.CalculateImpostorScores(s025Mean, s057);
            sv.ImpostorScoresUser25User58 = ManhDist.CalculateImpostorScores(s025Mean, s058);
            sv.ImpostorScoresUser25User59 = ManhDist.CalculateImpostorScores(s025Mean, s059);
            sv.ImpostorScoresUser25User60 = ManhDist.CalculateImpostorScores(s025Mean, s060);

            sv.ImpostorScoresUser25User61 = ManhDist.CalculateImpostorScores(s025Mean, s061);
            sv.ImpostorScoresUser25User62 = ManhDist.CalculateImpostorScores(s025Mean, s062);
            sv.ImpostorScoresUser25User63 = ManhDist.CalculateImpostorScores(s025Mean, s063);
            sv.ImpostorScoresUser25User64 = ManhDist.CalculateImpostorScores(s025Mean, s064);
            sv.ImpostorScoresUser25User65 = ManhDist.CalculateImpostorScores(s025Mean, s065);
            sv.ImpostorScoresUser25User66 = ManhDist.CalculateImpostorScores(s025Mean, s066);
            sv.ImpostorScoresUser25User67 = ManhDist.CalculateImpostorScores(s025Mean, s067);
            sv.ImpostorScoresUser25User68 = ManhDist.CalculateImpostorScores(s025Mean, s068);
            sv.ImpostorScoresUser25User69 = ManhDist.CalculateImpostorScores(s025Mean, s069);
            sv.ImpostorScoresUser25User70 = ManhDist.CalculateImpostorScores(s025Mean, s070);

            sv.ImpostorScoresUser25User71 = ManhDist.CalculateImpostorScores(s025Mean, s071);
            sv.ImpostorScoresUser25User72 = ManhDist.CalculateImpostorScores(s025Mean, s072);
            sv.ImpostorScoresUser25User73 = ManhDist.CalculateImpostorScores(s025Mean, s073);
            sv.ImpostorScoresUser25User74 = ManhDist.CalculateImpostorScores(s025Mean, s074);
            sv.ImpostorScoresUser25User75 = ManhDist.CalculateImpostorScores(s025Mean, s075);
            sv.ImpostorScoresUser25User76 = ManhDist.CalculateImpostorScores(s025Mean, s076);
            sv.ImpostorScoresUser25User77 = ManhDist.CalculateImpostorScores(s025Mean, s077);
            sv.ImpostorScoresUser25User78 = ManhDist.CalculateImpostorScores(s025Mean, s078);
            sv.ImpostorScoresUser25User79 = ManhDist.CalculateImpostorScores(s025Mean, s079);
            sv.ImpostorScoresUser25User80 = ManhDist.CalculateImpostorScores(s025Mean, s080);

            sv.ImpostorScoresUser25User81 = ManhDist.CalculateImpostorScores(s025Mean, s081);
            sv.ImpostorScoresUser25User82 = ManhDist.CalculateImpostorScores(s025Mean, s082);
            sv.ImpostorScoresUser25User83 = ManhDist.CalculateImpostorScores(s025Mean, s083);
            sv.ImpostorScoresUser25User84 = ManhDist.CalculateImpostorScores(s025Mean, s084);
            sv.ImpostorScoresUser25User85 = ManhDist.CalculateImpostorScores(s025Mean, s085);
            sv.ImpostorScoresUser25User86 = ManhDist.CalculateImpostorScores(s025Mean, s086);
            sv.ImpostorScoresUser25User87 = ManhDist.CalculateImpostorScores(s025Mean, s087);
            sv.ImpostorScoresUser25User88 = ManhDist.CalculateImpostorScores(s025Mean, s088);
            sv.ImpostorScoresUser25User89 = ManhDist.CalculateImpostorScores(s025Mean, s089);
            sv.ImpostorScoresUser25User90 = ManhDist.CalculateImpostorScores(s025Mean, s090);

            sv.ImpostorScoresUser25User91 = ManhDist.CalculateImpostorScores(s025Mean, s091);
            sv.ImpostorScoresUser25User92 = ManhDist.CalculateImpostorScores(s025Mean, s092);
            sv.ImpostorScoresUser25User93 = ManhDist.CalculateImpostorScores(s025Mean, s093);
            sv.ImpostorScoresUser25User94 = ManhDist.CalculateImpostorScores(s025Mean, s094);
            sv.ImpostorScoresUser25User95 = ManhDist.CalculateImpostorScores(s025Mean, s095);
            sv.ImpostorScoresUser25User96 = ManhDist.CalculateImpostorScores(s025Mean, s096);
            sv.ImpostorScoresUser25User97 = ManhDist.CalculateImpostorScores(s025Mean, s097);
            sv.ImpostorScoresUser25User98 = ManhDist.CalculateImpostorScores(s025Mean, s098);
            sv.ImpostorScoresUser25User99 = ManhDist.CalculateImpostorScores(s025Mean, s099);
            sv.ImpostorScoresUser25User100 = ManhDist.CalculateImpostorScores(s025Mean, s100);
            #endregion

            #region User 26 Impostor scores
            sv.ImpostorScoresUser26User1 = ManhDist.CalculateImpostorScores(s026Mean, s001);
            sv.ImpostorScoresUser26User2 = ManhDist.CalculateImpostorScores(s026Mean, s002);
            sv.ImpostorScoresUser26User3 = ManhDist.CalculateImpostorScores(s026Mean, s003);
            sv.ImpostorScoresUser26User4 = ManhDist.CalculateImpostorScores(s026Mean, s004);
            sv.ImpostorScoresUser26User5 = ManhDist.CalculateImpostorScores(s026Mean, s005);
            sv.ImpostorScoresUser26User6 = ManhDist.CalculateImpostorScores(s026Mean, s006);
            sv.ImpostorScoresUser26User7 = ManhDist.CalculateImpostorScores(s026Mean, s007);
            sv.ImpostorScoresUser26User8 = ManhDist.CalculateImpostorScores(s026Mean, s008);
            sv.ImpostorScoresUser26User9 = ManhDist.CalculateImpostorScores(s026Mean, s009);
            sv.ImpostorScoresUser26User10 = ManhDist.CalculateImpostorScores(s026Mean, s010);

            sv.ImpostorScoresUser26User11 = ManhDist.CalculateImpostorScores(s026Mean, s011);
            sv.ImpostorScoresUser26User12 = ManhDist.CalculateImpostorScores(s026Mean, s012);
            sv.ImpostorScoresUser26User13 = ManhDist.CalculateImpostorScores(s026Mean, s013);
            sv.ImpostorScoresUser26User14 = ManhDist.CalculateImpostorScores(s026Mean, s014);
            sv.ImpostorScoresUser26User15 = ManhDist.CalculateImpostorScores(s026Mean, s015);
            sv.ImpostorScoresUser26User16 = ManhDist.CalculateImpostorScores(s026Mean, s016);
            sv.ImpostorScoresUser26User17 = ManhDist.CalculateImpostorScores(s026Mean, s017);
            sv.ImpostorScoresUser26User18 = ManhDist.CalculateImpostorScores(s026Mean, s018);
            sv.ImpostorScoresUser26User19 = ManhDist.CalculateImpostorScores(s026Mean, s019);
            sv.ImpostorScoresUser26User20 = ManhDist.CalculateImpostorScores(s026Mean, s020);

            sv.ImpostorScoresUser26User21 = ManhDist.CalculateImpostorScores(s026Mean, s021);
            sv.ImpostorScoresUser26User22 = ManhDist.CalculateImpostorScores(s026Mean, s022);
            sv.ImpostorScoresUser26User23 = ManhDist.CalculateImpostorScores(s026Mean, s023);
            sv.ImpostorScoresUser26User24 = ManhDist.CalculateImpostorScores(s026Mean, s024);
            sv.ImpostorScoresUser26User25 = ManhDist.CalculateImpostorScores(s026Mean, s025);
            sv.ImpostorScoresUser26User27 = ManhDist.CalculateImpostorScores(s026Mean, s027);
            sv.ImpostorScoresUser26User28 = ManhDist.CalculateImpostorScores(s026Mean, s028);
            sv.ImpostorScoresUser26User29 = ManhDist.CalculateImpostorScores(s026Mean, s029);
            sv.ImpostorScoresUser26User30 = ManhDist.CalculateImpostorScores(s026Mean, s030);

            sv.ImpostorScoresUser26User31 = ManhDist.CalculateImpostorScores(s026Mean, s031);
            sv.ImpostorScoresUser26User32 = ManhDist.CalculateImpostorScores(s026Mean, s032);
            sv.ImpostorScoresUser26User33 = ManhDist.CalculateImpostorScores(s026Mean, s033);
            sv.ImpostorScoresUser26User34 = ManhDist.CalculateImpostorScores(s026Mean, s034);
            sv.ImpostorScoresUser26User35 = ManhDist.CalculateImpostorScores(s026Mean, s035);
            sv.ImpostorScoresUser26User36 = ManhDist.CalculateImpostorScores(s026Mean, s036);
            sv.ImpostorScoresUser26User37 = ManhDist.CalculateImpostorScores(s026Mean, s037);
            sv.ImpostorScoresUser26User38 = ManhDist.CalculateImpostorScores(s026Mean, s038);
            sv.ImpostorScoresUser26User39 = ManhDist.CalculateImpostorScores(s026Mean, s039);
            sv.ImpostorScoresUser26User40 = ManhDist.CalculateImpostorScores(s026Mean, s040);

            sv.ImpostorScoresUser26User41 = ManhDist.CalculateImpostorScores(s026Mean, s041);
            sv.ImpostorScoresUser26User42 = ManhDist.CalculateImpostorScores(s026Mean, s042);
            sv.ImpostorScoresUser26User43 = ManhDist.CalculateImpostorScores(s026Mean, s043);
            sv.ImpostorScoresUser26User44 = ManhDist.CalculateImpostorScores(s026Mean, s044);
            sv.ImpostorScoresUser26User45 = ManhDist.CalculateImpostorScores(s026Mean, s045);
            sv.ImpostorScoresUser26User46 = ManhDist.CalculateImpostorScores(s026Mean, s046);
            sv.ImpostorScoresUser26User47 = ManhDist.CalculateImpostorScores(s026Mean, s047);
            sv.ImpostorScoresUser26User48 = ManhDist.CalculateImpostorScores(s026Mean, s048);
            sv.ImpostorScoresUser26User49 = ManhDist.CalculateImpostorScores(s026Mean, s049);
            sv.ImpostorScoresUser26User50 = ManhDist.CalculateImpostorScores(s026Mean, s050);

            sv.ImpostorScoresUser26User51 = ManhDist.CalculateImpostorScores(s026Mean, s051);
            sv.ImpostorScoresUser26User52 = ManhDist.CalculateImpostorScores(s026Mean, s052);
            sv.ImpostorScoresUser26User53 = ManhDist.CalculateImpostorScores(s026Mean, s053);
            sv.ImpostorScoresUser26User54 = ManhDist.CalculateImpostorScores(s026Mean, s054);
            sv.ImpostorScoresUser26User55 = ManhDist.CalculateImpostorScores(s026Mean, s055);
            sv.ImpostorScoresUser26User56 = ManhDist.CalculateImpostorScores(s026Mean, s056);
            sv.ImpostorScoresUser26User57 = ManhDist.CalculateImpostorScores(s026Mean, s057);
            sv.ImpostorScoresUser26User58 = ManhDist.CalculateImpostorScores(s026Mean, s058);
            sv.ImpostorScoresUser26User59 = ManhDist.CalculateImpostorScores(s026Mean, s059);
            sv.ImpostorScoresUser26User60 = ManhDist.CalculateImpostorScores(s026Mean, s060);

            sv.ImpostorScoresUser26User61 = ManhDist.CalculateImpostorScores(s026Mean, s061);
            sv.ImpostorScoresUser26User62 = ManhDist.CalculateImpostorScores(s026Mean, s062);
            sv.ImpostorScoresUser26User63 = ManhDist.CalculateImpostorScores(s026Mean, s063);
            sv.ImpostorScoresUser26User64 = ManhDist.CalculateImpostorScores(s026Mean, s064);
            sv.ImpostorScoresUser26User65 = ManhDist.CalculateImpostorScores(s026Mean, s065);
            sv.ImpostorScoresUser26User66 = ManhDist.CalculateImpostorScores(s026Mean, s066);
            sv.ImpostorScoresUser26User67 = ManhDist.CalculateImpostorScores(s026Mean, s067);
            sv.ImpostorScoresUser26User68 = ManhDist.CalculateImpostorScores(s026Mean, s068);
            sv.ImpostorScoresUser26User69 = ManhDist.CalculateImpostorScores(s026Mean, s069);
            sv.ImpostorScoresUser26User70 = ManhDist.CalculateImpostorScores(s026Mean, s070);

            sv.ImpostorScoresUser26User71 = ManhDist.CalculateImpostorScores(s026Mean, s071);
            sv.ImpostorScoresUser26User72 = ManhDist.CalculateImpostorScores(s026Mean, s072);
            sv.ImpostorScoresUser26User73 = ManhDist.CalculateImpostorScores(s026Mean, s073);
            sv.ImpostorScoresUser26User74 = ManhDist.CalculateImpostorScores(s026Mean, s074);
            sv.ImpostorScoresUser26User75 = ManhDist.CalculateImpostorScores(s026Mean, s075);
            sv.ImpostorScoresUser26User76 = ManhDist.CalculateImpostorScores(s026Mean, s076);
            sv.ImpostorScoresUser26User77 = ManhDist.CalculateImpostorScores(s026Mean, s077);
            sv.ImpostorScoresUser26User78 = ManhDist.CalculateImpostorScores(s026Mean, s078);
            sv.ImpostorScoresUser26User79 = ManhDist.CalculateImpostorScores(s026Mean, s079);
            sv.ImpostorScoresUser26User80 = ManhDist.CalculateImpostorScores(s026Mean, s080);

            sv.ImpostorScoresUser26User81 = ManhDist.CalculateImpostorScores(s026Mean, s081);
            sv.ImpostorScoresUser26User82 = ManhDist.CalculateImpostorScores(s026Mean, s082);
            sv.ImpostorScoresUser26User83 = ManhDist.CalculateImpostorScores(s026Mean, s083);
            sv.ImpostorScoresUser26User84 = ManhDist.CalculateImpostorScores(s026Mean, s084);
            sv.ImpostorScoresUser26User85 = ManhDist.CalculateImpostorScores(s026Mean, s085);
            sv.ImpostorScoresUser26User86 = ManhDist.CalculateImpostorScores(s026Mean, s086);
            sv.ImpostorScoresUser26User87 = ManhDist.CalculateImpostorScores(s026Mean, s087);
            sv.ImpostorScoresUser26User88 = ManhDist.CalculateImpostorScores(s026Mean, s088);
            sv.ImpostorScoresUser26User89 = ManhDist.CalculateImpostorScores(s026Mean, s089);
            sv.ImpostorScoresUser26User90 = ManhDist.CalculateImpostorScores(s026Mean, s090);

            sv.ImpostorScoresUser26User91 = ManhDist.CalculateImpostorScores(s026Mean, s091);
            sv.ImpostorScoresUser26User92 = ManhDist.CalculateImpostorScores(s026Mean, s092);
            sv.ImpostorScoresUser26User93 = ManhDist.CalculateImpostorScores(s026Mean, s093);
            sv.ImpostorScoresUser26User94 = ManhDist.CalculateImpostorScores(s026Mean, s094);
            sv.ImpostorScoresUser26User95 = ManhDist.CalculateImpostorScores(s026Mean, s095);
            sv.ImpostorScoresUser26User96 = ManhDist.CalculateImpostorScores(s026Mean, s096);
            sv.ImpostorScoresUser26User97 = ManhDist.CalculateImpostorScores(s026Mean, s097);
            sv.ImpostorScoresUser26User98 = ManhDist.CalculateImpostorScores(s026Mean, s098);
            sv.ImpostorScoresUser26User99 = ManhDist.CalculateImpostorScores(s026Mean, s099);
            sv.ImpostorScoresUser26User100 = ManhDist.CalculateImpostorScores(s026Mean, s100);
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