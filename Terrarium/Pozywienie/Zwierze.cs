using System;

namespace SymulatorTerrarium
{
	public abstract class Zwierze : Pozywienie
	{
		public Zwierze (int wielkosc) : base(wielkosc)
		{

		}

		public override string Status()
		{
			return base.Status() + "/zwierze";
		}

		public abstract double PoziomSmaku();

        public override void ZjedzMnie(Drapieznik d, Terrarium t)
        {
            d.Eat(this, t);
        }
	}
}

