using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TaskTwoNamespace
{
	[Serializable]
	class GameEngine
	{
		private Map map;

		public GameEngine(int min_Width, int max_Width, int min_Height, int max_Height, int num_Enemies, int Gold)
		{//initialize map and construct game engine
			map = new Map(min_Width, max_Width, min_Height, max_Height, num_Enemies, Gold);
		}
		public GameEngine()
		{ }
		public Tile[,] getMapView()
		{
			return map.getMap();
		}

		public int getWidth()
		{
			return map.getWidth();
		}

		public int getHeight()
		{
			return map.getHeight();
		}

		public string getHeroStats()
		{
			return map.getHero().ToString();
		}

		public string getEnemiesRemaining()
		{
			string info = "";

			for (int i = 0; i < map.getEnemies().Length; ++i)
			{
				if (i <= 5)
				{
					info += map.getEnemies()[i].ToString() + "\n\n";
				}
			}

			if (map.getEnemies().Length > 6)
			{
				info += "+" + (map.getEnemies().Length - 6) + " more enem" + ((map.getEnemies().Length - 6) > 1 ? "ies" : "y");				
			}

			return info;
		}

		public void removefromItems(int yPosition, int xPosition)
		{
			Item[] new_Items = new Item[map.getItem().Length - 1];
			int index = 0;
			for (int i = 0; i < map.getItem().Length; ++i)
			{
				if (map.getItem()[i].getX() != xPosition && map.getItem()[i].getY() != yPosition)
				{
					new_Items[index] = map.getItem()[i];
					index+= 1;
				}
			}
			map.setItems(new_Items);
		}

		public Boolean movePlayer(Character.Movement Move)
		{

			if (map.getHero().returnMove(Move) == Character.Movement.noMovement)
			{
				return false;
			}
			else
			{
				int xPos = map.getHero().getX();
				int yPos = map.getHero().getY();
				if (Move == Character.Movement.Up)
				{
					if (map.getMap()[yPos - 1, xPos] is Gold)
					{
						map.getHero().PickUp((Gold)map.getMap()[yPos - 1, xPos]);
						map.getMap()[yPos - 1, xPos] = new EmptyTile(yPos - 1, xPos);

						map.pub_UpdateVision();
					}
				}
				else if (Move == Character.Movement.Down)
				{
					if (map.getMap()[yPos + 1, xPos] is Gold)
					{
						map.getHero().PickUp((Gold)map.getMap()[yPos + 1, xPos]);
						map.getMap()[yPos + 1, xPos] = new EmptyTile(yPos + 1, xPos);

						map.pub_UpdateVision();
					}
				}
				else if (Move == Character.Movement.Left)
				{
					if (map.getMap()[yPos, xPos - 1] is Gold)
					{
						map.getHero().PickUp((Gold)map.getMap()[yPos, xPos - 1]);
						map.getMap()[yPos, xPos - 1] = new EmptyTile(yPos, xPos - 1);

						map.pub_UpdateVision();
					}
				}
				else if (Move == Character.Movement.Right)
				{
					if (map.getMap()[yPos, xPos + 1] is Gold)
					{
						map.getHero().PickUp((Gold)map.getMap()[yPos, xPos + 1]);
						map.getMap()[yPos, xPos + 1] = new EmptyTile(yPos, xPos + 1);

						map.pub_UpdateVision();
					}
				}
				map.updateCharaterPosition(map.getHero(), Move);
				moveEnemies();
				enemyAttacks();
				return true;

			}
		}

		private void moveEnemies()
		{
			Enemy[] enemies = map.getEnemies();

			for (int i = 0; i < enemies.Length; ++i)
			{
				Character.Movement move = enemies[i].returnMove(Character.Movement.noMovement);
				map.updateCharaterPosition(enemies[i], move);
			}

		}

		public String HeroAttacks(Character.Movement Move)
		{
			Hero h = map.getHero();
			Tile Target = new EmptyTile(0, 0);

			switch (Move)
			{
				case Character.Movement.Up:
					Target = map.getMap()[h.getY() - 1, h.getX()];
					break;
				case Character.Movement.Down:
					Target = map.getMap()[h.getY() + 1, h.getX()];
					break;
				case Character.Movement.Left:
					Target = map.getMap()[h.getY(), h.getX() - 1];
					break;
				case Character.Movement.Right:
					Target = map.getMap()[h.getY(), h.getX() + 1];
					break;
			}

			if (Target is Enemy)
			{

				h.Attack((Character)Target);
				Character c_Target = (Character)Target;

				if (c_Target.IsDead())
				{
					map.removeTile(c_Target);
				}

				moveEnemies();

				if (!c_Target.IsDead())
				{
					return "1" + c_Target.ToString();
				}
				else
				{
					return "The enemy is dead";
				}

			}
			else
			{
				return "0";
			}


		}
		public void enemyAttacks()
		{
			Enemy[] tempEnemies = new Enemy[map.getEnemies().Length];
			Array.Copy(map.getEnemies(), 0, tempEnemies, 0, map.getEnemies().Length);
			string attack_status;
			for (int i = 0; i < tempEnemies.Length; ++i)
			{
				if (!tempEnemies[i].IsDead())
				{
					tempEnemies[i].lockVision();

					for (int j = 0; j < tempEnemies[i].getVision().Length; ++j)
					{
						if (tempEnemies[i] is Goblin && j < 4)
						{
							 attack_status = HeroAttacks(tempEnemies[i], Character.Movement.noMovement,
								 tempEnemies[i].getVision()[j]);

						}
						else if (tempEnemies[i] is Mages)
						{
							 attack_status = HeroAttacks(tempEnemies[i], Character.Movement.noMovement,
								 tempEnemies[i].getVision()[j]);

						}
					}

					tempEnemies[i].unlockVision();
					map.updateCharaterPosition(tempEnemies[i], Character.Movement.noMovement);
				}
			}
		}

		public string HeroAttacks(Character h, Character.Movement dir, Tile t)
		{
			Tile target = new EmptyTile(0, 0);

			switch (dir)
			{
				case Character.Movement.Up:
					target = map.getMap()[h.getY() - 1, h.getX()];
					break;
				case Character.Movement.Down:
					target = map.getMap()[h.getY() + 1, h.getX()];
					break;
				case Character.Movement.Left:
					target = map.getMap()[h.getY(), h.getX() - 1];
					break;
				case Character.Movement.Right:
					target = map.getMap()[h.getY(), h.getX() + 1];
					break;
				default:
					target = t;
					break;
			}


			if ((h is Hero && target is Enemy && !h.IsDead()) || (h is Goblin && target is Hero) || (h is Mages && target is Character))
			{

				h.Attack((Character)target);
				Character c_target = (Character)target;

				if (c_target.IsDead())
				{
					map.removeTile(c_target);
				}


				if (h is Hero)
				{


					enemyAttacks();
					if (!c_target.IsDead())
					{
						return "1" + c_target.ToString();
					}
					else
					{
						return "1The enemy is dead";
					}
				}
				else
				{
					return "";
				}

			}
			else
			{
				return "0";
			}


		}
		public Boolean saveGame()
		{
			try
			{
				FileStream saveFile = new FileStream("PrevSave.txt", FileMode.Create, FileAccess.ReadWrite);
				BinaryFormatter b_formatter = new BinaryFormatter();
				b_formatter.Serialize(saveFile, map);

				saveFile.Close();

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}

		}

		static public Map loadGame()
		{
			try
			{
				FileStream loadFile = new FileStream("PrevSave.txt", FileMode.Open, FileAccess.Read);
				BinaryFormatter b_formatter = new BinaryFormatter();
				Map m = (Map)b_formatter.Deserialize(loadFile);

				loadFile.Close();

				return m;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
		}
		public void setMap(Map loadMap)
		{
			this.map = loadMap;
		}
		public Map getMap()
		{
			return map;
		}
	}
}

