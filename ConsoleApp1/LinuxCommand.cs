
using System.Text.Json.Serialization;
public class LinuxComands{

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("usage")]
    public string Usage { get; set; } = string.Empty;

    [JsonPropertyName("options")]
    public string[] Options { get; set; } = Array.Empty<string>();

    [JsonPropertyName("example")]
    public string Example { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Command: {Name}\n" +
               $"Description: {Description}\n" +
               $"Usage: {Usage}\n" +
               $"Example: {Example}\n" +
               $"Options: {string.Join(", ", Options)}\n" +
               new string('-', 50);
    }




}
