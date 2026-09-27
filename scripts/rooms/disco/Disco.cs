using Godot;
using System;

public partial class Disco : Node2D
{
	private DiscoManagement _manager;
	private ColorRect _rect;
	
	public override void _Ready()
	{
		_manager = GetTree().Root.GetNode<DiscoManagement>("DiscoManagement");
		_rect = GetNode<ColorRect>("UiLayer/ColorRect");
		
		_manager.PartyStarted += TweenRectColors;
	}
	
	public void TweenRectColors()
	{
		if (!_manager.IsParty)
		{
			return;
		}
		
		Tween tween = CreateTween();
		
		tween.TweenProperty(
			_rect,
			"color",
			new Color(1, 0, 0, 0.3f),
			0.5
		);
		
		tween.TweenProperty(
			_rect,
			"color",
			new Color(0, 1, 0, 0.3f),
			0.5
		);
		
		tween.TweenProperty(
			_rect,
			"color",
			new Color(0, 0, 1, 0.3f),
			0.5
		);
		
		tween.TweenCallback(Callable.From(TweenRectColors));
	}
}
