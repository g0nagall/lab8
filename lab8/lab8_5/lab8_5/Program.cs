using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_5
{
	class Program
	{
		private static void Main()
		{
			Random rand = new Random();

			// Коллекция типа int.
			List<int> myRandomInts = new List<int>();

			// Цикл для заполнения рандомными числами.

			for (int i = 0; i < 1910; i++)
			{
				myRandomInts.Add(rand.Next(500, 700));
			}

			// Сортировка по возростанию.
			myRandomInts.Sort();

			// Вывод элементов на экран циклом foreach.
			foreach (var item in myRandomInts)
			{
				Console.WriteLine(item);
			}

			// Вставка элемента 9 на 9 позицию.
			myRandomInts.Insert(15, 16);

			// Генерация рандомного числа и проверка, есть ли оно в коллекции(если да то выводим индекс).
			int someRandInt = rand.Next(0, 916) + 700;
			Console.WriteLine("Here is our rand int: " + someRandInt);

			if (myRandomInts.Contains(someRandInt))
				Console.WriteLine("Here is index in collection: " + myRandomInts.IndexOf(someRandInt));
			else
				Console.WriteLine("\nThere is no such number as " + someRandInt + " in collection!\n");

			// Удаление рандомного элемента.
			myRandomInts.RemoveAt(rand.Next(0, myRandomInts.Count - 1));

			// Удаление коллекции.
			myRandomInts.Clear();
		}
	}
}
