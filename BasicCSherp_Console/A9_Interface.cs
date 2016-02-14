using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSherp_Console
{
    public class A9_Interface : Cat, IA9_Interface
    {
        public A9_Interface() : base() { }

        public A9_Interface(string name) : base(name) { }



        public string ChangeThing(string thing)
        {
            //throw new NotImplementedException();
            return base.Shout() + " 測試測試 " + thing;
        }
    }
}
