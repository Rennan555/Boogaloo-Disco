using Godot;
using System;

public partial class DiscoManagement : Node
{
	[Signal]
	public delegate void PartyStartedEventHandler();
	
	public float Money = 0.0f;
	public float Reputation = 0.0f;
	public float Filth = 0.0f;
	public int TrashCount = 0;
	public bool IsParty = false;
	
	public void StartParty()
	{
		IsParty = true;
		Money += 55.5f;
		EmitSignal(SignalName.PartyStarted);
	}
}
