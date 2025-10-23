using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;
using MonoGameLibrary.Scenes;

namespace Pong.Scenes;

public class GameScene : Scene
{
    private Sprite _square;

    private Vector2 _pos = new Vector2(50, 50);

    public override void Initialize()
    {
        base.Initialize();

        Core.ExitOnEscape = false;
    }

    public override void LoadContent()
    {
        base.LoadContent();

        Texture2D squareTexture = Content.Load<Texture2D>("textures/square");
        TextureRegion textureRegion = new TextureRegion(squareTexture, 0, 0, squareTexture.Width, squareTexture.Height);

        _square = new Sprite(textureRegion);
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
        
        _square.Draw(Core.SpriteBatch, _pos);

        // Always end the sprite batch when finished.
        Core.SpriteBatch.End();
    }
}