using Godot;
using System;

public partial class Player : Character
{
	[Signal]
	public delegate void ActionPressedEventHandler();
	
	private Node2D _grabbedItem;
	private Vector2 _direction = Vector2.Zero;
	
	public override void _Ready()
	{
		_grabbedItem = GetNode<Node2D>("GrabbedItemNode");
	}
	
	public override void _Process(double delta)
	{
		ActionPress();
	}
	
	public override void _PhysicsProcess(double delta)
	{
		_direction = Input.GetVector("Left", "Right", "Up", "Down");
		Velocity = _direction * Speed;
		
		MoveAndSlide();
	}
	
	private void ActionPress()
	{
		if (Input.IsActionJustPressed("Action"))
		{
			EmitSignal(SignalName.ActionPressed);
		}
	}
	
	public void AddGrabbedItem(Item item)
	{
		_grabbedItem.Visible = true;
		item.Position = Vector2.Zero;
		
		_grabbedItem.AddChild(item);
	}
}
