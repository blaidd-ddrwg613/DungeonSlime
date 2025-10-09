using Microsoft.Xna.Framework;

namespace MonoGameLibrary.Input;

public class InputManager
{
    /// <summary>
    /// Get the state info for the keyboard.
    /// </summary>
    public KeyboardInfo Keyboard { get; private set; }
    
    /// <summary>
    /// Get the state info for the mouse.
    /// </summary>
    public MouseInfo Mouse { get; private set; }
    
    /// <summary>
    /// Get the state info for the gamepad.
    /// </summary>
    public GamePadInfo[] GamePads { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public InputManager()
    {
        Keyboard = new KeyboardInfo();

        Mouse = new MouseInfo();

        GamePads = new GamePadInfo[4];
        for (int i = 0; i < 4; i++)
        {
            GamePads[i] = new GamePadInfo((PlayerIndex)i);
        }
    }

    /// <summary>
    /// Updates state info for keyboard, mouse and gamePad.
    /// </summary>
    /// <param name="gameTime"></param>
    public void Update(GameTime gameTime)
    {
        Keyboard.Update();
        Mouse.Update();
        for (int i = 0; i < 4; i++)
        {
            GamePads[i].Update(gameTime);
        }
    }
}