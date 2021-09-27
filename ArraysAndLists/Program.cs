using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;

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
        // If more than two people like your post, it returns: "[Friend 1], [Friend 2]
        // and [Number of Other People] others liked your post."
        public static string FacebookLikes(params string[] names)
        {

            if (names.Count() >= 3)
            {
                return names[0] + ", " + names[1] + " and " + Convert.ToString(names.Count() - 2) + " others liked your post.";
            }
            else if (names.Count() == 2)
            {
                return names[0] + " and " + names[1] + " liked your post.";
            }
            else if (names.Count() == 1)
            {
                return names[0] + " liked your post.";
            }
            else
            {
                return null;
            }
        }

        // 2 - Write a method that accepts any number of integers (minimum of two integers). If an
        // integer is a duplicate, return "Error". If all integers are unique, then order them in
        // ascending order and return the sorted result as a string of integers separated by spaces.
        public static string NumberSorter(params int[] numbers)
        {
            int temp;
            string result = "";
            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = i + 1; j < numbers.Count(); j++)
                {
                    if (i == numbers.Count())
                    {
                        break;
                    }
                    if (numbers[i] == numbers[j])
                    {
                        return "Error";
                    }
                }
            }
            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = 0; j < numbers.Count(); j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (i == numbers.Count() - 1)
                {
                    result += Convert.ToString(numbers[i]);
                }
                else
                {
                    result += Convert.ToString(numbers[i]) + " ";
                }
            }
            return result;
        }

        // 3 - Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. "I like trains" should return "sniart ekil I". Return
        // "Error" if no text is inputted.
        public static string ReverseName(string name)
        {
            if (name == "")
            {
                return "Error";
            }
            char[] array = name.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        // 4 - Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string separated by
        // spaces, sorted in ascending order. Treat duplicate numbers normally.
        public static string SmallestNumbers(params int[] numbers)
        {
            int temp = 0;

            if (numbers.Length < 5)
            {
                return "Invalid Array";
            }

            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = 0; j < numbers.Count(); j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return string.Format("{0} {1} {2}", numbers[0], numbers[1], numbers[2]);
        }

        // 5 - Write a method that accepts any number of numbers (assume at least two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
        // So for example, an array consisting of [2, 2, 1, 3] should return an integer array of {1, 2, 3}. 
        public static int[] UniqueNumbers(params int[] numbers)
        {
            int k = 0;
            int[] result = new int[0];
            int temp = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = 0; j < numbers.Count(); j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {

                Array.Resize(ref result, result.Length + 1);

                if (i == 0 || numbers[i] != result[k - 1])
                {
                    result[k] = numbers[i];
                    k++;
                }

                else if (numbers[i] == result[k - 1])
                {
                    Array.Resize(ref result, result.Length - 1);
                }
            }
            return result;
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
