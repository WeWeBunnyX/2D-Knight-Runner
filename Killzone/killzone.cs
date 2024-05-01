using Godot;
using System;

public partial class killzone : Area2D
{

 [Export]
private Node timer;
private void OnBodyEntered(Node2D body) 
{
Console.WriteLine("You died!");
}











}
