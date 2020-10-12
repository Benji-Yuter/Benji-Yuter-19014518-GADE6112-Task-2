using System;

namespace TaskTwoNamespace
{
	class Gold : Item
	{
		private Random initialGold = new Random();
		private int goldPurse;
		
		public int getGoldPurse() { return goldPurse; }

		public Gold(int x, int y) : base(x, y)
		{
			this.type = Tile.tileType.Gold;
			goldPurse = initialGold.Next(1, 5);
		}
	}
}
