using System;
using Microsoft.Xna.Framework;
using MonoGameGum;
using MonoGameLibrary;
using Pong.Scenes;
using Pong.Screens;

namespace Pong;

public class Game1 : Core
{
    
    GumService Gum => GumService.Default;
    public Game1() : base("Pong", 1080, 720, false){ }

    protected override void Initialize()
    {
        // We will Init Gum pointing to the gum project file
        Gum.Initialize(this, "GumProject/GumProject.gumx");
        ChangeScene(new TitleScene());
        
        base.Initialize();
    }

    protected override void LoadContent()
    {

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        GameTime = gameTime;
        
        Gum.Update(gameTime);
        
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        
        Gum.Draw();

        base.Draw(gameTime);
    }
}