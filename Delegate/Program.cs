using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Delegate_Practice
{
    public delegate void Func(string? str);
    public class MyClass
    {
        public string? Str { get; set; }
        public MyClass(string? str)
        {
            Str = str;
        }

        public void Space(string? str)
        {
            string? temp = "";
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    temp += str[i];
                    if (str.Length - 1 != i) temp += "_";
                }
            }
            Str = temp;

            Console.WriteLine($"Space : {Str}");
        }

        public void Reverse(string? str)
        {
            string? temp = "";
            if(str != null)
            {
                for (int i=str.Length-1; i >=0; i--)
                {
                    temp+=str[i];
                }
            }
            Str = temp;
            Console.WriteLine($"Reverse : {Str}");
        }


    }


    
    public class Run
    {
        public void runFunc( Func temp, string? str) {
            temp.Invoke(str);   
        }

    }
    public class Program
    {

       
        static void Main(string[] args)
        {
            MyClass cls = new MyClass("Anvar");
            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;
            Run run=new Run();
            run.runFunc(funcDell, "Anvar");
        }

    }
}