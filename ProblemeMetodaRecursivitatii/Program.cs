using System;

namespace ProblemeMetodaRecursivitatii
{
	class Program
	{
		static void Main(string[] args)
		{
			bool showMenu = true;
			while (showMenu)
			{
				showMenu = MainMenu();
			}
		}

		private static bool MainMenu()
		{
			Console.Clear();
			Console.WriteLine("Probleme rezolvate cu metoda recursivitatii");
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("Alege o optiune din meniu:");
			Console.WriteLine("1) Minim si Maxim intr-un vector");
			Console.WriteLine("2) Sirul lui Fibonacci");
			Console.WriteLine("3) Gasire Index in sir crescator (metoda binara)");
			Console.WriteLine("4) Exit");
			Console.Write("\r\nSelecteaza o optiune: ");

			switch (Console.ReadLine())
			{
				case "1":
					{
						Console.Clear();
						Console.WriteLine("1) Minim si Maxim intr-un vector");
						Console.WriteLine("--------------------------------");
						Console.Write("Cate elemente contine vectorul: ");
						int n = int.Parse(Console.ReadLine());
						int[] A = new int[n];

						Console.WriteLine("Introduceti elementele din vector:");
						for (int i = 0; i < n; i++)
						{
							Console.Write("Elementul " + (i + 1) + " este: ");
							A[i] = int.Parse(Console.ReadLine());
						}
						Console.WriteLine("Minimul din Vector este: " + minVector(A, n));
						Console.WriteLine("Maximul din Vector este: " + maxVector(A, n));
						Console.ReadLine();
						return true;
					}
				case "2":
					{
						Console.Clear();
						Console.WriteLine("2) Sirul lui Fibonacci");
						Console.WriteLine("----------------------");
						Console.Write("Introduceti \"n\" din Sirul lui Fibonacci: ");
						int numar = Convert.ToInt32(Console.ReadLine());
						Console.Write("Rezultatul Sirului lui Fibonacci pentru cele " + numar + " numere este: " + Fibonacci(numar));
						Console.ReadLine();
						return true;
					}
				case "3":
					{
						Console.Clear();
						Console.WriteLine("3) Gasire Index in sir crescator (metoda binara)");
						Console.WriteLine("------------------------------------------------");
						int[] iArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

						// Determin numarul de index al unui element anume dintr-un sir (vector) de lungime variabila 

						//	Aici solicit introducerea de la tastatura a numarului de elemente pe care vreau sa le contina sirul
						//	Console.Write("Cate elemente contine sirul: ");
						//	int nrElemente = int.Parse(Console.ReadLine());
						//	int[] iArray = new int[nrElemente];

						//	Aici solicit introducerea de la tastatura a fiecarui element din sir (vector)
						//	Console.WriteLine("Introduceti elementele din sir:");
						//	for (int i = 0; i < nrElemente; i++)
						//		{
						//		Console.Write("Elementul " + (i) + " este: ");
						//		iArray[i] = int.Parse(Console.ReadLine());
						//		}

						Console.WriteLine("Sirul ordonat creascator este: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
						Console.Write("Index-ul carui element din sirul de mai sus doriti sa il aflati: ");
						int number = Convert.ToInt32(Console.ReadLine());
						binary b = new binary();
						Console.WriteLine("Numarul de index al elementului este: {0}", b.searching(iArray, 0, iArray.Length - 1, number));
						Console.ReadLine();
						return true;
					}
				case "4":
					return false;
				default:
					return true;
			}
		}

		// Gasire element maxim din vector, 
		// folosind recursivitatea
		public static int minVector(int[] A, int n)
		{
			// if size = 0 means whole array 
			// has been traversed 
			if (n == 1)
				return A[0];

			return Math.Min(A[n - 1], minVector(A, n - 1));
		}


		// Gasire element maxim din vector, 
		// folosind recursivitatea 
		public static int maxVector(int[] A, int n)
		{
			// if size = 0 means whole array 
			// has been traversed 
			if (n == 1)
				return A[0];

			return Math.Max(A[n - 1], maxVector(A, n - 1));
		}

		// Sirul lui Fibonacci  
		// folosind recursivitatea 
		public static int Fibonacci(int numar)
		{
			if (numar <= 1)
			{
				return numar;
			}
			else
			{
				return Fibonacci(numar - 1) + Fibonacci(numar - 2);
			}
		}

		// cautare binara, folosind recursivitatea
		public class binary
		{
			public int searching(int[] array, int first, int last, int value)
			{
				int middle = (first + last) / 2;
				if (array[middle] == value)
				{
					return middle;
				}
				else if (first >= last)
				{
					return -1;
				}
				else if (value < array[middle])
				{
					return searching(array, first, middle, value);
				}
				else
				{
					return searching(array, middle, last, value);
				}
			}
		}
	}
}


