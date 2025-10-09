﻿using Microsoft.Xna.Framework.Input;

namespace MonoGameLibrary.Input;

public class KeyboardInfo
{
    /// <summary>
    /// Store state of the keyboard from the last frame.
    /// </summary>
    public KeyboardState PreviousState { get; private set; }
    
    /// <summary>
    /// Stores the current frames keyboard state.
    /// </summary>
    public KeyboardState CurrentState { get; private set; }


    /// <summary>
    /// 
    /// </summary>
    public KeyboardInfo()
    {
        PreviousState = new KeyboardState();
        CurrentState = Keyboard.GetState();
    }

    /// <summary>
    /// Updates the state information of the keyboard
    /// </summary>
    public void Update()
    {
        PreviousState = CurrentState;
        CurrentState = Keyboard.GetState();
    }
    
    /// <summary>
    /// Returns a value that indicates if the specified key is currently down.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>true if the specified key is currently down; otherwise, false.</returns>
    public bool IsKeyDown(Keys key)
    {
        return CurrentState.IsKeyDown(key);
    }

    /// <summary>
    /// Returns a value that indicates whether the specified key is currently up.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>true if the specified key is currently up; otherwise, false.</returns>
    public bool IsKeyUp(Keys key)
    {
        return CurrentState.IsKeyUp(key);
    }

    /// <summary>
    /// Returns a value that indicates if the specified key was just pressed on the current frame.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>true if the specified key was just pressed on the current frame; otherwise, false.</returns>
    public bool WasKeyJustPressed(Keys key)
    {
        return CurrentState.IsKeyDown(key) && PreviousState.IsKeyUp(key);
    }

    /// <summary>
    /// Returns a value that indicates if the specified key was just released on the current frame.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>true if the specified key was just released on the current frame; otherwise, false.</returns>
    public bool WasKeyJustReleased(Keys key)
    {
        return CurrentState.IsKeyUp(key) && PreviousState.IsKeyDown(key);
    }

}