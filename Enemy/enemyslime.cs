using Godot;
using System;

public partial class enemyslime : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	    Position += new Vector2(-1, 0);                        // this actually moves the sprite           
	}
}
