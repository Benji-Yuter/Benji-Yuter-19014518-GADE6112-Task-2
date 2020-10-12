using System;

namespace TaskTwoNamespace
{

	[Serializable]
	class EmptyTile : Tile
	{
		public EmptyTile(int X, int Y) : base(X, Y)
		{
			this.X = X;
			this.Y = Y;
		}
	}
}
