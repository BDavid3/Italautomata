using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italautomata
{
	internal class Tea : ForroItal
	{
		private bool citrommal;

		public Tea(string nev, int ar, int cukor, bool citrommal) : base(nev, ar, cukor)
		{
			this.citrommal = citrommal;
		}

		public bool Citrommal { get => citrommal; set => citrommal = value; }

		public override string ToString()
		{
			return base.ToString() + (this.citrommal ? " citrommal" : " citrom nélkül");
		}
	}
}
