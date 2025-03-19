using Godot;
using System;

public enum DetectState { Unaware,Suspicious,Aware}

public partial class StealthDetector : Node3D
{
	// Fields
	private DetectState _currentState;
	private RayCast3D _sightLine;
	private Area3D _sightArea;

	private float _sightDistanceSquared = 25.0f;

	public DetectState CurrentState { get { return _currentState; } }


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_currentState = DetectState.Unaware;
		_sightLine = GetNode<RayCast3D>("RayCast3D");
		_sightArea = GetNode<Area3D>("Area3D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void SightCollision(Node3D body)
	{
		if (body == null) return;

		// Make sure the collision is in fact the Stealth Agent
		if(body is StealthAgent agent)
		{
			// Check the Visibility state of the agent

			// Then check if it's crouching
		}
	}

}
