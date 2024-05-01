using Godot;
using System;

public partial class enemyslime : Node2D
{

	[Export]                                   
    private NodePath _RaycastPath;  

	[Export] 
	private NodePath _RaycastPath2;                
    private RayCast2D _Raycast;  
	private RayCast2D _Raycast2;    

	
	public override void _Ready()
	{
		_Raycast = GetNode<RayCast2D>(_RaycastPath);  
		_Raycast2 = GetNode<RayCast2D>(_RaycastPath2);  
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	    Position += new Vector2(-1, 0);                              
	}
}
