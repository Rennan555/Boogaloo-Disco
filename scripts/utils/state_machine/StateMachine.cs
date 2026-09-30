using Godot;
using System;

[GlobalClass]
public partial class StateMachine : Node
{
	[Export]
	public Node target;
	
	public override void _Ready()
	{
		if (target == null)
		{
			target = GetParent();
		}
	}
	
	public override void _Process(double delta)
	{
	}
}
