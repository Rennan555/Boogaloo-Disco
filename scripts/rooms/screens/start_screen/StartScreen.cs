using Godot;
using System;

public partial class StartScreen : Control
{
	[Export]
	public AudioStream BackgroundAudio;
	
	private AudioManagement _audioManager;
	
	public override void _Ready()
	{
		_audioManager = GetNode<AudioManagement>("/root/AudioManagement");
		_audioManager.PlayStream(BackgroundAudio);
	}
	
	public override void _Process(double delta)
	{
	}
}
