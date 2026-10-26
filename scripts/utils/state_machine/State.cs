using Godot;
using System;

public abstract partial class State : Node
{
    // It is expected that this var instatiate the StateMachine that contains the State
    protected StateMachine stateMachine;

    public abstract void Start();
    public abstract void Update(double delta);
    public abstract void PhysicsUpdate(double delta);
    public abstract void Exit();
}
