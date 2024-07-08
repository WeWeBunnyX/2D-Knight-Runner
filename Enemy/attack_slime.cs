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

    private RayCast2D _RaycastUp;
    private RayCast2D _RaycastLeft;
    private RayCast2D _RaycastRight;
    private AnimatedSprite2D _AnimatedSprite;


    public override void _Ready()
	{
		_RaycastUp= GetNode<RayCast2D>(_RaycastPathUp);
		_RaycastLeft= GetNode<RayCast2D>(_RaycastPathLeft);
		_RaycastRight= GetNode<RayCast2D>(_RaycastPathRight);
		_AnimatedSprite= GetNode<AnimatedSprite2D>(_AnimatedSpritePath);


	}


	public override void _Process(double delta)
	{
	}
}

public partial class SlimeArea: Area2D
{


	private void SlimeAreaEntered(Node2D body)
	{

		Console.WriteLine("Bruh");
	}


}