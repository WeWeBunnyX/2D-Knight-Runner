using Godot;
using System;

public partial class SlimeArea : Area2D
{
	public override void _Ready()
	{
	}
	public override void _Process(double delta)
	{
	}

	private void OnPlayerEntered(Node2D body){

		Console.WriteLine("Fullon");
		GD.Print("Fullon");





	} 
}
