using System;

namespace TaskTwoNamespace
{
	[Serializable]
	class Goblin : Enemy
	{

		public Goblin(int x, int y) : base(x, y, Tile.tileType.Enemy, 1, 10) { }

		public override Movement returnMove(Character.Movement move)
		{
			int[] possibleMoves = { 0, 1, 2, 3 };
			Boolean moveFound = false;
			Character.Movement Direction = Character.Movement.noMovement;


			while (!moveFound)
			{
				Direction = (Character.Movement)possibleMoves[rndNum.Next(0, possibleMoves.Length)];

				if (this.characterVision[(int)Direction] is EmptyTile)
				{
					moveFound = true;

				}
				else if (possibleMoves.Length != 1)
				{

					int[] newPossibleMoves = new int[possibleMoves.Length - 1];
					int Counter = 0;

					for (int i = 0; i < possibleMoves.Length; ++i)
					{
						if (possibleMoves[i] != (int)Direction)
						{
							newPossibleMoves[Counter] = possibleMoves[i];
							++Counter;
						}
					}

					possibleMoves = newPossibleMoves;
				}
				else
				{
					Direction = Character.Movement.noMovement;
					moveFound = true;
				}

			}
			return Direction;
		}

	}

}
