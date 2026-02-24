/* 
 * Filename: Lasagna.cs
 * Description: A skeleton class for a C# practical exercise covering basic programming tasks
 * such as declaring variables, methods, returning data from methods. 
 * 
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/practice/scrabble-score
 */

using System.Collections.Generic;
using System.Linq;

namespace Scrabble
{
    public static class ScrabbleScore
    {        
        /// <summary>
        /// Calculates the score based on the specified input string.Each letter in the input string is scored
        /// according to the following rules:
        /// 1 point : A, E, I, O, U, L, N, R, S, T
        /// 2 points : D, G
        /// 3 points : B, C, M, P
        /// 4 points : F, H, V, W, Y
        /// 5 points : K
        /// 8 points : J, X
        /// 10 points : Q, Z
        /// For example the word "cabbage" is worth 14 points
        /// </summary>
        /// <param name="input">The input string to evaluate and compute the score. Cannot be null.</param>
        /// <returns>An integer representing the calculated score for the provided input.</returns>
        public static int Score(string input)
        {
            // TODO - Implement the Score method. Hint you can implement this without selection statements. Think
            // about how what data you need and how you could store the date. Use your knowledge of the content
            // from the algorithms and data structures module you are also studying.
            //throw new NotImplementedException("You need to implement this method
            char[] alphabet = ['A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T', 'D', 'G', 'B', 'C', 'M', 'P', 'F', 'H', 'V', 'W', 'Y', 'J', 'X', 'Q', 'Z', 'K'];
            int[] score = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 8, 8, 10, 10, 5];
            Dictionary<char, int> openWith = new Dictionary<char, int>();
            int points = 0;

            char[] letters = input.ToUpper().ToCharArray();

            for (int i=0; i < alphabet.Length; i++)
            {
                openWith.Add(alphabet[i], score[i]);
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (openWith.ContainsKey(letters[i]))
                {
                    points += openWith[letters[i]];
                }
            }

            return points;
        }

    }
}
