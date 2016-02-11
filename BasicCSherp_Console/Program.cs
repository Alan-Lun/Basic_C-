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
    }
   



}







