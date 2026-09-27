using Godot;
using System;

public partial class Pc : Object
{
	private PackedScene _packedMenu;
	
	public override void Start()
	{
		_packedMenu = GD.Load<PackedScene>("res://scenes/uis/menus/menu/menu.tscn");
	}
	
	public override void Use()
	{
		Menu PcMenu = _packedMenu.Instantiate<Menu>();
		AddChild(PcMenu);
	}
}
