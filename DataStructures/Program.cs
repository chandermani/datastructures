using System;

class Program
{
    static void Main(string[] args)
    {
        Trie<int> tries = new Trie<int>();
        tries.Add("chander", 44);
        tries.Add("chandermani", 55);
        Console.WriteLine("chander {0}", 44);
        Console.WriteLine("chandermani {0}", 55);
        Console.WriteLine("test {0}", 0);

        Console.ReadLine();
    }
}