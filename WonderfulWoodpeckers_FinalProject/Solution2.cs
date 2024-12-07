/*
 * Name: Jacob Brumfield
 * Email: Brumfijb@mail.uc.edu
 * Assignment Number: Final Project
 * Due Date: 12/10
 * Course #/Section: IS 3050 001
 * Semester/Year: Fall 2024
 * Brief Desciption of the assignment: Solving leetcode problem #30. Substring with Concatenation of All Words.
 * Brief Description of what this module does: Returns an array of the starting indices of all concatenated substrings in
 * s. You can return the answer in any order.
 * Citations: Gemini and ChatGPT.
 * */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WonderfulWoodpeckers_FinalProject
{


    public class Solution2
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var result = new List<int>();
            var wordsLenght = words.Length;
            var sLenght = s.Length;
            if (sLenght == 0 || wordsLenght == 0) { return result; }

            var wordLenght = words[0].Length;
            var concatLenght = wordsLenght * wordLenght;

            if (concatLenght > sLenght) { return result; }

            var wordsMap = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordsMap.ContainsKey(word))
                {
                    wordsMap[word]++;
                }
                else
                {
                    wordsMap[word] = 1;
                }
            }
            IDictionary<string, int> used;

            int i, j, count;
            var subString = string.Empty;
            bool allUsed = false;
            for (i = 0; i <= sLenght - concatLenght; i++)
            {
                used = new Dictionary<string, int>(wordsMap);

                for (j = i; j <= sLenght - wordLenght; j += wordLenght)
                {
                    subString = s.Substring(j, wordLenght);
                    if (used.TryGetValue(subString, out count))
                    {
                        if (count == 0) { break; }
                        used[subString]--;
                    }
                    else
                    {
                        break;
                    }
                }

                allUsed = true;
                foreach (var pair in used)
                {
                    if (pair.Value > 0) { allUsed = false; break; }
                }

                if (allUsed) { result.Add(i); }
            }

            return result;
        }
    }
}
