using Godot;
using System;

public partial class player : CharacterBody2D
{

	[Export]
	public NodePath _AnimatedSpritePath;
	private AnimatedSprite2D _AnimatedSprite;

	public const float Speed = 150.0f;
	public const float JumpVelocity = -300.0f;

	public override void _Ready()
	{
		_AnimatedSprite = GetNode<AnimatedSprite2D>(_AnimatedSpritePath);
	}

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;

		// Handle Jump.
		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
			velocity.Y = JumpVelocity;


		if (velocity.Y < 0)
		{
			_AnimatedSprite.Play("jump");
		}
		else if (velocity.X != 0)
		{
			_AnimatedSprite.Play("run");
		}
		else
		{
			_AnimatedSprite.Play("idle");
		}

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");

		if (direction != Vector2.Zero && Input.IsActionPressed("ui_left")) 
		{  
			_AnimatedSprite.FlipH = true;
			velocity.X = direction.X * Speed;
		}

		else if (direction != Vector2.Zero && Input.IsActionPressed("ui_right")) 
		{
			_AnimatedSprite.FlipH = false;
			velocity.X = direction.X * Speed;
		}

		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
