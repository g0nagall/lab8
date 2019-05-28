using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace lab8_3
{
	class Program
	{
		private static void ThirdTask()
		{
			using (StreamReader file = new StreamReader("for3task.txt", Encoding.UTF8))
			{
				// Создаем очередь типа People
				List<Person> people = new List<Person>();
				while (!file.EndOfStream)
				{
					string temp = file.ReadLine();
					var templist = temp.Split(' ');
					people.Add(new Person
					{
						Name = templist[0],
						Surname = templist[1],
						FathersName = templist[2],
						Age = int.Parse(templist[3]),
						Weight = int.Parse(templist[4])
					});
				}

				var newListOfPeoples = from person in people orderby person.Age select person;

				foreach (var person in newListOfPeoples)
				{
					Console.WriteLine(person.ToString());
				}
			}
		}
	}

