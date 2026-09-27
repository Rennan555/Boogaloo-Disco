using Godot;
using System;

public abstract partial class Object : StaticBody2D
{
	private Area2D _area;
	private Label _textLabel;
	
	public override void _Ready()
	{
		_area = GetNode<Area2D>("ObjectArea");
		_textLabel = GetNode<Label>("TextLabel");
		
		Start();
	}
	
	public abstract void Start();
	public abstract void Use();
	
	public void PlayerEntered(Node2D body)
	{
		if (body is Player player)
		{
			_textLabel.Visible = true;
			player.ActionPressed += Use;
			_player = player;
		}
	}
	
	public void PlayerExited(Node2D body)
	{
		if (body is Player player)
		{
			_textLabel.Visible = false;
			player.ActionPressed -= Use;
			_player = null;
		}
	}
}
