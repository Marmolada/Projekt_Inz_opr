using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Ortografia
{
    class Przyklad
    {

        private string quest;
        private string[] answers = new string[2];
        private int which;

        public Przyklad()
        {
        }

        public Przyklad(string quest, string ans1, string ans2, int which)
        {
            this.quest = quest;
            answers[0]=ans1;
            answers[1]=ans2;
            this.which = which;
        }

        public bool Is_valid(int a)
        {
            if (a == which)
                return true;
            return false;
        }

        public void fill_przyklad(Control button1, Control button2, Control label1)
        {
            button1.Text = answers[0];
            button2.Text = answers[1];
            label1.Text = quest;
        }
    }
}
