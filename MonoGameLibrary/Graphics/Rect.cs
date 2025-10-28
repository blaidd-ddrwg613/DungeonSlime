using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary.Graphics;

public class Rect
{
    public Vector2 Position { get; set; } = new(0, 0);

    public new float Scale { get; set; } = 1.0f;

    public new int Width { get; set; } = 1;

    public new int Height { get; set; } = 1;

    public new Vector2 Origin { get; set; } = Vector2.Zero;

    public float Roation { get; set; } = 0.0f;

    private Texture2D _texture2D;

    private Rectangle _rectangle;

    public Rect()
    {
        _texture2D = new Texture2D(Core.GraphicsDevice, 1, 1);
        _texture2D.SetData(new[] {Color.White});
    }

    public void Draw(Color color)
    {
        _rectangle = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
        Core.SpriteBatch.Draw(_texture2D, _rectangle, color);
    }
}