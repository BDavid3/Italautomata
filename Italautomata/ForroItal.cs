using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
	internal class ForroItal
	{
		protected string nev;
		protected int ar;
		protected int cukor;

		public ForroItal(string nev, int ar, int cukor)
		{
			this.nev = nev;
			this.ar = ar;
			this.cukor = cukor;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Ar { get => ar; set => ar = value; }
		public int Cukor { get => cukor;}

		public void Aremeles(int osszeg)
		{
			this.ar += osszeg;
		}

		public virtual void Aremeles()
		{
			this.ar = (int)(this.ar + this.ar * 0.1);
		}

		public override string ToString()
		{
			return $"{this.nev} {this.cukor} cukorral {this.ar}Ft";
		}
	}
}
