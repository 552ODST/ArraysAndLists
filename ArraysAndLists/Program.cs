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
            string result = string.Empty;

            // If no one likes your post, it returns empty string
            if (names.Length == 0)
            {
                result = null;
            }
            // If one person likes your post, it returns whats asked above, "[Friend's Name] liked your post."
            else if (names.Length == 1)
            {
                result = $"{names[0]} liked your post.";
            }
            // If two people like your post, it returns both those names from the list
            else if (names.Length == 2)
            {
                result = $"{names[0]} and {names[1]} liked your post.";
            }
            // already established a result for the first three outcomes, so we can just have an else, for everyone else who liked
            else
            {
                result = $"{names[0]}, {names[1]} and {names.Length - 2} others liked your post.";
            }
            return result;
        }

        // 2 - Write a method that accepts any number of integers (minimum of two integers). If an
        // integer is a duplicate, return "Error". If all integers are unique, then order them in
        // ascending order and return the sorted result as a string of integers seperated by spaces.
        public static string NumberSorter(params int[] numbers)
        {
            string result = string.Empty;
            var numbersList = numbers.ToList();

            // first for loop goes through our list and checks each value
            for (int i = 0; i < numbersList.Count; i++)
            {
                // then we use a second for loop to check the values again
                for (var j = i + 1; j < numbersList.Count; j++)
                {
                    // so that we can check the values of i and j against each other to sort for duplicates
                    if (numbersList[i] == numbersList[j])
                    {
                        // and if a duplicate occurs we return "Error" as requested
                        return "Error";
                    }
                }
            }
            // if we go through and don't get an error, then we sort our list
            numbersList.Sort();
            // then we separte the list by spaces
            foreach (var num in numbersList)
            {
                result += num + " ";
            }
            // and be sure to trim the space at the end
            return result.Trim();
        }

        // 3 - Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. "I like trains" should return "sniart ekil I". Return
        // "Error" if no text is inputted.
        public static string ReverseName(string name)
        {
            string reverseName = string.Empty;

            // first we check to see if out given string is empty
            if (name.Length < 1)
            {
                // if it is we return this "Error" otherwise we move onto our else
                return "Error";
            }
            else
            {
                //since we cant use .Reverse we need to flip our array by going through each character starting at the last index
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    // and adding that to a new variable that starts at the end of name and works it's way backward
                    reverseName += name[i];
                }
            }
            // dinally we return our outcome of our if statement
            return reverseName;
        }
        
        // 4 - Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string seperated by
        // spaces, sorted in ascending order. Treat duplicate numbers normally.
        public static string SmallestNumbers(params int[] numbers)
        {
            // from the challenge "If none or less than 5 numbers return "Invalid Array""
            if (numbers.Length < 5)
            {
                return "Invalid Array";
            }
            // otherwise we move onto the else
            else
            {
                // and we sort our list from smallest to largest using .sort
                Array.Sort(numbers);
                // then just return the first three numbers in said list
                return numbers[0] + " " + numbers[1] + " " + numbers[2];
            }
        }

        // 5 - Write a method that accepts any number of numbers (assume at least two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
        // So for example, an array consisting of [2, 2, 1, 3] should return [1, 2, 3].
        public static int[] UniqueNumbers(params int[] numbers)
        {
            var numbersList = numbers.ToList();

            // first for loop goes through our list and checks each value
            for (int i = 0; i < numbersList.Count; i++)
            {
                // then we use a second for loop to check the values again
                for (var j = i + 1; j < numbersList.Count; j++)
                {
                    // so that we can check the values of i and j against each other to sort for duplicates
                    if (numbersList[i] == numbersList[j])
                    {
                        // if a duplicate is found we remove it from the list
                        numbersList.RemoveAt(j);
                        // need to include the decriment to account for the offset of removal
                        j--;
                    }
                }
            }
            // finally we take completed list and sort by asending order as the question wants
            numbersList.Sort();

            return numbersList.ToArray();
        }
        private static class Program
        {
            private static void Main()
            {
                string word = "";
                string result = string.Empty;

                if (word.Length == 0)
                {
                    result = "Error";
                }
                else
                {
                    for (int i = word.Length - 1; i >= 0; i--)
                    {
                        result += word[i];
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
