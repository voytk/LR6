using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
	public interface IPlayable : IMedia
	{
		void Play();
		void Pause();
		void Stop();
	}
}