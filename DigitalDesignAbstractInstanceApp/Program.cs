using System;
using System.Reflection;

namespace DigitalDesignAbstractInstanceApp
{
    abstract class SomeAbstractClass
    {
        int IntegerValue;

        public SomeAbstractClass()
        {
            
        }
        public string SomeProperty { get; set; }
        public abstract void Method1();
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var obj = (SomeAbstractClass)typeof(RuntimeTypeHandle).GetMethod("Allocate", BindingFlags.Static | BindingFlags.NonPublic).Invoke(null, new object[] { typeof(SomeAbstractClass) });
            typeof(SomeAbstractClass).GetConstructor(Type.EmptyTypes).Invoke(obj, new object[0]);
            obj.SomeProperty = "Wowie";
            Console.WriteLine(obj.SomeProperty);
            Console.ReadLine();
        }
    }
}