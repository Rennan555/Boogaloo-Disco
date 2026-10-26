using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

[GlobalClass]
public partial class StateMachine : Node
{
	[Signal] public delegate void StateChangedEventHandler();

	[Export] public Node target;
	[Export] public string initialState = "IdleState";

	private Dictionary<string, State> states = null;
	private State currentState;
	
	public override void _Ready()
	{
		if (target == null)
		{
			target = GetParent();
		}

		// Children state nodes added
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

	public bool ChangeState(string stateName)
	{
		State newState = states[stateName];

		if (newState == null)
		{
			return false;
		}

		currentState.Exit();
		currentState = newState;
		currentState.Start();

		EmitSignal(SignalName.StateChanged);
		
		return true;
	}
}
