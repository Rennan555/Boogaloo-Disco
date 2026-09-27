using Godot;
using System;

public partial class Trash : Item
{
	public override void _Process(double delta)
	{
	}
	
	public override void Pick()
	{
		EmitSignal(SignalName.PickedUp);
		
		QueueFree();
	}
}
