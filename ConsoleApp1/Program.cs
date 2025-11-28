using System.Text.Json;


LinuxCommand[] commands = JsonSerializer.Deserialize<LinuxCommand[]>(
    File.ReadAllText("LinuxCommands.json")) ?? Array.Empty<LinuxCommand>();

Console.WriteLine("Linux Commands Reference:\n");
foreach (LinuxCommand cmd in commands)
{
    Console.WriteLine(cmd.ToString());
}

internal class LinuxCommand
{
}