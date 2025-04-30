using Ara3D.Parakeet;

namespace TwelveDaParser;
public class DebugRule : Rule
{
    private readonly Rule _innerRule;
    private readonly string _ruleName;
    public DebugRule(Rule innerRule, string ruleName) 
    {
        _innerRule = innerRule;
        _ruleName = ruleName;
    }

    protected override ParserState? MatchImplementation(ParserState state)
    {
        Console.WriteLine($"Attempting to match rule: {_ruleName} at position {state.Position}");
        ParserState result = _innerRule.Match(state);
        if (result != null)
        {
            Console.WriteLine($"Rule {_ruleName} matched successfully at position {state.Position}");
        }
        else
        {
            Console.WriteLine($"Rule {_ruleName} failed to match at position {state.Position}");
        }
        return result;
    }
}