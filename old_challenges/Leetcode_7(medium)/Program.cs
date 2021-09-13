using System;
using System.Collections.Generic;

namespace Leetcode_7
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hello = new HashSet<string>();
            hello.Add(null);
            Console.Write(hello.Count);
            Console.WriteLine("Hello World!");
        }
    }

    public class Trie
    {

        HashSet<string> words;


        /** Initialize your data structure here. */
        public Trie()
        {
            words = new HashSet<string>();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            this.words.Add(word);
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            if (words.Contains(word)) return true;
            else return false;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            foreach (string word in words)
            {
                if (prefix.Length <= word.Length)
                {
                    if (word.Substring(0, prefix.Length) == prefix) return true;
                }
            }
            return false;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */


}
