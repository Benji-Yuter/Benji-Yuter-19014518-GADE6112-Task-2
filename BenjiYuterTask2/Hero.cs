using System;

namespace TaskTwoNamespace
{
	[Serializable]
	class Hero : Character
	{

		public Hero(int x, int y, int hitPoints) : base(x, y, Tile.tileType.Hero)
		{
			this.type = Tile.tileType.Hero;
			this.setHit_Points(hitPoints);
			this.setMaxHit_Points(hitPoints);
			this.setDamage(2);			
		}

		public override string ToString()
		{
			string infoTable = "";
			infoTable += "Player Hit_Points: " + HitPoints.ToString() + "\n";
			infoTable += "X Postion: " + x.ToString() + "\t";
			infoTable += "Y Postion: " + y.ToString() + "\t" + "\n";
			infoTable += "Damage: 2 " + damage.ToString() + "\n";
			infoTable += "Amount of Gold: " + this.getGoldPurse();
			return infoTable;

		}

		public override Movement returnMove(Movement Move)
		{
			{
				if (this.characterVision[(int)Move] is EmptyTile || this.characterVision[(int)Move] is Gold)
				{
					return Move;
				}
				else
				{
					return Movement.noMovement;
				}
			}
		}


	}
}
