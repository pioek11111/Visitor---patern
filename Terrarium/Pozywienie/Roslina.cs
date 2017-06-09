using System;

namespace SymulatorTerrarium
{
	public abstract class Roslina : Pozywienie
	{
		public Roslina (int wielkosc) : base(wielkosc)
		{
		}

		public override string Status()
		{
			return base.Status() + "/roslina";
		}

		public abstract bool CzyMiekkie();

        public override void ZjedzMnie(Drapieznik d, Terrarium t)
        {            
            d.Eat(this, t);
        }
    }
}

