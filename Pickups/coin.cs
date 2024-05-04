using Godot;
using System;

public partial class coin : Area2D
{
	[Export]
	public NodePath _GameManagerPath;

	[Export]

	public NodePath _AnimationPlayerPath;

	private AnimationPlayer _AnimationPlayer;

	private GameManager _GameManager;

	
	public override void _Ready()
	{
		_GameManager = GetNode<GameManager>(_GameManagerPath);
		_AnimationPlayer = GetNode<AnimationPlayer>(_AnimationPlayerPath);
	}
	
   private void playerBodyEntered(Node2D body)
   {
	_GameManager.AddScore();
	Console.WriteLine("Player collected a coin!");
	_AnimationPlayer.Play("pickup");


   }


}
