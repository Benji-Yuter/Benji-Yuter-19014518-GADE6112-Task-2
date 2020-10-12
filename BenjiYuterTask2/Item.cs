using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoNamespace
{	[Serializable]
	abstract class Item : Tile
	{
		protected Item(int X, int Y) : base(X, Y) { }

		public override string ToString() { return base.ToString();	}
	}
}
