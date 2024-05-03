using Godot;
using System;

public partial class coin : Area2D
{
	[Export]
	public NodePath _GameManagerPath;

	private GameManager _GameManager;

	
	public override void _Ready()
	{
		_GameManager = GetNode<GameManager>(_GameManagerPath);
	}
	
   private void playerBodyEntered(Node2D body)
   {
	_GameManager.AddScore();
	Console.WriteLine("Player collected a coin!");
	QueueFree();


   }


}
