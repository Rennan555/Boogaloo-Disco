using Godot;
using System;

public partial class AudioManagement : AudioStreamPlayer2D
{
	public void PlayStream(AudioStream audio)
	{
		Stream = audio;
		Play();
	}
	
	public void StopStream()
	{
		Stop();
	}
}
