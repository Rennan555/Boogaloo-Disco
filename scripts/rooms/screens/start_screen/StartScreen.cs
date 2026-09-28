using Godot;
using System;

public partial class StartScreen : Control
{
	[Export]
	public AudioStream BackgroundAudio;
	
	private const String StartScenePath = "res://scenes/rooms/disco/disco.tscn";
	
	private AudioManagement _audioManager;
	
	public override void _Ready()
	{
		_audioManager = GetNode<AudioManagement>("/root/AudioManagement");
		_audioManager.PlayStream(BackgroundAudio);
	}
	
	public void StartGame()
	{
		GetTree().ChangeSceneToFile(StartScenePath);
	}
}
