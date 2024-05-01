using Godot;
using System;

public partial class killzone : Area2D
{
    [Export]
    private NodePath _timerPath;
    private Timer _timer;

    public override void _Ready()
    {
        _timer = GetNode<Timer>(_timerPath);
    }

    private void OnBodyEntered(Node2D body)
    {
        Console.WriteLine("You died!");
        _timer.Start();
    }

    private void OnTimerTimeout()
    {
        GetTree().ReloadCurrentScene();
    }
}
