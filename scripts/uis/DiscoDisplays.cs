using Godot;
using System;

public partial class DiscoDisplays : Control
{
	private const String MoneyText = "Money: ";
	private const String ReputationText = "Reputation: ";
	private const String FilthText = "Filth: ";
	
	private Label _moneyLabel;
	private Label _reputationLabel;
	private Label _filthLabel;
	private DiscoManagement _management;
	
	public override void _Ready()
	{
		_moneyLabel = GetNode<Label>("LabelsBoxContainer/MoneyLabel");
		_reputationLabel = GetNode<Label>("LabelsBoxContainer/ReputationLabel");
		_filthLabel = GetNode<Label>("LabelsBoxContainer/FilthLabel");
		_management = GetNode<DiscoManagement>("/root/DiscoManagement");
	}
	
	public override void _Process(double delta)
	{
		_moneyLabel.Text = MoneyText + _management.Money;
		_reputationLabel.Text = ReputationText + _management.Reputation;
		_filthLabel.Text = FilthText + _management.Filth;
	}
}
