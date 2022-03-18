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

		//행
        int width;
		//열
        int height;

		//생성자
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
					Console.Write($"{Neighbors(x, y)}");
				Console.WriteLine();
			}
		}

		// 2중 for문으로 각각의 세포가 살아있어야 될지 판단하는 함수
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

		//세포가 살아있으면 1아니면 0을 들고있는 배열에서 1일 땐 ■ 아니면 공백을 출력
		public void DrawGeneration()
		{
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
                {
					string curGenStr = curGeneration[y, x] == 1 ? "■" : "  ";
					Console.Write(curGenStr);
				}
			
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		//살아있는 세포의 수를 확인
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
		//기본 세포 배열
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
			//사이클 생성
			LifeGame lifeGrid = new LifeGame(cell);

			Console.WriteLine("0번 째 세대");
			lifeGrid.DrawGeneration();
			Console.WriteLine();

			//반복~~
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