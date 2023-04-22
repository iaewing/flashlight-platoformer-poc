using Godot;

public partial class Flashlight : Sprite2D
{
    const int FLASHLIGHT_X_OFFSET = 67;
    const int FLASHLIGHT_Y_OFFSET = 77;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //TODO: This is a magic number of the offset between player and flashlight
        Position = new Vector2(FLASHLIGHT_X_OFFSET, 0);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        //Grabs the parent aimatedsprite2d which SHOULD be the player
        var player = GetParent() as CharacterBody2D;
        //Sets the flashlight to the player's position
        // Position = player.GlobalPosition;

        //Sets the flashlight's rotation to the player's rotation
        if (player.Velocity.X > 0)
        {
            RotationDegrees = 90;
            Position = new Vector2(FLASHLIGHT_X_OFFSET, 0);
        }
        else if (player.Velocity.X < 0)
        {
            RotationDegrees = 270;
            Position = new Vector2(-FLASHLIGHT_X_OFFSET, 0);
        }
        else if (player.Velocity.Y > 0)
        {
            RotationDegrees = 180;
            Position = new Vector2(0, FLASHLIGHT_Y_OFFSET);
        }
        else if (player.Velocity.Y < 0)
        {
            RotationDegrees = 0;
            Position = new Vector2(0, -FLASHLIGHT_Y_OFFSET);
        }
    }
}
