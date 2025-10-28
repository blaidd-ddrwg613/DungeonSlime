using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;
using MonoGameLibrary.Scenes;

namespace Pong.Scenes;

public class GameScene : Scene
{

    private Rect _rect;

    public override void Initialize()
    {
        base.Initialize();

        _rect = new Rect
        {
            Position = new Vector2(1,1),
            Scale = default,
            Width = 100,
            Height = 100,
            Origin = default,
            Roation = default
        };

        Core.ExitOnEscape = false;
    }

    public override void LoadContent()
    {
        base.LoadContent();
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (Core.Input.Keyboard.IsKeyDown(Keys.Escape))
        {
            Core.ChangeScene(new TitleScene());
        }
    }

    public override void Draw(GameTime gameTime)
    {
        // Clear the back buffer.
        Core.GraphicsDevice.Clear(Color.CornflowerBlue);

        // Begin the sprite batch to prepare for rendering.
        Core.SpriteBatch.Begin(samplerState: SamplerState.PointClamp);
        
        _rect.Draw(Color.Purple);

        // Always end the sprite batch when finished.
        Core.SpriteBatch.End();
    }
}