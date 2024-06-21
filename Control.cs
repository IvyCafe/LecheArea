using Godot;
using System;

public partial class Control : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	float amount;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Moving speed
		if (Input.IsKeyPressed(Key.Shift))
			amount = 10;
		else
			amount = 5;

		// Move the godot icon
		if (Input.IsKeyPressed(Key.W))
			Position += new Vector2(0, -amount);
		if (Input.IsKeyPressed(Key.A))
			Position += new Vector2(-amount, 0);
		if (Input.IsKeyPressed(Key.S))
			Position += new Vector2(0, amount);
		if (Input.IsKeyPressed(Key.D))
			Position += new Vector2(amount, 0);
	}
}
