using System;

namespace SymulatorTerrarium
{
	public abstract class Pozywienie
	{
		public int Wielkosc { get; private set; }
		
		public Pozywienie (int size)
		{
			Wielkosc = size;
		}

		public void Rosnij()
		{
			++Wielkosc;
		}

		public void WyzerujWielkosc()
		{
			Wielkosc = 0;
		}

		public virtual string Status()
		{
			return string.Format("pozywienie(wielkosc={0})", Wielkosc);
		}

        public abstract void ZjedzMnie(Drapieznik d, Terrarium t);
    }
}

