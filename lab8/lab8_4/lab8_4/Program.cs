using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab8_4
{
	class Program
	{
		private static void Main()
		{
			using (StreamReader file = new StreamReader("for4task.txt", Encoding.UTF8))
			{
				Stack<int> myInts = new Stack<int>();
				while (!file.EndOfStream)
				{
					myInts.Push(int.Parse(file.ReadLine()));
				}

				using (StreamWriter newFile = new StreamWriter("outputfor4task.txt"))
				{
					foreach (var i in myInts)
					{
						Console.Write(i + " ");
						newFile.Write(i + " ");
					}
				}
			}
		}
	}
}
