using Godot;
using System;

public partial class GameManager : Node
{
	[Export]
	public NodePath _ScorePath;

	private Label _ScoreLabel;

	public override void _Ready()
	{
		_ScoreLabel = GetNode<Label>(_ScorePath);
		
	}
	public int score = 0;

	public void AddScore()
	{
		score += 1;
		GD.Print("Score: " + score);
		_ScoreLabel.Text = "Score: " + score;
	}



}
