using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoNamespace
{
	[Serializable]
	class Obstacle : Tile
	{
		public Obstacle(int x, int y) : base(x, y)
		{
			this.y = y;
			this.x = x;
		}
	}
}
