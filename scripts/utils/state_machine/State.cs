using Godot;
using System;

public abstract partial class State : Node
{
    public abstract void Start();
    public abstract void Update(double delta);
    public abstract void PhysicsUpdate(double delta);
    public abstract void Exit();
}
