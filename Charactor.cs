﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    class Charactor
    {//思考如何同時達到安全與重用性高
        
        private string Name;//property
        private int STR;
        private int DEX;
        private int INT;
        private int LUK;
        private int HP;
        private int MP;
        public string GetName()//method
        {
            return Name;
        }
    }

    class Swordsman : Charactor
    {

        //屬性
        public double skill()
        {
            Console.WriteLine("摩天一擊");
            return Convert.ToDouble(1.4);
        }

        public double skill2(int str)
        {
            Console.WriteLine("劍器縱橫");
            return Convert.ToDouble(str * 0.5);
        }

        public double skill3(int hp)
        {
            Console.WriteLine("聖火");
            return Convert.ToDouble(hp * 1.5);
        }

    }

    class Mage : Charactor
    {
        public void skill()
        {
            Console.WriteLine("魔靈蛋");
        }
        public void skill2()
        {
            Console.WriteLine("魔力抓");
        }

    }

}