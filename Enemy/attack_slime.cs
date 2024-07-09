using Godot;
using System;

public partial class attack_slime : Node2D
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

    private RayCast2D _RaycastUp;
    private RayCast2D _RaycastLeft;
    private RayCast2D _RaycastRight;
    private AnimatedSprite2D _AnimatedSprite;
	private Vector2	_movementDirection = Vector2.Right;   
	private Timer _Timer;
	private bool _IsHit= false;

    public override void _Ready()
	{
		_RaycastUp= GetNode<RayCast2D>(_RaycastPathUp);
		_RaycastLeft= GetNode<RayCast2D>(_RaycastPathLeft);
		_RaycastRight= GetNode<RayCast2D>(_RaycastPathRight);
		_AnimatedSprite= GetNode<AnimatedSprite2D>(_AnimatedSpritePath);
		_Timer= GetNode<Timer>(_TimerPath);


	}


	public override void _Process(double delta)
	{
		Position+=_movementDirection;

		if (_RaycastRight.IsColliding() && _movementDirection.X>0)
		{
			_AnimatedSprite.FlipH=true;
			_movementDirection.X*= -1;

		}

		if(_RaycastLeft.IsColliding()&& _movementDirection.X<0)
		{
			_AnimatedSprite.FlipH=false;
			_movementDirection.X*= -1;

		}
		
	}

	public override void _PhysicsProcess(double delta)
	
	{
		if(_RaycastUp.IsColliding())
		
		{

			if(!_IsHit)

			{
				_AnimatedSprite.Play("hit");
				_IsHit= true;

			}

			if(!_Timer.IsStopped())
			{
				_Timer.Stop();

			}

		}
		
		else {

			if(_IsHit && _Timer.IsStopped())
			{
				_Timer.Start(1.0f);
			
			}




		}

	

	}

	private void OnTimerTimeout()
	{
		_AnimatedSprite.Play("idle");
        _IsHit = false;
		
	}


}


