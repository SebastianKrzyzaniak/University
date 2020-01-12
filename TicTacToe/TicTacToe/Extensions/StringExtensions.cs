using System.IO;
using TicTacToe.BusinessLayer.Model;

namespace TicTacToe.Extensions
{
    public static class StringExtensions
    {
        public static string GetImagePath(this string currStr, Player player)
        {
            return currStr + player.Sign.ToString() + ".png";
        }

        /// <summary>
        /// Returns 
        /// </summary>
        /// <param name="currStr"></param>
        /// <param name="lvlToBack">How many levels of path go backwards</param>
        /// <returns></returns>
        public static string GetDirectoryName(this string currStr, int lvlToBack)
        {
            if (!Directory.Exists(currStr)) return currStr;

            var newPath = currStr;

            for (int i = 0; i < lvlToBack; i++)
            {
                newPath = Path.GetDirectoryName(newPath);
            }

            return newPath;
        }
    }
}
