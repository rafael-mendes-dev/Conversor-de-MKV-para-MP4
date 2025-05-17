using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.Write("Digite o caminho do arquivo MKV: ");
        string inputFile = Console.ReadLine()!;

        string outputFile = Path.Combine(Path.GetDirectoryName(inputFile)!, "output.mp4");

        ConvertMkvToMp4(inputFile, outputFile);
    }

    static void ConvertMkvToMp4(string inputPath, string outputPath)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "ffmpeg",
            Arguments = $"-i \"{inputPath}\" -c:v copy -c:a aac \"{outputPath}\"",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process process = new Process { StartInfo = startInfo })
        {
            process.OutputDataReceived += (sender, args) => Console.WriteLine(args.Data);
            process.ErrorDataReceived += (sender, args) => Console.WriteLine(args.Data);

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }

        Console.WriteLine("Conversão concluída!");
    }
}