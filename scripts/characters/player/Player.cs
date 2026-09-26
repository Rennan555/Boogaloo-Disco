using Godot;
using System;

public partial class Player : Character
{
	private Vector2 _direction = Vector2.Zero;
	
	public override void _Ready()
	{
	}
	
	public override void _Process(double delta)
	{
	}
	
	public override void _PhysicsProcess(double delta)
	{
		_direction = Input.GetVector("Left", "Right", "Up", "Down");
		Velocity = _direction * Speed;
		
		MoveAndSlide();
	}
}
