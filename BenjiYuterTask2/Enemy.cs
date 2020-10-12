using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoNamespace
{
	[Serializable]
	abstract class Enemy : Character
	{
		protected Random rndNum = new Random();
		public Enemy(int X, int Y, Tile.tileType Type, int Damage, int hitPoints) : base(X, Y, Type)
		{
			this.type = Tile.tileType.Enemy;
			setDamage(Damage);
			setHit_Points(hitPoints);
			setMaxHit_Points(hitPoints);			
		}

		public override string ToString()
		{
			//Graphical list of enemies in the game
			string infoTable = "";
			infoTable += "\t\tEnemy Details\n\n";
			infoTable += "\tX Postion: "+X.ToString() + "\t";
			infoTable += "\tY Postion: " + Y.ToString() + "\t" + "\n";
			infoTable += "\tDamage: " + Damage.ToString();
			return infoTable;		
		}		
	}
}
