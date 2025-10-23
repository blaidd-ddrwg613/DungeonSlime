using Microsoft.Xna.Framework;
using MonoGameGum;
using MonoGameLibrary.Scenes;
using Pong.Screens;

namespace Pong.Scenes;

public class TitleScene : Scene
{
    private TitleScreen _titleScreen;

    public override void Initialize()
    {
        base.Initialize();

        _titleScreen = new TitleScreen();
        _titleScreen.AddToRoot();
    }
}