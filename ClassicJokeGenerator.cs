using System;
using System.Collections.Generic;

class ClassicJokeGenerator : IJokeGenerator
{
    private List<string> _starts;
    private List<string> _punchLines;

    public ClassicJokeGenerator(IEnumerable<string> starts, IEnumerable<string> punchLines)
    {
        _starts = new List<string>(starts);
        _punchLines = new List<string>(punchLines);
    }

    public string GenerateJoke()
    {
        string start = _starts[new Random().Next(0, _starts.Count)];
        string punchLine = _punchLines[new Random().Next(0, _punchLines.Count)];
        return start + " " + punchLine;
    }

    public string GenerateJokeFromPattern(IEnumerable<string> starts, IEnumerable<string> punchLines)
    {
        starts = new List<string>(starts);
        punchLines = new List<string>(punchLines);
        string start = ((List<string>)starts)[new Random().Next(0, ((List<string>)starts).Count)];
        string punchLine = ((List<string>)punchLines)[new Random().Next(0, ((List<string>)punchLines).Count)];
        return start + " " + punchLine;
    }
}