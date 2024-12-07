/* 
* Name: Rithu Aynampudi
* email: Aynampru@mail.uc.edu
* Assignment Number: Final Project
* Due Date: 12/10/2024
* Course #/Section: IS3050-001
* Semester/Year: Fall 2024
* Brief Description of the assignment: Solving Leetcode problem #10: Regular Expression Matching
* Brief Description of what this module does: This module inputs string and pattern to implement regular expression matching
* Citations: ChatGPT
* Anything else that's relevant:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WonderfulWoodpeckers_FinalProject
{
    public class Solution1
    {
        public bool IsMatch(string s, string p)
        {
            int m = s.Length, n = p.Length;
            // Create a DP table
            bool[,] dp = new bool[m + 1, n + 1];

            // Base case: empty string matches with empty pattern
            dp[0, 0] = true;

            // Handle patterns with '*' that can match an empty string
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 2];
                }
            }

            // Fill the DP table
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                    {
                        // Current characters match
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        // '*' matches zero occurrences of the preceding character
                        dp[i, j] = dp[i, j - 2];
                        // '*' matches one or more occurrences of the preceding character
                        if (p[j - 2] == s[i - 1] || p[j - 2] == '.')
                        {
                            dp[i, j] = dp[i, j] || dp[i - 1, j];
                        }
                    }
                }
            }

            return dp[m, n];
        }
    }
}

