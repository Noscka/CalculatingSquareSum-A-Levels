using System;

namespace CalculatingSquare_A_Levels
{
	static internal class Program
	{
		static int SumRange(int startPos, int Range)
		{
			int output = 0;
			for(int i = 0; i < Range; i++)
			{
				Console.Write($"{i + startPos}\t");
				output += i+startPos;
			}
			return output;
		}

		static int SumRows(int ColumnCount, int RowCount)
		{
			int output = 0;
			for (int i = 1; i < RowCount+1; i++)
			{
				int sum = SumRange(i, ColumnCount);
				output += sum;
				Console.Write($"  Row Sum: {sum}");
				Console.Write("\n");
			}
			return output;
		}

		static void Main(string[] args)
		{
			Console.WriteLine($"Full Output: {SumRows(10, 10)}");
		}
	}
}
