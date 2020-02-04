using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    class Fight
    {
        public int atk_monster(int player_dmg, int monster_hp)
        {
            return monster_hp - player_dmg;
        }
        public int injured(int player_hp, int monster_dmg)
        {
            return player_hp - monster_dmg;
        }
    }
}