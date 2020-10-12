using System;

namespace TaskTwoNamespace
{
	[Serializable]
	abstract class Character : Tile
	{
		private int goldPurse = 0;
		public enum Movement { Up, Down ,Left ,Right, noMovement }

		/*GetSet functions for:
		 * Hitpoints & MaxHitpoints
		 * Damage
		 * Vision */
		protected int HitPoints;
		public int hitPoints
		{
			get
			{
				return HitPoints;
			}
			set
			{
				HitPoints = value;
			}
		}


		protected int MaxHitPoints;
		public int maxHitPoints
		{
			get
			{
				return MaxHitPoints;
			}
			set
			{
				MaxHitPoints = value;
			}
		}



		protected int Damage;
		public int damage
		{
			get
			{
				return Damage;
			}
			set
			{
				Damage = value;
			}
		}



		protected Tile[] characterVision;
		public Tile[] CharacterVision
		{
			get
			{
				return characterVision;
			}
			set
			{
				characterVision = value;
			}
		}

		public Character(int tempHitPoints, int tempMaxHitPoints, int tempDamage,
			Tile[] tempCharacterVision, int x, int y, tileType typeTemp) : base(x, y, typeTemp)
		{//initialize character
			CharacterVision = tempCharacterVision;
			this.damage = tempDamage;
			this.hitPoints = tempHitPoints;
			this.maxHitPoints = tempMaxHitPoints;
		}

		public Character(int tempX, int tempY, tileType typeTemp) : base(tempX, tempY, typeTemp)
		{
		}

		public virtual void Attack(Character Target)
		{
			//subtract damage from target
			Target.setHit_Points(Target.getHit_Points() - this.damage);
		}
		public bool IsDead()
		{
			if (HitPoints > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public virtual bool checkRange(Character Target)
		{
			//Using distance to determine if the target is within range
			if (DistanceTo(Target) < 1)
			{
				return false;

			}
			else
			{

				return true;
			}

		}
		private int DistanceTo(Character Target)
		{
			return (Math.Abs(base.x - Target.x) + Math.Abs(base.y - Target.y));
		}

		public void Move(Movement Move)
		{
			//increment positions
			if (Move == Movement.Down) { ++this.y; }
			else if (Move == Movement.Up) { --this.y; }
			else if (Move == Movement.Right) { ++this.x; }
			else if (Move == Movement.Left) { --this.x; }
			
			
		}

		public abstract override string ToString();

		private int distanceTo(Character Target)
		{
			int x = Math.Abs(Target.getX() - this.x);
			int y = Math.Abs(Target.getY() - this.y);

			return x + y;
		}
		public void setHit_Points(int hitPoints)
		{
			this.hitPoints = hitPoints;
			if (hitPoints <= 0)
			{
				hitPoints = 0;
			}
		}
		public int getHit_Points()
		{
			return this.hitPoints;
		}

		public void setMaxHit_Points(int maxHitPoints)
		{
			this.MaxHitPoints = maxHitPoints;
		}

		public int getMaxHit_Points()
		{
			return this.MaxHitPoints;
		}

		public void setDamage(int Damage)
		{
			this.damage = Damage;
		}

		public int getDamage()
		{
			return this.damage;
		}
		public void setVision(Tile[] characterVision)
		{
			this.characterVision = characterVision;
		}

		public Tile[] getVision()
		{
			return this.characterVision;
		}
		public abstract Movement returnMove(Movement move = 0);

		public void PickUp(Item goldDrop)
		{
			if (goldDrop is Gold)
			{
				goldPurse = goldPurse + ((Gold)goldDrop).getGoldPurse();
			}
		}
		public int getGoldPurse()
		{
			return goldPurse;
		}
		protected Boolean lock_Vision = false;  

		public void lockVision()
		{
			this.lock_Vision = true;
		}

		public void unlockVision()
		{
			this.lock_Vision = false;
		}

		public Boolean isVisionLocked()
		{
			return this.lock_Vision;
		}

	}
}


