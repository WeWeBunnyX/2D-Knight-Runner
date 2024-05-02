using Godot;
using System;

public partial class killzone : Area2D
{
    [Export]                                      //Export needed to expose the variable to the editor.
    private NodePath _timerPath;                  //Path to the Timer node.
    private Timer _timer;                         //Reference to the Timer node.

    public override void _Ready()                 //Called when the node enters the scene tree for the first time.
    {
        _timer = GetNode<Timer>(_timerPath);      //Get the Timer node.
    }

    private void OnBodyEntered(Node2D body)        //Called when a body enters the Area2D.
    {
        Console.WriteLine("You died!");  
        Engine.TimeScale = 0.5;                      //Pause the game.         
        _timer.Start();                            //Start the Timer.
    }

    private void OnTimerTimeout()
    {   
        Engine.TimeScale = 1; 
        GetTree().ReloadCurrentScene();             //Reload the current scene.
    }
}
