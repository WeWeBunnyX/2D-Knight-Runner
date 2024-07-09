using Godot;
using System;

public partial class SlimeArea : Area2D
{
	[Export]
	
	private NodePath _AnimatedSprite;

	private AnimatedSprite2D AnimatedSpritePath;


	public override void _Ready()
	{
		AnimatedSpritePath= GetNode<AnimatedSprite2D>(_AnimatedSprite);
	}

	public override void _Process(double delta)
	{
	}

	private void OnPlayerEntered(Node2D body){

		//Console.WriteLine("Fullon");
		//GD.Print("Fullon");





	} 
}
