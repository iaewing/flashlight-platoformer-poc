using Godot;

public partial class Flashlight : Sprite2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //TODO: This is a magic number of the offset between player and flashlight
        Position = new Vector2(67, 0);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        //Grabs the parent aimatedsprite2d which SHOULD be the player
        var player = GetParent() as CharacterBody2D;
        //Sets the flashlight to the player's position
        // Position = player.GlobalPosition;

        GD.Print("player: " + player);
        GD.Print("player velocity: " + player.Velocity.X + ',' + player.Velocity.Y);

        //Sets the flashlight's rotation to the player's rotation
        if (player.Velocity.X > 0)
        {
            RotationDegrees = 90;
        }
        else if (player.Velocity.X < 0)
        {
            RotationDegrees = 180;
        }
        else if (player.Velocity.Y > 0)
        {
            Rotation = 90;
        }
        else if (player.Velocity.Y < 0)
        {
            Rotation = 270;
        }
        GD.Print("flashlight rotation: " + Rotation);
    }
}
