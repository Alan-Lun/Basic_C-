using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSherp_Console
{

    //抽象
    //可以想想上一個A7時，會發現Animal類別根本不可能實體化，因為她就是動物
    //所以可以把沒意義的父類別做抽象類別以及他的方法做抽象類別，因為他根本什麼也沒有
    
    //抽象類別不能實體化
    //抽象方法必須被子類別重寫的方法
    //如果類別中包含抽象方法，那麼類別就必須定義為抽象類別
    
        //抽象類別通常代表一個抽象概念，他提供一個繼承的出發點，抽象類別一定是用來繼承的，而一個以繼承關係形成的等級結裡面，樹葉結點應當是具體類別，而樹枝節點均應當是抽象類別
     
    class A8_abstract
    {
    }

    public abstract class Animal3
    {
        protected string name = "";
        public Animal3(string name)
        {
            this.name = name;
        }

        public Animal3()
        {
            this.name = "無名";
        }

        protected int _shoutNum = 3;

        public int shoutNum
        {
            get { return _shoutNum = 3; }
            set { _shoutNum = value; }
        }

        //在這邊將動物類別做成抽象，等等繼承時一定要做override，否則一定錯
        protected abstract string Shout();

    }

    public class fox2:Animal3
    {
        public fox2() : base() { }
        public fox2(string name) : base(name) { }


        protected override string Shout()
        {
            return "";
        }
    }



}
