using System;
using System.Collections.Generic;
using System.Linq;

public class Trie<T>
{
    public TrieNode<T> Root { get; set; }

    public Trie()
    {
        this.Root = new TrieNode<T>();
    }

    public void Add(string key, T data)
    {
        TrieNode<T> node = this.Root;
        for (int i = 0; i < key.Length; i++)
        {
            var child = node.GetChild(key[i]);
            node = child == null ? node.AddChild(key[i]) : child;
        }

        node.Data = data;
    }

    public T Get(string key)
    {
        TrieNode<T> node = this.Root;

        if (string.IsNullOrWhiteSpace(key))
        {
            return default(T);
        }

        for (int i = 0; i < key.Length; i++)
        {
            node = node.GetChild(key[i]);
            if (node == null)
            {
                return default(T);
            }
        }

        return node.Data;
    }

    public bool IsMember(string key)
    {
        return false;
    }
}

public class TrieNode<T>
{
    private const int CHARS = 26;
    public TrieNode()
    {
        this.Children = new TrieNode<T>[CHARS];
    }

    public char Key { get; private set; }
    public T Data { get; set; }
    public TrieNode<T>[] Children { get; set; }

    public TrieNode<T> AddChild(char key)
    {
        this.Children[this.KeyIndex(key)] = new TrieNode<T>();
        return Children[this.KeyIndex(key)];
    }

    public int KeyIndex(char key)
    {
        return key - 'a';
    }

    public TrieNode<T> GetChild(char key)
    {
        return this.Children[this.KeyIndex(key)];
    }
}
