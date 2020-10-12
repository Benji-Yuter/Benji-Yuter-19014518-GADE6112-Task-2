using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoNamespace
{
	[Serializable]
	abstract class Tile
	{

		public enum tileType { Hero, Weapon, Gold, Enemy, Obstacle }

		protected int x;
		protected int y;
		
		public int X
		{
			get { return x; }
			set { x = value; }

		}
		public int Y
		{
			get { return y; }
			set { y = value; }

		}
		private tileType Type;

		public tileType type
		{
			get { return Type; }
			set { Type = value; }
		}

		public Tile(int tempX, int tempY, tileType tempType)
		{
			this.x = tempX;
			this.y = tempY;
			type = tempType;
		}

		protected Tile(int x, int y)
		{
			X = x;
			Y = y;
		}

		public tileType getTileType()
		{
			return type;
		}

		public void setTileType(tileType type)
		{
			this.type = type;
		}

		public int getX()
		{
			return x;
		}

		public void setX(int x)
		{
			this.x = x;
		}

		public int getY()
		{
			return y;
		}

		public void setY(int y)
		{
			this.y = y;
		}
	}
}