using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp10
{
	class PlayerItem
	{
		public IMedia FileRef
		{
			get; set;
		}
		public static PlayerItem DefineMedia(string path)
		{
			if (!File.Exists(path))
				return null;
			switch (Path.GetExtension(path).ToUpper())
			{
				case ".MKV":
					return new MkvVideo();
				case ".MP3":
					return new Mp3Audio();
				case ".WAV":
				case ".WAVE":
					return new WaveAudio();
				default:
					return null;
			}
		}
	}
}