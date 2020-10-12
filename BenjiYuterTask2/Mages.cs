using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoNamespace
{ [Serializable]
	class Mages : Enemy
	{

		private int magesDamage;

		public int getMageDamage()
		{
			return magesDamage;
		}
		private int magesHit_Points;
		public int getMageHitPoints()
		{
			return magesHit_Points;
		}

		public Mages(int x, int y, tileType type, int damage, int hitPoints) : base(x, y, type, damage, hitPoints)
		{
			magesDamage = damage;
			magesHit_Points = hitPoints;
		}

		public override Movement returnMove(Movement move = 0)
		{
			return Movement.noMovement;

		}
		public override bool checkRange(Character target)
		{
			bool isEnemy = false;
			for (int i = 0; i < characterVision.Length; ++i)
			{
				if (characterVision[i] is Enemy || characterVision[i] is Hero)
				{
					isEnemy = true;
					return isEnemy;
				}
			}
			return isEnemy;

		}
	
	}
}
