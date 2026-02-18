namespace LDtkTypes;

// This file was automatically generated, any modifications will be lost!
#pragma warning disable

using LDtk;
using Microsoft.Xna.Framework;

public partial class Player_start : ILDtkEntity
{
    public static Player_start Default() => new()
    {
        Identifier = "Player_start",
        Uid = 5,
        Size = new Vector2(64f, 64f),
        Pivot = new Vector2(0f, 0f),
        SmartColor = new Color(99, 199, 77, 255),
    };

    public string Identifier { get; set; }
    public System.Guid Iid { get; set; }
    public int Uid { get; set; }
    public Vector2 Position { get; set; }
    public Vector2 Size { get; set; }
    public Vector2 Pivot { get; set; }
    public Rectangle Tile { get; set; }

    public Color SmartColor { get; set; }
}
#pragma warning restore
