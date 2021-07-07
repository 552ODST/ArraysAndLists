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
        // If more than two people like your post, it returns: "[Friend 1], [Friend 2] and [Number of Other People] others liked your post."
        public static string FacebookLikes(params string[] names)
        {
            string result;

            if (names.Length == 1)
            {
                result = names[0] + " liked your post.";
            }

            else if (names.Length == 2)
            {
                result = names[0] + " and " + names[1] + " liked your post.";
            }

            else if (names.Length >= 3)
            {
                int others = names.Length - 2;
                result = names[0] + ", " + names[1] + " and " + others.ToString() + " others liked your post.";
            }

            else
            {
                result = "";
            }

            return result;
        }

        // 2 - Write a method that accepts any number of integers (minimum of two integers). If an
        // integer is a duplicate, return "Error". If all integers are unique, then order them in
        // ascending order and return the sorted result as a string of integers separated by spaces.
        public static string NumberSorter(params int[] numbers)
        {
            string result = "";
            bool isUnique = numbers.Distinct().Count() == numbers.Count();

            if (isUnique == false)
            {
                result = "Error";
            }
            else
            {
                Array.Sort(numbers);

                foreach(int number in numbers)
                {
                    if (number == numbers[numbers.Length - 1])
                    {
                        result = result + number.ToString();
                    }
                    else
                    {
                        result = result + number.ToString() + " ";
                    }
                }
            }
            return result;
        }

        // 3 - Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. "I like trains" should return "sniart ekil I". Return
        // "Error" if no text is inputted.
        public static string ReverseName(string name)
        {
            string result = "";
            if(name == "")
            {
                result = "Error";
            }
            else
            {
                int counter = name.Length - 1;

                while (counter >= 0)
                {
                    result = result + name[counter];
                    counter--;
                }
            }

            return result;
        }

        // 4 - Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string separated by
        // spaces, sorted in ascending order. Treat duplicate numbers normally.
        public static string SmallestNumbers(params int[] numbers)
        {
            string result = "";

            int index = 0;

            ArrayList numbersList = new ArrayList();

            numbersList.AddRange(numbers);

            ArrayList smallestNumbers = new ArrayList();

            if(numbers.Length < 5)
            {
                result = "Invalid Array";
            }

            else
            {
                while( smallestNumbers.Count < 3)
                {

                    numbersList.Sort();
                    smallestNumbers.Add(numbersList[0]);
                    numbersList.RemoveAt(0);
                }

                result = smallestNumbers[0].ToString() + " " + smallestNumbers[1].ToString() + " " + smallestNumbers[2].ToString();
            }

            return result;
        }

        // 5 - Write a method that accepts any number of numbers (assume at least two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
        // So for example, an array consisting of [2, 2, 1, 3] should return an integer array of {1, 2, 3}. 
        public static int[] UniqueNumbers(params int[] numbers)
        {
            List<int> uniqueNumbers = new List<int>();
            
            foreach(int i in numbers)
            {
                if (!uniqueNumbers.Contains(i))
                {
                    uniqueNumbers.Add(i);
                }
            }

            uniqueNumbers.Sort();

            return uniqueNumbers.ToArray(); 
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
