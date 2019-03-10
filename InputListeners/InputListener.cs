using Microsoft.Xna.Framework;

namespace FNA.Extended.Input.InputListeners
{
    public abstract class InputListener
    {
        protected InputListener()
        {
        }

        public abstract void Update(GameTime gameTime);
    }
}