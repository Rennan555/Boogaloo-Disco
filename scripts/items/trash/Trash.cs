using Godot;
using System;

public partial class Trash : Item
{
	[Export]
	public float FilthValue;
	
	private DiscoManagement _manager;
	
	public override void Enter()
	{
		_manager = GetNode<DiscoManagement>("/root/DiscoManagement");
		
		_manager.Filth += FilthValue;
		_manager.TrashCount ++;
	}
	
	public override void Pick()
	{
		EmitSignal(SignalName.PickedUp);
		
		_player.AddGrabbedItem((Item)Duplicate());
		QueueFree();
	}
}
