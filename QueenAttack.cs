using System;
using System.Collections.Generic;

class Chess
{
	public class Queen
	{
		public int XCoordinate;
		public int YCoordinate;
	}
	public class Piece
	{
		public int XCoordinate;
		public int YCoordinate;
	}
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter queen's X coordinate:");
			string queenXCor = Console.ReadLine();
			int queenXCorNumber = int.Parse(queenXCor);
			Console.WriteLine("Enter queen's Y coordinate:");
			string queenYCor = Console.ReadLine();
			int queenYCorNumber = int.Parse(queenYCor);
			Queen queen = new Queen();
			queen.XCoordinate = queenXCorNumber;
			queen.YCoordinate = queenYCorNumber;
			Console.WriteLine("Enter piece X coordinates:");
			string pieceXCor = Console.ReadLine();
			int pieceXCorNumber = int.Parse(pieceXCor);
			Console.WriteLine("Enter piece Y coordinates:");
			string pieceYCor = Console.ReadLine();
			int pieceYCorNumber = int.Parse(pieceYCor);
			Piece piece = new Piece();
			piece.XCoordinate = pieceXCorNumber;
			piece.YCoordinate = pieceYCorNumber;
			bool attacked = queen.CanAttack(pieceXCorNumber, pieceYCorNumber);
			if(attacked)
			{
				Console.WriteLine("This queen will get your piece");
			}
			else
			{
				Console.WriteLine("you are safe from getting hit!");
			}
		}
		public bool CanAttack(int intX, int intY)
			{
			if(queenXCoordinate == intX || queenYCoordinate == intY || Math.Abs(queenXCoordinate - intX) == Math.Abs(queenYCoordinate - intY))
			{
				return true;
			}
			else
			{
				return false;
			}
			}
	}
}
