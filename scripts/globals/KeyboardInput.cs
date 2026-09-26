using Godot;
using System;

public partial class KeyboardInput : Node
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ExitGame"))
		{
			GetTree().Quit();
		}
	}
}
