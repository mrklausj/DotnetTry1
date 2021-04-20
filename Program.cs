using System;

namespace DotnetTry1
{
    class Program
    {
        class TryBranc
        {
            public string testing { get => "testing branch"; set { } }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // code that is changed after pull request from github

            Console.WriteLine("Testing new code");

            // trying Branch
            TryBranc tb = new TryBranc();
            Console.WriteLine(tb.testing);
        }
    }
}
