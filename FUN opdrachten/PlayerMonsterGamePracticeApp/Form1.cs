using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerMonsterGamePracticeApp
{
    public partial class MonsterKillerForm : Form
    {
        //Maakt twee monsters en een hero aan
        private Hero hero = new Hero(0);
        private Monster monsterleft = new Monster(100);
        private Monster monsterright = new Monster(100);

        public MonsterKillerForm()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e)
        {

            //Attacks the left monster if it's radio button is checked.
            if (RBMonsterLeft.Checked == true)
            {
                hero.Attack(monsterleft, 30);
                LMonsterLeft.Text = "Health: " + monsterleft.Health.ToString();
                if(monsterleft.MonsterDead == true)
                {
                    LMonsterLeft.Text = "Monster is Dead!";
                    hero.MonsterKilled();
                    LblMonstersKilled.Text = "Monsters killed: " + hero.numberOfMonsterKilled.ToString();
                }
            }
            else if (RBMonsterRight.Checked == true)
            {
                hero.Attack(monsterright, 30);
                LMonsterRight.Text = "Health: " + monsterright.Health.ToString();
                if (monsterright.MonsterDead == true)
                {
                    LMonsterRight.Text = "Monster is Dead!";
                    hero.MonsterKilled();
                    LblMonstersKilled.Text = "Monsters killed: " + hero.numberOfMonsterKilled.ToString();
                }
            }
        }

    }
}
