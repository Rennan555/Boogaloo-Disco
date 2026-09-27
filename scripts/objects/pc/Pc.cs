using Godot;
using System;

public partial class Pc : Object
{
	private PackedScene _packedMenu;
	
	public override void Start()
	{
		_packedMenu = GD.Load<PackedScene>("res://scenes/uis/menus/pc_menu/pc_menu.tscn");
	}
	
	public override void Use()
	{
		PcMenu PcMenuScreen = _packedMenu.Instantiate<PcMenu>();
		AddChild(PcMenuScreen);
	}
}
