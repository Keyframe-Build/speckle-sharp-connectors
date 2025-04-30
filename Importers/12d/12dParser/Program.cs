using Ara3D.Parakeet;

namespace TwelveDaParser;
public static class Program
{
    public static void Main()
    {
        var grammar = new TwelveDaGrammar();
        

        string filePath = "26-CIVIL C 301 01 BAYSWATER PORTAL T11.12da";
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}");
            return;
        }        
        var parserInput = ParserInput.FromFile(filePath);
        Console.WriteLine(parserInput);
        Console.WriteLine($"Starting to parse {parserInput.LineToChar.Count} lines containing {parserInput.Text.Length} characters.");
        var rule = grammar.Command;
        Console.WriteLine(rule);
        
        var state = new ParserState(parserInput);
        var match = rule.Match(state);
        Console.WriteLine(match);
        
        if (match == null) 
        {
            Console.WriteLine("Unrecoverable parser failure");
        }
        else
        {
    
            while (!match.AtEnd())
            {
                
                Console.WriteLine(match.CurrentLine);
                match = grammar.Command.Match(state);
            }
        }

    // Convert the parsed characters to an integer
    //Console.Write(result);
  }
}
