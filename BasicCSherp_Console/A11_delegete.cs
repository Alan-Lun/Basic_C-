using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSherp_Console
{
    //A11 委託及事件
    //委託是對函數的封裝，可以當作給方法的特徵指定一個名稱。
    //事件則是委託一個特殊形式，當發生有意義的事情時，事件物件處理通知過程

    //狀況：有貓叫T，老鼠兩隻叫Ja、Jb，貓只要一叫，兩隻老鼠就喊快跑
    //正常就是Cat類別和Mouse類別，Cat的Shout方法觸發時，Mouse就執行Run方法

        //但cat類別當中不會關連到mouse類別，所以此時要用委託事件
        //委託是一種參考方法的類型。一旦為委託分配了方法，委託將與該方法具有完全相同的行為
        //委託適用delegate來宣告。事件是說在發生其他類別或物件關注的事情時，類別可透過事件通知它們，事件是用event關鍵字做宣告

    
    public class A11_delegete
    {

    }

    public class cat_deleget
    {
        private string name;
        public cat_deleget(string name)
        {
            this.name = name;
        }

        public delegate void CatShoutEventHandler(); //宣告委託事件

        public event CatShoutEventHandler CatShout; //宣告事件CatShout，事件類型是委託CatShoutEventHandler

        public void Shout()
        {
            Console.WriteLine("喵,我是{0}", name);

            if (CatShout != null)
            {
                CatShout(); //如果當執行shout()方法時，如果catshout有物件登記事件，則執行CatShout()
            }

        }




    }

    public class mouse_deleget
    {
        private string name;
        public mouse_deleget(string name)
        {
            this.name = name;
        }


        public void Run()
        {
            Console.WriteLine("老貓來，{0}", name);
        }

    }





}
