using System.Text.Json;
using System;
using System.IO;



LinuxCommand[] commands = JsonSerializer.Deserialize<LinuxCommand[]>(
    File.ReadAllText("LinuxCommand.json")) ?? Array.Empty<LinuxCommand>();

Console.WriteLine("Linux Commands Reference:\n");
foreach (LinuxCommand cmd in commands)
{
    Console.WriteLine(cmd.ToString());
}

