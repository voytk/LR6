using System;
using System.IO;
using System.Text;

namespace ConsoleApp10
{
	class Program
	{
		static void Main()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("List of files in the Media folder:");
			Console.WriteLine("Name\t\tFormat\tPossible actions");
			foreach (string s in Directory.EnumerateFiles("media\\"))
			{
				Console.Write(Path.GetFileName(s) + '\t');
				PlayerItem item = PlayerItem.DefineMedia(s);
				if (item is MkvVideo)
				{
					Console.Write("MKV\t");
					Console.Write("Play, Pause, Stop");
				}
				else if (item is Mp3Audio)
				{
					Console.Write("MP3\t");
					Console.Write("Record, Pause, Stop");
				}
				else if (item is WaveAudio)
				{
					Console.Write("WAVE\t");
					Console.Write("Play, Record, Pause, Stop");
				}
				else
				{
					Console.Write("Unknown\t");
					Console.Write("N/A");
				}
				Console.WriteLine();
			}
		}
	}
}
