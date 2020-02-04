using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    class Inventory
    {
        public object GetInventory;
       
        
    }

    class helmet : Inventory
    {
        private void zakums_helmet()
        {
            int STR = 15;
            int DEX = 17;
            int INT = 13;
            int LUX = 18;
        }
    }

    class others: Inventory
    {
        private string ZakumsTreeBranch;
    }
}
