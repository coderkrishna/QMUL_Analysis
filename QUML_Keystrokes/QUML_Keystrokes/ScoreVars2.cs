using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUML_Keystrokes
{
    public partial class ScoreVars
    {
        #region User 5 Impostor scores
        private double[,] _impostorScoresUser5User1;
        public double[,] ImpostorScoresUser5User1
        {
            get { return _impostorScoresUser5User1; }
            set { _impostorScoresUser5User1 = value; }
        }

        private double[,] _impostorScoresUser5User2;
        public double[,] ImpostorScoresUser5User2
        {
            get { return _impostorScoresUser5User2; }
            set { _impostorScoresUser5User2 = value; }
        }
        #endregion
    }
}