using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Replace the exception statement below with your code!
            //If the word is null or empty, return the word  
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return null;
            }
            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round(originalPrice * (100 + vatRate) / 100, 2);
        }

        public string Reverse(string sentence)
        {
           if(string.IsNullOrEmpty(sentence))
            {
                return null;
            }
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int CountLinuxUsers(List<User> users)
        {
            int count = 0;
            if(users == null)
            {
                return count;
            }
            foreach (User user in users)
            {
                if (user.Type == "Linux")
                {
                    count++;
                }
            }
            return count;
        }
    }
}
