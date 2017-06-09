using System;

namespace SymulatorTerrarium
	{
	public class Salata : Roslina
		{
		public Salata(int wielkosc)
			: base(wielkosc)
			{
			}

		public override bool CzyMiekkie()
			{
			return true;
			}

		public override string Status()
			{
			return base.Status() + "/salata";
			}

		public static Salata LosowaWielkosc(Random rand) => new Salata(rand.Next() % (5 - 1) + 1);
		}
	}

