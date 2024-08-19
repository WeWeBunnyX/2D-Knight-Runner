using Godot;
using System;

public partial class AttackSlime : Node2D
{
    [Export]
    private NodePath _RaycastPathUp;

    [Export]
    private NodePath _RaycastPathLeft;

    [Export]
    private NodePath _RaycastPathRight;

    [Export]
    private NodePath _AnimatedSpritePath;

    [Export]
    private NodePath _TimerPath;

    [Export]
    private float speed = 40.0f; 

    private RayCast2D _RaycastUp;
    private RayCast2D _RaycastLeft;
    private RayCast2D _RaycastRight;
    private AnimatedSprite2D _AnimatedSprite;
    private Vector2 _movementDirectionRight = Vector2.Right;
    private Vector2 _movementDirectionLeft = Vector2.Left;
    private Timer _Timer;
    private Node2D _Player; 
    private bool _isChasing = false;

    public override void _Ready()
    {
        _RaycastUp = GetNode<RayCast2D>(_RaycastPathUp);
        _RaycastLeft = GetNode<RayCast2D>(_RaycastPathLeft);
        _RaycastRight = GetNode<RayCast2D>(_RaycastPathRight);
        _AnimatedSprite = GetNode<AnimatedSprite2D>(_AnimatedSpritePath);
        _Timer = GetNode<Timer>(_TimerPath);
    }

public override void _PhysicsProcess(double delta)

{

     if (_isChasing && _Player != null)

        {
            Vector2 directionToPlayer = (_Player.GlobalPosition - GlobalPosition).Normalized();
            Position += directionToPlayer * speed * (float)delta;
        }


    else
    
    {
    
    
        Position += _movementDirectionRight * (float)delta*speed;

        if (_RaycastRight.IsColliding() && _movementDirectionRight.X > 0)
         {
              FlipCast();

         }

        else if (_RaycastLeft.IsColliding() && _movementDirectionRight.X < 0)
        {
              FlipCast();
         }




    }

}

    public void FlipCast()
    
    {
        _movementDirectionRight*=-1;
        _AnimatedSprite.FlipH = !_AnimatedSprite.FlipH;


    }

    public void OnPlayerEntered(Node2D body)
    
    {

        GD.Print("Player Detected !");
        _Player = body;
        _isChasing = true;
        


    }


     public void OnPlayerExited(Node2D body)
     
     {
        GD.Print("Player Exited");
        _Player = null;
        _isChasing = false;



     }




















}


