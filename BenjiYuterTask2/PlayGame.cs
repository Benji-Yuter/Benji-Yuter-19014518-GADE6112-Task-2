using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskTwoNamespace
{
	public partial class PlayGame : Form
	{
		private Form1 caller;
		private GameEngine ge;
		private int width;
		private int height;

		public PlayGame(int min_width, int max_width, int min_height, int max_height, int num_enemies, bool loadGame, int gold)
		{
			InitializeComponent();
			if (!loadGame)
			{
				ge = new GameEngine(min_width, max_width, min_height, max_height, num_enemies, gold);
				width = ge.getWidth();
				height = ge.getHeight();
			}
			else
			{
				ge = new GameEngine();
				ge.setMap(GameEngine.loadGame());
				width = ge.getWidth();
				height = ge.getHeight();
			}
			redraw();

		}
		public void setCaller(Form1 caller)
		{
			this.caller = caller;
		}

		private void actionStatus(String action, Boolean success, String meta)
		{
			if (success)
			{
				if (action.Substring(0, 6) == "attack")
				{
					lbl_ActionStatus.ForeColor = Color.Green;
					lbl_ActionStatus.Text = "Action successful!";
					lbl_ActionStatus.Text += '\n' + meta;
				}
				redraw();
			}
			else
			{
				lbl_ActionStatus.ForeColor = Color.Red;
				lbl_ActionStatus.Text = "You cannot " + action;
			}
		}

		private void redraw()
		{
			updateMap();
			updatePlayerStats(ge.getHeroStats());
			updateEnemiesRemaining(ge.getEnemiesRemaining());


		}

		private void updateMap()
		{
			Tile[,] view = ge.getMapView();
			string textview = "";

			for (int i = 0; i < height; ++i)
			{
				for (int j = 0; j < width; ++j)
				{
					textview += this.getRepresentation(view[i, j]) + (j == (width - 1) ? "" : " ");
				}
				textview += '\n';
			}

			lbl_MapView.Text = textview;
		}

		private void updatePlayerStats(String info)
		{
			lbl_HeroStats.Text = info;
		}

		private void updateEnemiesRemaining(String info)
		{
			lbl_EnemiesRemaining.Text = info;
		}

		private char getRepresentation(Tile type)
		{
			if (type is EmptyTile)
			{
				return '.';
			}
			else if (type is Hero)
			{
				if (ge.getMap().getHero().IsDead())
				{
					return '.';
				}
				else
				{
					return 'H';
				}
			}
			else if (type is Goblin)
			{
				return 'G';
			}
			else if (type is Mages)
			{
				return 'M';
			}
			else if (type is Gold)
			{
				return 'g';
			}
			else
			{
				return 'X';
			}
		}

		private void PlayGame_Load(object sender, EventArgs e)
		{


		}

		private void btnUp_Click_1(object sender, EventArgs e)
		{
			actionStatus("move up", ge.movePlayer(Character.Movement.Up), "");
		}

		private void btnLeft_Click_1(object sender, EventArgs e)
		{
			actionStatus("move left", ge.movePlayer(Character.Movement.Left), "");
		}

		private void btnDown_Click_1(object sender, EventArgs e)
		{
			actionStatus("move down", ge.movePlayer(Character.Movement.Down), "");
		}

		private void btnRight_Click_1(object sender, EventArgs e)
		{
			actionStatus("move right", ge.movePlayer(Character.Movement.Right), "");
		}

		private void btnAttackUp_Click(object sender, EventArgs e)
		{
			String response = ge.HeroAttacks(Character.Movement.Up);
			Boolean success = false;
			if (response[0] == '1')
			{
				success = true;
			}
			actionStatus("attack up", success, response.Substring(1));
		}

		private void btnAttackLeft_Click(object sender, EventArgs e)
		{
			String response = ge.HeroAttacks(Character.Movement.Left);
			Boolean success = false;
			if (response[0] == '1')
			{
				success = true;
			}
			actionStatus("attack left", success, response.Substring(1));
		}

		private void btnAttackDown_Click(object sender, EventArgs e)
		{
			String response = ge.HeroAttacks(Character.Movement.Down);
			Boolean success = false;
			if (response[0] == '1')
			{
				success = true;
			}
			actionStatus("attack down", success, response.Substring(1));
		}

		private void btnAttackRight_Click(object sender, EventArgs e)
		{
			String response = ge.HeroAttacks(Character.Movement.Right);
			Boolean success = false;
			if (response[0] == '1')
			{
				success = true;
			}
			actionStatus("attack right", success, response.Substring(1));
		}

		private void btnSaveGame_Click(object sender, EventArgs e)
		{
			ge.saveGame();
		}
	}

}
