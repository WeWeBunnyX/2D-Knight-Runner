using Godot;
using System;

public partial class SlimeArea : Area2D
{
    [Export]
    private NodePath _AttackSlimePath; // Reference to the attack_slime node

    private attack_slime _AttackSlime;

    public override void _Ready()
    {
        _AttackSlime = GetNode<attack_slime>(_AttackSlimePath);

    }

    private void OnPlayerEntered(Node2D body)
    {
        if (body.IsInGroup("player")) // Assuming the player is in the "Player" group
        {
            GD.Print("Player Entered Detection Area");
            
        }
    }

    private void OnPlayerExited(Node2D body)
    {
        if (body.IsInGroup("player"))
        {
            GD.Print("Player Exited Detection Area");

        }
    }
}
