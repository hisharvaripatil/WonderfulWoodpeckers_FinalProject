/* Name:Sharvari Patil
# email: patilsg@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/2024
# Course: IS 3050
# Semester/Year: Fall '24
# Brief Description: This project focuses on creating a website that solves 3 different Leetcode Problems. This particular solution is for Leetcode problem no. 4: Median of Two Sorted Arrays
# Citations: Used ChatGpt AI for solving the leetcode problem 
# Anything else that's relevant: */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WonderfulWoodpeckers_FinalProject
{
    public class Solution3
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                var temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }

            int m = nums1.Length;
            int n = nums2.Length;

            int low = 0, high = m;

            while (low <= high)
            {
                int partition1 = (low + high) / 2;
                int partition2 = (m + n + 1) / 2 - partition1;

                
                int maxLeft1 = (partition1 == 0) ? int.MinValue : nums1[partition1 - 1];
                int minRight1 = (partition1 == m) ? int.MaxValue : nums1[partition1];

                
                int maxLeft2 = (partition2 == 0) ? int.MinValue : nums2[partition2 - 1];
                int minRight2 = (partition2 == n) ? int.MaxValue : nums2[partition2];

                
                if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1)
                {
                    
                    if ((m + n) % 2 == 1)
                    {
                        return Math.Max(maxLeft1, maxLeft2);
                    }
                  
                    else
                    {
                        return (Math.Max(maxLeft1, maxLeft2) + Math.Min(minRight1, minRight2)) / 2.0;
                    }
                }
                
                else if (maxLeft1 > minRight2)
                {
                    high = partition1 - 1;
                }
               
                else
                {
                    low = partition1 + 1;
                }
            }

            throw new ArgumentException("Input arrays are not sorted.");
        }
    }
}
