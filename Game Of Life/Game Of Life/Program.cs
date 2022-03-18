using System;
using System.Threading;

namespace GameOfLife
{

    public class LifeGame
    {
        //현재 세대
        int[,] curGeneration;

        //지난 세대
        int[,] lastGeneration;

        //현재 세대 수
        public int generationCount;

        int width;
        int height;

        public LifeGame(int[,] cells)
        {
            curGeneration = (int[,])cells.Clone();

            generationCount = 1;

            width = curGeneration.GetLength(1);
            height = curGeneration.GetLength(0);

            lastGeneration = new int[height, width];
        }

        private int Neighbors(int x, int y)
        {
            int count = 0;

			//왼쪽 아래
			if (x > 0 && y > 0)
			{
				if (curGeneration[y - 1, x - 1] == 1)
				{
					count++;
				}
			}
			// 아래
			if (y > 0)
			{
				if (curGeneration[y - 1, x] == 1)
					count++;
			}

			// 오른쪽 아래
			if (x < width - 1 && y > 0)
			{
				if (curGeneration[y - 1, x + 1] == 1)
					count++;
			}

			// 왼쪽
			if (x > 0)
			{
				if (curGeneration[y, x - 1] == 1)
					count++;
			}

			// 오른쪽
			if (x < width - 1)
			{
				if (curGeneration[y, x + 1] == 1)
					count++;
			}

			// 왼쪽 위
			if (x > 0 && y < height - 1)
			{
				if (curGeneration[y + 1, x - 1] == 1)
					count++;
			}

			// 위
			if (y < height - 1)
			{
				if (curGeneration[y + 1, x] == 1)
					count++;
			}

			// 오른쪽 위
			if (x < width - 1 && y < height - 1)
			{
				if (curGeneration[y + 1, x + 1] == 1)
					count++;
			}

			return count;

		}

		public void WriteNeighbours()
		{
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
					Console.Write("{0}", Neighbors(x, y));
				Console.WriteLine();
			}
		}
		public void ProcessGeneration()
		{
			int[,] nextGeneration = new int[height, width];

			lastGeneration = (int[,])curGeneration.Clone();

			generationCount++;

			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					if (curGeneration[y, x] == 0 && Neighbors(x, y) == 3)
						nextGeneration[y, x] = 1;
					if (curGeneration[y, x] == 1 &&
						   (Neighbors(x, y) == 2 || Neighbors(x, y) == 3))
						nextGeneration[y, x] = 1;
				}
			}

			curGeneration = (int[,])nextGeneration.Clone();
		}

		public void DrawGeneration()
		{
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
					Console.Write("{0}", curGeneration[y, x]);
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		public int AliveCells()
		{
			int count = 0;

			for (int y = 0; y < height; y++)
				for (int x = 0; x < width; x++)
					if (curGeneration[y, x] == 1)
						count++;

			return count;
		}



	}

	class Program
	{
		public static int[,] cell = new int[,]
		{
			{ 1, 0, 0, 0, 0, 0, 0, 0, 1, 1,},
			{ 0, 0, 1, 0, 0, 1, 0, 0, 0, 0,},
			{ 0, 1, 1, 0, 1, 1, 1, 0, 0, 0,},
			{ 0, 1, 0, 0, 0, 1, 0, 0, 0, 0,},
			{ 0, 0, 0, 0, 0, 0, 0, 1, 0, 1,},
			{ 0, 0, 0, 0, 1, 0, 0, 0, 1, 1,},
			{ 0, 1, 0, 0, 1, 0, 0, 1, 0, 0,},
			{ 1, 1, 0, 0, 1, 0, 0, 0, 0, 0,},
		};

		private static void Main(string[] args)
		{
			LifeGame lifeGrid = new LifeGame(cell);

			Console.WriteLine("0번 째 세대");
			lifeGrid.DrawGeneration();
			Console.WriteLine();

			while (lifeGrid.AliveCells() > 0)
			{
				Console.Clear();
				string response;

				Console.WriteLine($"{lifeGrid.generationCount}번 째 세대");
				Console.WriteLine();

				lifeGrid.ProcessGeneration();
				lifeGrid.DrawGeneration();

				Console.WriteLine();

				if (lifeGrid.AliveCells() == 0)
				{
					Console.WriteLine("모든 세포가 죽었습니다!");
					Console.ReadLine();
				}
				else
				{
					Thread.Sleep(1000);
					Console.WriteLine("Enter 키를 눌러 진행하세요");

					response = Console.ReadLine();

					if (response == "n" || response == "N")
						break;
				}

				


			}
		}
	}
}