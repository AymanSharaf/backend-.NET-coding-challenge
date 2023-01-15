using System;
using System.Text;

/*
 
    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height)
        {
            StringBuilder pyramid = new StringBuilder();

            for (int i = 0; i < height; i++)
            {
                var line = BuildLine(i, height);
                pyramid.AppendLine(line);
            }

            Console.WriteLine(pyramid);
        }

        private static string BuildLine(int lineIndex, int pyramidHeight)
        {
            var line = new StringBuilder();

            AddSpaces(line, lineIndex, pyramidHeight);
            AddStars(line, lineIndex);

            return line.ToString();
        }

        private static void AddStars(StringBuilder line, int lineIndex)
        {
            for (int j = 0; j < (lineIndex * 2) + 1; j++)
            {
                line.Append("*");
            }
        }

        private static void AddSpaces(StringBuilder line, int lineIndex, int pyramidHeight)
        {
            for (int i = 0; i < pyramidHeight - lineIndex - 1; i++)
            {
                line.Append(" ");
            }
        }

        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}