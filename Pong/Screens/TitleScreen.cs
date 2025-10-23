

using System;
using Microsoft.Xna.Framework;
using MonoGameLibrary;
using MonoGameLibrary.Primatives;
using Pong.Scenes;

namespace Pong.Screens
{
    partial class TitleScreen
    {
        partial void CustomInitialize()
        {
            Start.Click += OnStartClicked;
            Options.Click += OnOptionsClicked;
            Quit.Click += OnQuitClicked;

        }

        private void OnQuitClicked(object sender, EventArgs e)
        {
            Core.Instance.Exit();
        }

        private void OnOptionsClicked(object sender, EventArgs e)
        {
            Square square = new Square();
            square.PrintPath();
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
           Core.ChangeScene(new GameScene());
        }
    }
}


