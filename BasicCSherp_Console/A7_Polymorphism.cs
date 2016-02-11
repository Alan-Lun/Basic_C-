using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSherp_Console
{
    //A7-多型
    //多型表示不同的物件可以執行相同的動作，但要透過他們自己的實現程式碼執行

        //Animal相當於父親，cat、dog、fox都是兒子，兒子代表父親做某一件事情，但每個兒子叫出來的不一樣，
        //多型有必須要注意的是宣告的必須是父類別而不是子類別，但是實體化的物件是子類別，這才會實現多型
        //多型的原理是當方法被調用時，無論物件是否被轉換為其父類別，都只有位於物件繼承鍊最末端的方法實現會被調用。也就是說虛擬方法是按照其執行時類型，而非邊一時類型進行動態繫結調用的



    class A7_Polymorphism
    {
      

    }

    public class Animal2
    {
        protected string name = "";
        public Animal2(string name)
        {
            this.name = name;
        }

        public Animal2()
        {
            this.name = "無名";
        }

        protected int _shoutNum = 3;

        public int shoutNum
        {
            get { return _shoutNum = 3; }
            set { _shoutNum = value; }
        }

        //跟上一個繼承範例差別在多了此Virtual
        public virtual string Shout()
        {
            return "";
        }

    }

    public class fox:Animal2
    {
        public fox() : base() { }
        public fox(string name) : base(name) { }

        public override string Shout()
        {
            //return base.Shout();
            return "嗚";
        }

    }




}
