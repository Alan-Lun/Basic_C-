using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSherp_Console
{
     class Program
    {
        static void Main(string[] args)
        {


            //A1就是類別名稱，Happy就是類別的方法
            //就像是我們裝好電腦之後，就可以做開機的動作，new就是裝好這台電腦
            A1 _PC = new A1();
            //然後我們就是做開機動作，
            string _Happy=_PC.Happy();


            //-----------------------------------------------
            
            A2 _PC2 = new A2("龍魂GE60"); //可以在裝好電腦時，為他取名，這樣大家才會知道是哪台，當然建構式可以多個

            string _strPC2 = _PC2.Happy();

            //A3 方法重載
            A2 _PC3 = new A2();
            string _strPC3 = _PC3.Happy("自爽");

            //--------------------------------------------------

            //A4 屬性與修飾子
            A4 _PC4 = new A4();
            _PC4.ReStartNum = 5;
            Console.WriteLine(_PC4.ReStart());


            //A5 封裝，剛才都是在使用封裝的
            //假設現在A5是NB，他也一樣會有ReStart
            A5 _NB = new A5();
            _NB.ReStartNum = 5;
            Console.WriteLine(_NB.ReStart());


            //A9 介面
            //抽象類別可以給初一些成員的實現，抽象類別的抽象成員可被子類別部分實現
            //介面的成員需要實現類別完全實現，一個類別只能繼承一個抽象類別，但可以實現多個介面等
            //第一類別是對物件的抽象；抽象類別是對類別的抽象；介面是對行為的抽象
            //第二如果行為跨越不同類別的物件，可使用介面；對於一些相似的類別物件，用繼承抽象類別
            //舉例 貓 狗都是動物，所以它們去繼承動物這抽象類別
            //但悟空和超人都會飛，但是悟空會變身，神話的悟空也會變身，所以此時可以用介面來完成
            //第三，抽象類別是從子類別中發現了公共的東西，泛化出父類別，然後子類別繼承父類別
            //，而介面是根本不知子類別的存在，方法如何實現還不確認，預先定義
            //例如在寫程式時候，是先寫了貓類別後，在寫出狗類別，最後發現有相同類似的，就泛化出動物類別，
            //不可能只有貓類別時候就想到動物類別
            //而介面是一同思考，定義一些項目，但不知道會有什麼動物，要如何實現，能做的就是是先定義這些比賽項目的行為介面
            //抽象類別是自底而上抽象類別的，而介面則是自頂而下設定的
            //(從狗貓衍伸出動物)(從項目延伸出不知那些動物會來參加預先定義好項目)

            A9_Interface _A9 = new A9_Interface("測試介面");
            
            IA9_Interface _A9_2 = new A9_Interface("測試介面2");
            Console.WriteLine(_A9.ChangeThing("第一個"));
            Console.WriteLine(_A9_2.ChangeThing("第二個"));

            //A10 泛型
            IList<Animal> arrayAnimal = new List<Animal>();
            arrayAnimal.Add(new Cat_Extend("tt"));
            arrayAnimal.Add(new Dog_Extend("tt2"));
            arrayAnimal.Add(new Cat_Extend("tt3"));
            Console.WriteLine(arrayAnimal.Count.ToString());

            //A11 泛型

            cat_deleget _cat = new cat_deleget("T");
            mouse_deleget _mo1 = new mouse_deleget("Ja");
            mouse_deleget _mo2 = new mouse_deleget("Jb");

            //表示將Mouse的Run方法透過實體化委託給CatShoutEventHandler登記到Cat的事件CatShout當中，+=是為了加進去add_CatShout的意思
            _cat.CatShout += new cat_deleget.CatShoutEventHandler(_mo1.Run);
            _cat.CatShout += new cat_deleget.CatShoutEventHandler(_mo2.Run);
            _cat.Shout();

            cat_deleget2 _cat2 = new cat_deleget2("T");
            mouse_deleget2 _mo21 = new mouse_deleget2("Ja");
            mouse_deleget2 _mo22 = new mouse_deleget2("Jb");
            _cat2.CatShout += new cat_deleget2.CatShoutEventHandler(_mo21.Run);
            _cat2.CatShout += new cat_deleget2.CatShoutEventHandler(_mo22.Run);
            _cat2.Shout();



            //A12-yieldreturn
            yieldreturn _yield = new yieldreturn();
            var _return = _yield.returnACD();
            string _strreturn = "";
            foreach (var item in _return)
            {
                _strreturn += item;
            }
            Console.WriteLine(_strreturn);

            Console.Read();



        }


        /// <summary>
        /// A1-類別與實體
        /// </summary>
        public class A1
        {
            //類別
            public string Happy()
            {
                return "開心";
            }
        }

        /// <summary>
        /// A2-建構式
        /// </summary>
        public class A2
        {
            private string name = "";//只能在裡面使用的變數
            public A2(string name)
            {
                this.name = name;
            }

            public string Happy()
            {
                return name + "很開心";
            }

            //方法重載
            public A2()
            {
                this.name = "無名";
            }

            public string Happy(string _strHappy)
            {
                return _strHappy;
            }


        }

        /// <summary>
        /// A4-屬性與修飾子
        /// </summary>
        public class A4
        {
            //修飾子
            //public 好比家裡完全透明，家具都看得到，都可以動
            //private 就像是家裡有牆壁保護住，只有我們才可以動裡面的家具

            //屬性，可設定成唯獨或者是條件式設定
            private int _ReStartNum;
            
            public int ReStartNum
            {
                get { return _ReStartNum; }
                // set { _ReStartNum = value; }
                set {
                    if(value<=5)
                    {
                        _ReStartNum = value;
                    }
                    else
                    {
                        _ReStartNum = 5;
                    }
                    


                }


            }

            public string ReStart()
            {
                string result = "";
                for (int i = 0; i < ReStartNum; i++)
                {
                    result += "重開 ";
                }
                return result;



            }



        }

        /// <summary>
        /// A5-封裝
        /// </summary>
        public class A5
        {
            //良好的封裝能夠減少耦合
            //類別內部實現可以自由地修改
            //類別具有清晰的對外界面


            //屬性，可設定成唯獨或者是條件式設定
            private int _ReStartNum;

            public int ReStartNum
            {
                get { return _ReStartNum; }
                // set { _ReStartNum = value; }
                set
                {
                    if (value <= 5)
                    {
                        _ReStartNum = value;
                    }
                    else
                    {
                        _ReStartNum = 5;
                    }



                }


            }

            public string ReStart()
            {
                string result = "";
                for (int i = 0; i < ReStartNum; i++)
                {
                    result += "重開 ";
                }
                return result;



            }



        }





    }
   



}







