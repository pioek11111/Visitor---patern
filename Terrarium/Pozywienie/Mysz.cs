using System;

namespace SymulatorTerrarium
	{
	public class Mysz : Zwierze
		{
		public Mysz(int wielkosc)
			: base(wielkosc)
			{
			}

		public override double PoziomSmaku()
			{
			return 0.25;
			}

		public override string Status()
			{
			return base.Status() + "/mysz";
			}

		public static Mysz LosowaWielkosc(Random rand) => new Mysz(rand.Next() % (20 - 15) + 15);
	    
		}
	}

