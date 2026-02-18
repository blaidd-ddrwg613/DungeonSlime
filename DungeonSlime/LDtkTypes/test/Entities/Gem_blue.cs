namespace LDtkTypes;

// This file was automatically generated, any modifications will be lost!
#pragma warning disable

using LDtk;
using Microsoft.Xna.Framework;

public partial class Gem_blue : ILDtkEntity
{
    public static Gem_blue Default() => new()
    {
        Identifier = "Gem_blue",
        Uid = 3,
        Size = new Vector2(64f, 64f),
        Pivot = new Vector2(0.5f, 0.5f),
        Tile = new TilesetRectangle()
        {
            X = 195,
            Y = 195,
            W = 64,
            H = 64
        },
        SmartColor = new Color(190, 74, 47, 255),
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
