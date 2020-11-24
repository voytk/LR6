using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
	public interface IRecordable : IMedia
	{
		void Record();
		void Pause();
		void Stop();
	}
}
