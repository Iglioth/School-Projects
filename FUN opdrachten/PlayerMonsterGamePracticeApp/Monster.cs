using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMonsterGamePracticeApp
{
    public class Monster
    {
        public int Health { get; set; }
        public bool MonsterDead { get; set; }
        
        public Monster(int initialHealth)
        {
            this.Health = initialHealth;
        }


        public void LoseHealth(int damage)
        {
            this.Health = this.Health - damage;
            if(Health <= 0)
            {
                this.MonsterDead = true;
            }
        }

       

    }
    
}
