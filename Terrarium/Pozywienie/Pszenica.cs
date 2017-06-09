using System;

namespace SymulatorTerrarium
	{
	public class Pszenica : Roslina
		{
		public Pszenica(int wielkosc)
			: base(wielkosc)
			{
			}

		public override bool CzyMiekkie()
			{
			return false;
			}

		public override string Status()
			{
			return base.Status() + "/pszenica";
			}

		public static Pszenica LosowaWielkosc(Random rand) => new Pszenica(rand.Next() % (10 - 5) + 5);
		}
	}

