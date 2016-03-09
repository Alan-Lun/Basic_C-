using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSherp_Console
{
    //A12 yield return 
    /*
    反覆運算器
    可傳回相同型態的值有序序列的一段程式
    可在類別中實現多個反覆運算器

    1.回傳類型必須為IEnumerable, IEnumerable<T>, IEnumerator, IEnumerator<T>
    2.不可包含任何 ref 與 out 參數
    3.匿名方法與unsafe區塊不可使用yield
        
        */
    public class yieldreturn
    {
        List<string> _stringList = new List<string>()
        {
            "A","B","C","D","E","F"
        };

        public yieldreturn()
        {
            
        }

        public IEnumerable<string> returnACD()
        {
            foreach (var item in _stringList)
            {
                if(item=="E")
                {
                    yield break;
                }
                else if(item!="B")
                {
                    yield return item;
                }
            }
        }



    }
}
