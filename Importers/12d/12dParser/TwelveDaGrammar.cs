using Ara3D.Parakeet;
using Ara3D.Parakeet.Grammars;

public class TwelveDaGrammar : BaseCommonGrammar
{    
    public Rule NullLine => new DebugRule(Named("null" + WS + "-999" + AnyCharUntilNextLine, "NullLine"), "NullLine");
    public Rule Comment => Named("//" + AnyCharUntilNextLine);
    public Rule Command => Identifier;
    public Rule Attribute => Identifier;
    public Rule Value => DoubleQuoteBasicString | Identifier;

    public Rule Line => Node(
        NullLine |
        Comment |
        Node(Command + ZeroOrMore(WS) + ZeroOrMore(Value)) |
        Node(Attribute + ZeroOrMore(WS) + Value)
    );
    public Rule File => new DebugRule(ZeroOrMore(Line), "File");
    public override Rule StartRule => File;
}