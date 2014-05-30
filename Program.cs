
using System;
using System.IO;
using Newtonsoft.Json;
//1: Komprimer H0, finn H1-Hn
//2: Finn minste Hn 
//3: Verifiser Hn=H0

namespace Monotest
{
	public class Program 
	{
		public static void Main()
		{
			var data = File.ReadAllLines("data.json");
			foreach( var line in data)
				Console.WriteLine(line);	
			Console.WriteLine("Hello mono");

		}

	}
}