/*
 * Name: Jacob Brumfield, Sharvari Patil, Rithu Aynampudi
 * Email: brumfijb@mail.uc.edu, patilsg@mail.uc.edu, aynampru@mail.uc.edu
 * Assignment Number: Final Project- Wonderful Woodpeckers
 * Due Date: 12/10
 * Course #/Section: IS 3050 001
 * Semester/Year: Fall 2024
 * Brief Desciption of the assignment: Creating a functional website that solves 3 hard Leetcode problems with the help of GitHub. 
 * Citations: GoogleGemini and ChatGPT.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderfulWoodpeckers_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void problembtn_Click(object sender, EventArgs e)
        {           
            string selectedProblem = problemsDropdown.SelectedValue;
         
            switch (selectedProblem)
            {
                case "ExpressionProblem":                    
                    problemDescription.Text = "Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).This problem is about regular expression matching with support for '.' and '*' characters.";
                    testCase.Text = "Test case: s = \"aa\", p = \"a*\"";

                    
                    Solution1 solution1 = new Solution1();
                    bool result1 = solution1.IsMatch("aa", "a*");
                    solutionOutput.Text = "Solution Output: " + result1.ToString();
                    break;

                case "SubstringProblem":                 
                    problemDescription.Text = "You are given a string s and an array of strings words. All the strings of words are of the same length. Return an array of the starting indices of all the concatenated substrings in s. You can return the answer in any order. A concatenated string is a string that exactly contains all the strings of any permutation of words concatenated.This problem asks to find the substring concatenation of all words in a string.";
                    testCase.Text = "Test case: s = \"barfoothefoobarman\", words = [\"foo\", \"bar\"]";

                    
                    Solution2 solution2 = new Solution2();
                    IList<int> result2 = solution2.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" });
                    solutionOutput.Text = "Solution Output: " + string.Join(", ", result2);
                    break;

                case "MedianProblem":
                    problemDescription.Text = "Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).This problem is about finding the median of two sorted arrays.";
                    testCase.Text = "Test case: nums1 = [1, 3], nums2 = [2]";

                   
                    Solution3 solution3 = new Solution3();
                    double result3 = solution3.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
                    solutionOutput.Text = "Solution Output: " + result3.ToString();
                    break;

                default:
                    problemDescription.Text = "Please select a problem.";
                    testCase.Text = "N/A";
                    solutionOutput.Text = "N/A";
                    break;
            }
        }

   
    }
}  
        
        
    

                
    
