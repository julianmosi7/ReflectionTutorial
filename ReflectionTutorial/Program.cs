using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("DummyLib");
            Type type = assembly.GetType("DummyLib.DummyClass");
            object instance = Activator.CreateInstance(type);
            //DummyLib.DummyClass instance = new DummyLib.Dummyclass();
            //instance.fDummy();
            MethodInfo methodInfo = type.GetMethod("fDummy");
            methodInfo.Invoke(instance, null);
            Console.ReadKey();


            //var type = Assembly.Load("DummyLib").GetType("DummyLib.DummyClass");
            //var instance = Activator.CreateInstance(type);
            var result = type?.GetMethod("gDummy")?.Invoke(instance, new object[] { 666 });
        }
    }
}
