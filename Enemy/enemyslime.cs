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
	// code to move character left by one pixel every frame
		//Position = Position with { X = 150.0f };            This code only moves sprite to a fixed place immediately, no motion or movement involved.
      
	    Position += new Vector2(-1, 0);                        // this actually moves the sprite                   


	}
}
