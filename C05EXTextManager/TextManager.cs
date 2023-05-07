using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EXTextManager
{
    internal class TextManager
    {

        public string FindLongestWord(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                throw new ArgumentNullException("Sentence cannot consist of white spaces or null");

            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
                throw new InvalidOperationException("Sentence does not contain any words.");

            string longestWord = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length>longestWord.Length)
                    longestWord = words[i];
            }

            return longestWord;
        }
        public List<string> FindAllLongestWords(string sentence) 
        {
            int j = 0;
            
            if (string.IsNullOrWhiteSpace(sentence))
                throw new ArgumentNullException("Sentence cannot consist of white spaces or null");

            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
                throw new InvalidOperationException("Sentence does not contain any words.");

            List<string> longestWords = new List<string>();
            int maxLength = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                    longestWords.Clear();
                    longestWords.Add(words[i]);
                }
                else if (words[i].Length == maxLength)
                {
                    longestWords.Add(words[i]);
                }
            }

            return longestWords;

        }


    }
}
