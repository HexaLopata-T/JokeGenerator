using System;
using System.Collections.Generic;
using System.IO;

namespace HoholGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string startsPath = "JokeStarts.txt";
            string punchLinesPath = "JokePunchLines.txt";

            string[] starts = File.ReadAllLines(startsPath);
            string[] punchLines = File.ReadAllLines(punchLinesPath);

            IJokeGenerator jokeGenerator = new ClassicJokeGenerator(starts, punchLines);

            List<string> jokes = new List<string>();

            for(int i = 0; i < 100; i++)
            {
                jokes.Add(jokeGenerator.GenerateJoke());
            }
            File.WriteAllLines("Jokes.txt", jokes);
        }
    }
}
