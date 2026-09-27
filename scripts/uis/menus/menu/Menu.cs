using Godot;
using System;

public partial class Menu : Control
{
	[Export]
	public String Title = "Menu";
	
	protected DiscoManagement _manager;
	private Label _titleLabel;
	
	public override void _Ready()
	{
		_manager = GetNode<DiscoManagement>("/root/DiscoManagement");
		_titleLabel = GetNode<Label>("MenuNinePatchRect/MenuVBoxContainer/TitleLabel");
		_titleLabel.Text = Title;
	}
	
	public void Close()
	{
		QueueFree();
	}
}
