using Godot;
using System;

public abstract partial class Item : Node2D
{
	[Signal]
	public delegate void PickedUpEventHandler();
	
	[Export]
	protected String _text;
	
	protected Sprite2D _sprite;
	protected Area2D _area;
	protected Label _textLabel;
	protected Player _player;
	
	public override void _Ready()
	{
		_sprite = GetNode<Sprite2D>("ItemSprite");
		_area = GetNode<Area2D>("ItemArea");
		_textLabel = GetNode<Label>("ActionLabel");
		GD.Print(_textLabel);
		
		_textLabel.Text = _text;
		
		Enter();
	}
	
	public abstract void Enter();
	public abstract void Pick();
	
	public void PlayerEntered(Node2D body)
	{
		if (body is Player player)
		{
			_textLabel.Visible = true;
			player.ActionPressed += Pick;
			_player = player;
		}
	}
	
	public void PlayerExited(Node2D body)
	{
		if (body is Player player)
		{
			_textLabel.Visible = false;
			player.ActionPressed -= Pick;
			_player = null;
		}
	}
}
