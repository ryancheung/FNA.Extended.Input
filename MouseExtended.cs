﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SDL2;

namespace FNA.Extended.Input
{
    public static class MouseExtended
    {
        // TODO: This global static state was a horrible idea.
        private static MouseState _currentMouseState;
        private static MouseState _previousMouseState;

        public static MouseStateExtended GetState()
        {
            _previousMouseState = _currentMouseState;
            _currentMouseState = Mouse.GetState();
            return new MouseStateExtended(_currentMouseState, _previousMouseState);
        }

        public static void SetPosition(int x, int y) => Mouse.SetPosition(x, y);
        public static void SetPosition(Point point) => Mouse.SetPosition(point.X, point.Y);
        public static void SetCursor(SDL.SDL_SystemCursor cursor) {
            var systemCursor = SDL.SDL_CreateSystemCursor(cursor);
             SDL.SDL_SetCursor(systemCursor);
        }

        public static IntPtr WindowHandle
        {
            get => Mouse.WindowHandle;
            set => Mouse.WindowHandle = value;
        }
    }
}