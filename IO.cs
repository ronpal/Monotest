using System;
using System.IO;

namespace Monotest
{
	public class IO 
	{
	
		const bool _debug = true;

		public IO Write(string text)
		{
			Console.WriteLine(text);
			return this;
		}

		public void Debug(object text)
		{
			if( _debug ) 
				Console.WriteLine(text);
		}

		public string ReadAllText(string path)
		{
			return File.ReadAllText( path );
		}

	}
}