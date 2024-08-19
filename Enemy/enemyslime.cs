using Godot;
using System;

public partial class enemyslime : Node2D
{
    [Export]                                   
    private NodePath _RaycastPathLeft;  

    [Export] 
    private NodePath _RaycastPathRight;       

    [Export]
	private NodePath _AnimatedSpritePath;   
    


    private RayCast2D _RaycastLeft;  
    private RayCast2D _RaycastRight;    
	private AnimatedSprite2D _AnimatedSprite;

    private Vector2 _movementDirection = Vector2.Right;           // Initial movement direction


    public override void _Ready()
    {
        _RaycastLeft = GetNode<RayCast2D>(_RaycastPathLeft);  
        _RaycastRight = GetNode<RayCast2D>(_RaycastPathRight);  
		_AnimatedSprite = GetNode<AnimatedSprite2D>(_AnimatedSpritePath);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
		
                                                                 
        Position += _movementDirection;

                                                                     
        if (_RaycastLeft.IsColliding() && _movementDirection.X < 0)
        {
                                                                       
			//GD.Print("Enemy Collided with left surface");
			_AnimatedSprite.FlipH = false;
            _movementDirection.X*= -1;
        }

        if (_RaycastRight.IsColliding() && _movementDirection.X> 0)
        {
                                                                      
			//GD.Print("Enemy Collided with right surface");
			_AnimatedSprite.FlipH = true;
            _movementDirection.X *= -1;
        }
    }
}

