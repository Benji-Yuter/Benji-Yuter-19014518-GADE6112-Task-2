using System;

namespace TaskTwoNamespace
{
	[Serializable]
	class Map
	{
		public Random rndNum = new Random();
		private Item[] Items;
		private Tile[,] map;
		private Hero hero;
		private Enemy[] enemies;
		private int Width;
		private int Height;

		public Map(int min_Width, int max_Width, int min_Height, int max_Height, int num_Enemies, int GoldAmount)
		{
			this.Width = rndNum.Next(min_Width, max_Width + 1);
			this.Height = rndNum.Next(min_Height, max_Height + 1);

			this.map = new Tile[Height, Width];


			int max_Enemies = ((Width - 2) * (Height - 2)) - 1;
			if (num_Enemies > max_Enemies)
			{
				num_Enemies = max_Enemies;
			}
			this.enemies = new Enemy[num_Enemies];

			generateEmptyMap();
			this.hero = (Hero)create(Tile.tileType.Hero);
			map[hero.getY(), hero.getX()] = hero;

			for (int i = 0; i < enemies.Length; ++i)
			{
				enemies[i] = (Enemy)create(Tile.tileType.Enemy);
				map[enemies[i].getY(), enemies[i].getX()] = enemies[i];
			}

			int maxGold = ((Width - 2) * (Height - 2)) - 1 - enemies.Length;
			if (GoldAmount > maxGold)
			{
				GoldAmount = maxGold;
			}
			this.Items = new Item[GoldAmount];

			
			for (int i = 0; i < Items.Length; ++i)
			{
				Items[i] = (Gold)create(Tile.tileType.Gold);
				map[Items[i].getY(), Items[i].getX()] = Items[i];
			}
			updateVision();

		}

		private void generateEmptyMap()
		{
			for (int i = 0; i < Height; ++i)
			{
				for (int k = 0; k < Width; ++k)
				{
					if (i == 0 || i == (Height - 1))
					{
						map[i, k] = new Obstacle(i, k);
					}
					else if (k == 0 || k == (Width - 1))
					{
						map[i, k] = new Obstacle(i, k);
					}
					else
					{
						map[i, k] = new EmptyTile(i, k);
					}
				}
			}
		}

		private Tile create(Tile.tileType type)
		{
			int[] initLocation = getSpawnPosition();

			if (type == Tile.tileType.Hero)
			{
				return new Hero(initLocation[1], initLocation[0], 10);
			}
			else if (type == Tile.tileType.Enemy)
			{
				return enemyGen(initLocation[1], initLocation[0]);
			}
			else if (type == Tile.tileType.Gold)
			{
				return new Gold(initLocation[1], initLocation[0]);
			}
			else
			{
				return new EmptyTile(initLocation[1], initLocation[0]);
			}

		}
		public Enemy enemyGen(int y, int x)
		{
			if (rndNum.Next(1, 10) <= 3)
			{
				return new Mages(y, x, Tile.tileType.Enemy, 5, 5);
			}
			else
			{
				return new Goblin(y, x);
			}
		}

		private void updateVision()
		{
			hero.setVision(fetchVision(hero.getX(), hero.getY()));

			for (int i = 0; i < enemies.Length; ++i)
			{
				enemies[i].setVision(fetchVision(enemies[i].getX(), enemies[i].getY()));
			}
		}

		public void pub_UpdateVision()
		{
			updateVision();
		}

		public void removeTile(Tile character)
		{
			if (character.getTileType() == Tile.tileType.Enemy)
			{
				Enemy[] tempEnemy = new Enemy[enemies.Length - 1];
				int ind_Position = 0;

				for (int i = 0; i < enemies.Length; ++i)
				{
					if (enemies[i].IsDead())
					{
						map[enemies[i].getY(), enemies[i].getX()] = new EmptyTile(enemies[i].getY(), enemies[i].getX());
					}
					else
					{
						tempEnemy[ind_Position] = enemies[i];
						++ind_Position;
					}
				}
				enemies = tempEnemy;
				updateVision();
			}
		}

