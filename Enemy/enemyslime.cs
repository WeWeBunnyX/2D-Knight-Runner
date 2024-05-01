using Godot;
using System;

public partial class enemyslime : Node2D
{

	[Export]                                   
    private NodePath _RaycastPathLeft;  

	[Export] 
	private NodePath _RaycastPathRight;                
    private RayCast2D _RaycastLeft;  
	private RayCast2D _RaycastRight;    

	
	public override void _Ready()
	{
		_RaycastLeft = GetNode<RayCast2D>(_RaycastPathLeft);  
		_RaycastRight = GetNode<RayCast2D>(_RaycastPathRight);  
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	Position += new Vector2(-1, 0); 

	if (_RaycastLeft.IsColliding())
	    Position += new Vector2(-1, 0);  

	if (_RaycastRight.IsColliding())
		Position += new Vector2(1, 0);                            
	}
}
