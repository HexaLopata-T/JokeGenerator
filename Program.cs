using System;
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
            string[] punchLines =File.ReadAllLines(punchLinesPath);

            IJokeGenerator hoholJokeGenerator = new ClassicJokeGenerator(starts, punchLines);
        }
    }
}
