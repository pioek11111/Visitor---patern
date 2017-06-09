using System;

namespace SymulatorTerrarium
	{
	public class Zuk : Zwierze
		{
		public Zuk(int wielkosc)
			: base(wielkosc)
			{
			}

		public override double PoziomSmaku()
			{
			return 0.75;
			}

		public override string Status()
			{
			return base.Status() + "/zuk";
			}

		public static  Zuk LosowaWielkosc(Random rand) => new Zuk(rand.Next() % (12 - 8) + 8);
		}
	}

