using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSherp_Console
{
    //在這邊會再增加一個修飾詞 protected，在繼承時，子類別可以對基礎類別有完全存取權
    class A6_Extend
    {
    }

    #region 未繼承前，會發現到許多相似的
    public class Cat
    {
        private string name = "";
        public Cat(string name)
        {
            this.name = name;
        }

        public Cat()
        {
            this.name = "無名";
        }

        private int _shoutNum=3;

        public int shoutNum
        {
            get { return _shoutNum = 3; }
            set { _shoutNum =  value; }
        }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵 ";
            }
            return "我的名字叫" + name + " " + result;
        }



    }

    public class Dog
    {
        private string name = "";
        public Dog(string name)
        {
            this.name = name;
        }

        public Dog()
        {
            this.name = "無名";
        }

        private int _shoutNum = 3;

        public int shoutNum
        {
            get { return _shoutNum = 3; }
            set { _shoutNum = value; }
        }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "汪 ";
            }
            return "我的名字叫" + name + " " + result;
        }



    }

    #endregion

    #region 使用繼承後
    //相同東西丟到動物，因為貓跟狗都是動物
    //繼承有一件事情要注意，他只有建構式是無法被繼承，所以只調用他，使用base來做
    //在這邊會再增加一個修飾詞 protected，在繼承時，子類別可以對基礎類別有完全存取權
    //繼承缺點就是父類別變動，子類別也不得不變，所以不適合狗繼承貓，另外繼承會破壞包裝，父類別實現細節暴露給子類別
    //繼承是一種類別與類別之間強耦合的關係，53u.3y94的關係時才適合用繼承
    //如果是 has-a的關係的話就不適合用繼承，ex：人有兩隻手，手不能繼承人，或者是飛機場有飛機，但飛機不可以繼承飛機場

    public class Animal
    {
        protected string name = "";
        public Animal(string name)
        {
            this.name = name;
        }

        public Animal()
        {
            this.name = "無名";
        }

        protected int _shoutNum = 3;

        public int shoutNum
        {
            get { return _shoutNum = 3; }
            set { _shoutNum = value; }
        }

    }

    //使用了繼承以後，重複的程式碼就可以減少，就可以做好客製專屬於那物件的東西

    public class Cat_Extend:Animal
    {
        public Cat_Extend():base()
         { }
        public Cat_Extend(string name) : base(name) { }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵 ";
            }
            return "我的名字叫" + name + " " + result;
        }

    }

    public class Dog_Extend:Animal
    {
        public Dog_Extend():base()
         { }
        public Dog_Extend(string name) : base(name) { }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "汪 ";
            }
            return "我的名字叫" + name + " " + result;
        }

    }



    #endregion


}
