using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyLib
{
    public class DummyClass
    {
        public void fDummy() => Console.WriteLine("DummyClass::fDummy");

        public string gDummy(int x)
        {
            Console.WriteLine($"DummyClass::gDummy({x})");
            return 
        }
        
    }
}
