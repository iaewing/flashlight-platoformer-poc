using Godot;

public partial class Flashlight : Sprite2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //Grabs the parent aimatedsprite2d which SHOULD be the player
        var player = GetParent() as CharacterBody2D;
        //Sets the flashlight to the player's position
        Position = new Vector2(67, 0);
    }

        // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        //Grabs the parent aimatedsprite2d which SHOULD be the player
        var player = GetParent() as CharacterBody2D;
        //Sets the flashlight to the player's position
        // Position = player.GlobalPosition;

        GD.Print("player velocity: " + player.Velocity);
        GD.Print("player position: " + player.GlobalPosition);
        GD.Print("flashlight position: " + this.Position);

        //Sets the flashlight's rotation to the player's rotation
        if (player.Velocity.X > 0)
        {
            this.FlipV = false;
        }
        else if (player.Velocity.X < 0)
        {
            Rotation = 180;
        }
        else if (player.Velocity.Y > 0)
        {
            Rotation = 90;
        }
        else if (player.Velocity.Y < 0)
        {
            Rotation = 270;
        }
    }
}
