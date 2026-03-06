using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
	internal class Capuccino : Kave
	{
		private bool tejszinhab;

		public Capuccino(string nev, int ar, int cukor, string tej, bool tejszinhab) : base(nev, ar, cukor, tej)
		{
			this.tejszinhab = tejszinhab;
		}

		public override string ToString()
		{
			return base.ToString() + (this.tejszinhab? " tejszínhabbal, színes cukorszórással.":" tejszínhab nélkül.");
		}
	}
}
