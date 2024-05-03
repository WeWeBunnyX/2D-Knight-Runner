using Godot;
using System;

public partial class GameManager : Node
{


	public int score = 0;

	public void AddScore()
	{
		score += 1;
		Console.WriteLine("Score: " + score);
	}



}
