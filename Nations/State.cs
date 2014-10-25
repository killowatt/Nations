using System;
using SFML.Graphics;
using SFML.Window;

namespace Nations
{
    public abstract class State
    {
        protected RenderWindow renderWindow;

        public abstract void Update();
        public abstract void Render();
        public State(Game game)
        {
            renderWindow = game.renderWindow;
        }
    }
}
