using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab8_2
{
	class Program
	{
		private static void Main()
		{
			using (StreamReader file = new StreamReader("for2task.txt", Encoding.UTF8))
			{
				// Создаем очередь типа People
				Queue<Person> people = new Queue<Person>();
				while (!file.EndOfStream)
				{
					string temp = file.ReadLine();
					var templist = temp.Split(' ');
					people.Enqueue(new Person
					{
						Name = templist[0],
						Surname = templist[1],
						FathersName = templist[2],
						Age = int.Parse(templist[3]),
						Weight = int.Parse(templist[4])
					});
				}

				// Создаем подсписок людей, возраст которых меньше 40 лет.
				var youngPeople = from p in people where p.Age < 30 select p;

				var youngPeopleAreFirst = (from b in youngPeople select b).Concat(from c in people select c).Distinct();

				foreach (var person in youngPeopleAreFirst)
				{
					Console.WriteLine(person.ToString());
				}
			}
		}
	}
}