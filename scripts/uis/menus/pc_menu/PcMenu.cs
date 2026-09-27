using Godot;
using System;

public partial class PcMenu : Menu
{
	public void StartParty()
	{
		_manager.StartParty();
		QueueFree();
	}
}
