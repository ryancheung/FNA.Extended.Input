﻿using Microsoft.Xna.Framework.Input;

namespace FNA.Extended.Input
{
    public static class KeyboardExtended
    {
        // TODO: This global static state was a horrible idea.
        private static KeyboardState _currentKeyboardState;
        private static KeyboardState _previousKeyboardState;

        public static KeyboardStateExtended GetState()
        {
            _previousKeyboardState = _currentKeyboardState;
            _currentKeyboardState = Keyboard.GetState();
            return new KeyboardStateExtended(_currentKeyboardState, _previousKeyboardState);
        }
    }
}