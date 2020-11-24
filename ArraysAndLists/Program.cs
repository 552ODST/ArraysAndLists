using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace ArraysAndLists
{
    public static class ArraysAndLists
    {
        // 1- When you post a message on Facebook, depending on the number of people who like your
        // post, Facebook returns different information.

        // Write a method that accepts any number of names.
        // Return a string based on the below pattern.
        // If no one likes your post, it returns an empty string.
        // If only one person likes your post, it returns: "[Friend's Name] liked your post."
        // If two people like your post, it returns: "[Friend 1] and [Friend 2] liked your post."
        // If more than two people like your post, it returns: "[Friend 1], [Friend 2] and [Number of Other People] others liked your post."
        public static string FacebookLikes(params string[] names)
        {
            //var noOne = "empty";
            //var onePerson = "[Friend's Name] liked your post.";
            //var twoPeople = "[Friend 1] and [Friend 2] liked your post.";
            //var multPeople = "[Friend 1], [Friend 2] and [Number of Other People] others liked your post.";
            //if (Convert.ToInt32(names.Length) == 0)
            //{
            //    return "empty";
            //}
            //else if (Convert.ToInt32(names.Length) == 1)
            //{
            //    return names[0];
            //}
            //else if (Convert.ToInt32(names.Length) == 2)
            //{
            //    return names[0] + names[1];
            //}
            //else
            //{
            //    return (names[0] + names[1] + (Convert.ToInt32(names.Length) - 2));
            //}
            return default;

        }

        // 2 - Write a method that accepts any number of integers (minimum of two integers). If an
        // integer is a duplicate, return "Error". If all integers are unique, then order them in
        // ascending order and return the sorted result as a string of integers seperated by spaces.
        public static string NumberSorter(params int[] numbers)
        {
            if (numbers.Length != numbers.Distinct().Count())
            {
                return "Error";
            }
            else
                Array.Sort(numbers);

            return (numbers + " ");
        }

        // 3 - Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. "I like trains" should return "sniart ekil I". Return
        // "Error" if no text is inputted.
        public static string ReverseName(string name)
        {
            string[] backwardArray = new string[] { name };

            if (backwardArray == null || backwardArray.Length < 1)
            {
                return "Error";
            }
            else
            {
                Array.Reverse(backwardArray);
            }
            return (backwardArray);
        }

        // 4 - Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string seperated by
        // spaces, sorted in ascending order. Treat duplicate numbers normally.
        public static string SmallestNumbers(params int[] numbers)
        {
            int firstMin = int.MaxValue;
            int secondMin = int.MaxValue;
            int thirdMin = int.MaxValue;

         /*   if (numbers == null || numbers.Length < 5)
            {
                return "Invalid Array";
            }*/
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers == null || numbers.Length < 5)
                {
                    return "Invalid Array";
                }
                    if (numbers[i] < firstMin)
                {
                    firstMin = numbers[i];
                    secondMin = firstMin;
                    thirdMin = secondMin;
                }
                else if (numbers[i] < secondMin)
                {
                    secondMin = numbers[i];
                    thirdMin = secondMin;
                }
                else if (numbers[i] < thirdMin)
                {
                    thirdMin = numbers[i];
                }

            }    
        }

        // 5 - Write a method that accepts any number of numbers (assume at least two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
        // So for example, an array consisting of [2, 2, 1, 3] should return [1, 2, 3].
        public static int[] UniqueNumbers(params int[] numbers)
        {
            if (numbers.Length != numbers.Distinct().Count())
            {
                Array.Sort(numbers);
            }
            else
            {
                Array.Sort(numbers)
            }
        }

        private static class Program
        {
            private static void Main()
            {
                // Use this section to test code should you feel the need.
                // Console.WriteLine(whatever);
            }
        }
    }
}
