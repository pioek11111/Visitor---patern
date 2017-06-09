using System;

namespace SymulatorTerrarium
	{
	class MainClass
		{
		public static void Main(string[] args)
			{
			Random rand = new Random();
			Terrarium terrarium = new Terrarium(rand);
			
			while (true)
				{
				Console.WriteLine("Symulator terrarium");
				Console.WriteLine("1 - dodaj losowe pozywienie");
				Console.WriteLine("2 - dodaj losowe drapiezniki");
				Console.WriteLine("3 - ustaw temperature terrarium");
				Console.WriteLine("4 - pokaz aktualny status");
				Console.WriteLine("5 - wykonaj symulacje");
				Console.WriteLine("6 - wyjscie");
				Console.WriteLine();

				int wartosc;
				int indeks;

				switch (Console.ReadLine())
					{
					case "1":
						Console.WriteLine("Wpisz liczbe pozywienia do wygenerowania");

						while (!int.TryParse(Console.ReadLine(), out wartosc))
							Console.WriteLine("Nieprawidlowa wartosc");
					
						terrarium.DodajLosowePozywienie(wartosc);
						break;

					case "2":
						Console.WriteLine("Wpisz liczbe drapieznikow do wygenerowania");

						while (!int.TryParse(Console.ReadLine(), out wartosc))
							Console.WriteLine("Nieprawidlowa wartosc");

						terrarium.DodajLosoweDrapiezniki(wartosc);
						break;

					case "3":
						Console.WriteLine("Wpisz temperature terrarium");

						while (!int.TryParse(Console.ReadLine(), out wartosc))
							Console.WriteLine("Nieprawidlowa wartosc");

						terrarium.Temperatura = wartosc;
						break;

					case "4":
						Console.WriteLine("Aktualny status");

						Console.WriteLine("Pozywienie:");

						indeks = 1;

						foreach (Pozywienie p in terrarium.ListaPozywienia)
							Console.WriteLine("{0}: {1}", indeks++, p.Status());

						Console.WriteLine("Drapiezniki:");

						indeks = 1;

						foreach (Drapieznik f in terrarium.ListaDrapieznikow)
							Console.WriteLine("{0}: {1}", indeks++, f.Status());

						Console.WriteLine("Temperatura:");
						Console.WriteLine("{0} stopni", terrarium.Temperatura);

						break;

					case "5":
						Console.WriteLine("Wpisz liczbe krokow do zasymulowania");

						while (!int.TryParse(Console.ReadLine(), out wartosc))
							Console.WriteLine("Nieprawidlowa wartosc");

						terrarium.Symuluj(wartosc);
						break;

					case "6":
						return;
					}
				}
			}
		}
	}
