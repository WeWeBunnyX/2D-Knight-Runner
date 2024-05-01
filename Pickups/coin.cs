using Godot;
using System;

public partial class coin : Area2D
{

   private void playerBodyEntered(Node2D body)
   {
    
	Console.WriteLine("Player collected a coin!");
	QueueFree();


   }



























	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


    












}
