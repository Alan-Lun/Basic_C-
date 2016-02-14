using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSherp_Console
{
    //A9-介面
    //介面是把隱式公共方法與屬性組合起來，以封裝特定功能的一個集合
    //一旦類別實現了介面，類別就可以支援介面所指定的所有屬性和成員。宣告介面在語法上與宣告抽象類別完成相同
    //但不允許提供介面中任何成員的執行方式。
    //介面不能實體化，也不能有建構式和欄位，介面也不能有修飾子(public、private)等，也不能宣告虛擬或靜態的
    //還有實現介面的類別就必須實現介面中的所有方法和屬性

    //還有介面的命名前面要加一個大寫字母 I，這是規範
    //一個類別可以支援多個介面

    interface IA9_Interface
    {
        string ChangeThing(string thing);
    }
}
