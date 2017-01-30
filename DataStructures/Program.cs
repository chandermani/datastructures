using System;

class Program
{
    static void Main(string[] args)
    {
        Trie<int> tries = new Trie<int>();
        tries.Add("chander", 44);
        tries.Add("chandermani", 55);
        tries.Add("arora", 232);
        Console.WriteLine("key: chander value:{0}", tries.Get("chander"));
        Console.WriteLine("key: chandermani value:{0}", tries.Get("chandermani"));
        Console.WriteLine("key: test value:{0}", tries.Get("test"));
        Console.WriteLine("key: arora value:{0}", tries.Get("arora"));

        Console.ReadLine();
    }
}