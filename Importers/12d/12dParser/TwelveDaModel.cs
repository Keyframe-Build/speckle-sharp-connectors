namespace TwelveDaParser;
public class TwelveDaModel
{
    public List<string> NullLines { get; set; } = new List<string>();
    public List<string> Comments { get; set; } = new List<string>();
    public List<string> Commands { get; set; } = new List<string>();
    public List<KeyValuePair<string, string>> Attributes { get; set; } = new List<KeyValuePair<string, string>>();
}