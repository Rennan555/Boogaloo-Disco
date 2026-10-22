using Godot;
using System;
using System.Collections.Generic;

[GlobalClass]
public partial class StateMachine : Node
{
	[Export] public Node target;
	[Export] public string initialState = "IdleState";

	private Dictionary<string, State> states;
	private State currentState;
	
	public override void _Ready()
	{
		if (target == null)
		{
			target = GetParent();
		}

		foreach (Node child in GetChildren())
		{
			if (child is State state)
			{
				states.Add(state.Name.ToString(), state);
			}
		}

		currentState = states[initialState];
		currentState.Start();
	}
	
	public override void _Process(double delta)
	{
		if (!hasCurrentState())
		{
			return;
		}

		currentState.Update(delta);
	}

	public override void _PhysicsProcess(double delta)
	{
		if (!hasCurrentState())
		{
			return;
		}

		currentState.PhysicsUpdate(delta);
	}

	private bool hasCurrentState()
	{
		return currentState != null;
	}
}
