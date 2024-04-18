using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_2_coding_challenge
{
    internal class player
    {
        private string name;
        private int score;
        private int livesleft;

        public player(string name)
        {
            this.name = name;
        } //end method

        public player(string name, int startinglives)
        {
            this.name = name;
            livesleft = startinglives;
        } //end method

        //task or action
        public int GetScore()
        {
            return score;
        }//end method

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }//end method

        public void Kill()
        {
            if (livesleft > 0)
            {
                livesleft--;
            }
        }//end method

        public int GetLivesLeft()
        {
            return livesleft;
        }//end method

    } //end class
} //end namespace
