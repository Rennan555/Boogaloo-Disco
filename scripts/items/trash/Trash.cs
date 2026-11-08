using Godot;
using System;

public partial class Trash : Item
{
	[Export]
	public float FilthValue;
	
	private DiscoManagement _dissco_manager;
	
	public override void Enter()
	{
		_dissco_manager = GetNode<DiscoManagement>("/root/DiscoManagement");
		
		_dissco_manager.Filth += FilthValue;
		_dissco_manager.TrashCount ++;
	}
	
	public override void Pick()
	{
		EmitSignal(SignalName.PickedUp);
		
		_player.AddGrabbedItem((Item)Duplicate());
		_dissco_manager.Filth -= FilthValue;
		QueueFree();
	}
}
