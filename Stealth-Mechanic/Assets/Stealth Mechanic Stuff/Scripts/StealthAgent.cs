using Godot;
using System;

public partial class StealthAgent : Node3D
{
	// Visibility state is used by the agent to be more or less visibile
	// Ranges from 1 to 5
	private int _visibilityLevel;
	private bool _crouching;

	public int VisibilityLevel { get { return _visibilityLevel; } set { _visibilityLevel = value; } }
	public bool IsCrouching {  get { return _crouching; } }

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_visibilityLevel = 0;
		_crouching = false;

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Make sure the visibility level is within range
		if(_visibilityLevel <  1) _visibilityLevel = 1;
		if(_visibilityLevel > 5) _visibilityLevel = 5;
		_checkInput();
	}
	
	private void _checkInput()
	{
		// Check if we started crouching/sneaking (it's a toggle)
		if (Input.IsActionJustPressed("Sneak"))
		{
			_crouching = !_crouching;
		}

		// see if we changed the visbility state
		if (Input.IsActionJustPressed("Visibility1"))
		{
			_visibilityLevel = 1;
			GD.Print($"Visibility level {_visibilityLevel}");
		}
		else if (Input.IsActionJustPressed("Visibility2"))
		{
			_visibilityLevel = 2;
            GD.Print($"Visibility level {_visibilityLevel}");
        }
		else if (Input.IsActionJustPressed("Visibility3"))
		{
			_visibilityLevel = 3;
            GD.Print($"Visibility level {_visibilityLevel}");
        }
		else if (Input.IsActionJustPressed("Visibility4"))
		{
			_visibilityLevel = 4;
            GD.Print($"Visibility level {_visibilityLevel}");
        }
		else if (Input.IsActionJustPressed("Visibility5"))
		{
			_visibilityLevel = 5;
            GD.Print($"Visibility level {_visibilityLevel}");
        }

		// Room for extra input shenaigans
	}
	/// <summary>
	/// Method used by non-agent classes, such as Detector
	/// </summary>
	/// <returns> Returns the VisibilityLevel of the Agent</returns>
	public int GetVisibilityLevel()
	{
		return _visibilityLevel;
	}
}