		public void updateCharaterPosition(Tile character, Character.Movement dir)
		{
			Character tempCharacter = (Character)map[character.getY(), character.getX()];
			EmptyTile emp;

			switch (dir)
			{
				case Character.Movement.Up:
					emp = (EmptyTile)map[tempCharacter.getY() - 1, tempCharacter.getX()];
					map[tempCharacter.getY() - 1, tempCharacter.getX()] = tempCharacter;
					map[tempCharacter.getY(), tempCharacter.getX()] = emp;
					tempCharacter.Move(Character.Movement.Up);
					emp.setY(emp.getY() + 1);
					break;
				case Character.Movement.Down:
					emp = (EmptyTile)map[tempCharacter.getY() + 1, tempCharacter.getX()];
					map[tempCharacter.getY() + 1, tempCharacter.getX()] = tempCharacter;
					map[tempCharacter.getY(), tempCharacter.getX()] = emp;
					tempCharacter.Move(Character.Movement.Down);
					emp.setY(emp.getY() - 1);
					break;
				case Character.Movement.Left:
					emp = (EmptyTile)map[tempCharacter.getY(), tempCharacter.getX() - 1];
					map[tempCharacter.getY(), tempCharacter.getX() - 1] = tempCharacter;
					map[tempCharacter.getY(), tempCharacter.getX()] = emp;
					tempCharacter.Move(Character.Movement.Left);
					emp.setX(emp.getX() + 1);
					break;
				case Character.Movement.Right:
					emp = (EmptyTile)map[tempCharacter.getY(), tempCharacter.getX() + 1];
					map[tempCharacter.getY(), tempCharacter.getX() + 1] = tempCharacter;
					map[tempCharacter.getY(), tempCharacter.getX()] = emp;
					tempCharacter.Move(Character.Movement.Right);
					emp.setX(emp.getX() - 1);
					break;
			}

			this.updateVision();
		}

		private Tile[] fetchVision(int x, int y)
		{
			Tile[] characterVision = new Tile[8];
			
			characterVision[0] = map[y - 1, x];  
			characterVision[1] = map[y + 1, x];  
			characterVision[2] = map[y, x - 1]; 
			characterVision[3] = map[y, x + 1];  

			//Mage character Vision
			characterVision[4] = map[y - 1, x + 1];  
			characterVision[5] = map[y + 1, x + 1];  
			characterVision[6] = map[y + 1, x - 1];  
			characterVision[7] = map[y - 1, x - 1]; 

			return characterVision;

		}

		private int[] getSpawnPosition()
		{
			int xPos = rndNum.Next(1, Width);
			int yPos = rndNum.Next(1, Height);

			if (map[yPos, xPos] is EmptyTile)
			{
				int[] s_point = new int[2];
				s_point[0] = yPos;
				s_point[1] = xPos;

				return s_point;
			}
			else
			{
				return getSpawnPosition();
			}
		}

		public void setMap(Tile[,] map)
		{
			this.map = map;
		}

		public Tile[,] getMap()
		{
			return this.map;
		}

		public void setHero(Hero hero)
		{
			this.hero = hero;
		}

		public Hero getHero()
		{
			return this.hero;
		}

		public void setEnemies(Enemy[] enemies)
		{
			this.enemies = enemies;
		}

		public Enemy[] getEnemies()
		{
			return this.enemies;
		}

		public void setWidth(int Width)
		{
			this.Width = Width;
		}
		public Item[] getItem()
		{
			return this.Items;
		}
		public void setItems(Item[] newItems)
		{
			this.Items = newItems;
		}
		public int getWidth()
		{
			return this.Width;
		}

		public void setHeight(int Height)
		{
			this.Height = Height;
		}

		public int getHeight()
		{
			return this.Height;
		}
		public Item GetItemAtPosition(int x, int y)
		{
			Item tempItem = null;
			for (int i = 0; i < Items.Length; ++i)
			{
				if (Items[i].getX() == x && Items[i].getY() == y)
				{
					tempItem = Items[i];
				}
			}
			return tempItem;
		}
	}
}
