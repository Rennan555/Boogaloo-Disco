using Godot;
using System;

public partial class Player : Character
{
	[Signal]
	public delegate void ActionPressedEventHandler();
	
	private Vector2 _direction = Vector2.Zero;
	
	public override void _Process(double delta)
	{
		ActionPress();
	}
	
	public override void _PhysicsProcess(double delta)
	{
		_direction = Input.GetVector("Left", "Right", "Up", "Down");
		Velocity = _direction * Speed;
		
		MoveAndSlide();
	}
	
	private void ActionPress()
	{
		if (Input.IsActionPressed("Action"))
		{
			EmitSignal(SignalName.ActionPressed);
		}
	}
}
