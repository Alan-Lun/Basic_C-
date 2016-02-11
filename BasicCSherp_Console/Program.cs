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



    }
   



}







