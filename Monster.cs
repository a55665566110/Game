using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    class Monster
    {
        public Monster(int  HP)
        {
        }
        public string NAME;
        public int HP;
        public int ATK;
        public string GetName() {
            return NAME;
        }
        public object DropTreasure;
      
    }
    class Monster_BOSS : Monster
    {
        public Monster_BOSS(string HP):base(HP)
        {
            
        }
        private void zakum()
        {
            Monster_BOSS zakum = new Monster_BOSS();
            helmet drop_zakum = new helmet(); 
            zakum.NAME = "zakum";
            zakum.HP = 66000000;
            zakum.ATK = 3000;
            zakum.DropTreasure = drop_zakum.GetInventory;
        }

        public void Dead_Horntail()
        {
            Monster Dead_Horntail = new Monster();
            Dead_Horntail.NAME = ("Dead_Horntail");
            Dead_Horntail.HP = 2090000000;
            Dead_Horntail.ATK = 5000;
        }


    }
}