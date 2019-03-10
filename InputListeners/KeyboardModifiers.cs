using System;

namespace FNA.Extended.Input.InputListeners
{
    [Flags]
    public enum KeyboardModifiers
    {
        Control = 1,
        Shift = 2,
        Alt = 4,
        None = 0
    }
}