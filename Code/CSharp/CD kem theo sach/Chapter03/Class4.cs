using System;
using System.IO;
class Class4
	{
	static void Main()
	{	
		Console.WriteLine("List of File");
		foreach(string name in Directory.GetFiles("C:\\"))
		{
			Console.WriteLine(name);
		}
		Console.ReadLine();
	}
}	
